using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Capture360 : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int imageWidth;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool saveAsJPG;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera _camera;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1795704", Offset = "0x1795704", VA = "0x1795704")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1795708", Offset = "0x1795708", VA = "0x1795708")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1795F84", Offset = "0x1795F84", VA = "0x1795F84")]
	public Capture360()
	{
	}
}
[Token(Token = "0x2000003")]
public static class I360Render
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000005")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000006")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x4000007")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1795814", Offset = "0x1795814", VA = "0x1795814")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1796048", Offset = "0x1796048", VA = "0x1796048")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1795F94", Offset = "0x1795F94", VA = "0x1795F94")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1796100", Offset = "0x1796100", VA = "0x1796100")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1796B60", Offset = "0x1796B60", VA = "0x1796B60")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x17969A8", Offset = "0x17969A8", VA = "0x17969A8")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1796B18", Offset = "0x1796B18", VA = "0x1796B18")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1796584", Offset = "0x1796584", VA = "0x1796584")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1796C40", Offset = "0x1796C40", VA = "0x1796C40")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1796FE4", Offset = "0x1796FE4", VA = "0x1796FE4")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1796EC4", Offset = "0x1796EC4", VA = "0x1796EC4")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x17970D8", Offset = "0x17970D8", VA = "0x17970D8")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
