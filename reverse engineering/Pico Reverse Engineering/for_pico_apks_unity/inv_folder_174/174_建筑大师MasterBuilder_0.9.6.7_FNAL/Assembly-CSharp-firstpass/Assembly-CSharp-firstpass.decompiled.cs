using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class I360Render
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int paddingX;

	[Token(Token = "0x4000003")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000004")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x4000005")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xF17148", Offset = "0xF17148", VA = "0xF17148")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xF17C58", Offset = "0xF17C58", VA = "0xF17C58")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xF17B84", Offset = "0xF17B84", VA = "0xF17B84")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xF17D30", Offset = "0xF17D30", VA = "0xF17D30")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xF18A4C", Offset = "0xF18A4C", VA = "0xF18A4C")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xF18838", Offset = "0xF18838", VA = "0xF18838")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xF189F0", Offset = "0xF189F0", VA = "0xF189F0")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xF182EC", Offset = "0xF182EC", VA = "0xF182EC")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xF18B38", Offset = "0xF18B38", VA = "0xF18B38")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xF18FC8", Offset = "0xF18FC8", VA = "0xF18FC8")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xF18E90", Offset = "0xF18E90", VA = "0xF18E90")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xF190B8", Offset = "0xF190B8", VA = "0xF190B8")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
namespace SuperPivot;

[Token(Token = "0x2000003")]
public static class API
{
	[Token(Token = "0x2000004")]
	public enum Space
	{
		[Token(Token = "0x4000009")]
		Global,
		[Token(Token = "0x400000A")]
		Local
	}

	[Token(Token = "0x4000007")]
	public const float Version = 1.5f;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xF16420", Offset = "0xF16420", VA = "0xF16420")]
	public static Vector3 GetPivotPosition(this Transform self, Space space = Space.Global)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xF1647C", Offset = "0xF1647C", VA = "0xF1647C")]
	public static bool CanChangePivot(Transform target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xF167E0", Offset = "0xF167E0", VA = "0xF167E0")]
	public static bool CanChangePivot(Transform target, out string reason)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xF16810", Offset = "0xF16810", VA = "0xF16810")]
	public static bool CanChangeAtLeastOnePivot(Transform[] targets)
	{
		return default(bool);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xF16494", Offset = "0xF16494", VA = "0xF16494")]
	private static string CanChangePivotPrivate(Transform target)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xF16874", Offset = "0xF16874", VA = "0xF16874")]
	public static void SetPivot(Transform target, Vector3 pivotPos, Space space = Space.Global)
	{
	}
}
[Token(Token = "0x2000005")]
public class ShowPivot : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool visible;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Color color;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xF1915C", Offset = "0xF1915C", VA = "0xF1915C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xF1925C", Offset = "0xF1925C", VA = "0xF1925C")]
	public ShowPivot()
	{
	}
}
