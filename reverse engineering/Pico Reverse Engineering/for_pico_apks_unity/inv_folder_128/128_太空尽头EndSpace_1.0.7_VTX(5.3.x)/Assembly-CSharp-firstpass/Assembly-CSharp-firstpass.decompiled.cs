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
	[Address(RVA = "0x17837C0", Offset = "0x17837C0", VA = "0x17837C0")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1783FD0", Offset = "0x1783FD0", VA = "0x1783FD0")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1783F08", Offset = "0x1783F08", VA = "0x1783F08")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x178409C", Offset = "0x178409C", VA = "0x178409C")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1784CCC", Offset = "0x1784CCC", VA = "0x1784CCC")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1784A80", Offset = "0x1784A80", VA = "0x1784A80")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1784C60", Offset = "0x1784C60", VA = "0x1784C60")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x17845AC", Offset = "0x17845AC", VA = "0x17845AC")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1784DB8", Offset = "0x1784DB8", VA = "0x1784DB8")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x17851CC", Offset = "0x17851CC", VA = "0x17851CC")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x17850AC", Offset = "0x17850AC", VA = "0x17850AC")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x17852DC", Offset = "0x17852DC", VA = "0x17852DC")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x869AA4", Offset = "0x869AA4")]
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
public static class MECExtensionMethods
{
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A538", Offset = "0x86A538")]
	private sealed class <Delay>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float timeToDelay;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700008D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1329AD8", Offset = "0x1329AD8", VA = "0x1329AD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1329B48", Offset = "0x1329B48", VA = "0x1329B48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1327F14", Offset = "0x1327F14", VA = "0x1327F14")]
		[DebuggerHidden]
		public <Delay>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x132991C", Offset = "0x132991C", VA = "0x132991C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1329920", Offset = "0x1329920", VA = "0x1329920", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1329AE0", Offset = "0x1329AE0", VA = "0x1329AE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A548", Offset = "0x86A548")]
	private sealed class <Delay>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700008F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1329D50", Offset = "0x1329D50", VA = "0x1329D50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1329DC0", Offset = "0x1329DC0", VA = "0x1329DC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1327FD8", Offset = "0x1327FD8", VA = "0x1327FD8")]
		[DebuggerHidden]
		public <Delay>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1329BAC", Offset = "0x1329BAC", VA = "0x1329BAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1329BB0", Offset = "0x1329BB0", VA = "0x1329BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1329D58", Offset = "0x1329D58", VA = "0x1329D58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A558", Offset = "0x86A558")]
	private sealed class <Delay>d__2<T> : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Func<T, bool> condition;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T data;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000091")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600065E")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000660")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600065B")]
		[DebuggerHidden]
		public <Delay>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600065C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600065D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A568", Offset = "0x86A568")]
	private sealed class <DelayFrames>d__3 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int framesToDelay;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x17000093")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x1329FB0", Offset = "0x1329FB0", VA = "0x1329FB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x132A020", Offset = "0x132A020", VA = "0x132A020", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x132809C", Offset = "0x132809C", VA = "0x132809C")]
		[DebuggerHidden]
		public <DelayFrames>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1329E24", Offset = "0x1329E24", VA = "0x1329E24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1329E28", Offset = "0x1329E28", VA = "0x1329E28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1329FB8", Offset = "0x1329FB8", VA = "0x1329FB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A578", Offset = "0x86A578")]
	private sealed class <CancelWith>d__4 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x17000095")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1329268", Offset = "0x1329268", VA = "0x1329268", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x13292D8", Offset = "0x13292D8", VA = "0x13292D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1328160", Offset = "0x1328160", VA = "0x1328160")]
		[DebuggerHidden]
		public <CancelWith>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1329068", Offset = "0x1329068", VA = "0x1329068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x132906C", Offset = "0x132906C", VA = "0x132906C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1329270", Offset = "0x1329270", VA = "0x1329270", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A588", Offset = "0x86A588")]
	private sealed class <CancelWith>d__5 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x17000097")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1329588", Offset = "0x1329588", VA = "0x1329588", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x13295F8", Offset = "0x13295F8", VA = "0x13295F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1328238", Offset = "0x1328238", VA = "0x1328238")]
		[DebuggerHidden]
		public <CancelWith>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x132933C", Offset = "0x132933C", VA = "0x132933C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1329340", Offset = "0x1329340", VA = "0x1329340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1329590", Offset = "0x1329590", VA = "0x1329590", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A598", Offset = "0x86A598")]
	private sealed class <CancelWith>d__6<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x17000099")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000676")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000678")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000673")]
		[DebuggerHidden]
		public <CancelWith>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000674")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000675")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5A8", Offset = "0x86A5A8")]
	private sealed class <CancelWith>d__7 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009B")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x1329848", Offset = "0x1329848", VA = "0x1329848", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x13298B8", Offset = "0x13298B8", VA = "0x13298B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x13282FC", Offset = "0x13282FC", VA = "0x13282FC")]
		[DebuggerHidden]
		public <CancelWith>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x132965C", Offset = "0x132965C", VA = "0x132965C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1329660", Offset = "0x1329660", VA = "0x1329660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1329850", Offset = "0x1329850", VA = "0x1329850", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5B8", Offset = "0x86A5B8")]
	private sealed class <PauseWith>d__8 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009D")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x132A7CC", Offset = "0x132A7CC", VA = "0x132A7CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x132A83C", Offset = "0x132A83C", VA = "0x132A83C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x13283C0", Offset = "0x13283C0", VA = "0x13283C0")]
		[DebuggerHidden]
		public <PauseWith>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x132A5C8", Offset = "0x132A5C8", VA = "0x132A5C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x132A5CC", Offset = "0x132A5CC", VA = "0x132A5CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x132A7D4", Offset = "0x132A7D4", VA = "0x132A7D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5C8", Offset = "0x86A5C8")]
	private sealed class <PauseWith>d__9 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject gameObject1;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject2;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x1700009F")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x132AAF8", Offset = "0x132AAF8", VA = "0x132AAF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x132AB68", Offset = "0x132AB68", VA = "0x132AB68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x132849C", Offset = "0x132849C", VA = "0x132849C")]
		[DebuggerHidden]
		public <PauseWith>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x132A8A0", Offset = "0x132A8A0", VA = "0x132A8A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x132A8A4", Offset = "0x132A8A4", VA = "0x132A8A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x132AB00", Offset = "0x132AB00", VA = "0x132AB00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5D8", Offset = "0x86A5D8")]
	private sealed class <PauseWith>d__10<T> : IEnumerator<float>, IEnumerator, IDisposable where T : MonoBehaviour
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int <>1__state;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float <>2__current;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T script;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private GameObject <myGO>5__2;

		[Token(Token = "0x170000A1")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600068E")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000690")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068B")]
		[DebuggerHidden]
		public <PauseWith>d__10(int <>1__state)
		{
		}

		[Token(Token = "0x600068C")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068D")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068F")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5E8", Offset = "0x86A5E8")]
	private sealed class <PauseWith>d__11 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<bool> condition;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000A3")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x132A4F4", Offset = "0x132A4F4", VA = "0x132A4F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x132A564", Offset = "0x132A564", VA = "0x132A564", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1328560", Offset = "0x1328560", VA = "0x1328560")]
		[DebuggerHidden]
		public <PauseWith>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x132A308", Offset = "0x132A308", VA = "0x132A308", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x132A30C", Offset = "0x132A30C", VA = "0x132A30C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x132A4FC", Offset = "0x132A4FC", VA = "0x132A4FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A5F8", Offset = "0x86A5F8")]
	private sealed class <Append>d__12 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> nextCoroutine;

		[Token(Token = "0x170000A5")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1328D50", Offset = "0x1328D50", VA = "0x1328D50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1328DC0", Offset = "0x1328DC0", VA = "0x1328DC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1328624", Offset = "0x1328624", VA = "0x1328624")]
		[DebuggerHidden]
		public <Append>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1328ABC", Offset = "0x1328ABC", VA = "0x1328ABC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1328AC0", Offset = "0x1328AC0", VA = "0x1328AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1328D58", Offset = "0x1328D58", VA = "0x1328D58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A608", Offset = "0x86A608")]
	private sealed class <Append>d__13 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action onDone;

		[Token(Token = "0x170000A7")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1328F94", Offset = "0x1328F94", VA = "0x1328F94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1329004", Offset = "0x1329004", VA = "0x1329004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x13286E8", Offset = "0x13286E8", VA = "0x13286E8")]
		[DebuggerHidden]
		public <Append>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1328E24", Offset = "0x1328E24", VA = "0x1328E24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1328E28", Offset = "0x1328E28", VA = "0x1328E28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1328F9C", Offset = "0x1328F9C", VA = "0x1328F9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A618", Offset = "0x86A618")]
	private sealed class <Prepend>d__14 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> lastCoroutine;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000A9")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x132AE70", Offset = "0x132AE70", VA = "0x132AE70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x132AEE0", Offset = "0x132AEE0", VA = "0x132AEE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x13287AC", Offset = "0x13287AC", VA = "0x13287AC")]
		[DebuggerHidden]
		public <Prepend>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x132ABCC", Offset = "0x132ABCC", VA = "0x132ABCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x132ABD0", Offset = "0x132ABD0", VA = "0x132ABD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x132AE78", Offset = "0x132AE78", VA = "0x132AE78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A628", Offset = "0x86A628")]
	private sealed class <Prepend>d__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onStart;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000AB")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x132B0C4", Offset = "0x132B0C4", VA = "0x132B0C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x132B134", Offset = "0x132B134", VA = "0x132B134", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1328870", Offset = "0x1328870", VA = "0x1328870")]
		[DebuggerHidden]
		public <Prepend>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x132AF44", Offset = "0x132AF44", VA = "0x132AF44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x132AF48", Offset = "0x132AF48", VA = "0x132AF48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x132B0CC", Offset = "0x132B0CC", VA = "0x132B0CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A638", Offset = "0x86A638")]
	private sealed class <Superimpose>d__17 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutineA;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Timing instance;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IEnumerator<float> coroutineB;

		[Token(Token = "0x170000AD")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x132B794", Offset = "0x132B794", VA = "0x132B794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x132B804", Offset = "0x132B804", VA = "0x132B804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x13289CC", Offset = "0x13289CC", VA = "0x13289CC")]
		[DebuggerHidden]
		public <Superimpose>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x132B198", Offset = "0x132B198", VA = "0x132B198", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x132B19C", Offset = "0x132B19C", VA = "0x132B19C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x132B79C", Offset = "0x132B79C", VA = "0x132B79C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A648", Offset = "0x86A648")]
	private sealed class <Hijack>d__18 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<float, float> newReturn;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x170000AF")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x132A234", Offset = "0x132A234", VA = "0x132A234", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x132A2A4", Offset = "0x132A2A4", VA = "0x132A2A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1328A90", Offset = "0x1328A90", VA = "0x1328A90")]
		[DebuggerHidden]
		public <Hijack>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x132A084", Offset = "0x132A084", VA = "0x132A084", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x132A088", Offset = "0x132A088", VA = "0x132A088", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x132A23C", Offset = "0x132A23C", VA = "0x132A23C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1327E7C", Offset = "0x1327E7C", VA = "0x1327E7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8713C0", Offset = "0x8713C0")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, float timeToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1327F40", Offset = "0x1327F40", VA = "0x1327F40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871434", Offset = "0x871434")]
	public static IEnumerator<float> Delay(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8714A8", Offset = "0x8714A8")]
	public static IEnumerator<float> Delay<T>(this IEnumerator<float> coroutine, T data, Func<T, bool> condition)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1328004", Offset = "0x1328004", VA = "0x1328004")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87151C", Offset = "0x87151C")]
	public static IEnumerator<float> DelayFrames(this IEnumerator<float> coroutine, int framesToDelay)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x13280C8", Offset = "0x13280C8", VA = "0x13280C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871590", Offset = "0x871590")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x132818C", Offset = "0x132818C", VA = "0x132818C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871604", Offset = "0x871604")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871678", Offset = "0x871678")]
	public static IEnumerator<float> CancelWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1328264", Offset = "0x1328264", VA = "0x1328264")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8716EC", Offset = "0x8716EC")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1328328", Offset = "0x1328328", VA = "0x1328328")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871760", Offset = "0x871760")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x13283EC", Offset = "0x13283EC", VA = "0x13283EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8717D4", Offset = "0x8717D4")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871848", Offset = "0x871848")]
	public static IEnumerator<float> PauseWith<T>(this IEnumerator<float> coroutine, T script) where T : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x13284C8", Offset = "0x13284C8", VA = "0x13284C8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8718BC", Offset = "0x8718BC")]
	public static IEnumerator<float> PauseWith(this IEnumerator<float> coroutine, Func<bool> condition)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x132858C", Offset = "0x132858C", VA = "0x132858C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871930", Offset = "0x871930")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, IEnumerator<float> nextCoroutine)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1328650", Offset = "0x1328650", VA = "0x1328650")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8719A4", Offset = "0x8719A4")]
	public static IEnumerator<float> Append(this IEnumerator<float> coroutine, Action onDone)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1328714", Offset = "0x1328714", VA = "0x1328714")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871A18", Offset = "0x871A18")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, IEnumerator<float> lastCoroutine)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x13287D8", Offset = "0x13287D8", VA = "0x13287D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871A8C", Offset = "0x871A8C")]
	public static IEnumerator<float> Prepend(this IEnumerator<float> coroutine, Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x132889C", Offset = "0x132889C", VA = "0x132889C")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x132891C", Offset = "0x132891C", VA = "0x132891C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871B10", Offset = "0x871B10")]
	public static IEnumerator<float> Superimpose(this IEnumerator<float> coroutineA, IEnumerator<float> coroutineB, Timing instance)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x13289F8", Offset = "0x13289F8", VA = "0x13289F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871B84", Offset = "0x871B84")]
	public static IEnumerator<float> Hijack(this IEnumerator<float> coroutine, Func<float, float> newReturn)
	{
		return null;
	}
}
namespace MEC
{
	[Token(Token = "0x2000005")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x2000091")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x924358", Offset = "0x924358", VA = "0x924358", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x924380", Offset = "0x924380", VA = "0x924380", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1327E1C", Offset = "0x1327E1C", VA = "0x1327E1C")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1327E3C", Offset = "0x1327E3C", VA = "0x1327E3C")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x924388", Offset = "0x924388", VA = "0x924388", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A658", Offset = "0x86A658")]
		private sealed class <_EOFPumpWatcher>d__132 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x170000B1")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006C3")]
				[Address(RVA = "0x1326CAC", Offset = "0x1326CAC", VA = "0x1326CAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006C5")]
				[Address(RVA = "0x1326D1C", Offset = "0x1326D1C", VA = "0x1326D1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1326BC8", Offset = "0x1326BC8", VA = "0x1326BC8")]
			[DebuggerHidden]
			public <_EOFPumpWatcher>d__132(int <>1__state)
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1326BF4", Offset = "0x1326BF4", VA = "0x1326BF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1326BF8", Offset = "0x1326BF8", VA = "0x1326BF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1326CB4", Offset = "0x1326CB4", VA = "0x1326CB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A668", Offset = "0x86A668")]
		private sealed class <_EOFPump>d__133 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Timing <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x1326B50", Offset = "0x1326B50", VA = "0x1326B50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x1326BC0", Offset = "0x1326BC0", VA = "0x1326BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x132621C", Offset = "0x132621C", VA = "0x132621C")]
			[DebuggerHidden]
			public <_EOFPump>d__133(int <>1__state)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1326248", Offset = "0x1326248", VA = "0x1326248", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x132624C", Offset = "0x132624C", VA = "0x132624C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1326B58", Offset = "0x1326B58", VA = "0x1326B58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A678", Offset = "0x86A678")]
		private sealed class <_StartWhenDone>d__274 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000B5")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006D0")]
				[Address(RVA = "0x13273C0", Offset = "0x13273C0", VA = "0x13273C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D2")]
				[Address(RVA = "0x1327430", Offset = "0x1327430", VA = "0x1327430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1326FBC", Offset = "0x1326FBC", VA = "0x1326FBC")]
			[DebuggerHidden]
			public <_StartWhenDone>d__274(int <>1__state)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1326FE8", Offset = "0x1326FE8", VA = "0x1326FE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1327054", Offset = "0x1327054", VA = "0x1327054", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1327014", Offset = "0x1327014", VA = "0x1327014")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x13273C8", Offset = "0x13273C8", VA = "0x13273C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A688", Offset = "0x86A688")]
		private sealed class <_StartWhenDone>d__279 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000B7")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x13275EC", Offset = "0x13275EC", VA = "0x13275EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D8")]
				[Address(RVA = "0x132765C", Offset = "0x132765C", VA = "0x132765C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1327494", Offset = "0x1327494", VA = "0x1327494")]
			[DebuggerHidden]
			public <_StartWhenDone>d__279(int <>1__state)
			{
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x13274C0", Offset = "0x13274C0", VA = "0x13274C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x13274C4", Offset = "0x13274C4", VA = "0x13274C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x13275F4", Offset = "0x13275F4", VA = "0x13275F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A698", Offset = "0x86A698")]
		private sealed class <_StartWhenDone>d__281 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000B9")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006DC")]
				[Address(RVA = "0x132781C", Offset = "0x132781C", VA = "0x132781C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DE")]
				[Address(RVA = "0x132788C", Offset = "0x132788C", VA = "0x132788C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x13276C0", Offset = "0x13276C0", VA = "0x13276C0")]
			[DebuggerHidden]
			public <_StartWhenDone>d__281(int <>1__state)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x13276EC", Offset = "0x13276EC", VA = "0x13276EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x13276F0", Offset = "0x13276F0", VA = "0x13276F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1327824", Offset = "0x1327824", VA = "0x1327824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6A8", Offset = "0x86A6A8")]
		private sealed class <_StartWhenDone>d__286 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> evaluatorFunc;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool continueOn;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000BB")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1327A60", Offset = "0x1327A60", VA = "0x1327A60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x1327AD0", Offset = "0x1327AD0", VA = "0x1327AD0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x13278F0", Offset = "0x13278F0", VA = "0x13278F0")]
			[DebuggerHidden]
			public <_StartWhenDone>d__286(int <>1__state)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x132791C", Offset = "0x132791C", VA = "0x132791C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x1327920", Offset = "0x1327920", VA = "0x1327920", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x1327A68", Offset = "0x1327A68", VA = "0x1327A68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6B8", Offset = "0x86A6B8")]
		private sealed class <_InjectDelay>d__287 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float waitTime;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000BD")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x1326EE8", Offset = "0x1326EE8", VA = "0x1326EE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006EA")]
				[Address(RVA = "0x1326F58", Offset = "0x1326F58", VA = "0x1326F58", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x1326D80", Offset = "0x1326D80", VA = "0x1326D80")]
			[DebuggerHidden]
			public <_InjectDelay>d__287(int <>1__state)
			{
			}

			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x1326DAC", Offset = "0x1326DAC", VA = "0x1326DAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1326DB0", Offset = "0x1326DB0", VA = "0x1326DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1326EF0", Offset = "0x1326EF0", VA = "0x1326EF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6C8", Offset = "0x86A6C8")]
		private sealed class <_DelayedCall>d__312 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000BF")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006EE")]
				[Address(RVA = "0x1326148", Offset = "0x1326148", VA = "0x1326148", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F0")]
				[Address(RVA = "0x13261B8", Offset = "0x13261B8", VA = "0x13261B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x1326020", Offset = "0x1326020", VA = "0x1326020")]
			[DebuggerHidden]
			public <_DelayedCall>d__312(int <>1__state)
			{
			}

			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x132604C", Offset = "0x132604C", VA = "0x132604C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x1326050", Offset = "0x1326050", VA = "0x1326050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x1326150", Offset = "0x1326150", VA = "0x1326150", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6D8", Offset = "0x86A6D8")]
		private sealed class <_WatchCall>d__329 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeframe;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action onDone;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public GameObject gObject;

			[Token(Token = "0x170000C1")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006F4")]
				[Address(RVA = "0x1327C88", Offset = "0x1327C88", VA = "0x1327C88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006F6")]
				[Address(RVA = "0x1327CF8", Offset = "0x1327CF8", VA = "0x1327CF8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1327B34", Offset = "0x1327B34", VA = "0x1327B34")]
			[DebuggerHidden]
			public <_WatchCall>d__329(int <>1__state)
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1327B60", Offset = "0x1327B60", VA = "0x1327B60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1327B64", Offset = "0x1327B64", VA = "0x1327B64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1327C90", Offset = "0x1327C90", VA = "0x1327C90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6E8", Offset = "0x86A6E8")]
		private sealed class <_CallContinuously>d__330 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject gObject;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000C3")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1325F4C", Offset = "0x1325F4C", VA = "0x1325F4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x1325FBC", Offset = "0x1325FBC", VA = "0x1325FBC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1325DB4", Offset = "0x1325DB4", VA = "0x1325DB4")]
			[DebuggerHidden]
			public <_CallContinuously>d__330(int <>1__state)
			{
			}

			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x1325DE0", Offset = "0x1325DE0", VA = "0x1325DE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x1325DE4", Offset = "0x1325DE4", VA = "0x1325DE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1325F54", Offset = "0x1325F54", VA = "0x1325F54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A6F8", Offset = "0x86A6F8")]
		private sealed class <_WatchCall>d__347<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000C5")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000700")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000702")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006FD")]
			[DebuggerHidden]
			public <_WatchCall>d__347(int <>1__state)
			{
			}

			[Token(Token = "0x60006FE")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006FF")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000701")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A708", Offset = "0x86A708")]
		private sealed class <_CallContinuously>d__348<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public GameObject gObject;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x170000C7")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000706")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000C8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000708")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000703")]
			[DebuggerHidden]
			public <_CallContinuously>d__348(int <>1__state)
			{
			}

			[Token(Token = "0x6000704")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000705")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000707")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A7D8", Offset = "0x86A7D8")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A810", Offset = "0x86A810")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A848", Offset = "0x86A848")]
		public bool AutoTriggerManualTimeframe;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A880", Offset = "0x86A880")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x86A880", Offset = "0x86A880")]
		public int UpdateCoroutines;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A8D0", Offset = "0x86A8D0")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A908", Offset = "0x86A908")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A940", Offset = "0x86A940")]
		public int SlowUpdateCoroutines;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A978", Offset = "0x86A978")]
		public int RealtimeUpdateCoroutines;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A9B0", Offset = "0x86A9B0")]
		public int EditorUpdateCoroutines;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86A9E8", Offset = "0x86A9E8")]
		public int EditorSlowUpdateCoroutines;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AA20", Offset = "0x86AA20")]
		public int EndOfFrameCoroutines;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AA58", Offset = "0x86AA58")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AAA0", Offset = "0x86AAA0")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CoroutineHandle _currentCoroutine;

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
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1787344", Offset = "0x1787344", VA = "0x1787344")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000008")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x178761C", Offset = "0x178761C", VA = "0x178761C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000009")]
		public static Thread MainThread
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x17878EC", Offset = "0x17878EC", VA = "0x17878EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x871C18", Offset = "0x871C18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1787954", Offset = "0x1787954", VA = "0x1787954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x871C28", Offset = "0x871C28")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public static CoroutineHandle CurrentCoroutine
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x17879C0", Offset = "0x17879C0", VA = "0x17879C0")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x1700000B")]
		public CoroutineHandle currentCoroutine
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1787B7C", Offset = "0x1787B7C", VA = "0x1787B7C")]
			get
			{
				return default(CoroutineHandle);
			}
		}

		[Token(Token = "0x1700000C")]
		public static Timing Instance
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x17873B4", Offset = "0x17873B4", VA = "0x17873B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1787E20", Offset = "0x1787E20", VA = "0x1787E20")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x178768C", Offset = "0x178768C", VA = "0x178768C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x871BF8", Offset = "0x871BF8")]
			add
			{
			}
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x17877BC", Offset = "0x17877BC", VA = "0x17877BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x871C08", Offset = "0x871C08")]
			remove
			{
			}
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1787E8C", Offset = "0x1787E8C", VA = "0x1787E8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1787FF4", Offset = "0x1787FF4", VA = "0x1787FF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17880C4", Offset = "0x17880C4", VA = "0x17880C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1788430", Offset = "0x1788430", VA = "0x1788430")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1787B84", Offset = "0x1787B84", VA = "0x1787B84")]
		private void InitializeInstanceID()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1788518", Offset = "0x1788518", VA = "0x1788518")]
		private void Update()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x178CDD0", Offset = "0x178CDD0", VA = "0x178CDD0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x178D5AC", Offset = "0x178D5AC", VA = "0x178D5AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x178A09C", Offset = "0x178A09C", VA = "0x178A09C")]
		public void TriggerManualTimeframeUpdate()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1788144", Offset = "0x1788144", VA = "0x1788144")]
		private bool OnEditorStart()
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x178814C", Offset = "0x178814C", VA = "0x178814C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871C38", Offset = "0x871C38")]
		private IEnumerator<float> _EOFPumpWatcher()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x178DD88", Offset = "0x178DD88", VA = "0x178DD88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871C9C", Offset = "0x871C9C")]
		private IEnumerator _EOFPump()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x178A89C", Offset = "0x178A89C", VA = "0x178A89C")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x178E40C", Offset = "0x178E40C", VA = "0x178E40C")]
		private void EditorRemoveUnused()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x178EFEC", Offset = "0x178EFEC", VA = "0x178EFEC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1792160", Offset = "0x1792160", VA = "0x1792160")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17922CC", Offset = "0x17922CC", VA = "0x17922CC")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17923C0", Offset = "0x17923C0", VA = "0x17923C0")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1792498", Offset = "0x1792498", VA = "0x1792498")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1792608", Offset = "0x1792608", VA = "0x1792608")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1792700", Offset = "0x1792700", VA = "0x1792700")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17927D8", Offset = "0x17927D8", VA = "0x17927D8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1792948", Offset = "0x1792948", VA = "0x1792948")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1792A40", Offset = "0x1792A40", VA = "0x1792A40")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1792B1C", Offset = "0x1792B1C", VA = "0x1792B1C")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1792C98", Offset = "0x1792C98", VA = "0x1792C98")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1792D9C", Offset = "0x1792D9C", VA = "0x1792D9C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1792E04", Offset = "0x1792E04", VA = "0x1792E04")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1792F18", Offset = "0x1792F18", VA = "0x1792F18")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1792FCC", Offset = "0x1792FCC", VA = "0x1792FCC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1793038", Offset = "0x1793038", VA = "0x1793038")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1793158", Offset = "0x1793158", VA = "0x1793158")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1793218", Offset = "0x1793218", VA = "0x1793218")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1793284", Offset = "0x1793284", VA = "0x1793284")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x17933A4", Offset = "0x17933A4", VA = "0x17933A4")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1793464", Offset = "0x1793464", VA = "0x1793464")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x17934DC", Offset = "0x17934DC", VA = "0x17934DC")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1793600", Offset = "0x1793600", VA = "0x1793600")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x17936C4", Offset = "0x17936C4", VA = "0x17936C4")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1793C30", Offset = "0x1793C30", VA = "0x1793C30")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1793D34", Offset = "0x1793D34", VA = "0x1793D34")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1794AD0", Offset = "0x1794AD0", VA = "0x1794AD0")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1794EE8", Offset = "0x1794EE8", VA = "0x1794EE8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1795004", Offset = "0x1795004", VA = "0x1795004")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x179575C", Offset = "0x179575C", VA = "0x179575C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, CoroutineHandle handle, Segment segment, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1795924", Offset = "0x1795924", VA = "0x1795924")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1795A3C", Offset = "0x1795A3C", VA = "0x1795A3C")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1795DA8", Offset = "0x1795DA8", VA = "0x1795DA8")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x17960DC", Offset = "0x17960DC", VA = "0x17960DC")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1796204", Offset = "0x1796204", VA = "0x1796204")]
		public static CoroutineHandle RunCoroutineSingleton(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1796880", Offset = "0x1796880", VA = "0x1796880")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, CoroutineHandle handle, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1796A20", Offset = "0x1796A20", VA = "0x1796A20")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1796AF0", Offset = "0x1796AF0", VA = "0x1796AF0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x17881C0", Offset = "0x17881C0", VA = "0x17881C0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1797418", Offset = "0x1797418", VA = "0x1797418")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x17974F8", Offset = "0x17974F8", VA = "0x17974F8")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1797EB0", Offset = "0x1797EB0", VA = "0x1797EB0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1797F8C", Offset = "0x1797F8C", VA = "0x1797F8C")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1798238", Offset = "0x1798238", VA = "0x1798238")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x17984AC", Offset = "0x17984AC", VA = "0x17984AC")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, GameObject gameObj, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x17985A0", Offset = "0x17985A0", VA = "0x17985A0")]
		public CoroutineHandle RunCoroutineSingletonOnInstance(IEnumerator<float> coroutine, Segment segment, int layer, string tag, SingletonBehavior behaviorOnCollision)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x178F0B8", Offset = "0x178F0B8", VA = "0x178F0B8")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, int? layer, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1798D28", Offset = "0x1798D28", VA = "0x1798D28")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1798E0C", Offset = "0x1798E0C", VA = "0x1798E0C")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1786A64", Offset = "0x1786A64", VA = "0x1786A64")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1789E40", Offset = "0x1789E40", VA = "0x1789E40")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x179933C", Offset = "0x179933C", VA = "0x179933C")]
		public static int KillCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1799450", Offset = "0x1799450", VA = "0x1799450")]
		public int KillCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x179408C", Offset = "0x179408C", VA = "0x179408C")]
		public static int KillCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1796D98", Offset = "0x1796D98", VA = "0x1796D98")]
		public int KillCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1794DF0", Offset = "0x1794DF0", VA = "0x1794DF0")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x17970C0", Offset = "0x17970C0", VA = "0x17970C0")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1799758", Offset = "0x1799758", VA = "0x1799758")]
		public static int KillCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1799874", Offset = "0x1799874", VA = "0x1799874")]
		public int KillCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x179565C", Offset = "0x179565C", VA = "0x179565C")]
		public static int KillCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1797990", Offset = "0x1797990", VA = "0x1797990")]
		public int KillCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x179920C", Offset = "0x179920C", VA = "0x179920C")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x17998C4", Offset = "0x17998C4", VA = "0x17998C4")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1799950", Offset = "0x1799950", VA = "0x1799950")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1789B44", Offset = "0x1789B44", VA = "0x1789B44")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1799994", Offset = "0x1799994", VA = "0x1799994")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1799A80", Offset = "0x1799A80", VA = "0x1799A80")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1799B64", Offset = "0x1799B64", VA = "0x1799B64")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1786DF0", Offset = "0x1786DF0", VA = "0x1786DF0")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x179B81C", Offset = "0x179B81C", VA = "0x179B81C")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x179CEE4", Offset = "0x179CEE4", VA = "0x179CEE4")]
		public static int PauseCoroutines(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x179D0D8", Offset = "0x179D0D8", VA = "0x179D0D8")]
		public static int PauseCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x179D1D0", Offset = "0x179D1D0", VA = "0x179D1D0")]
		public int PauseCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x179D63C", Offset = "0x179D63C", VA = "0x179D63C")]
		public static int PauseCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x179D284", Offset = "0x179D284", VA = "0x179D284")]
		public int PauseCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x179D734", Offset = "0x179D734", VA = "0x179D734")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x179D82C", Offset = "0x179D82C", VA = "0x179D82C")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x179DBE8", Offset = "0x179DBE8", VA = "0x179DBE8")]
		public static int PauseCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x179E1B0", Offset = "0x179E1B0", VA = "0x179E1B0")]
		public int PauseCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x179E26C", Offset = "0x179E26C", VA = "0x179E26C")]
		public static int PauseCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x179DD04", Offset = "0x179DD04", VA = "0x179DD04")]
		public int PauseCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x179E36C", Offset = "0x179E36C", VA = "0x179E36C")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x179E450", Offset = "0x179E450", VA = "0x179E450")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1786F18", Offset = "0x1786F18", VA = "0x1786F18")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x179F064", Offset = "0x179F064", VA = "0x179F064")]
		public static int ResumeCoroutines(IEnumerable<CoroutineHandle> handles)
		{
			return default(int);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x179ED98", Offset = "0x179ED98", VA = "0x179ED98")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x179F250", Offset = "0x179F250", VA = "0x179F250")]
		public static int ResumeCoroutines(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x179F718", Offset = "0x179F718", VA = "0x179F718")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj)
		{
			return default(int);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x179F7CC", Offset = "0x179F7CC", VA = "0x179F7CC")]
		public static int ResumeCoroutines(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x179F364", Offset = "0x179F364", VA = "0x179F364")]
		public int ResumeCoroutinesOnInstance(int layer)
		{
			return default(int);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x179F8C4", Offset = "0x179F8C4", VA = "0x179F8C4")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x179F9BC", Offset = "0x179F9BC", VA = "0x179F9BC")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x179FD74", Offset = "0x179FD74", VA = "0x179FD74")]
		public static int ResumeCoroutines(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x17A0320", Offset = "0x17A0320", VA = "0x17A0320")]
		public int ResumeCoroutinesOnInstance(GameObject gameObj, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x17A03DC", Offset = "0x17A03DC", VA = "0x17A03DC")]
		public static int ResumeCoroutines(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x179FE90", Offset = "0x179FE90", VA = "0x179FE90")]
		public int ResumeCoroutinesOnInstance(int layer, string tag)
		{
			return default(int);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1785930", Offset = "0x1785930", VA = "0x1785930")]
		public static string GetTag(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1785A80", Offset = "0x1785A80", VA = "0x1785A80")]
		public static int? GetLayer(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1785BEC", Offset = "0x1785BEC", VA = "0x1785BEC")]
		public static string GetDebugName(CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1786444", Offset = "0x1786444", VA = "0x1786444")]
		public static Segment GetSegment(CoroutineHandle handle)
		{
			return default(Segment);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1785E40", Offset = "0x1785E40", VA = "0x1785E40")]
		public static bool SetTag(CoroutineHandle handle, string newTag, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1786250", Offset = "0x1786250", VA = "0x1786250")]
		public static bool SetLayer(CoroutineHandle handle, int newLayer, bool overwriteExisting = true)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x17865D8", Offset = "0x17865D8", VA = "0x17865D8")]
		public static bool SetSegment(CoroutineHandle handle, Segment newSegment)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x17A0BF0", Offset = "0x17A0BF0", VA = "0x17A0BF0")]
		public static bool RemoveTag(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1786114", Offset = "0x1786114", VA = "0x1786114")]
		public static bool RemoveLayer(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x17868AC", Offset = "0x17868AC", VA = "0x17868AC")]
		public static bool IsRunning(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1786BF4", Offset = "0x1786BF4", VA = "0x1786BF4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x871D00", Offset = "0x871D00")]
		public static bool IsPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x17870A8", Offset = "0x17870A8", VA = "0x17870A8")]
		public static bool IsAliveAndPaused(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1798A48", Offset = "0x1798A48", VA = "0x1798A48")]
		private void AddTagOnInstance(string tag, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1798BB8", Offset = "0x1798BB8", VA = "0x1798BB8")]
		private void AddLayerOnInstance(int layer, CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x17A05A4", Offset = "0x17A05A4", VA = "0x17A05A4")]
		private void RemoveTagOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17A0768", Offset = "0x17A0768", VA = "0x17A0768")]
		private void RemoveLayerOnInstance(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x178E0F8", Offset = "0x178E0F8", VA = "0x178E0F8")]
		private void RemoveGraffiti(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x17A092C", Offset = "0x17A092C", VA = "0x17A092C")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x178DDFC", Offset = "0x178DDFC", VA = "0x178DDFC")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x17A04DC", Offset = "0x17A04DC", VA = "0x17A04DC")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x17992C0", Offset = "0x17992C0", VA = "0x17992C0")]
		private bool Nullify(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1799490", Offset = "0x1799490", VA = "0x1799490")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x179BAEC", Offset = "0x179BAEC", VA = "0x179BAEC")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x17A0D30", Offset = "0x17A0D30", VA = "0x17A0D30")]
		private bool SetHeld(ProcessIndex coindex, bool newHeldState)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x17A2128", Offset = "0x17A2128", VA = "0x17A2128")]
		private IEnumerator<float> CreateHold(ProcessIndex coindex, IEnumerator<float> coptr)
		{
			return null;
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x17A0C5C", Offset = "0x17A0C5C", VA = "0x17A0C5C")]
		private bool CoindexIsPaused(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17A32CC", Offset = "0x17A32CC", VA = "0x17A32CC")]
		private bool CoindexIsHeld(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x17A33A0", Offset = "0x17A33A0", VA = "0x17A33A0")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17A3494", Offset = "0x17A3494", VA = "0x17A3494")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17A385C", Offset = "0x17A385C", VA = "0x17A385C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x17A38DC", Offset = "0x17A38DC", VA = "0x17A38DC")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x17A395C", Offset = "0x17A395C", VA = "0x17A395C")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x17A39E4", Offset = "0x17A39E4", VA = "0x17A39E4")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x17A3A64", Offset = "0x17A3A64", VA = "0x17A3A64")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17A3AEC", Offset = "0x17A3AEC", VA = "0x17A3AEC")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer)
		{
			return default(float);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x17A3B74", Offset = "0x17A3B74", VA = "0x17A3B74")]
		public static float WaitUntilDone(IEnumerator<float> newCoroutine, Segment segment, int layer, string tag)
		{
			return default(float);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17A3C0C", Offset = "0x17A3C0C", VA = "0x17A3C0C")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17A3504", Offset = "0x17A3504", VA = "0x17A3504")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1793888", Offset = "0x1793888", VA = "0x1793888")]
		public static void WaitForOtherHandles(CoroutineHandle handle, CoroutineHandle otherHandle, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1794184", Offset = "0x1794184", VA = "0x1794184")]
		public static void WaitForOtherHandles(CoroutineHandle handle, IEnumerable<CoroutineHandle> otherHandles, bool warnOnIssue = true)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x17A3D24", Offset = "0x17A3D24", VA = "0x17A3D24")]
		private void SwapToLast(CoroutineHandle firstHandle, CoroutineHandle lastHandle)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x17A3C74", Offset = "0x17A3C74", VA = "0x17A3C74")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871D3C", Offset = "0x871D3C")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x178DED0", Offset = "0x178DED0", VA = "0x178DED0")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17A3F4C", Offset = "0x17A3F4C", VA = "0x17A3F4C")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x17A4064", Offset = "0x17A4064", VA = "0x17A4064")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x17A40D8", Offset = "0x17A40D8", VA = "0x17A40D8")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x17A426C", Offset = "0x17A426C", VA = "0x17A426C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871DA0", Offset = "0x871DA0")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x17A4304", Offset = "0x17A4304", VA = "0x17A4304")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17A449C", Offset = "0x17A449C", VA = "0x17A449C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871E04", Offset = "0x871E04")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x17A4534", Offset = "0x17A4534", VA = "0x17A4534")]
		public static float WaitUntilTrue(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17A4604", Offset = "0x17A4604", VA = "0x17A4604")]
		private static IEnumerator<float> WaitUntilTrueHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17A4754", Offset = "0x17A4754", VA = "0x17A4754")]
		public static float WaitUntilFalse(Func<bool> evaluatorFunc)
		{
			return default(float);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17A4824", Offset = "0x17A4824", VA = "0x17A4824")]
		private static IEnumerator<float> WaitUntilFalseHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17A469C", Offset = "0x17A469C", VA = "0x17A469C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871E68", Offset = "0x871E68")]
		private static IEnumerator<float> _StartWhenDone(Func<bool> evaluatorFunc, bool continueOn, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x179B764", Offset = "0x179B764", VA = "0x179B764")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871ECC", Offset = "0x871ECC")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float waitTime)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17A48BC", Offset = "0x17A48BC", VA = "0x17A48BC")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x17A4A8C", Offset = "0x17A4A8C", VA = "0x17A4A8C")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17A4C14", Offset = "0x17A4C14", VA = "0x17A4C14")]
		public static int LinkCoroutines(CoroutineHandle master, CoroutineHandle slave)
		{
			return default(int);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17A4EB8", Offset = "0x17A4EB8", VA = "0x17A4EB8")]
		public static int UnlinkCoroutines(CoroutineHandle master, CoroutineHandle slave, bool twoWay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x17A52E8", Offset = "0x17A52E8", VA = "0x17A52E8")]
		public static float GetMyHandle(Action<CoroutineHandle> reciever)
		{
			return default(float);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17A539C", Offset = "0x17A539C", VA = "0x17A539C")]
		private static IEnumerator<float> GetHandleHelper(IEnumerator<float> input, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17A545C", Offset = "0x17A545C", VA = "0x17A545C")]
		public static float SwitchCoroutine(Segment newSegment)
		{
			return default(float);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x17A5510", Offset = "0x17A5510", VA = "0x17A5510")]
		private static IEnumerator<float> SwitchCoroutineRepS(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x17A56B0", Offset = "0x17A56B0", VA = "0x17A56B0")]
		public static float SwitchCoroutine(Segment newSegment, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x17A5778", Offset = "0x17A5778", VA = "0x17A5778")]
		private static IEnumerator<float> SwitchCoroutineRepST(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x17A5900", Offset = "0x17A5900", VA = "0x17A5900")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x17A59C8", Offset = "0x17A59C8", VA = "0x17A59C8")]
		private static IEnumerator<float> SwitchCoroutineRepSL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17A5B10", Offset = "0x17A5B10", VA = "0x17A5B10")]
		public static float SwitchCoroutine(Segment newSegment, int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x17A5BE4", Offset = "0x17A5BE4", VA = "0x17A5BE4")]
		private static IEnumerator<float> SwitchCoroutineRepSLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x17A5CEC", Offset = "0x17A5CEC", VA = "0x17A5CEC")]
		public static float SwitchCoroutine(string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17A5DA0", Offset = "0x17A5DA0", VA = "0x17A5DA0")]
		private static IEnumerator<float> SwitchCoroutineRepT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17A5F10", Offset = "0x17A5F10", VA = "0x17A5F10")]
		public static float SwitchCoroutine(int newLayer)
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17A5FC4", Offset = "0x17A5FC4", VA = "0x17A5FC4")]
		private static IEnumerator<float> SwitchCoroutineRepL(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17A6070", Offset = "0x17A6070", VA = "0x17A6070")]
		public static float SwitchCoroutine(int newLayer, string newTag)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17A6138", Offset = "0x17A6138", VA = "0x17A6138")]
		private static IEnumerator<float> SwitchCoroutineRepLT(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17A62F8", Offset = "0x17A62F8", VA = "0x17A62F8")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17A646C", Offset = "0x17A646C", VA = "0x17A646C")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17A64B0", Offset = "0x17A64B0", VA = "0x17A64B0")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17A6564", Offset = "0x17A6564", VA = "0x17A6564")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject gameObject)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17A639C", Offset = "0x17A639C", VA = "0x17A639C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871F30", Offset = "0x871F30")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17A65B0", Offset = "0x17A65B0", VA = "0x17A65B0")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17A6878", Offset = "0x17A6878", VA = "0x17A6878")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17A6910", Offset = "0x17A6910", VA = "0x17A6910")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17A6A34", Offset = "0x17A6A34", VA = "0x17A6A34")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17A6B3C", Offset = "0x17A6B3C", VA = "0x17A6B3C")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17A6C54", Offset = "0x17A6C54", VA = "0x17A6C54")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x17A6D5C", Offset = "0x17A6D5C", VA = "0x17A6D5C")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17A6E94", Offset = "0x17A6E94", VA = "0x17A6E94")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17A6FA8", Offset = "0x17A6FA8", VA = "0x17A6FA8")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17A70BC", Offset = "0x17A70BC", VA = "0x17A70BC")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17A71AC", Offset = "0x17A71AC", VA = "0x17A71AC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17A72CC", Offset = "0x17A72CC", VA = "0x17A72CC")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17A73D0", Offset = "0x17A73D0", VA = "0x17A73D0")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17A74F0", Offset = "0x17A74F0", VA = "0x17A74F0")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17A75F4", Offset = "0x17A75F4", VA = "0x17A75F4")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17A7728", Offset = "0x17A7728", VA = "0x17A7728")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, GameObject gameObject, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17A678C", Offset = "0x17A678C", VA = "0x17A678C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871F94", Offset = "0x871F94")]
		private IEnumerator<float> _WatchCall(float timeframe, CoroutineHandle handle, GameObject gObject, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17A66BC", Offset = "0x17A66BC", VA = "0x17A66BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x871FF8", Offset = "0x871FF8")]
		private IEnumerator<float> _CallContinuously(float period, Action action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000111")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000112")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000113")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000114")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000115")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000116")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000117")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000118")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000119")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011A")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011B")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011C")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011D")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011E")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600011F")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, GameObject gameObject, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000120")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87205C", Offset = "0x87205C")]
		private IEnumerator<float> _WatchCall<T>(T reference, float timeframe, CoroutineHandle handle, GameObject gObject, Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x6000121")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8720C0", Offset = "0x8720C0")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float period, Action<T> action, GameObject gObject)
		{
			return null;
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x17A7838", Offset = "0x17A7838", VA = "0x17A7838")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872124", Offset = "0x872124")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x17A7840", Offset = "0x17A7840", VA = "0x17A7840")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872160", Offset = "0x872160")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x17A7848", Offset = "0x17A7848", VA = "0x17A7848")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87219C", Offset = "0x87219C")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x17A7850", Offset = "0x17A7850", VA = "0x17A7850")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8721D8", Offset = "0x8721D8")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x17A7858", Offset = "0x17A7858", VA = "0x17A7858")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872214", Offset = "0x872214")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x17A785C", Offset = "0x17A785C", VA = "0x17A785C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872250", Offset = "0x872250")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x17A7860", Offset = "0x17A7860", VA = "0x17A7860")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87228C", Offset = "0x87228C")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x17A7864", Offset = "0x17A7864", VA = "0x17A7864")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8722C8", Offset = "0x8722C8")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x17A7868", Offset = "0x17A7868", VA = "0x17A7868")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872304", Offset = "0x872304")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17A786C", Offset = "0x17A786C", VA = "0x17A786C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872340", Offset = "0x872340")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17A7870", Offset = "0x17A7870", VA = "0x17A7870")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87237C", Offset = "0x87237C")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17A7874", Offset = "0x17A7874", VA = "0x17A7874")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8723B8", Offset = "0x8723B8")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17A7878", Offset = "0x17A7878", VA = "0x17A7878")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8723F4", Offset = "0x8723F4")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17A787C", Offset = "0x17A787C", VA = "0x17A787C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872430", Offset = "0x872430")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17A7880", Offset = "0x17A7880", VA = "0x17A7880")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87246C", Offset = "0x87246C")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x17A7884", Offset = "0x17A7884", VA = "0x17A7884")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8724A8", Offset = "0x8724A8")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000132")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8724E4", Offset = "0x8724E4")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x6000133")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872520", Offset = "0x872520")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x17A7888", Offset = "0x17A7888", VA = "0x17A7888")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x87255C", Offset = "0x87255C")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000135")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872598", Offset = "0x872598")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x17A7890", Offset = "0x17A7890", VA = "0x17A7890")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x8725D4", Offset = "0x8725D4")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x17A7898", Offset = "0x17A7898", VA = "0x17A7898")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x872610", Offset = "0x872610")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x17A789C", Offset = "0x17A789C", VA = "0x17A789C")]
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
		Wait
	}
	[Token(Token = "0x2000009")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x4000084")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x1700000D")]
		public byte Key
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x92BE48", Offset = "0x92BE48", VA = "0x92BE48")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700000E")]
		public string Tag
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x92BE84", Offset = "0x92BE84", VA = "0x92BE84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x92BE8C", Offset = "0x92BE8C", VA = "0x92BE8C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int? Layer
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x92BE94", Offset = "0x92BE94", VA = "0x92BE94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x92BE9C", Offset = "0x92BE9C", VA = "0x92BE9C")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Segment Segment
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x92BEA4", Offset = "0x92BEA4", VA = "0x92BEA4")]
			get
			{
				return default(Segment);
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x92BEAC", Offset = "0x92BEAC", VA = "0x92BEAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsRunning
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x92BEB4", Offset = "0x92BEB4", VA = "0x92BEB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x92BEBC", Offset = "0x92BEBC", VA = "0x92BEBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x875760", Offset = "0x875760")]
		public bool IsPaused
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x92BEC8", Offset = "0x92BEC8", VA = "0x92BEC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x92BED0", Offset = "0x92BED0", VA = "0x92BED0")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsAliveAndPaused
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x92BEDC", Offset = "0x92BEDC", VA = "0x92BEDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x92BEE4", Offset = "0x92BEE4", VA = "0x92BEE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool IsValid
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x92BEF0", Offset = "0x92BEF0", VA = "0x92BEF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x92BE54", Offset = "0x92BE54", VA = "0x92BE54")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x92BE5C", Offset = "0x92BE5C", VA = "0x92BE5C", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x92BE6C", Offset = "0x92BE6C", VA = "0x92BE6C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x178551C", Offset = "0x178551C", VA = "0x178551C")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1785528", Offset = "0x1785528", VA = "0x1785528")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x92BE74", Offset = "0x92BE74", VA = "0x92BE74", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x92BE7C", Offset = "0x92BE7C", VA = "0x92BE7C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x200000A")]
	public enum Axis
	{
		[Token(Token = "0x4000088")]
		X,
		[Token(Token = "0x4000089")]
		Y,
		[Token(Token = "0x400008A")]
		Z
	}
	[Token(Token = "0x200000B")]
	public class AxisTools
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1337C9C", Offset = "0x1337C9C", VA = "0x1337C9C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1337D5C", Offset = "0x1337D5C", VA = "0x1337D5C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1337E08", Offset = "0x1337E08", VA = "0x1337E08")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1337FF0", Offset = "0x1337FF0", VA = "0x1337FF0")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1337F24", Offset = "0x1337F24", VA = "0x1337F24")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x133810C", Offset = "0x133810C", VA = "0x133810C")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1338354", Offset = "0x1338354", VA = "0x1338354")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000C")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200009E")]
		public class LimbOrientation
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x133861C", Offset = "0x133861C", VA = "0x133861C")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000015")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x13383A8", Offset = "0x13383A8", VA = "0x13383A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1338698", Offset = "0x1338698", VA = "0x1338698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x133835C", Offset = "0x133835C", VA = "0x133835C")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200000D")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public enum BoneType
		{
			[Token(Token = "0x4000491")]
			Unassigned,
			[Token(Token = "0x4000492")]
			Spine,
			[Token(Token = "0x4000493")]
			Head,
			[Token(Token = "0x4000494")]
			Arm,
			[Token(Token = "0x4000495")]
			Leg,
			[Token(Token = "0x4000496")]
			Tail,
			[Token(Token = "0x4000497")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public enum BoneSide
		{
			[Token(Token = "0x4000499")]
			Center,
			[Token(Token = "0x400049A")]
			Left,
			[Token(Token = "0x400049B")]
			Right
		}

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x133890C", Offset = "0x133890C", VA = "0x133890C")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1338C50", Offset = "0x1338C50", VA = "0x1338C50")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1338EE4", Offset = "0x1338EE4", VA = "0x1338EE4")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1338F68", Offset = "0x1338F68", VA = "0x1338F68")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x133901C", Offset = "0x133901C", VA = "0x133901C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1338B00", Offset = "0x1338B00", VA = "0x1338B00")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1338E44", Offset = "0x1338E44", VA = "0x1338E44")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1339870", Offset = "0x1339870", VA = "0x1339870")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1339688", Offset = "0x1339688", VA = "0x1339688")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x133977C", Offset = "0x133977C", VA = "0x133977C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1339250", Offset = "0x1339250", VA = "0x1339250")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1339304", Offset = "0x1339304", VA = "0x1339304")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x13393B8", Offset = "0x13393B8", VA = "0x13393B8")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x133946C", Offset = "0x133946C", VA = "0x133946C")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1339520", Offset = "0x1339520", VA = "0x1339520")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x13395D4", Offset = "0x13395D4", VA = "0x13395D4")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1339AEC", Offset = "0x1339AEC", VA = "0x1339AEC")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x133915C", Offset = "0x133915C", VA = "0x133915C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1339A54", Offset = "0x1339A54", VA = "0x1339A54")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1339B5C", Offset = "0x1339B5C", VA = "0x1339B5C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1339C30", Offset = "0x1339C30", VA = "0x1339C30")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x13399C0", Offset = "0x13399C0", VA = "0x13399C0")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1339900", Offset = "0x1339900", VA = "0x1339900")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200000E")]
	public class BipedReferences
	{
		[Token(Token = "0x20000A1")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000C9")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600070B")]
				[Address(RVA = "0x1340728", Offset = "0x1340728", VA = "0x1340728")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x9243E4", Offset = "0x9243E4", VA = "0x9243E4")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000017")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x133C714", Offset = "0x133C714", VA = "0x133C714", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		public bool isEmpty
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x133CB18", Offset = "0x133CB18", VA = "0x133CB18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x133CB28", Offset = "0x133CB28", VA = "0x133CB28", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x133CF6C", Offset = "0x133CF6C", VA = "0x133CF6C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x133D3B4", Offset = "0x133D3B4", VA = "0x133D3B4")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x133DBFC", Offset = "0x133DBFC", VA = "0x133DBFC")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x133D638", Offset = "0x133D638", VA = "0x133D638")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x133E6E0", Offset = "0x133E6E0", VA = "0x133E6E0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x133E7D8", Offset = "0x133E7D8", VA = "0x133E7D8")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x133EE08", Offset = "0x133EE08", VA = "0x133EE08")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x133EBD8", Offset = "0x133EBD8", VA = "0x133EBD8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x133EA20", Offset = "0x133EA20", VA = "0x133EA20")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x133E8B0", Offset = "0x133E8B0", VA = "0x133E8B0")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x133ECF0", Offset = "0x133ECF0", VA = "0x133ECF0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x133EF14", Offset = "0x133EF14", VA = "0x133EF14")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x133FDB8", Offset = "0x133FDB8", VA = "0x133FDB8")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x133F6A4", Offset = "0x133F6A4", VA = "0x133F6A4")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1340170", Offset = "0x1340170", VA = "0x1340170")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x133FB64", Offset = "0x133FB64", VA = "0x133FB64")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1340178", Offset = "0x1340178", VA = "0x1340178")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1340180", Offset = "0x1340180", VA = "0x1340180")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x134038C", Offset = "0x134038C", VA = "0x134038C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x13405F0", Offset = "0x13405F0", VA = "0x13405F0")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x133D5C8", Offset = "0x133D5C8", VA = "0x133D5C8")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1340730", Offset = "0x1340730", VA = "0x1340730")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1340738", Offset = "0x1340738", VA = "0x1340738")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x13407F8", Offset = "0x13407F8", VA = "0x13407F8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class Hierarchy
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1CC5BA4", Offset = "0x1CC5BA4", VA = "0x1CC5BA4")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1CC5DD8", Offset = "0x1CC5DD8", VA = "0x1CC5DD8")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1CC5C54", Offset = "0x1CC5C54", VA = "0x1CC5C54")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1CC5F24", Offset = "0x1CC5F24", VA = "0x1CC5F24")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1CC604C", Offset = "0x1CC604C", VA = "0x1CC604C")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1CC639C", Offset = "0x1CC639C", VA = "0x1CC639C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1CC64E0", Offset = "0x1CC64E0", VA = "0x1CC64E0")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1CC668C", Offset = "0x1CC668C", VA = "0x1CC668C")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1CC6A74", Offset = "0x1CC6A74", VA = "0x1CC6A74")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1CC6840", Offset = "0x1CC6840", VA = "0x1CC6840")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1CC6C24", Offset = "0x1CC6C24", VA = "0x1CC6C24")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1CC6C2C", Offset = "0x1CC6C2C", VA = "0x1CC6C2C")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1CC6C9C", Offset = "0x1CC6C9C", VA = "0x1CC6C9C")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000013")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40000B8")]
		None,
		[Token(Token = "0x40000B9")]
		InOutCubic,
		[Token(Token = "0x40000BA")]
		InOutQuintic,
		[Token(Token = "0x40000BB")]
		InOutSine,
		[Token(Token = "0x40000BC")]
		InQuintic,
		[Token(Token = "0x40000BD")]
		InQuartic,
		[Token(Token = "0x40000BE")]
		InCubic,
		[Token(Token = "0x40000BF")]
		InQuadratic,
		[Token(Token = "0x40000C0")]
		InElastic,
		[Token(Token = "0x40000C1")]
		InElasticSmall,
		[Token(Token = "0x40000C2")]
		InElasticBig,
		[Token(Token = "0x40000C3")]
		InSine,
		[Token(Token = "0x40000C4")]
		InBack,
		[Token(Token = "0x40000C5")]
		OutQuintic,
		[Token(Token = "0x40000C6")]
		OutQuartic,
		[Token(Token = "0x40000C7")]
		OutCubic,
		[Token(Token = "0x40000C8")]
		OutInCubic,
		[Token(Token = "0x40000C9")]
		OutInQuartic,
		[Token(Token = "0x40000CA")]
		OutElastic,
		[Token(Token = "0x40000CB")]
		OutElasticSmall,
		[Token(Token = "0x40000CC")]
		OutElasticBig,
		[Token(Token = "0x40000CD")]
		OutSine,
		[Token(Token = "0x40000CE")]
		OutBack,
		[Token(Token = "0x40000CF")]
		OutBackCubic,
		[Token(Token = "0x40000D0")]
		OutBackQuartic,
		[Token(Token = "0x40000D1")]
		BackInCubic,
		[Token(Token = "0x40000D2")]
		BackInQuartic
	}
	[Token(Token = "0x2000014")]
	public class Interp
	{
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1CC6D0C", Offset = "0x1CC6D0C", VA = "0x1CC6D0C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1CC777C", Offset = "0x1CC777C", VA = "0x1CC777C")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1CC7884", Offset = "0x1CC7884", VA = "0x1CC7884")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1CC707C", Offset = "0x1CC707C", VA = "0x1CC707C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1CC7088", Offset = "0x1CC7088", VA = "0x1CC7088")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1CC70B0", Offset = "0x1CC70B0", VA = "0x1CC70B0")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1CC70EC", Offset = "0x1CC70EC", VA = "0x1CC70EC")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1CC7104", Offset = "0x1CC7104", VA = "0x1CC7104")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1CC7118", Offset = "0x1CC7118", VA = "0x1CC7118")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1CC712C", Offset = "0x1CC712C", VA = "0x1CC712C")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1CC713C", Offset = "0x1CC713C", VA = "0x1CC713C")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1CC7184", Offset = "0x1CC7184", VA = "0x1CC7184")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1CC71BC", Offset = "0x1CC71BC", VA = "0x1CC71BC")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1CC71E4", Offset = "0x1CC71E4", VA = "0x1CC71E4")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1CC7980", Offset = "0x1CC7980", VA = "0x1CC7980")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1CC7218", Offset = "0x1CC7218", VA = "0x1CC7218")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1CC7240", Offset = "0x1CC7240", VA = "0x1CC7240")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1CC7270", Offset = "0x1CC7270", VA = "0x1CC7270")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1CC72A4", Offset = "0x1CC72A4", VA = "0x1CC72A4")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1CC72E8", Offset = "0x1CC72E8", VA = "0x1CC72E8")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1CC734C", Offset = "0x1CC734C", VA = "0x1CC734C")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1CC73B0", Offset = "0x1CC73B0", VA = "0x1CC73B0")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1CC7404", Offset = "0x1CC7404", VA = "0x1CC7404")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1CC7458", Offset = "0x1CC7458", VA = "0x1CC7458")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1CC74F0", Offset = "0x1CC74F0", VA = "0x1CC74F0")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1CC7584", Offset = "0x1CC7584", VA = "0x1CC7584")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1CC79B4", Offset = "0x1CC79B4", VA = "0x1CC79B4")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1CC7628", Offset = "0x1CC7628", VA = "0x1CC7628")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1CC770C", Offset = "0x1CC770C", VA = "0x1CC770C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1CC773C", Offset = "0x1CC773C", VA = "0x1CC773C")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1CC7A9C", Offset = "0x1CC7A9C", VA = "0x1CC7A9C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1CC7AA4", Offset = "0x1CC7AA4", VA = "0x1CC7AA4")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1CC7B14", Offset = "0x1CC7B14", VA = "0x1CC7B14")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000016")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1CC7B84", Offset = "0x1CC7B84", VA = "0x1CC7B84")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1CC7BE0", Offset = "0x1CC7BE0", VA = "0x1CC7BE0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1CC7CB8", Offset = "0x1CC7CB8", VA = "0x1CC7CB8")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1CC7BF8", Offset = "0x1CC7BF8", VA = "0x1CC7BF8")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1CC7CD0", Offset = "0x1CC7CD0", VA = "0x1CC7CD0")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1CC7D80", Offset = "0x1CC7D80", VA = "0x1CC7D80")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1CC7DAC", Offset = "0x1CC7DAC", VA = "0x1CC7DAC")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1CC7DFC", Offset = "0x1CC7DFC", VA = "0x1CC7DFC")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1CC7E68", Offset = "0x1CC7E68", VA = "0x1CC7E68")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1CC7F68", Offset = "0x1CC7F68", VA = "0x1CC7F68")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1CC804C", Offset = "0x1CC804C", VA = "0x1CC804C")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1CC80AC", Offset = "0x1CC80AC", VA = "0x1CC80AC")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public static class QuaTools
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1CC80DC", Offset = "0x1CC80DC", VA = "0x1CC80DC")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1CC8228", Offset = "0x1CC8228", VA = "0x1CC8228")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1CC8374", Offset = "0x1CC8374", VA = "0x1CC8374")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1CC8488", Offset = "0x1CC8488", VA = "0x1CC8488")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1CC859C", Offset = "0x1CC859C", VA = "0x1CC859C")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1CC8728", Offset = "0x1CC8728", VA = "0x1CC8728")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1CB8944", Offset = "0x1CB8944", VA = "0x1CB8944")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1CC87F8", Offset = "0x1CC87F8", VA = "0x1CC87F8")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1CC8A7C", Offset = "0x1CC8A7C", VA = "0x1CC8A7C")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1CC8C90", Offset = "0x1CC8C90", VA = "0x1CC8C90")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1CC307C", Offset = "0x1CC307C", VA = "0x1CC307C")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000018")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000019")]
		public static T instance
		{
			[Token(Token = "0x60001D2")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D3")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001D4")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AAF8", Offset = "0x86AAF8")]
		public bool fixTransforms;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700001A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1CC8F48", Offset = "0x1CC8F48", VA = "0x1CC8F48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		private bool isAnimated
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x1CC929C", Offset = "0x1CC929C", VA = "0x1CC929C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1CC8E10", Offset = "0x1CC8E10", VA = "0x1CC8E10")]
		public void Disable()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1CC8EA8", Offset = "0x1CC8EA8", VA = "0x1CC8EA8", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1CC8EAC", Offset = "0x1CC8EAC", VA = "0x1CC8EAC", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1CC8EB0", Offset = "0x1CC8EB0", VA = "0x1CC8EB0", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1CC8EB4", Offset = "0x1CC8EB4", VA = "0x1CC8EB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1CC8F44", Offset = "0x1CC8F44", VA = "0x1CC8F44")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1CC8EEC", Offset = "0x1CC8EEC", VA = "0x1CC8EEC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1CC924C", Offset = "0x1CC924C", VA = "0x1CC924C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1CC904C", Offset = "0x1CC904C", VA = "0x1CC904C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1CC9358", Offset = "0x1CC9358", VA = "0x1CC9358")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1CC93B4", Offset = "0x1CC93B4", VA = "0x1CC93B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1CC9414", Offset = "0x1CC9414", VA = "0x1CC9414")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1CB6870", Offset = "0x1CB6870", VA = "0x1CB6870")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1CC945C", Offset = "0x1CC945C", VA = "0x1CC945C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1CC951C", Offset = "0x1CC951C", VA = "0x1CC951C")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1CC95DC", Offset = "0x1CC95DC", VA = "0x1CC95DC")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1CC969C", Offset = "0x1CC969C", VA = "0x1CC969C")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class V3Tools
	{
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1CC96A4", Offset = "0x1CC96A4", VA = "0x1CC96A4")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1CC979C", Offset = "0x1CC979C", VA = "0x1CC979C")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1CC9894", Offset = "0x1CC9894", VA = "0x1CC9894")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1CC998C", Offset = "0x1CC998C", VA = "0x1CC998C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1CC9A8C", Offset = "0x1CC9A8C", VA = "0x1CC9A8C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1CC9CC8", Offset = "0x1CC9CC8", VA = "0x1CC9CC8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1CC9F18", Offset = "0x1CC9F18", VA = "0x1CC9F18")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1CCA128", Offset = "0x1CCA128", VA = "0x1CCA128")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200001C")]
	public static class Warning
	{
		[Token(Token = "0x20000A2")]
		public delegate void Logger(string message);

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1CCA304", Offset = "0x1CCA304", VA = "0x1CCA304")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1CBA858", Offset = "0x1CBA858", VA = "0x1CBA858")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Serializable]
	[Token(Token = "0x200001D")]
	public class Navigator
	{
		[Token(Token = "0x20000A3")]
		public enum State
		{
			[Token(Token = "0x400049F")]
			Idle,
			[Token(Token = "0x40004A0")]
			Seeking,
			[Token(Token = "0x40004A1")]
			OnPath
		}

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AB30", Offset = "0x86AB30")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AB68", Offset = "0x86AB68")]
		public float cornerRadius;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ABA0", Offset = "0x86ABA0")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ABD8", Offset = "0x86ABD8")]
		public float maxSampleDistance;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AC10", Offset = "0x86AC10")]
		public float nextPathInterval;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC48", Offset = "0x86AC48")]
		private Vector3 <normalizedDeltaPosition>k__BackingField;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC58", Offset = "0x86AC58")]
		private State <state>k__BackingField;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x1700001C")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x134082C", Offset = "0x134082C", VA = "0x134082C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8726BC", Offset = "0x8726BC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x1340838", Offset = "0x1340838", VA = "0x1340838")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8726CC", Offset = "0x8726CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public State state
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x1340844", Offset = "0x1340844", VA = "0x1340844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8726DC", Offset = "0x8726DC")]
			get
			{
				return default(State);
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x134084C", Offset = "0x134084C", VA = "0x134084C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8726EC", Offset = "0x8726EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1340854", Offset = "0x1340854", VA = "0x1340854")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1340928", Offset = "0x1340928", VA = "0x1340928")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1340EE4", Offset = "0x1340EE4", VA = "0x1340EE4")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1340F54", Offset = "0x1340F54", VA = "0x1340F54")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1340DAC", Offset = "0x1340DAC", VA = "0x1340DAC")]
		private void Stop()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1340E20", Offset = "0x1340E20", VA = "0x1340E20")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x13410BC", Offset = "0x13410BC", VA = "0x13410BC")]
		public void Visualize()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x134134C", Offset = "0x134134C", VA = "0x134134C")]
		public Navigator()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869AFC", Offset = "0x869AFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869AFC", Offset = "0x869AFC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x13438C8", Offset = "0x13438C8", VA = "0x13438C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8726FC", Offset = "0x8726FC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1343914", Offset = "0x1343914", VA = "0x1343914")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872734", Offset = "0x872734")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1343960", Offset = "0x1343960", VA = "0x1343960")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87276C", Offset = "0x87276C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x13439AC", Offset = "0x13439AC", VA = "0x13439AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8727A4", Offset = "0x8727A4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x13439F8", Offset = "0x13439F8", VA = "0x13439F8")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1343AC8", Offset = "0x1343AC8", VA = "0x1343AC8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1343AF8", Offset = "0x1343AF8", VA = "0x1343AF8")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1343B38", Offset = "0x1343B38", VA = "0x1343B38")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1343B78", Offset = "0x1343B78", VA = "0x1343B78")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1343BD0", Offset = "0x1343BD0", VA = "0x1343BD0")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1343C30", Offset = "0x1343C30", VA = "0x1343C30")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1343C64", Offset = "0x1343C64", VA = "0x1343C64")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1343C94", Offset = "0x1343C94", VA = "0x1343C94")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1343D2C", Offset = "0x1343D2C", VA = "0x1343D2C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1343D94", Offset = "0x1343D94", VA = "0x1343D94")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1343DFC", Offset = "0x1343DFC", VA = "0x1343DFC")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1343A28", Offset = "0x1343A28", VA = "0x1343A28")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1343E4C", Offset = "0x1343E4C", VA = "0x1343E4C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1343E58", Offset = "0x1343E58", VA = "0x1343E58")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1343E64", Offset = "0x1343E64", VA = "0x1343E64")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x13442B0", Offset = "0x13442B0", VA = "0x13442B0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x13443A8", Offset = "0x13443A8", VA = "0x13443A8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1344874", Offset = "0x1344874", VA = "0x1344874", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1344B14", Offset = "0x1344B14", VA = "0x1344B14")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1344B48", Offset = "0x1344B48", VA = "0x1344B48")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001F")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700001E")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x13440F8", Offset = "0x13440F8", VA = "0x13440F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1344D10", Offset = "0x1344D10", VA = "0x1344D10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1344630", Offset = "0x1344630", VA = "0x1344630")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1344BC8", Offset = "0x1344BC8", VA = "0x1344BC8")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public abstract class Constraint
	{
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000020")]
		public bool isValid
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x171291C", Offset = "0x171291C", VA = "0x171291C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600021D")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x171298C", Offset = "0x171298C", VA = "0x171298C")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000021")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1712994", Offset = "0x1712994", VA = "0x1712994", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1712AC8", Offset = "0x1712AC8", VA = "0x1712AC8")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1712AD0", Offset = "0x1712AD0", VA = "0x1712AD0")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		private bool positionChanged
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1712D28", Offset = "0x1712D28", VA = "0x1712D28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1712AFC", Offset = "0x1712AFC", VA = "0x1712AFC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1712DEC", Offset = "0x1712DEC", VA = "0x1712DEC")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1712DF4", Offset = "0x1712DF4", VA = "0x1712DF4")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1712E20", Offset = "0x1712E20", VA = "0x1712E20", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1712F78", Offset = "0x1712F78", VA = "0x1712F78")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1712F80", Offset = "0x1712F80", VA = "0x1712F80")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000022")]
		private bool rotationChanged
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x17131EC", Offset = "0x17131EC", VA = "0x17131EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1712FAC", Offset = "0x1712FAC", VA = "0x1712FAC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x17132C4", Offset = "0x17132C4", VA = "0x17132C4")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x17132CC", Offset = "0x17132CC", VA = "0x17132CC")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class Constraints
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AC68", Offset = "0x86AC68")]
		public float positionWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AC80", Offset = "0x86AC80")]
		public float rotationWeight;

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x17132F8", Offset = "0x17132F8", VA = "0x17132F8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1713368", Offset = "0x1713368", VA = "0x1713368")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x17133E0", Offset = "0x17133E0", VA = "0x17133E0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1713814", Offset = "0x1713814", VA = "0x1713814")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x20000A4")]
		public enum DOF
		{
			[Token(Token = "0x40004A3")]
			One,
			[Token(Token = "0x40004A4")]
			Three
		}

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AC98", Offset = "0x86AC98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AC98", Offset = "0x86AC98")]
		public float weight;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ACEC", Offset = "0x86ACEC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86ACEC", Offset = "0x86ACEC")]
		public float rotationWeight;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AD40", Offset = "0x86AD40")]
		public DOF rotationDOF;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AD78", Offset = "0x86AD78")]
		public Transform bone1;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ADB0", Offset = "0x86ADB0")]
		public Transform bone2;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ADE8", Offset = "0x86ADE8")]
		public Transform bone3;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AE20", Offset = "0x86AE20")]
		public Transform tip;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AE58", Offset = "0x86AE58")]
		public Transform target;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AE90", Offset = "0x86AE90")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x171E71C", Offset = "0x171E71C", VA = "0x171E71C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8727DC", Offset = "0x8727DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x171E724", Offset = "0x171E724", VA = "0x171E724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8727EC", Offset = "0x8727EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x171E730", Offset = "0x171E730", VA = "0x171E730")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x171E760", Offset = "0x171E760", VA = "0x171E760")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x171E7AC", Offset = "0x171E7AC", VA = "0x171E7AC")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x171E7DC", Offset = "0x171E7DC", VA = "0x171E7DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x171E82C", Offset = "0x171E82C", VA = "0x171E82C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x171E92C", Offset = "0x171E92C", VA = "0x171E92C")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x171EE38", Offset = "0x171EE38", VA = "0x171EE38")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x171EF68", Offset = "0x171EF68", VA = "0x171EF68")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x171F050", Offset = "0x171F050", VA = "0x171F050")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x171F548", Offset = "0x171F548", VA = "0x171F548")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AEA0", Offset = "0x86AEA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AEA0", Offset = "0x86AEA0")]
		public float weight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AEF4", Offset = "0x86AEF4")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000026")]
		public bool initiated
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x171F558", Offset = "0x171F558", VA = "0x171F558")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8727FC", Offset = "0x8727FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x171F560", Offset = "0x171F560", VA = "0x171F560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87280C", Offset = "0x87280C")]
			private set
			{
			}
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x171F56C", Offset = "0x171F56C", VA = "0x171F56C")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x171F600", Offset = "0x171F600", VA = "0x171F600")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87281C", Offset = "0x87281C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x171FA4C", Offset = "0x171FA4C", VA = "0x171FA4C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x171FC60", Offset = "0x171FC60", VA = "0x171FC60")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x171F900", Offset = "0x171F900", VA = "0x171F900")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x171FE58", Offset = "0x171FE58", VA = "0x171FE58", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x171FF60", Offset = "0x171FF60", VA = "0x171FF60")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x171FFF4", Offset = "0x171FFF4", VA = "0x171FFF4")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1720080", Offset = "0x1720080", VA = "0x1720080")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1720100", Offset = "0x1720100", VA = "0x1720100", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1720104", Offset = "0x1720104", VA = "0x1720104", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1720118", Offset = "0x1720118", VA = "0x1720118")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AF04", Offset = "0x86AF04")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AF04", Offset = "0x86AF04")]
		public float weight;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AF58", Offset = "0x86AF58")]
		public Grounding solver;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AF90", Offset = "0x86AF90")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000027")]
		public bool initiated
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x17214D0", Offset = "0x17214D0", VA = "0x17214D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872854", Offset = "0x872854")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x17214D8", Offset = "0x17214D8", VA = "0x17214D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872864", Offset = "0x872864")]
			protected set
			{
			}
		}

		[Token(Token = "0x600024B")]
		public abstract void ResetPosition();

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x17214E4", Offset = "0x17214E4", VA = "0x17214E4")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1721834", Offset = "0x1721834", VA = "0x1721834")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x172166C", Offset = "0x172166C", VA = "0x172166C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x1721868", Offset = "0x1721868", VA = "0x1721868")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000253")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x1721AE8", Offset = "0x1721AE8", VA = "0x1721AE8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869B5C", Offset = "0x869B5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869B5C", Offset = "0x869B5C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AFA0", Offset = "0x86AFA0")]
		public BipedIK ik;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86AFD8", Offset = "0x86AFD8")]
		public float spineBend;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B010", Offset = "0x86B010")]
		public float spineSpeed;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1722054", Offset = "0x1722054", VA = "0x1722054", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872874", Offset = "0x872874")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x17220A0", Offset = "0x17220A0", VA = "0x17220A0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8728AC", Offset = "0x8728AC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x17220EC", Offset = "0x17220EC", VA = "0x17220EC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x172221C", Offset = "0x172221C", VA = "0x172221C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x172231C", Offset = "0x172231C", VA = "0x172231C")]
		private void Update()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x17223D0", Offset = "0x17223D0", VA = "0x17223D0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1722B64", Offset = "0x1722B64", VA = "0x1722B64")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1722BF0", Offset = "0x1722BF0", VA = "0x1722BF0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x17235E8", Offset = "0x17235E8", VA = "0x17235E8")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x17237D4", Offset = "0x17237D4", VA = "0x17237D4")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1723A44", Offset = "0x1723A44", VA = "0x1723A44")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1723C98", Offset = "0x1723C98", VA = "0x1723C98")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869BBC", Offset = "0x869BBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869BBC", Offset = "0x869BBC")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000A6")]
		public class SpineEffector
		{
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E01C", Offset = "0x86E01C")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E054", Offset = "0x86E054")]
			public float horizontalWeight;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E08C", Offset = "0x86E08C")]
			public float verticalWeight;

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1724E80", Offset = "0x1724E80", VA = "0x1724E80")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1724E90", Offset = "0x1724E90", VA = "0x1724E90")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B048", Offset = "0x86B048")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B080", Offset = "0x86B080")]
		public float spineBend;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B0B8", Offset = "0x86B0B8")]
		public float spineSpeed;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1723D18", Offset = "0x1723D18", VA = "0x1723D18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8728E4", Offset = "0x8728E4")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1723D64", Offset = "0x1723D64", VA = "0x1723D64", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87291C", Offset = "0x87291C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1723DB0", Offset = "0x1723DB0", VA = "0x1723DB0", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872954", Offset = "0x872954")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1723DFC", Offset = "0x1723DFC", VA = "0x1723DFC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1723E84", Offset = "0x1723E84", VA = "0x1723E84")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1723F34", Offset = "0x1723F34", VA = "0x1723F34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1724324", Offset = "0x1724324", VA = "0x1724324")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1724330", Offset = "0x1724330", VA = "0x1724330")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1723FF0", Offset = "0x1723FF0", VA = "0x1723FF0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x172433C", Offset = "0x172433C", VA = "0x172433C")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1724954", Offset = "0x1724954", VA = "0x1724954")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1724B60", Offset = "0x1724B60", VA = "0x1724B60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1724C98", Offset = "0x1724C98", VA = "0x1724C98")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1724E00", Offset = "0x1724E00", VA = "0x1724E00")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869C1C", Offset = "0x869C1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869C1C", Offset = "0x869C1C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B0F0", Offset = "0x86B0F0")]
		public Transform pelvis;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B128", Offset = "0x86B128")]
		public Transform characterRoot;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B160", Offset = "0x86B160")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B160", Offset = "0x86B160")]
		public float rootRotationWeight;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B1B4", Offset = "0x86B1B4")]
		public float rootRotationSpeed;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B1EC", Offset = "0x86B1EC")]
		public float maxRootRotationAngle;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1724ED8", Offset = "0x1724ED8", VA = "0x1724ED8", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87298C", Offset = "0x87298C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1724F24", Offset = "0x1724F24", VA = "0x1724F24", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8729C4", Offset = "0x8729C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1724F70", Offset = "0x1724F70", VA = "0x1724F70", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1724F9C", Offset = "0x1724F9C", VA = "0x1724F9C")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x172519C", Offset = "0x172519C", VA = "0x172519C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x17252E8", Offset = "0x17252E8", VA = "0x17252E8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1725B34", Offset = "0x1725B34", VA = "0x1725B34")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1726178", Offset = "0x1726178", VA = "0x1726178")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1726458", Offset = "0x1726458", VA = "0x1726458")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x17269A0", Offset = "0x17269A0", VA = "0x17269A0")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1726C18", Offset = "0x1726C18", VA = "0x1726C18")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1726EB0", Offset = "0x1726EB0", VA = "0x1726EB0")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869C7C", Offset = "0x869C7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869C7C", Offset = "0x869C7C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000A7")]
		public struct Foot
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x92ACE0", Offset = "0x92ACE0", VA = "0x92ACE0")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B224", Offset = "0x86B224")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B25C", Offset = "0x86B25C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B25C", Offset = "0x86B25C")]
		public float rootRotationWeight;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B2B0", Offset = "0x86B2B0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B2B0", Offset = "0x86B2B0")]
		public float minRootRotation;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B308", Offset = "0x86B308")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B308", Offset = "0x86B308")]
		public float maxRootRotation;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B360", Offset = "0x86B360")]
		public float rootRotationSpeed;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B398", Offset = "0x86B398")]
		public float maxLegOffset;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B3D0", Offset = "0x86B3D0")]
		public float maxForeLegOffset;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B408", Offset = "0x86B408")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B408", Offset = "0x86B408")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B45C", Offset = "0x86B45C")]
		public Transform characterRoot;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B494", Offset = "0x86B494")]
		public Transform pelvis;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B4CC", Offset = "0x86B4CC")]
		public Transform lastSpineBone;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B504", Offset = "0x86B504")]
		public Transform head;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1726F30", Offset = "0x1726F30", VA = "0x1726F30", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8729FC", Offset = "0x8729FC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1726F7C", Offset = "0x1726F7C", VA = "0x1726F7C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872A34", Offset = "0x872A34")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1726FC8", Offset = "0x1726FC8", VA = "0x1726FC8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1727010", Offset = "0x1727010", VA = "0x1727010")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x172714C", Offset = "0x172714C", VA = "0x172714C")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1727304", Offset = "0x1727304", VA = "0x1727304")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x17273E4", Offset = "0x17273E4", VA = "0x17273E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x172749C", Offset = "0x172749C", VA = "0x172749C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x17278A8", Offset = "0x17278A8", VA = "0x17278A8")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1727DB0", Offset = "0x1727DB0", VA = "0x1727DB0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1727EFC", Offset = "0x1727EFC", VA = "0x1727EFC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1728460", Offset = "0x1728460", VA = "0x1728460")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1728E80", Offset = "0x1728E80", VA = "0x1728E80")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x17291E4", Offset = "0x17291E4", VA = "0x17291E4")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1729378", Offset = "0x1729378", VA = "0x1729378")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1729770", Offset = "0x1729770", VA = "0x1729770")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x17297B4", Offset = "0x17297B4", VA = "0x17297B4")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1729A44", Offset = "0x1729A44", VA = "0x1729A44")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869CDC", Offset = "0x869CDC")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B54C", Offset = "0x86B54C")]
		public VRIK ik;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1729B60", Offset = "0x1729B60", VA = "0x1729B60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872A6C", Offset = "0x872A6C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1729B64", Offset = "0x1729B64", VA = "0x1729B64", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872AA4", Offset = "0x872AA4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1729B68", Offset = "0x1729B68", VA = "0x1729B68", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872ADC", Offset = "0x872ADC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1729B6C", Offset = "0x1729B6C", VA = "0x1729B6C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1729B98", Offset = "0x1729B98", VA = "0x1729B98")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1729C48", Offset = "0x1729C48", VA = "0x1729C48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1729CFC", Offset = "0x1729CFC", VA = "0x1729CFC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x172A048", Offset = "0x172A048", VA = "0x172A048")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x172A418", Offset = "0x172A418", VA = "0x172A418")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x172A554", Offset = "0x172A554", VA = "0x172A554")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x172A884", Offset = "0x172A884", VA = "0x172A884")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x172A9BC", Offset = "0x172A9BC", VA = "0x172A9BC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x172ABF0", Offset = "0x172ABF0", VA = "0x172ABF0")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000A8")]
		public enum Quality
		{
			[Token(Token = "0x40004AD")]
			Fastest,
			[Token(Token = "0x40004AE")]
			Simple,
			[Token(Token = "0x40004AF")]
			Best
		}

		[Token(Token = "0x20000A9")]
		public class Leg
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E0C4", Offset = "0x86E0C4")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E0D4", Offset = "0x86E0D4")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E0E4", Offset = "0x86E0E4")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E0F4", Offset = "0x86E0F4")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E104", Offset = "0x86E104")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E114", Offset = "0x86E114")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E124", Offset = "0x86E124")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000CA")]
			public bool isGrounded
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x172BD88", Offset = "0x172BD88", VA = "0x172BD88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874F90", Offset = "0x874F90")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x172C660", Offset = "0x172C660", VA = "0x172C660")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FA0", Offset = "0x874FA0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x1721AD4", Offset = "0x1721AD4", VA = "0x1721AD4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FB0", Offset = "0x874FB0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x172C66C", Offset = "0x172C66C", VA = "0x172C66C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FC0", Offset = "0x874FC0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public bool initiated
			{
				[Token(Token = "0x600071B")]
				[Address(RVA = "0x172C678", Offset = "0x172C678", VA = "0x172C678")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FD0", Offset = "0x874FD0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x172C680", Offset = "0x172C680", VA = "0x172C680")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FE0", Offset = "0x874FE0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			public float heightFromGround
			{
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x172C68C", Offset = "0x172C68C", VA = "0x172C68C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874FF0", Offset = "0x874FF0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x172C694", Offset = "0x172C694", VA = "0x172C694")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875000", Offset = "0x875000")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CE")]
			public Vector3 velocity
			{
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x172C69C", Offset = "0x172C69C", VA = "0x172C69C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875010", Offset = "0x875010")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x172C6A8", Offset = "0x172C6A8", VA = "0x172C6A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875020", Offset = "0x875020")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public Transform transform
			{
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x1721AE0", Offset = "0x1721AE0", VA = "0x1721AE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875030", Offset = "0x875030")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000722")]
				[Address(RVA = "0x172C6B4", Offset = "0x172C6B4", VA = "0x172C6B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875040", Offset = "0x875040")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public float IKOffset
			{
				[Token(Token = "0x6000723")]
				[Address(RVA = "0x172BD80", Offset = "0x172BD80", VA = "0x172BD80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875050", Offset = "0x875050")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000724")]
				[Address(RVA = "0x172C6BC", Offset = "0x172C6BC", VA = "0x172C6BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875060", Offset = "0x875060")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x172D340", Offset = "0x172D340", VA = "0x172D340")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000D2")]
			private float rootYOffset
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0x172D6C4", Offset = "0x172D6C4", VA = "0x172D6C4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x172B284", Offset = "0x172B284", VA = "0x172B284")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x172C6C4", Offset = "0x172C6C4", VA = "0x172C6C4")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x172C140", Offset = "0x172C140", VA = "0x172C140")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x172B394", Offset = "0x172B394", VA = "0x172B394")]
			public void Process()
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x172CE44", Offset = "0x172CE44", VA = "0x172CE44")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x172C718", Offset = "0x172C718", VA = "0x172C718")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0x172D504", Offset = "0x172D504", VA = "0x172D504")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600072D")]
			[Address(RVA = "0x172CAC8", Offset = "0x172CAC8", VA = "0x172CAC8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0x172CBD0", Offset = "0x172CBD0", VA = "0x172CBD0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x172D614", Offset = "0x172D614", VA = "0x172D614")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x172D3F0", Offset = "0x172D3F0", VA = "0x172D3F0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x172D830", Offset = "0x172D830", VA = "0x172D830")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0x172B1D4", Offset = "0x172B1D4", VA = "0x172B1D4")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000AA")]
		public class Pelvis
		{
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E134", Offset = "0x86E134")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E144", Offset = "0x86E144")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000D3")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0x17235DC", Offset = "0x17235DC", VA = "0x17235DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875070", Offset = "0x875070")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000735")]
				[Address(RVA = "0x172D9A8", Offset = "0x172D9A8", VA = "0x172D9A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875080", Offset = "0x875080")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public float heightOffset
			{
				[Token(Token = "0x6000736")]
				[Address(RVA = "0x17291DC", Offset = "0x17291DC", VA = "0x17291DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875090", Offset = "0x875090")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000737")]
				[Address(RVA = "0x172D9B4", Offset = "0x172D9B4", VA = "0x172D9B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750A0", Offset = "0x8750A0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000738")]
			[Address(RVA = "0x172B36C", Offset = "0x172B36C", VA = "0x172B36C")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x172C074", Offset = "0x172C074", VA = "0x172C074")]
			public void Reset()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x172D9BC", Offset = "0x172D9BC", VA = "0x172D9BC")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x172BD90", Offset = "0x172BD90", VA = "0x172BD90")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0x172B27C", Offset = "0x172B27C", VA = "0x172B27C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B584", Offset = "0x86B584")]
		public LayerMask layers;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B5BC", Offset = "0x86B5BC")]
		public float maxStep;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B5F4", Offset = "0x86B5F4")]
		public float heightOffset;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B62C", Offset = "0x86B62C")]
		public float footSpeed;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B664", Offset = "0x86B664")]
		public float footRadius;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B69C", Offset = "0x86B69C")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B6E8", Offset = "0x86B6E8")]
		public float prediction;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B720", Offset = "0x86B720")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B720", Offset = "0x86B720")]
		public float footRotationWeight;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B774", Offset = "0x86B774")]
		public float footRotationSpeed;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B7AC", Offset = "0x86B7AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B7AC", Offset = "0x86B7AC")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B804", Offset = "0x86B804")]
		public bool rotateSolver;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B83C", Offset = "0x86B83C")]
		public float pelvisSpeed;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B874", Offset = "0x86B874")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86B874", Offset = "0x86B874")]
		public float pelvisDamper;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B8C8", Offset = "0x86B8C8")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B900", Offset = "0x86B900")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B938", Offset = "0x86B938")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B970", Offset = "0x86B970")]
		public bool overstepFallsDown;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86B9A8", Offset = "0x86B9A8")]
		public Quality quality;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86B9E0", Offset = "0x86B9E0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86B9F0", Offset = "0x86B9F0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86BA00", Offset = "0x86BA00")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86BA10", Offset = "0x86BA10")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86BA20", Offset = "0x86BA20")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000028")]
		public Leg[] legs
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1721664", Offset = "0x1721664", VA = "0x1721664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B14", Offset = "0x872B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x172AC4C", Offset = "0x172AC4C", VA = "0x172AC4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B24", Offset = "0x872B24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public Pelvis pelvis
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x17235D4", Offset = "0x17235D4", VA = "0x17235D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B34", Offset = "0x872B34")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x172AC54", Offset = "0x172AC54", VA = "0x172AC54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B44", Offset = "0x872B44")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool isGrounded
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x172AC5C", Offset = "0x172AC5C", VA = "0x172AC5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B54", Offset = "0x872B54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x172AC64", Offset = "0x172AC64", VA = "0x172AC64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B64", Offset = "0x872B64")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Transform root
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x1721ACC", Offset = "0x1721ACC", VA = "0x1721ACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B74", Offset = "0x872B74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x172AC70", Offset = "0x172AC70", VA = "0x172AC70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B84", Offset = "0x872B84")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x1728444", Offset = "0x1728444", VA = "0x1728444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872B94", Offset = "0x872B94")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x172AC78", Offset = "0x172AC78", VA = "0x172AC78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x872BA4", Offset = "0x872BA4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x172AC98", Offset = "0x172AC98", VA = "0x172AC98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector3 up
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x1723740", Offset = "0x1723740", VA = "0x1723740")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002F")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x172C208", Offset = "0x172C208", VA = "0x172C208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x172ACF0", Offset = "0x172ACF0", VA = "0x172ACF0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x172B0F8", Offset = "0x172B0F8", VA = "0x172B0F8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1722860", Offset = "0x1722860", VA = "0x1722860")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1723334", Offset = "0x1723334", VA = "0x1723334")]
		public void Update()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x17258C0", Offset = "0x17258C0", VA = "0x17258C0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1722174", Offset = "0x1722174", VA = "0x1722174")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x172B37C", Offset = "0x172B37C", VA = "0x172B37C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x172C2E0", Offset = "0x172C2E0", VA = "0x172C2E0")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x172C450", Offset = "0x172C450", VA = "0x172C450")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x172C55C", Offset = "0x172C55C", VA = "0x172C55C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1721BAC", Offset = "0x1721BAC", VA = "0x1721BAC")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869D14", Offset = "0x869D14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869D14", Offset = "0x869D14")]
	public class AimIK : IK
	{
		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x1342894", Offset = "0x1342894", VA = "0x1342894", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872BB4", Offset = "0x872BB4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x13428E0", Offset = "0x13428E0", VA = "0x13428E0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872BEC", Offset = "0x872BEC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x134292C", Offset = "0x134292C", VA = "0x134292C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872C24", Offset = "0x872C24")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x1342978", Offset = "0x1342978", VA = "0x1342978")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872C5C", Offset = "0x872C5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x13429C4", Offset = "0x13429C4", VA = "0x13429C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872C94", Offset = "0x872C94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1342A10", Offset = "0x1342A10", VA = "0x1342A10", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1342A18", Offset = "0x1342A18", VA = "0x1342A18")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869D74", Offset = "0x869D74")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x13436E8", Offset = "0x13436E8", VA = "0x13436E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872CCC", Offset = "0x872CCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1343754", Offset = "0x1343754", VA = "0x1343754", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872D04", Offset = "0x872D04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x13437C0", Offset = "0x13437C0", VA = "0x13437C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872D3C", Offset = "0x872D3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x134380C", Offset = "0x134380C", VA = "0x134380C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872D74", Offset = "0x872D74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1343858", Offset = "0x1343858", VA = "0x1343858", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1343860", Offset = "0x1343860", VA = "0x1343860")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869DAC", Offset = "0x869DAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869DAC", Offset = "0x869DAC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1712774", Offset = "0x1712774", VA = "0x1712774", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872DAC", Offset = "0x872DAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x17127C0", Offset = "0x17127C0", VA = "0x17127C0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872DE4", Offset = "0x872DE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x171280C", Offset = "0x171280C", VA = "0x171280C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872E1C", Offset = "0x872E1C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1712858", Offset = "0x1712858", VA = "0x1712858")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872E54", Offset = "0x872E54")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x17128A4", Offset = "0x17128A4", VA = "0x17128A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x17128AC", Offset = "0x17128AC", VA = "0x17128AC")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869E0C", Offset = "0x869E0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869E0C", Offset = "0x869E0C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x171381C", Offset = "0x171381C", VA = "0x171381C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872E8C", Offset = "0x872E8C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1713868", Offset = "0x1713868", VA = "0x1713868", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872EC4", Offset = "0x872EC4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x17138B4", Offset = "0x17138B4", VA = "0x17138B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872EFC", Offset = "0x872EFC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1713900", Offset = "0x1713900", VA = "0x1713900")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872F34", Offset = "0x872F34")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x171394C", Offset = "0x171394C", VA = "0x171394C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1713954", Offset = "0x1713954", VA = "0x1713954")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869E6C", Offset = "0x869E6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869E6C", Offset = "0x869E6C")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x17142B8", Offset = "0x17142B8", VA = "0x17142B8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872F6C", Offset = "0x872F6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1714304", Offset = "0x1714304", VA = "0x1714304", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872FA4", Offset = "0x872FA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1714350", Offset = "0x1714350", VA = "0x1714350")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x872FDC", Offset = "0x872FDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x171439C", Offset = "0x171439C", VA = "0x171439C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873014", Offset = "0x873014")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x17143E8", Offset = "0x17143E8", VA = "0x17143E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x17143F0", Offset = "0x17143F0", VA = "0x17143F0")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869ECC", Offset = "0x869ECC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869ECC", Offset = "0x869ECC")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1720180", Offset = "0x1720180", VA = "0x1720180", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87304C", Offset = "0x87304C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x17201CC", Offset = "0x17201CC", VA = "0x17201CC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873084", Offset = "0x873084")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1720218", Offset = "0x1720218", VA = "0x1720218")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8730BC", Offset = "0x8730BC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1720264", Offset = "0x1720264", VA = "0x1720264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8730F4", Offset = "0x8730F4")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x17202B0", Offset = "0x17202B0", VA = "0x17202B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87312C", Offset = "0x87312C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x17202FC", Offset = "0x17202FC", VA = "0x17202FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873164", Offset = "0x873164")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1720348", Offset = "0x1720348", VA = "0x1720348")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1720394", Offset = "0x1720394", VA = "0x1720394", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x172039C", Offset = "0x172039C", VA = "0x172039C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x17205C0", Offset = "0x17205C0", VA = "0x17205C0")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x17209B0", Offset = "0x17209B0", VA = "0x17209B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87319C", Offset = "0x87319C")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x17209F0", Offset = "0x17209F0", VA = "0x17209F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8731D4", Offset = "0x8731D4")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1720B04", Offset = "0x1720B04", VA = "0x1720B04")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60002DE")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1730DD4", Offset = "0x1730DD4", VA = "0x1730DD4", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1730E84", Offset = "0x1730E84", VA = "0x1730E84", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1730F10", Offset = "0x1730F10", VA = "0x1730F10", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002E2")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002E3")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1712914", Offset = "0x1712914", VA = "0x1712914")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BA30", Offset = "0x86BA30")]
		public IK[] IKComponents;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BA68", Offset = "0x86BA68")]
		public Animator animator;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x17000030")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x1733C5C", Offset = "0x1733C5C", VA = "0x1733C5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1733D00", Offset = "0x1733D00", VA = "0x1733D00")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1733DA0", Offset = "0x1733DA0", VA = "0x1733DA0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1733ED8", Offset = "0x1733ED8", VA = "0x1733ED8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1733F14", Offset = "0x1733F14", VA = "0x1733F14")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1733DD4", Offset = "0x1733DD4", VA = "0x1733DD4")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1733FE0", Offset = "0x1733FE0", VA = "0x1733FE0")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869F2C", Offset = "0x869F2C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x17C5478", Offset = "0x17C5478", VA = "0x17C5478", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87320C", Offset = "0x87320C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17C54E4", Offset = "0x17C54E4", VA = "0x17C54E4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873244", Offset = "0x873244")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17C5550", Offset = "0x17C5550", VA = "0x17C5550")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87327C", Offset = "0x87327C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x17C559C", Offset = "0x17C559C", VA = "0x17C559C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8732B4", Offset = "0x8732B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x17C55E8", Offset = "0x17C55E8", VA = "0x17C55E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x17C55F0", Offset = "0x17C55F0", VA = "0x17C55F0")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869F64", Offset = "0x869F64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869F64", Offset = "0x869F64")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17C5658", Offset = "0x17C5658", VA = "0x17C5658", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8732EC", Offset = "0x8732EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x17C56A4", Offset = "0x17C56A4", VA = "0x17C56A4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873324", Offset = "0x873324")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x17C56F0", Offset = "0x17C56F0", VA = "0x17C56F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87335C", Offset = "0x87335C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x17C573C", Offset = "0x17C573C", VA = "0x17C573C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873394", Offset = "0x873394")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x17C5788", Offset = "0x17C5788", VA = "0x17C5788", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x17C5790", Offset = "0x17C5790", VA = "0x17C5790")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x869FC4", Offset = "0x869FC4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x869FC4", Offset = "0x869FC4")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x17C68AC", Offset = "0x17C68AC", VA = "0x17C68AC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8733CC", Offset = "0x8733CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x17C68F8", Offset = "0x17C68F8", VA = "0x17C68F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873404", Offset = "0x873404")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x17C6944", Offset = "0x17C6944", VA = "0x17C6944")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87343C", Offset = "0x87343C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x17C6990", Offset = "0x17C6990", VA = "0x17C6990")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873474", Offset = "0x873474")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x17C69DC", Offset = "0x17C69DC", VA = "0x17C69DC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x17C69E4", Offset = "0x17C69E4", VA = "0x17C69E4")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A024", Offset = "0x86A024")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A024", Offset = "0x86A024")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1CBEB80", Offset = "0x1CBEB80", VA = "0x1CBEB80", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8734AC", Offset = "0x8734AC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1CBEBCC", Offset = "0x1CBEBCC", VA = "0x1CBEBCC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8734E4", Offset = "0x8734E4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1CBEC18", Offset = "0x1CBEC18", VA = "0x1CBEC18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87351C", Offset = "0x87351C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1CBEC64", Offset = "0x1CBEC64", VA = "0x1CBEC64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873554", Offset = "0x873554")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1CBECB0", Offset = "0x1CBECB0", VA = "0x1CBECB0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1CBECB8", Offset = "0x1CBECB8", VA = "0x1CBECB8")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A084", Offset = "0x86A084")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000AB")]
		public class References
		{
			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E154", Offset = "0x86E154")]
			public Transform chest;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E18C", Offset = "0x86E18C")]
			public Transform neck;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E1C4", Offset = "0x86E1C4")]
			public Transform leftShoulder;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E1FC", Offset = "0x86E1FC")]
			public Transform rightShoulder;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E234", Offset = "0x86E234")]
			public Transform leftThigh;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E26C", Offset = "0x86E26C")]
			public Transform leftCalf;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E2A4", Offset = "0x86E2A4")]
			public Transform leftFoot;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E2DC", Offset = "0x86E2DC")]
			public Transform leftToes;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E314", Offset = "0x86E314")]
			public Transform rightThigh;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E34C", Offset = "0x86E34C")]
			public Transform rightCalf;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E384", Offset = "0x86E384")]
			public Transform rightFoot;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E3BC", Offset = "0x86E3BC")]
			public Transform rightToes;

			[Token(Token = "0x170000D5")]
			public bool isFilled
			{
				[Token(Token = "0x600073E")]
				[Address(RVA = "0x1CC0608", Offset = "0x1CC0608", VA = "0x1CC0608")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000D6")]
			public bool isEmpty
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0x1CC018C", Offset = "0x1CC018C", VA = "0x1CC018C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1CC0CAC", Offset = "0x1CC0CAC", VA = "0x1CC0CAC")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1CBFB34", Offset = "0x1CBFB34", VA = "0x1CBFB34")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1CC0CA4", Offset = "0x1CC0CA4", VA = "0x1CC0CA4")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x86BAA0", Offset = "0x86BAA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BAA0", Offset = "0x86BAA0")]
		public References references;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BB1C", Offset = "0x86BB1C")]
		public IKSolverVR solver;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1CBF9E8", Offset = "0x1CBF9E8", VA = "0x1CBF9E8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87358C", Offset = "0x87358C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1CBFA54", Offset = "0x1CBFA54", VA = "0x1CBFA54", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8735C4", Offset = "0x8735C4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1CBFAC0", Offset = "0x1CBFAC0", VA = "0x1CBFAC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8735FC", Offset = "0x8735FC")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1CBFB0C", Offset = "0x1CBFB0C", VA = "0x1CBFB0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873634", Offset = "0x873634")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1CC00B0", Offset = "0x1CC00B0", VA = "0x1CC00B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87366C", Offset = "0x87366C")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1CC00E8", Offset = "0x1CC00E8", VA = "0x1CC00E8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1CC00F0", Offset = "0x1CC00F0", VA = "0x1CC00F0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1CC0A8C", Offset = "0x1CC0A8C", VA = "0x1CC0A8C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1CC0C1C", Offset = "0x1CC0C1C", VA = "0x1CC0C1C")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class FABRIKChain
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BB54", Offset = "0x86BB54")]
		public float pull;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BB6C", Offset = "0x86BB6C")]
		public float pin;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x17139BC", Offset = "0x17139BC", VA = "0x17139BC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1713A94", Offset = "0x1713A94", VA = "0x1713A94")]
		public void Initiate()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1713AC8", Offset = "0x1713AC8", VA = "0x1713AC8")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1714048", Offset = "0x1714048", VA = "0x1714048")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1713C50", Offset = "0x1713C50", VA = "0x1713C50")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1714250", Offset = "0x1714250", VA = "0x1714250")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1714458", Offset = "0x1714458", VA = "0x1714458")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1714BC8", Offset = "0x1714BC8", VA = "0x1714BC8")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1714E9C", Offset = "0x1714E9C", VA = "0x1714E9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1714FFC", Offset = "0x1714FFC", VA = "0x1714FFC")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class BendBone
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E3F4", Offset = "0x86E3F4")]
			public Transform transform;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E42C", Offset = "0x86E42C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E42C", Offset = "0x86E42C")]
			public float weight;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1719488", Offset = "0x1719488", VA = "0x1719488")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1719508", Offset = "0x1719508", VA = "0x1719508")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1715C84", Offset = "0x1715C84", VA = "0x1715C84")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x17162D0", Offset = "0x17162D0", VA = "0x17162D0")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BB84", Offset = "0x86BB84")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x86BBBC", Offset = "0x86BBBC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BBBC", Offset = "0x86BBBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BBBC", Offset = "0x86BBBC")]
		public float positionWeight;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BC34", Offset = "0x86BC34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BC34", Offset = "0x86BC34")]
		public float bodyWeight;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BC88", Offset = "0x86BC88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BC88", Offset = "0x86BC88")]
		public float thighWeight;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BCDC", Offset = "0x86BCDC")]
		public bool handsPullBody;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x86BD14", Offset = "0x86BD14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BD14", Offset = "0x86BD14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BD14", Offset = "0x86BD14")]
		public float rotationWeight;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BD8C", Offset = "0x86BD8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BD8C", Offset = "0x86BD8C")]
		public float bodyClampWeight;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BDE0", Offset = "0x86BDE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BDE0", Offset = "0x86BDE0")]
		public float headClampWeight;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BE34", Offset = "0x86BE34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BE34", Offset = "0x86BE34")]
		public float bendWeight;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BE88", Offset = "0x86BE88")]
		public BendBone[] bendBones;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x86BEC0", Offset = "0x86BEC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BEC0", Offset = "0x86BEC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BEC0", Offset = "0x86BEC0")]
		public float CCDWeight;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BF38", Offset = "0x86BF38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BF38", Offset = "0x86BF38")]
		public float roll;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BF8C", Offset = "0x86BF8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86BF8C", Offset = "0x86BF8C")]
		public float damper;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86BFE4", Offset = "0x86BFE4")]
		public Transform[] CCDBones;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x86C01C", Offset = "0x86C01C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C01C", Offset = "0x86C01C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C01C", Offset = "0x86C01C")]
		public float postStretchWeight;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C094", Offset = "0x86C094")]
		public float maxStretch;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C0CC", Offset = "0x86C0CC")]
		public float stretchDamper;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C104", Offset = "0x86C104")]
		public bool fixHead;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C13C", Offset = "0x86C13C")]
		public Transform[] stretchBones;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x86C174", Offset = "0x86C174")]
		public Vector3 chestDirection;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C1AC", Offset = "0x86C1AC")]
		public float chestDirectionWeight;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1715004", Offset = "0x1715004", VA = "0x1715004")]
		private void Start()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x171558C", Offset = "0x171558C", VA = "0x171558C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1715CC4", Offset = "0x1715CC4", VA = "0x1715CC4")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1716328", Offset = "0x1716328", VA = "0x1716328")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1716FDC", Offset = "0x1716FDC", VA = "0x1716FDC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x171744C", Offset = "0x171744C", VA = "0x171744C")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x171792C", Offset = "0x171792C", VA = "0x171792C")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x171866C", Offset = "0x171866C", VA = "0x171866C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1716C50", Offset = "0x1716C50", VA = "0x1716C50")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1718954", Offset = "0x1718954", VA = "0x1718954")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x17184F4", Offset = "0x17184F4", VA = "0x17184F4")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1718358", Offset = "0x1718358", VA = "0x1718358")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1718E68", Offset = "0x1718E68", VA = "0x1718E68")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1719308", Offset = "0x1719308", VA = "0x1719308")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000AD")]
		public class ChildConstraint
		{
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E4A0", Offset = "0x86E4A0")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E4B0", Offset = "0x86E4B0")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000D7")]
			public float nominalDistance
			{
				[Token(Token = "0x6000746")]
				[Address(RVA = "0x171E6AC", Offset = "0x171E6AC", VA = "0x171E6AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750B0", Offset = "0x8750B0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000747")]
				[Address(RVA = "0x171E6B4", Offset = "0x171E6B4", VA = "0x171E6B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750C0", Offset = "0x8750C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D8")]
			public bool isRigid
			{
				[Token(Token = "0x6000748")]
				[Address(RVA = "0x171E6BC", Offset = "0x171E6BC", VA = "0x171E6BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750D0", Offset = "0x8750D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000749")]
				[Address(RVA = "0x171E6C4", Offset = "0x171E6C4", VA = "0x171E6C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750E0", Offset = "0x8750E0")]
				private set
				{
				}
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x171E6D0", Offset = "0x171E6D0", VA = "0x171E6D0")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x171A778", Offset = "0x171A778", VA = "0x171A778")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x171B448", Offset = "0x171B448", VA = "0x171B448")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x171E260", Offset = "0x171E260", VA = "0x171E260")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public enum Smoothing
		{
			[Token(Token = "0x40004EC")]
			None,
			[Token(Token = "0x40004ED")]
			Exponential,
			[Token(Token = "0x40004EE")]
			Cubic
		}

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C1C4", Offset = "0x86C1C4")]
		public float pin;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C1DC", Offset = "0x86C1DC")]
		public float pull;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C1F4", Offset = "0x86C1F4")]
		public float push;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C20C", Offset = "0x86C20C")]
		public float pushParent;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C224", Offset = "0x86C224")]
		public float reach;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40001DA")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x17195AC", Offset = "0x17195AC", VA = "0x17195AC")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x17196F8", Offset = "0x17196F8", VA = "0x17196F8")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1719800", Offset = "0x1719800", VA = "0x1719800")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1719950", Offset = "0x1719950", VA = "0x1719950")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1719A50", Offset = "0x1719A50", VA = "0x1719A50")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1719B70", Offset = "0x1719B70", VA = "0x1719B70")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x171AB3C", Offset = "0x171AB3C", VA = "0x171AB3C")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1719DF0", Offset = "0x1719DF0", VA = "0x1719DF0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x171B728", Offset = "0x171B728", VA = "0x171B728")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x171BC00", Offset = "0x171BC00", VA = "0x171BC00")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x171C130", Offset = "0x171C130", VA = "0x171C130")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x171CEB8", Offset = "0x171CEB8", VA = "0x171CEB8")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x171D9A8", Offset = "0x171D9A8", VA = "0x171D9A8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x171DE58", Offset = "0x171DE58", VA = "0x171DE58")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x171D8A0", Offset = "0x171D8A0", VA = "0x171D8A0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x171CCA0", Offset = "0x171CCA0", VA = "0x171CCA0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x171D7F8", Offset = "0x171D7F8", VA = "0x171D7F8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x171E07C", Offset = "0x171E07C", VA = "0x171E07C")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x171D5B0", Offset = "0x171D5B0", VA = "0x171D5B0")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x171DBCC", Offset = "0x171DBCC", VA = "0x171DBCC")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C23C", Offset = "0x86C23C")]
		public float weight;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C254", Offset = "0x86C254")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x17000031")]
		public bool initiated
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x171C620", Offset = "0x171C620", VA = "0x171C620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736A4", Offset = "0x8736A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1731168", Offset = "0x1731168", VA = "0x1731168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736B4", Offset = "0x8736B4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1730F88", Offset = "0x1730F88", VA = "0x1730F88")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1719674", Offset = "0x1719674", VA = "0x1719674")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1731174", Offset = "0x1731174", VA = "0x1731174")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x171A7F0", Offset = "0x171A7F0", VA = "0x171A7F0")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x171A7FC", Offset = "0x171A7FC", VA = "0x171A7FC")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x17314C0", Offset = "0x17314C0", VA = "0x17314C0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x17316F8", Offset = "0x17316F8", VA = "0x17316F8")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x171C628", Offset = "0x171C628", VA = "0x171C628")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1731220", Offset = "0x1731220", VA = "0x1731220")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1731370", Offset = "0x1731370", VA = "0x1731370")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class IKEffector
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C264", Offset = "0x86C264")]
		public float positionWeight;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C27C", Offset = "0x86C27C")]
		public float rotationWeight;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C294", Offset = "0x86C294")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C2A4", Offset = "0x86C2A4")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000032")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1731C70", Offset = "0x1731C70", VA = "0x1731C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736C4", Offset = "0x8736C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1731C78", Offset = "0x1731C78", VA = "0x1731C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736D4", Offset = "0x8736D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1718DB8", Offset = "0x1718DB8", VA = "0x1718DB8")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1731C84", Offset = "0x1731C84", VA = "0x1731C84")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1731D6C", Offset = "0x1731D6C", VA = "0x1731D6C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1731EA8", Offset = "0x1731EA8", VA = "0x1731EA8")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1732000", Offset = "0x1732000", VA = "0x1732000")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1732358", Offset = "0x1732358", VA = "0x1732358")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1732708", Offset = "0x1732708", VA = "0x1732708")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x17328E4", Offset = "0x17328E4", VA = "0x17328E4")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x17329A4", Offset = "0x17329A4", VA = "0x17329A4")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x17331A8", Offset = "0x17331A8", VA = "0x17331A8")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1733218", Offset = "0x1733218", VA = "0x1733218")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1733484", Offset = "0x1733484", VA = "0x1733484")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x17338F4", Offset = "0x17338F4", VA = "0x17338F4")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class BoneMap
		{
			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000D9")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600074F")]
				[Address(RVA = "0x15C1438", Offset = "0x15C1438", VA = "0x15C1438")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DA")]
			public bool isNodeBone
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x15C1600", Offset = "0x15C1600", VA = "0x15C1600")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DB")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000766")]
				[Address(RVA = "0x15C1CA4", Offset = "0x15C1CA4", VA = "0x15C1CA4")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x15C1344", Offset = "0x15C1344", VA = "0x15C1344")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x15C150C", Offset = "0x15C150C", VA = "0x15C150C")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x15C1570", Offset = "0x15C1570", VA = "0x15C1570")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x15C1610", Offset = "0x15C1610", VA = "0x15C1610")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x15C1714", Offset = "0x15C1714", VA = "0x15C1714")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x15C171C", Offset = "0x15C171C", VA = "0x15C171C")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x15C18D4", Offset = "0x15C18D4", VA = "0x15C18D4")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x15C19E8", Offset = "0x15C19E8", VA = "0x15C19E8")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x15C1AD4", Offset = "0x15C1AD4", VA = "0x15C1AD4")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x15C1F18", Offset = "0x15C1F18", VA = "0x15C1F18")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x15C1F58", Offset = "0x15C1F58", VA = "0x15C1F58")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x15C1F98", Offset = "0x15C1F98", VA = "0x15C1F98")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x15C1FEC", Offset = "0x15C1FEC", VA = "0x15C1FEC")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x15C2200", Offset = "0x15C2200", VA = "0x15C2200")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x15C25B0", Offset = "0x15C25B0", VA = "0x15C25B0")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600075F")]
			[Address(RVA = "0x15C260C", Offset = "0x15C260C", VA = "0x15C260C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x15C27DC", Offset = "0x15C27DC", VA = "0x15C27DC")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0x15C2854", Offset = "0x15C2854", VA = "0x15C2854")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0x15C2AF0", Offset = "0x15C2AF0", VA = "0x15C2AF0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x15C2D70", Offset = "0x15C2D70", VA = "0x15C2D70")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x15C2EB8", Offset = "0x15C2EB8", VA = "0x15C2EB8")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x15C2360", Offset = "0x15C2360", VA = "0x15C2360")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000767")]
			[Address(RVA = "0x15C30CC", Offset = "0x15C30CC", VA = "0x15C30CC")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1733FE8", Offset = "0x1733FE8", VA = "0x1733FE8", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1733FF0", Offset = "0x1733FF0", VA = "0x1733FF0", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1733FF4", Offset = "0x1733FF4", VA = "0x1733FF4")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x173412C", Offset = "0x173412C", VA = "0x173412C")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1734234", Offset = "0x1734234", VA = "0x1734234")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C2BC", Offset = "0x86C2BC")]
		public float maintainRotationWeight;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x15C30E4", Offset = "0x15C30E4", VA = "0x15C30E4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x15C31A8", Offset = "0x15C31A8", VA = "0x15C31A8")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x15C322C", Offset = "0x15C322C", VA = "0x15C322C")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x15C32C4", Offset = "0x15C32C4", VA = "0x15C32C4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x15C32F0", Offset = "0x15C32F0", VA = "0x15C32F0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x15C3320", Offset = "0x15C3320", VA = "0x15C3320", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x15C33CC", Offset = "0x15C33CC", VA = "0x15C33CC")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x15C33F8", Offset = "0x15C33F8", VA = "0x15C33F8")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public enum BoneMapType
		{
			[Token(Token = "0x4000506")]
			Parent,
			[Token(Token = "0x4000507")]
			Bone1,
			[Token(Token = "0x4000508")]
			Bone2,
			[Token(Token = "0x4000509")]
			Bone3
		}

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C2D4", Offset = "0x86C2D4")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C2EC", Offset = "0x86C2EC")]
		public float weight;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x15C3438", Offset = "0x15C3438", VA = "0x15C3438", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x15C34DC", Offset = "0x15C34DC", VA = "0x15C34DC")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x15C35B0", Offset = "0x15C35B0", VA = "0x15C35B0")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x15C3980", Offset = "0x15C3980", VA = "0x15C3980")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x15C3A80", Offset = "0x15C3A80", VA = "0x15C3A80")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x15C3BAC", Offset = "0x15C3BAC", VA = "0x15C3BAC")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x15C3BB8", Offset = "0x15C3BB8", VA = "0x15C3BB8")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x15C3C8C", Offset = "0x15C3C8C", VA = "0x15C3C8C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x15C3D70", Offset = "0x15C3D70", VA = "0x15C3D70", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x15C408C", Offset = "0x15C408C", VA = "0x15C408C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x15C4164", Offset = "0x15C4164", VA = "0x15C4164")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C304", Offset = "0x86C304")]
		public int iterations;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C31C", Offset = "0x86C31C")]
		public float twistWeight;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x15C4390", Offset = "0x15C4390", VA = "0x15C4390", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x15C46E8", Offset = "0x15C46E8", VA = "0x15C46E8")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x15C4804", Offset = "0x15C4804", VA = "0x15C4804")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x15C4954", Offset = "0x15C4954", VA = "0x15C4954")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x15C4964", Offset = "0x15C4964", VA = "0x15C4964")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x15C49FC", Offset = "0x15C49FC", VA = "0x15C49FC")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x15C4ACC", Offset = "0x15C4ACC", VA = "0x15C4ACC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x15C54F0", Offset = "0x15C54F0", VA = "0x15C54F0")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x15C553C", Offset = "0x15C553C", VA = "0x15C553C")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x15C5A20", Offset = "0x15C5A20", VA = "0x15C5A20")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x15C605C", Offset = "0x15C605C", VA = "0x15C605C")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x15C62C0", Offset = "0x15C62C0", VA = "0x15C62C0")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x15C64DC", Offset = "0x15C64DC", VA = "0x15C64DC")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class Point
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E4C0", Offset = "0x86E4C0")]
			public float weight;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x15C8D44", Offset = "0x15C8D44", VA = "0x15C8D44")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x15C8DA8", Offset = "0x15C8DA8", VA = "0x15C8DA8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x15C8F78", Offset = "0x15C8F78", VA = "0x15C8F78")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x15C8FB8", Offset = "0x15C8FB8", VA = "0x15C8FB8")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x15C8FF8", Offset = "0x15C8FF8", VA = "0x15C8FF8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x15C905C", Offset = "0x15C905C", VA = "0x15C905C")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x15C8638", Offset = "0x15C8638", VA = "0x15C8638")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B2")]
		public class Bone : Point
		{
			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000DC")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0x15C7A2C", Offset = "0x15C7A2C", VA = "0x15C7A2C")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000770")]
				[Address(RVA = "0x15C7B28", Offset = "0x15C7B28", VA = "0x15C7B28")]
				set
				{
				}
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x15C7BB0", Offset = "0x15C7BB0", VA = "0x15C7BB0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x15C7EB8", Offset = "0x15C7EB8", VA = "0x15C7EB8")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x15C82B0", Offset = "0x15C82B0", VA = "0x15C82B0")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x15C8560", Offset = "0x15C8560", VA = "0x15C8560")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x15C85B4", Offset = "0x15C85B4", VA = "0x15C85B4")]
			public Bone()
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x15C86B8", Offset = "0x15C86B8", VA = "0x15C86B8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x15C8750", Offset = "0x15C8750", VA = "0x15C8750")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000B3")]
		public class Node : Point
		{
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x15C8CE0", Offset = "0x15C8CE0", VA = "0x15C8CE0")]
			public Node()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0x15C8CE4", Offset = "0x15C8CE4", VA = "0x15C8CE4")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x15C8D0C", Offset = "0x15C8D0C", VA = "0x15C8D0C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000B5")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C344", Offset = "0x86C344")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C344", Offset = "0x86C344")]
		public float IKPositionWeight;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C398", Offset = "0x86C398")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000033")]
		public bool initiated
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x15C7024", Offset = "0x15C7024", VA = "0x15C7024")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736E4", Offset = "0x8736E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x15C6FB0", Offset = "0x15C6FB0", VA = "0x15C6FB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8736F4", Offset = "0x8736F4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x15C69E8", Offset = "0x15C69E8", VA = "0x15C69E8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600037A")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x15C6A64", Offset = "0x15C6A64", VA = "0x15C6A64")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x15C6FBC", Offset = "0x15C6FBC", VA = "0x15C6FBC")]
		public void Update()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x15C702C", Offset = "0x15C702C", VA = "0x15C702C", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x15C7038", Offset = "0x15C7038", VA = "0x15C7038")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x15C7044", Offset = "0x15C7044", VA = "0x15C7044")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x15C704C", Offset = "0x15C704C", VA = "0x15C704C")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x15C70D0", Offset = "0x15C70D0", VA = "0x15C70D0")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000385")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000386")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000387")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000388")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000389")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x15C70D8", Offset = "0x15C70D8", VA = "0x15C70D8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x15C70F0", Offset = "0x15C70F0", VA = "0x15C70F0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x15C726C", Offset = "0x15C726C", VA = "0x15C726C")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x15C7340", Offset = "0x15C7340", VA = "0x15C7340")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x15C7A14", Offset = "0x15C7A14", VA = "0x15C7A14")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C3E0", Offset = "0x86C3E0")]
		public float poleWeight;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C3F8", Offset = "0x86C3F8")]
		public float clampWeight;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C410", Offset = "0x86C410")]
		public int clampSmoothing;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000034")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x15C9218", Offset = "0x15C9218", VA = "0x15C9218")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000035")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x15C92EC", Offset = "0x15C92EC", VA = "0x15C92EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000036")]
		protected override int minBones
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x15CA2D8", Offset = "0x15CA2D8", VA = "0x15CA2D8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000037")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x15CA968", Offset = "0x15CA968", VA = "0x15CA968", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x15C9110", Offset = "0x15C9110", VA = "0x15C9110")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x15C93C0", Offset = "0x15C93C0", VA = "0x15C93C0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x15C96C8", Offset = "0x15C96C8", VA = "0x15C96C8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x15CA0FC", Offset = "0x15CA0FC", VA = "0x15CA0FC")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x15C9CD4", Offset = "0x15C9CD4", VA = "0x15C9CD4")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x15CA2E0", Offset = "0x15CA2E0", VA = "0x15CA2E0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x15CAA70", Offset = "0x15CAA70", VA = "0x15CAA70")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C428", Offset = "0x86C428")]
		public float IKRotationWeight;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x15CAB80", Offset = "0x15CAB80", VA = "0x15CAB80", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x15CB018", Offset = "0x15CB018", VA = "0x15CB018")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x15CB0D8", Offset = "0x15CB0D8", VA = "0x15CB0D8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x15CB2C4", Offset = "0x15CB2C4", VA = "0x15CB2C4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x15CB480", Offset = "0x15CB480", VA = "0x15CB480", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x15CB4F8", Offset = "0x15CB4F8", VA = "0x15CB4F8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x15CB584", Offset = "0x15CB584", VA = "0x15CB584", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x15CBC0C", Offset = "0x15CBC0C", VA = "0x15CBC0C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x15CBC38", Offset = "0x15CBC38", VA = "0x15CBC38")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x15CB60C", Offset = "0x15CB60C", VA = "0x15CB60C")]
		private void Read()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x15CBCE0", Offset = "0x15CBCE0", VA = "0x15CBCE0")]
		private void Write()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x15CBFE0", Offset = "0x15CBFE0", VA = "0x15CBFE0")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x15CC130", Offset = "0x15CC130", VA = "0x15CC130")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x15CC288", Offset = "0x15CC288", VA = "0x15CC288", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x15CCB64", Offset = "0x15CCB64", VA = "0x15CCB64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x15CD43C", Offset = "0x15CD43C", VA = "0x15CD43C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x15CDF08", Offset = "0x15CDF08", VA = "0x15CDF08")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000038")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x15CF900", Offset = "0x15CF900", VA = "0x15CF900", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x15CDF0C", Offset = "0x15CDF0C", VA = "0x15CDF0C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x15CEB24", Offset = "0x15CEB24", VA = "0x15CEB24")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x15CEC5C", Offset = "0x15CEC5C", VA = "0x15CEC5C", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x15CED00", Offset = "0x15CED00", VA = "0x15CED00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x15CF558", Offset = "0x15CF558", VA = "0x15CF558", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x15CF908", Offset = "0x15CF908", VA = "0x15CF908")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x15CDFE0", Offset = "0x15CDFE0", VA = "0x15CDFE0")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x15CEC08", Offset = "0x15CEC08", VA = "0x15CEC08")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x15CF888", Offset = "0x15CF888", VA = "0x15CF888")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x15CE778", Offset = "0x15CE778", VA = "0x15CE778")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x15D05BC", Offset = "0x15D05BC", VA = "0x15D05BC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x15D06E4", Offset = "0x15D06E4", VA = "0x15D06E4")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x15D087C", Offset = "0x15D087C", VA = "0x15D087C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x15D0A14", Offset = "0x15D0A14", VA = "0x15D0A14")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x15CF1C0", Offset = "0x15CF1C0", VA = "0x15CF1C0")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x15CF38C", Offset = "0x15CF38C", VA = "0x15CF38C")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x15D0CB4", Offset = "0x15D0CB4", VA = "0x15D0CB4")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x15CFDDC", Offset = "0x15CFDDC", VA = "0x15CFDDC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x15CEBF8", Offset = "0x15CEBF8", VA = "0x15CEBF8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x15D17BC", Offset = "0x15D17BC", VA = "0x15D17BC")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x15D0EAC", Offset = "0x15D0EAC", VA = "0x15D0EAC")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x15CFA20", Offset = "0x15CFA20", VA = "0x15CFA20")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x15CFC00", Offset = "0x15CFC00", VA = "0x15CFC00")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x15D19D4", Offset = "0x15D19D4", VA = "0x15D19D4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C440", Offset = "0x86C440")]
		public float rootPin;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x15D1A48", Offset = "0x15D1A48", VA = "0x15D1A48", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x15D29A4", Offset = "0x15D29A4", VA = "0x15D29A4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x15D2A88", Offset = "0x15D2A88", VA = "0x15D2A88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x15D2B90", Offset = "0x15D2B90", VA = "0x15D2B90", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x15D2CFC", Offset = "0x15D2CFC", VA = "0x15D2CFC")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x15D2E54", Offset = "0x15D2E54", VA = "0x15D2E54", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x15D35AC", Offset = "0x15D35AC", VA = "0x15D35AC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x15D3838", Offset = "0x15D3838", VA = "0x15D3838", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x15D3680", Offset = "0x15D3680", VA = "0x15D3680")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x15D3188", Offset = "0x15D3188", VA = "0x15D3188")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x15D3910", Offset = "0x15D3910", VA = "0x15D3910")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C458", Offset = "0x86C458")]
		public int iterations;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x15D3988", Offset = "0x15D3988", VA = "0x15D3988")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x15D3ABC", Offset = "0x15D3ABC", VA = "0x15D3ABC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x15D3B28", Offset = "0x15D3B28", VA = "0x15D3B28")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x15C215C", Offset = "0x15C215C", VA = "0x15C215C")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x15C1394", Offset = "0x15C1394", VA = "0x15C1394")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x15D3CDC", Offset = "0x15D3CDC", VA = "0x15D3CDC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x15D3F3C", Offset = "0x15D3F3C", VA = "0x15D3F3C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x15D4164", Offset = "0x15D4164", VA = "0x15D4164", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x15D440C", Offset = "0x15D440C", VA = "0x15D440C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x15D4548", Offset = "0x15D4548", VA = "0x15D4548", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x15D4698", Offset = "0x15D4698", VA = "0x15D4698", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x15D489C", Offset = "0x15D489C", VA = "0x15D489C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x15D4AD8", Offset = "0x15D4AD8", VA = "0x15D4AD8", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x15D4F24", Offset = "0x15D4F24", VA = "0x15D4F24", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x15D5508", Offset = "0x15D5508", VA = "0x15D5508", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x15D556C", Offset = "0x15D556C", VA = "0x15D556C", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x15D56CC", Offset = "0x15D56CC", VA = "0x15D56CC")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000263")]
		Body,
		[Token(Token = "0x4000264")]
		LeftShoulder,
		[Token(Token = "0x4000265")]
		RightShoulder,
		[Token(Token = "0x4000266")]
		LeftThigh,
		[Token(Token = "0x4000267")]
		RightThigh,
		[Token(Token = "0x4000268")]
		LeftHand,
		[Token(Token = "0x4000269")]
		RightHand,
		[Token(Token = "0x400026A")]
		LeftFoot,
		[Token(Token = "0x400026B")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x400026D")]
		LeftArm,
		[Token(Token = "0x400026E")]
		RightArm,
		[Token(Token = "0x400026F")]
		LeftLeg,
		[Token(Token = "0x4000270")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C470", Offset = "0x86C470")]
		public float spineStiffness;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C488", Offset = "0x86C488")]
		public float pullBodyVertical;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C4A0", Offset = "0x86C4A0")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C4B8", Offset = "0x86C4B8")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000039")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x15D57AC", Offset = "0x15D57AC", VA = "0x15D57AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x15D59C4", Offset = "0x15D59C4", VA = "0x15D59C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x15D59CC", Offset = "0x15D59CC", VA = "0x15D59CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x15D59D4", Offset = "0x15D59D4", VA = "0x15D59D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x15D59DC", Offset = "0x15D59DC", VA = "0x15D59DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x15D59E4", Offset = "0x15D59E4", VA = "0x15D59E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x15D59EC", Offset = "0x15D59EC", VA = "0x15D59EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x15D59F4", Offset = "0x15D59F4", VA = "0x15D59F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x15D59FC", Offset = "0x15D59FC", VA = "0x15D59FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x15D5A04", Offset = "0x15D5A04", VA = "0x15D5A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x15D5A4C", Offset = "0x15D5A4C", VA = "0x15D5A4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x15D5A94", Offset = "0x15D5A94", VA = "0x15D5A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x15D5ADC", Offset = "0x15D5ADC", VA = "0x15D5ADC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x15D5B24", Offset = "0x15D5B24", VA = "0x15D5B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x15D5B68", Offset = "0x15D5B68", VA = "0x15D5B68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x15D5BB0", Offset = "0x15D5BB0", VA = "0x15D5BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x15D5BF8", Offset = "0x15D5BF8", VA = "0x15D5BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x15D5C40", Offset = "0x15D5C40", VA = "0x15D5C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0x15D8B90", Offset = "0x15D8B90", VA = "0x15D8B90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873704", Offset = "0x873704")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x15D8B9C", Offset = "0x15D8B9C", VA = "0x15D8B9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873714", Offset = "0x873714")]
			private set
			{
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x15D5C84", Offset = "0x15D5C84", VA = "0x15D5C84")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x15D5DFC", Offset = "0x15D5DFC", VA = "0x15D5DFC")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x15D5CEC", Offset = "0x15D5CEC", VA = "0x15D5CEC")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x15D5EEC", Offset = "0x15D5EEC", VA = "0x15D5EEC")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x15D57B4", Offset = "0x15D57B4", VA = "0x15D57B4")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x15D602C", Offset = "0x15D602C", VA = "0x15D602C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x15D613C", Offset = "0x15D613C", VA = "0x15D613C")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x15D6248", Offset = "0x15D6248", VA = "0x15D6248")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x15D6354", Offset = "0x15D6354", VA = "0x15D6354")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x15D635C", Offset = "0x15D635C", VA = "0x15D635C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x15D63A0", Offset = "0x15D63A0", VA = "0x15D63A0")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x15D64C4", Offset = "0x15D64C4", VA = "0x15D64C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x15D6790", Offset = "0x15D6790", VA = "0x15D6790")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x15D82F4", Offset = "0x15D82F4", VA = "0x15D82F4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x15D888C", Offset = "0x15D888C", VA = "0x15D888C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x15D894C", Offset = "0x15D894C", VA = "0x15D894C")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x15D86BC", Offset = "0x15D86BC", VA = "0x15D86BC")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x15D87A4", Offset = "0x15D87A4", VA = "0x15D87A4")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x15D8BA8", Offset = "0x15D8BA8", VA = "0x15D8BA8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x15D8C80", Offset = "0x15D8C80", VA = "0x15D8C80", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x15D8E7C", Offset = "0x15D8E7C", VA = "0x15D8E7C")]
		private void PullBody()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x15D903C", Offset = "0x15D903C", VA = "0x15D903C")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x15D9244", Offset = "0x15D9244", VA = "0x15D9244")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x15D94B8", Offset = "0x15D94B8", VA = "0x15D94B8", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x15D99D0", Offset = "0x15D99D0", VA = "0x15D99D0", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x15D9B0C", Offset = "0x15D9B0C", VA = "0x15D9B0C")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700004C")]
		protected virtual int minBones
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x15DA584", Offset = "0x15DA584", VA = "0x15DA584", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x15DA58C", Offset = "0x15DA58C", VA = "0x15DA58C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x15DA594", Offset = "0x15DA594", VA = "0x15DA594", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x15DA5A4", Offset = "0x15DA5A4", VA = "0x15DA5A4", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000050")]
		protected float positionOffset
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x15CD378", Offset = "0x15CD378", VA = "0x15CD378")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x15D9B18", Offset = "0x15D9B18", VA = "0x15D9B18")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x15D9D24", Offset = "0x15D9D24", VA = "0x15D9D24")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x15D9EF0", Offset = "0x15D9EF0", VA = "0x15D9EF0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x15D9F88", Offset = "0x15D9F88", VA = "0x15D9F88", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x15DA034", Offset = "0x15DA034", VA = "0x15DA034", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x15DA448", Offset = "0x15DA448", VA = "0x15DA448", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x15DA450", Offset = "0x15DA450", VA = "0x15DA450", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x15DA59C", Offset = "0x15DA59C", VA = "0x15DA59C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x15DA5A0", Offset = "0x15DA5A0", VA = "0x15DA5A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x15CC338", Offset = "0x15CC338", VA = "0x15CC338")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x15CCEB4", Offset = "0x15CCEB4", VA = "0x15CCEB4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x15DA784", Offset = "0x15DA784", VA = "0x15DA784")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x15CAB04", Offset = "0x15CAB04", VA = "0x15CAB04")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000051")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C4C8", Offset = "0x86C4C8")]
		public float IKRotationWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x15DAAEC", Offset = "0x15DAAEC", VA = "0x15DAAEC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x15DAF84", Offset = "0x15DAF84", VA = "0x15DAF84")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x15DB044", Offset = "0x15DB044", VA = "0x15DB044", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15DB230", Offset = "0x15DB230", VA = "0x15DB230", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x15DB3EC", Offset = "0x15DB3EC", VA = "0x15DB3EC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x15DB464", Offset = "0x15DB464", VA = "0x15DB464", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x15DB4F0", Offset = "0x15DB4F0", VA = "0x15DB4F0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x15DBB7C", Offset = "0x15DBB7C", VA = "0x15DBB7C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x15DBBA8", Offset = "0x15DBBA8", VA = "0x15DBBA8")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x15DB578", Offset = "0x15DB578", VA = "0x15DB578")]
		private void Read()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x15DBCE4", Offset = "0x15DBCE4", VA = "0x15DBCE4")]
		private void Write()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x15DBFE4", Offset = "0x15DBFE4", VA = "0x15DBFE4")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000052")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000B6")]
		public enum BendModifier
		{
			[Token(Token = "0x400051A")]
			Animation,
			[Token(Token = "0x400051B")]
			Target,
			[Token(Token = "0x400051C")]
			Parent,
			[Token(Token = "0x400051D")]
			Arm,
			[Token(Token = "0x400051E")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000B7")]
		public struct AxisDirection
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0x9295B8", Offset = "0x9295B8", VA = "0x9295B8")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C4E0", Offset = "0x86C4E0")]
		public float maintainRotationWeight;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C4F8", Offset = "0x86C4F8")]
		public float bendModifierWeight;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000051")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x15DDB4C", Offset = "0x15DDB4C", VA = "0x15DDB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x15DC134", Offset = "0x15DC134", VA = "0x15DC134")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x15DC194", Offset = "0x15DC194", VA = "0x15DC194")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x15DC2B8", Offset = "0x15DC2B8", VA = "0x15DC2B8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x15DCA34", Offset = "0x15DCA34", VA = "0x15DCA34", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x15DD79C", Offset = "0x15DD79C", VA = "0x15DD79C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x15DD940", Offset = "0x15DD940", VA = "0x15DD940")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x15DDAC4", Offset = "0x15DDAC4", VA = "0x15DDAC4")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x15DC6F0", Offset = "0x15DC6F0", VA = "0x15DC6F0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x15DCB70", Offset = "0x15DCB70", VA = "0x15DCB70")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000DD")]
			public Vector3 forward
			{
				[Token(Token = "0x6000788")]
				[Address(RVA = "0x15E0094", Offset = "0x15E0094", VA = "0x15E0094")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0x15E08F4", Offset = "0x15E08F4", VA = "0x15E08F4")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x15DF100", Offset = "0x15DF100", VA = "0x15DF100")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0x15DF540", Offset = "0x15DF540", VA = "0x15DF540")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0x15E0558", Offset = "0x15E0558", VA = "0x15E0558")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C510", Offset = "0x86C510")]
		public float bodyWeight;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C528", Offset = "0x86C528")]
		public float headWeight;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C540", Offset = "0x86C540")]
		public float eyesWeight;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C558", Offset = "0x86C558")]
		public float clampWeight;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C570", Offset = "0x86C570")]
		public float clampWeightHead;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C588", Offset = "0x86C588")]
		public float clampWeightEyes;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C5A0", Offset = "0x86C5A0")]
		public int clampSmoothing;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3[] headForwards;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000052")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x15DE5E4", Offset = "0x15DE5E4", VA = "0x15DE5E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x15DE884", Offset = "0x15DE884", VA = "0x15DE884")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool headIsValid
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x15DE72C", Offset = "0x15DE72C", VA = "0x15DE72C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15DE8B8", Offset = "0x15DE8B8", VA = "0x15DE8B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x15DE73C", Offset = "0x15DE73C", VA = "0x15DE73C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000057")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x15DE938", Offset = "0x15DE938", VA = "0x15DE938")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x15DDBC8", Offset = "0x15DDBC8", VA = "0x15DDBC8")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x15DDC4C", Offset = "0x15DDC4C", VA = "0x15DDC4C")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x15DDCF8", Offset = "0x15DDCF8", VA = "0x15DDCF8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x15DDDC0", Offset = "0x15DDDC0", VA = "0x15DDDC0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x15DDEAC", Offset = "0x15DDEAC", VA = "0x15DDEAC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x15DDFB8", Offset = "0x15DDFB8", VA = "0x15DDFB8")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x15DE100", Offset = "0x15DE100", VA = "0x15DE100", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x15DE294", Offset = "0x15DE294", VA = "0x15DE294", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x15DE43C", Offset = "0x15DE43C", VA = "0x15DE43C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x15DE96C", Offset = "0x15DE96C", VA = "0x15DE96C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x15DEC7C", Offset = "0x15DEC7C", VA = "0x15DEC7C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x15DEE3C", Offset = "0x15DEE3C", VA = "0x15DEE3C")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x15DF128", Offset = "0x15DF128", VA = "0x15DF128", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x15DF68C", Offset = "0x15DF68C", VA = "0x15DF68C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x15DF798", Offset = "0x15DF798", VA = "0x15DF798")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x15DFA94", Offset = "0x15DFA94", VA = "0x15DFA94")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x15DFD90", Offset = "0x15DFD90", VA = "0x15DFD90")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x15E0168", Offset = "0x15E0168", VA = "0x15E0168")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x15DEEE4", Offset = "0x15DEEE4", VA = "0x15DEEE4")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x15E06F0", Offset = "0x15E06F0", VA = "0x15E06F0")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000789")]
			[Address(RVA = "0x15E22E0", Offset = "0x15E22E0", VA = "0x15E22E0")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600078A")]
			[Address(RVA = "0x15E3170", Offset = "0x15E3170", VA = "0x15E3170")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0x15DC1E4", Offset = "0x15DC1E4", VA = "0x15DC1E4")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600078C")]
			[Address(RVA = "0x15E3238", Offset = "0x15E3238", VA = "0x15E3238")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C5B8", Offset = "0x86C5B8")]
		public float IKRotationWeight;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x15E08F8", Offset = "0x15E08F8", VA = "0x15E08F8")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x15E0B14", Offset = "0x15E0B14", VA = "0x15E0B14")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x15E0D14", Offset = "0x15E0D14", VA = "0x15E0D14")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x15E0D20", Offset = "0x15E0D20", VA = "0x15E0D20")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x15E0DA4", Offset = "0x15E0DA4", VA = "0x15E0DA4")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x15E0DB0", Offset = "0x15E0DB0", VA = "0x15E0DB0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x15E0DB8", Offset = "0x15E0DB8", VA = "0x15E0DB8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x15E0F0C", Offset = "0x15E0F0C", VA = "0x15E0F0C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x15E1040", Offset = "0x15E1040", VA = "0x15E1040", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x15E10A0", Offset = "0x15E10A0", VA = "0x15E10A0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x15E1114", Offset = "0x15E1114", VA = "0x15E1114", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x15E1604", Offset = "0x15E1604", VA = "0x15E1604")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x15E168C", Offset = "0x15E168C", VA = "0x15E168C")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x15E1D18", Offset = "0x15E1D18", VA = "0x15E1D18")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x15E1F30", Offset = "0x15E1F30", VA = "0x15E1F30", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x15E21A4", Offset = "0x15E21A4", VA = "0x15E21A4")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x15E208C", Offset = "0x15E208C", VA = "0x15E208C")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x15E24A0", Offset = "0x15E24A0", VA = "0x15E24A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x15E322C", Offset = "0x15E322C", VA = "0x15E322C", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x15E3230", Offset = "0x15E3230", VA = "0x15E3230", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x15E3234", Offset = "0x15E3234", VA = "0x15E3234", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x15E2E38", Offset = "0x15E2E38", VA = "0x15E2E38")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x15DD9B4", Offset = "0x15DD9B4", VA = "0x15DD9B4")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000BA")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x20000F5")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40006C6")]
				YawPitch,
				[Token(Token = "0x40006C7")]
				FromTo
			}

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E4D8", Offset = "0x86E4D8")]
			public Transform target;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E510", Offset = "0x86E510")]
			public Transform bendGoal;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E548", Offset = "0x86E548")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E548", Offset = "0x86E548")]
			public float positionWeight;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E59C", Offset = "0x86E59C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E59C", Offset = "0x86E59C")]
			public float rotationWeight;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E5F0", Offset = "0x86E5F0")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E628", Offset = "0x86E628")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E628", Offset = "0x86E628")]
			public float shoulderRotationWeight;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E67C", Offset = "0x86E67C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E67C", Offset = "0x86E67C")]
			public float shoulderTwistWeight;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E6D0", Offset = "0x86E6D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E6D0", Offset = "0x86E6D0")]
			public float bendGoalWeight;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E724", Offset = "0x86E724")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E724", Offset = "0x86E724")]
			public float swivelOffset;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E780", Offset = "0x86E780")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E7B8", Offset = "0x86E7B8")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E7F0", Offset = "0x86E7F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E7F0", Offset = "0x86E7F0")]
			public float armLengthMlp;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E848", Offset = "0x86E848")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E8C0", Offset = "0x86E8C0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E8D0", Offset = "0x86E8D0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x400053E")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x400053F")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000DE")]
			public Vector3 position
			{
				[Token(Token = "0x600078D")]
				[Address(RVA = "0x17A7CB8", Offset = "0x17A7CB8", VA = "0x17A7CB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8750F0", Offset = "0x8750F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600078E")]
				[Address(RVA = "0x17A7CC4", Offset = "0x17A7CC4", VA = "0x17A7CC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875100", Offset = "0x875100")]
				private set
				{
				}
			}

			[Token(Token = "0x170000DF")]
			public Quaternion rotation
			{
				[Token(Token = "0x600078F")]
				[Address(RVA = "0x17A7CD0", Offset = "0x17A7CD0", VA = "0x17A7CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875110", Offset = "0x875110")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000790")]
				[Address(RVA = "0x17A7CDC", Offset = "0x17A7CDC", VA = "0x17A7CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875120", Offset = "0x875120")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E0")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x17A7CE8", Offset = "0x17A7CE8", VA = "0x17A7CE8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E1")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000792")]
				[Address(RVA = "0x17A7D2C", Offset = "0x17A7D2C", VA = "0x17A7D2C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x17A7D7C", Offset = "0x17A7D7C", VA = "0x17A7D7C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000794")]
				[Address(RVA = "0x17A7DD8", Offset = "0x17A7DD8", VA = "0x17A7DD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x17A7E34", Offset = "0x17A7E34", VA = "0x17A7E34", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000796")]
			[Address(RVA = "0x17A89A0", Offset = "0x17A89A0", VA = "0x17A89A0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x17A8BE8", Offset = "0x17A8BE8", VA = "0x17A8BE8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000798")]
			[Address(RVA = "0x17A8C94", Offset = "0x17A8C94", VA = "0x17A8C94")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x17A917C", Offset = "0x17A917C", VA = "0x17A917C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x17AB98C", Offset = "0x17AB98C", VA = "0x17AB98C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x17AB9FC", Offset = "0x17AB9FC", VA = "0x17AB9FC", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x17AA634", Offset = "0x17AA634", VA = "0x17AA634")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x600079D")]
			[Address(RVA = "0x17AAA24", Offset = "0x17AAA24", VA = "0x17AAA24")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x17ABD48", Offset = "0x17ABD48", VA = "0x17ABD48")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600079F")]
			[Address(RVA = "0x17ABEA0", Offset = "0x17ABEA0", VA = "0x17ABEA0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BB")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E8E0", Offset = "0x86E8E0")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E8F0", Offset = "0x86E8F0")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000E4")]
			public float sqrMag
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x17AC060", Offset = "0x17AC060", VA = "0x17AC060")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875130", Offset = "0x875130")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x17AC068", Offset = "0x17AC068", VA = "0x17AC068")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875140", Offset = "0x875140")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E5")]
			public float mag
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x17AA70C", Offset = "0x17AA70C", VA = "0x17AA70C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875150", Offset = "0x875150")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x17AC070", Offset = "0x17AC070", VA = "0x17AC070")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875160", Offset = "0x875160")]
				private set
				{
				}
			}

			[Token(Token = "0x60007A0")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x60007A1")]
			public abstract void PreSolve();

			[Token(Token = "0x60007A2")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x60007A3")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x60007A4")]
			public abstract void ResetOffsets();

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x17AC078", Offset = "0x17AC078", VA = "0x17AC078")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x17AC704", Offset = "0x17AC704", VA = "0x17AC704")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x17AC89C", Offset = "0x17AC89C", VA = "0x17AC89C")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x17ACC24", Offset = "0x17ACC24", VA = "0x17ACC24")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x17ACC78", Offset = "0x17ACC78", VA = "0x17ACC78")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x17AB774", Offset = "0x17AB774", VA = "0x17AB774")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x17ACE70", Offset = "0x17ACE70", VA = "0x17ACE70")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x17AD010", Offset = "0x17AD010", VA = "0x17AD010")]
			public void Visualize()
			{
			}

			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x17ABFC8", Offset = "0x17ABFC8", VA = "0x17ABFC8")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public class Footstep
		{
			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E910", Offset = "0x86E910")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000E6")]
			public bool isStepping
			{
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x17AD038", Offset = "0x17AD038", VA = "0x17AD038")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E7")]
			public float stepProgress
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x17AD04C", Offset = "0x17AD04C", VA = "0x17AD04C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875170", Offset = "0x875170")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x17AD054", Offset = "0x17AD054", VA = "0x17AD054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875180", Offset = "0x875180")]
				private set
				{
				}
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x17AD05C", Offset = "0x17AD05C", VA = "0x17AD05C")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x17AD1F0", Offset = "0x17AD1F0", VA = "0x17AD1F0")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x17AD238", Offset = "0x17AD238", VA = "0x17AD238")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x17AD344", Offset = "0x17AD344", VA = "0x17AD344")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x17AD51C", Offset = "0x17AD51C", VA = "0x17AD51C")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x17AD708", Offset = "0x17AD708", VA = "0x17AD708")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E920", Offset = "0x86E920")]
			public Transform target;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E958", Offset = "0x86E958")]
			public Transform bendGoal;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E990", Offset = "0x86E990")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E990", Offset = "0x86E990")]
			public float positionWeight;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86E9E4", Offset = "0x86E9E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86E9E4", Offset = "0x86E9E4")]
			public float rotationWeight;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EA38", Offset = "0x86EA38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EA38", Offset = "0x86EA38")]
			public float bendGoalWeight;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EA8C", Offset = "0x86EA8C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EA8C", Offset = "0x86EA8C")]
			public float swivelOffset;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EAE8", Offset = "0x86EAE8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EAE8", Offset = "0x86EAE8")]
			public float bendToTargetWeight;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EB3C", Offset = "0x86EB3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EB3C", Offset = "0x86EB3C")]
			public float legLengthMlp;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EB94", Offset = "0x86EB94")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EC2C", Offset = "0x86EC2C")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EC3C", Offset = "0x86EC3C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EC4C", Offset = "0x86EC4C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86EC5C", Offset = "0x86EC5C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Quaternion footRotation;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 bendNormal;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000E8")]
			public Vector3 position
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0x17AD928", Offset = "0x17AD928", VA = "0x17AD928")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875190", Offset = "0x875190")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x17AD934", Offset = "0x17AD934", VA = "0x17AD934")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751A0", Offset = "0x8751A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public Quaternion rotation
			{
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0x17AD940", Offset = "0x17AD940", VA = "0x17AD940")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751B0", Offset = "0x8751B0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x17AD94C", Offset = "0x17AD94C", VA = "0x17AD94C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751C0", Offset = "0x8751C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EA")]
			public bool hasToes
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x17AD958", Offset = "0x17AD958", VA = "0x17AD958")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751D0", Offset = "0x8751D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x17AD960", Offset = "0x17AD960", VA = "0x17AD960")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751E0", Offset = "0x8751E0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			public VirtualBone thigh
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x17AD96C", Offset = "0x17AD96C", VA = "0x17AD96C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EC")]
			private VirtualBone calf
			{
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x17AD9B0", Offset = "0x17AD9B0", VA = "0x17AD9B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000ED")]
			private VirtualBone foot
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x17AD9F8", Offset = "0x17AD9F8", VA = "0x17AD9F8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			private VirtualBone toes
			{
				[Token(Token = "0x60007C4")]
				[Address(RVA = "0x17ADA40", Offset = "0x17ADA40", VA = "0x17ADA40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x17ADA88", Offset = "0x17ADA88", VA = "0x17ADA88")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x17ADAE4", Offset = "0x17ADAE4", VA = "0x17ADAE4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8751F0", Offset = "0x8751F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x17ADAF0", Offset = "0x17ADAF0", VA = "0x17ADAF0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875200", Offset = "0x875200")]
				private set
				{
				}
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x17ADAFC", Offset = "0x17ADAFC", VA = "0x17ADAFC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x17AE30C", Offset = "0x17AE30C", VA = "0x17AE30C", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x17AEBA0", Offset = "0x17AEBA0", VA = "0x17AEBA0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x17AEA9C", Offset = "0x17AEA9C", VA = "0x17AEA9C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x17AE864", Offset = "0x17AE864", VA = "0x17AE864")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x17AF1B8", Offset = "0x17AF1B8", VA = "0x17AF1B8")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x17AF810", Offset = "0x17AF810", VA = "0x17AF810")]
			private void Stretching()
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x17AFDF4", Offset = "0x17AFDF4", VA = "0x17AFDF4", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x17B013C", Offset = "0x17B013C", VA = "0x17B013C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x17B01EC", Offset = "0x17B01EC", VA = "0x17B01EC")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public class Locomotion
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EC6C", Offset = "0x86EC6C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EC6C", Offset = "0x86EC6C")]
			public float weight;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ECC0", Offset = "0x86ECC0")]
			public float footDistance;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ECF8", Offset = "0x86ECF8")]
			public float stepThreshold;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ED30", Offset = "0x86ED30")]
			public float angleThreshold;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86ED68", Offset = "0x86ED68")]
			public float comAngleMlp;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EDA0", Offset = "0x86EDA0")]
			public float maxVelocity;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EDD8", Offset = "0x86EDD8")]
			public float velocityFactor;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EE10", Offset = "0x86EE10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EE10", Offset = "0x86EE10")]
			public float maxLegStretch;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EE68", Offset = "0x86EE68")]
			public float rootSpeed;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EEA0", Offset = "0x86EEA0")]
			public float stepSpeed;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EED8", Offset = "0x86EED8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EF10", Offset = "0x86EF10")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EF48", Offset = "0x86EF48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86EF48", Offset = "0x86EF48")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EFA0", Offset = "0x86EFA0")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86EFD8", Offset = "0x86EFD8")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F010", Offset = "0x86F010")]
			public Vector3 offset;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F088", Offset = "0x86F088")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F0C0", Offset = "0x86F0C0")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86F0F8", Offset = "0x86F0F8")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000F1")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x60007D2")]
				[Address(RVA = "0x17B02E0", Offset = "0x17B02E0", VA = "0x17B02E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875210", Offset = "0x875210")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x17B02EC", Offset = "0x17B02EC", VA = "0x17B02EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875220", Offset = "0x875220")]
				private set
				{
				}
			}

			[Token(Token = "0x170000F2")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60007D9")]
				[Address(RVA = "0x17B306C", Offset = "0x17B306C", VA = "0x17B306C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F3")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60007DA")]
				[Address(RVA = "0x17B30C4", Offset = "0x17B30C4", VA = "0x17B30C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000F4")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60007DB")]
				[Address(RVA = "0x17B3120", Offset = "0x17B3120", VA = "0x17B3120")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000F5")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0x17B3178", Offset = "0x17B3178", VA = "0x17B3178")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x17B02F8", Offset = "0x17B02F8", VA = "0x17B02F8")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x17B06E0", Offset = "0x17B06E0", VA = "0x17B06E0")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x17B0AA0", Offset = "0x17B0AA0", VA = "0x17B0AA0")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x17B0E84", Offset = "0x17B0E84", VA = "0x17B0E84")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x17B1040", Offset = "0x17B1040", VA = "0x17B1040")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x17B2C54", Offset = "0x17B2C54", VA = "0x17B2C54")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x17B2DF8", Offset = "0x17B2DF8", VA = "0x17B2DF8")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x17B2EA0", Offset = "0x17B2EA0", VA = "0x17B2EA0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x17B31D4", Offset = "0x17B31D4", VA = "0x17B31D4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F108", Offset = "0x86F108")]
			public Transform headTarget;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F140", Offset = "0x86F140")]
			public Transform pelvisTarget;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F178", Offset = "0x86F178")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F178", Offset = "0x86F178")]
			public float positionWeight;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F1CC", Offset = "0x86F1CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F1CC", Offset = "0x86F1CC")]
			public float rotationWeight;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F220", Offset = "0x86F220")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F220", Offset = "0x86F220")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F274", Offset = "0x86F274")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F274", Offset = "0x86F274")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F2C8", Offset = "0x86F2C8")]
			public Transform chestGoal;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F300", Offset = "0x86F300")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F300", Offset = "0x86F300")]
			public float chestGoalWeight;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F354", Offset = "0x86F354")]
			public float minHeadHeight;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F38C", Offset = "0x86F38C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F38C", Offset = "0x86F38C")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F3E0", Offset = "0x86F3E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F3E0", Offset = "0x86F3E0")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F434", Offset = "0x86F434")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86F434", Offset = "0x86F434")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F434", Offset = "0x86F434")]
			public float neckStiffness;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F4AC", Offset = "0x86F4AC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F4AC", Offset = "0x86F4AC")]
			public float rotateChestByHands;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F500", Offset = "0x86F500")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F500", Offset = "0x86F500")]
			public float chestClampWeight;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F554", Offset = "0x86F554")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F554", Offset = "0x86F554")]
			public float headClampWeight;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F5A8", Offset = "0x86F5A8")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F5E0", Offset = "0x86F5E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F5E0", Offset = "0x86F5E0")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F634", Offset = "0x86F634")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86F634", Offset = "0x86F634")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86F76C", Offset = "0x86F76C")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			private Quaternion headRotation;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
			private int pelvisIndex;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int spineIndex;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int chestIndex;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int neckIndex;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int headIndex;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private float length;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private bool hasChest;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20D")]
			private bool hasNeck;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20E")]
			private bool hasLegs;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private float headHeight;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float sizeMlp;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private Vector3 chestForward;

			[Token(Token = "0x170000F6")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x17B2BB4", Offset = "0x17B2BB4", VA = "0x17B2BB4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F7")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60007E2")]
				[Address(RVA = "0x17B32BC", Offset = "0x17B32BC", VA = "0x17B32BC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F8")]
			public VirtualBone chest
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x17B330C", Offset = "0x17B330C", VA = "0x17B330C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F9")]
			private VirtualBone neck
			{
				[Token(Token = "0x60007E4")]
				[Address(RVA = "0x17B3374", Offset = "0x17B3374", VA = "0x17B3374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FA")]
			public VirtualBone head
			{
				[Token(Token = "0x60007E5")]
				[Address(RVA = "0x17B2C04", Offset = "0x17B2C04", VA = "0x17B2C04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FB")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60007E6")]
				[Address(RVA = "0x17B33C4", Offset = "0x17B33C4", VA = "0x17B33C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875230", Offset = "0x875230")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x17B33D8", Offset = "0x17B33D8", VA = "0x17B33D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875240", Offset = "0x875240")]
				private set
				{
				}
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x17B33EC", Offset = "0x17B33EC", VA = "0x17B33EC", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x17B4240", Offset = "0x17B4240", VA = "0x17B4240", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x17B44A0", Offset = "0x17B44A0", VA = "0x17B44A0", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x17B4A60", Offset = "0x17B4A60", VA = "0x17B4A60")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x17B504C", Offset = "0x17B504C", VA = "0x17B504C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x17B5A44", Offset = "0x17B5A44", VA = "0x17B5A44")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp)
			{
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x17B6360", Offset = "0x17B6360", VA = "0x17B6360")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x17B6D50", Offset = "0x17B6D50", VA = "0x17B6D50", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x17B70CC", Offset = "0x17B70CC", VA = "0x17B70CC", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x17B4C94", Offset = "0x17B4C94", VA = "0x17B4C94")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x17B5F48", Offset = "0x17B5F48", VA = "0x17B5F48")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x17B5630", Offset = "0x17B5630", VA = "0x17B5630")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x17B71C4", Offset = "0x17B71C4", VA = "0x17B71C4")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x17B60C0", Offset = "0x17B60C0", VA = "0x17B60C0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x17B5C54", Offset = "0x17B5C54", VA = "0x17B5C54")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x17B7574", Offset = "0x17B7574", VA = "0x17B7574")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C0")]
		public enum PositionOffset
		{
			[Token(Token = "0x40005C2")]
			Pelvis,
			[Token(Token = "0x40005C3")]
			Chest,
			[Token(Token = "0x40005C4")]
			Head,
			[Token(Token = "0x40005C5")]
			LeftHand,
			[Token(Token = "0x40005C6")]
			RightHand,
			[Token(Token = "0x40005C7")]
			LeftFoot,
			[Token(Token = "0x40005C8")]
			RightFoot,
			[Token(Token = "0x40005C9")]
			LeftHeel,
			[Token(Token = "0x40005CA")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000C1")]
		public enum RotationOffset
		{
			[Token(Token = "0x40005CC")]
			Pelvis,
			[Token(Token = "0x40005CD")]
			Chest,
			[Token(Token = "0x40005CE")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000C2")]
		public class VirtualBone
		{
			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x17A8904", Offset = "0x17A8904", VA = "0x17A8904")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x17A8980", Offset = "0x17A8980", VA = "0x17A8980")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x17B7740", Offset = "0x17B7740", VA = "0x17B7740")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x17AC1C0", Offset = "0x17AC1C0", VA = "0x17AC1C0")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x17AC998", Offset = "0x17AC998", VA = "0x17AC998")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x17B7A7C", Offset = "0x17B7A7C", VA = "0x17B7A7C")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x17AA714", Offset = "0x17AA714", VA = "0x17AA714")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x17B7D84", Offset = "0x17B7D84", VA = "0x17B7D84")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0x17AB050", Offset = "0x17AB050", VA = "0x17AB050")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x6000801")]
			[Address(RVA = "0x17B7E84", Offset = "0x17B7E84", VA = "0x17B7E84")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x17B66F0", Offset = "0x17B66F0", VA = "0x17B66F0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x17B809C", Offset = "0x17B809C", VA = "0x17B809C")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x17B81A4", Offset = "0x17B81A4", VA = "0x17B81A4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C5D0", Offset = "0x86C5D0")]
		public bool plantFeet;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C608", Offset = "0x86C608")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C618", Offset = "0x86C618")]
		public Spine spine;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C650", Offset = "0x86C650")]
		public Arm leftArm;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C688", Offset = "0x86C688")]
		public Arm rightArm;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C6C0", Offset = "0x86C6C0")]
		public Leg leftLeg;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C6F8", Offset = "0x86C6F8")]
		public Leg rightLeg;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C730", Offset = "0x86C730")]
		public Locomotion locomotion;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Leg[] legs;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Arm[] arms;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 headPosition;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private Vector3 lastOffset;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 debugPos1;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 debugPos2;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 debugPos3;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000058")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x15E5444", Offset = "0x15E5444", VA = "0x15E5444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873724", Offset = "0x873724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x15E7DA0", Offset = "0x15E7DA0", VA = "0x15E7DA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873734", Offset = "0x873734")]
			private set
			{
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x15E323C", Offset = "0x15E323C", VA = "0x15E323C")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x15E37BC", Offset = "0x15E37BC", VA = "0x15E37BC")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x15E35D8", Offset = "0x15E35D8", VA = "0x15E35D8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x15E43C0", Offset = "0x15E43C0", VA = "0x15E43C0")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x15E455C", Offset = "0x15E455C", VA = "0x15E455C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x15E4600", Offset = "0x15E4600", VA = "0x15E4600")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x15E47A8", Offset = "0x15E47A8", VA = "0x15E47A8")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x15E4964", Offset = "0x15E4964", VA = "0x15E4964")]
		public void Reset()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x15E544C", Offset = "0x15E544C", VA = "0x15E544C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x15E5680", Offset = "0x15E5680", VA = "0x15E5680", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x15E58E4", Offset = "0x15E58E4", VA = "0x15E58E4", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x15E5958", Offset = "0x15E5958", VA = "0x15E5958", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x15E59CC", Offset = "0x15E59CC", VA = "0x15E59CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x15E5BFC", Offset = "0x15E5BFC", VA = "0x15E5BFC")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x15E3B7C", Offset = "0x15E3B7C", VA = "0x15E3B7C")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x15E3D6C", Offset = "0x15E3D6C", VA = "0x15E3D6C")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x15E4248", Offset = "0x15E4248", VA = "0x15E4248")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x15E4B20", Offset = "0x15E4B20", VA = "0x15E4B20")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x15E5F40", Offset = "0x15E5F40", VA = "0x15E5F40", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x15E5F88", Offset = "0x15E5F88", VA = "0x15E5F88", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x15E78F0", Offset = "0x15E78F0", VA = "0x15E78F0")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x15E4D44", Offset = "0x15E4D44", VA = "0x15E4D44")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x15E6004", Offset = "0x15E6004", VA = "0x15E6004")]
		private void Solve()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x15E7CEC", Offset = "0x15E7CEC", VA = "0x15E7CEC")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x15E7D48", Offset = "0x15E7D48", VA = "0x15E7D48")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x15E7714", Offset = "0x15E7714", VA = "0x15E7714")]
		private void Write()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x15E7DA8", Offset = "0x15E7DA8", VA = "0x15E7DA8")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x15E84C0", Offset = "0x15E84C0", VA = "0x15E84C0")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C768", Offset = "0x86C768")]
		public Transform parent;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C7A0", Offset = "0x86C7A0")]
		public Transform child;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C7D8", Offset = "0x86C7D8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C7D8", Offset = "0x86C7D8")]
		public float weight;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C82C", Offset = "0x86C82C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C82C", Offset = "0x86C82C")]
		public float parentChildCrossfade;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C880", Offset = "0x86C880")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86C880", Offset = "0x86C880")]
		public float twistAngleOffset;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 twistAxis;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 axis;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1CBED20", Offset = "0x1CBED20", VA = "0x1CBED20")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1CBF164", Offset = "0x1CBF164", VA = "0x1CBF164")]
		private void Start()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1CBF6D8", Offset = "0x1CBF6D8", VA = "0x1CBF6D8")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1CBF760", Offset = "0x1CBF760", VA = "0x1CBF760")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1CBF7E8", Offset = "0x1CBF7E8", VA = "0x1CBF7E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1CBF954", Offset = "0x1CBF954", VA = "0x1CBF954")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class InteractionEffector
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C8DC", Offset = "0x86C8DC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C8EC", Offset = "0x86C8EC")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86C8FC", Offset = "0x86C8FC")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000059")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x17B8BD4", Offset = "0x17B8BD4", VA = "0x17B8BD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873744", Offset = "0x873744")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x17B8BDC", Offset = "0x17B8BDC", VA = "0x17B8BDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873754", Offset = "0x873754")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool isPaused
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x17B8BE4", Offset = "0x17B8BE4", VA = "0x17B8BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873764", Offset = "0x873764")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x17B8BEC", Offset = "0x17B8BEC", VA = "0x17B8BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873774", Offset = "0x873774")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x17B8BF8", Offset = "0x17B8BF8", VA = "0x17B8BF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873784", Offset = "0x873784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x17B8C00", Offset = "0x17B8C00", VA = "0x17B8C00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873794", Offset = "0x873794")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public bool inInteraction
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x17B8C08", Offset = "0x17B8C08", VA = "0x17B8C08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		public float progress
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x17BC5EC", Offset = "0x17BC5EC", VA = "0x17BC5EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x17B8C78", Offset = "0x17B8C78", VA = "0x17B8C78")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x17B8CFC", Offset = "0x17B8CFC", VA = "0x17B8CFC")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x17B8DD8", Offset = "0x17B8DD8", VA = "0x17B8DD8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x17B900C", Offset = "0x17B900C", VA = "0x17B900C")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x17B9574", Offset = "0x17B9574", VA = "0x17B9574")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x17B9B98", Offset = "0x17B9B98", VA = "0x17B9B98")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x17B9C24", Offset = "0x17B9C24", VA = "0x17B9C24")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x17BAA40", Offset = "0x17BAA40", VA = "0x17BAA40")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x17BB9A0", Offset = "0x17BB9A0", VA = "0x17BB9A0")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x17BBE64", Offset = "0x17BBE64", VA = "0x17BBE64")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x17BC44C", Offset = "0x17BC44C", VA = "0x17BC44C")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x17BCD40", Offset = "0x17BCD40", VA = "0x17BCD40")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class InteractionLookAt
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C90C", Offset = "0x86C90C")]
		public LookAtIK ik;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C944", Offset = "0x86C944")]
		public float lerpSpeed;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C97C", Offset = "0x86C97C")]
		public float weightSpeed;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x17BD0A8", Offset = "0x17BD0A8", VA = "0x17BD0A8")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x17BD2B4", Offset = "0x17BD2B4", VA = "0x17BD2B4")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x17BD37C", Offset = "0x17BD37C", VA = "0x17BD37C")]
		public void Update()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x17BD638", Offset = "0x17BD638", VA = "0x17BD638")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x17BD7CC", Offset = "0x17BD7CC", VA = "0x17BD7CC")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x17BD8F0", Offset = "0x17BD8F0", VA = "0x17BD8F0")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A0BC", Offset = "0x86A0BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A0BC", Offset = "0x86A0BC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class InteractionEvent
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F77C", Offset = "0x86F77C")]
			public float time;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F7B4", Offset = "0x86F7B4")]
			public bool pause;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F7EC", Offset = "0x86F7EC")]
			public bool pickUp;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F824", Offset = "0x86F824")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F85C", Offset = "0x86F85C")]
			public Message[] messages;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F894", Offset = "0x86F894")]
			public UnityEvent unityEvent;

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x17BC628", Offset = "0x17BC628", VA = "0x17BC628")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x17BF108", Offset = "0x17BF108", VA = "0x17BF108")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Message
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F8CC", Offset = "0x86F8CC")]
			public string function;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F904", Offset = "0x86F904")]
			public GameObject recipient;

			[Token(Token = "0x40005DE")]
			private const string empty = "";

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x17BF00C", Offset = "0x17BF00C", VA = "0x17BF00C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x17BF110", Offset = "0x17BF110", VA = "0x17BF110")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C5")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F93C", Offset = "0x86F93C")]
			public Animator animator;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F974", Offset = "0x86F974")]
			public Animation animation;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F9AC", Offset = "0x86F9AC")]
			public string animationState;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86F9E4", Offset = "0x86F9E4")]
			public float crossfadeTime;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FA1C", Offset = "0x86FA1C")]
			public int layer;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FA54", Offset = "0x86FA54")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40005E5")]
			private const string empty = "";

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x17BECE8", Offset = "0x17BECE8", VA = "0x17BECE8")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x17BEDE4", Offset = "0x17BEDE4", VA = "0x17BEDE4")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x17BEECC", Offset = "0x17BEECC", VA = "0x17BEECC")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x17BEFF8", Offset = "0x17BEFF8", VA = "0x17BEFF8")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C6")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000F6")]
			public enum Type
			{
				[Token(Token = "0x40006C9")]
				PositionWeight,
				[Token(Token = "0x40006CA")]
				RotationWeight,
				[Token(Token = "0x40006CB")]
				PositionOffsetX,
				[Token(Token = "0x40006CC")]
				PositionOffsetY,
				[Token(Token = "0x40006CD")]
				PositionOffsetZ,
				[Token(Token = "0x40006CE")]
				Pull,
				[Token(Token = "0x40006CF")]
				Reach,
				[Token(Token = "0x40006D0")]
				RotateBoneWeight,
				[Token(Token = "0x40006D1")]
				Push,
				[Token(Token = "0x40006D2")]
				PushParent,
				[Token(Token = "0x40006D3")]
				PoserWeight
			}

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FA8C", Offset = "0x86FA8C")]
			public Type type;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FAC4", Offset = "0x86FAC4")]
			public AnimationCurve curve;

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x17BE24C", Offset = "0x17BE24C", VA = "0x17BE24C")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0x17BF128", Offset = "0x17BF128", VA = "0x17BF128")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C7")]
		public class Multiplier
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FAFC", Offset = "0x86FAFC")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FB34", Offset = "0x86FB34")]
			public float multiplier;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FB6C", Offset = "0x86FB6C")]
			public WeightCurve.Type result;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x17BEAF0", Offset = "0x17BEAF0", VA = "0x17BEAF0")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x17BF118", Offset = "0x17BF118", VA = "0x17BF118")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C9C4", Offset = "0x86C9C4")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86C9FC", Offset = "0x86C9FC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CA34", Offset = "0x86CA34")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86CA6C", Offset = "0x86CA6C")]
		private float <length>k__BackingField;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86CA7C", Offset = "0x86CA7C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700005E")]
		public float length
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x17BA424", Offset = "0x17BA424", VA = "0x17BA424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8738F4", Offset = "0x8738F4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x17BDACC", Offset = "0x17BDACC", VA = "0x17BDACC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873904", Offset = "0x873904")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x17BDAD4", Offset = "0x17BDAD4", VA = "0x17BDAD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873914", Offset = "0x873914")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x17BDADC", Offset = "0x17BDADC", VA = "0x17BDADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873924", Offset = "0x873924")]
			private set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x17BDDF4", Offset = "0x17BDDF4", VA = "0x17BDDF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x17BCBE4", Offset = "0x17BCBE4", VA = "0x17BCBE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x17BD904", Offset = "0x17BD904", VA = "0x17BD904")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8737A4", Offset = "0x8737A4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x17BD950", Offset = "0x17BD950", VA = "0x17BD950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8737DC", Offset = "0x8737DC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x17BD99C", Offset = "0x17BD99C", VA = "0x17BD99C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873814", Offset = "0x873814")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x17BD9E8", Offset = "0x17BD9E8", VA = "0x17BD9E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87384C", Offset = "0x87384C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x17BDA34", Offset = "0x17BDA34", VA = "0x17BDA34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873884", Offset = "0x873884")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x17BDA80", Offset = "0x17BDA80", VA = "0x17BDA80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8738BC", Offset = "0x8738BC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x17BDAE4", Offset = "0x17BDAE4", VA = "0x17BDAE4")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x17BDE84", Offset = "0x17BDE84", VA = "0x17BDE84")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x17BA324", Offset = "0x17BA324", VA = "0x17BA324")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x17BE050", Offset = "0x17BE050", VA = "0x17BE050")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x17BA144", Offset = "0x17BA144", VA = "0x17BA144")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x17BA31C", Offset = "0x17BA31C", VA = "0x17BA31C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x17BB330", Offset = "0x17BB330", VA = "0x17BB330")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x17BC124", Offset = "0x17BC124", VA = "0x17BC124")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x17BEB3C", Offset = "0x17BEB3C", VA = "0x17BEB3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x17BE28C", Offset = "0x17BE28C", VA = "0x17BE28C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x17BE058", Offset = "0x17BE058", VA = "0x17BE058")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x17BEA40", Offset = "0x17BEA40", VA = "0x17BEA40")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x17BEB40", Offset = "0x17BEB40", VA = "0x17BEB40")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x17BEBF0", Offset = "0x17BEBF0", VA = "0x17BEBF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873934", Offset = "0x873934")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x17BEC3C", Offset = "0x17BEC3C", VA = "0x17BEC3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x87396C", Offset = "0x87396C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x17BEC88", Offset = "0x17BEC88", VA = "0x17BEC88")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A11C", Offset = "0x86A11C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A11C", Offset = "0x86A11C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000C9")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CA8C", Offset = "0x86CA8C")]
		public string targetTag;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CAC4", Offset = "0x86CAC4")]
		public float fadeInTime;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CAFC", Offset = "0x86CAFC")]
		public float speed;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CB34", Offset = "0x86CB34")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86CB6C", Offset = "0x86CB6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CB6C", Offset = "0x86CB6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86CB6C", Offset = "0x86CB6C")]
		public Collider characterCollider;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CBF0", Offset = "0x86CBF0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x86CBF0", Offset = "0x86CBF0")]
		public Transform FPSCamera;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CC50", Offset = "0x86CC50")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CC88", Offset = "0x86CC88")]
		public float camRaycastDistance;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86CCC0", Offset = "0x86CCC0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x86CCD0", Offset = "0x86CCD0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CCD0", Offset = "0x86CCD0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CD30", Offset = "0x86CD30")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000062")]
		public bool inInteraction
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x17BF2F8", Offset = "0x17BF2F8", VA = "0x17BF2F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x17B8DD0", Offset = "0x17B8DD0", VA = "0x17B8DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x17C1C74", Offset = "0x17C1C74", VA = "0x17C1C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x17C07E4", Offset = "0x17C07E4", VA = "0x17C07E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873AF4", Offset = "0x873AF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x17C1C7C", Offset = "0x17C1C7C", VA = "0x17C1C7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x873B04", Offset = "0x873B04")]
			private set
			{
			}
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x17BF130", Offset = "0x17BF130", VA = "0x17BF130")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8739A4", Offset = "0x8739A4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x17BF17C", Offset = "0x17BF17C", VA = "0x17BF17C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8739DC", Offset = "0x8739DC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x17BF1C8", Offset = "0x17BF1C8", VA = "0x17BF1C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873A14", Offset = "0x873A14")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x17BF214", Offset = "0x17BF214", VA = "0x17BF214")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873A4C", Offset = "0x873A4C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x17BF260", Offset = "0x17BF260", VA = "0x17BF260")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873A84", Offset = "0x873A84")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x17BF2AC", Offset = "0x17BF2AC", VA = "0x17BF2AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873ABC", Offset = "0x873ABC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x17BF4D8", Offset = "0x17BF4D8", VA = "0x17BF4D8")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x17BF630", Offset = "0x17BF630", VA = "0x17BF630")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x17BF788", Offset = "0x17BF788", VA = "0x17BF788")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x17BF884", Offset = "0x17BF884", VA = "0x17BF884")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x17BFA04", Offset = "0x17BFA04", VA = "0x17BFA04")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x17BFBA8", Offset = "0x17BFBA8", VA = "0x17BFBA8")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x17BFCB8", Offset = "0x17BFCB8", VA = "0x17BFCB8")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x17BFDC8", Offset = "0x17BFDC8", VA = "0x17BFDC8")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x17BFED8", Offset = "0x17BFED8", VA = "0x17BFED8")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x17BFF7C", Offset = "0x17BFF7C", VA = "0x17BFF7C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x17C0020", Offset = "0x17C0020", VA = "0x17C0020")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x17C00B8", Offset = "0x17C00B8", VA = "0x17C00B8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x17C01B8", Offset = "0x17C01B8", VA = "0x17C01B8")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x17C02E0", Offset = "0x17C02E0", VA = "0x17C02E0")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x17C0410", Offset = "0x17C0410", VA = "0x17C0410")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x17C07EC", Offset = "0x17C07EC", VA = "0x17C07EC")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x17C0A9C", Offset = "0x17C0A9C", VA = "0x17C0A9C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x17C0E5C", Offset = "0x17C0E5C", VA = "0x17C0E5C")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x17C1200", Offset = "0x17C1200", VA = "0x17C1200")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x17C125C", Offset = "0x17C125C", VA = "0x17C125C")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x17C1354", Offset = "0x17C1354", VA = "0x17C1354")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x17C14CC", Offset = "0x17C14CC", VA = "0x17C14CC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x17C1684", Offset = "0x17C1684", VA = "0x17C1684")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x17C1B1C", Offset = "0x17C1B1C", VA = "0x17C1B1C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x17C0F94", Offset = "0x17C0F94", VA = "0x17C0F94")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x17C1C84", Offset = "0x17C1C84", VA = "0x17C1C84")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x17C25FC", Offset = "0x17C25FC", VA = "0x17C25FC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x17C262C", Offset = "0x17C262C", VA = "0x17C262C")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x17C2658", Offset = "0x17C2658", VA = "0x17C2658")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x17C2684", Offset = "0x17C2684", VA = "0x17C2684")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x17C2708", Offset = "0x17C2708", VA = "0x17C2708")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x17C2840", Offset = "0x17C2840", VA = "0x17C2840")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x17C294C", Offset = "0x17C294C", VA = "0x17C294C")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x17C2D20", Offset = "0x17C2D20", VA = "0x17C2D20")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x17C2E0C", Offset = "0x17C2E0C", VA = "0x17C2E0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x17C30D4", Offset = "0x17C30D4", VA = "0x17C30D4")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x17C233C", Offset = "0x17C233C", VA = "0x17C233C")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x17C3228", Offset = "0x17C3228", VA = "0x17C3228")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x17C33BC", Offset = "0x17C33BC", VA = "0x17C33BC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x17C346C", Offset = "0x17C346C", VA = "0x17C346C")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x17C3594", Offset = "0x17C3594", VA = "0x17C3594")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x17C35C0", Offset = "0x17C35C0", VA = "0x17C35C0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x17BF3F4", Offset = "0x17BF3F4", VA = "0x17BF3F4")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x17C06B4", Offset = "0x17C06B4", VA = "0x17C06B4")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x17C3B28", Offset = "0x17C3B28", VA = "0x17C3B28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873B14", Offset = "0x873B14")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x17C3B74", Offset = "0x17C3B74", VA = "0x17C3B74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873B4C", Offset = "0x873B4C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x17C3BC0", Offset = "0x17C3BC0", VA = "0x17C3BC0")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A17C", Offset = "0x86A17C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A17C", Offset = "0x86A17C")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class Multiplier
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FBA4", Offset = "0x86FBA4")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FBDC", Offset = "0x86FBDC")]
			public float multiplier;

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x17C4470", Offset = "0x17C4470", VA = "0x17C4470")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CD68", Offset = "0x86CD68")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CDA0", Offset = "0x86CDA0")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CDD8", Offset = "0x86CDD8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CE10", Offset = "0x86CE10")]
		public Transform pivot;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CE48", Offset = "0x86CE48")]
		public Vector3 twistAxis;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CE80", Offset = "0x86CE80")]
		public float twistWeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CEB8", Offset = "0x86CEB8")]
		public float swingWeight;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CEF0", Offset = "0x86CEF0")]
		public bool rotateOnce;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x17C4184", Offset = "0x17C4184", VA = "0x17C4184")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873B84", Offset = "0x873B84")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x17C41D0", Offset = "0x17C41D0", VA = "0x17C41D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873BBC", Offset = "0x873BBC")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x17C421C", Offset = "0x17C421C", VA = "0x17C421C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873BF4", Offset = "0x873BF4")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x17C4268", Offset = "0x17C4268", VA = "0x17C4268")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873C2C", Offset = "0x873C2C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x17C42B4", Offset = "0x17C42B4", VA = "0x17C42B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873C64", Offset = "0x873C64")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x17C4300", Offset = "0x17C4300", VA = "0x17C4300")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873C9C", Offset = "0x873C9C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x17BE14C", Offset = "0x17BE14C", VA = "0x17BE14C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x17BCC74", Offset = "0x17BCC74", VA = "0x17BCC74")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x17BA42C", Offset = "0x17BA42C", VA = "0x17BA42C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x17C434C", Offset = "0x17C434C", VA = "0x17C434C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873CD4", Offset = "0x873CD4")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x17C4398", Offset = "0x17C4398", VA = "0x17C4398")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873D0C", Offset = "0x873D0C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x17C43E4", Offset = "0x17C43E4", VA = "0x17C43E4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A1DC", Offset = "0x86A1DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A1DC", Offset = "0x86A1DC")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public class CharacterPosition
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FC14", Offset = "0x86FC14")]
			public bool use;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FC4C", Offset = "0x86FC4C")]
			public Vector2 offset;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FC84", Offset = "0x86FC84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86FC84", Offset = "0x86FC84")]
			public float angleOffset;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FCE0", Offset = "0x86FCE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86FCE0", Offset = "0x86FCE0")]
			public float maxAngle;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FD38", Offset = "0x86FD38")]
			public float radius;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FD70", Offset = "0x86FD70")]
			public bool orbit;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FDA8", Offset = "0x86FDA8")]
			public bool fixYAxis;

			[Token(Token = "0x170000FC")]
			public Vector3 offset3D
			{
				[Token(Token = "0x600081A")]
				[Address(RVA = "0x17C4C44", Offset = "0x17C4C44", VA = "0x17C4C44")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000FD")]
			public Vector3 direction3D
			{
				[Token(Token = "0x600081B")]
				[Address(RVA = "0x17C4C80", Offset = "0x17C4C80", VA = "0x17C4C80")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x17C4D78", Offset = "0x17C4D78", VA = "0x17C4D78")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x17C544C", Offset = "0x17C544C", VA = "0x17C544C")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class CameraPosition
		{
			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FDE0", Offset = "0x86FDE0")]
			public Collider lookAtTarget;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FE18", Offset = "0x86FE18")]
			public Vector3 direction;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FE50", Offset = "0x86FE50")]
			public float maxDistance;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FE88", Offset = "0x86FE88")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86FE88", Offset = "0x86FE88")]
			public float maxAngle;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FEE0", Offset = "0x86FEE0")]
			public bool fixYAxis;

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x17C4700", Offset = "0x17C4700", VA = "0x17C4700")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x17C48D4", Offset = "0x17C48D4", VA = "0x17C48D4")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x17C4BB8", Offset = "0x17C4BB8", VA = "0x17C4BB8")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CD")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000F7")]
			public class Interaction
			{
				[Token(Token = "0x40006D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870F98", Offset = "0x870F98")]
				public InteractionObject interactionObject;

				[Token(Token = "0x40006D5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870FD0", Offset = "0x870FD0")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x60008D6")]
				[Address(RVA = "0x17C5470", Offset = "0x17C5470", VA = "0x17C5470")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FF88", Offset = "0x86FF88")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FFC0", Offset = "0x86FFC0")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86FFF8", Offset = "0x86FFF8")]
			public Interaction[] interactions;

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x17C4560", Offset = "0x17C4560", VA = "0x17C4560")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x17C5460", Offset = "0x17C5460", VA = "0x17C5460")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CF28", Offset = "0x86CF28")]
		public Range[] ranges;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x17C4478", Offset = "0x17C4478", VA = "0x17C4478")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873D44", Offset = "0x873D44")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x17C44C4", Offset = "0x17C44C4", VA = "0x17C44C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873D7C", Offset = "0x873D7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x17C4510", Offset = "0x17C4510", VA = "0x17C4510")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873DB4", Offset = "0x873DB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x17C455C", Offset = "0x17C455C", VA = "0x17C455C")]
		private void Start()
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x17C2B34", Offset = "0x17C2B34", VA = "0x17C2B34")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x17C46A0", Offset = "0x17C46A0", VA = "0x17C46A0")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000CE")]
		public class Map
		{
			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1720F1C", Offset = "0x1720F1C", VA = "0x1720F1C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1721464", Offset = "0x1721464", VA = "0x1721464")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x17213D8", Offset = "0x17213D8", VA = "0x17213D8")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x172112C", Offset = "0x172112C", VA = "0x172112C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1720B8C", Offset = "0x1720B8C", VA = "0x1720B8C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873DEC", Offset = "0x873DEC")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1720FF0", Offset = "0x1720FF0", VA = "0x1720FF0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1720FF4", Offset = "0x1720FF4", VA = "0x1720FF4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1721340", Offset = "0x1721340", VA = "0x1721340", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1720F58", Offset = "0x1720F58", VA = "0x1720F58")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1720E54", Offset = "0x1720E54", VA = "0x1720E54")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x17214C8", Offset = "0x17214C8", VA = "0x17214C8")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x172DA38", Offset = "0x172DA38", VA = "0x172DA38", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x172DAF4", Offset = "0x172DAF4", VA = "0x172DAF4", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x172DD54", Offset = "0x172DD54", VA = "0x172DD54", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x172DEE4", Offset = "0x172DEE4", VA = "0x172DEE4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x172DB50", Offset = "0x172DB50", VA = "0x172DB50")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x172E408", Offset = "0x172E408", VA = "0x172E408")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86CF60", Offset = "0x86CF60")]
		public float weight;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86CF78", Offset = "0x86CF78")]
		public float localRotationWeight;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86CF90", Offset = "0x86CF90")]
		public float localPositionWeight;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x600051A")]
		public abstract void AutoMapping();

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1CB67A4", Offset = "0x1CB67A4", VA = "0x1CB67A4")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x600051C")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x600051D")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x600051E")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1CB67B0", Offset = "0x1CB67B0", VA = "0x1CB67B0", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1CB6804", Offset = "0x1CB6804", VA = "0x1CB6804", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1CB6840", Offset = "0x1CB6840", VA = "0x1CB6840", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1CB6858", Offset = "0x1CB6858", VA = "0x1CB6858")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x86A23C", Offset = "0x86A23C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000CF")]
		public class Rigidbone
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1CB6F48", Offset = "0x1CB6F48", VA = "0x1CB6F48")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1CB7F5C", Offset = "0x1CB7F5C", VA = "0x1CB7F5C")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1CB7CA4", Offset = "0x1CB7CA4", VA = "0x1CB7CA4")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		public class Child
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1CB70E0", Offset = "0x1CB70E0", VA = "0x1CB70E0")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x1CB8134", Offset = "0x1CB8134", VA = "0x1CB8134")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x1CB80D0", Offset = "0x1CB80D0", VA = "0x1CB80D0")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A718", Offset = "0x86A718")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000FE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000830")]
				[Address(RVA = "0x1CB88CC", Offset = "0x1CB88CC", VA = "0x1CB88CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000832")]
				[Address(RVA = "0x1CB893C", Offset = "0x1CB893C", VA = "0x1CB893C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x1CB7150", Offset = "0x1CB7150", VA = "0x1CB7150")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x1CB85A4", Offset = "0x1CB85A4", VA = "0x1CB85A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x1CB85A8", Offset = "0x1CB85A8", VA = "0x1CB85A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000831")]
			[Address(RVA = "0x1CB88D4", Offset = "0x1CB88D4", VA = "0x1CB88D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CFA8", Offset = "0x86CFA8")]
		public IK ik;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86CFE0", Offset = "0x86CFE0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D018", Offset = "0x86D018")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D050", Offset = "0x86D050")]
		public float applyVelocity;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D088", Offset = "0x86D088")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000065")]
		private bool isRagdoll
		{
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x1CB68B8", Offset = "0x1CB68B8", VA = "0x1CB68B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		private bool ikUsed
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1CB76B8", Offset = "0x1CB76B8", VA = "0x1CB76B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1CB6880", Offset = "0x1CB6880", VA = "0x1CB6880")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1CB6958", Offset = "0x1CB6958", VA = "0x1CB6958")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1CB6AA4", Offset = "0x1CB6AA4", VA = "0x1CB6AA4")]
		public void Start()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1CB6A30", Offset = "0x1CB6A30", VA = "0x1CB6A30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x873E24", Offset = "0x873E24")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1CB717C", Offset = "0x1CB717C", VA = "0x1CB717C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1CB7518", Offset = "0x1CB7518", VA = "0x1CB7518")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1CB75E8", Offset = "0x1CB75E8", VA = "0x1CB75E8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1CB787C", Offset = "0x1CB787C", VA = "0x1CB787C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1CB767C", Offset = "0x1CB767C", VA = "0x1CB767C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1CB7838", Offset = "0x1CB7838", VA = "0x1CB7838")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1CB7930", Offset = "0x1CB7930", VA = "0x1CB7930")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1CB78B0", Offset = "0x1CB78B0", VA = "0x1CB78B0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1CB69B0", Offset = "0x1CB69B0", VA = "0x1CB69B0")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1CB7558", Offset = "0x1CB7558", VA = "0x1CB7558")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1CB836C", Offset = "0x1CB836C", VA = "0x1CB836C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1CB84D8", Offset = "0x1CB84D8", VA = "0x1CB84D8")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000067")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x1CBA718", Offset = "0x1CBA718", VA = "0x1CBA718")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000068")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x1CBA754", Offset = "0x1CBA754", VA = "0x1CBA754")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1CBA354", Offset = "0x1CBA354", VA = "0x1CBA354")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1CBA3A0", Offset = "0x1CBA3A0", VA = "0x1CBA3A0")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1CBA630", Offset = "0x1CBA630", VA = "0x1CBA630")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1CBA6E0", Offset = "0x1CBA6E0", VA = "0x1CBA6E0")]
		public void Disable()
		{
		}

		[Token(Token = "0x600053B")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1CBA540", Offset = "0x1CBA540", VA = "0x1CBA540")]
		private void Awake()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1CBA824", Offset = "0x1CBA824", VA = "0x1CBA824")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1CBA828", Offset = "0x1CBA828", VA = "0x1CBA828")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1CBA910", Offset = "0x1CBA910", VA = "0x1CBA910")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1CBA9F4", Offset = "0x1CBA9F4", VA = "0x1CBA9F4")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1CBAC74", Offset = "0x1CBAC74", VA = "0x1CBAC74")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1CBAD30", Offset = "0x1CBAD30", VA = "0x1CBAD30")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A2A0", Offset = "0x86A2A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A2A0", Offset = "0x86A2A0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D0D0", Offset = "0x86D0D0")]
		public float limit;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D0EC", Offset = "0x86D0EC")]
		public float twistLimit;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1CBADA8", Offset = "0x1CBADA8", VA = "0x1CBADA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873E88", Offset = "0x873E88")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1CBADF4", Offset = "0x1CBADF4", VA = "0x1CBADF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873EC0", Offset = "0x873EC0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1CBAE40", Offset = "0x1CBAE40", VA = "0x1CBAE40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873EF8", Offset = "0x873EF8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1CBAE8C", Offset = "0x1CBAE8C", VA = "0x1CBAE8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873F30", Offset = "0x873F30")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1CBAED8", Offset = "0x1CBAED8", VA = "0x1CBAED8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1CBAF90", Offset = "0x1CBAF90", VA = "0x1CBAF90")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1CBB1D8", Offset = "0x1CBB1D8", VA = "0x1CBB1D8")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A300", Offset = "0x86A300")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A300", Offset = "0x86A300")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x1CBB1E8", Offset = "0x1CBB1E8", VA = "0x1CBB1E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873F68", Offset = "0x873F68")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1CBB234", Offset = "0x1CBB234", VA = "0x1CBB234")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873FA0", Offset = "0x873FA0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1CBB280", Offset = "0x1CBB280", VA = "0x1CBB280")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x873FD8", Offset = "0x873FD8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1CBB2CC", Offset = "0x1CBB2CC", VA = "0x1CBB2CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874010", Offset = "0x874010")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1CBB318", Offset = "0x1CBB318", VA = "0x1CBB318", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1CBB340", Offset = "0x1CBB340", VA = "0x1CBB340")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1CBB640", Offset = "0x1CBB640", VA = "0x1CBB640")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A360", Offset = "0x86A360")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A360", Offset = "0x86A360")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000D2")]
		public class ReachCone
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x17000100")]
			public Vector3 o
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x1CBDB28", Offset = "0x1CBDB28", VA = "0x1CBDB28")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000101")]
			public Vector3 a
			{
				[Token(Token = "0x6000834")]
				[Address(RVA = "0x1CBDB70", Offset = "0x1CBDB70", VA = "0x1CBDB70")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000102")]
			public Vector3 b
			{
				[Token(Token = "0x6000835")]
				[Address(RVA = "0x1CBDBBC", Offset = "0x1CBDBBC", VA = "0x1CBDBBC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000103")]
			public Vector3 c
			{
				[Token(Token = "0x6000836")]
				[Address(RVA = "0x1CBDC08", Offset = "0x1CBDC08", VA = "0x1CBDC08")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000104")]
			public bool isValid
			{
				[Token(Token = "0x6000838")]
				[Address(RVA = "0x1CBCA64", Offset = "0x1CBCA64", VA = "0x1CBCA64")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000837")]
			[Address(RVA = "0x1CBD20C", Offset = "0x1CBD20C", VA = "0x1CBD20C")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0x1CBD3BC", Offset = "0x1CBD3BC", VA = "0x1CBD3BC")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D3")]
		public class LimitPoint
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x1CBCA74", Offset = "0x1CBCA74", VA = "0x1CBCA74")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D118", Offset = "0x86D118")]
		public float twistLimit;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D134", Offset = "0x86D134")]
		public int smoothIterations;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1CBB6C8", Offset = "0x1CBB6C8", VA = "0x1CBB6C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874048", Offset = "0x874048")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1CBB714", Offset = "0x1CBB714", VA = "0x1CBB714")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874080", Offset = "0x874080")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1CBB760", Offset = "0x1CBB760", VA = "0x1CBB760")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8740B8", Offset = "0x8740B8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1CBB7AC", Offset = "0x1CBB7AC", VA = "0x1CBB7AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8740F0", Offset = "0x8740F0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1CBB7F8", Offset = "0x1CBB7F8", VA = "0x1CBB7F8")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1CBBE30", Offset = "0x1CBBE30", VA = "0x1CBBE30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1CBBF2C", Offset = "0x1CBBF2C", VA = "0x1CBBF2C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1CBC5F0", Offset = "0x1CBC5F0", VA = "0x1CBC5F0")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1CBB898", Offset = "0x1CBB898", VA = "0x1CBB898")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1CBCAF8", Offset = "0x1CBCAF8", VA = "0x1CBCAF8")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x1CBD57C", Offset = "0x1CBD57C", VA = "0x1CBD57C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1CBD5C0", Offset = "0x1CBD5C0", VA = "0x1CBD5C0")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1CBD708", Offset = "0x1CBD708", VA = "0x1CBD708")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1CBC288", Offset = "0x1CBC288", VA = "0x1CBC288")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1CBD898", Offset = "0x1CBD898", VA = "0x1CBD898")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1CBDAC4", Offset = "0x1CBDAC4", VA = "0x1CBDAC4")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x86A3C0", Offset = "0x86A3C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A3C0", Offset = "0x86A3C0")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D1F4", Offset = "0x86D1F4")]
		public float twistLimit;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1CBDC54", Offset = "0x1CBDC54", VA = "0x1CBDC54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874128", Offset = "0x874128")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1CBDCA0", Offset = "0x1CBDCA0", VA = "0x1CBDCA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874160", Offset = "0x874160")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1CBDCEC", Offset = "0x1CBDCEC", VA = "0x1CBDCEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x874198", Offset = "0x874198")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1CBDD38", Offset = "0x1CBDD38", VA = "0x1CBDD38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x8741D0", Offset = "0x8741D0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1CBDD84", Offset = "0x1CBDD84", VA = "0x1CBDD84")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1CBDDBC", Offset = "0x1CBDDBC", VA = "0x1CBDDBC", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1CBDE74", Offset = "0x1CBDE74", VA = "0x1CBDE74")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1CBE1AC", Offset = "0x1CBE1AC", VA = "0x1CBE1AC")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A728", Offset = "0x86A728")]
		private sealed class <TurnToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083E")]
				[Address(RVA = "0x134281C", Offset = "0x134281C", VA = "0x134281C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000840")]
				[Address(RVA = "0x134288C", Offset = "0x134288C", VA = "0x134288C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x13425A8", Offset = "0x13425A8", VA = "0x13425A8")]
			[DebuggerHidden]
			public <TurnToTarget>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x13426A0", Offset = "0x13426A0", VA = "0x13426A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x13426A4", Offset = "0x13426A4", VA = "0x13426A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1342824", Offset = "0x1342824", VA = "0x1342824", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D248", Offset = "0x86D248")]
		public AimIK ik;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D280", Offset = "0x86D280")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D280", Offset = "0x86D280")]
		public float weight;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86D2D4", Offset = "0x86D2D4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D2D4", Offset = "0x86D2D4")]
		public Transform target;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D334", Offset = "0x86D334")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D36C", Offset = "0x86D36C")]
		public float weightSmoothTime;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86D3A4", Offset = "0x86D3A4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D3A4", Offset = "0x86D3A4")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D404", Offset = "0x86D404")]
		public float maxRadiansDelta;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D43C", Offset = "0x86D43C")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D474", Offset = "0x86D474")]
		public float slerpSpeed;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D4AC", Offset = "0x86D4AC")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D4E4", Offset = "0x86D4E4")]
		public float minDistance;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D51C", Offset = "0x86D51C")]
		public Vector3 offset;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86D554", Offset = "0x86D554")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D554", Offset = "0x86D554")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D554", Offset = "0x86D554")]
		public float maxRootAngle;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D5D0", Offset = "0x86D5D0")]
		public bool turnToTarget;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D608", Offset = "0x86D608")]
		public float turnToTargetTime;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86D640", Offset = "0x86D640")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D640", Offset = "0x86D640")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D6A0", Offset = "0x86D6A0")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x17000069")]
		private Vector3 pivot
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x13414E8", Offset = "0x13414E8", VA = "0x13414E8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x13413B8", Offset = "0x13413B8", VA = "0x13413B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1341660", Offset = "0x1341660", VA = "0x1341660")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1341F64", Offset = "0x1341F64", VA = "0x1341F64")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1342130", Offset = "0x1342130", VA = "0x1342130")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1342534", Offset = "0x1342534", VA = "0x1342534")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x874208", Offset = "0x874208")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x13425D4", Offset = "0x13425D4", VA = "0x13425D4")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Pose
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1342BE0", Offset = "0x1342BE0", VA = "0x1342BE0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1342F74", Offset = "0x1342F74", VA = "0x1342F74")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1342FE4", Offset = "0x1342FE4", VA = "0x1342FE4")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1342A80", Offset = "0x1342A80", VA = "0x1342A80")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1342E7C", Offset = "0x1342E7C", VA = "0x1342E7C")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1342F7C", Offset = "0x1342F7C", VA = "0x1342F7C")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000F8")]
			public class EffectorLink
			{
				[Token(Token = "0x40006D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871008", Offset = "0x871008")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871040", Offset = "0x871040")]
				public float weight;

				[Token(Token = "0x60008D7")]
				[Address(RVA = "0x13436E0", Offset = "0x13436E0", VA = "0x13436E0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870030", Offset = "0x870030")]
			public Transform transform;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870068", Offset = "0x870068")]
			public Transform relativeTo;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8700A0", Offset = "0x8700A0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8700D8", Offset = "0x8700D8")]
			public float verticalWeight;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870110", Offset = "0x870110")]
			public float horizontalWeight;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870148", Offset = "0x870148")]
			public float speed;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1343160", Offset = "0x1343160", VA = "0x1343160")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x13436B8", Offset = "0x13436B8", VA = "0x13436B8")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x13436C8", Offset = "0x13436C8", VA = "0x13436C8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D6D8", Offset = "0x86D6D8")]
		public Body[] bodies;

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1343000", Offset = "0x1343000", VA = "0x1343000", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x13436B0", Offset = "0x13436B0", VA = "0x13436B0")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D710", Offset = "0x86D710")]
		public float tiltSpeed;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D748", Offset = "0x86D748")]
		public float tiltSensitivity;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D780", Offset = "0x86D780")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D7B8", Offset = "0x86D7B8")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1344FAC", Offset = "0x1344FAC", VA = "0x1344FAC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1344FFC", Offset = "0x1344FFC", VA = "0x1344FFC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1345268", Offset = "0x1345268", VA = "0x1345268")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public abstract class HitPoint
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870180", Offset = "0x870180")]
			public string name;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8701B8", Offset = "0x8701B8")]
			public Collider collider;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8701F0", Offset = "0x8701F0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87023C", Offset = "0x87023C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87024C", Offset = "0x87024C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87025C", Offset = "0x87025C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x87026C", Offset = "0x87026C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000107")]
			public bool inProgress
			{
				[Token(Token = "0x6000847")]
				[Address(RVA = "0x172E50C", Offset = "0x172E50C", VA = "0x172E50C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000108")]
			protected float crossFader
			{
				[Token(Token = "0x6000848")]
				[Address(RVA = "0x172EB44", Offset = "0x172EB44", VA = "0x172EB44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8752F0", Offset = "0x8752F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x172EB4C", Offset = "0x172EB4C", VA = "0x172EB4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875300", Offset = "0x875300")]
				private set
				{
				}
			}

			[Token(Token = "0x17000109")]
			protected float timer
			{
				[Token(Token = "0x600084A")]
				[Address(RVA = "0x172EB3C", Offset = "0x172EB3C", VA = "0x172EB3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875310", Offset = "0x875310")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x172EB54", Offset = "0x172EB54", VA = "0x172EB54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875320", Offset = "0x875320")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010A")]
			protected Vector3 force
			{
				[Token(Token = "0x600084C")]
				[Address(RVA = "0x172EB5C", Offset = "0x172EB5C", VA = "0x172EB5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875330", Offset = "0x875330")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600084D")]
				[Address(RVA = "0x172EB68", Offset = "0x172EB68", VA = "0x172EB68")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875340", Offset = "0x875340")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010B")]
			protected Vector3 point
			{
				[Token(Token = "0x600084E")]
				[Address(RVA = "0x172EB74", Offset = "0x172EB74", VA = "0x172EB74")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875350", Offset = "0x875350")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600084F")]
				[Address(RVA = "0x172EB80", Offset = "0x172EB80", VA = "0x172EB80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875360", Offset = "0x875360")]
				private set
				{
				}
			}

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x172EA08", Offset = "0x172EA08", VA = "0x172EA08")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x172E654", Offset = "0x172E654", VA = "0x172E654")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000852")]
			protected abstract float GetLength();

			[Token(Token = "0x6000853")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000854")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x172EB8C", Offset = "0x172EB8C", VA = "0x172EB8C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D8")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000F9")]
			public class EffectorLink
			{
				[Token(Token = "0x40006D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871078", Offset = "0x871078")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8710B0", Offset = "0x8710B0")]
				public float weight;

				[Token(Token = "0x40006DA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006DB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60008D8")]
				[Address(RVA = "0x172F6E0", Offset = "0x172F6E0", VA = "0x172F6E0")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x172F47C", Offset = "0x172F47C", VA = "0x172F47C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008DA")]
				[Address(RVA = "0x172F840", Offset = "0x172F840", VA = "0x172F840")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87027C", Offset = "0x87027C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8702B4", Offset = "0x8702B4")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8702EC", Offset = "0x8702EC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x172F1F4", Offset = "0x172F1F4", VA = "0x172F1F4", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x172F3F4", Offset = "0x172F3F4", VA = "0x172F3F4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x172F490", Offset = "0x172F490", VA = "0x172F490", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x172F82C", Offset = "0x172F82C", VA = "0x172F82C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D9")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000FA")]
			public class BoneLink
			{
				[Token(Token = "0x40006DC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8710E8", Offset = "0x8710E8")]
				public Transform bone;

				[Token(Token = "0x40006DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871120", Offset = "0x871120")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x871120", Offset = "0x871120")]
				public float weight;

				[Token(Token = "0x40006DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40006DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x60008DB")]
				[Address(RVA = "0x172EFCC", Offset = "0x172EFCC", VA = "0x172EFCC")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60008DC")]
				[Address(RVA = "0x172ED0C", Offset = "0x172ED0C", VA = "0x172ED0C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008DD")]
				[Address(RVA = "0x172F16C", Offset = "0x172F16C", VA = "0x172F16C")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870324", Offset = "0x870324")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87035C", Offset = "0x87035C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x172EBA0", Offset = "0x172EBA0", VA = "0x172EBA0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x172EC7C", Offset = "0x172EC7C", VA = "0x172EC7C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x172ED28", Offset = "0x172ED28", VA = "0x172ED28", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x172F158", Offset = "0x172F158", VA = "0x172F158")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D7F0", Offset = "0x86D7F0")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D828", Offset = "0x86D828")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x1700006A")]
		public bool inProgress
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x172E410", Offset = "0x172E410", VA = "0x172E410")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x172E520", Offset = "0x172E520", VA = "0x172E520", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x172E7A0", Offset = "0x172E7A0", VA = "0x172E7A0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x172EB34", Offset = "0x172EB34", VA = "0x172EB34")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public abstract class Offset
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870394", Offset = "0x870394")]
			public string name;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8703CC", Offset = "0x8703CC")]
			public Collider collider;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870404", Offset = "0x870404")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870450", Offset = "0x870450")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870460", Offset = "0x870460")]
			private float <timer>k__BackingField;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870470", Offset = "0x870470")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x870480", Offset = "0x870480")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700010C")]
			protected float crossFader
			{
				[Token(Token = "0x600085E")]
				[Address(RVA = "0x172FE78", Offset = "0x172FE78", VA = "0x172FE78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875370", Offset = "0x875370")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600085F")]
				[Address(RVA = "0x172FE80", Offset = "0x172FE80", VA = "0x172FE80")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875380", Offset = "0x875380")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010D")]
			protected float timer
			{
				[Token(Token = "0x6000860")]
				[Address(RVA = "0x172FE88", Offset = "0x172FE88", VA = "0x172FE88")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x875390", Offset = "0x875390")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x172FE90", Offset = "0x172FE90", VA = "0x172FE90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8753A0", Offset = "0x8753A0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010E")]
			protected Vector3 force
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x172FE98", Offset = "0x172FE98", VA = "0x172FE98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8753B0", Offset = "0x8753B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000863")]
				[Address(RVA = "0x172FEA4", Offset = "0x172FEA4", VA = "0x172FEA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8753C0", Offset = "0x8753C0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700010F")]
			protected Vector3 point
			{
				[Token(Token = "0x6000864")]
				[Address(RVA = "0x172FEB0", Offset = "0x172FEB0", VA = "0x172FEB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8753D0", Offset = "0x8753D0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000865")]
				[Address(RVA = "0x172FEBC", Offset = "0x172FEBC", VA = "0x172FEBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8753E0", Offset = "0x8753E0")]
				private set
				{
				}
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x172FD30", Offset = "0x172FD30", VA = "0x172FD30")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x172F96C", Offset = "0x172F96C", VA = "0x172F96C")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000868")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000869")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x600086A")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x172FEC8", Offset = "0x172FEC8", VA = "0x172FEC8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FB")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40006E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871174", Offset = "0x871174")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40006E1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8711AC", Offset = "0x8711AC")]
				public float weight;

				[Token(Token = "0x40006E2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006E3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x60008DE")]
				[Address(RVA = "0x1730508", Offset = "0x1730508", VA = "0x1730508")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x173024C", Offset = "0x173024C", VA = "0x173024C")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008E0")]
				[Address(RVA = "0x1730658", Offset = "0x1730658", VA = "0x1730658")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870490", Offset = "0x870490")]
			public int forceDirCurveIndex;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8704C8", Offset = "0x8704C8")]
			public int upDirCurveIndex;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870500", Offset = "0x870500")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x172FEDC", Offset = "0x172FEDC", VA = "0x172FEDC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x17301C4", Offset = "0x17301C4", VA = "0x17301C4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x1730260", Offset = "0x1730260", VA = "0x1730260", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x173063C", Offset = "0x173063C", VA = "0x173063C")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DC")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000FC")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40006E4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8711E4", Offset = "0x8711E4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40006E5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87121C", Offset = "0x87121C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x87121C", Offset = "0x87121C")]
				public float weight;

				[Token(Token = "0x40006E6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40006E7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x60008E1")]
				[Address(RVA = "0x1730BD4", Offset = "0x1730BD4", VA = "0x1730BD4")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x60008E2")]
				[Address(RVA = "0x1730854", Offset = "0x1730854", VA = "0x1730854")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x60008E3")]
				[Address(RVA = "0x1730D4C", Offset = "0x1730D4C", VA = "0x1730D4C")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870538", Offset = "0x870538")]
			public int curveIndex;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870570", Offset = "0x870570")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x1730660", Offset = "0x1730660", VA = "0x1730660", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x17307C4", Offset = "0x17307C4", VA = "0x17307C4", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1730870", Offset = "0x1730870", VA = "0x1730870", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1730D38", Offset = "0x1730D38", VA = "0x1730D38")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D860", Offset = "0x86D860")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D898", Offset = "0x86D898")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x172F848", Offset = "0x172F848", VA = "0x172F848", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x172FAC0", Offset = "0x172FAC0", VA = "0x172FAC0")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x172FE70", Offset = "0x172FE70", VA = "0x172FE70")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000FD")]
			public class EffectorLink
			{
				[Token(Token = "0x40006E8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871270", Offset = "0x871270")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006E9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8712A8", Offset = "0x8712A8")]
				public float weight;

				[Token(Token = "0x60008E4")]
				[Address(RVA = "0x17B8BCC", Offset = "0x17B8BCC", VA = "0x17B8BCC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8705A8", Offset = "0x8705A8")]
			public Transform transform;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8705E0", Offset = "0x8705E0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870618", Offset = "0x870618")]
			public float speed;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870650", Offset = "0x870650")]
			public float acceleration;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870688", Offset = "0x870688")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x870688", Offset = "0x870688")]
			public float matchVelocity;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8706DC", Offset = "0x8706DC")]
			public float gravity;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x17B84F0", Offset = "0x17B84F0", VA = "0x17B84F0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x17B86DC", Offset = "0x17B86DC", VA = "0x17B86DC")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x17B8BB0", Offset = "0x17B8BB0", VA = "0x17B8BB0")]
			public Body()
			{
			}
		}

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D8D0", Offset = "0x86D8D0")]
		public Body[] bodies;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D908", Offset = "0x86D908")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x17B8460", Offset = "0x17B8460", VA = "0x17B8460")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x17B85E0", Offset = "0x17B85E0", VA = "0x17B85E0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x17B8B90", Offset = "0x17B8B90", VA = "0x17B8B90")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86D940", Offset = "0x86D940")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D940", Offset = "0x86D940")]
		public Transform target;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86D9A0", Offset = "0x86D9A0")]
		public float weight;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D9B8", Offset = "0x86D9B8")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86D9F0", Offset = "0x86D9F0")]
		public float weightSmoothTime;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86DA28", Offset = "0x86DA28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DA28", Offset = "0x86DA28")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DA88", Offset = "0x86DA88")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DAC0", Offset = "0x86DAC0")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DAF8", Offset = "0x86DAF8")]
		public float slerpSpeed;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DB30", Offset = "0x86DB30")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DB68", Offset = "0x86DB68")]
		public float minDistance;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x86DBA0", Offset = "0x86DBA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DBA0", Offset = "0x86DBA0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86DBA0", Offset = "0x86DBA0")]
		public float maxRootAngle;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700006B")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x17C5904", Offset = "0x17C5904", VA = "0x17C5904")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x17C57F8", Offset = "0x17C57F8", VA = "0x17C57F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x17C5A7C", Offset = "0x17C5A7C", VA = "0x17C5A7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x17C6284", Offset = "0x17C6284", VA = "0x17C6284")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x17C6450", Offset = "0x17C6450", VA = "0x17C6450")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x17C6800", Offset = "0x17C6800", VA = "0x17C6800")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870714", Offset = "0x870714")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87074C", Offset = "0x87074C")]
			public float spring;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870784", Offset = "0x870784")]
			public bool x;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8707BC", Offset = "0x8707BC")]
			public bool y;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8707F4", Offset = "0x8707F4")]
			public bool z;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87082C", Offset = "0x87082C")]
			public float minX;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870864", Offset = "0x870864")]
			public float maxX;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87089C", Offset = "0x87089C")]
			public float minY;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8708D4", Offset = "0x8708D4")]
			public float maxY;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87090C", Offset = "0x87090C")]
			public float minZ;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870944", Offset = "0x870944")]
			public float maxZ;

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x17C6C24", Offset = "0x17C6C24", VA = "0x17C6C24")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x17C7230", Offset = "0x17C7230", VA = "0x17C7230")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x17C7260", Offset = "0x17C7260", VA = "0x17C7260")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x17C7338", Offset = "0x17C7338", VA = "0x17C7338")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A738", Offset = "0x86A738")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087E")]
				[Address(RVA = "0x17C71B8", Offset = "0x17C71B8", VA = "0x17C71B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x17C7228", Offset = "0x17C7228", VA = "0x17C7228", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x17C6AEC", Offset = "0x17C6AEC", VA = "0x17C6AEC")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x17C7008", Offset = "0x17C7008", VA = "0x17C7008", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x17C700C", Offset = "0x17C700C", VA = "0x17C700C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x17C71C0", Offset = "0x17C71C0", VA = "0x17C71C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DC1C", Offset = "0x86DC1C")]
		public float weight;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DC54", Offset = "0x86DC54")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700006C")]
		protected float deltaTime
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x17B86B0", Offset = "0x17B86B0", VA = "0x17B86B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000589")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x17C6A4C", Offset = "0x17C6A4C", VA = "0x17C6A4C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x17C6A78", Offset = "0x17C6A78", VA = "0x17C6A78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87426C", Offset = "0x87426C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x17C6B18", Offset = "0x17C6B18", VA = "0x17C6B18")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x17B8AA4", Offset = "0x17B8AA4", VA = "0x17B8AA4")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x17C6EA8", Offset = "0x17C6EA8", VA = "0x17C6EA8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x17B8BA0", Offset = "0x17B8BA0", VA = "0x17B8BA0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A748", Offset = "0x86A748")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000112")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000884")]
				[Address(RVA = "0x17C7864", Offset = "0x17C7864", VA = "0x17C7864", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000113")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000886")]
				[Address(RVA = "0x17C78D4", Offset = "0x17C78D4", VA = "0x17C78D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x17C740C", Offset = "0x17C740C", VA = "0x17C740C")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x17C76B4", Offset = "0x17C76B4", VA = "0x17C76B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x17C76B8", Offset = "0x17C76B8", VA = "0x17C76B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x17C786C", Offset = "0x17C786C", VA = "0x17C786C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DC8C", Offset = "0x86DC8C")]
		public float weight;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DCC4", Offset = "0x86DCC4")]
		public VRIK ik;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x1700006D")]
		protected float deltaTime
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x17C7340", Offset = "0x17C7340", VA = "0x17C7340")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000591")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x17C736C", Offset = "0x17C736C", VA = "0x17C736C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x17C7398", Offset = "0x17C7398", VA = "0x17C7398")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8742D0", Offset = "0x8742D0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x17C7438", Offset = "0x17C7438", VA = "0x17C7438")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x17C7544", Offset = "0x17C7544", VA = "0x17C7544", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x17C76A4", Offset = "0x17C76A4", VA = "0x17C76A4")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E1")]
		public class EffectorLink
		{
			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x17C79F4", Offset = "0x17C79F4", VA = "0x17C79F4")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x17C7F30", Offset = "0x17C7F30", VA = "0x17C7F30")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x17C78DC", Offset = "0x17C78DC", VA = "0x17C78DC")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x17C7DE8", Offset = "0x17C7DE8", VA = "0x17C7DE8")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x17C7ED0", Offset = "0x17C7ED0", VA = "0x17C7ED0")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000FE")]
			public class EffectorLink
			{
				[Token(Token = "0x40006EA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8712E0", Offset = "0x8712E0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006EB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871318", Offset = "0x871318")]
				public float weight;

				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x1CB679C", Offset = "0x1CB679C", VA = "0x1CB679C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x87097C", Offset = "0x87097C")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8709B4", Offset = "0x8709B4")]
			public Transform raycastTo;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x8709EC", Offset = "0x8709EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x8709EC", Offset = "0x8709EC")]
			public float raycastRadius;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870A40", Offset = "0x870A40")]
			public EffectorLink[] effectors;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870A78", Offset = "0x870A78")]
			public float smoothTimeIn;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870AB0", Offset = "0x870AB0")]
			public float smoothTimeOut;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870AE8", Offset = "0x870AE8")]
			public LayerMask layers;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1CB6108", Offset = "0x1CB6108", VA = "0x1CB6108")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1CB6328", Offset = "0x1CB6328", VA = "0x1CB6328")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x1CB650C", Offset = "0x1CB650C", VA = "0x1CB650C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1CB6780", Offset = "0x1CB6780", VA = "0x1CB6780")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DCFC", Offset = "0x86DCFC")]
		public Avoider[] avoiders;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1CB6054", Offset = "0x1CB6054", VA = "0x1CB6054", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1CB6320", Offset = "0x1CB6320", VA = "0x1CB6320")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000FF")]
			public class EffectorLink
			{
				[Token(Token = "0x40006EC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871350", Offset = "0x871350")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006ED")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x871388", Offset = "0x871388")]
				public float weight;

				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x1CBA34C", Offset = "0x1CBA34C", VA = "0x1CBA34C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870B20", Offset = "0x870B20")]
			public Vector3 offset;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870B58", Offset = "0x870B58")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x870B58", Offset = "0x870B58")]
			public float additivity;

			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870BAC", Offset = "0x870BAC")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870BE4", Offset = "0x870BE4")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1CB8CFC", Offset = "0x1CB8CFC", VA = "0x1CB8CFC")]
			public void Start()
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1CB9A6C", Offset = "0x1CB9A6C", VA = "0x1CB9A6C")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1CBA334", Offset = "0x1CBA334", VA = "0x1CBA334")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum Handedness
		{
			[Token(Token = "0x400067C")]
			Right,
			[Token(Token = "0x400067D")]
			Left
		}

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DD34", Offset = "0x86DD34")]
		public AimIK aimIK;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DD6C", Offset = "0x86DD6C")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DDA4", Offset = "0x86DDA4")]
		public Handedness handedness;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DDDC", Offset = "0x86DDDC")]
		public bool twoHanded;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DE14", Offset = "0x86DE14")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DE4C", Offset = "0x86DE4C")]
		public float magnitudeRandom;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DE84", Offset = "0x86DE84")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DEBC", Offset = "0x86DEBC")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DEF4", Offset = "0x86DEF4")]
		public float blendTime;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x86DF2C", Offset = "0x86DF2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DF2C", Offset = "0x86DF2C")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700006E")]
		public bool isFinished
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1CB8A98", Offset = "0x1CB8A98", VA = "0x1CB8A98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1CB9D54", Offset = "0x1CB9D54", VA = "0x1CB9D54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1CB9DB4", Offset = "0x1CB9DB4", VA = "0x1CB9DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private Transform primaryHand
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1CB9CFC", Offset = "0x1CB9CFC", VA = "0x1CB9CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private Transform secondaryHand
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1CB9D28", Offset = "0x1CB9D28", VA = "0x1CB9D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1CB8AC8", Offset = "0x1CB8AC8", VA = "0x1CB8AC8")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1CB8AF4", Offset = "0x1CB8AF4", VA = "0x1CB8AF4")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1CB8DAC", Offset = "0x1CB8DAC", VA = "0x1CB8DAC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1CB9E14", Offset = "0x1CB9E14", VA = "0x1CB9E14")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1CB9FB0", Offset = "0x1CB9FB0", VA = "0x1CB9FB0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1CBA00C", Offset = "0x1CBA00C", VA = "0x1CBA00C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1CBA284", Offset = "0x1CBA284", VA = "0x1CBA284")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DF8C", Offset = "0x86DF8C")]
		public float weight;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x86DFC4", Offset = "0x86DFC4")]
		public float offset;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1CBE1B8", Offset = "0x1CBE1B8", VA = "0x1CBE1B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1CBE2F4", Offset = "0x1CBE2F4", VA = "0x1CBE2F4")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1CBE40C", Offset = "0x1CBE40C", VA = "0x1CBE40C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1CBE9A4", Offset = "0x1CBE9A4", VA = "0x1CBE9A4")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1CBEA08", Offset = "0x1CBEA08", VA = "0x1CBEA08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1CBEB68", Offset = "0x1CBEB68", VA = "0x1CBEB68")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class Settings
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870C1C", Offset = "0x870C1C")]
			public float scaleMlp;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870C54", Offset = "0x870C54")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870C8C", Offset = "0x870C8C")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870CC4", Offset = "0x870CC4")]
			public Vector3 bodyTrackerForward;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870CFC", Offset = "0x870CFC")]
			public Vector3 bodyTrackerUp;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870D34", Offset = "0x870D34")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870D6C", Offset = "0x870D6C")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870DA4", Offset = "0x870DA4")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870DDC", Offset = "0x870DDC")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x870E14", Offset = "0x870E14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870E14", Offset = "0x870E14")]
			public Vector3 headOffset;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870E64", Offset = "0x870E64")]
			public Vector3 handOffset;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870E9C", Offset = "0x870E9C")]
			public float footForwardOffset;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870ED4", Offset = "0x870ED4")]
			public float footInwardOffset;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x870F0C", Offset = "0x870F0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x870F0C", Offset = "0x870F0C")]
			public float footHeadingOffset;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x870F68", Offset = "0x870F68")]
			public float pelvisPositionWeight;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x870F80", Offset = "0x870F80")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1CC5124", Offset = "0x1CC5124", VA = "0x1CC5124")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x2000100")]
			public class Target
			{
				[Token(Token = "0x40006EE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x40006EF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x40006F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x60008E7")]
				[Address(RVA = "0x1CC3DF8", Offset = "0x1CC3DF8", VA = "0x1CC3DF8")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x1CC4C34", Offset = "0x1CC4C34", VA = "0x1CC4C34")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1CC3074", Offset = "0x1CC3074", VA = "0x1CC3074")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x1CC13A4", Offset = "0x1CC13A4", VA = "0x1CC13A4")]
		public static void RecalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1CC159C", Offset = "0x1CC159C", VA = "0x1CC159C")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1CC31EC", Offset = "0x1CC31EC", VA = "0x1CC31EC")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1CC3EEC", Offset = "0x1CC3EEC", VA = "0x1CC3EEC")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1CC4CD8", Offset = "0x1CC4CD8", VA = "0x1CC4CD8")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86DFFC", Offset = "0x86DFFC")]
		private Vector3 <pelvisTargetRight>k__BackingField;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x17000073")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1CC3EE0", Offset = "0x1CC3EE0", VA = "0x1CC3EE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874334", Offset = "0x874334")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x1CC521C", Offset = "0x1CC521C", VA = "0x1CC521C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874344", Offset = "0x874344")]
			private set
			{
			}
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1CC5228", Offset = "0x1CC5228", VA = "0x1CC5228")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1CC3B54", Offset = "0x1CC3B54", VA = "0x1CC3B54")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1CC4F54", Offset = "0x1CC4F54", VA = "0x1CC4F54")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1CC536C", Offset = "0x1CC536C", VA = "0x1CC536C")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1CC5A3C", Offset = "0x1CC5A3C", VA = "0x1CC5A3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1CC5B9C", Offset = "0x1CC5B9C", VA = "0x1CC5B9C")]
		public VRIKRootController()
		{
		}
	}
}
namespace PathologicalGames
{
	[Token(Token = "0x2000076")]
	public static class PoolManager
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SpawnPoolsDict Pools;
	}
	[Token(Token = "0x2000077")]
	public static class InstanceHandler
	{
		[Token(Token = "0x20000E7")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000E8")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static InstantiateDelegate InstantiateDelegates;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static DestroyDelegate DestroyDelegates;

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x132B868", Offset = "0x132B868", VA = "0x132B868")]
		internal static GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x132C2A8", Offset = "0x132C2A8", VA = "0x132C2A8")]
		internal static void DestroyInstance(GameObject instance)
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x86A420", Offset = "0x86A420")]
	public class SpawnPoolsDict : IDictionary<string, SpawnPool>, ICollection<KeyValuePair<string, SpawnPool>>, IEnumerable<KeyValuePair<string, SpawnPool>>, IEnumerable
	{
		[Token(Token = "0x20000E9")]
		public delegate void OnCreatedDelegate(SpawnPool pool);

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal Dictionary<string, OnCreatedDelegate> onCreatedDelegates;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<string, SpawnPool> _pools;

		[Token(Token = "0x17000074")]
		public int Count
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1336D5C", Offset = "0x1336D5C", VA = "0x1336D5C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public SpawnPool Item
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1336E30", Offset = "0x1336E30", VA = "0x1336E30", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1336F7C", Offset = "0x1336F7C", VA = "0x1336F7C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1336FF0", Offset = "0x1336FF0", VA = "0x1336FF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public ICollection<SpawnPool> Values
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1337064", Offset = "0x1337064", VA = "0x1337064", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private bool IsReadOnly
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x13370D8", Offset = "0x13370D8", VA = "0x13370D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.IsReadOnly
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x13370E0", Offset = "0x13370E0", VA = "0x13370E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x133587C", Offset = "0x133587C", VA = "0x133587C")]
		public void AddOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1335A6C", Offset = "0x1335A6C", VA = "0x1335A6C")]
		public void RemoveOnCreatedDelegate(string poolName, OnCreatedDelegate createdDelegate)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1335C90", Offset = "0x1335C90", VA = "0x1335C90")]
		public SpawnPool Create(string poolName)
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1335D2C", Offset = "0x1335D2C", VA = "0x1335D2C")]
		public SpawnPool Create(string poolName, GameObject owner)
		{
			return null;
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1335EB8", Offset = "0x1335EB8", VA = "0x1335EB8")]
		private bool assertValidPoolName(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1336078", Offset = "0x1336078", VA = "0x1336078", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1336174", Offset = "0x1336174", VA = "0x1336174")]
		public bool Destroy(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x13362D8", Offset = "0x13362D8", VA = "0x13362D8")]
		public void DestroyAll()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1330EC8", Offset = "0x1330EC8", VA = "0x1330EC8")]
		internal void Add(SpawnPool spawnPool)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1336C74", Offset = "0x1336C74", VA = "0x1336C74", Slot = "9")]
		public void Add(string key, SpawnPool value)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x13323D8", Offset = "0x13323D8", VA = "0x13323D8")]
		internal bool Remove(SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1336CE8", Offset = "0x1336CE8", VA = "0x1336CE8", Slot = "10")]
		public bool Remove(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1336008", Offset = "0x1336008", VA = "0x1336008", Slot = "8")]
		public bool ContainsKey(string poolName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1332368", Offset = "0x1332368", VA = "0x1332368")]
		public bool ContainsValue(SpawnPool pool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x132CDE0", Offset = "0x132CDE0", VA = "0x132CDE0", Slot = "11")]
		public bool TryGetValue(string poolName, out SpawnPool spawnPool)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1336DBC", Offset = "0x1336DBC", VA = "0x1336DBC", Slot = "16")]
		public bool Contains(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x13370E8", Offset = "0x13370E8", VA = "0x13370E8", Slot = "14")]
		public void Add(KeyValuePair<string, SpawnPool> item)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x133715C", Offset = "0x133715C", VA = "0x133715C", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x13371D0", Offset = "0x13371D0", VA = "0x13371D0")]
		private void CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1337244", Offset = "0x1337244", VA = "0x1337244", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,PathologicalGames.SpawnPool>>.CopyTo(KeyValuePair<string, SpawnPool>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x13372B8", Offset = "0x13372B8", VA = "0x13372B8", Slot = "18")]
		public bool Remove(KeyValuePair<string, SpawnPool> item)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x133732C", Offset = "0x133732C", VA = "0x133732C", Slot = "19")]
		public IEnumerator<KeyValuePair<string, SpawnPool>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x13373C4", Offset = "0x13373C4", VA = "0x13373C4", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x132CBF4", Offset = "0x132CBF4", VA = "0x132CBF4")]
		public SpawnPoolsDict()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A458", Offset = "0x86A458")]
	public class PreRuntimePoolItem : MonoBehaviour
	{
		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string prefabName;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool despawnOnStart;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool doNotReparent;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x132CC8C", Offset = "0x132CC8C", VA = "0x132CC8C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x132D19C", Offset = "0x132D19C", VA = "0x132D19C")]
		public PreRuntimePoolItem()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x86A490", Offset = "0x86A490")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x86A490", Offset = "0x86A490")]
	public sealed class SpawnPool : MonoBehaviour, IList<Transform>, ICollection<Transform>, IEnumerable<Transform>, IEnumerable
	{
		[Token(Token = "0x20000EA")]
		public delegate GameObject InstantiateDelegate(GameObject prefab, Vector3 pos, Quaternion rot);

		[Token(Token = "0x20000EB")]
		public delegate void DestroyDelegate(GameObject instance);

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A758", Offset = "0x86A758")]
		private sealed class <DoDespawnAfterSeconds>d__56 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform instance;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool useParent;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform parent;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private GameObject <go>5__2;

			[Token(Token = "0x17000114")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x1334E14", Offset = "0x1334E14", VA = "0x1334E14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000115")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x1334E84", Offset = "0x1334E84", VA = "0x1334E84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1333E4C", Offset = "0x1333E4C", VA = "0x1333E4C")]
			[DebuggerHidden]
			public <DoDespawnAfterSeconds>d__56(int <>1__state)
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1334D04", Offset = "0x1334D04", VA = "0x1334D04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1334D08", Offset = "0x1334D08", VA = "0x1334D08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x1334E1C", Offset = "0x1334E1C", VA = "0x1334E1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A768", Offset = "0x86A768")]
		private sealed class <ListForAudioStop>d__63 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioSource src;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private GameObject <srcGameObject>5__2;

			[Token(Token = "0x17000116")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008AF")]
				[Address(RVA = "0x13351A4", Offset = "0x13351A4", VA = "0x13351A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000117")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B1")]
				[Address(RVA = "0x1335214", Offset = "0x1335214", VA = "0x1335214", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x13343D8", Offset = "0x13343D8", VA = "0x13343D8")]
			[DebuggerHidden]
			public <ListForAudioStop>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x1335074", Offset = "0x1335074", VA = "0x1335074", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x1335078", Offset = "0x1335078", VA = "0x1335078", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x13351AC", Offset = "0x13351AC", VA = "0x13351AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A778", Offset = "0x86A778")]
		private sealed class <ListenForEmitDespawn>d__64 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ParticleSystem emitter;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <safetimer>5__2;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private GameObject <emitterGO>5__3;

			[Token(Token = "0x17000118")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x60008B5")]
				[Address(RVA = "0x13354FC", Offset = "0x13354FC", VA = "0x13354FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000119")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B7")]
				[Address(RVA = "0x133556C", Offset = "0x133556C", VA = "0x133556C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1334404", Offset = "0x1334404", VA = "0x1334404")]
			[DebuggerHidden]
			public <ListenForEmitDespawn>d__64(int <>1__state)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1335278", Offset = "0x1335278", VA = "0x1335278", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x133527C", Offset = "0x133527C", VA = "0x133527C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1335504", Offset = "0x1335504", VA = "0x1335504", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A788", Offset = "0x86A788")]
		private sealed class <GetEnumerator>d__73 : IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700011A")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0x1334FFC", Offset = "0x1334FFC", VA = "0x1334FFC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008BD")]
				[Address(RVA = "0x133506C", Offset = "0x133506C", VA = "0x133506C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1334894", Offset = "0x1334894", VA = "0x1334894")]
			[DebuggerHidden]
			public <GetEnumerator>d__73(int <>1__state)
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1334EE8", Offset = "0x1334EE8", VA = "0x1334EE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1334EEC", Offset = "0x1334EEC", VA = "0x1334EEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1335004", Offset = "0x1335004", VA = "0x1335004", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A798", Offset = "0x86A798")]
		private sealed class <System-Collections-IEnumerable-GetEnumerator>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpawnPool <>4__this;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700011C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C1")]
				[Address(RVA = "0x13356E4", Offset = "0x13356E4", VA = "0x13356E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C3")]
				[Address(RVA = "0x1335754", Offset = "0x1335754", VA = "0x1335754", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1334934", Offset = "0x1334934", VA = "0x1334934")]
			[DebuggerHidden]
			public <System-Collections-IEnumerable-GetEnumerator>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x13355D0", Offset = "0x13355D0", VA = "0x13355D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x13355D4", Offset = "0x13355D4", VA = "0x13355D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x13356EC", Offset = "0x13356EC", VA = "0x13356EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string poolName;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool matchPoolScale;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool matchPoolLayer;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool dontReparent;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool _dontDestroyOnLoad;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool logMessages;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PrefabPool> _perPrefabPoolOptions;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<object, bool> prefabsFoldOutStates;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxParticleDespawnTime;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86E00C", Offset = "0x86E00C")]
		private Transform <group>k__BackingField;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public PrefabsDict prefabs;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Dictionary<object, bool> _editorListItemStates;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<PrefabPool> _prefabPools;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InstantiateDelegate instantiateDelegates;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DestroyDelegate destroyDelegates;

		[Token(Token = "0x1700007A")]
		public bool dontDestroyOnLoad
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1330758", Offset = "0x1330758", VA = "0x1330758")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1330760", Offset = "0x1330760", VA = "0x1330760")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public Transform group
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x132E770", Offset = "0x132E770", VA = "0x132E770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874354", Offset = "0x874354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1330840", Offset = "0x1330840", VA = "0x1330840")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x874364", Offset = "0x874364")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public Dictionary<string, PrefabPool> prefabPools
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1330848", Offset = "0x1330848", VA = "0x1330848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public Transform Item
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x13345F0", Offset = "0x13345F0", VA = "0x13345F0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1334660", Offset = "0x1334660", VA = "0x1334660", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public int Count
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x13347C0", Offset = "0x13347C0", VA = "0x13347C0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007F")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1334B00", Offset = "0x1334B00", VA = "0x1334B00", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x13309A0", Offset = "0x13309A0", VA = "0x13309A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x132E778", Offset = "0x132E778", VA = "0x132E778")]
		internal GameObject InstantiatePrefab(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x132D8B0", Offset = "0x132D8B0", VA = "0x132D8B0")]
		internal void DestroyInstance(GameObject instance)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1332100", Offset = "0x1332100", VA = "0x1332100")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1330CC8", Offset = "0x1330CC8", VA = "0x1330CC8")]
		public void CreatePrefabPool(PrefabPool prefabPool)
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x132CE58", Offset = "0x132CE58", VA = "0x132CE58")]
		public void Add(Transform instance, string prefabName, bool despawn, bool parent)
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x13326D8", Offset = "0x13326D8", VA = "0x13326D8", Slot = "11")]
		public void Add(Transform item)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x133274C", Offset = "0x133274C", VA = "0x133274C")]
		public void Remove(Transform item)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x13327C0", Offset = "0x13327C0", VA = "0x13327C0")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1332CA0", Offset = "0x1332CA0", VA = "0x1332CA0")]
		public Transform Spawn(Transform prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1332D94", Offset = "0x1332D94", VA = "0x1332D94")]
		public Transform Spawn(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1332E80", Offset = "0x1332E80", VA = "0x1332E80")]
		public Transform Spawn(Transform prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1332F74", Offset = "0x1332F74", VA = "0x1332F74")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x133301C", Offset = "0x133301C", VA = "0x133301C")]
		public Transform Spawn(GameObject prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x13330B4", Offset = "0x13330B4", VA = "0x13330B4")]
		public Transform Spawn(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x13330F4", Offset = "0x13330F4", VA = "0x13330F4")]
		public Transform Spawn(GameObject prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1333144", Offset = "0x1333144", VA = "0x1333144")]
		public Transform Spawn(string prefabName)
		{
			return null;
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1333190", Offset = "0x1333190", VA = "0x1333190")]
		public Transform Spawn(string prefabName, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x13331E4", Offset = "0x13331E4", VA = "0x13331E4")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1333288", Offset = "0x1333288", VA = "0x1333288")]
		public Transform Spawn(string prefabName, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1333334", Offset = "0x1333334", VA = "0x1333334")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x13334C8", Offset = "0x13334C8", VA = "0x13334C8")]
		public AudioSource Spawn(AudioSource prefab)
		{
			return null;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x13335B8", Offset = "0x13335B8", VA = "0x13335B8")]
		public AudioSource Spawn(AudioSource prefab, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x133333C", Offset = "0x133333C", VA = "0x133333C")]
		public AudioSource Spawn(AudioSource prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1333744", Offset = "0x1333744", VA = "0x1333744")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x133374C", Offset = "0x133374C", VA = "0x133374C")]
		public ParticleSystem Spawn(ParticleSystem prefab, Vector3 pos, Quaternion rot, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x133395C", Offset = "0x133395C", VA = "0x133395C")]
		public void Despawn(Transform instance)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1333B80", Offset = "0x1333B80", VA = "0x1333B80")]
		public void Despawn(Transform instance, Transform parent)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1333C14", Offset = "0x1333C14", VA = "0x1333C14")]
		public void Despawn(Transform instance, float seconds)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1333DA8", Offset = "0x1333DA8", VA = "0x1333DA8")]
		public void Despawn(Transform instance, float seconds, Transform parent)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1333CB4", Offset = "0x1333CB4", VA = "0x1333CB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x874374", Offset = "0x874374")]
		private IEnumerator<float> DoDespawnAfterSeconds(Transform instance, float seconds, bool useParent, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1333E78", Offset = "0x1333E78", VA = "0x1333E78")]
		public void DespawnAll()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1333F58", Offset = "0x1333F58", VA = "0x1333F58")]
		public bool IsSpawned(Transform instance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x13324E0", Offset = "0x13324E0", VA = "0x13324E0")]
		public PrefabPool GetPrefabPool(Transform prefab)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1333FC8", Offset = "0x1333FC8", VA = "0x1333FC8")]
		public PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x13341A0", Offset = "0x13341A0", VA = "0x13341A0")]
		public Transform GetPrefab(Transform instance)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x13342A8", Offset = "0x13342A8", VA = "0x13342A8")]
		public GameObject GetPrefab(GameObject instance)
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x13336AC", Offset = "0x13336AC", VA = "0x13336AC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8743D8", Offset = "0x8743D8")]
		private IEnumerator<float> ListForAudioStop(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x13338C4", Offset = "0x13338C4", VA = "0x13338C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x87443C", Offset = "0x87443C")]
		private IEnumerator<float> ListenForEmitDespawn(ParticleSystem emitter)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1334430", Offset = "0x1334430", VA = "0x1334430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x13346D4", Offset = "0x13346D4", VA = "0x13346D4", Slot = "13")]
		public bool Contains(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1334748", Offset = "0x1334748", VA = "0x1334748", Slot = "14")]
		public void CopyTo(Transform[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1334820", Offset = "0x1334820", VA = "0x1334820", Slot = "16")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8744A0", Offset = "0x8744A0")]
		public IEnumerator<Transform> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x13348C0", Offset = "0x13348C0", VA = "0x13348C0", Slot = "17")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x874504", Offset = "0x874504")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1334960", Offset = "0x1334960", VA = "0x1334960", Slot = "6")]
		public int IndexOf(Transform item)
		{
			return default(int);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x13349C8", Offset = "0x13349C8", VA = "0x13349C8", Slot = "7")]
		public void Insert(int index, Transform item)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1334A30", Offset = "0x1334A30", VA = "0x1334A30", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1334A98", Offset = "0x1334A98", VA = "0x1334A98", Slot = "12")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1334B68", Offset = "0x1334B68", VA = "0x1334B68", Slot = "15")]
		private bool System.Collections.Generic.ICollection<UnityEngine.Transform>.Remove(Transform item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1334BD0", Offset = "0x1334BD0", VA = "0x1334BD0")]
		public SpawnPool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class PrefabPool
	{
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A7A8", Offset = "0x86A7A8")]
		private sealed class <CullDespawned>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x1700011E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C7")]
				[Address(RVA = "0x132F868", Offset = "0x132F868", VA = "0x132F868", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C9")]
				[Address(RVA = "0x132F8D8", Offset = "0x132F8D8", VA = "0x132F8D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x132DD10", Offset = "0x132DD10", VA = "0x132DD10")]
			[DebuggerHidden]
			public <CullDespawned>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x132F200", Offset = "0x132F200", VA = "0x132F200", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x132F204", Offset = "0x132F204", VA = "0x132F204", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x132F870", Offset = "0x132F870", VA = "0x132F870", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A7B8", Offset = "0x86A7B8")]
		private sealed class <PreloadOverTime>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PrefabPool <>4__this;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <remainder>5__2;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <numPerFrame>5__3;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <numThisFrame>5__4;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <i>5__5;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <n>5__6;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008CD")]
				[Address(RVA = "0x132FB90", Offset = "0x132FB90", VA = "0x132FB90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008CF")]
				[Address(RVA = "0x132FC00", Offset = "0x132FC00", VA = "0x132FC00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x132F090", Offset = "0x132F090", VA = "0x132F090")]
			[DebuggerHidden]
			public <PreloadOverTime>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x132F8E0", Offset = "0x132F8E0", VA = "0x132F8E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x132F8E4", Offset = "0x132F8E4", VA = "0x132F8E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x132FB98", Offset = "0x132FB98", VA = "0x132FB98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform prefab;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GameObject prefabGO;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int preloadAmount;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool preloadTime;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int preloadFrames;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float preloadDelay;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool limitInstances;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int limitAmount;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool limitFIFO;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool cullDespawned;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int cullAbove;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cullDelay;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int cullMaxPerPass;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool _logMessages;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool forceLoggingSilent;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpawnPool spawnPool;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool cullingActive;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal List<Transform> _spawned;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal List<Transform> _despawned;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _preloaded;

		[Token(Token = "0x17000080")]
		public bool logMessages
		{
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x132D1FC", Offset = "0x132D1FC", VA = "0x132D1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public List<Transform> spawned
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x132D8C4", Offset = "0x132D8C4", VA = "0x132D8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public List<Transform> despawned
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x132D934", Offset = "0x132D934", VA = "0x132D934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public int totalCount
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x132D9A4", Offset = "0x132D9A4", VA = "0x132D9A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000084")]
		internal bool preloaded
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x132DA34", Offset = "0x132DA34", VA = "0x132DA34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x132DA3C", Offset = "0x132DA3C", VA = "0x132DA3C")]
			private set
			{
			}
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x132D264", Offset = "0x132D264", VA = "0x132D264")]
		public PrefabPool(Transform prefab)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x132D350", Offset = "0x132D350", VA = "0x132D350")]
		public PrefabPool()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x132D40C", Offset = "0x132D40C", VA = "0x132D40C")]
		internal void inspectorInstanceConstructor()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x132D4B4", Offset = "0x132D4B4", VA = "0x132D4B4")]
		internal void SelfDestruct()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x132DA48", Offset = "0x132DA48", VA = "0x132DA48")]
		internal bool DespawnInstance(Transform xform)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x132DA64", Offset = "0x132DA64", VA = "0x132DA64")]
		internal bool DespawnInstance(Transform xform, bool sendEventMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x132DC9C", Offset = "0x132DC9C", VA = "0x132DC9C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x874568", Offset = "0x874568")]
		internal IEnumerator CullDespawned()
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x132DD3C", Offset = "0x132DD3C", VA = "0x132DD3C")]
		internal Transform SpawnInstance(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x132E694", Offset = "0x132E694", VA = "0x132E694")]
		public Transform SpawnNew()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x132E1C8", Offset = "0x132E1C8", VA = "0x132E1C8")]
		public Transform SpawnNew(Vector3 pos, Quaternion rot)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x132E850", Offset = "0x132E850", VA = "0x132E850")]
		private void SetRecursively(Transform xform, int layer)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x132EB50", Offset = "0x132EB50", VA = "0x132EB50")]
		internal void AddUnpooled(Transform inst, bool despawn)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x132EC14", Offset = "0x132EC14", VA = "0x132EC14")]
		internal void PreloadInstances()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x132F01C", Offset = "0x132F01C", VA = "0x132F01C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8745CC", Offset = "0x8745CC")]
		private IEnumerator PreloadOverTime()
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x132F0BC", Offset = "0x132F0BC", VA = "0x132F0BC")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x132E78C", Offset = "0x132E78C", VA = "0x132E78C")]
		private void nameInstance(Transform instance)
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x86A4F0", Offset = "0x86A4F0")]
	public class PrefabsDict : IDictionary<string, Transform>, ICollection<KeyValuePair<string, Transform>>, IEnumerable<KeyValuePair<string, Transform>>, IEnumerable
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, Transform> _prefabs;

		[Token(Token = "0x17000085")]
		public int Count
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x132FE4C", Offset = "0x132FE4C", VA = "0x132FE4C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000086")]
		public Transform Item
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x13300F0", Offset = "0x13300F0", VA = "0x13300F0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x133023C", Offset = "0x133023C", VA = "0x133023C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public ICollection<string> Keys
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x13302B0", Offset = "0x13302B0", VA = "0x13302B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public ICollection<Transform> Values
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x1330310", Offset = "0x1330310", VA = "0x1330310", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x1330370", Offset = "0x1330370", VA = "0x1330370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.IsReadOnly
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1330378", Offset = "0x1330378", VA = "0x1330378", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x132FC08", Offset = "0x132FC08", VA = "0x132FC08", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x132FD04", Offset = "0x132FD04", VA = "0x132FD04")]
		internal void _Add(string prefabName, Transform prefab)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x132FD7C", Offset = "0x132FD7C", VA = "0x132FD7C")]
		internal bool _Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x132FDEC", Offset = "0x132FDEC", VA = "0x132FDEC")]
		internal void _Clear()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x132FEAC", Offset = "0x132FEAC", VA = "0x132FEAC", Slot = "8")]
		public bool ContainsKey(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x132FF1C", Offset = "0x132FF1C", VA = "0x132FF1C", Slot = "11")]
		public bool TryGetValue(string prefabName, out Transform prefab)
		{
			return default(bool);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x132FF94", Offset = "0x132FF94", VA = "0x132FF94", Slot = "9")]
		public void Add(string key, Transform value)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1330008", Offset = "0x1330008", VA = "0x1330008", Slot = "10")]
		public bool Remove(string prefabName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x133007C", Offset = "0x133007C", VA = "0x133007C", Slot = "16")]
		public bool Contains(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1330380", Offset = "0x1330380", VA = "0x1330380", Slot = "14")]
		public void Add(KeyValuePair<string, Transform> item)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x13303F4", Offset = "0x13303F4", VA = "0x13303F4", Slot = "15")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x133045C", Offset = "0x133045C", VA = "0x133045C")]
		private void CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x13304D0", Offset = "0x13304D0", VA = "0x13304D0", Slot = "17")]
		private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,UnityEngine.Transform>>.CopyTo(KeyValuePair<string, Transform>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1330544", Offset = "0x1330544", VA = "0x1330544", Slot = "18")]
		public bool Remove(KeyValuePair<string, Transform> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x13305B8", Offset = "0x13305B8", VA = "0x13305B8", Slot = "19")]
		public IEnumerator<KeyValuePair<string, Transform>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1330650", Offset = "0x1330650", VA = "0x1330650", Slot = "20")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x13306E8", Offset = "0x13306E8", VA = "0x13306E8")]
		public PrefabsDict()
		{
		}
	}
}
namespace Plugins.Isolationist
{
	[Token(Token = "0x200007D")]
	public class IsolateInfo : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A7C8", Offset = "0x86A7C8")]
		private sealed class <>c
		{
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<GameObject, bool> <>9__9_0;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<GameObject> <>9__9_1;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<GameObject, bool> <>9__10_0;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action<GameObject> <>9__10_1;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1337B5C", Offset = "0x1337B5C", VA = "0x1337B5C")]
			public <>c()
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x1337B64", Offset = "0x1337B64", VA = "0x1337B64")]
			internal bool <Hide>b__9_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1337BCC", Offset = "0x1337BCC", VA = "0x1337BCC")]
			internal void <Hide>b__9_1(GameObject go)
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x1337C00", Offset = "0x1337C00", VA = "0x1337C00")]
			internal bool <Show>b__10_0(GameObject go)
			{
				return default(bool);
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x1337C68", Offset = "0x1337C68", VA = "0x1337C68")]
			internal void <Show>b__10_1(GameObject go)
			{
			}
		}

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IsolateInfo _instance;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _searched;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> FocusObjects;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GameObject> HiddenObjects;

		[Token(Token = "0x1700008B")]
		public static IsolateInfo Instance
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x133749C", Offset = "0x133749C", VA = "0x133749C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x1337568", Offset = "0x1337568", VA = "0x1337568")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public static bool IsIsolated
		{
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x13375BC", Offset = "0x13375BC", VA = "0x13375BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x133768C", Offset = "0x133768C", VA = "0x133768C")]
		public static void Hide()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x13378BC", Offset = "0x13378BC", VA = "0x13378BC")]
		public static void Show()
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1337AEC", Offset = "0x1337AEC", VA = "0x1337AEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1337AF0", Offset = "0x1337AF0", VA = "0x1337AF0")]
		public IsolateInfo()
		{
		}
	}
}
