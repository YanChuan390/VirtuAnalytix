using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;
using MEC;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class I360Render
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000002")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000003")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x4000004")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x144E350", Offset = "0x144E350", VA = "0x144E350")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x144EAD0", Offset = "0x144EAD0", VA = "0x144EAD0")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x144EA18", Offset = "0x144EA18", VA = "0x144EA18")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x144EB8C", Offset = "0x144EB8C", VA = "0x144EB8C")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x144F4C0", Offset = "0x144F4C0", VA = "0x144F4C0")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x144F304", Offset = "0x144F304", VA = "0x144F304")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x144F478", Offset = "0x144F478", VA = "0x144F478")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x144EF78", Offset = "0x144EF78", VA = "0x144EF78")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x144F5A4", Offset = "0x144F5A4", VA = "0x144F5A4")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x144F8F4", Offset = "0x144F8F4", VA = "0x144F8F4")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x144F7E4", Offset = "0x144F7E4", VA = "0x144F7E4")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x144F9EC", Offset = "0x144F9EC", VA = "0x144F9EC")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x84B150", Offset = "0x84B150")]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private readonly IDictionary<TKey, TValue> _dictionary;

	[Token(Token = "0x17000001")]
	public ICollection<TKey> Keys
	{
		[Token(Token = "0x6000011")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public ICollection<TValue> Values
	{
		[Token(Token = "0x6000014")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public TValue Item
	{
		[Token(Token = "0x6000015")]
		get
		{
			return (TValue)null;
		}
	}

	[Token(Token = "0x17000004")]
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item
	{
		[Token(Token = "0x6000016")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x6000017")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public int Count
	{
		[Token(Token = "0x600001C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public bool IsReadOnly
	{
		[Token(Token = "0x600001D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000E")]
	public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
	{
	}

	[Token(Token = "0x600000F")]
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value)
	{
	}

	[Token(Token = "0x6000010")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	public bool TryGetValue(TKey key, out TValue value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000018")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item)
	{
	}

	[Token(Token = "0x6000019")]
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear()
	{
	}

	[Token(Token = "0x600001A")]
	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x600001E")]
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		return default(bool);
	}

	[Token(Token = "0x600001F")]
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	private static Exception ReadOnlyException()
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class MECExtensionMethods2
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BBF4", Offset = "0x84BBF4")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700008C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1190DE0", Offset = "0x1190DE0", VA = "0x1190DE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1190E48", Offset = "0x1190E48", VA = "0x1190E48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x118F278", Offset = "0x118F278", VA = "0x118F278")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1190C30", Offset = "0x1190C30", VA = "0x1190C30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1190C34", Offset = "0x1190C34", VA = "0x1190C34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1190DE8", Offset = "0x1190DE8", VA = "0x1190DE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC04", Offset = "0x84BC04")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700008E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1191038", Offset = "0x1191038", VA = "0x1191038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x11910A0", Offset = "0x11910A0", VA = "0x11910A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x118F320", Offset = "0x118F320", VA = "0x118F320")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1190EAC", Offset = "0x1190EAC", VA = "0x1190EAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1190EB0", Offset = "0x1190EB0", VA = "0x1190EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1191040", Offset = "0x1191040", VA = "0x1191040", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC14", Offset = "0x84BC14")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000090")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000681")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000091")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000683")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600067E")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600067F")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000680")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC24", Offset = "0x84BC24")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000092")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1191284", Offset = "0x1191284", VA = "0x1191284", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000093")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x11912EC", Offset = "0x11912EC", VA = "0x11912EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x118F3CC", Offset = "0x118F3CC", VA = "0x118F3CC")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1191104", Offset = "0x1191104", VA = "0x1191104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1191108", Offset = "0x1191108", VA = "0x1191108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x119128C", Offset = "0x119128C", VA = "0x119128C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC34", Offset = "0x84BC34")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000094")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1190558", Offset = "0x1190558", VA = "0x1190558", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000095")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x11905C0", Offset = "0x11905C0", VA = "0x11905C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x118F474", Offset = "0x118F474", VA = "0x118F474")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1190334", Offset = "0x1190334", VA = "0x1190334", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1190338", Offset = "0x1190338", VA = "0x1190338", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1190560", Offset = "0x1190560", VA = "0x1190560", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC44", Offset = "0x84BC44")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x17000096")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1190888", Offset = "0x1190888", VA = "0x1190888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000097")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x11908F0", Offset = "0x11908F0", VA = "0x11908F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x118F524", Offset = "0x118F524", VA = "0x118F524")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1190624", Offset = "0x1190624", VA = "0x1190624", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1190628", Offset = "0x1190628", VA = "0x1190628", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1190890", Offset = "0x1190890", VA = "0x1190890", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC54", Offset = "0x84BC54")]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000098")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000699")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600069B")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000696")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000697")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000698")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600069A")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC64", Offset = "0x84BC64")]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009A")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1190B64", Offset = "0x1190B64", VA = "0x1190B64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1190BCC", Offset = "0x1190BCC", VA = "0x1190BCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x118F5CC", Offset = "0x118F5CC", VA = "0x118F5CC")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1190954", Offset = "0x1190954", VA = "0x1190954", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1190958", Offset = "0x1190958", VA = "0x1190958", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1190B6C", Offset = "0x1190B6C", VA = "0x1190B6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC74", Offset = "0x84BC74")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009C")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1191CE8", Offset = "0x1191CE8", VA = "0x1191CE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1191D50", Offset = "0x1191D50", VA = "0x1191D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x118F674", Offset = "0x118F674", VA = "0x118F674")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1191AB8", Offset = "0x1191AB8", VA = "0x1191AB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1191ABC", Offset = "0x1191ABC", VA = "0x1191ABC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1191CF0", Offset = "0x1191CF0", VA = "0x1191CF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC84", Offset = "0x84BC84")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009E")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1192024", Offset = "0x1192024", VA = "0x1192024", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x119208C", Offset = "0x119208C", VA = "0x119208C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x118F724", Offset = "0x118F724", VA = "0x118F724")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1191DB4", Offset = "0x1191DB4", VA = "0x1191DB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1191DB8", Offset = "0x1191DB8", VA = "0x1191DB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x119202C", Offset = "0x119202C", VA = "0x119202C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BC94", Offset = "0x84BC94")]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x170000A0")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006B1")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B3")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AE")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x60006AF")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B0")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCA4", Offset = "0x84BCA4")]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000A2")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x11919EC", Offset = "0x11919EC", VA = "0x11919EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x1191A54", Offset = "0x1191A54", VA = "0x1191A54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x118F7CC", Offset = "0x118F7CC", VA = "0x118F7CC")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x11917DC", Offset = "0x11917DC", VA = "0x11917DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x11917E0", Offset = "0x11917E0", VA = "0x11917E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x11919F4", Offset = "0x11919F4", VA = "0x11919F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCB4", Offset = "0x84BCB4")]
	private sealed class <KillWith>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CoroutineHandle otherCoroutine;

		[Token(Token = "0x170000A4")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1191710", Offset = "0x1191710", VA = "0x1191710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1191778", Offset = "0x1191778", VA = "0x1191778", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x118F878", Offset = "0x118F878", VA = "0x118F878")]
		[DebuggerHidden]
		public <KillWith>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x11915AC", Offset = "0x11915AC", VA = "0x11915AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x11915B0", Offset = "0x11915B0", VA = "0x11915B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1191718", Offset = "0x1191718", VA = "0x1191718", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCC4", Offset = "0x84BCC4")]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x170000A6")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1190038", Offset = "0x1190038", VA = "0x1190038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x11900A0", Offset = "0x11900A0", VA = "0x11900A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x118F920", Offset = "0x118F920", VA = "0x118F920")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x118FDC4", Offset = "0x118FDC4", VA = "0x118FDC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x118FDC8", Offset = "0x118FDC8", VA = "0x118FDC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1190040", Offset = "0x1190040", VA = "0x1190040", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCD4", Offset = "0x84BCD4")]
	private sealed class <Append>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x170000A8")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1190268", Offset = "0x1190268", VA = "0x1190268", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x11902D0", Offset = "0x11902D0", VA = "0x11902D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x118F9C8", Offset = "0x118F9C8", VA = "0x118F9C8")]
		[DebuggerHidden]
		public <Append>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1190104", Offset = "0x1190104", VA = "0x1190104", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1190108", Offset = "0x1190108", VA = "0x1190108", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1190270", Offset = "0x1190270", VA = "0x1190270", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCE4", Offset = "0x84BCE4")]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000AA")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1192378", Offset = "0x1192378", VA = "0x1192378", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x11923E0", Offset = "0x11923E0", VA = "0x11923E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x118FA70", Offset = "0x118FA70", VA = "0x118FA70")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x11920F0", Offset = "0x11920F0", VA = "0x11920F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x11920F4", Offset = "0x11920F4", VA = "0x11920F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1192380", Offset = "0x1192380", VA = "0x1192380", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BCF4", Offset = "0x84BCF4")]
	private sealed class <Prepend>d__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000AC")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x11925B8", Offset = "0x11925B8", VA = "0x11925B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AD")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1192620", Offset = "0x1192620", VA = "0x1192620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x118FB18", Offset = "0x118FB18", VA = "0x118FB18")]
		[DebuggerHidden]
		public <Prepend>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1192444", Offset = "0x1192444", VA = "0x1192444", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1192448", Offset = "0x1192448", VA = "0x1192448", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x11925C0", Offset = "0x11925C0", VA = "0x11925C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD04", Offset = "0x84BD04")]
	private sealed class <Superimpose>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x170000AE")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1192F50", Offset = "0x1192F50", VA = "0x1192F50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1192FB8", Offset = "0x1192FB8", VA = "0x1192FB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x118FC48", Offset = "0x118FC48", VA = "0x118FC48")]
		[DebuggerHidden]
		public <Superimpose>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x119293C", Offset = "0x119293C", VA = "0x119293C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1192940", Offset = "0x1192940", VA = "0x1192940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1192F58", Offset = "0x1192F58", VA = "0x1192F58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD14", Offset = "0x84BD14")]
	private sealed class <Hijack>d__19 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000B0")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x11914E0", Offset = "0x11914E0", VA = "0x11914E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1191548", Offset = "0x1191548", VA = "0x1191548", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x118FCF0", Offset = "0x118FCF0", VA = "0x118FCF0")]
		[DebuggerHidden]
		public <Hijack>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1191350", Offset = "0x1191350", VA = "0x1191350", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1191354", Offset = "0x1191354", VA = "0x1191354", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x11914E8", Offset = "0x11914E8", VA = "0x11914E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD24", Offset = "0x84BD24")]
	private sealed class <RerouteExceptions>d__20 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<Exception> exceptionHandler;

		[Token(Token = "0x170000B2")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1192870", Offset = "0x1192870", VA = "0x1192870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x11928D8", Offset = "0x11928D8", VA = "0x11928D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x118FD98", Offset = "0x118FD98", VA = "0x118FD98")]
		[DebuggerHidden]
		public <RerouteExceptions>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1192684", Offset = "0x1192684", VA = "0x1192684", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1192688", Offset = "0x1192688", VA = "0x1192688", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1192878", Offset = "0x1192878", VA = "0x1192878", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x118F1F8", Offset = "0x118F1F8", VA = "0x118F1F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852AAC", Offset = "0x852AAC")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x118F2A4", Offset = "0x118F2A4", VA = "0x118F2A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852B20", Offset = "0x852B20")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852B94", Offset = "0x852B94")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x118F34C", Offset = "0x118F34C", VA = "0x118F34C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852C08", Offset = "0x852C08")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x118F3F8", Offset = "0x118F3F8", VA = "0x118F3F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852C7C", Offset = "0x852C7C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x118F4A0", Offset = "0x118F4A0", VA = "0x118F4A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852CF0", Offset = "0x852CF0")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852D64", Offset = "0x852D64")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x118F550", Offset = "0x118F550", VA = "0x118F550")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852DD8", Offset = "0x852DD8")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x118F5F8", Offset = "0x118F5F8", VA = "0x118F5F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852E4C", Offset = "0x852E4C")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x118F6A0", Offset = "0x118F6A0", VA = "0x118F6A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852EC0", Offset = "0x852EC0")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852F34", Offset = "0x852F34")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x118F750", Offset = "0x118F750", VA = "0x118F750")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x852FA8", Offset = "0x852FA8")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x118F7F8", Offset = "0x118F7F8", VA = "0x118F7F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85301C", Offset = "0x85301C")]
	public static IEnumerator<float> KillWith(this IEnumerator<float> coroutine, CoroutineHandle otherCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x118F8A4", Offset = "0x118F8A4", VA = "0x118F8A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853090", Offset = "0x853090")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x118F94C", Offset = "0x118F94C", VA = "0x118F94C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853104", Offset = "0x853104")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x118F9F4", Offset = "0x118F9F4", VA = "0x118F9F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853178", Offset = "0x853178")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x118FA9C", Offset = "0x118FA9C", VA = "0x118FA9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8531EC", Offset = "0x8531EC")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x118FB44", Offset = "0x118FB44", VA = "0x118FB44")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x118FBC4", Offset = "0x118FBC4", VA = "0x118FBC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853270", Offset = "0x853270")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x118FC74", Offset = "0x118FC74", VA = "0x118FC74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8532E4", Offset = "0x8532E4")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x118FD1C", Offset = "0x118FD1C", VA = "0x118FD1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853358", Offset = "0x853358")]
	public static IEnumerator<float> RerouteExceptions(this IEnumerator<float> coroutine, Action<Exception> exceptionHandler)
	{
		return null;
	}
}
namespace MEC
{
	[Token(Token = "0x2000005")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x2000094")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x8FD564", Offset = "0x8FD564", VA = "0x8FD564", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x8FD58C", Offset = "0x8FD58C", VA = "0x8FD58C", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x118F198", Offset = "0x118F198", VA = "0x118F198")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x118F1B8", Offset = "0x118F1B8", VA = "0x118F1B8")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x8FD594", Offset = "0x8FD594", VA = "0x8FD594", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD34", Offset = "0x84BD34")]
		private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x170000B4")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006F2")]
				[Address(RVA = "0x118E114", Offset = "0x118E114", VA = "0x118E114", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x118E17C", Offset = "0x118E17C", VA = "0x118E17C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x118E054", Offset = "0x118E054", VA = "0x118E054")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x118E080", Offset = "0x118E080", VA = "0x118E080", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x118E084", Offset = "0x118E084", VA = "0x118E084", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x118E11C", Offset = "0x118E11C", VA = "0x118E11C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD44", Offset = "0x84BD44")]
		private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Timing <>4__this;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x118DFE4", Offset = "0x118DFE4", VA = "0x118DFE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x118E04C", Offset = "0x118E04C", VA = "0x118E04C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x118D804", Offset = "0x118D804", VA = "0x118D804")]
			[DebuggerHidden]
			public <_EOFPump>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x118D830", Offset = "0x118D830", VA = "0x118D830", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x118D834", Offset = "0x118D834", VA = "0x118D834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x118DFEC", Offset = "0x118DFEC", VA = "0x118DFEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD54", Offset = "0x84BD54")]
		private sealed class <_StartWhenDone>d__272 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000B8")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x118E7B0", Offset = "0x118E7B0", VA = "0x118E7B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x118E818", Offset = "0x118E818", VA = "0x118E818", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x118E400", Offset = "0x118E400", VA = "0x118E400")]
			[DebuggerHidden]
			public <_StartWhenDone>d__272(int <>1__state)
			{
			}

			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x118E42C", Offset = "0x118E42C", VA = "0x118E42C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x118E484", Offset = "0x118E484", VA = "0x118E484", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x118E458", Offset = "0x118E458", VA = "0x118E458")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x118E7B8", Offset = "0x118E7B8", VA = "0x118E7B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD64", Offset = "0x84BD64")]
		private sealed class <_StartWhenDone>d__277 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000BA")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000705")]
				[Address(RVA = "0x118E9CC", Offset = "0x118E9CC", VA = "0x118E9CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000707")]
				[Address(RVA = "0x118EA34", Offset = "0x118EA34", VA = "0x118EA34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000702")]
			[Address(RVA = "0x118E87C", Offset = "0x118E87C", VA = "0x118E87C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__277(int <>1__state)
			{
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x118E8A8", Offset = "0x118E8A8", VA = "0x118E8A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x118E8AC", Offset = "0x118E8AC", VA = "0x118E8AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x118E9D4", Offset = "0x118E9D4", VA = "0x118E9D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD74", Offset = "0x84BD74")]
		private sealed class <_StartWhenDone>d__279 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000BC")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x118EBEC", Offset = "0x118EBEC", VA = "0x118EBEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600070D")]
				[Address(RVA = "0x118EC54", Offset = "0x118EC54", VA = "0x118EC54", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x118EA98", Offset = "0x118EA98", VA = "0x118EA98")]
			[DebuggerHidden]
			public <_StartWhenDone>d__279(int <>1__state)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x118EAC4", Offset = "0x118EAC4", VA = "0x118EAC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x118EAC8", Offset = "0x118EAC8", VA = "0x118EAC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x118EBF4", Offset = "0x118EBF4", VA = "0x118EBF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD84", Offset = "0x84BD84")]
		private sealed class <_StartWhenDone>d__284 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> evaluatorFunc;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool continueOn;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000BE")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000711")]
				[Address(RVA = "0x118EE20", Offset = "0x118EE20", VA = "0x118EE20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000713")]
				[Address(RVA = "0x118EE88", Offset = "0x118EE88", VA = "0x118EE88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x118ECB8", Offset = "0x118ECB8", VA = "0x118ECB8")]
			[DebuggerHidden]
			public <_StartWhenDone>d__284(int <>1__state)
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x118ECE4", Offset = "0x118ECE4", VA = "0x118ECE4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x118ECE8", Offset = "0x118ECE8", VA = "0x118ECE8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x118EE28", Offset = "0x118EE28", VA = "0x118EE28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BD94", Offset = "0x84BD94")]
		private sealed class <_InjectDelay>d__285 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000C0")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x118E334", Offset = "0x118E334", VA = "0x118E334", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x118E39C", Offset = "0x118E39C", VA = "0x118E39C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x118E1E0", Offset = "0x118E1E0", VA = "0x118E1E0")]
			[DebuggerHidden]
			public <_InjectDelay>d__285(int <>1__state)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x118E20C", Offset = "0x118E20C", VA = "0x118E20C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x118E210", Offset = "0x118E210", VA = "0x118E210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x118E33C", Offset = "0x118E33C", VA = "0x118E33C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDA4", Offset = "0x84BDA4")]
		private sealed class <_DelayedCall>d__310 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000C2")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x118D738", Offset = "0x118D738", VA = "0x118D738", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x118D7A0", Offset = "0x118D7A0", VA = "0x118D7A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x118D630", Offset = "0x118D630", VA = "0x118D630")]
			[DebuggerHidden]
			public <_DelayedCall>d__310(int <>1__state)
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x118D65C", Offset = "0x118D65C", VA = "0x118D65C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x118D660", Offset = "0x118D660", VA = "0x118D660", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x118D740", Offset = "0x118D740", VA = "0x118D740", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDB4", Offset = "0x84BDB4")]
		private sealed class <_WatchCall>d__331 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeframe;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CoroutineHandle handle;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onDone;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gObject;

			[Token(Token = "0x170000C4")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x118F00C", Offset = "0x118F00C", VA = "0x118F00C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000725")]
				[Address(RVA = "0x118F074", Offset = "0x118F074", VA = "0x118F074", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x118EEEC", Offset = "0x118EEEC", VA = "0x118EEEC")]
			[DebuggerHidden]
			public <_WatchCall>d__331(int <>1__state)
			{
			}

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x118EF18", Offset = "0x118EF18", VA = "0x118EF18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x118EF1C", Offset = "0x118EF1C", VA = "0x118EF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x118F014", Offset = "0x118F014", VA = "0x118F014", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDC4", Offset = "0x84BDC4")]
		private sealed class <_CallContinuously>d__332 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gObject;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000C6")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x118D564", Offset = "0x118D564", VA = "0x118D564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072B")]
				[Address(RVA = "0x118D5CC", Offset = "0x118D5CC", VA = "0x118D5CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x118D3F4", Offset = "0x118D3F4", VA = "0x118D3F4")]
			[DebuggerHidden]
			public <_CallContinuously>d__332(int <>1__state)
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x118D420", Offset = "0x118D420", VA = "0x118D420", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x118D424", Offset = "0x118D424", VA = "0x118D424", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x118D56C", Offset = "0x118D56C", VA = "0x118D56C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDD4", Offset = "0x84BDD4")]
		private sealed class <_WatchCall>d__349<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineHandle handle;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000C8")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600072F")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000731")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072C")]
			[DebuggerHidden]
			public <_WatchCall>d__349(int <>1__state)
			{
			}

			[Token(Token = "0x600072D")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000730")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDE4", Offset = "0x84BDE4")]
		private sealed class <_CallContinuously>d__350<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000CA")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000735")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000CB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000737")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000732")]
			[DebuggerHidden]
			public <_CallContinuously>d__350(int <>1__state)
			{
			}

			[Token(Token = "0x6000733")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000734")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000736")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BEB4", Offset = "0x84BEB4")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BEEC", Offset = "0x84BEEC")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BF24", Offset = "0x84BF24")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BF5C", Offset = "0x84BF5C")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x84BF5C", Offset = "0x84BF5C")]
		public int UpdateCoroutines;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BFAC", Offset = "0x84BFAC")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84BFE4", Offset = "0x84BFE4")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C01C", Offset = "0x84C01C")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C054", Offset = "0x84C054")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C08C", Offset = "0x84C08C")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C0C4", Offset = "0x84C0C4")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C0FC", Offset = "0x84C0FC")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C134", Offset = "0x84C134")]
		public int ManualTimeframeCoroutines;

		[NonSerialized]
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float deltaTime;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Func<float, float> SetManualTimeframeTime;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x4000018")]
		public const float WaitForOneFrame = float.NegativeInfinity;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C17C", Offset = "0x84C17C")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C18C", Offset = "0x84C18C")]
		private CoroutineHandle <currentCoroutine>k__BackingField;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int _tmpInt;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static bool _tmpBool;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Segment _tmpSegment;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _currentUpdateFrame;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int _currentRealtimeUpdateFrame;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _currentEndOfFrameFrame;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _nextRealtimeUpdateProcessSlot;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private int _nextEditorUpdateProcessSlot;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _nextEditorSlowUpdateProcessSlot;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _nextEndOfFrameProcessSlot;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _nextManualTimeframeProcessSlot;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int _lastRealtimeUpdateProcessSlot;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _lastEndOfFrameProcessSlot;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int _lastManualTimeframeProcessSlot;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _lastUpdateTime;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _lastRealtimeUpdateTime;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float _lastEndOfFrameTime;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _lastManualTimeframeTime;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _lastEditorUpdateDeltaTime;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _lastEditorSlowUpdateDeltaTime;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float _lastManualTimeframeDeltaTime;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
		private ushort _expansions;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[HideInInspector]
		private byte _instanceID;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _EOFPumpRan;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> Links;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly WaitForEndOfFrame EofWaitObject;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly Dictionary<CoroutineHandle, int> _processLayers;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly Dictionary<int, HashSet<CoroutineHandle>> _layeredProcesses;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private IEnumerator<float>[] RealtimeUpdateProcesses;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private IEnumerator<float>[] EditorUpdateProcesses;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private IEnumerator<float>[] EditorSlowUpdateProcesses;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private IEnumerator<float>[] EndOfFrameProcesses;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private IEnumerator<float>[] ManualTimeframeProcesses;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool[] UpdatePaused;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool[] RealtimeUpdatePaused;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool[] EditorUpdatePaused;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private bool[] EditorSlowUpdatePaused;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private bool[] EndOfFramePaused;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool[] ManualTimeframePaused;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private bool[] UpdateHeld;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool[] LateUpdateHeld;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private bool[] FixedUpdateHeld;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private bool[] SlowUpdateHeld;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private bool[] RealtimeUpdateHeld;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool[] EditorUpdateHeld;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private bool[] EditorSlowUpdateHeld;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool[] EndOfFrameHeld;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private bool[] ManualTimeframeHeld;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private CoroutineHandle _eofWatcherHandle;

		[Token(Token = "0x400006A")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x400006B")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x400006C")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x400006D")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x400006E")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Timing[] ActiveInstances;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Timing _instance;

		[Token(Token = "0x17000007")]
		public static float LocalTime
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x14555F4", Offset = "0x14555F4", VA = "0x14555F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000008")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1455898", Offset = "0x1455898", VA = "0x1455898")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public static Thread MainThread
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1455AE4", Offset = "0x1455AE4", VA = "0x1455AE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8533EC", Offset = "0x8533EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1455B4C", Offset = "0x1455B4C", VA = "0x1455B4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8533FC", Offset = "0x8533FC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1455BB8", Offset = "0x1455BB8", VA = "0x1455BB8")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x1700000B")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1455D54", Offset = "0x1455D54", VA = "0x1455D54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85340C", Offset = "0x85340C")]
			get
			{
				return default(CoroutineHandle);
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1455D5C", Offset = "0x1455D5C", VA = "0x1455D5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x85341C", Offset = "0x85341C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public static Timing Instance
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1455660", Offset = "0x1455660", VA = "0x1455660")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1455FBC", Offset = "0x1455FBC", VA = "0x1455FBC")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1455904", Offset = "0x1455904", VA = "0x1455904")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8533CC", Offset = "0x8533CC")]
			add
			{
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x14559F4", Offset = "0x14559F4", VA = "0x14559F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8533DC", Offset = "0x8533DC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1456028", Offset = "0x1456028", VA = "0x1456028")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x14560F8", Offset = "0x14560F8", VA = "0x14560F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x145652C", Offset = "0x145652C", VA = "0x145652C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1455D64", Offset = "0x1455D64", VA = "0x1455D64")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1456600", Offset = "0x1456600", VA = "0x1456600")]
		private void Update()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1459E70", Offset = "0x1459E70", VA = "0x1459E70")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x145A59C", Offset = "0x145A59C", VA = "0x145A59C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1457F44", Offset = "0x1457F44", VA = "0x1457F44")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1456260", Offset = "0x1456260", VA = "0x1456260")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1456268", Offset = "0x1456268", VA = "0x1456268")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x85342C", Offset = "0x85342C")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x145ACC8", Offset = "0x145ACC8", VA = "0x145ACC8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853490", Offset = "0x853490")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1458694", Offset = "0x1458694", VA = "0x1458694")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x145B1D0", Offset = "0x145B1D0", VA = "0x145B1D0")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x145181C", Offset = "0x145181C", VA = "0x145181C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x145195C", Offset = "0x145195C", VA = "0x145195C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1451B4C", Offset = "0x1451B4C", VA = "0x1451B4C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1451C98", Offset = "0x1451C98", VA = "0x1451C98")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1451DEC", Offset = "0x1451DEC", VA = "0x1451DEC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1451FF0", Offset = "0x1451FF0", VA = "0x1451FF0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1452140", Offset = "0x1452140", VA = "0x1452140")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1452294", Offset = "0x1452294", VA = "0x1452294")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1452498", Offset = "0x1452498", VA = "0x1452498")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x14525F0", Offset = "0x14525F0", VA = "0x14525F0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1452758", Offset = "0x1452758", VA = "0x1452758")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1452970", Offset = "0x1452970", VA = "0x1452970")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x145E364", Offset = "0x145E364", VA = "0x145E364")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x145E3D0", Offset = "0x145E3D0", VA = "0x145E3D0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x145E4F8", Offset = "0x145E4F8", VA = "0x145E4F8")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x145E570", Offset = "0x145E570", VA = "0x145E570")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x145E5E8", Offset = "0x145E5E8", VA = "0x145E5E8")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x145E714", Offset = "0x145E714", VA = "0x145E714")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x145E790", Offset = "0x145E790", VA = "0x145E790")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x145E808", Offset = "0x145E808", VA = "0x145E808")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x145E934", Offset = "0x145E934", VA = "0x145E934")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x145E9B0", Offset = "0x145E9B0", VA = "0x145E9B0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x145EA2C", Offset = "0x145EA2C", VA = "0x145EA2C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x145EB64", Offset = "0x145EB64", VA = "0x145EB64")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1452AD4", Offset = "0x1452AD4", VA = "0x1452AD4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x145EF08", Offset = "0x145EF08", VA = "0x145EF08")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1452E24", Offset = "0x1452E24", VA = "0x1452E24")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1453224", Offset = "0x1453224", VA = "0x1453224")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x145FB20", Offset = "0x145FB20", VA = "0x145FB20")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1453634", Offset = "0x1453634", VA = "0x1453634")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1453C44", Offset = "0x1453C44", VA = "0x1453C44")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x145FE28", Offset = "0x145FE28", VA = "0x145FE28")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1453FAC", Offset = "0x1453FAC", VA = "0x1453FAC")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x14543D8", Offset = "0x14543D8", VA = "0x14543D8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x145FF3C", Offset = "0x145FF3C", VA = "0x145FF3C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1454800", Offset = "0x1454800", VA = "0x1454800")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1460060", Offset = "0x1460060", VA = "0x1460060")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x14604A0", Offset = "0x14604A0", VA = "0x14604A0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x146056C", Offset = "0x146056C", VA = "0x146056C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x14562D8", Offset = "0x14562D8", VA = "0x14562D8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1460CF4", Offset = "0x1460CF4", VA = "0x1460CF4")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1460DD0", Offset = "0x1460DD0", VA = "0x1460DD0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x14618D8", Offset = "0x14618D8", VA = "0x14618D8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x14619B0", Offset = "0x14619B0", VA = "0x14619B0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1461C10", Offset = "0x1461C10", VA = "0x1461C10")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1461E70", Offset = "0x1461E70", VA = "0x1461E70")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1461F60", Offset = "0x1461F60", VA = "0x1461F60")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x145B990", Offset = "0x145B990", VA = "0x145B990")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int layer, bool layerHasValue, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1462554", Offset = "0x1462554", VA = "0x1462554")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1462630", Offset = "0x1462630", VA = "0x1462630")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x145100C", Offset = "0x145100C", VA = "0x145100C")]
		public static int KillCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1457D10", Offset = "0x1457D10", VA = "0x1457D10")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1462AF8", Offset = "0x1462AF8", VA = "0x1462AF8")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1462BFC", Offset = "0x1462BFC", VA = "0x1462BFC")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x145F008", Offset = "0x145F008", VA = "0x145F008")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x14607C0", Offset = "0x14607C0", VA = "0x14607C0")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x145FA30", Offset = "0x145FA30", VA = "0x145FA30")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1460A48", Offset = "0x1460A48", VA = "0x1460A48")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1462D40", Offset = "0x1462D40", VA = "0x1462D40")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1462E4C", Offset = "0x1462E4C", VA = "0x1462E4C")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x145FC38", Offset = "0x145FC38", VA = "0x145FC38")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1461154", Offset = "0x1461154", VA = "0x1461154")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x14629D8", Offset = "0x14629D8", VA = "0x14629D8")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1462E8C", Offset = "0x1462E8C", VA = "0x1462E8C")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1462F18", Offset = "0x1462F18", VA = "0x1462F18")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1457A14", Offset = "0x1457A14", VA = "0x1457A14")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1462F5C", Offset = "0x1462F5C", VA = "0x1462F5C")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1463048", Offset = "0x1463048", VA = "0x1463048")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1463124", Offset = "0x1463124", VA = "0x1463124")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x14643F4", Offset = "0x14643F4", VA = "0x14643F4")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1451408", Offset = "0x1451408", VA = "0x1451408")]
		public static int PauseCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x14653D0", Offset = "0x14653D0", VA = "0x14653D0")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x14654C0", Offset = "0x14654C0", VA = "0x14654C0")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1465870", Offset = "0x1465870", VA = "0x1465870")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1465570", Offset = "0x1465570", VA = "0x1465570")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1465960", Offset = "0x1465960", VA = "0x1465960")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1465A50", Offset = "0x1465A50", VA = "0x1465A50")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1465D54", Offset = "0x1465D54", VA = "0x1465D54")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x146623C", Offset = "0x146623C", VA = "0x146623C")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x14662F4", Offset = "0x14662F4", VA = "0x14662F4")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1465E60", Offset = "0x1465E60", VA = "0x1465E60")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x14663EC", Offset = "0x14663EC", VA = "0x14663EC")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x14664C8", Offset = "0x14664C8", VA = "0x14664C8")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1451590", Offset = "0x1451590", VA = "0x1451590")]
		public static int ResumeCoroutines(params CoroutineHandle[] handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x146020C", Offset = "0x146020C", VA = "0x146020C")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x145F0F8", Offset = "0x145F0F8", VA = "0x145F0F8")]
		public int ResumeCoroutinesOnInstance(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1466A2C", Offset = "0x1466A2C", VA = "0x1466A2C")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1466E2C", Offset = "0x1466E2C", VA = "0x1466E2C")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1466EDC", Offset = "0x1466EDC", VA = "0x1466EDC")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1466B30", Offset = "0x1466B30", VA = "0x1466B30")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1466FCC", Offset = "0x1466FCC", VA = "0x1466FCC")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x14670BC", Offset = "0x14670BC", VA = "0x14670BC")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x14673BC", Offset = "0x14673BC", VA = "0x14673BC")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x14674C8", Offset = "0x14674C8", VA = "0x14674C8")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x145FD30", Offset = "0x145FD30", VA = "0x145FD30")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1461550", Offset = "0x1461550", VA = "0x1461550")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x144FF7C", Offset = "0x144FF7C", VA = "0x144FF7C")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x145009C", Offset = "0x145009C", VA = "0x145009C")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x14501E0", Offset = "0x14501E0", VA = "0x14501E0")]
		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x145097C", Offset = "0x145097C", VA = "0x145097C")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1450400", Offset = "0x1450400", VA = "0x1450400")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x14507B8", Offset = "0x14507B8", VA = "0x14507B8")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1450AEC", Offset = "0x1450AEC", VA = "0x1450AEC")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1468898", Offset = "0x1468898", VA = "0x1468898")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x14506A0", Offset = "0x14506A0", VA = "0x14506A0")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1450E40", Offset = "0x1450E40", VA = "0x1450E40")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x14511FC", Offset = "0x14511FC", VA = "0x14511FC")]
		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x14622E4", Offset = "0x14622E4", VA = "0x14622E4")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x146241C", Offset = "0x146241C", VA = "0x146241C")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1467648", Offset = "0x1467648", VA = "0x1467648")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x146779C", Offset = "0x146779C", VA = "0x146779C")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x145AF94", Offset = "0x145AF94", VA = "0x145AF94")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x14678F0", Offset = "0x14678F0", VA = "0x14678F0")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x145AD38", Offset = "0x145AD38", VA = "0x145AD38")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1467580", Offset = "0x1467580", VA = "0x1467580")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1462A84", Offset = "0x1462A84", VA = "0x1462A84")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1462C34", Offset = "0x1462C34", VA = "0x1462C34")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x146468C", Offset = "0x146468C", VA = "0x146468C")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1467B54", Offset = "0x1467B54", VA = "0x1467B54")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1468904", Offset = "0x1468904", VA = "0x1468904")]
		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1467A88", Offset = "0x1467A88", VA = "0x1467A88")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x14679BC", Offset = "0x14679BC", VA = "0x14679BC")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x14695CC", Offset = "0x14695CC", VA = "0x14695CC")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1454DF8", Offset = "0x1454DF8", VA = "0x1454DF8")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1454F00", Offset = "0x1454F00", VA = "0x1454F00")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1455010", Offset = "0x1455010", VA = "0x1455010")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1455128", Offset = "0x1455128", VA = "0x1455128")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1455248", Offset = "0x1455248", VA = "0x1455248")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1455344", Offset = "0x1455344", VA = "0x1455344")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1455448", Offset = "0x1455448", VA = "0x1455448")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x145555C", Offset = "0x145555C", VA = "0x145555C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1469990", Offset = "0x1469990", VA = "0x1469990")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x14696C8", Offset = "0x14696C8", VA = "0x14696C8")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x145EBEC", Offset = "0x145EBEC", VA = "0x145EBEC")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x145F2A4", Offset = "0x145F2A4", VA = "0x145F2A4")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1469A80", Offset = "0x1469A80", VA = "0x1469A80")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x14699F8", Offset = "0x14699F8", VA = "0x14699F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8534F4", Offset = "0x8534F4")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x145AE08", Offset = "0x145AE08", VA = "0x145AE08")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1469DF8", Offset = "0x1469DF8", VA = "0x1469DF8")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1469EC4", Offset = "0x1469EC4", VA = "0x1469EC4")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1469F38", Offset = "0x1469F38", VA = "0x1469F38")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x146A0B4", Offset = "0x146A0B4", VA = "0x146A0B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853558", Offset = "0x853558")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x146A130", Offset = "0x146A130", VA = "0x146A130")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x146A2B0", Offset = "0x146A2B0", VA = "0x146A2B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8535BC", Offset = "0x8535BC")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x146A32C", Offset = "0x146A32C", VA = "0x146A32C")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x146A3FC", Offset = "0x146A3FC", VA = "0x146A3FC")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x146A520", Offset = "0x146A520", VA = "0x146A520")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x146A5F0", Offset = "0x146A5F0", VA = "0x146A5F0")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x146A494", Offset = "0x146A494", VA = "0x146A494")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853620", Offset = "0x853620")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1464364", Offset = "0x1464364", VA = "0x1464364")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853684", Offset = "0x853684")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x146A688", Offset = "0x146A688", VA = "0x146A688")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x146A840", Offset = "0x146A840", VA = "0x146A840")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x146A9EC", Offset = "0x146A9EC", VA = "0x146A9EC")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x146AC74", Offset = "0x146AC74", VA = "0x146AC74")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x146AFC8", Offset = "0x146AFC8", VA = "0x146AFC8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8536E8", Offset = "0x8536E8")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x146B07C", Offset = "0x146B07C", VA = "0x146B07C")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x146B134", Offset = "0x146B134", VA = "0x146B134")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x146B1E8", Offset = "0x146B1E8", VA = "0x146B1E8")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x146B29C", Offset = "0x146B29C", VA = "0x146B29C")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x146B364", Offset = "0x146B364", VA = "0x146B364")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x146B4C0", Offset = "0x146B4C0", VA = "0x146B4C0")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x146B588", Offset = "0x146B588", VA = "0x146B588")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x146B668", Offset = "0x146B668", VA = "0x146B668")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x146B73C", Offset = "0x146B73C", VA = "0x146B73C")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x146B8B8", Offset = "0x146B8B8", VA = "0x146B8B8")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x146B96C", Offset = "0x146B96C", VA = "0x146B96C")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x146BA7C", Offset = "0x146BA7C", VA = "0x146BA7C")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x146BB30", Offset = "0x146BB30", VA = "0x146BB30")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x146BBD0", Offset = "0x146BBD0", VA = "0x146BBD0")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x146BC98", Offset = "0x146BC98", VA = "0x146BC98")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x146BDCC", Offset = "0x146BDCC", VA = "0x146BDCC")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x146BEFC", Offset = "0x146BEFC", VA = "0x146BEFC")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x146BF3C", Offset = "0x146BF3C", VA = "0x146BF3C")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x146BFE8", Offset = "0x146BFE8", VA = "0x146BFE8")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x146BE68", Offset = "0x146BE68", VA = "0x146BE68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853724", Offset = "0x853724")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x146C02C", Offset = "0x146C02C", VA = "0x146C02C")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x146C0D8", Offset = "0x146C0D8", VA = "0x146C0D8")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x146C124", Offset = "0x146C124", VA = "0x146C124")]
		public static CoroutineHandle CallDelayed(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x146C1D8", Offset = "0x146C1D8", VA = "0x146C1D8")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Segment segment, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x146C234", Offset = "0x146C234", VA = "0x146C234")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x146C464", Offset = "0x146C464", VA = "0x146C464")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x146C4FC", Offset = "0x146C4FC", VA = "0x146C4FC")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x146C60C", Offset = "0x146C60C", VA = "0x146C60C")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x146C714", Offset = "0x146C714", VA = "0x146C714")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x146C818", Offset = "0x146C818", VA = "0x146C818")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x146C920", Offset = "0x146C920", VA = "0x146C920")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x146CA44", Offset = "0x146CA44", VA = "0x146CA44")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x146CB58", Offset = "0x146CB58", VA = "0x146CB58")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x146CC58", Offset = "0x146CC58", VA = "0x146CC58")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x146CD48", Offset = "0x146CD48", VA = "0x146CD48")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x146CE54", Offset = "0x146CE54", VA = "0x146CE54")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x146CF58", Offset = "0x146CF58", VA = "0x146CF58")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x146D064", Offset = "0x146D064", VA = "0x146D064")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x146D168", Offset = "0x146D168", VA = "0x146D168")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x146D288", Offset = "0x146D288", VA = "0x146D288")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x146C3C0", Offset = "0x146C3C0", VA = "0x146C3C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853788", Offset = "0x853788")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x146C32C", Offset = "0x146C32C", VA = "0x146C32C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8537EC", Offset = "0x8537EC")]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000114")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000115")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000116")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000117")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000118")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000119")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011A")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011B")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011C")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011D")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011E")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011F")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000120")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000121")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000122")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000123")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000124")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x853850", Offset = "0x853850")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8538B4", Offset = "0x8538B4")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x146D398", Offset = "0x146D398", VA = "0x146D398")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853918", Offset = "0x853918")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x146D3A0", Offset = "0x146D3A0", VA = "0x146D3A0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853954", Offset = "0x853954")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x146D3A8", Offset = "0x146D3A8", VA = "0x146D3A8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853990", Offset = "0x853990")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x146D3B0", Offset = "0x146D3B0", VA = "0x146D3B0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8539CC", Offset = "0x8539CC")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x146D3B8", Offset = "0x146D3B8", VA = "0x146D3B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853A08", Offset = "0x853A08")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x146D3BC", Offset = "0x146D3BC", VA = "0x146D3BC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853A44", Offset = "0x853A44")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x146D3C0", Offset = "0x146D3C0", VA = "0x146D3C0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853A80", Offset = "0x853A80")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x146D3C4", Offset = "0x146D3C4", VA = "0x146D3C4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853ABC", Offset = "0x853ABC")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x146D3C8", Offset = "0x146D3C8", VA = "0x146D3C8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853AF8", Offset = "0x853AF8")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x146D3CC", Offset = "0x146D3CC", VA = "0x146D3CC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853B34", Offset = "0x853B34")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x146D3D0", Offset = "0x146D3D0", VA = "0x146D3D0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853B70", Offset = "0x853B70")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x146D3D4", Offset = "0x146D3D4", VA = "0x146D3D4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853BAC", Offset = "0x853BAC")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x146D3D8", Offset = "0x146D3D8", VA = "0x146D3D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853BE8", Offset = "0x853BE8")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x146D3DC", Offset = "0x146D3DC", VA = "0x146D3DC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853C24", Offset = "0x853C24")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x146D3E0", Offset = "0x146D3E0", VA = "0x146D3E0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853C60", Offset = "0x853C60")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x146D3E4", Offset = "0x146D3E4", VA = "0x146D3E4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853C9C", Offset = "0x853C9C")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000136")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853CD8", Offset = "0x853CD8")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000137")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853D14", Offset = "0x853D14")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x146D3E8", Offset = "0x146D3E8", VA = "0x146D3E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853D50", Offset = "0x853D50")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853D8C", Offset = "0x853D8C")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x146D3F0", Offset = "0x146D3F0", VA = "0x146D3F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853DC8", Offset = "0x853DC8")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x146D3F8", Offset = "0x146D3F8", VA = "0x146D3F8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x853E04", Offset = "0x853E04")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x146D3FC", Offset = "0x146D3FC", VA = "0x146D3FC")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x2000006")]
	public enum Segment
	{
		[Token(Token = "0x4000072")]
		Invalid = -1,
		[Token(Token = "0x4000073")]
		Update,
		[Token(Token = "0x4000074")]
		FixedUpdate,
		[Token(Token = "0x4000075")]
		LateUpdate,
		[Token(Token = "0x4000076")]
		SlowUpdate,
		[Token(Token = "0x4000077")]
		RealtimeUpdate,
		[Token(Token = "0x4000078")]
		EditorUpdate,
		[Token(Token = "0x4000079")]
		EditorSlowUpdate,
		[Token(Token = "0x400007A")]
		EndOfFrame,
		[Token(Token = "0x400007B")]
		ManualTimeframe
	}
	[Token(Token = "0x2000007")]
	public enum DebugInfoType
	{
		[Token(Token = "0x400007D")]
		None,
		[Token(Token = "0x400007E")]
		SeperateCoroutines,
		[Token(Token = "0x400007F")]
		SeperateTags
	}
	[Token(Token = "0x2000008")]
	public enum SingletonBehavior
	{
		[Token(Token = "0x4000081")]
		Abort,
		[Token(Token = "0x4000082")]
		Overwrite,
		[Token(Token = "0x4000083")]
		Wait,
		[Token(Token = "0x4000084")]
		AbortAndUnpause
	}
	[Token(Token = "0x2000009")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x4000085")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x1700000D")]
		public byte Key
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x90506C", Offset = "0x90506C", VA = "0x90506C")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700000E")]
		public string Tag
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x9050B0", Offset = "0x9050B0", VA = "0x9050B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x9050B8", Offset = "0x9050B8", VA = "0x9050B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int? Layer
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x9050C0", Offset = "0x9050C0", VA = "0x9050C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x9050C8", Offset = "0x9050C8", VA = "0x9050C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Segment Segment
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x9050D0", Offset = "0x9050D0", VA = "0x9050D0")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x9050D8", Offset = "0x9050D8", VA = "0x9050D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsRunning
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x9050E0", Offset = "0x9050E0", VA = "0x9050E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x9050E8", Offset = "0x9050E8", VA = "0x9050E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsAliveAndPaused
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x9050F4", Offset = "0x9050F4", VA = "0x9050F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x9050FC", Offset = "0x9050FC", VA = "0x9050FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsValid
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x905108", Offset = "0x905108", VA = "0x905108")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x905078", Offset = "0x905078", VA = "0x905078")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x905080", Offset = "0x905080", VA = "0x905080")]
		public CoroutineHandle(CoroutineHandle other)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x905088", Offset = "0x905088", VA = "0x905088", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x905098", Offset = "0x905098", VA = "0x905098", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x144FC18", Offset = "0x144FC18", VA = "0x144FC18")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x144FC24", Offset = "0x144FC24", VA = "0x144FC24")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x9050A0", Offset = "0x9050A0", VA = "0x9050A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x9050A8", Offset = "0x9050A8", VA = "0x9050A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	public static class MECExtensionMethods1
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x14517B0", Offset = "0x14517B0", VA = "0x14517B0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x14518E0", Offset = "0x14518E0", VA = "0x14518E0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1451AD0", Offset = "0x1451AD0", VA = "0x1451AD0")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1451C1C", Offset = "0x1451C1C", VA = "0x1451C1C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1451D68", Offset = "0x1451D68", VA = "0x1451D68")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1451F6C", Offset = "0x1451F6C", VA = "0x1451F6C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x14520C4", Offset = "0x14520C4", VA = "0x14520C4")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1452210", Offset = "0x1452210", VA = "0x1452210")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1452414", Offset = "0x1452414", VA = "0x1452414")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x145256C", Offset = "0x145256C", VA = "0x145256C")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x14526C4", Offset = "0x14526C4", VA = "0x14526C4")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x14528DC", Offset = "0x14528DC", VA = "0x14528DC")]
		public static CoroutineHandle RunCoroutine(this IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1452A50", Offset = "0x1452A50", VA = "0x1452A50")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1452D24", Offset = "0x1452D24", VA = "0x1452D24")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x145311C", Offset = "0x145311C", VA = "0x145311C")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x14531A0", Offset = "0x14531A0", VA = "0x14531A0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x145351C", Offset = "0x145351C", VA = "0x145351C")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1453B1C", Offset = "0x1453B1C", VA = "0x1453B1C")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1453BB0", Offset = "0x1453BB0", VA = "0x1453BB0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1453E98", Offset = "0x1453E98", VA = "0x1453E98")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x14542B0", Offset = "0x14542B0", VA = "0x14542B0")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1454344", Offset = "0x1454344", VA = "0x1454344")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x14546DC", Offset = "0x14546DC", VA = "0x14546DC")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1454CF8", Offset = "0x1454CF8", VA = "0x1454CF8")]
		public static CoroutineHandle RunCoroutineSingleton(this IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1454D94", Offset = "0x1454D94", VA = "0x1454D94")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1454E8C", Offset = "0x1454E8C", VA = "0x1454E8C")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1454F9C", Offset = "0x1454F9C", VA = "0x1454F9C")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x14550AC", Offset = "0x14550AC", VA = "0x14550AC")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x14551D4", Offset = "0x14551D4", VA = "0x14551D4")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x14552C8", Offset = "0x14552C8", VA = "0x14552C8")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x14553CC", Offset = "0x14553CC", VA = "0x14553CC")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x14554D0", Offset = "0x14554D0", VA = "0x14554D0")]
		public static float WaitUntilDone(this IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x200000B")]
	public enum Axis
	{
		[Token(Token = "0x4000089")]
		X,
		[Token(Token = "0x400008A")]
		Y,
		[Token(Token = "0x400008B")]
		Z
	}
	[Token(Token = "0x200000C")]
	public class AxisTools
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x119CED0", Offset = "0x119CED0", VA = "0x119CED0")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x119CF88", Offset = "0x119CF88", VA = "0x119CF88")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x119D034", Offset = "0x119D034", VA = "0x119D034")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x119D218", Offset = "0x119D218", VA = "0x119D218")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x119D150", Offset = "0x119D150", VA = "0x119D150")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x119D334", Offset = "0x119D334", VA = "0x119D334")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x119D560", Offset = "0x119D560", VA = "0x119D560")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000A1")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x119D828", Offset = "0x119D828", VA = "0x119D828")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000014")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x119D5B4", Offset = "0x119D5B4", VA = "0x119D5B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x119D8A0", Offset = "0x119D8A0", VA = "0x119D8A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x119D568", Offset = "0x119D568", VA = "0x119D568")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000E")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		public enum BoneType
		{
			[Token(Token = "0x400049A")]
			Unassigned,
			[Token(Token = "0x400049B")]
			Spine,
			[Token(Token = "0x400049C")]
			Head,
			[Token(Token = "0x400049D")]
			Arm,
			[Token(Token = "0x400049E")]
			Leg,
			[Token(Token = "0x400049F")]
			Tail,
			[Token(Token = "0x40004A0")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000A3")]
		public enum BoneSide
		{
			[Token(Token = "0x40004A2")]
			Center,
			[Token(Token = "0x40004A3")]
			Left,
			[Token(Token = "0x40004A4")]
			Right
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x119DB14", Offset = "0x119DB14", VA = "0x119DB14")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x119DE14", Offset = "0x119DE14", VA = "0x119DE14")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x119E064", Offset = "0x119E064", VA = "0x119E064")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x119E0E8", Offset = "0x119E0E8", VA = "0x119E0E8")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x119E194", Offset = "0x119E194", VA = "0x119E194")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x119DCC4", Offset = "0x119DCC4", VA = "0x119DCC4")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x119DFC4", Offset = "0x119DFC4", VA = "0x119DFC4")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x119E9D4", Offset = "0x119E9D4", VA = "0x119E9D4")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x119E7EC", Offset = "0x119E7EC", VA = "0x119E7EC")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x119E8E0", Offset = "0x119E8E0", VA = "0x119E8E0")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x119E3B4", Offset = "0x119E3B4", VA = "0x119E3B4")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x119E468", Offset = "0x119E468", VA = "0x119E468")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x119E51C", Offset = "0x119E51C", VA = "0x119E51C")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x119E5D0", Offset = "0x119E5D0", VA = "0x119E5D0")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x119E684", Offset = "0x119E684", VA = "0x119E684")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x119E738", Offset = "0x119E738", VA = "0x119E738")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x119EBE8", Offset = "0x119EBE8", VA = "0x119EBE8")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x119E2C8", Offset = "0x119E2C8", VA = "0x119E2C8")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x119EB58", Offset = "0x119EB58", VA = "0x119EB58")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x119EC58", Offset = "0x119EC58", VA = "0x119EC58")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x119ED30", Offset = "0x119ED30", VA = "0x119ED30")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x119EADC", Offset = "0x119EADC", VA = "0x119EADC")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x119EA64", Offset = "0x119EA64", VA = "0x119EA64")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class BipedReferences
	{
		[Token(Token = "0x20000A4")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000CC")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600073A")]
				[Address(RVA = "0x11A3CC0", Offset = "0x11A3CC0", VA = "0x11A3CC0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x8FD5F0", Offset = "0x8FD5F0", VA = "0x8FD5F0")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000016")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x11A08A4", Offset = "0x11A08A4", VA = "0x11A08A4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool isEmpty
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x11A0C90", Offset = "0x11A0C90", VA = "0x11A0C90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11A0CA0", Offset = "0x11A0CA0", VA = "0x11A0CA0", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11A10CC", Offset = "0x11A10CC", VA = "0x11A10CC", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x11A1504", Offset = "0x11A1504", VA = "0x11A1504")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x11A1B14", Offset = "0x11A1B14", VA = "0x11A1B14")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x11A1750", Offset = "0x11A1750", VA = "0x11A1750")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x11A22C4", Offset = "0x11A22C4", VA = "0x11A22C4")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x11A23B8", Offset = "0x11A23B8", VA = "0x11A23B8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11A2910", Offset = "0x11A2910", VA = "0x11A2910")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x11A2714", Offset = "0x11A2714", VA = "0x11A2714")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x11A258C", Offset = "0x11A258C", VA = "0x11A258C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x11A2458", Offset = "0x11A2458", VA = "0x11A2458")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11A2818", Offset = "0x11A2818", VA = "0x11A2818")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x11A2A0C", Offset = "0x11A2A0C", VA = "0x11A2A0C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11A34AC", Offset = "0x11A34AC", VA = "0x11A34AC")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x11A2F90", Offset = "0x11A2F90", VA = "0x11A2F90")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x11A37A0", Offset = "0x11A37A0", VA = "0x11A37A0")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11A32D0", Offset = "0x11A32D0", VA = "0x11A32D0")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x11A37A8", Offset = "0x11A37A8", VA = "0x11A37A8")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11A37B0", Offset = "0x11A37B0", VA = "0x11A37B0")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x11A3970", Offset = "0x11A3970", VA = "0x11A3970")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11A3B88", Offset = "0x11A3B88", VA = "0x11A3B88")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x11A16E0", Offset = "0x11A16E0", VA = "0x11A16E0")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x11A3CC8", Offset = "0x11A3CC8", VA = "0x11A3CC8")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x11A3CD0", Offset = "0x11A3CD0", VA = "0x11A3CD0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x11A3E10", Offset = "0x11A3E10", VA = "0x11A3E10")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class Hierarchy
	{
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x18FD35C", Offset = "0x18FD35C", VA = "0x18FD35C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x18FD55C", Offset = "0x18FD55C", VA = "0x18FD55C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x18FD3F4", Offset = "0x18FD3F4", VA = "0x18FD3F4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x18FD680", Offset = "0x18FD680", VA = "0x18FD680")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x18FD7A4", Offset = "0x18FD7A4", VA = "0x18FD7A4")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x18FDA4C", Offset = "0x18FDA4C", VA = "0x18FDA4C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x18FDB68", Offset = "0x18FDB68", VA = "0x18FDB68")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x18FDCF0", Offset = "0x18FDCF0", VA = "0x18FDCF0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x18FE084", Offset = "0x18FE084", VA = "0x18FE084")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x18FDE70", Offset = "0x18FDE70", VA = "0x18FDE70")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x18FE224", Offset = "0x18FE224", VA = "0x18FE224")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x18FE22C", Offset = "0x18FE22C", VA = "0x18FE22C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x18FE29C", Offset = "0x18FE29C", VA = "0x18FE29C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000B9")]
		None,
		[Token(Token = "0x40000BA")]
		InOutCubic,
		[Token(Token = "0x40000BB")]
		InOutQuintic,
		[Token(Token = "0x40000BC")]
		InOutSine,
		[Token(Token = "0x40000BD")]
		InQuintic,
		[Token(Token = "0x40000BE")]
		InQuartic,
		[Token(Token = "0x40000BF")]
		InCubic,
		[Token(Token = "0x40000C0")]
		InQuadratic,
		[Token(Token = "0x40000C1")]
		InElastic,
		[Token(Token = "0x40000C2")]
		InElasticSmall,
		[Token(Token = "0x40000C3")]
		InElasticBig,
		[Token(Token = "0x40000C4")]
		InSine,
		[Token(Token = "0x40000C5")]
		InBack,
		[Token(Token = "0x40000C6")]
		OutQuintic,
		[Token(Token = "0x40000C7")]
		OutQuartic,
		[Token(Token = "0x40000C8")]
		OutCubic,
		[Token(Token = "0x40000C9")]
		OutInCubic,
		[Token(Token = "0x40000CA")]
		OutInQuartic,
		[Token(Token = "0x40000CB")]
		OutElastic,
		[Token(Token = "0x40000CC")]
		OutElasticSmall,
		[Token(Token = "0x40000CD")]
		OutElasticBig,
		[Token(Token = "0x40000CE")]
		OutSine,
		[Token(Token = "0x40000CF")]
		OutBack,
		[Token(Token = "0x40000D0")]
		OutBackCubic,
		[Token(Token = "0x40000D1")]
		OutBackQuartic,
		[Token(Token = "0x40000D2")]
		BackInCubic,
		[Token(Token = "0x40000D3")]
		BackInQuartic
	}
	[Token(Token = "0x2000015")]
	public class Interp
	{
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x18FE30C", Offset = "0x18FE30C", VA = "0x18FE30C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x18FED74", Offset = "0x18FED74", VA = "0x18FED74")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x18FEE7C", Offset = "0x18FEE7C", VA = "0x18FEE7C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x18FE678", Offset = "0x18FE678", VA = "0x18FE678")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x18FE684", Offset = "0x18FE684", VA = "0x18FE684")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x18FE6A8", Offset = "0x18FE6A8", VA = "0x18FE6A8")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x18FE6E4", Offset = "0x18FE6E4", VA = "0x18FE6E4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x18FE6FC", Offset = "0x18FE6FC", VA = "0x18FE6FC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x18FE710", Offset = "0x18FE710", VA = "0x18FE710")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x18FE724", Offset = "0x18FE724", VA = "0x18FE724")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x18FE734", Offset = "0x18FE734", VA = "0x18FE734")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x18FE77C", Offset = "0x18FE77C", VA = "0x18FE77C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x18FE7B4", Offset = "0x18FE7B4", VA = "0x18FE7B4")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x18FE7DC", Offset = "0x18FE7DC", VA = "0x18FE7DC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x18FEF78", Offset = "0x18FEF78", VA = "0x18FEF78")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x18FE810", Offset = "0x18FE810", VA = "0x18FE810")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x18FE838", Offset = "0x18FE838", VA = "0x18FE838")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x18FE868", Offset = "0x18FE868", VA = "0x18FE868")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x18FE89C", Offset = "0x18FE89C", VA = "0x18FE89C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x18FE8E0", Offset = "0x18FE8E0", VA = "0x18FE8E0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x18FE944", Offset = "0x18FE944", VA = "0x18FE944")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x18FE9A8", Offset = "0x18FE9A8", VA = "0x18FE9A8")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x18FE9FC", Offset = "0x18FE9FC", VA = "0x18FE9FC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x18FEA50", Offset = "0x18FEA50", VA = "0x18FEA50")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x18FEAE8", Offset = "0x18FEAE8", VA = "0x18FEAE8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x18FEB7C", Offset = "0x18FEB7C", VA = "0x18FEB7C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x18FEFAC", Offset = "0x18FEFAC", VA = "0x18FEFAC")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x18FEC20", Offset = "0x18FEC20", VA = "0x18FEC20")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x18FED04", Offset = "0x18FED04", VA = "0x18FED04")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x18FED34", Offset = "0x18FED34", VA = "0x18FED34")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x18FF094", Offset = "0x18FF094", VA = "0x18FF094")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x18FF09C", Offset = "0x18FF09C", VA = "0x18FF09C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x18FF10C", Offset = "0x18FF10C", VA = "0x18FF10C")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x18FF17C", Offset = "0x18FF17C", VA = "0x18FF17C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x18FF1D4", Offset = "0x18FF1D4", VA = "0x18FF1D4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x18FF2A0", Offset = "0x18FF2A0", VA = "0x18FF2A0")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x18FF1EC", Offset = "0x18FF1EC", VA = "0x18FF1EC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x18FF2B8", Offset = "0x18FF2B8", VA = "0x18FF2B8")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x18FF35C", Offset = "0x18FF35C", VA = "0x18FF35C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x18FF388", Offset = "0x18FF388", VA = "0x18FF388")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x18FF3D8", Offset = "0x18FF3D8", VA = "0x18FF3D8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x18FF444", Offset = "0x18FF444", VA = "0x18FF444")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x18FF538", Offset = "0x18FF538", VA = "0x18FF538")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x18FF610", Offset = "0x18FF610", VA = "0x18FF610")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x18FF670", Offset = "0x18FF670", VA = "0x18FF670")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000018")]
	public static class QuaTools
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x18FF6A0", Offset = "0x18FF6A0", VA = "0x18FF6A0")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x18FF7EC", Offset = "0x18FF7EC", VA = "0x18FF7EC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x18FF938", Offset = "0x18FF938", VA = "0x18FF938")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x18FFA4C", Offset = "0x18FFA4C", VA = "0x18FFA4C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x18FFB60", Offset = "0x18FFB60", VA = "0x18FFB60")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x18FFCEC", Offset = "0x18FFCEC", VA = "0x18FFCEC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x18F2588", Offset = "0x18F2588", VA = "0x18F2588")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x18FFDBC", Offset = "0x18FFDBC", VA = "0x18FFDBC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1900040", Offset = "0x1900040", VA = "0x1900040")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1900254", Offset = "0x1900254", VA = "0x1900254")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x18FB128", Offset = "0x18FB128", VA = "0x18FB128")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000019")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000018")]
		public static T instance
		{
			[Token(Token = "0x60001F5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F6")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001F7")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C1E4", Offset = "0x84C1E4")]
		public bool fixTransforms;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000019")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x190050C", Offset = "0x190050C", VA = "0x190050C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		private bool isAnimated
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x1900808", Offset = "0x1900808", VA = "0x1900808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x19003D4", Offset = "0x19003D4", VA = "0x19003D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x190046C", Offset = "0x190046C", VA = "0x190046C", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1900470", Offset = "0x1900470", VA = "0x1900470", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1900474", Offset = "0x1900474", VA = "0x1900474", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1900478", Offset = "0x1900478", VA = "0x1900478")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1900508", Offset = "0x1900508", VA = "0x1900508")]
		private void Start()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x19004B0", Offset = "0x19004B0", VA = "0x19004B0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x19007BC", Offset = "0x19007BC", VA = "0x19007BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x19005FC", Offset = "0x19005FC", VA = "0x19005FC")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x19008C4", Offset = "0x19008C4", VA = "0x19008C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1900920", Offset = "0x1900920", VA = "0x1900920")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x190097C", Offset = "0x190097C", VA = "0x190097C")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x18F0C10", Offset = "0x18F0C10", VA = "0x18F0C10")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x19009C4", Offset = "0x19009C4", VA = "0x19009C4")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1900A7C", Offset = "0x1900A7C", VA = "0x1900A7C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1900B34", Offset = "0x1900B34", VA = "0x1900B34")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1900BEC", Offset = "0x1900BEC", VA = "0x1900BEC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public static class V3Tools
	{
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1900BF4", Offset = "0x1900BF4", VA = "0x1900BF4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1900CEC", Offset = "0x1900CEC", VA = "0x1900CEC")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1900DE4", Offset = "0x1900DE4", VA = "0x1900DE4")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1900EDC", Offset = "0x1900EDC", VA = "0x1900EDC")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1900FDC", Offset = "0x1900FDC", VA = "0x1900FDC")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1901218", Offset = "0x1901218", VA = "0x1901218")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1901468", Offset = "0x1901468", VA = "0x1901468")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1901668", Offset = "0x1901668", VA = "0x1901668")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200001D")]
	public static class Warning
	{
		[Token(Token = "0x20000A5")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1901844", Offset = "0x1901844", VA = "0x1901844")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x18F407C", Offset = "0x18F407C", VA = "0x18F407C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x200001E")]
	public class Navigator
	{
		[Token(Token = "0x20000A6")]
		public enum State
		{
			[Token(Token = "0x40004A8")]
			Idle,
			[Token(Token = "0x40004A9")]
			Seeking,
			[Token(Token = "0x40004AA")]
			OnPath
		}

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C21C", Offset = "0x84C21C")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C254", Offset = "0x84C254")]
		public float cornerRadius;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C28C", Offset = "0x84C28C")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C2C4", Offset = "0x84C2C4")]
		public float maxSampleDistance;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C2FC", Offset = "0x84C2FC")]
		public float nextPathInterval;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C334", Offset = "0x84C334")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C344", Offset = "0x84C344")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700001B")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x11A3E44", Offset = "0x11A3E44", VA = "0x11A3E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8540B0", Offset = "0x8540B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x11A3E50", Offset = "0x11A3E50", VA = "0x11A3E50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8540C0", Offset = "0x8540C0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public State state
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x11A3E5C", Offset = "0x11A3E5C", VA = "0x11A3E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8540D0", Offset = "0x8540D0")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x11A3E64", Offset = "0x11A3E64", VA = "0x11A3E64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8540E0", Offset = "0x8540E0")]
			private set
			{
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x11A3E6C", Offset = "0x11A3E6C", VA = "0x11A3E6C")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x11A3F40", Offset = "0x11A3F40", VA = "0x11A3F40")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x11A4484", Offset = "0x11A4484", VA = "0x11A4484")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x11A44F4", Offset = "0x11A44F4", VA = "0x11A44F4")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x11A434C", Offset = "0x11A434C", VA = "0x11A434C")]
		private void Stop()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x11A43C0", Offset = "0x11A43C0", VA = "0x11A43C0")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x11A463C", Offset = "0x11A463C", VA = "0x11A463C")]
		public void Visualize()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x11A47EC", Offset = "0x11A47EC", VA = "0x11A47EC")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B1B8", Offset = "0x84B1B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B1B8", Offset = "0x84B1B8")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x11A67E0", Offset = "0x11A67E0", VA = "0x11A67E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8540F0", Offset = "0x8540F0")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x11A682C", Offset = "0x11A682C", VA = "0x11A682C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854128", Offset = "0x854128")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x11A6878", Offset = "0x11A6878", VA = "0x11A6878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854160", Offset = "0x854160")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x11A68C4", Offset = "0x11A68C4", VA = "0x11A68C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854198", Offset = "0x854198")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11A6910", Offset = "0x11A6910", VA = "0x11A6910")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x11A69AC", Offset = "0x11A69AC", VA = "0x11A69AC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x11A69CC", Offset = "0x11A69CC", VA = "0x11A69CC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x11A69FC", Offset = "0x11A69FC", VA = "0x11A69FC")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x11A6A2C", Offset = "0x11A6A2C", VA = "0x11A6A2C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x11A6A6C", Offset = "0x11A6A6C", VA = "0x11A6A6C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x11A6AB0", Offset = "0x11A6AB0", VA = "0x11A6AB0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x11A6AD4", Offset = "0x11A6AD4", VA = "0x11A6AD4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x11A6AF8", Offset = "0x11A6AF8", VA = "0x11A6AF8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x11A6B20", Offset = "0x11A6B20", VA = "0x11A6B20")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x11A6B4C", Offset = "0x11A6B4C", VA = "0x11A6B4C")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x11A6B78", Offset = "0x11A6B78", VA = "0x11A6B78")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x11A6930", Offset = "0x11A6930", VA = "0x11A6930")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x11A6BA0", Offset = "0x11A6BA0", VA = "0x11A6BA0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x11A6BAC", Offset = "0x11A6BAC", VA = "0x11A6BAC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x11A6BB8", Offset = "0x11A6BB8", VA = "0x11A6BB8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x11A6EA0", Offset = "0x11A6EA0", VA = "0x11A6EA0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x11A6F48", Offset = "0x11A6F48", VA = "0x11A6F48", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x11A723C", Offset = "0x11A723C", VA = "0x11A723C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x11A73C8", Offset = "0x11A73C8", VA = "0x11A73C8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x11A73FC", Offset = "0x11A73FC", VA = "0x11A73FC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700001D")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x11A6D58", Offset = "0x11A6D58", VA = "0x11A6D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x11A75C4", Offset = "0x11A75C4", VA = "0x11A75C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x11A7118", Offset = "0x11A7118", VA = "0x11A7118")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x11A747C", Offset = "0x11A747C", VA = "0x11A747C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700001F")]
		public bool isValid
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x14F594C", Offset = "0x14F594C", VA = "0x14F594C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000240")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x14F59BC", Offset = "0x14F59BC", VA = "0x14F59BC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x14F59C4", Offset = "0x14F59C4", VA = "0x14F59C4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x14F5AD0", Offset = "0x14F5AD0", VA = "0x14F5AD0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x14F5AD8", Offset = "0x14F5AD8", VA = "0x14F5AD8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000020")]
		private bool positionChanged
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x14F5CA0", Offset = "0x14F5CA0", VA = "0x14F5CA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x14F5B04", Offset = "0x14F5B04", VA = "0x14F5B04", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x14F5D5C", Offset = "0x14F5D5C", VA = "0x14F5D5C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x14F5D64", Offset = "0x14F5D64", VA = "0x14F5D64")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x14F5D90", Offset = "0x14F5D90", VA = "0x14F5D90", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x14F5EB8", Offset = "0x14F5EB8", VA = "0x14F5EB8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x14F5EC0", Offset = "0x14F5EC0", VA = "0x14F5EC0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		private bool rotationChanged
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x14F608C", Offset = "0x14F608C", VA = "0x14F608C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x14F5EEC", Offset = "0x14F5EEC", VA = "0x14F5EEC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x14F615C", Offset = "0x14F615C", VA = "0x14F615C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x14F6164", Offset = "0x14F6164", VA = "0x14F6164")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class Constraints
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C354", Offset = "0x84C354")]
		public float positionWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C36C", Offset = "0x84C36C")]
		public float rotationWeight;

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x14F6190", Offset = "0x14F6190", VA = "0x14F6190")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x14F6200", Offset = "0x14F6200", VA = "0x14F6200")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x14F6254", Offset = "0x14F6254", VA = "0x14F6254")]
		public void Update()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x14F65B4", Offset = "0x14F65B4", VA = "0x14F65B4")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000A7")]
		public enum DOF
		{
			[Token(Token = "0x40004AC")]
			One,
			[Token(Token = "0x40004AD")]
			Three
		}

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C384", Offset = "0x84C384")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C384", Offset = "0x84C384")]
		public float weight;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C3D8", Offset = "0x84C3D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C3D8", Offset = "0x84C3D8")]
		public float rotationWeight;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C42C", Offset = "0x84C42C")]
		public DOF rotationDOF;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C464", Offset = "0x84C464")]
		public Transform bone1;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C49C", Offset = "0x84C49C")]
		public Transform bone2;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C4D4", Offset = "0x84C4D4")]
		public Transform bone3;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C50C", Offset = "0x84C50C")]
		public Transform tip;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C544", Offset = "0x84C544")]
		public Transform target;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C57C", Offset = "0x84C57C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000022")]
		public bool initiated
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x14FE0AC", Offset = "0x14FE0AC", VA = "0x14FE0AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8541D0", Offset = "0x8541D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x14FE0B4", Offset = "0x14FE0B4", VA = "0x14FE0B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8541E0", Offset = "0x8541E0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x14FE0C0", Offset = "0x14FE0C0", VA = "0x14FE0C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x14FE0E0", Offset = "0x14FE0E0", VA = "0x14FE0E0")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x14FE100", Offset = "0x14FE100", VA = "0x14FE100")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x14FE120", Offset = "0x14FE120", VA = "0x14FE120")]
			set
			{
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x14FE140", Offset = "0x14FE140", VA = "0x14FE140")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x14FE240", Offset = "0x14FE240", VA = "0x14FE240")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x14FE654", Offset = "0x14FE654", VA = "0x14FE654")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x14FE730", Offset = "0x14FE730", VA = "0x14FE730")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x14FE7F8", Offset = "0x14FE7F8", VA = "0x14FE7F8")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x14FEBAC", Offset = "0x14FEBAC", VA = "0x14FEBAC")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C58C", Offset = "0x84C58C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C58C", Offset = "0x84C58C")]
		public float weight;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C5E0", Offset = "0x84C5E0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000025")]
		public bool initiated
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x14FEBBC", Offset = "0x14FEBBC", VA = "0x14FEBBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8541F0", Offset = "0x8541F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x14FEBC4", Offset = "0x14FEBC4", VA = "0x14FEBC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854200", Offset = "0x854200")]
			private set
			{
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x14FEBD0", Offset = "0x14FEBD0", VA = "0x14FEBD0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x14FEC58", Offset = "0x14FEC58", VA = "0x14FEC58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854210", Offset = "0x854210")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x14FEF7C", Offset = "0x14FEF7C", VA = "0x14FEF7C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x14FF0EC", Offset = "0x14FF0EC", VA = "0x14FF0EC")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x14FEE74", Offset = "0x14FEE74", VA = "0x14FEE74")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x14FF254", Offset = "0x14FF254", VA = "0x14FF254", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x14FF314", Offset = "0x14FF314", VA = "0x14FF314")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x14FF38C", Offset = "0x14FF38C", VA = "0x14FF38C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x14FF400", Offset = "0x14FF400", VA = "0x14FF400")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x14FF468", Offset = "0x14FF468", VA = "0x14FF468", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x14FF46C", Offset = "0x14FF46C", VA = "0x14FF46C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x14FF480", Offset = "0x14FF480", VA = "0x14FF480")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C5F0", Offset = "0x84C5F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C5F0", Offset = "0x84C5F0")]
		public float weight;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C644", Offset = "0x84C644")]
		public Grounding solver;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84C67C", Offset = "0x84C67C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000026")]
		public bool initiated
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x15004B4", Offset = "0x15004B4", VA = "0x15004B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854248", Offset = "0x854248")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x15004BC", Offset = "0x15004BC", VA = "0x15004BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854258", Offset = "0x854258")]
			protected set
			{
			}
		}

		[Token(Token = "0x600026E")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x15004C8", Offset = "0x15004C8", VA = "0x15004C8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x150079C", Offset = "0x150079C", VA = "0x150079C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x150060C", Offset = "0x150060C", VA = "0x150060C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x15007D0", Offset = "0x15007D0", VA = "0x15007D0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000275")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000276")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x15009D8", Offset = "0x15009D8", VA = "0x15009D8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B218", Offset = "0x84B218")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B218", Offset = "0x84B218")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C68C", Offset = "0x84C68C")]
		public BipedIK ik;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C6C4", Offset = "0x84C6C4")]
		public float spineBend;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C6FC", Offset = "0x84C6FC")]
		public float spineSpeed;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1500D40", Offset = "0x1500D40", VA = "0x1500D40", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854268", Offset = "0x854268")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1500D8C", Offset = "0x1500D8C", VA = "0x1500D8C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8542A0", Offset = "0x8542A0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1500DD8", Offset = "0x1500DD8", VA = "0x1500DD8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1500EDC", Offset = "0x1500EDC", VA = "0x1500EDC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1500F8C", Offset = "0x1500F8C", VA = "0x1500F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1501040", Offset = "0x1501040", VA = "0x1501040")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1501554", Offset = "0x1501554", VA = "0x1501554")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x15015A8", Offset = "0x15015A8", VA = "0x15015A8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1501D5C", Offset = "0x1501D5C", VA = "0x1501D5C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1501EBC", Offset = "0x1501EBC", VA = "0x1501EBC")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x150204C", Offset = "0x150204C", VA = "0x150204C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x15021BC", Offset = "0x15021BC", VA = "0x15021BC")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B278", Offset = "0x84B278")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B278", Offset = "0x84B278")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public class SpineEffector
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F708", Offset = "0x84F708")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F740", Offset = "0x84F740")]
			public float horizontalWeight;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F778", Offset = "0x84F778")]
			public float verticalWeight;

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1503024", Offset = "0x1503024", VA = "0x1503024")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1503034", Offset = "0x1503034", VA = "0x1503034")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C734", Offset = "0x84C734")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C76C", Offset = "0x84C76C")]
		public float spineBend;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C7A4", Offset = "0x84C7A4")]
		public float spineSpeed;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x150223C", Offset = "0x150223C", VA = "0x150223C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8542D8", Offset = "0x8542D8")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1502288", Offset = "0x1502288", VA = "0x1502288", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854310", Offset = "0x854310")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15022D4", Offset = "0x15022D4", VA = "0x15022D4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854348", Offset = "0x854348")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1502320", Offset = "0x1502320", VA = "0x1502320", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15023A0", Offset = "0x15023A0", VA = "0x15023A0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1502438", Offset = "0x1502438", VA = "0x1502438")]
		private void Update()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15026F4", Offset = "0x15026F4", VA = "0x15026F4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1502700", Offset = "0x1502700", VA = "0x1502700")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x15024F4", Offset = "0x15024F4", VA = "0x15024F4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x150270C", Offset = "0x150270C", VA = "0x150270C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1502BAC", Offset = "0x1502BAC", VA = "0x1502BAC")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1502D6C", Offset = "0x1502D6C", VA = "0x1502D6C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1502EA4", Offset = "0x1502EA4", VA = "0x1502EA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1502FA4", Offset = "0x1502FA4", VA = "0x1502FA4")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B2D8", Offset = "0x84B2D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B2D8", Offset = "0x84B2D8")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C7DC", Offset = "0x84C7DC")]
		public Transform pelvis;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C814", Offset = "0x84C814")]
		public Transform characterRoot;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C84C", Offset = "0x84C84C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C84C", Offset = "0x84C84C")]
		public float rootRotationWeight;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C8A0", Offset = "0x84C8A0")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C8D8", Offset = "0x84C8D8")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x150307C", Offset = "0x150307C", VA = "0x150307C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854380", Offset = "0x854380")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15030C8", Offset = "0x15030C8", VA = "0x15030C8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8543B8", Offset = "0x8543B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x1503114", Offset = "0x1503114", VA = "0x1503114", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x150312C", Offset = "0x150312C", VA = "0x150312C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x150331C", Offset = "0x150331C", VA = "0x150331C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x150341C", Offset = "0x150341C", VA = "0x150341C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1503B64", Offset = "0x1503B64", VA = "0x1503B64")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1503F48", Offset = "0x1503F48", VA = "0x1503F48")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x15041B8", Offset = "0x15041B8", VA = "0x15041B8")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x15044D8", Offset = "0x15044D8", VA = "0x15044D8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1504664", Offset = "0x1504664", VA = "0x1504664")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x150482C", Offset = "0x150482C", VA = "0x150482C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B338", Offset = "0x84B338")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B338", Offset = "0x84B338")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000AA")]
		public struct Foot
		{
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x907BF4", Offset = "0x907BF4", VA = "0x907BF4")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C910", Offset = "0x84C910")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C948", Offset = "0x84C948")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C948", Offset = "0x84C948")]
		public float rootRotationWeight;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C99C", Offset = "0x84C99C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C99C", Offset = "0x84C99C")]
		public float minRootRotation;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84C9F4", Offset = "0x84C9F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84C9F4", Offset = "0x84C9F4")]
		public float maxRootRotation;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CA4C", Offset = "0x84CA4C")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CA84", Offset = "0x84CA84")]
		public float maxLegOffset;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CABC", Offset = "0x84CABC")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CAF4", Offset = "0x84CAF4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CAF4", Offset = "0x84CAF4")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CB48", Offset = "0x84CB48")]
		public Transform characterRoot;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CB80", Offset = "0x84CB80")]
		public Transform pelvis;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CBB8", Offset = "0x84CBB8")]
		public Transform lastSpineBone;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CBF0", Offset = "0x84CBF0")]
		public Transform head;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x15048AC", Offset = "0x15048AC", VA = "0x15048AC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8543F0", Offset = "0x8543F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x15048F8", Offset = "0x15048F8", VA = "0x15048F8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854428", Offset = "0x854428")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1504944", Offset = "0x1504944", VA = "0x1504944", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1504978", Offset = "0x1504978", VA = "0x1504978")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1504AA8", Offset = "0x1504AA8", VA = "0x1504AA8")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x1504C68", Offset = "0x1504C68", VA = "0x1504C68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x1504CD0", Offset = "0x1504CD0", VA = "0x1504CD0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1504D88", Offset = "0x1504D88", VA = "0x1504D88")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1505088", Offset = "0x1505088", VA = "0x1505088")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15053E8", Offset = "0x15053E8", VA = "0x15053E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1505534", Offset = "0x1505534", VA = "0x1505534")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x15059D8", Offset = "0x15059D8", VA = "0x15059D8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x15061C8", Offset = "0x15061C8", VA = "0x15061C8")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1506488", Offset = "0x1506488", VA = "0x1506488")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x15065E8", Offset = "0x15065E8", VA = "0x15065E8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x15068C4", Offset = "0x15068C4", VA = "0x15068C4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x15068FC", Offset = "0x15068FC", VA = "0x15068FC")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1506ABC", Offset = "0x1506ABC", VA = "0x1506ABC")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B398", Offset = "0x84B398")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CC38", Offset = "0x84CC38")]
		public VRIK ik;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1506BD4", Offset = "0x1506BD4", VA = "0x1506BD4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854460", Offset = "0x854460")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1506BD8", Offset = "0x1506BD8", VA = "0x1506BD8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854498", Offset = "0x854498")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1506BDC", Offset = "0x1506BDC", VA = "0x1506BDC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8544D0", Offset = "0x8544D0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x1506BE0", Offset = "0x1506BE0", VA = "0x1506BE0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x1506BF8", Offset = "0x1506BF8", VA = "0x1506BF8")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1506C90", Offset = "0x1506C90", VA = "0x1506C90")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1506D44", Offset = "0x1506D44", VA = "0x1506D44")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1506F44", Offset = "0x1506F44", VA = "0x1506F44")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x15071D8", Offset = "0x15071D8", VA = "0x15071D8")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x15072E0", Offset = "0x15072E0", VA = "0x15072E0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x15074E0", Offset = "0x15074E0", VA = "0x15074E0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1507618", Offset = "0x1507618", VA = "0x1507618")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1507778", Offset = "0x1507778", VA = "0x1507778")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public enum Quality
		{
			[Token(Token = "0x40004B6")]
			Fastest,
			[Token(Token = "0x40004B7")]
			Simple,
			[Token(Token = "0x40004B8")]
			Best
		}

		[Token(Token = "0x20000AC")]
		public class Leg
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F7B0", Offset = "0x84F7B0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F7C0", Offset = "0x84F7C0")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F7D0", Offset = "0x84F7D0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F7E0", Offset = "0x84F7E0")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F7F0", Offset = "0x84F7F0")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F800", Offset = "0x84F800")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F810", Offset = "0x84F810")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000CD")]
			public bool isGrounded
			{
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x1508F88", Offset = "0x1508F88", VA = "0x1508F88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A24", Offset = "0x856A24")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x1508F90", Offset = "0x1508F90", VA = "0x1508F90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A34", Offset = "0x856A34")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CE")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x1508F9C", Offset = "0x1508F9C", VA = "0x1508F9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A44", Offset = "0x856A44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x1508FA8", Offset = "0x1508FA8", VA = "0x1508FA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A54", Offset = "0x856A54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public bool initiated
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0x1508FB4", Offset = "0x1508FB4", VA = "0x1508FB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A64", Offset = "0x856A64")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600074B")]
				[Address(RVA = "0x1508FBC", Offset = "0x1508FBC", VA = "0x1508FBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A74", Offset = "0x856A74")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public float heightFromGround
			{
				[Token(Token = "0x600074C")]
				[Address(RVA = "0x1508FC8", Offset = "0x1508FC8", VA = "0x1508FC8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A84", Offset = "0x856A84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600074D")]
				[Address(RVA = "0x1508FD0", Offset = "0x1508FD0", VA = "0x1508FD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856A94", Offset = "0x856A94")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			public Vector3 velocity
			{
				[Token(Token = "0x600074E")]
				[Address(RVA = "0x1508FD8", Offset = "0x1508FD8", VA = "0x1508FD8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AA4", Offset = "0x856AA4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600074F")]
				[Address(RVA = "0x1508FE4", Offset = "0x1508FE4", VA = "0x1508FE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AB4", Offset = "0x856AB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public Transform transform
			{
				[Token(Token = "0x6000750")]
				[Address(RVA = "0x1508FF0", Offset = "0x1508FF0", VA = "0x1508FF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AC4", Offset = "0x856AC4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000751")]
				[Address(RVA = "0x1508FF8", Offset = "0x1508FF8", VA = "0x1508FF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AD4", Offset = "0x856AD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public float IKOffset
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x1509000", Offset = "0x1509000", VA = "0x1509000")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AE4", Offset = "0x856AE4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000753")]
				[Address(RVA = "0x1509008", Offset = "0x1509008", VA = "0x1509008")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856AF4", Offset = "0x856AF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000758")]
				[Address(RVA = "0x1509B58", Offset = "0x1509B58", VA = "0x1509B58")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D5")]
			private float rootYOffset
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x1509E4C", Offset = "0x1509E4C", VA = "0x1509E4C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1507E10", Offset = "0x1507E10", VA = "0x1507E10")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1509010", Offset = "0x1509010", VA = "0x1509010")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1508AA8", Offset = "0x1508AA8", VA = "0x1508AA8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1507F1C", Offset = "0x1507F1C", VA = "0x1507F1C")]
			public void Process()
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x15096F0", Offset = "0x15096F0", VA = "0x15096F0")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x150905C", Offset = "0x150905C", VA = "0x150905C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1509CD8", Offset = "0x1509CD8", VA = "0x1509CD8")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1509380", Offset = "0x1509380", VA = "0x1509380")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1509488", Offset = "0x1509488", VA = "0x1509488")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1509DD4", Offset = "0x1509DD4", VA = "0x1509DD4")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1509BE4", Offset = "0x1509BE4", VA = "0x1509BE4")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x1509F80", Offset = "0x1509F80", VA = "0x1509F80")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x1507D60", Offset = "0x1507D60", VA = "0x1507D60")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000AD")]
		public class Pelvis
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F820", Offset = "0x84F820")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F830", Offset = "0x84F830")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000D6")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000763")]
				[Address(RVA = "0x150A070", Offset = "0x150A070", VA = "0x150A070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B04", Offset = "0x856B04")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000764")]
				[Address(RVA = "0x150A07C", Offset = "0x150A07C", VA = "0x150A07C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B14", Offset = "0x856B14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			public float heightOffset
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0x150A088", Offset = "0x150A088", VA = "0x150A088")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B24", Offset = "0x856B24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x150A090", Offset = "0x150A090", VA = "0x150A090")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B34", Offset = "0x856B34")]
				private set
				{
				}
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1507EF4", Offset = "0x1507EF4", VA = "0x1507EF4")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x15089F8", Offset = "0x15089F8", VA = "0x15089F8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x150A098", Offset = "0x150A098", VA = "0x150A098")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x150878C", Offset = "0x150878C", VA = "0x150878C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1507E08", Offset = "0x1507E08", VA = "0x1507E08")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CC70", Offset = "0x84CC70")]
		public LayerMask layers;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CCA8", Offset = "0x84CCA8")]
		public float maxStep;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CCE0", Offset = "0x84CCE0")]
		public float heightOffset;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CD18", Offset = "0x84CD18")]
		public float footSpeed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CD50", Offset = "0x84CD50")]
		public float footRadius;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CD88", Offset = "0x84CD88")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CDD4", Offset = "0x84CDD4")]
		public float prediction;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CE0C", Offset = "0x84CE0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CE0C", Offset = "0x84CE0C")]
		public float footRotationWeight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CE60", Offset = "0x84CE60")]
		public float footRotationSpeed;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CE98", Offset = "0x84CE98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CE98", Offset = "0x84CE98")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CEF0", Offset = "0x84CEF0")]
		public bool rotateSolver;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CF28", Offset = "0x84CF28")]
		public float pelvisSpeed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CF60", Offset = "0x84CF60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84CF60", Offset = "0x84CF60")]
		public float pelvisDamper;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CFB4", Offset = "0x84CFB4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84CFEC", Offset = "0x84CFEC")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D024", Offset = "0x84D024")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D05C", Offset = "0x84D05C")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D094", Offset = "0x84D094")]
		public Quality quality;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D0CC", Offset = "0x84D0CC")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D0DC", Offset = "0x84D0DC")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D0EC", Offset = "0x84D0EC")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D0FC", Offset = "0x84D0FC")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D10C", Offset = "0x84D10C")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000027")]
		public Leg[] legs
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x15077D4", Offset = "0x15077D4", VA = "0x15077D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854508", Offset = "0x854508")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x15077DC", Offset = "0x15077DC", VA = "0x15077DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854518", Offset = "0x854518")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x15077E4", Offset = "0x15077E4", VA = "0x15077E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854528", Offset = "0x854528")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x15077EC", Offset = "0x15077EC", VA = "0x15077EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854538", Offset = "0x854538")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool isGrounded
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x15077F4", Offset = "0x15077F4", VA = "0x15077F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854548", Offset = "0x854548")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x15077FC", Offset = "0x15077FC", VA = "0x15077FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854558", Offset = "0x854558")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Transform root
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1507808", Offset = "0x1507808", VA = "0x1507808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854568", Offset = "0x854568")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1507810", Offset = "0x1507810", VA = "0x1507810")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854578", Offset = "0x854578")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1507818", Offset = "0x1507818", VA = "0x1507818")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854588", Offset = "0x854588")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1507830", Offset = "0x1507830", VA = "0x1507830")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x854598", Offset = "0x854598")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1507850", Offset = "0x1507850", VA = "0x1507850")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 up
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1501E30", Offset = "0x1501E30", VA = "0x1501E30")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1508B5C", Offset = "0x1508B5C", VA = "0x1508B5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x15078A4", Offset = "0x15078A4", VA = "0x15078A4")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1507C84", Offset = "0x1507C84", VA = "0x1507C84")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x15012F4", Offset = "0x15012F4", VA = "0x15012F4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1501AF4", Offset = "0x1501AF4", VA = "0x1501AF4")]
		public void Update()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x150394C", Offset = "0x150394C", VA = "0x150394C")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1500E58", Offset = "0x1500E58", VA = "0x1500E58")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1507F04", Offset = "0x1507F04", VA = "0x1507F04")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1508C2C", Offset = "0x1508C2C", VA = "0x1508C2C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1508D94", Offset = "0x1508D94", VA = "0x1508D94")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1508E98", Offset = "0x1508E98", VA = "0x1508E98")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1500A98", Offset = "0x1500A98", VA = "0x1500A98")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B3D0", Offset = "0x84B3D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B3D0", Offset = "0x84B3D0")]
	public class AimIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11A59CC", Offset = "0x11A59CC", VA = "0x11A59CC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8545A8", Offset = "0x8545A8")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11A5A18", Offset = "0x11A5A18", VA = "0x11A5A18", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8545E0", Offset = "0x8545E0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11A5A64", Offset = "0x11A5A64", VA = "0x11A5A64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854618", Offset = "0x854618")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11A5AB0", Offset = "0x11A5AB0", VA = "0x11A5AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854650", Offset = "0x854650")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x11A5AFC", Offset = "0x11A5AFC", VA = "0x11A5AFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854688", Offset = "0x854688")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11A5B48", Offset = "0x11A5B48", VA = "0x11A5B48", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11A5B50", Offset = "0x11A5B50", VA = "0x11A5B50")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B430", Offset = "0x84B430")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11A6600", Offset = "0x11A6600", VA = "0x11A6600", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8546C0", Offset = "0x8546C0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11A666C", Offset = "0x11A666C", VA = "0x11A666C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8546F8", Offset = "0x8546F8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11A66D8", Offset = "0x11A66D8", VA = "0x11A66D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854730", Offset = "0x854730")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11A6724", Offset = "0x11A6724", VA = "0x11A6724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854768", Offset = "0x854768")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11A6770", Offset = "0x11A6770", VA = "0x11A6770", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11A6778", Offset = "0x11A6778", VA = "0x11A6778")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B468", Offset = "0x84B468")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B468", Offset = "0x84B468")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x14F57A4", Offset = "0x14F57A4", VA = "0x14F57A4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8547A0", Offset = "0x8547A0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x14F57F0", Offset = "0x14F57F0", VA = "0x14F57F0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8547D8", Offset = "0x8547D8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x14F583C", Offset = "0x14F583C", VA = "0x14F583C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854810", Offset = "0x854810")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x14F5888", Offset = "0x14F5888", VA = "0x14F5888")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854848", Offset = "0x854848")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x14F58D4", Offset = "0x14F58D4", VA = "0x14F58D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x14F58DC", Offset = "0x14F58DC", VA = "0x14F58DC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B4C8", Offset = "0x84B4C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B4C8", Offset = "0x84B4C8")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x14F65BC", Offset = "0x14F65BC", VA = "0x14F65BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854880", Offset = "0x854880")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x14F6608", Offset = "0x14F6608", VA = "0x14F6608", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8548B8", Offset = "0x8548B8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x14F6654", Offset = "0x14F6654", VA = "0x14F6654")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8548F0", Offset = "0x8548F0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x14F66A0", Offset = "0x14F66A0", VA = "0x14F66A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854928", Offset = "0x854928")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x14F66EC", Offset = "0x14F66EC", VA = "0x14F66EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x14F66F4", Offset = "0x14F66F4", VA = "0x14F66F4")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B528", Offset = "0x84B528")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B528", Offset = "0x84B528")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x14F6D74", Offset = "0x14F6D74", VA = "0x14F6D74", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854960", Offset = "0x854960")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x14F6DC0", Offset = "0x14F6DC0", VA = "0x14F6DC0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854998", Offset = "0x854998")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x14F6E0C", Offset = "0x14F6E0C", VA = "0x14F6E0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8549D0", Offset = "0x8549D0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x14F6E58", Offset = "0x14F6E58", VA = "0x14F6E58")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854A08", Offset = "0x854A08")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x14F6EA4", Offset = "0x14F6EA4", VA = "0x14F6EA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x14F6EAC", Offset = "0x14F6EAC", VA = "0x14F6EAC")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B588", Offset = "0x84B588")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B588", Offset = "0x84B588")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x14FF4E8", Offset = "0x14FF4E8", VA = "0x14FF4E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854A40", Offset = "0x854A40")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x14FF534", Offset = "0x14FF534", VA = "0x14FF534", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854A78", Offset = "0x854A78")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x14FF580", Offset = "0x14FF580", VA = "0x14FF580")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854AB0", Offset = "0x854AB0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x14FF5CC", Offset = "0x14FF5CC", VA = "0x14FF5CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854AE8", Offset = "0x854AE8")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x14FF618", Offset = "0x14FF618", VA = "0x14FF618")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854B20", Offset = "0x854B20")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x14FF664", Offset = "0x14FF664", VA = "0x14FF664")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854B58", Offset = "0x854B58")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x14FF6B0", Offset = "0x14FF6B0", VA = "0x14FF6B0")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x14FF6D4", Offset = "0x14FF6D4", VA = "0x14FF6D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x14FF6DC", Offset = "0x14FF6DC", VA = "0x14FF6DC")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x14FF898", Offset = "0x14FF898", VA = "0x14FF898")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x14FFBEC", Offset = "0x14FFBEC", VA = "0x14FFBEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854B90", Offset = "0x854B90")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x14FFC0C", Offset = "0x14FFC0C", VA = "0x14FFC0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854BC8", Offset = "0x854BC8")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x14FFCE8", Offset = "0x14FFCE8", VA = "0x14FFCE8")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000301")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x150CB80", Offset = "0x150CB80", VA = "0x150CB80", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x150CC08", Offset = "0x150CC08", VA = "0x150CC08", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x150CC7C", Offset = "0x150CC7C", VA = "0x150CC7C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000305")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000306")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x14F5944", Offset = "0x14F5944", VA = "0x14F5944")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D11C", Offset = "0x84D11C")]
		public IK[] IKComponents;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D154", Offset = "0x84D154")]
		public Animator animator;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700002F")]
		private bool animatePhysics
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x150F270", Offset = "0x150F270", VA = "0x150F270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x150F30C", Offset = "0x150F30C", VA = "0x150F30C")]
		private void Start()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x150F37C", Offset = "0x150F37C", VA = "0x150F37C")]
		private void Update()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x150F438", Offset = "0x150F438", VA = "0x150F438")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x150F474", Offset = "0x150F474", VA = "0x150F474")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x150F3B0", Offset = "0x150F3B0", VA = "0x150F3B0")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x150F504", Offset = "0x150F504", VA = "0x150F504")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B5E8", Offset = "0x84B5E8")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1586468", Offset = "0x1586468", VA = "0x1586468", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854C00", Offset = "0x854C00")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x15864D4", Offset = "0x15864D4", VA = "0x15864D4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854C38", Offset = "0x854C38")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1586540", Offset = "0x1586540", VA = "0x1586540")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854C70", Offset = "0x854C70")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x158658C", Offset = "0x158658C", VA = "0x158658C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854CA8", Offset = "0x854CA8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x15865D8", Offset = "0x15865D8", VA = "0x15865D8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x15865E0", Offset = "0x15865E0", VA = "0x15865E0")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B620", Offset = "0x84B620")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B620", Offset = "0x84B620")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1586648", Offset = "0x1586648", VA = "0x1586648", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854CE0", Offset = "0x854CE0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1586694", Offset = "0x1586694", VA = "0x1586694", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854D18", Offset = "0x854D18")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x15866E0", Offset = "0x15866E0", VA = "0x15866E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854D50", Offset = "0x854D50")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x158672C", Offset = "0x158672C", VA = "0x158672C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854D88", Offset = "0x854D88")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1586778", Offset = "0x1586778", VA = "0x1586778", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1586780", Offset = "0x1586780", VA = "0x1586780")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B680", Offset = "0x84B680")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B680", Offset = "0x84B680")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1587620", Offset = "0x1587620", VA = "0x1587620", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854DC0", Offset = "0x854DC0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x158766C", Offset = "0x158766C", VA = "0x158766C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854DF8", Offset = "0x854DF8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x15876B8", Offset = "0x15876B8", VA = "0x15876B8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854E30", Offset = "0x854E30")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1587704", Offset = "0x1587704", VA = "0x1587704")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854E68", Offset = "0x854E68")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1587750", Offset = "0x1587750", VA = "0x1587750", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1587758", Offset = "0x1587758", VA = "0x1587758")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B6E0", Offset = "0x84B6E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B6E0", Offset = "0x84B6E0")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x18F7B70", Offset = "0x18F7B70", VA = "0x18F7B70", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854EA0", Offset = "0x854EA0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x18F7BBC", Offset = "0x18F7BBC", VA = "0x18F7BBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854ED8", Offset = "0x854ED8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x18F7C08", Offset = "0x18F7C08", VA = "0x18F7C08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854F10", Offset = "0x854F10")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x18F7C54", Offset = "0x18F7C54", VA = "0x18F7C54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854F48", Offset = "0x854F48")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x18F7CA0", Offset = "0x18F7CA0", VA = "0x18F7CA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x18F7CA8", Offset = "0x18F7CA8", VA = "0x18F7CA8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B740", Offset = "0x84B740")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public class References
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F840", Offset = "0x84F840")]
			public Transform chest;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F878", Offset = "0x84F878")]
			public Transform neck;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F8B0", Offset = "0x84F8B0")]
			public Transform leftShoulder;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F8E8", Offset = "0x84F8E8")]
			public Transform rightShoulder;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F920", Offset = "0x84F920")]
			public Transform leftThigh;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F958", Offset = "0x84F958")]
			public Transform leftCalf;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F990", Offset = "0x84F990")]
			public Transform leftFoot;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F9C8", Offset = "0x84F9C8")]
			public Transform leftToes;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA00", Offset = "0x84FA00")]
			public Transform rightThigh;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA38", Offset = "0x84FA38")]
			public Transform rightCalf;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FA70", Offset = "0x84FA70")]
			public Transform rightFoot;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FAA8", Offset = "0x84FAA8")]
			public Transform rightToes;

			[Token(Token = "0x170000D8")]
			public bool isFilled
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0x18F91E8", Offset = "0x18F91E8", VA = "0x18F91E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D9")]
			public bool isEmpty
			{
				[Token(Token = "0x600076E")]
				[Address(RVA = "0x18F8D6C", Offset = "0x18F8D6C", VA = "0x18F8D6C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x18F986C", Offset = "0x18F986C", VA = "0x18F986C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x18F8958", Offset = "0x18F8958", VA = "0x18F8958")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x18F9864", Offset = "0x18F9864", VA = "0x18F9864")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x84D18C", Offset = "0x84D18C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D18C", Offset = "0x84D18C")]
		public References references;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D208", Offset = "0x84D208")]
		public IKSolverVR solver;

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x18F880C", Offset = "0x18F880C", VA = "0x18F880C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854F80", Offset = "0x854F80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x18F8878", Offset = "0x18F8878", VA = "0x18F8878", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854FB8", Offset = "0x854FB8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x18F88E4", Offset = "0x18F88E4", VA = "0x18F88E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x854FF0", Offset = "0x854FF0")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x18F8930", Offset = "0x18F8930", VA = "0x18F8930")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855028", Offset = "0x855028")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x18F8CC8", Offset = "0x18F8CC8", VA = "0x18F8CC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855060", Offset = "0x855060")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x18F8CF0", Offset = "0x18F8CF0", VA = "0x18F8CF0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x18F8CF8", Offset = "0x18F8CF8", VA = "0x18F8CF8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x18F9664", Offset = "0x18F9664", VA = "0x18F9664", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x18F97DC", Offset = "0x18F97DC", VA = "0x18F97DC")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class FABRIKChain
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D240", Offset = "0x84D240")]
		public float pull;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D258", Offset = "0x84D258")]
		public float pin;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x14F675C", Offset = "0x14F675C", VA = "0x14F675C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x14F6824", Offset = "0x14F6824", VA = "0x14F6824")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x14F6844", Offset = "0x14F6844", VA = "0x14F6844")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x14F6C14", Offset = "0x14F6C14", VA = "0x14F6C14")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x14F6918", Offset = "0x14F6918", VA = "0x14F6918")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x14F6D0C", Offset = "0x14F6D0C", VA = "0x14F6D0C")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x14F6F14", Offset = "0x14F6F14", VA = "0x14F6F14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x14F747C", Offset = "0x14F747C", VA = "0x14F747C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x14F763C", Offset = "0x14F763C", VA = "0x14F763C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x14F7734", Offset = "0x14F7734", VA = "0x14F7734")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class BendBone
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FAE0", Offset = "0x84FAE0")]
			public Transform transform;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FB18", Offset = "0x84FB18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FB18", Offset = "0x84FB18")]
			public float weight;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x14FA7C4", Offset = "0x14FA7C4", VA = "0x14FA7C4")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x14FA844", Offset = "0x14FA844", VA = "0x14FA844")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x14F7EF4", Offset = "0x14F7EF4", VA = "0x14F7EF4")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x14F82F8", Offset = "0x14F82F8", VA = "0x14F82F8")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D270", Offset = "0x84D270")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84D2A8", Offset = "0x84D2A8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D2A8", Offset = "0x84D2A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D2A8", Offset = "0x84D2A8")]
		public float positionWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D320", Offset = "0x84D320")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D320", Offset = "0x84D320")]
		public float bodyWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D374", Offset = "0x84D374")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D374", Offset = "0x84D374")]
		public float thighWeight;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D3C8", Offset = "0x84D3C8")]
		public bool handsPullBody;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84D400", Offset = "0x84D400")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D400", Offset = "0x84D400")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D400", Offset = "0x84D400")]
		public float rotationWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D478", Offset = "0x84D478")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D478", Offset = "0x84D478")]
		public float bodyClampWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D4CC", Offset = "0x84D4CC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D4CC", Offset = "0x84D4CC")]
		public float headClampWeight;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D520", Offset = "0x84D520")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D520", Offset = "0x84D520")]
		public float bendWeight;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D574", Offset = "0x84D574")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84D5AC", Offset = "0x84D5AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D5AC", Offset = "0x84D5AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D5AC", Offset = "0x84D5AC")]
		public float CCDWeight;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D624", Offset = "0x84D624")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D624", Offset = "0x84D624")]
		public float roll;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D678", Offset = "0x84D678")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D678", Offset = "0x84D678")]
		public float damper;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D6D0", Offset = "0x84D6D0")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84D708", Offset = "0x84D708")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D708", Offset = "0x84D708")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D708", Offset = "0x84D708")]
		public float postStretchWeight;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D780", Offset = "0x84D780")]
		public float maxStretch;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D7B8", Offset = "0x84D7B8")]
		public float stretchDamper;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D7F0", Offset = "0x84D7F0")]
		public bool fixHead;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84D828", Offset = "0x84D828")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x84D860", Offset = "0x84D860")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D898", Offset = "0x84D898")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x14F773C", Offset = "0x14F773C", VA = "0x14F773C")]
		private void Start()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x14F7A6C", Offset = "0x14F7A6C", VA = "0x14F7A6C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x14F7F2C", Offset = "0x14F7F2C", VA = "0x14F7F2C")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x14F8320", Offset = "0x14F8320", VA = "0x14F8320")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x14F8C98", Offset = "0x14F8C98", VA = "0x14F8C98")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x14F8FE4", Offset = "0x14F8FE4", VA = "0x14F8FE4")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x14F9380", Offset = "0x14F9380", VA = "0x14F9380")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x14F9DE4", Offset = "0x14F9DE4", VA = "0x14F9DE4")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x14F89C4", Offset = "0x14F89C4", VA = "0x14F89C4")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x14F9FF4", Offset = "0x14F9FF4", VA = "0x14F9FF4")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x14F9CA8", Offset = "0x14F9CA8", VA = "0x14F9CA8")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x14F9B0C", Offset = "0x14F9B0C", VA = "0x14F9B0C")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x14FA3C8", Offset = "0x14FA3C8", VA = "0x14FA3C8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x14FA648", Offset = "0x14FA648", VA = "0x14FA648")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public class ChildConstraint
		{
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FB8C", Offset = "0x84FB8C")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FB9C", Offset = "0x84FB9C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000DA")]
			public float nominalDistance
			{
				[Token(Token = "0x6000775")]
				[Address(RVA = "0x14FE03C", Offset = "0x14FE03C", VA = "0x14FE03C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B44", Offset = "0x856B44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000776")]
				[Address(RVA = "0x14FE044", Offset = "0x14FE044", VA = "0x14FE044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B54", Offset = "0x856B54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DB")]
			public bool isRigid
			{
				[Token(Token = "0x6000777")]
				[Address(RVA = "0x14FE04C", Offset = "0x14FE04C", VA = "0x14FE04C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B64", Offset = "0x856B64")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000778")]
				[Address(RVA = "0x14FE054", Offset = "0x14FE054", VA = "0x14FE054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B74", Offset = "0x856B74")]
				private set
				{
				}
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x14FE060", Offset = "0x14FE060", VA = "0x14FE060")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x14FB504", Offset = "0x14FB504", VA = "0x14FB504")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x14FBD00", Offset = "0x14FBD00", VA = "0x14FBD00")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x14FDD38", Offset = "0x14FDD38", VA = "0x14FDD38")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum Smoothing
		{
			[Token(Token = "0x40004F5")]
			None,
			[Token(Token = "0x40004F6")]
			Exponential,
			[Token(Token = "0x40004F7")]
			Cubic
		}

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D8B0", Offset = "0x84D8B0")]
		public float pin;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D8C8", Offset = "0x84D8C8")]
		public float pull;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D8E0", Offset = "0x84D8E0")]
		public float push;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D8F8", Offset = "0x84D8F8")]
		public float pushParent;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D910", Offset = "0x84D910")]
		public float reach;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001DB")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x14FA8E8", Offset = "0x14FA8E8", VA = "0x14FA8E8")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x14FAA34", Offset = "0x14FAA34", VA = "0x14FAA34")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x14FAB3C", Offset = "0x14FAB3C", VA = "0x14FAB3C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x14FAC60", Offset = "0x14FAC60", VA = "0x14FAC60")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x14FAD3C", Offset = "0x14FAD3C", VA = "0x14FAD3C")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x14FAE40", Offset = "0x14FAE40", VA = "0x14FAE40")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x14FB818", Offset = "0x14FB818", VA = "0x14FB818")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x14FAFCC", Offset = "0x14FAFCC", VA = "0x14FAFCC")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x14FBF04", Offset = "0x14FBF04", VA = "0x14FBF04")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x14FC2A8", Offset = "0x14FC2A8", VA = "0x14FC2A8")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x14FC68C", Offset = "0x14FC68C", VA = "0x14FC68C")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x14FD210", Offset = "0x14FD210", VA = "0x14FD210")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x14FD7E0", Offset = "0x14FD7E0", VA = "0x14FD7E0")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x14FDA78", Offset = "0x14FDA78", VA = "0x14FDA78")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x14FD6D8", Offset = "0x14FD6D8", VA = "0x14FD6D8")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x14FCFF8", Offset = "0x14FCFF8", VA = "0x14FCFF8")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x14FD660", Offset = "0x14FD660", VA = "0x14FD660")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x14FDB60", Offset = "0x14FDB60", VA = "0x14FDB60")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x14FD580", Offset = "0x14FD580", VA = "0x14FD580")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x14FD960", Offset = "0x14FD960", VA = "0x14FD960")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D928", Offset = "0x84D928")]
		public float weight;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D940", Offset = "0x84D940")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000030")]
		public bool initiated
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x150CEA4", Offset = "0x150CEA4", VA = "0x150CEA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855098", Offset = "0x855098")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x150CEAC", Offset = "0x150CEAC", VA = "0x150CEAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550A8", Offset = "0x8550A8")]
			private set
			{
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x150CCDC", Offset = "0x150CCDC", VA = "0x150CCDC")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x14FA9B0", Offset = "0x14FA9B0", VA = "0x14FA9B0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x150CEB8", Offset = "0x150CEB8", VA = "0x150CEB8")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x14FB55C", Offset = "0x14FB55C", VA = "0x14FB55C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x14FB568", Offset = "0x14FB568", VA = "0x14FB568")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x150D1A4", Offset = "0x150D1A4", VA = "0x150D1A4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x150D3DC", Offset = "0x150D3DC", VA = "0x150D3DC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x14FC9F4", Offset = "0x14FC9F4", VA = "0x14FC9F4")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x150CF64", Offset = "0x150CF64", VA = "0x150CF64")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x150D084", Offset = "0x150D084", VA = "0x150D084")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKEffector
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D950", Offset = "0x84D950")]
		public float positionWeight;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D968", Offset = "0x84D968")]
		public float rotationWeight;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84D980", Offset = "0x84D980")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D990", Offset = "0x84D990")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000031")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x150D878", Offset = "0x150D878", VA = "0x150D878")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550B8", Offset = "0x8550B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x150D880", Offset = "0x150D880", VA = "0x150D880")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550C8", Offset = "0x8550C8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x14FA360", Offset = "0x14FA360", VA = "0x14FA360")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x150D88C", Offset = "0x150D88C", VA = "0x150D88C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x150D960", Offset = "0x150D960", VA = "0x150D960")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x150DA9C", Offset = "0x150DA9C", VA = "0x150DA9C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x150DBF4", Offset = "0x150DBF4", VA = "0x150DBF4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x150DEE4", Offset = "0x150DEE4", VA = "0x150DEE4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x150E184", Offset = "0x150E184", VA = "0x150E184")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x150E2C4", Offset = "0x150E2C4", VA = "0x150E2C4")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x150E370", Offset = "0x150E370", VA = "0x150E370")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x150E9C4", Offset = "0x150E9C4", VA = "0x150E9C4")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x150EA34", Offset = "0x150EA34", VA = "0x150EA34")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x150EC4C", Offset = "0x150EC4C", VA = "0x150EC4C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x150EF94", Offset = "0x150EF94", VA = "0x150EF94")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000B2")]
		public class BoneMap
		{
			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000DC")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600077E")]
				[Address(RVA = "0x1413EA0", Offset = "0x1413EA0", VA = "0x1413EA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DD")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x141400C", Offset = "0x141400C", VA = "0x141400C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DE")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x14145E4", Offset = "0x14145E4", VA = "0x14145E4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1413DF8", Offset = "0x1413DF8", VA = "0x1413DF8")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1413F6C", Offset = "0x1413F6C", VA = "0x1413F6C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1413FBC", Offset = "0x1413FBC", VA = "0x1413FBC")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0x141401C", Offset = "0x141401C", VA = "0x141401C")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1414104", Offset = "0x1414104", VA = "0x1414104")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x141410C", Offset = "0x141410C", VA = "0x141410C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x141429C", Offset = "0x141429C", VA = "0x141429C")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x14143A8", Offset = "0x14143A8", VA = "0x14143A8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1414434", Offset = "0x1414434", VA = "0x1414434")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1414808", Offset = "0x1414808", VA = "0x1414808")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1414840", Offset = "0x1414840", VA = "0x1414840")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1414878", Offset = "0x1414878", VA = "0x1414878")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x14148A0", Offset = "0x14148A0", VA = "0x14148A0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1414A24", Offset = "0x1414A24", VA = "0x1414A24")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1414D5C", Offset = "0x1414D5C", VA = "0x1414D5C")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600078E")]
			[Address(RVA = "0x1414D8C", Offset = "0x1414D8C", VA = "0x1414D8C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600078F")]
			[Address(RVA = "0x1414F24", Offset = "0x1414F24", VA = "0x1414F24")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000790")]
			[Address(RVA = "0x1414F94", Offset = "0x1414F94", VA = "0x1414F94")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x14151D8", Offset = "0x14151D8", VA = "0x14151D8")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x1415400", Offset = "0x1415400", VA = "0x1415400")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1415518", Offset = "0x1415518", VA = "0x1415518")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1414B64", Offset = "0x1414B64", VA = "0x1414B64")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x14156A8", Offset = "0x14156A8", VA = "0x14156A8")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1413BB8", Offset = "0x1413BB8", VA = "0x1413BB8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1413BC0", Offset = "0x1413BC0", VA = "0x1413BC0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1413BC4", Offset = "0x1413BC4", VA = "0x1413BC4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1413CE8", Offset = "0x1413CE8", VA = "0x1413CE8")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1413DF0", Offset = "0x1413DF0", VA = "0x1413DF0")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D9A8", Offset = "0x84D9A8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x14156C4", Offset = "0x14156C4", VA = "0x14156C4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1415764", Offset = "0x1415764", VA = "0x1415764")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x14157E8", Offset = "0x14157E8", VA = "0x14157E8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1415880", Offset = "0x1415880", VA = "0x1415880")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1415898", Offset = "0x1415898", VA = "0x1415898")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x14158B4", Offset = "0x14158B4", VA = "0x14158B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1415950", Offset = "0x1415950", VA = "0x1415950")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1415968", Offset = "0x1415968", VA = "0x1415968")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public enum BoneMapType
		{
			[Token(Token = "0x400050F")]
			Parent,
			[Token(Token = "0x4000510")]
			Bone1,
			[Token(Token = "0x4000511")]
			Bone2,
			[Token(Token = "0x4000512")]
			Bone3
		}

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D9C0", Offset = "0x84D9C0")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D9D8", Offset = "0x84D9D8")]
		public float weight;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x141598C", Offset = "0x141598C", VA = "0x141598C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1415A10", Offset = "0x1415A10", VA = "0x1415A10")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1415AE4", Offset = "0x1415AE4", VA = "0x1415AE4")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1415E38", Offset = "0x1415E38", VA = "0x1415E38")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1415F38", Offset = "0x1415F38", VA = "0x1415F38")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1416064", Offset = "0x1416064", VA = "0x1416064")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1416070", Offset = "0x1416070", VA = "0x1416070")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1416118", Offset = "0x1416118", VA = "0x1416118")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x14161D0", Offset = "0x14161D0", VA = "0x14161D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1416440", Offset = "0x1416440", VA = "0x1416440")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x14164F8", Offset = "0x14164F8", VA = "0x14164F8")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84D9F0", Offset = "0x84D9F0")]
		public int iterations;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DA08", Offset = "0x84DA08")]
		public float twistWeight;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1416660", Offset = "0x1416660", VA = "0x1416660", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1416950", Offset = "0x1416950", VA = "0x1416950")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1416A6C", Offset = "0x1416A6C", VA = "0x1416A6C")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1416BC4", Offset = "0x1416BC4", VA = "0x1416BC4")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1416BD4", Offset = "0x1416BD4", VA = "0x1416BD4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1416C3C", Offset = "0x1416C3C", VA = "0x1416C3C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1416CBC", Offset = "0x1416CBC", VA = "0x1416CBC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1417310", Offset = "0x1417310", VA = "0x1417310")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1417348", Offset = "0x1417348", VA = "0x1417348")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1417628", Offset = "0x1417628", VA = "0x1417628")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x14179D4", Offset = "0x14179D4", VA = "0x14179D4")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1417AC0", Offset = "0x1417AC0", VA = "0x1417AC0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1417B88", Offset = "0x1417B88", VA = "0x1417B88")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B4")]
		public class Point
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FBAC", Offset = "0x84FBAC")]
			public float weight;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x141985C", Offset = "0x141985C", VA = "0x141985C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x14198AC", Offset = "0x14198AC", VA = "0x14198AC")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1419A34", Offset = "0x1419A34", VA = "0x1419A34")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x1419A6C", Offset = "0x1419A6C", VA = "0x1419A6C")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1419AA4", Offset = "0x1419AA4", VA = "0x1419AA4")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1419AF4", Offset = "0x1419AF4", VA = "0x1419AF4")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x1419330", Offset = "0x1419330", VA = "0x1419330")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public class Bone : Point
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000DF")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x1418900", Offset = "0x1418900", VA = "0x1418900")]
				get
				{
					return null;
				}
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x14189F4", Offset = "0x14189F4", VA = "0x14189F4")]
				set
				{
				}
			}

			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x1418A7C", Offset = "0x1418A7C", VA = "0x1418A7C")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x1418D3C", Offset = "0x1418D3C", VA = "0x1418D3C")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x141901C", Offset = "0x141901C", VA = "0x141901C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1419284", Offset = "0x1419284", VA = "0x1419284")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x14192AC", Offset = "0x14192AC", VA = "0x14192AC")]
			public Bone()
			{
			}

			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x14193B0", Offset = "0x14193B0", VA = "0x14193B0")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1419448", Offset = "0x1419448", VA = "0x1419448")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public class Node : Point
		{
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x14197F8", Offset = "0x14197F8", VA = "0x14197F8")]
			public Node()
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x14197FC", Offset = "0x14197FC", VA = "0x14197FC")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1419824", Offset = "0x1419824", VA = "0x1419824")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000B7")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000B8")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DA30", Offset = "0x84DA30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DA30", Offset = "0x84DA30")]
		public float IKPositionWeight;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DA84", Offset = "0x84DA84")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000032")]
		public bool initiated
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x1418350", Offset = "0x1418350", VA = "0x1418350")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550D8", Offset = "0x8550D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1418358", Offset = "0x1418358", VA = "0x1418358")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550E8", Offset = "0x8550E8")]
			private set
			{
			}
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1417E68", Offset = "0x1417E68", VA = "0x1417E68")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1417EE4", Offset = "0x1417EE4", VA = "0x1417EE4")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x141823C", Offset = "0x141823C", VA = "0x141823C")]
		public void Update()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x14182A4", Offset = "0x14182A4", VA = "0x14182A4", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x14182B0", Offset = "0x14182B0", VA = "0x14182B0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x14182BC", Offset = "0x14182BC", VA = "0x14182BC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x14182C4", Offset = "0x14182C4", VA = "0x14182C4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1418348", Offset = "0x1418348", VA = "0x1418348")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x60003A8")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x60003A9")]
		public abstract void FixTransforms();

		[Token(Token = "0x60003AA")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x60003AB")]
		protected abstract void OnInitiate();

		[Token(Token = "0x60003AC")]
		protected abstract void OnUpdate();

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1418364", Offset = "0x1418364", VA = "0x1418364")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x141837C", Offset = "0x141837C", VA = "0x141837C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x14184B8", Offset = "0x14184B8", VA = "0x14184B8")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1418564", Offset = "0x1418564", VA = "0x1418564")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x14188E8", Offset = "0x14188E8", VA = "0x14188E8")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DACC", Offset = "0x84DACC")]
		public float poleWeight;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DAE4", Offset = "0x84DAE4")]
		public float clampWeight;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DAFC", Offset = "0x84DAFC")]
		public int clampSmoothing;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000033")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1419C8C", Offset = "0x1419C8C", VA = "0x1419C8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1419D58", Offset = "0x1419D58", VA = "0x1419D58")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000035")]
		protected override int minBones
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x141AAC8", Offset = "0x141AAC8", VA = "0x141AAC8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x141B06C", Offset = "0x141B06C", VA = "0x141B06C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1419B8C", Offset = "0x1419B8C", VA = "0x1419B8C")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1419E24", Offset = "0x1419E24", VA = "0x1419E24", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x141A0A4", Offset = "0x141A0A4", VA = "0x141A0A4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x141AA14", Offset = "0x141AA14", VA = "0x141AA14")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x141A63C", Offset = "0x141A63C", VA = "0x141A63C")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x141AAD0", Offset = "0x141AAD0", VA = "0x141AAD0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x141B0E0", Offset = "0x141B0E0", VA = "0x141B0E0")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB14", Offset = "0x84DB14")]
		public float IKRotationWeight;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x141B1F0", Offset = "0x141B1F0", VA = "0x141B1F0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x141B564", Offset = "0x141B564", VA = "0x141B564")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x141B5D0", Offset = "0x141B5D0", VA = "0x141B5D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x141B72C", Offset = "0x141B72C", VA = "0x141B72C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x141B8C4", Offset = "0x141B8C4", VA = "0x141B8C4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x141B910", Offset = "0x141B910", VA = "0x141B910", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x141B970", Offset = "0x141B970", VA = "0x141B970", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x141BCE0", Offset = "0x141BCE0", VA = "0x141BCE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x141BD0C", Offset = "0x141BD0C", VA = "0x141BD0C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x141B9D4", Offset = "0x141B9D4", VA = "0x141B9D4")]
		private void Read()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x141BD78", Offset = "0x141BD78", VA = "0x141BD78")]
		private void Write()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x141BF04", Offset = "0x141BF04", VA = "0x141BF04")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x141C054", Offset = "0x141C054", VA = "0x141C054")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x141C104", Offset = "0x141C104", VA = "0x141C104", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x141C6F8", Offset = "0x141C6F8", VA = "0x141C6F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x141CE48", Offset = "0x141CE48", VA = "0x141CE48")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x141D59C", Offset = "0x141D59C", VA = "0x141D59C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000037")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x141E7BC", Offset = "0x141E7BC", VA = "0x141E7BC", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x141D5A0", Offset = "0x141D5A0", VA = "0x141D5A0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x141DCE8", Offset = "0x141DCE8", VA = "0x141DCE8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x141DE20", Offset = "0x141DE20", VA = "0x141DE20", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x141DEB8", Offset = "0x141DEB8", VA = "0x141DEB8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x141E45C", Offset = "0x141E45C", VA = "0x141E45C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x141E7C4", Offset = "0x141E7C4", VA = "0x141E7C4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x141D674", Offset = "0x141D674", VA = "0x141D674")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x141DDCC", Offset = "0x141DDCC", VA = "0x141DDCC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x141E760", Offset = "0x141E760", VA = "0x141E760")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x141DB10", Offset = "0x141DB10", VA = "0x141DB10")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x141F004", Offset = "0x141F004", VA = "0x141F004")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x141F114", Offset = "0x141F114", VA = "0x141F114")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x141F240", Offset = "0x141F240", VA = "0x141F240")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x141F358", Offset = "0x141F358", VA = "0x141F358")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x141E1C4", Offset = "0x141E1C4", VA = "0x141E1C4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x141E310", Offset = "0x141E310", VA = "0x141E310")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x141F544", Offset = "0x141F544", VA = "0x141F544")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x141EA7C", Offset = "0x141EA7C", VA = "0x141EA7C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x141DDBC", Offset = "0x141DDBC", VA = "0x141DDBC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x141FCAC", Offset = "0x141FCAC", VA = "0x141FCAC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x141F718", Offset = "0x141F718", VA = "0x141F718")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x141E8DC", Offset = "0x141E8DC", VA = "0x141E8DC")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x141E9B8", Offset = "0x141E9B8", VA = "0x141E9B8")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x141FD78", Offset = "0x141FD78", VA = "0x141FD78")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB2C", Offset = "0x84DB2C")]
		public float rootPin;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x141FDEC", Offset = "0x141FDEC", VA = "0x141FDEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x14206B8", Offset = "0x14206B8", VA = "0x14206B8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1420750", Offset = "0x1420750", VA = "0x1420750", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x14207F0", Offset = "0x14207F0", VA = "0x14207F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x14208F0", Offset = "0x14208F0", VA = "0x14208F0")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x142098C", Offset = "0x142098C", VA = "0x142098C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1420EF4", Offset = "0x1420EF4", VA = "0x1420EF4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x14210F4", Offset = "0x14210F4", VA = "0x14210F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1420FA4", Offset = "0x1420FA4", VA = "0x1420FA4")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1420BC0", Offset = "0x1420BC0", VA = "0x1420BC0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x142118C", Offset = "0x142118C", VA = "0x142118C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB44", Offset = "0x84DB44")]
		public int iterations;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1421204", Offset = "0x1421204", VA = "0x1421204")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x14212F8", Offset = "0x14212F8", VA = "0x14212F8")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1421354", Offset = "0x1421354", VA = "0x1421354")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x14149C8", Offset = "0x14149C8", VA = "0x14149C8")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1413E20", Offset = "0x1413E20", VA = "0x1413E20")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1421488", Offset = "0x1421488", VA = "0x1421488", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1421610", Offset = "0x1421610", VA = "0x1421610", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1421784", Offset = "0x1421784", VA = "0x1421784", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1421988", Offset = "0x1421988", VA = "0x1421988", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1421A58", Offset = "0x1421A58", VA = "0x1421A58", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1421B34", Offset = "0x1421B34", VA = "0x1421B34", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1421CA8", Offset = "0x1421CA8", VA = "0x1421CA8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1421E64", Offset = "0x1421E64", VA = "0x1421E64", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x14220AC", Offset = "0x14220AC", VA = "0x14220AC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x142237C", Offset = "0x142237C", VA = "0x142237C", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x14223C0", Offset = "0x14223C0", VA = "0x14223C0", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x14224A4", Offset = "0x14224A4", VA = "0x14224A4")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000264")]
		Body,
		[Token(Token = "0x4000265")]
		LeftShoulder,
		[Token(Token = "0x4000266")]
		RightShoulder,
		[Token(Token = "0x4000267")]
		LeftThigh,
		[Token(Token = "0x4000268")]
		RightThigh,
		[Token(Token = "0x4000269")]
		LeftHand,
		[Token(Token = "0x400026A")]
		RightHand,
		[Token(Token = "0x400026B")]
		LeftFoot,
		[Token(Token = "0x400026C")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400026E")]
		LeftArm,
		[Token(Token = "0x400026F")]
		RightArm,
		[Token(Token = "0x4000270")]
		LeftLeg,
		[Token(Token = "0x4000271")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB5C", Offset = "0x84DB5C")]
		public float spineStiffness;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB74", Offset = "0x84DB74")]
		public float pullBodyVertical;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DB8C", Offset = "0x84DB8C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DBA4", Offset = "0x84DBA4")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000038")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1422584", Offset = "0x1422584", VA = "0x1422584")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x14226CC", Offset = "0x14226CC", VA = "0x14226CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x14226D4", Offset = "0x14226D4", VA = "0x14226D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x14226DC", Offset = "0x14226DC", VA = "0x14226DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x14226E4", Offset = "0x14226E4", VA = "0x14226E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x14226EC", Offset = "0x14226EC", VA = "0x14226EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x14226F4", Offset = "0x14226F4", VA = "0x14226F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x14226FC", Offset = "0x14226FC", VA = "0x14226FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1422704", Offset = "0x1422704", VA = "0x1422704")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x142270C", Offset = "0x142270C", VA = "0x142270C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1422744", Offset = "0x1422744", VA = "0x1422744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x142277C", Offset = "0x142277C", VA = "0x142277C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x14227B4", Offset = "0x14227B4", VA = "0x14227B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x14227EC", Offset = "0x14227EC", VA = "0x14227EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1422820", Offset = "0x1422820", VA = "0x1422820")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1422858", Offset = "0x1422858", VA = "0x1422858")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1422890", Offset = "0x1422890", VA = "0x1422890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x14228C8", Offset = "0x14228C8", VA = "0x14228C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x1424844", Offset = "0x1424844", VA = "0x1424844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8550F8", Offset = "0x8550F8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1424850", Offset = "0x1424850", VA = "0x1424850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855108", Offset = "0x855108")]
			private set
			{
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x14228FC", Offset = "0x14228FC", VA = "0x14228FC")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1422A08", Offset = "0x1422A08", VA = "0x1422A08")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1422950", Offset = "0x1422950", VA = "0x1422950")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x1422AE4", Offset = "0x1422AE4", VA = "0x1422AE4")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x142258C", Offset = "0x142258C", VA = "0x142258C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1422BB4", Offset = "0x1422BB4", VA = "0x1422BB4")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1422C6C", Offset = "0x1422C6C", VA = "0x1422C6C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1422D20", Offset = "0x1422D20", VA = "0x1422D20")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1422DD4", Offset = "0x1422DD4", VA = "0x1422DD4")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1422DDC", Offset = "0x1422DDC", VA = "0x1422DDC")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x1422E10", Offset = "0x1422E10", VA = "0x1422E10")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1422ED8", Offset = "0x1422ED8", VA = "0x1422ED8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1423068", Offset = "0x1423068", VA = "0x1423068")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1424160", Offset = "0x1424160", VA = "0x1424160")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x14245F4", Offset = "0x14245F4", VA = "0x14245F4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1424654", Offset = "0x1424654", VA = "0x1424654")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1424474", Offset = "0x1424474", VA = "0x1424474")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1424534", Offset = "0x1424534", VA = "0x1424534")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x142485C", Offset = "0x142485C", VA = "0x142485C")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1424938", Offset = "0x1424938", VA = "0x1424938", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1424A80", Offset = "0x1424A80", VA = "0x1424A80")]
		private void PullBody()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1424C10", Offset = "0x1424C10", VA = "0x1424C10")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1424E10", Offset = "0x1424E10", VA = "0x1424E10")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1425010", Offset = "0x1425010", VA = "0x1425010", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1425344", Offset = "0x1425344", VA = "0x1425344", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1425444", Offset = "0x1425444", VA = "0x1425444")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700004B")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x1425C7C", Offset = "0x1425C7C", VA = "0x1425C7C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x1425C84", Offset = "0x1425C84", VA = "0x1425C84", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x1425C8C", Offset = "0x1425C8C", VA = "0x1425C8C", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x1425C9C", Offset = "0x1425C9C", VA = "0x1425C9C", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004F")]
		protected float positionOffset
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x141CD84", Offset = "0x141CD84", VA = "0x141CD84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1425450", Offset = "0x1425450", VA = "0x1425450")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x14255DC", Offset = "0x14255DC", VA = "0x14255DC")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1425718", Offset = "0x1425718", VA = "0x1425718", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1425780", Offset = "0x1425780", VA = "0x1425780", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x14257FC", Offset = "0x14257FC", VA = "0x14257FC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1425B80", Offset = "0x1425B80", VA = "0x1425B80", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1425B88", Offset = "0x1425B88", VA = "0x1425B88", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1425C94", Offset = "0x1425C94", VA = "0x1425C94", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1425C98", Offset = "0x1425C98", VA = "0x1425C98", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x141C184", Offset = "0x141C184", VA = "0x141C184")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x141C9EC", Offset = "0x141C9EC", VA = "0x141C9EC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1425DD0", Offset = "0x1425DD0", VA = "0x1425DD0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x141B174", Offset = "0x141B174", VA = "0x141B174")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DBB4", Offset = "0x84DBB4")]
		public float IKRotationWeight;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1426084", Offset = "0x1426084", VA = "0x1426084", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x14263F8", Offset = "0x14263F8", VA = "0x14263F8")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1426464", Offset = "0x1426464", VA = "0x1426464", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x14265C0", Offset = "0x14265C0", VA = "0x14265C0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1426758", Offset = "0x1426758", VA = "0x1426758", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x14267A4", Offset = "0x14267A4", VA = "0x14267A4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1426804", Offset = "0x1426804", VA = "0x1426804", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1426B74", Offset = "0x1426B74", VA = "0x1426B74", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1426BA0", Offset = "0x1426BA0", VA = "0x1426BA0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1426868", Offset = "0x1426868", VA = "0x1426868")]
		private void Read()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1426CA8", Offset = "0x1426CA8", VA = "0x1426CA8")]
		private void Write()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1426E34", Offset = "0x1426E34", VA = "0x1426E34")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public enum BendModifier
		{
			[Token(Token = "0x4000523")]
			Animation,
			[Token(Token = "0x4000524")]
			Target,
			[Token(Token = "0x4000525")]
			Parent,
			[Token(Token = "0x4000526")]
			Arm,
			[Token(Token = "0x4000527")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000BA")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x904F08", Offset = "0x904F08", VA = "0x904F08")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DBCC", Offset = "0x84DBCC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DBE4", Offset = "0x84DBE4")]
		public float bendModifierWeight;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000050")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x1428684", Offset = "0x1428684", VA = "0x1428684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1426F84", Offset = "0x1426F84", VA = "0x1426F84")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1426FD4", Offset = "0x1426FD4", VA = "0x1426FD4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x14270E8", Offset = "0x14270E8", VA = "0x14270E8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1427750", Offset = "0x1427750", VA = "0x1427750", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1428330", Offset = "0x1428330", VA = "0x1428330", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1428478", Offset = "0x1428478", VA = "0x1428478")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x14285FC", Offset = "0x14285FC", VA = "0x14285FC")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x142745C", Offset = "0x142745C", VA = "0x142745C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x142787C", Offset = "0x142787C", VA = "0x142787C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000E0")]
			public Vector3 forward
			{
				[Token(Token = "0x60007B7")]
				[Address(RVA = "0x142A510", Offset = "0x142A510", VA = "0x142A510")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x142AC68", Offset = "0x142AC68", VA = "0x142AC68")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x14298B0", Offset = "0x14298B0", VA = "0x14298B0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x1429BE8", Offset = "0x1429BE8", VA = "0x1429BE8")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x142A914", Offset = "0x142A914", VA = "0x142A914")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DBFC", Offset = "0x84DBFC")]
		public float bodyWeight;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC14", Offset = "0x84DC14")]
		public float headWeight;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC2C", Offset = "0x84DC2C")]
		public float eyesWeight;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC44", Offset = "0x84DC44")]
		public float clampWeight;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC5C", Offset = "0x84DC5C")]
		public float clampWeightHead;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC74", Offset = "0x84DC74")]
		public float clampWeightEyes;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DC8C", Offset = "0x84DC8C")]
		public int clampSmoothing;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000051")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1429020", Offset = "0x1429020", VA = "0x1429020")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x14291F8", Offset = "0x14291F8", VA = "0x14291F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool headIsValid
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x1429104", Offset = "0x1429104", VA = "0x1429104")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x142921C", Offset = "0x142921C", VA = "0x142921C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x1429114", Offset = "0x1429114", VA = "0x1429114")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x1429298", Offset = "0x1429298", VA = "0x1429298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1428700", Offset = "0x1428700", VA = "0x1428700")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1428784", Offset = "0x1428784", VA = "0x1428784")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1428830", Offset = "0x1428830", VA = "0x1428830")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x14288F8", Offset = "0x14288F8", VA = "0x14288F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x14289E4", Offset = "0x14289E4", VA = "0x14289E4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1428AF0", Offset = "0x1428AF0", VA = "0x1428AF0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1428C38", Offset = "0x1428C38", VA = "0x1428C38", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1428D5C", Offset = "0x1428D5C", VA = "0x1428D5C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1428E94", Offset = "0x1428E94", VA = "0x1428E94", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x14292BC", Offset = "0x14292BC", VA = "0x14292BC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x14294F4", Offset = "0x14294F4", VA = "0x14294F4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1429694", Offset = "0x1429694", VA = "0x1429694")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x14298D8", Offset = "0x14298D8", VA = "0x14298D8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1429D24", Offset = "0x1429D24", VA = "0x1429D24", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1429E28", Offset = "0x1429E28", VA = "0x1429E28")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x142A054", Offset = "0x142A054", VA = "0x142A054")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x142A2B0", Offset = "0x142A2B0", VA = "0x142A2B0")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x142A5DC", Offset = "0x142A5DC", VA = "0x142A5DC")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x142973C", Offset = "0x142973C", VA = "0x142973C")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x142AA7C", Offset = "0x142AA7C", VA = "0x142AA7C")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x142C220", Offset = "0x142C220", VA = "0x142C220")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x142CDCC", Offset = "0x142CDCC", VA = "0x142CDCC")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x142701C", Offset = "0x142701C", VA = "0x142701C")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x142CE94", Offset = "0x142CE94", VA = "0x142CE94")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DCA4", Offset = "0x84DCA4")]
		public float IKRotationWeight;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x142AC6C", Offset = "0x142AC6C", VA = "0x142AC6C")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x142AE5C", Offset = "0x142AE5C", VA = "0x142AE5C")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x142B010", Offset = "0x142B010", VA = "0x142B010")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x142B01C", Offset = "0x142B01C", VA = "0x142B01C")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x142B0A0", Offset = "0x142B0A0", VA = "0x142B0A0")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x142B0AC", Offset = "0x142B0AC", VA = "0x142B0AC")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x142B0B4", Offset = "0x142B0B4", VA = "0x142B0B4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x142B1B8", Offset = "0x142B1B8", VA = "0x142B1B8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x142B2D8", Offset = "0x142B2D8", VA = "0x142B2D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x142B318", Offset = "0x142B318", VA = "0x142B318", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x142B36C", Offset = "0x142B36C", VA = "0x142B36C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x142B748", Offset = "0x142B748", VA = "0x142B748")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x142B79C", Offset = "0x142B79C", VA = "0x142B79C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x142BD44", Offset = "0x142BD44", VA = "0x142BD44")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x142BF5C", Offset = "0x142BF5C", VA = "0x142BF5C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x142C118", Offset = "0x142C118", VA = "0x142C118")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x142C094", Offset = "0x142C094", VA = "0x142C094")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x142C3C0", Offset = "0x142C3C0", VA = "0x142C3C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x142CE88", Offset = "0x142CE88", VA = "0x142CE88", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x142CE8C", Offset = "0x142CE8C", VA = "0x142CE8C", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x142CE90", Offset = "0x142CE90", VA = "0x142CE90", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x142CAD0", Offset = "0x142CAD0", VA = "0x142CAD0")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x14284EC", Offset = "0x14284EC", VA = "0x14284EC")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000F8")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40006CF")]
				YawPitch,
				[Token(Token = "0x40006D0")]
				FromTo
			}

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FBC4", Offset = "0x84FBC4")]
			public Transform target;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FBFC", Offset = "0x84FBFC")]
			public Transform bendGoal;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FC34", Offset = "0x84FC34")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FC34", Offset = "0x84FC34")]
			public float positionWeight;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FC88", Offset = "0x84FC88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FC88", Offset = "0x84FC88")]
			public float rotationWeight;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FCDC", Offset = "0x84FCDC")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FD14", Offset = "0x84FD14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FD14", Offset = "0x84FD14")]
			public float shoulderRotationWeight;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FD68", Offset = "0x84FD68")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FD68", Offset = "0x84FD68")]
			public float shoulderTwistWeight;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FDBC", Offset = "0x84FDBC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FDBC", Offset = "0x84FDBC")]
			public float bendGoalWeight;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FE10", Offset = "0x84FE10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FE10", Offset = "0x84FE10")]
			public float swivelOffset;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FE6C", Offset = "0x84FE6C")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FEA4", Offset = "0x84FEA4")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FEDC", Offset = "0x84FEDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84FEDC", Offset = "0x84FEDC")]
			public float armLengthMlp;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84FF34", Offset = "0x84FF34")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FFAC", Offset = "0x84FFAC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FFBC", Offset = "0x84FFBC")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000547")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000548")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000E1")]
			public Vector3 position
			{
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x156EAE0", Offset = "0x156EAE0", VA = "0x156EAE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B84", Offset = "0x856B84")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0x156EAEC", Offset = "0x156EAEC", VA = "0x156EAEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856B94", Offset = "0x856B94")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public Quaternion rotation
			{
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x156EAF8", Offset = "0x156EAF8", VA = "0x156EAF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BA4", Offset = "0x856BA4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x156EB04", Offset = "0x156EB04", VA = "0x156EB04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BB4", Offset = "0x856BB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x156EB10", Offset = "0x156EB10", VA = "0x156EB10")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x156EB44", Offset = "0x156EB44", VA = "0x156EB44")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private VirtualBone forearm
			{
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x156EB84", Offset = "0x156EB84", VA = "0x156EB84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private VirtualBone hand
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x156EBD0", Offset = "0x156EBD0", VA = "0x156EBD0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x156EC1C", Offset = "0x156EC1C", VA = "0x156EC1C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x156F420", Offset = "0x156F420", VA = "0x156F420", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x156F614", Offset = "0x156F614", VA = "0x156F614", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x156F6C0", Offset = "0x156F6C0", VA = "0x156F6C0")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x156FAD8", Offset = "0x156FAD8", VA = "0x156FAD8")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1571E78", Offset = "0x1571E78", VA = "0x1571E78", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x1571EE8", Offset = "0x1571EE8", VA = "0x1571EE8", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x1570E68", Offset = "0x1570E68", VA = "0x1570E68")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x1571174", Offset = "0x1571174", VA = "0x1571174")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x1572108", Offset = "0x1572108", VA = "0x1572108")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x1572230", Offset = "0x1572230", VA = "0x1572230")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FFCC", Offset = "0x84FFCC")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FFDC", Offset = "0x84FFDC")]
			private float <mag>k__BackingField;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000E7")]
			public float sqrMag
			{
				[Token(Token = "0x60007D4")]
				[Address(RVA = "0x15723F0", Offset = "0x15723F0", VA = "0x15723F0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BC4", Offset = "0x856BC4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x15723F8", Offset = "0x15723F8", VA = "0x15723F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BD4", Offset = "0x856BD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			public float mag
			{
				[Token(Token = "0x60007D6")]
				[Address(RVA = "0x1572400", Offset = "0x1572400", VA = "0x1572400")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BE4", Offset = "0x856BE4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x1572408", Offset = "0x1572408", VA = "0x1572408")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856BF4", Offset = "0x856BF4")]
				private set
				{
				}
			}

			[Token(Token = "0x60007CF")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60007D0")]
			public abstract void PreSolve();

			[Token(Token = "0x60007D1")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60007D2")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60007D3")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1572410", Offset = "0x1572410", VA = "0x1572410")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x15727CC", Offset = "0x15727CC", VA = "0x15727CC")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x1572938", Offset = "0x1572938", VA = "0x1572938")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x1572BC8", Offset = "0x1572BC8", VA = "0x1572BC8")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x1572C1C", Offset = "0x1572C1C", VA = "0x1572C1C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x1571CD8", Offset = "0x1571CD8", VA = "0x1571CD8")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x1572E08", Offset = "0x1572E08", VA = "0x1572E08")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x1572F4C", Offset = "0x1572F4C", VA = "0x1572F4C")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x1572358", Offset = "0x1572358", VA = "0x1572358")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Footstep
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84FFFC", Offset = "0x84FFFC")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E9")]
			public bool isStepping
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x1572F74", Offset = "0x1572F74", VA = "0x1572F74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000EA")]
			public float stepProgress
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x1572F88", Offset = "0x1572F88", VA = "0x1572F88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C04", Offset = "0x856C04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x1572F90", Offset = "0x1572F90", VA = "0x1572F90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C14", Offset = "0x856C14")]
				private set
				{
				}
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x1572F98", Offset = "0x1572F98", VA = "0x1572F98")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x1573128", Offset = "0x1573128", VA = "0x1573128")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x1573170", Offset = "0x1573170", VA = "0x1573170")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x1573270", Offset = "0x1573270", VA = "0x1573270")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1573448", Offset = "0x1573448", VA = "0x1573448")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x1573634", Offset = "0x1573634", VA = "0x1573634")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85000C", Offset = "0x85000C")]
			public Transform target;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850044", Offset = "0x850044")]
			public Transform bendGoal;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85007C", Offset = "0x85007C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85007C", Offset = "0x85007C")]
			public float positionWeight;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8500D0", Offset = "0x8500D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8500D0", Offset = "0x8500D0")]
			public float rotationWeight;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850124", Offset = "0x850124")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850124", Offset = "0x850124")]
			public float bendGoalWeight;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850178", Offset = "0x850178")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850178", Offset = "0x850178")]
			public float swivelOffset;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8501D4", Offset = "0x8501D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8501D4", Offset = "0x8501D4")]
			public float bendToTargetWeight;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850228", Offset = "0x850228")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850228", Offset = "0x850228")]
			public float legLengthMlp;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850280", Offset = "0x850280")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850318", Offset = "0x850318")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850328", Offset = "0x850328")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850338", Offset = "0x850338")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850348", Offset = "0x850348")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000EB")]
			public Vector3 position
			{
				[Token(Token = "0x60007EA")]
				[Address(RVA = "0x1573850", Offset = "0x1573850", VA = "0x1573850")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C24", Offset = "0x856C24")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007EB")]
				[Address(RVA = "0x157385C", Offset = "0x157385C", VA = "0x157385C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C34", Offset = "0x856C34")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			public Quaternion rotation
			{
				[Token(Token = "0x60007EC")]
				[Address(RVA = "0x1573868", Offset = "0x1573868", VA = "0x1573868")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C44", Offset = "0x856C44")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60007ED")]
				[Address(RVA = "0x1573874", Offset = "0x1573874", VA = "0x1573874")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C54", Offset = "0x856C54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			public bool hasToes
			{
				[Token(Token = "0x60007EE")]
				[Address(RVA = "0x1573880", Offset = "0x1573880", VA = "0x1573880")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C64", Offset = "0x856C64")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007EF")]
				[Address(RVA = "0x1573888", Offset = "0x1573888", VA = "0x1573888")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C74", Offset = "0x856C74")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EE")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60007F0")]
				[Address(RVA = "0x1573894", Offset = "0x1573894", VA = "0x1573894")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private VirtualBone calf
			{
				[Token(Token = "0x60007F1")]
				[Address(RVA = "0x15738C8", Offset = "0x15738C8", VA = "0x15738C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private VirtualBone foot
			{
				[Token(Token = "0x60007F2")]
				[Address(RVA = "0x1573900", Offset = "0x1573900", VA = "0x1573900")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private VirtualBone toes
			{
				[Token(Token = "0x60007F3")]
				[Address(RVA = "0x1573938", Offset = "0x1573938", VA = "0x1573938")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60007F4")]
				[Address(RVA = "0x1573970", Offset = "0x1573970", VA = "0x1573970")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F3")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60007F5")]
				[Address(RVA = "0x15739B0", Offset = "0x15739B0", VA = "0x15739B0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C84", Offset = "0x856C84")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007F6")]
				[Address(RVA = "0x15739BC", Offset = "0x15739BC", VA = "0x15739BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856C94", Offset = "0x856C94")]
				private set
				{
				}
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x15739C8", Offset = "0x15739C8", VA = "0x15739C8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x1573FE4", Offset = "0x1573FE4", VA = "0x1573FE4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x15747F4", Offset = "0x15747F4", VA = "0x15747F4", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x15746F0", Offset = "0x15746F0", VA = "0x15746F0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x15744B8", Offset = "0x15744B8", VA = "0x15744B8")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x1574DAC", Offset = "0x1574DAC", VA = "0x1574DAC")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x1575380", Offset = "0x1575380", VA = "0x1575380")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1575880", Offset = "0x1575880", VA = "0x1575880", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x1575A9C", Offset = "0x1575A9C", VA = "0x1575A9C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x1575B4C", Offset = "0x1575B4C", VA = "0x1575B4C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public class Locomotion
		{
			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850358", Offset = "0x850358")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850358", Offset = "0x850358")]
			public float weight;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8503AC", Offset = "0x8503AC")]
			public float footDistance;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8503E4", Offset = "0x8503E4")]
			public float stepThreshold;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85041C", Offset = "0x85041C")]
			public float angleThreshold;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850454", Offset = "0x850454")]
			public float comAngleMlp;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85048C", Offset = "0x85048C")]
			public float maxVelocity;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8504C4", Offset = "0x8504C4")]
			public float velocityFactor;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8504FC", Offset = "0x8504FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8504FC", Offset = "0x8504FC")]
			public float maxLegStretch;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850554", Offset = "0x850554")]
			public float rootSpeed;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85058C", Offset = "0x85058C")]
			public float stepSpeed;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8505C4", Offset = "0x8505C4")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8505FC", Offset = "0x8505FC")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850634", Offset = "0x850634")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850634", Offset = "0x850634")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85068C", Offset = "0x85068C")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8506C4", Offset = "0x8506C4")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8506FC", Offset = "0x8506FC")]
			public Vector3 offset;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850774", Offset = "0x850774")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8507AC", Offset = "0x8507AC")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8507E4", Offset = "0x8507E4")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000F4")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0x1575C40", Offset = "0x1575C40", VA = "0x1575C40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856CA4", Offset = "0x856CA4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000802")]
				[Address(RVA = "0x1575C4C", Offset = "0x1575C4C", VA = "0x1575C4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856CB4", Offset = "0x856CB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F5")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000808")]
				[Address(RVA = "0x1578080", Offset = "0x1578080", VA = "0x1578080")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F6")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000809")]
				[Address(RVA = "0x15780C0", Offset = "0x15780C0", VA = "0x15780C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F7")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600080A")]
				[Address(RVA = "0x1578104", Offset = "0x1578104", VA = "0x1578104")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000F8")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x1578144", Offset = "0x1578144", VA = "0x1578144")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1575C58", Offset = "0x1575C58", VA = "0x1575C58")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x1575F50", Offset = "0x1575F50", VA = "0x1575F50")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x15761C4", Offset = "0x15761C4", VA = "0x15761C4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x157659C", Offset = "0x157659C", VA = "0x157659C")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x157674C", Offset = "0x157674C", VA = "0x157674C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x1577C8C", Offset = "0x1577C8C", VA = "0x1577C8C")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x1577E30", Offset = "0x1577E30", VA = "0x1577E30")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1577EB4", Offset = "0x1577EB4", VA = "0x1577EB4")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x1578188", Offset = "0x1578188", VA = "0x1578188")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8507F4", Offset = "0x8507F4")]
			public Transform headTarget;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85082C", Offset = "0x85082C")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850864", Offset = "0x850864")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850864", Offset = "0x850864")]
			public float positionWeight;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8508B8", Offset = "0x8508B8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8508B8", Offset = "0x8508B8")]
			public float rotationWeight;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85090C", Offset = "0x85090C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85090C", Offset = "0x85090C")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850960", Offset = "0x850960")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850960", Offset = "0x850960")]
			public float pelvisRotationWeight;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8509B4", Offset = "0x8509B4")]
			public Transform chestGoal;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8509EC", Offset = "0x8509EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8509EC", Offset = "0x8509EC")]
			public float chestGoalWeight;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850A40", Offset = "0x850A40")]
			public float minHeadHeight;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850A78", Offset = "0x850A78")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850A78", Offset = "0x850A78")]
			public float bodyPosStiffness;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850ACC", Offset = "0x850ACC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850ACC", Offset = "0x850ACC")]
			public float bodyRotStiffness;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850B20", Offset = "0x850B20")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x850B20", Offset = "0x850B20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B20", Offset = "0x850B20")]
			public float neckStiffness;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850B98", Offset = "0x850B98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850B98", Offset = "0x850B98")]
			public float rotateChestByHands;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850BEC", Offset = "0x850BEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850BEC", Offset = "0x850BEC")]
			public float chestClampWeight;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850C40", Offset = "0x850C40")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850C40", Offset = "0x850C40")]
			public float headClampWeight;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850C94", Offset = "0x850C94")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850CCC", Offset = "0x850CCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850CCC", Offset = "0x850CCC")]
			public float maintainPelvisPosition;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850D20", Offset = "0x850D20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x850D20", Offset = "0x850D20")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x850E58", Offset = "0x850E58")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F9")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0x1577C0C", Offset = "0x1577C0C", VA = "0x1577C0C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000811")]
				[Address(RVA = "0x157826C", Offset = "0x157826C", VA = "0x157826C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0x15782AC", Offset = "0x15782AC", VA = "0x15782AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FC")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x1578300", Offset = "0x1578300", VA = "0x1578300")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FD")]
			public VirtualBone head
			{
				[Token(Token = "0x6000814")]
				[Address(RVA = "0x1577C4C", Offset = "0x1577C4C", VA = "0x1577C4C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FE")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x1578340", Offset = "0x1578340", VA = "0x1578340")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856CC4", Offset = "0x856CC4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000816")]
				[Address(RVA = "0x1578354", Offset = "0x1578354", VA = "0x1578354")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856CD4", Offset = "0x856CD4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x1578368", Offset = "0x1578368", VA = "0x1578368", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x1578E28", Offset = "0x1578E28", VA = "0x1578E28", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1579038", Offset = "0x1579038", VA = "0x1579038", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x15795F0", Offset = "0x15795F0", VA = "0x15795F0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x1579BA4", Offset = "0x1579BA4", VA = "0x1579BA4")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x157A508", Offset = "0x157A508", VA = "0x157A508")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x157AD20", Offset = "0x157AD20", VA = "0x157AD20")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x157B4F0", Offset = "0x157B4F0", VA = "0x157B4F0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x157B6CC", Offset = "0x157B6CC", VA = "0x157B6CC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x1579820", Offset = "0x1579820", VA = "0x1579820")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x157A968", Offset = "0x157A968", VA = "0x157A968")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x157A100", Offset = "0x157A100", VA = "0x157A100")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x157B7C4", Offset = "0x157B7C4", VA = "0x157B7C4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x157AAD4", Offset = "0x157AAD4", VA = "0x157AAD4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x157A6B4", Offset = "0x157A6B4", VA = "0x157A6B4")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x157BAEC", Offset = "0x157BAEC", VA = "0x157BAEC")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum PositionOffset
		{
			[Token(Token = "0x40005CB")]
			Pelvis,
			[Token(Token = "0x40005CC")]
			Chest,
			[Token(Token = "0x40005CD")]
			Head,
			[Token(Token = "0x40005CE")]
			LeftHand,
			[Token(Token = "0x40005CF")]
			RightHand,
			[Token(Token = "0x40005D0")]
			LeftFoot,
			[Token(Token = "0x40005D1")]
			RightFoot,
			[Token(Token = "0x40005D2")]
			LeftHeel,
			[Token(Token = "0x40005D3")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public enum RotationOffset
		{
			[Token(Token = "0x40005D5")]
			Pelvis,
			[Token(Token = "0x40005D6")]
			Chest,
			[Token(Token = "0x40005D7")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class VirtualBone
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x156F384", Offset = "0x156F384", VA = "0x156F384")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x156F400", Offset = "0x156F400", VA = "0x156F400")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x157BCB8", Offset = "0x157BCB8", VA = "0x157BCB8")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x15724E0", Offset = "0x15724E0", VA = "0x15724E0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x15729E0", Offset = "0x15729E0", VA = "0x15729E0")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x157BF48", Offset = "0x157BF48", VA = "0x157BF48")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x1570F40", Offset = "0x1570F40", VA = "0x1570F40")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x157C180", Offset = "0x157C180", VA = "0x157C180")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x157172C", Offset = "0x157172C", VA = "0x157172C")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x157C238", Offset = "0x157C238", VA = "0x157C238")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x157B0A8", Offset = "0x157B0A8", VA = "0x157B0A8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x157C450", Offset = "0x157C450", VA = "0x157C450")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x157C558", Offset = "0x157C558", VA = "0x157C558")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DCBC", Offset = "0x84DCBC")]
		public bool plantFeet;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DCF4", Offset = "0x84DCF4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DD04", Offset = "0x84DD04")]
		public Spine spine;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DD3C", Offset = "0x84DD3C")]
		public Arm leftArm;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DD74", Offset = "0x84DD74")]
		public Arm rightArm;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DDAC", Offset = "0x84DDAC")]
		public Leg leftLeg;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DDE4", Offset = "0x84DDE4")]
		public Leg rightLeg;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DE1C", Offset = "0x84DE1C")]
		public Locomotion locomotion;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000057")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1430FA4", Offset = "0x1430FA4", VA = "0x1430FA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855118", Offset = "0x855118")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1430FAC", Offset = "0x1430FAC", VA = "0x1430FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855128", Offset = "0x855128")]
			private set
			{
			}
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x142CE98", Offset = "0x142CE98", VA = "0x142CE98")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x142D2D4", Offset = "0x142D2D4", VA = "0x142D2D4")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x142D17C", Offset = "0x142D17C", VA = "0x142D17C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x142DCC0", Offset = "0x142DCC0", VA = "0x142DCC0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x142DF9C", Offset = "0x142DF9C", VA = "0x142DF9C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x142E040", Offset = "0x142E040", VA = "0x142E040")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x142E1D4", Offset = "0x142E1D4", VA = "0x142E1D4")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x142E360", Offset = "0x142E360", VA = "0x142E360")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x142EB84", Offset = "0x142EB84", VA = "0x142EB84", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x142ECF8", Offset = "0x142ECF8", VA = "0x142ECF8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x142EE9C", Offset = "0x142EE9C", VA = "0x142EE9C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x142EF10", Offset = "0x142EF10", VA = "0x142EF10", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x142EF84", Offset = "0x142EF84", VA = "0x142EF84", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x142F198", Offset = "0x142F198", VA = "0x142F198")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x142D574", Offset = "0x142D574", VA = "0x142D574")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x142D74C", Offset = "0x142D74C", VA = "0x142D74C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x142DB9C", Offset = "0x142DB9C", VA = "0x142DB9C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x142E4D8", Offset = "0x142E4D8", VA = "0x142E4D8")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x142F478", Offset = "0x142F478", VA = "0x142F478", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x142F4C0", Offset = "0x142F4C0", VA = "0x142F4C0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x14306BC", Offset = "0x14306BC", VA = "0x14306BC")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x142E640", Offset = "0x142E640", VA = "0x142E640")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x142F52C", Offset = "0x142F52C", VA = "0x142F52C")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1430918", Offset = "0x1430918", VA = "0x1430918")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1430960", Offset = "0x1430960", VA = "0x1430960")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x143056C", Offset = "0x143056C", VA = "0x143056C")]
		private void Write()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x14309A4", Offset = "0x14309A4", VA = "0x14309A4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1430FB4", Offset = "0x1430FB4", VA = "0x1430FB4")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DE54", Offset = "0x84DE54")]
		public Transform parent;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DE8C", Offset = "0x84DE8C")]
		public Transform child;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DEC4", Offset = "0x84DEC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DEC4", Offset = "0x84DEC4")]
		public float weight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DF18", Offset = "0x84DF18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DF18", Offset = "0x84DF18")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DF6C", Offset = "0x84DF6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84DF6C", Offset = "0x84DF6C")]
		public float twistAngleOffset;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x18F7D10", Offset = "0x18F7D10", VA = "0x18F7D10")]
		public void Relax()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x18F80F0", Offset = "0x18F80F0", VA = "0x18F80F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x18F8564", Offset = "0x18F8564", VA = "0x18F8564")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x18F85EC", Offset = "0x18F85EC", VA = "0x18F85EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x18F8674", Offset = "0x18F8674", VA = "0x18F8674")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x18F8778", Offset = "0x18F8778", VA = "0x18F8778")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DFC8", Offset = "0x84DFC8")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DFD8", Offset = "0x84DFD8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84DFE8", Offset = "0x84DFE8")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000058")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x157CE7C", Offset = "0x157CE7C", VA = "0x157CE7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855138", Offset = "0x855138")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x157CE84", Offset = "0x157CE84", VA = "0x157CE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855148", Offset = "0x855148")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool isPaused
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x157CE8C", Offset = "0x157CE8C", VA = "0x157CE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855158", Offset = "0x855158")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x157CE94", Offset = "0x157CE94", VA = "0x157CE94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855168", Offset = "0x855168")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x157CEA0", Offset = "0x157CEA0", VA = "0x157CEA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855178", Offset = "0x855178")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x157CEA8", Offset = "0x157CEA8", VA = "0x157CEA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855188", Offset = "0x855188")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool inInteraction
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x157CEB0", Offset = "0x157CEB0", VA = "0x157CEB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public float progress
		{
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x157F770", Offset = "0x157F770", VA = "0x157F770")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x157CF20", Offset = "0x157CF20", VA = "0x157CF20")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x157CFA4", Offset = "0x157CFA4", VA = "0x157CFA4")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x157D048", Offset = "0x157D048", VA = "0x157D048")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x157D188", Offset = "0x157D188", VA = "0x157D188")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x157D58C", Offset = "0x157D58C", VA = "0x157D58C")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x157D94C", Offset = "0x157D94C", VA = "0x157D94C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x157D9A0", Offset = "0x157D9A0", VA = "0x157D9A0")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x157E4E0", Offset = "0x157E4E0", VA = "0x157E4E0")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x157EFC0", Offset = "0x157EFC0", VA = "0x157EFC0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x157F1E8", Offset = "0x157F1E8", VA = "0x157F1E8")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x157F61C", Offset = "0x157F61C", VA = "0x157F61C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x157FC58", Offset = "0x157FC58", VA = "0x157FC58")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84DFF8", Offset = "0x84DFF8")]
		public LookAtIK ik;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E030", Offset = "0x84E030")]
		public float lerpSpeed;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E068", Offset = "0x84E068")]
		public float weightSpeed;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x157FEBC", Offset = "0x157FEBC", VA = "0x157FEBC")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1580034", Offset = "0x1580034", VA = "0x1580034")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x15800DC", Offset = "0x15800DC", VA = "0x15800DC")]
		public void Update()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1580320", Offset = "0x1580320", VA = "0x1580320")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1580418", Offset = "0x1580418", VA = "0x1580418")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x15804E4", Offset = "0x15804E4", VA = "0x15804E4")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B778", Offset = "0x84B778")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B778", Offset = "0x84B778")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C6")]
		public class InteractionEvent
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850E68", Offset = "0x850E68")]
			public float time;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850EA0", Offset = "0x850EA0")]
			public bool pause;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850ED8", Offset = "0x850ED8")]
			public bool pickUp;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F10", Offset = "0x850F10")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F48", Offset = "0x850F48")]
			public Message[] messages;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850F80", Offset = "0x850F80")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x157F7AC", Offset = "0x157F7AC", VA = "0x157F7AC")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x1581784", Offset = "0x1581784", VA = "0x1581784")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Message
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850FB8", Offset = "0x850FB8")]
			public string function;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x850FF0", Offset = "0x850FF0")]
			public GameObject recipient;

			[Token(Token = "0x40005E7")]
			private const string empty = "";

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x1581694", Offset = "0x1581694", VA = "0x1581694")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x158178C", Offset = "0x158178C", VA = "0x158178C")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851028", Offset = "0x851028")]
			public Animator animator;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851060", Offset = "0x851060")]
			public Animation animation;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851098", Offset = "0x851098")]
			public string animationState;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8510D0", Offset = "0x8510D0")]
			public float crossfadeTime;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851108", Offset = "0x851108")]
			public int layer;

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851140", Offset = "0x851140")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40005EE")]
			private const string empty = "";

			[Token(Token = "0x6000838")]
			[Address(RVA = "0x15813F4", Offset = "0x15813F4", VA = "0x15813F4")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x15814E8", Offset = "0x15814E8", VA = "0x15814E8")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x15815A0", Offset = "0x15815A0", VA = "0x15815A0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x1581680", Offset = "0x1581680", VA = "0x1581680")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000F9")]
			public enum Type
			{
				[Token(Token = "0x40006D2")]
				PositionWeight,
				[Token(Token = "0x40006D3")]
				RotationWeight,
				[Token(Token = "0x40006D4")]
				PositionOffsetX,
				[Token(Token = "0x40006D5")]
				PositionOffsetY,
				[Token(Token = "0x40006D6")]
				PositionOffsetZ,
				[Token(Token = "0x40006D7")]
				Pull,
				[Token(Token = "0x40006D8")]
				Reach,
				[Token(Token = "0x40006D9")]
				RotateBoneWeight,
				[Token(Token = "0x40006DA")]
				Push,
				[Token(Token = "0x40006DB")]
				PushParent,
				[Token(Token = "0x40006DC")]
				PoserWeight
			}

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851178", Offset = "0x851178")]
			public Type type;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8511B0", Offset = "0x8511B0")]
			public AnimationCurve curve;

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x1580BF0", Offset = "0x1580BF0", VA = "0x1580BF0")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x15817A4", Offset = "0x15817A4", VA = "0x15817A4")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Multiplier
		{
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8511E8", Offset = "0x8511E8")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851220", Offset = "0x851220")]
			public float multiplier;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851258", Offset = "0x851258")]
			public WeightCurve.Type result;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x1581254", Offset = "0x1581254", VA = "0x1581254")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1581794", Offset = "0x1581794", VA = "0x1581794")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E0B0", Offset = "0x84E0B0")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E0E8", Offset = "0x84E0E8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E120", Offset = "0x84E120")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E158", Offset = "0x84E158")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E168", Offset = "0x84E168")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700005D")]
		public float length
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x15806C0", Offset = "0x15806C0", VA = "0x15806C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8552E8", Offset = "0x8552E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x15806C8", Offset = "0x15806C8", VA = "0x15806C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8552F8", Offset = "0x8552F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x15806D0", Offset = "0x15806D0", VA = "0x15806D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855308", Offset = "0x855308")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x15806D8", Offset = "0x15806D8", VA = "0x15806D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855318", Offset = "0x855318")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x15808F4", Offset = "0x15808F4", VA = "0x15808F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x157FB2C", Offset = "0x157FB2C", VA = "0x157FB2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x15804F8", Offset = "0x15804F8", VA = "0x15804F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855198", Offset = "0x855198")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1580544", Offset = "0x1580544", VA = "0x1580544")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8551D0", Offset = "0x8551D0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1580590", Offset = "0x1580590", VA = "0x1580590")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855208", Offset = "0x855208")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x15805DC", Offset = "0x15805DC", VA = "0x15805DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855240", Offset = "0x855240")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1580628", Offset = "0x1580628", VA = "0x1580628")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855278", Offset = "0x855278")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1580674", Offset = "0x1580674", VA = "0x1580674")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8552B0", Offset = "0x8552B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x15806E0", Offset = "0x15806E0", VA = "0x15806E0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1580984", Offset = "0x1580984", VA = "0x1580984")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x157DF08", Offset = "0x157DF08", VA = "0x157DF08")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1580B08", Offset = "0x1580B08", VA = "0x1580B08")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x157DDBC", Offset = "0x157DDBC", VA = "0x157DDBC")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x157DF00", Offset = "0x157DF00", VA = "0x157DF00")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x157EBA4", Offset = "0x157EBA4", VA = "0x157EBA4")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x157F3F4", Offset = "0x157F3F4", VA = "0x157F3F4")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1581290", Offset = "0x1581290", VA = "0x1581290")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1580C0C", Offset = "0x1580C0C", VA = "0x1580C0C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1580B10", Offset = "0x1580B10", VA = "0x1580B10")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x15811EC", Offset = "0x15811EC", VA = "0x15811EC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1581294", Offset = "0x1581294", VA = "0x1581294")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x15812FC", Offset = "0x15812FC", VA = "0x15812FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855328", Offset = "0x855328")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1581348", Offset = "0x1581348", VA = "0x1581348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855360", Offset = "0x855360")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1581394", Offset = "0x1581394", VA = "0x1581394")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B7D8", Offset = "0x84B7D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B7D8", Offset = "0x84B7D8")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000CC")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E178", Offset = "0x84E178")]
		public string targetTag;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E1B0", Offset = "0x84E1B0")]
		public float fadeInTime;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E1E8", Offset = "0x84E1E8")]
		public float speed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E220", Offset = "0x84E220")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84E258", Offset = "0x84E258")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E258", Offset = "0x84E258")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x84E258", Offset = "0x84E258")]
		public Collider characterCollider;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E2DC", Offset = "0x84E2DC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x84E2DC", Offset = "0x84E2DC")]
		public Transform FPSCamera;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E33C", Offset = "0x84E33C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E374", Offset = "0x84E374")]
		public float camRaycastDistance;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84E3AC", Offset = "0x84E3AC")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x84E3BC", Offset = "0x84E3BC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E3BC", Offset = "0x84E3BC")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E41C", Offset = "0x84E41C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000061")]
		public bool inInteraction
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x1581974", Offset = "0x1581974", VA = "0x1581974")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x158358C", Offset = "0x158358C", VA = "0x158358C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1583594", Offset = "0x1583594", VA = "0x1583594")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x158359C", Offset = "0x158359C", VA = "0x158359C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8554E8", Offset = "0x8554E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x15835A4", Offset = "0x15835A4", VA = "0x15835A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8554F8", Offset = "0x8554F8")]
			private set
			{
			}
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x15817AC", Offset = "0x15817AC", VA = "0x15817AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855398", Offset = "0x855398")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x15817F8", Offset = "0x15817F8", VA = "0x15817F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8553D0", Offset = "0x8553D0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1581844", Offset = "0x1581844", VA = "0x1581844")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855408", Offset = "0x855408")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1581890", Offset = "0x1581890", VA = "0x1581890")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855440", Offset = "0x855440")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x15818DC", Offset = "0x15818DC", VA = "0x15818DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855478", Offset = "0x855478")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1581928", Offset = "0x1581928", VA = "0x1581928")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8554B0", Offset = "0x8554B0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1581B04", Offset = "0x1581B04", VA = "0x1581B04")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1581BD0", Offset = "0x1581BD0", VA = "0x1581BD0")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1581C9C", Offset = "0x1581C9C", VA = "0x1581C9C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1581D48", Offset = "0x1581D48", VA = "0x1581D48")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1581E40", Offset = "0x1581E40", VA = "0x1581E40")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1581F5C", Offset = "0x1581F5C", VA = "0x1581F5C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1581FEC", Offset = "0x1581FEC", VA = "0x1581FEC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x158207C", Offset = "0x158207C", VA = "0x158207C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x158210C", Offset = "0x158210C", VA = "0x158210C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1582180", Offset = "0x1582180", VA = "0x1582180")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x15821F4", Offset = "0x15821F4", VA = "0x15821F4")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x158225C", Offset = "0x158225C", VA = "0x158225C")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x15822E8", Offset = "0x15822E8", VA = "0x15822E8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x158239C", Offset = "0x158239C", VA = "0x158239C")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1582480", Offset = "0x1582480", VA = "0x1582480")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1582724", Offset = "0x1582724", VA = "0x1582724")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x15828FC", Offset = "0x15828FC", VA = "0x15828FC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1582B70", Offset = "0x1582B70", VA = "0x1582B70")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1582E64", Offset = "0x1582E64", VA = "0x1582E64")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1582EA8", Offset = "0x1582EA8", VA = "0x1582EA8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1582F20", Offset = "0x1582F20", VA = "0x1582F20")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1583040", Offset = "0x1583040", VA = "0x1583040")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x15831B8", Offset = "0x15831B8", VA = "0x15831B8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1583460", Offset = "0x1583460", VA = "0x1583460")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1582C70", Offset = "0x1582C70", VA = "0x1582C70")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x15835AC", Offset = "0x15835AC", VA = "0x15835AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1583C60", Offset = "0x1583C60", VA = "0x1583C60")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1583C80", Offset = "0x1583C80", VA = "0x1583C80")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1583C9C", Offset = "0x1583C9C", VA = "0x1583C9C")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1583CB8", Offset = "0x1583CB8", VA = "0x1583CB8")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1583D18", Offset = "0x1583D18", VA = "0x1583D18")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1583E34", Offset = "0x1583E34", VA = "0x1583E34")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1583F30", Offset = "0x1583F30", VA = "0x1583F30")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1584290", Offset = "0x1584290", VA = "0x1584290")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x158437C", Offset = "0x158437C", VA = "0x158437C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x15845C8", Offset = "0x15845C8", VA = "0x15845C8")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x15839D8", Offset = "0x15839D8", VA = "0x15839D8")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1584708", Offset = "0x1584708", VA = "0x1584708")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1584834", Offset = "0x1584834", VA = "0x1584834")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x15848DC", Offset = "0x15848DC", VA = "0x15848DC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x15849C4", Offset = "0x15849C4", VA = "0x15849C4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x15849DC", Offset = "0x15849DC", VA = "0x15849DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1581A20", Offset = "0x1581A20", VA = "0x1581A20")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1582620", Offset = "0x1582620", VA = "0x1582620")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1584CCC", Offset = "0x1584CCC", VA = "0x1584CCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855508", Offset = "0x855508")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1584D18", Offset = "0x1584D18", VA = "0x1584D18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855540", Offset = "0x855540")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1584D64", Offset = "0x1584D64", VA = "0x1584D64")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B838", Offset = "0x84B838")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B838", Offset = "0x84B838")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Multiplier
		{
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851290", Offset = "0x851290")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8512C8", Offset = "0x8512C8")]
			public float multiplier;

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1585504", Offset = "0x1585504", VA = "0x1585504")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E454", Offset = "0x84E454")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E48C", Offset = "0x84E48C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E4C4", Offset = "0x84E4C4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E4FC", Offset = "0x84E4FC")]
		public Transform pivot;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E534", Offset = "0x84E534")]
		public Vector3 twistAxis;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E56C", Offset = "0x84E56C")]
		public float twistWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E5A4", Offset = "0x84E5A4")]
		public float swingWeight;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E5DC", Offset = "0x84E5DC")]
		public bool rotateOnce;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1585218", Offset = "0x1585218", VA = "0x1585218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855578", Offset = "0x855578")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1585264", Offset = "0x1585264", VA = "0x1585264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8555B0", Offset = "0x8555B0")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x15852B0", Offset = "0x15852B0", VA = "0x15852B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8555E8", Offset = "0x8555E8")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x15852FC", Offset = "0x15852FC", VA = "0x15852FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855620", Offset = "0x855620")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1585348", Offset = "0x1585348", VA = "0x1585348")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855658", Offset = "0x855658")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1585394", Offset = "0x1585394", VA = "0x1585394")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855690", Offset = "0x855690")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1580B80", Offset = "0x1580B80", VA = "0x1580B80")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x157FBBC", Offset = "0x157FBBC", VA = "0x157FBBC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x157DFBC", Offset = "0x157DFBC", VA = "0x157DFBC")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x15853E0", Offset = "0x15853E0", VA = "0x15853E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8556C8", Offset = "0x8556C8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x158542C", Offset = "0x158542C", VA = "0x158542C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855700", Offset = "0x855700")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1585478", Offset = "0x1585478", VA = "0x1585478")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B898", Offset = "0x84B898")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B898", Offset = "0x84B898")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851300", Offset = "0x851300")]
			public bool use;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851338", Offset = "0x851338")]
			public Vector2 offset;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851370", Offset = "0x851370")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851370", Offset = "0x851370")]
			public float angleOffset;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8513CC", Offset = "0x8513CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8513CC", Offset = "0x8513CC")]
			public float maxAngle;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851424", Offset = "0x851424")]
			public float radius;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85145C", Offset = "0x85145C")]
			public bool orbit;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851494", Offset = "0x851494")]
			public bool fixYAxis;

			[Token(Token = "0x170000FF")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x1585C8C", Offset = "0x1585C8C", VA = "0x1585C8C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000100")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0x1585CC8", Offset = "0x1585CC8", VA = "0x1585CC8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1585DC0", Offset = "0x1585DC0", VA = "0x1585DC0")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x158643C", Offset = "0x158643C", VA = "0x158643C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public class CameraPosition
		{
			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8514CC", Offset = "0x8514CC")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851504", Offset = "0x851504")]
			public Vector3 direction;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85153C", Offset = "0x85153C")]
			public float maxDistance;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851574", Offset = "0x851574")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851574", Offset = "0x851574")]
			public float maxAngle;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8515CC", Offset = "0x8515CC")]
			public bool fixYAxis;

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1585778", Offset = "0x1585778", VA = "0x1585778")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x1585920", Offset = "0x1585920", VA = "0x1585920")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x1585C00", Offset = "0x1585C00", VA = "0x1585C00")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000FA")]
			public class Interaction
			{
				[Token(Token = "0x40006DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852684", Offset = "0x852684")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40006DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8526BC", Offset = "0x8526BC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000905")]
				[Address(RVA = "0x1586460", Offset = "0x1586460", VA = "0x1586460")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851674", Offset = "0x851674")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8516AC", Offset = "0x8516AC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8516E4", Offset = "0x8516E4")]
			public Interaction[] interactions;

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x15855F4", Offset = "0x15855F4", VA = "0x15855F4")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x1586450", Offset = "0x1586450", VA = "0x1586450")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E614", Offset = "0x84E614")]
		public Range[] ranges;

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x158550C", Offset = "0x158550C", VA = "0x158550C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855738", Offset = "0x855738")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1585558", Offset = "0x1585558", VA = "0x1585558")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855770", Offset = "0x855770")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x15855A4", Offset = "0x15855A4", VA = "0x15855A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8557A8", Offset = "0x8557A8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x15855F0", Offset = "0x15855F0", VA = "0x15855F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x15840D4", Offset = "0x15840D4", VA = "0x15840D4")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1585718", Offset = "0x1585718", VA = "0x1585718")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class Map
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x1500058", Offset = "0x1500058", VA = "0x1500058")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x150045C", Offset = "0x150045C", VA = "0x150045C")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x1500410", Offset = "0x1500410", VA = "0x1500410")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x1500208", Offset = "0x1500208", VA = "0x1500208")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x14FFD70", Offset = "0x14FFD70", VA = "0x14FFD70", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8557E0", Offset = "0x8557E0")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x15000FC", Offset = "0x15000FC", VA = "0x15000FC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1500100", Offset = "0x1500100", VA = "0x1500100", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x15003A8", Offset = "0x15003A8", VA = "0x15003A8", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1500094", Offset = "0x1500094", VA = "0x1500094")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x14FFFB8", Offset = "0x14FFFB8", VA = "0x14FFFB8")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x15004AC", Offset = "0x15004AC", VA = "0x15004AC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x150A0F8", Offset = "0x150A0F8", VA = "0x150A0F8", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x150A1AC", Offset = "0x150A1AC", VA = "0x150A1AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x150A364", Offset = "0x150A364", VA = "0x150A364", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x150A460", Offset = "0x150A460", VA = "0x150A460", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x150A208", Offset = "0x150A208", VA = "0x150A208")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x150A810", Offset = "0x150A810", VA = "0x150A810")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E64C", Offset = "0x84E64C")]
		public float weight;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E664", Offset = "0x84E664")]
		public float localRotationWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E67C", Offset = "0x84E67C")]
		public float localPositionWeight;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600053D")]
		public abstract void AutoMapping();

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x18F0B44", Offset = "0x18F0B44", VA = "0x18F0B44")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600053F")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000540")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000541")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x18F0B50", Offset = "0x18F0B50", VA = "0x18F0B50", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x18F0BA4", Offset = "0x18F0BA4", VA = "0x18F0BA4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x18F0BE0", Offset = "0x18F0BE0", VA = "0x18F0BE0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x18F0BF8", Offset = "0x18F0BF8", VA = "0x18F0BF8")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x84B8F8", Offset = "0x84B8F8")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public class Rigidbone
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x18F1194", Offset = "0x18F1194", VA = "0x18F1194")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x18F1DA0", Offset = "0x18F1DA0", VA = "0x18F1DA0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x18F1B84", Offset = "0x18F1B84", VA = "0x18F1B84")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		public class Child
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x18F12F0", Offset = "0x18F12F0", VA = "0x18F12F0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x18F1F38", Offset = "0x18F1F38", VA = "0x18F1F38")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x18F1EE8", Offset = "0x18F1EE8", VA = "0x18F1EE8")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BDF4", Offset = "0x84BDF4")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000101")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085F")]
				[Address(RVA = "0x18F2518", Offset = "0x18F2518", VA = "0x18F2518", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000102")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x18F2580", Offset = "0x18F2580", VA = "0x18F2580", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x18F1350", Offset = "0x18F1350", VA = "0x18F1350")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x18F22D0", Offset = "0x18F22D0", VA = "0x18F22D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x18F22D4", Offset = "0x18F22D4", VA = "0x18F22D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x18F2520", Offset = "0x18F2520", VA = "0x18F2520", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E694", Offset = "0x84E694")]
		public IK ik;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E6CC", Offset = "0x84E6CC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E704", Offset = "0x84E704")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E73C", Offset = "0x84E73C")]
		public float applyVelocity;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E774", Offset = "0x84E774")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000064")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x18F0C58", Offset = "0x18F0C58", VA = "0x18F0C58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		private bool ikUsed
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x18F173C", Offset = "0x18F173C", VA = "0x18F173C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x18F0C20", Offset = "0x18F0C20", VA = "0x18F0C20")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x18F0CD0", Offset = "0x18F0CD0", VA = "0x18F0CD0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x18F0E00", Offset = "0x18F0E00", VA = "0x18F0E00")]
		public void Start()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x18F0D90", Offset = "0x18F0D90", VA = "0x18F0D90")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855818", Offset = "0x855818")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x18F137C", Offset = "0x18F137C", VA = "0x18F137C")]
		private void Update()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x18F15C8", Offset = "0x18F15C8", VA = "0x18F15C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x18F1680", Offset = "0x18F1680", VA = "0x18F1680")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x18F18C0", Offset = "0x18F18C0", VA = "0x18F18C0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x18F1700", Offset = "0x18F1700", VA = "0x18F1700")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x18F187C", Offset = "0x18F187C", VA = "0x18F187C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x18F195C", Offset = "0x18F195C", VA = "0x18F195C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x18F18F4", Offset = "0x18F18F4", VA = "0x18F18F4")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x18F0D28", Offset = "0x18F0D28", VA = "0x18F0D28")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x18F1608", Offset = "0x18F1608", VA = "0x18F1608")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x18F2100", Offset = "0x18F2100", VA = "0x18F2100")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x18F2204", Offset = "0x18F2204", VA = "0x18F2204")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000066")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x18F3F3C", Offset = "0x18F3F3C", VA = "0x18F3F3C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x18F3F78", Offset = "0x18F3F78", VA = "0x18F3F78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x18F3BC4", Offset = "0x18F3BC4", VA = "0x18F3BC4")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x18F3C08", Offset = "0x18F3C08", VA = "0x18F3C08")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x18F3E94", Offset = "0x18F3E94", VA = "0x18F3E94")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x18F3F04", Offset = "0x18F3F04", VA = "0x18F3F04")]
		public void Disable()
		{
		}

		[Token(Token = "0x600055E")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x18F3DA4", Offset = "0x18F3DA4", VA = "0x18F3DA4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x18F4048", Offset = "0x18F4048", VA = "0x18F4048")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x18F404C", Offset = "0x18F404C", VA = "0x18F404C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x18F4134", Offset = "0x18F4134", VA = "0x18F4134")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x18F4218", Offset = "0x18F4218", VA = "0x18F4218")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x18F4494", Offset = "0x18F4494", VA = "0x18F4494")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x18F4550", Offset = "0x18F4550", VA = "0x18F4550")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B95C", Offset = "0x84B95C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B95C", Offset = "0x84B95C")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E7BC", Offset = "0x84E7BC")]
		public float limit;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E7D8", Offset = "0x84E7D8")]
		public float twistLimit;

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x18F45C8", Offset = "0x18F45C8", VA = "0x18F45C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85587C", Offset = "0x85587C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x18F4614", Offset = "0x18F4614", VA = "0x18F4614")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8558B4", Offset = "0x8558B4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x18F4660", Offset = "0x18F4660", VA = "0x18F4660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8558EC", Offset = "0x8558EC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x18F46AC", Offset = "0x18F46AC", VA = "0x18F46AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855924", Offset = "0x855924")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x18F46F8", Offset = "0x18F46F8", VA = "0x18F46F8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x18F47B0", Offset = "0x18F47B0", VA = "0x18F47B0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x18F49F8", Offset = "0x18F49F8", VA = "0x18F49F8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84B9BC", Offset = "0x84B9BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84B9BC", Offset = "0x84B9BC")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x18F4A08", Offset = "0x18F4A08", VA = "0x18F4A08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x85595C", Offset = "0x85595C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x18F4A54", Offset = "0x18F4A54", VA = "0x18F4A54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855994", Offset = "0x855994")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x18F4AA0", Offset = "0x18F4AA0", VA = "0x18F4AA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8559CC", Offset = "0x8559CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x18F4AEC", Offset = "0x18F4AEC", VA = "0x18F4AEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855A04", Offset = "0x855A04")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x18F4B38", Offset = "0x18F4B38", VA = "0x18F4B38", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x18F4B60", Offset = "0x18F4B60", VA = "0x18F4B60")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x18F4E60", Offset = "0x18F4E60", VA = "0x18F4E60")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84BA1C", Offset = "0x84BA1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84BA1C", Offset = "0x84BA1C")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class ReachCone
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000103")]
			public Vector3 o
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x18F6DFC", Offset = "0x18F6DFC", VA = "0x18F6DFC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000104")]
			public Vector3 a
			{
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x18F6E34", Offset = "0x18F6E34", VA = "0x18F6E34")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000105")]
			public Vector3 b
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0x18F6E70", Offset = "0x18F6E70", VA = "0x18F6E70")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000106")]
			public Vector3 c
			{
				[Token(Token = "0x6000865")]
				[Address(RVA = "0x18F6EAC", Offset = "0x18F6EAC", VA = "0x18F6EAC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000107")]
			public bool isValid
			{
				[Token(Token = "0x6000867")]
				[Address(RVA = "0x18F5F60", Offset = "0x18F5F60", VA = "0x18F5F60")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x18F65AC", Offset = "0x18F65AC", VA = "0x18F65AC")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x18F670C", Offset = "0x18F670C", VA = "0x18F670C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class LimitPoint
		{
			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x18F5F70", Offset = "0x18F5F70", VA = "0x18F5F70")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E804", Offset = "0x84E804")]
		public float twistLimit;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E820", Offset = "0x84E820")]
		public int smoothIterations;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x18F4EE8", Offset = "0x18F4EE8", VA = "0x18F4EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855A3C", Offset = "0x855A3C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x18F4F34", Offset = "0x18F4F34", VA = "0x18F4F34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855A74", Offset = "0x855A74")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x18F4F80", Offset = "0x18F4F80", VA = "0x18F4F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855AAC", Offset = "0x855AAC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x18F4FCC", Offset = "0x18F4FCC", VA = "0x18F4FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855AE4", Offset = "0x855AE4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x18F5018", Offset = "0x18F5018", VA = "0x18F5018")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x18F54FC", Offset = "0x18F54FC", VA = "0x18F54FC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x18F55F4", Offset = "0x18F55F4", VA = "0x18F55F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x18F5BAC", Offset = "0x18F5BAC", VA = "0x18F5BAC")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x18F50B4", Offset = "0x18F50B4", VA = "0x18F50B4")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x18F5FF4", Offset = "0x18F5FF4", VA = "0x18F5FF4")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x18F68CC", Offset = "0x18F68CC", VA = "0x18F68CC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x18F6910", Offset = "0x18F6910", VA = "0x18F6910")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x18F6A58", Offset = "0x18F6A58", VA = "0x18F6A58")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x18F5874", Offset = "0x18F5874", VA = "0x18F5874")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x18F6BE8", Offset = "0x18F6BE8", VA = "0x18F6BE8")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x18F6D98", Offset = "0x18F6D98", VA = "0x18F6D98")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x84BA7C", Offset = "0x84BA7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84BA7C", Offset = "0x84BA7C")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E8E0", Offset = "0x84E8E0")]
		public float twistLimit;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x18F6EE8", Offset = "0x18F6EE8", VA = "0x18F6EE8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855B1C", Offset = "0x855B1C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x18F6F34", Offset = "0x18F6F34", VA = "0x18F6F34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855B54", Offset = "0x855B54")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x18F6F80", Offset = "0x18F6F80", VA = "0x18F6F80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855B8C", Offset = "0x855B8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x18F6FCC", Offset = "0x18F6FCC", VA = "0x18F6FCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x855BC4", Offset = "0x855BC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x18F7018", Offset = "0x18F7018", VA = "0x18F7018")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x18F7034", Offset = "0x18F7034", VA = "0x18F7034", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x18F70EC", Offset = "0x18F70EC", VA = "0x18F70EC")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x18F7418", Offset = "0x18F7418", VA = "0x18F7418")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE04", Offset = "0x84BE04")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000108")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086D")]
				[Address(RVA = "0x11A595C", Offset = "0x11A595C", VA = "0x11A595C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086F")]
				[Address(RVA = "0x11A59C4", Offset = "0x11A59C4", VA = "0x11A59C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x11A5738", Offset = "0x11A5738", VA = "0x11A5738")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x11A5838", Offset = "0x11A5838", VA = "0x11A5838", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x11A583C", Offset = "0x11A583C", VA = "0x11A583C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x11A5964", Offset = "0x11A5964", VA = "0x11A5964", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E934", Offset = "0x84E934")]
		public AimIK ik;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E96C", Offset = "0x84E96C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84E96C", Offset = "0x84E96C")]
		public float weight;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84E9C0", Offset = "0x84E9C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84E9C0", Offset = "0x84E9C0")]
		public Transform target;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EA20", Offset = "0x84EA20")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EA58", Offset = "0x84EA58")]
		public float weightSmoothTime;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84EA90", Offset = "0x84EA90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EA90", Offset = "0x84EA90")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EAF0", Offset = "0x84EAF0")]
		public float maxRadiansDelta;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB28", Offset = "0x84EB28")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB60", Offset = "0x84EB60")]
		public float slerpSpeed;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EB98", Offset = "0x84EB98")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EBD0", Offset = "0x84EBD0")]
		public float minDistance;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EC08", Offset = "0x84EC08")]
		public Vector3 offset;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84EC40", Offset = "0x84EC40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EC40", Offset = "0x84EC40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84EC40", Offset = "0x84EC40")]
		public float maxRootAngle;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84ECBC", Offset = "0x84ECBC")]
		public bool turnToTarget;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84ECF4", Offset = "0x84ECF4")]
		public float turnToTargetTime;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84ED2C", Offset = "0x84ED2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84ED2C", Offset = "0x84ED2C")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84ED8C", Offset = "0x84ED8C")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000068")]
		private Vector3 pivot
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x11A4954", Offset = "0x11A4954", VA = "0x11A4954")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x11A4858", Offset = "0x11A4858", VA = "0x11A4858")]
		private void Start()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x11A4AA0", Offset = "0x11A4AA0", VA = "0x11A4AA0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x11A51BC", Offset = "0x11A51BC", VA = "0x11A51BC")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x11A5358", Offset = "0x11A5358", VA = "0x11A5358")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x11A56C8", Offset = "0x11A56C8", VA = "0x11A56C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855BFC", Offset = "0x855BFC")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x11A5764", Offset = "0x11A5764", VA = "0x11A5764")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D8")]
		public class Pose
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x11A5C94", Offset = "0x11A5C94", VA = "0x11A5C94")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x11A6000", Offset = "0x11A6000", VA = "0x11A6000")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x11A6008", Offset = "0x11A6008", VA = "0x11A6008")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x11A5BB8", Offset = "0x11A5BB8", VA = "0x11A5BB8")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x11A5F2C", Offset = "0x11A5F2C", VA = "0x11A5F2C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x11A5F98", Offset = "0x11A5F98", VA = "0x11A5F98")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000FB")]
			public class EffectorLink
			{
				[Token(Token = "0x40006DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8526F4", Offset = "0x8526F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85272C", Offset = "0x85272C")]
				public float weight;

				[Token(Token = "0x6000906")]
				[Address(RVA = "0x11A65F8", Offset = "0x11A65F8", VA = "0x11A65F8")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85171C", Offset = "0x85171C")]
			public Transform transform;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851754", Offset = "0x851754")]
			public Transform relativeTo;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85178C", Offset = "0x85178C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8517C4", Offset = "0x8517C4")]
			public float verticalWeight;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8517FC", Offset = "0x8517FC")]
			public float horizontalWeight;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851834", Offset = "0x851834")]
			public float speed;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x11A6164", Offset = "0x11A6164", VA = "0x11A6164")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x11A65D0", Offset = "0x11A65D0", VA = "0x11A65D0")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x11A65E0", Offset = "0x11A65E0", VA = "0x11A65E0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EDC4", Offset = "0x84EDC4")]
		public Body[] bodies;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x11A6024", Offset = "0x11A6024", VA = "0x11A6024", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x11A65C8", Offset = "0x11A65C8", VA = "0x11A65C8")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EDFC", Offset = "0x84EDFC")]
		public float tiltSpeed;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EE34", Offset = "0x84EE34")]
		public float tiltSensitivity;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EE6C", Offset = "0x84EE6C")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EEA4", Offset = "0x84EEA4")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x11A7790", Offset = "0x11A7790", VA = "0x11A7790", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x11A77D8", Offset = "0x11A77D8", VA = "0x11A77D8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11A7A08", Offset = "0x11A7A08", VA = "0x11A7A08")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public abstract class HitPoint
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85186C", Offset = "0x85186C")]
			public string name;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8518A4", Offset = "0x8518A4")]
			public Collider collider;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8518DC", Offset = "0x8518DC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851928", Offset = "0x851928")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851938", Offset = "0x851938")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851948", Offset = "0x851948")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851958", Offset = "0x851958")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010A")]
			public bool inProgress
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x150A8D4", Offset = "0x150A8D4", VA = "0x150A8D4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700010B")]
			protected float crossFader
			{
				[Token(Token = "0x6000877")]
				[Address(RVA = "0x150AE7C", Offset = "0x150AE7C", VA = "0x150AE7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856D84", Offset = "0x856D84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000878")]
				[Address(RVA = "0x150AE84", Offset = "0x150AE84", VA = "0x150AE84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856D94", Offset = "0x856D94")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010C")]
			protected float timer
			{
				[Token(Token = "0x6000879")]
				[Address(RVA = "0x150AE8C", Offset = "0x150AE8C", VA = "0x150AE8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DA4", Offset = "0x856DA4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x150AE94", Offset = "0x150AE94", VA = "0x150AE94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DB4", Offset = "0x856DB4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			protected Vector3 force
			{
				[Token(Token = "0x600087B")]
				[Address(RVA = "0x150AE9C", Offset = "0x150AE9C", VA = "0x150AE9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DC4", Offset = "0x856DC4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600087C")]
				[Address(RVA = "0x150AEA8", Offset = "0x150AEA8", VA = "0x150AEA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DD4", Offset = "0x856DD4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010E")]
			protected Vector3 point
			{
				[Token(Token = "0x600087D")]
				[Address(RVA = "0x150AEB4", Offset = "0x150AEB4", VA = "0x150AEB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DE4", Offset = "0x856DE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600087E")]
				[Address(RVA = "0x150AEC0", Offset = "0x150AEC0", VA = "0x150AEC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856DF4", Offset = "0x856DF4")]
				private set
				{
				}
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x150AD48", Offset = "0x150AD48", VA = "0x150AD48")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x150A9BC", Offset = "0x150A9BC", VA = "0x150A9BC")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000881")]
			protected abstract float GetLength();

			[Token(Token = "0x6000882")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000883")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x150AECC", Offset = "0x150AECC", VA = "0x150AECC")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000FC")]
			public class EffectorLink
			{
				[Token(Token = "0x40006E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852764", Offset = "0x852764")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85279C", Offset = "0x85279C")]
				public float weight;

				[Token(Token = "0x40006E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000907")]
				[Address(RVA = "0x150B838", Offset = "0x150B838", VA = "0x150B838")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000908")]
				[Address(RVA = "0x150B62C", Offset = "0x150B62C", VA = "0x150B62C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000909")]
				[Address(RVA = "0x150B974", Offset = "0x150B974", VA = "0x150B974")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851968", Offset = "0x851968")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8519A0", Offset = "0x8519A0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8519D8", Offset = "0x8519D8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x150B448", Offset = "0x150B448", VA = "0x150B448", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x150B5C0", Offset = "0x150B5C0", VA = "0x150B5C0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x150B640", Offset = "0x150B640", VA = "0x150B640", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x150B960", Offset = "0x150B960", VA = "0x150B960")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000FD")]
			public class BoneLink
			{
				[Token(Token = "0x40006E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8527D4", Offset = "0x8527D4")]
				public Transform bone;

				[Token(Token = "0x40006E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85280C", Offset = "0x85280C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85280C", Offset = "0x85280C")]
				public float weight;

				[Token(Token = "0x40006E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40006E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600090A")]
				[Address(RVA = "0x150B250", Offset = "0x150B250", VA = "0x150B250")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600090B")]
				[Address(RVA = "0x150AFE8", Offset = "0x150AFE8", VA = "0x150AFE8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600090C")]
				[Address(RVA = "0x150B3C0", Offset = "0x150B3C0", VA = "0x150B3C0")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851A10", Offset = "0x851A10")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851A48", Offset = "0x851A48")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x150AEE0", Offset = "0x150AEE0", VA = "0x150AEE0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x150AF84", Offset = "0x150AF84", VA = "0x150AF84", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x150AFF4", Offset = "0x150AFF4", VA = "0x150AFF4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x150B3AC", Offset = "0x150B3AC", VA = "0x150B3AC")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EEDC", Offset = "0x84EEDC")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EF14", Offset = "0x84EF14")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000069")]
		public bool inProgress
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x150A818", Offset = "0x150A818", VA = "0x150A818")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x150A8E8", Offset = "0x150A8E8", VA = "0x150A8E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x150AB08", Offset = "0x150AB08", VA = "0x150AB08")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x150AE74", Offset = "0x150AE74", VA = "0x150AE74")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public abstract class Offset
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851A80", Offset = "0x851A80")]
			public string name;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851AB8", Offset = "0x851AB8")]
			public Collider collider;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851AF0", Offset = "0x851AF0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851B3C", Offset = "0x851B3C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851B4C", Offset = "0x851B4C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851B5C", Offset = "0x851B5C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x851B6C", Offset = "0x851B6C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010F")]
			protected float crossFader
			{
				[Token(Token = "0x600088D")]
				[Address(RVA = "0x150BF2C", Offset = "0x150BF2C", VA = "0x150BF2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E04", Offset = "0x856E04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x150BF34", Offset = "0x150BF34", VA = "0x150BF34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E14", Offset = "0x856E14")]
				private set
				{
				}
			}

			[Token(Token = "0x17000110")]
			protected float timer
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x150BF3C", Offset = "0x150BF3C", VA = "0x150BF3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E24", Offset = "0x856E24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x150BF44", Offset = "0x150BF44", VA = "0x150BF44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E34", Offset = "0x856E34")]
				private set
				{
				}
			}

			[Token(Token = "0x17000111")]
			protected Vector3 force
			{
				[Token(Token = "0x6000891")]
				[Address(RVA = "0x150BF4C", Offset = "0x150BF4C", VA = "0x150BF4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E44", Offset = "0x856E44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x150BF58", Offset = "0x150BF58", VA = "0x150BF58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E54", Offset = "0x856E54")]
				private set
				{
				}
			}

			[Token(Token = "0x17000112")]
			protected Vector3 point
			{
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x150BF64", Offset = "0x150BF64", VA = "0x150BF64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E64", Offset = "0x856E64")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000894")]
				[Address(RVA = "0x150BF70", Offset = "0x150BF70", VA = "0x150BF70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x856E74", Offset = "0x856E74")]
				private set
				{
				}
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x150BDE4", Offset = "0x150BDE4", VA = "0x150BDE4")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x150BA48", Offset = "0x150BA48", VA = "0x150BA48")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000897")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000898")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000899")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x150BF7C", Offset = "0x150BF7C", VA = "0x150BF7C")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FE")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40006E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852860", Offset = "0x852860")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40006EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852898", Offset = "0x852898")]
				public float weight;

				[Token(Token = "0x40006EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600090D")]
				[Address(RVA = "0x150C438", Offset = "0x150C438", VA = "0x150C438")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600090E")]
				[Address(RVA = "0x150C1F4", Offset = "0x150C1F4", VA = "0x150C1F4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600090F")]
				[Address(RVA = "0x150C554", Offset = "0x150C554", VA = "0x150C554")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851B7C", Offset = "0x851B7C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851BB4", Offset = "0x851BB4")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851BEC", Offset = "0x851BEC")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x150BF90", Offset = "0x150BF90", VA = "0x150BF90", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x150C188", Offset = "0x150C188", VA = "0x150C188", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x150C208", Offset = "0x150C208", VA = "0x150C208", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x150C538", Offset = "0x150C538", VA = "0x150C538")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FF")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40006ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8528D0", Offset = "0x8528D0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40006EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852908", Offset = "0x852908")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852908", Offset = "0x852908")]
				public float weight;

				[Token(Token = "0x40006EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40006F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000910")]
				[Address(RVA = "0x150C9BC", Offset = "0x150C9BC", VA = "0x150C9BC")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000911")]
				[Address(RVA = "0x150C6A4", Offset = "0x150C6A4", VA = "0x150C6A4")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000912")]
				[Address(RVA = "0x150CAF8", Offset = "0x150CAF8", VA = "0x150CAF8")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851C24", Offset = "0x851C24")]
			public int curveIndex;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851C5C", Offset = "0x851C5C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x150C55C", Offset = "0x150C55C", VA = "0x150C55C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x150C640", Offset = "0x150C640", VA = "0x150C640", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x150C6B0", Offset = "0x150C6B0", VA = "0x150C6B0", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x150CAE4", Offset = "0x150CAE4", VA = "0x150CAE4")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EF4C", Offset = "0x84EF4C")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EF84", Offset = "0x84EF84")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x150B97C", Offset = "0x150B97C", VA = "0x150B97C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x150BB9C", Offset = "0x150BB9C", VA = "0x150BB9C")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x150BF24", Offset = "0x150BF24", VA = "0x150BF24")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000100")]
			public class EffectorLink
			{
				[Token(Token = "0x40006F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85295C", Offset = "0x85295C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852994", Offset = "0x852994")]
				public float weight;

				[Token(Token = "0x6000913")]
				[Address(RVA = "0x157CE74", Offset = "0x157CE74", VA = "0x157CE74")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851C94", Offset = "0x851C94")]
			public Transform transform;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851CCC", Offset = "0x851CCC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D04", Offset = "0x851D04")]
			public float speed;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D3C", Offset = "0x851D3C")]
			public float acceleration;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851D74", Offset = "0x851D74")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x851D74", Offset = "0x851D74")]
			public float matchVelocity;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851DC8", Offset = "0x851DC8")]
			public float gravity;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x157C844", Offset = "0x157C844", VA = "0x157C844")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x157CA04", Offset = "0x157CA04", VA = "0x157CA04")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x157CE58", Offset = "0x157CE58", VA = "0x157CE58")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EFBC", Offset = "0x84EFBC")]
		public Body[] bodies;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84EFF4", Offset = "0x84EFF4")]
		public OffsetLimits[] limits;

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x157C7CC", Offset = "0x157C7CC", VA = "0x157C7CC")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x157C920", Offset = "0x157C920", VA = "0x157C920", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x157CE38", Offset = "0x157CE38", VA = "0x157CE38")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84F02C", Offset = "0x84F02C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F02C", Offset = "0x84F02C")]
		public Transform target;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F08C", Offset = "0x84F08C")]
		public float weight;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F0A4", Offset = "0x84F0A4")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F0DC", Offset = "0x84F0DC")]
		public float weightSmoothTime;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84F114", Offset = "0x84F114")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F114", Offset = "0x84F114")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F174", Offset = "0x84F174")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F1AC", Offset = "0x84F1AC")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F1E4", Offset = "0x84F1E4")]
		public float slerpSpeed;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F21C", Offset = "0x84F21C")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F254", Offset = "0x84F254")]
		public float minDistance;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x84F28C", Offset = "0x84F28C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F28C", Offset = "0x84F28C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x84F28C", Offset = "0x84F28C")]
		public float maxRootAngle;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700006A")]
		private Vector3 pivot
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x15868D0", Offset = "0x15868D0", VA = "0x15868D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x15867E8", Offset = "0x15867E8", VA = "0x15867E8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1586A1C", Offset = "0x1586A1C", VA = "0x1586A1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x15870B4", Offset = "0x15870B4", VA = "0x15870B4")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1587250", Offset = "0x1587250", VA = "0x1587250")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x158756C", Offset = "0x158756C", VA = "0x158756C")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class OffsetLimits
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851E00", Offset = "0x851E00")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851E38", Offset = "0x851E38")]
			public float spring;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851E70", Offset = "0x851E70")]
			public bool x;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851EA8", Offset = "0x851EA8")]
			public bool y;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851EE0", Offset = "0x851EE0")]
			public bool z;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851F18", Offset = "0x851F18")]
			public float minX;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851F50", Offset = "0x851F50")]
			public float maxX;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851F88", Offset = "0x851F88")]
			public float minY;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851FC0", Offset = "0x851FC0")]
			public float maxY;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x851FF8", Offset = "0x851FF8")]
			public float minZ;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852030", Offset = "0x852030")]
			public float maxZ;

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1587994", Offset = "0x1587994", VA = "0x1587994")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1587E9C", Offset = "0x1587E9C", VA = "0x1587E9C")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1587ECC", Offset = "0x1587ECC", VA = "0x1587ECC")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1587FA4", Offset = "0x1587FA4", VA = "0x1587FA4")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE14", Offset = "0x84BE14")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0x1587E2C", Offset = "0x1587E2C", VA = "0x1587E2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x1587E94", Offset = "0x1587E94", VA = "0x1587E94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x158785C", Offset = "0x158785C", VA = "0x158785C")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x1587CEC", Offset = "0x1587CEC", VA = "0x1587CEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x1587CF0", Offset = "0x1587CF0", VA = "0x1587CF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1587E34", Offset = "0x1587E34", VA = "0x1587E34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F308", Offset = "0x84F308")]
		public float weight;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F340", Offset = "0x84F340")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700006B")]
		protected float deltaTime
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x157C9D8", Offset = "0x157C9D8", VA = "0x157C9D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005AC")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x15877C0", Offset = "0x15877C0", VA = "0x15877C0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x15877EC", Offset = "0x15877EC", VA = "0x15877EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855C60", Offset = "0x855C60")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1587888", Offset = "0x1587888", VA = "0x1587888")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x157CD7C", Offset = "0x157CD7C", VA = "0x157CD7C")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1587BF4", Offset = "0x1587BF4", VA = "0x1587BF4", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x157CE48", Offset = "0x157CE48", VA = "0x157CE48")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE24", Offset = "0x84BE24")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x15883F4", Offset = "0x15883F4", VA = "0x15883F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B5")]
				[Address(RVA = "0x158845C", Offset = "0x158845C", VA = "0x158845C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1588074", Offset = "0x1588074", VA = "0x1588074")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x15882B4", Offset = "0x15882B4", VA = "0x15882B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x15882B8", Offset = "0x15882B8", VA = "0x15882B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x15883FC", Offset = "0x15883FC", VA = "0x15883FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F378", Offset = "0x84F378")]
		public float weight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F3B0", Offset = "0x84F3B0")]
		public VRIK ik;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006C")]
		protected float deltaTime
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1587FAC", Offset = "0x1587FAC", VA = "0x1587FAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005B4")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1587FD8", Offset = "0x1587FD8", VA = "0x1587FD8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1588004", Offset = "0x1588004", VA = "0x1588004")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855CC4", Offset = "0x855CC4")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x15880A0", Offset = "0x15880A0", VA = "0x15880A0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x15881AC", Offset = "0x15881AC", VA = "0x15881AC", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x15882A4", Offset = "0x15882A4", VA = "0x15882A4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E4")]
		public class EffectorLink
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1588524", Offset = "0x1588524", VA = "0x1588524")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1588974", Offset = "0x1588974", VA = "0x1588974")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1588464", Offset = "0x1588464", VA = "0x1588464")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x158885C", Offset = "0x158885C", VA = "0x158885C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1588914", Offset = "0x1588914", VA = "0x1588914")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x2000101")]
			public class EffectorLink
			{
				[Token(Token = "0x40006F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8529CC", Offset = "0x8529CC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852A04", Offset = "0x852A04")]
				public float weight;

				[Token(Token = "0x6000914")]
				[Address(RVA = "0x18F0B3C", Offset = "0x18F0B3C", VA = "0x18F0B3C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852068", Offset = "0x852068")]
			public Transform[] raycastFrom;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8520A0", Offset = "0x8520A0")]
			public Transform raycastTo;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8520D8", Offset = "0x8520D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8520D8", Offset = "0x8520D8")]
			public float raycastRadius;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85212C", Offset = "0x85212C")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852164", Offset = "0x852164")]
			public float smoothTimeIn;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85219C", Offset = "0x85219C")]
			public float smoothTimeOut;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8521D4", Offset = "0x8521D4")]
			public LayerMask layers;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x18F0518", Offset = "0x18F0518", VA = "0x18F0518")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x18F071C", Offset = "0x18F071C", VA = "0x18F071C")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x18F08B4", Offset = "0x18F08B4", VA = "0x18F08B4")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x18F0B28", Offset = "0x18F0B28", VA = "0x18F0B28")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F3E8", Offset = "0x84F3E8")]
		public Avoider[] avoiders;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x18F0494", Offset = "0x18F0494", VA = "0x18F0494", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x18F0714", Offset = "0x18F0714", VA = "0x18F0714")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E6")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000102")]
			public class EffectorLink
			{
				[Token(Token = "0x40006F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852A3C", Offset = "0x852A3C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852A74", Offset = "0x852A74")]
				public float weight;

				[Token(Token = "0x6000915")]
				[Address(RVA = "0x18F3BBC", Offset = "0x18F3BBC", VA = "0x18F3BBC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x85220C", Offset = "0x85220C")]
			public Vector3 offset;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852244", Offset = "0x852244")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852244", Offset = "0x852244")]
			public float additivity;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852298", Offset = "0x852298")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8522D0", Offset = "0x8522D0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x18F2904", Offset = "0x18F2904", VA = "0x18F2904")]
			public void Start()
			{
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x18F3494", Offset = "0x18F3494", VA = "0x18F3494")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x18F3BA8", Offset = "0x18F3BA8", VA = "0x18F3BA8")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum Handedness
		{
			[Token(Token = "0x4000685")]
			Right,
			[Token(Token = "0x4000686")]
			Left
		}

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F420", Offset = "0x84F420")]
		public AimIK aimIK;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F458", Offset = "0x84F458")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F490", Offset = "0x84F490")]
		public Handedness handedness;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F4C8", Offset = "0x84F4C8")]
		public bool twoHanded;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F500", Offset = "0x84F500")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F538", Offset = "0x84F538")]
		public float magnitudeRandom;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F570", Offset = "0x84F570")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F5A8", Offset = "0x84F5A8")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F5E0", Offset = "0x84F5E0")]
		public float blendTime;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x84F618", Offset = "0x84F618")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F618", Offset = "0x84F618")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700006D")]
		public bool isFinished
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x18F26DC", Offset = "0x18F26DC", VA = "0x18F26DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x18F3748", Offset = "0x18F3748", VA = "0x18F3748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x18F3788", Offset = "0x18F3788", VA = "0x18F3788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x18F3708", Offset = "0x18F3708", VA = "0x18F3708")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x18F3728", Offset = "0x18F3728", VA = "0x18F3728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x18F270C", Offset = "0x18F270C", VA = "0x18F270C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x18F2738", Offset = "0x18F2738", VA = "0x18F2738")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x18F29B4", Offset = "0x18F29B4", VA = "0x18F29B4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x18F37C8", Offset = "0x18F37C8", VA = "0x18F37C8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x18F3920", Offset = "0x18F3920", VA = "0x18F3920")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x18F395C", Offset = "0x18F395C", VA = "0x18F395C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x18F3AF8", Offset = "0x18F3AF8", VA = "0x18F3AF8")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F678", Offset = "0x84F678")]
		public float weight;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x84F6B0", Offset = "0x84F6B0")]
		public float offset;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x18F7424", Offset = "0x18F7424", VA = "0x18F7424")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x18F74F8", Offset = "0x18F74F8", VA = "0x18F74F8")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x18F75E4", Offset = "0x18F75E4", VA = "0x18F75E4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x18F7A2C", Offset = "0x18F7A2C", VA = "0x18F7A2C")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x18F7A64", Offset = "0x18F7A64", VA = "0x18F7A64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x18F7B5C", Offset = "0x18F7B5C", VA = "0x18F7B5C")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Settings
		{
			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852308", Offset = "0x852308")]
			public float scaleMlp;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852340", Offset = "0x852340")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852378", Offset = "0x852378")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8523B0", Offset = "0x8523B0")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8523E8", Offset = "0x8523E8")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852420", Offset = "0x852420")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852458", Offset = "0x852458")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852490", Offset = "0x852490")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8524C8", Offset = "0x8524C8")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x852500", Offset = "0x852500")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852500", Offset = "0x852500")]
			public Vector3 headOffset;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852550", Offset = "0x852550")]
			public Vector3 handOffset;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x852588", Offset = "0x852588")]
			public float footForwardOffset;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8525C0", Offset = "0x8525C0")]
			public float footInwardOffset;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8525F8", Offset = "0x8525F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8525F8", Offset = "0x8525F8")]
			public float footHeadingOffset;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x852654", Offset = "0x852654")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x85266C", Offset = "0x85266C")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x18FCBD0", Offset = "0x18FCBD0", VA = "0x18FCBD0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000103")]
			public class Target
			{
				[Token(Token = "0x40006F7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40006F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40006F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000916")]
				[Address(RVA = "0x18FBC7C", Offset = "0x18FBC7C", VA = "0x18FBC7C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000917")]
				[Address(RVA = "0x18FC7D0", Offset = "0x18FC7D0", VA = "0x18FC7D0")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x18FB120", Offset = "0x18FB120", VA = "0x18FB120")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x18F9CB8", Offset = "0x18F9CB8", VA = "0x18F9CB8")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x18F9E20", Offset = "0x18F9E20", VA = "0x18F9E20")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x18FB298", Offset = "0x18FB298", VA = "0x18FB298")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x18FBD40", Offset = "0x18FBD40", VA = "0x18FBD40")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x18FC830", Offset = "0x18FC830", VA = "0x18FC830")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F6E8", Offset = "0x84F6E8")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000072")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x18FCCC8", Offset = "0x18FCCC8", VA = "0x18FCCC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855D28", Offset = "0x855D28")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x18FCCD4", Offset = "0x18FCCD4", VA = "0x18FCCD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855D38", Offset = "0x855D38")]
			private set
			{
			}
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x18FCCE0", Offset = "0x18FCCE0", VA = "0x18FCCE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x18FBA58", Offset = "0x18FBA58", VA = "0x18FBA58")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x18FCA60", Offset = "0x18FCA60", VA = "0x18FCA60")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x18FCDB8", Offset = "0x18FCDB8", VA = "0x18FCDB8")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x18FD25C", Offset = "0x18FD25C", VA = "0x18FD25C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x18FD354", Offset = "0x18FD354", VA = "0x18FD354")]
		public VRIKRootController()
		{
		}
	}
}
namespace PathologicalGames
{
	[Token(Token = "0x2000077")]
	public static class PoolManager
	{
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SpawnPoolsDict Pools;
	}
	[Token(Token = "0x2000078")]
	public static class InstanceHandler
	{
		[Token(Token = "0x20000EA")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000EB")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static InstantiateDelegate InstantiateDelegates;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static DestroyDelegate DestroyDelegates;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x119301C", Offset = "0x119301C", VA = "0x119301C")]
		internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1193620", Offset = "0x1193620", VA = "0x1193620")]
		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x84BADC", Offset = "0x84BADC")]
	public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
	{
		[Token(Token = "0x20000EC")]
		public delegate void OnCreatedDelegate(SpawnPool pool);

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, SpawnPool> _pools;

		[Token(Token = "0x17000073")]
		public int Count
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x119C054", Offset = "0x119C054", VA = "0x119C054", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		public SpawnPool Item
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x119C118", Offset = "0x119C118", VA = "0x119C118", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x119C258", Offset = "0x119C258", VA = "0x119C258", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x119C2C4", Offset = "0x119C2C4", VA = "0x119C2C4", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public ICollection<SpawnPool> Values
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x119C330", Offset = "0x119C330", VA = "0x119C330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x119C39C", Offset = "0x119C39C", VA = "0x119C39C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x119C3A4", Offset = "0x119C3A4", VA = "0x119C3A4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x119B198", Offset = "0x119B198", VA = "0x119B198")]
		public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x119B2F0", Offset = "0x119B2F0", VA = "0x119B2F0")]
		public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x119B480", Offset = "0x119B480", VA = "0x119B480")]
		public SpawnPool Create(string poolName)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x119B518", Offset = "0x119B518", VA = "0x119B518")]
		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x119B634", Offset = "0x119B634", VA = "0x119B634")]
		private bool assertValidPoolName(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x119B7E8", Offset = "0x119B7E8", VA = "0x119B7E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x119B8C8", Offset = "0x119B8C8", VA = "0x119B8C8")]
		public bool Destroy(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x119BA00", Offset = "0x119BA00", VA = "0x119BA00")]
		public void DestroyAll()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x11975C0", Offset = "0x11975C0", VA = "0x11975C0")]
		internal void Add(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x119BF7C", Offset = "0x119BF7C", VA = "0x119BF7C", Slot = "9")]
		public void Add(string key, SpawnPool value)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1198240", Offset = "0x1198240", VA = "0x1198240")]
		internal bool Remove(SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x119BFE8", Offset = "0x119BFE8", VA = "0x119BFE8", Slot = "10")]
		public bool Remove(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x119B780", Offset = "0x119B780", VA = "0x119B780", Slot = "8")]
		public bool ContainsKey(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x11981D8", Offset = "0x11981D8", VA = "0x11981D8")]
		public bool ContainsValue(SpawnPool pool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1193D8C", Offset = "0x1193D8C", VA = "0x1193D8C", Slot = "11")]
		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x119C0AC", Offset = "0x119C0AC", VA = "0x119C0AC", Slot = "16")]
		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x119C3AC", Offset = "0x119C3AC", VA = "0x119C3AC", Slot = "14")]
		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x119C418", Offset = "0x119C418", VA = "0x119C418", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x119C484", Offset = "0x119C484", VA = "0x119C484")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x119C4F0", Offset = "0x119C4F0", VA = "0x119C4F0", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x119C55C", Offset = "0x119C55C", VA = "0x119C55C", Slot = "18")]
		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x119C5C8", Offset = "0x119C5C8", VA = "0x119C5C8", Slot = "19")]
		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x119C658", Offset = "0x119C658", VA = "0x119C658", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1193BCC", Offset = "0x1193BCC", VA = "0x1193BCC")]
		public SpawnPoolsDict()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84BB14", Offset = "0x84BB14")]
	public class PreRuntimePoolItem : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string prefabName;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool despawnOnStart;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool doNotReparent;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1193C64", Offset = "0x1193C64", VA = "0x1193C64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x11940DC", Offset = "0x11940DC", VA = "0x11940DC")]
		public PreRuntimePoolItem()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x84BB4C", Offset = "0x84BB4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x84BB4C", Offset = "0x84BB4C")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		[Token(Token = "0x20000ED")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000EE")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE34", Offset = "0x84BE34")]
		private sealed class <DoDespawnAfterSeconds>d__56 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform instance;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool useParent;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform parent;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject <go>5__2;

			[Token(Token = "0x17000117")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0x119A868", Offset = "0x119A868", VA = "0x119A868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x119A8D0", Offset = "0x119A8D0", VA = "0x119A8D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1199A28", Offset = "0x1199A28", VA = "0x1199A28")]
			[DebuggerHidden]
			public <DoDespawnAfterSeconds>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x119A790", Offset = "0x119A790", VA = "0x119A790", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x119A794", Offset = "0x119A794", VA = "0x119A794", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x119A870", Offset = "0x119A870", VA = "0x119A870", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE44", Offset = "0x84BE44")]
		private sealed class <ListForAudioStop>d__63 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioSource src;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <srcGameObject>5__2;

			[Token(Token = "0x17000119")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008DE")]
				[Address(RVA = "0x119AB70", Offset = "0x119AB70", VA = "0x119AB70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E0")]
				[Address(RVA = "0x119ABD8", Offset = "0x119ABD8", VA = "0x119ABD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1199F00", Offset = "0x1199F00", VA = "0x1199F00")]
			[DebuggerHidden]
			public <ListForAudioStop>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x119AA7C", Offset = "0x119AA7C", VA = "0x119AA7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x119AA80", Offset = "0x119AA80", VA = "0x119AA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x119AB78", Offset = "0x119AB78", VA = "0x119AB78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE54", Offset = "0x84BE54")]
		private sealed class <ListenForEmitDespawn>d__64 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ParticleSystem emitter;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <safetimer>5__2;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject <emitterGO>5__3;

			[Token(Token = "0x1700011B")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008E4")]
				[Address(RVA = "0x119AE64", Offset = "0x119AE64", VA = "0x119AE64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x119AECC", Offset = "0x119AECC", VA = "0x119AECC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1199F2C", Offset = "0x1199F2C", VA = "0x1199F2C")]
			[DebuggerHidden]
			public <ListenForEmitDespawn>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x119AC3C", Offset = "0x119AC3C", VA = "0x119AC3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x119AC40", Offset = "0x119AC40", VA = "0x119AC40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x119AE6C", Offset = "0x119AE6C", VA = "0x119AE6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE64", Offset = "0x84BE64")]
		private sealed class <GetEnumerator>d__73 : IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700011D")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x119AA0C", Offset = "0x119AA0C", VA = "0x119AA0C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x119AA74", Offset = "0x119AA74", VA = "0x119AA74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x119A354", Offset = "0x119A354", VA = "0x119A354")]
			[DebuggerHidden]
			public <GetEnumerator>d__73(int <>1__state)
			{
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x119A934", Offset = "0x119A934", VA = "0x119A934", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x119A938", Offset = "0x119A938", VA = "0x119A938", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x119AA14", Offset = "0x119AA14", VA = "0x119AA14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE74", Offset = "0x84BE74")]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700011F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F0")]
				[Address(RVA = "0x119B008", Offset = "0x119B008", VA = "0x119B008", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000120")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F2")]
				[Address(RVA = "0x119B070", Offset = "0x119B070", VA = "0x119B070", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x119A3F0", Offset = "0x119A3F0", VA = "0x119A3F0")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x119AF30", Offset = "0x119AF30", VA = "0x119AF30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x119AF34", Offset = "0x119AF34", VA = "0x119AF34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x119B010", Offset = "0x119B010", VA = "0x119B010", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool matchPoolScale;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool matchPoolLayer;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool dontReparent;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool _dontDestroyOnLoad;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool logMessages;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PrefabPool> _perPrefabPoolOptions;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<object, bool> prefabsFoldOutStates;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxParticleDespawnTime;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84F6F8", Offset = "0x84F6F8")]
		private Transform <group>k__BackingField;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PrefabsDict prefabs;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<object, bool> _editorListItemStates;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<PrefabPool> _prefabPools;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InstantiateDelegate instantiateDelegates;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DestroyDelegate destroyDelegates;

		[Token(Token = "0x17000079")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1196F38", Offset = "0x1196F38", VA = "0x1196F38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1196F40", Offset = "0x1196F40", VA = "0x1196F40")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Transform group
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1197018", Offset = "0x1197018", VA = "0x1197018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855D48", Offset = "0x855D48")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1197020", Offset = "0x1197020", VA = "0x1197020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x855D58", Offset = "0x855D58")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Dictionary<string, PrefabPool> prefabPools
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1197028", Offset = "0x1197028", VA = "0x1197028")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public Transform Item
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x119A0D4", Offset = "0x119A0D4", VA = "0x119A0D4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x119A14C", Offset = "0x119A14C", VA = "0x119A14C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public int Count
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x119A294", Offset = "0x119A294", VA = "0x119A294", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x119A59C", Offset = "0x119A59C", VA = "0x119A59C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1197144", Offset = "0x1197144", VA = "0x1197144")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1195378", Offset = "0x1195378", VA = "0x1195378")]
		internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x119474C", Offset = "0x119474C", VA = "0x119474C")]
		internal void DestroyInstance(GameObject instance)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1197FDC", Offset = "0x1197FDC", VA = "0x1197FDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1197414", Offset = "0x1197414", VA = "0x1197414")]
		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1193DFC", Offset = "0x1193DFC", VA = "0x1193DFC")]
		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x11984FC", Offset = "0x11984FC", VA = "0x11984FC", Slot = "11")]
		public void Add(Transform item)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1198568", Offset = "0x1198568", VA = "0x1198568")]
		public void Remove(Transform item)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x11985D4", Offset = "0x11985D4", VA = "0x11985D4")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1198A14", Offset = "0x1198A14", VA = "0x1198A14")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1198B08", Offset = "0x1198B08", VA = "0x1198B08")]
		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1198BF4", Offset = "0x1198BF4", VA = "0x1198BF4")]
		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1198CE8", Offset = "0x1198CE8", VA = "0x1198CE8")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1198D80", Offset = "0x1198D80", VA = "0x1198D80")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1198E10", Offset = "0x1198E10", VA = "0x1198E10")]
		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1198E48", Offset = "0x1198E48", VA = "0x1198E48")]
		public Transform Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1198E88", Offset = "0x1198E88", VA = "0x1198E88")]
		public Transform Spawn(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1198EBC", Offset = "0x1198EBC", VA = "0x1198EBC")]
		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1198EF8", Offset = "0x1198EF8", VA = "0x1198EF8")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1198F84", Offset = "0x1198F84", VA = "0x1198F84")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1199018", Offset = "0x1199018", VA = "0x1199018")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1199198", Offset = "0x1199198", VA = "0x1199198")]
		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1199288", Offset = "0x1199288", VA = "0x1199288")]
		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1199020", Offset = "0x1199020", VA = "0x1199020")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11993F8", Offset = "0x11993F8", VA = "0x11993F8")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1199400", Offset = "0x1199400", VA = "0x1199400")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x11995E8", Offset = "0x11995E8", VA = "0x11995E8")]
		public void Despawn(Transform instance)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11997B4", Offset = "0x11997B4", VA = "0x11997B4")]
		public void Despawn(Transform instance, Transform parent)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x119983C", Offset = "0x119983C", VA = "0x119983C")]
		public void Despawn(Transform instance, float seconds)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x1199984", Offset = "0x1199984", VA = "0x1199984")]
		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x11998DC", Offset = "0x11998DC", VA = "0x11998DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855D68", Offset = "0x855D68")]
		private IEnumerator<float> DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1199A54", Offset = "0x1199A54", VA = "0x1199A54")]
		public void DespawnAll()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1199B14", Offset = "0x1199B14", VA = "0x1199B14")]
		public bool IsSpawned(Transform instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x119832C", Offset = "0x119832C", VA = "0x119832C")]
		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1199B7C", Offset = "0x1199B7C", VA = "0x1199B7C")]
		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1199D2C", Offset = "0x1199D2C", VA = "0x1199D2C")]
		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1199E0C", Offset = "0x1199E0C", VA = "0x1199E0C")]
		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x119937C", Offset = "0x119937C", VA = "0x119937C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855DCC", Offset = "0x855DCC")]
		private IEnumerator<float> ListForAudioStop(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x119956C", Offset = "0x119956C", VA = "0x119956C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855E30", Offset = "0x855E30")]
		private IEnumerator<float> ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1199F58", Offset = "0x1199F58", VA = "0x1199F58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x119A1B8", Offset = "0x119A1B8", VA = "0x119A1B8", Slot = "13")]
		public bool Contains(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x119A224", Offset = "0x119A224", VA = "0x119A224", Slot = "14")]
		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x119A2E4", Offset = "0x119A2E4", VA = "0x119A2E4", Slot = "16")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855E94", Offset = "0x855E94")]
		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x119A380", Offset = "0x119A380", VA = "0x119A380", Slot = "17")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855EF8", Offset = "0x855EF8")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x119A41C", Offset = "0x119A41C", VA = "0x119A41C", Slot = "6")]
		public int IndexOf(Transform item)
		{
			return default(int);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x119A47C", Offset = "0x119A47C", VA = "0x119A47C", Slot = "7")]
		public void Insert(int index, Transform item)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x119A4DC", Offset = "0x119A4DC", VA = "0x119A4DC", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x119A53C", Offset = "0x119A53C", VA = "0x119A53C", Slot = "12")]
		public void Clear()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x119A5FC", Offset = "0x119A5FC", VA = "0x119A5FC", Slot = "15")]
		private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x119A65C", Offset = "0x119A65C", VA = "0x119A65C")]
		public SpawnPool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class PrefabPool
	{
		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE84", Offset = "0x84BE84")]
		private sealed class <CullDespawned>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x17000121")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F6")]
				[Address(RVA = "0x11961D0", Offset = "0x11961D0", VA = "0x11961D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000122")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F8")]
				[Address(RVA = "0x1196238", Offset = "0x1196238", VA = "0x1196238", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1194B20", Offset = "0x1194B20", VA = "0x1194B20")]
			[DebuggerHidden]
			public <CullDespawned>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1195CA4", Offset = "0x1195CA4", VA = "0x1195CA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1195CA8", Offset = "0x1195CA8", VA = "0x1195CA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x11961D8", Offset = "0x11961D8", VA = "0x11961D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BE94", Offset = "0x84BE94")]
		private sealed class <PreloadOverTime>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <remainder>5__2;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <numPerFrame>5__3;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <numThisFrame>5__4;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <i>5__5;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <n>5__6;

			[Token(Token = "0x17000123")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FC")]
				[Address(RVA = "0x1196438", Offset = "0x1196438", VA = "0x1196438", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0x11964A0", Offset = "0x11964A0", VA = "0x11964A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x1195B50", Offset = "0x1195B50", VA = "0x1195B50")]
			[DebuggerHidden]
			public <PreloadOverTime>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1196240", Offset = "0x1196240", VA = "0x1196240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x1196244", Offset = "0x1196244", VA = "0x1196244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1196440", Offset = "0x1196440", VA = "0x1196440", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform prefab;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GameObject prefabGO;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int preloadAmount;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool preloadTime;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int preloadFrames;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float preloadDelay;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool limitInstances;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int limitAmount;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool limitFIFO;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool cullDespawned;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int cullAbove;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cullDelay;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int cullMaxPerPass;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool _logMessages;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool forceLoggingSilent;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpawnPool spawnPool;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool cullingActive;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal List<Transform> _despawned;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _preloaded;

		[Token(Token = "0x1700007F")]
		public bool logMessages
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x119413C", Offset = "0x119413C", VA = "0x119413C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public List<Transform> spawned
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1194760", Offset = "0x1194760", VA = "0x1194760")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public List<Transform> despawned
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x11947D0", Offset = "0x11947D0", VA = "0x11947D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public int totalCount
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1194840", Offset = "0x1194840", VA = "0x1194840")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		internal bool preloaded
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x11948A0", Offset = "0x11948A0", VA = "0x11948A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x11948A8", Offset = "0x11948A8", VA = "0x11948A8")]
			private set
			{
			}
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1194180", Offset = "0x1194180", VA = "0x1194180")]
		public PrefabPool(Transform prefab)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1194268", Offset = "0x1194268", VA = "0x1194268")]
		public PrefabPool()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1194324", Offset = "0x1194324", VA = "0x1194324")]
		internal void inspectorInstanceConstructor()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x11943C4", Offset = "0x11943C4", VA = "0x11943C4")]
		internal void SelfDestruct()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x11948B4", Offset = "0x11948B4", VA = "0x11948B4")]
		internal bool DespawnInstance(Transform xform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x11948D0", Offset = "0x11948D0", VA = "0x11948D0")]
		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1194AB0", Offset = "0x1194AB0", VA = "0x1194AB0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855F5C", Offset = "0x855F5C")]
		internal IEnumerator CullDespawned()
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1194B4C", Offset = "0x1194B4C", VA = "0x1194B4C")]
		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x119529C", Offset = "0x119529C", VA = "0x119529C")]
		public Transform SpawnNew()
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1194EC4", Offset = "0x1194EC4", VA = "0x1194EC4")]
		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x119543C", Offset = "0x119543C", VA = "0x119543C")]
		private void SetRecursively(Transform xform, int layer)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x11956B4", Offset = "0x11956B4", VA = "0x11956B4")]
		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1195758", Offset = "0x1195758", VA = "0x1195758")]
		internal void PreloadInstances()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1195AE0", Offset = "0x1195AE0", VA = "0x1195AE0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x855FC0", Offset = "0x855FC0")]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1195B7C", Offset = "0x1195B7C", VA = "0x1195B7C")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x119538C", Offset = "0x119538C", VA = "0x119538C")]
		private void nameInstance(Transform instance)
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x84BBAC", Offset = "0x84BBAC")]
	public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transform> _prefabs;

		[Token(Token = "0x17000084")]
		public int Count
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x11966B8", Offset = "0x11966B8", VA = "0x11966B8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000085")]
		public Transform Item
		{
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x119692C", Offset = "0x119692C", VA = "0x119692C", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1196A6C", Offset = "0x1196A6C", VA = "0x1196A6C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1196AD8", Offset = "0x1196AD8", VA = "0x1196AD8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public ICollection<Transform> Values
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1196B30", Offset = "0x1196B30", VA = "0x1196B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1196B88", Offset = "0x1196B88", VA = "0x1196B88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1196B90", Offset = "0x1196B90", VA = "0x1196B90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x11964A8", Offset = "0x11964A8", VA = "0x11964A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x1196588", Offset = "0x1196588", VA = "0x1196588")]
		internal void _Add(string prefabName, Transform prefab)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x11965F8", Offset = "0x11965F8", VA = "0x11965F8")]
		internal bool _Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1196660", Offset = "0x1196660", VA = "0x1196660")]
		internal void _Clear()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1196710", Offset = "0x1196710", VA = "0x1196710", Slot = "8")]
		public bool ContainsKey(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1196778", Offset = "0x1196778", VA = "0x1196778", Slot = "11")]
		public bool TryGetValue(string prefabName, out Transform prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x11967E8", Offset = "0x11967E8", VA = "0x11967E8", Slot = "9")]
		public void Add(string key, Transform value)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1196854", Offset = "0x1196854", VA = "0x1196854", Slot = "10")]
		public bool Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x11968C0", Offset = "0x11968C0", VA = "0x11968C0", Slot = "16")]
		public bool Contains(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1196B98", Offset = "0x1196B98", VA = "0x1196B98", Slot = "14")]
		public void Add(KeyValuePair<string, Transform> item)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1196C04", Offset = "0x1196C04", VA = "0x1196C04", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1196C64", Offset = "0x1196C64", VA = "0x1196C64")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1196CD0", Offset = "0x1196CD0", VA = "0x1196CD0", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1196D3C", Offset = "0x1196D3C", VA = "0x1196D3C", Slot = "18")]
		public bool Remove(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1196DA8", Offset = "0x1196DA8", VA = "0x1196DA8", Slot = "19")]
		public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1196E38", Offset = "0x1196E38", VA = "0x1196E38", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1196EC8", Offset = "0x1196EC8", VA = "0x1196EC8")]
		public PrefabsDict()
		{
		}
	}
}
namespace Plugins.Isolationist
{
	[Token(Token = "0x200007E")]
	public class IsolateInfo : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x84BEA4", Offset = "0x84BEA4")]
		private sealed class <>c
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__9_0;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<GameObject> <>9__9_1;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<GameObject, bool> <>9__10_0;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<GameObject> <>9__10_1;

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x119CDB8", Offset = "0x119CDB8", VA = "0x119CDB8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x119CDC0", Offset = "0x119CDC0", VA = "0x119CDC0")]
			internal bool <Hide>b__9_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x119CE28", Offset = "0x119CE28", VA = "0x119CE28")]
			internal void <Hide>b__9_1(GameObject go)
			{
			}

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x119CE48", Offset = "0x119CE48", VA = "0x119CE48")]
			internal bool <Show>b__10_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x119CEB0", Offset = "0x119CEB0", VA = "0x119CEB0")]
			internal void <Show>b__10_1(GameObject go)
			{
			}
		}

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IsolateInfo _instance;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _searched;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> FocusObjects;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GameObject> HiddenObjects;

		[Token(Token = "0x1700008A")]
		public static IsolateInfo Instance
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x119C728", Offset = "0x119C728", VA = "0x119C728")]
			get
			{
				return null;
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x119C7F4", Offset = "0x119C7F4", VA = "0x119C7F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public static bool IsIsolated
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x119C848", Offset = "0x119C848", VA = "0x119C848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x119C918", Offset = "0x119C918", VA = "0x119C918")]
		public static void Hide()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x119CB30", Offset = "0x119CB30", VA = "0x119CB30")]
		public static void Show()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x119CD48", Offset = "0x119CD48", VA = "0x119CD48")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x119CD4C", Offset = "0x119CD4C", VA = "0x119CD4C")]
		public IsolateInfo()
		{
		}
	}
}
