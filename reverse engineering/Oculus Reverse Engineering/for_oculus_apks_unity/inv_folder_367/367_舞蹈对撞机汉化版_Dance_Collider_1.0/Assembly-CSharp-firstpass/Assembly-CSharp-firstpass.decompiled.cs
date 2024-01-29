using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class Capture360 : MonoBehaviour
{
	public int imageWidth = 2048;

	public bool saveAsJPG;

	public Camera _camera;

	private void Start()
	{
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			byte[] array = I360Render.Capture(imageWidth, saveAsJPG, _camera);
			if (array != null)
			{
				File.WriteAllBytes("E:/Unity360Capture" + (saveAsJPG ? ".jpeg" : ".png"), array);
			}
		}
	}
}
public static class I360Render
{
	private static Material equirectangularConverter;

	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	private static uint[] CRC_TABLE_PNG;

	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, Camera renderCam = null)
	{
		if (renderCam == null)
		{
			renderCam = Camera.main;
			if (renderCam == null)
			{
				Debug.LogError("Error: no camera detected");
				return null;
			}
		}
		RenderTexture targetTexture = renderCam.targetTexture;
		if (equirectangularConverter == null)
		{
			equirectangularConverter = new Material(Shader.Find("Hidden/CubemapToEquirectangular"));
		}
		int num = Mathf.Min(Mathf.NextPowerOfTwo(width), 8192);
		RenderTexture renderTexture = null;
		RenderTexture renderTexture2 = null;
		Texture2D texture2D = null;
		try
		{
			renderTexture = RenderTexture.GetTemporary(num, num, 0);
			renderTexture.dimension = TextureDimension.Cube;
			renderTexture2 = RenderTexture.GetTemporary(num, num / 2, 0);
			renderTexture2.dimension = TextureDimension.Tex2D;
			if (!renderCam.RenderToCubemap(renderTexture, 63))
			{
				Debug.LogError("Rendering to cubemap is not supported on device/platform!");
				return null;
			}
			Graphics.Blit(renderTexture, renderTexture2, equirectangularConverter);
			RenderTexture active = RenderTexture.active;
			RenderTexture.active = renderTexture2;
			texture2D = new Texture2D(renderTexture2.width, renderTexture2.height, TextureFormat.RGB24, mipChain: false);
			texture2D.ReadPixels(new Rect(0f, 0f, renderTexture2.width, renderTexture2.height), 0, 0);
			RenderTexture.active = active;
			return encodeAsJPEG ? InsertXMPIntoTexture2D_JPEG(texture2D) : InsertXMPIntoTexture2D_PNG(texture2D);
		}
		catch (Exception exception)
		{
			Debug.LogException(exception);
			return null;
		}
		finally
		{
			renderCam.targetTexture = targetTexture;
			if (renderTexture != null)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2 != null)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			if (texture2D != null)
			{
				UnityEngine.Object.DestroyImmediate(texture2D);
			}
		}
	}

	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return DoTheHardWork_JPEG(image.EncodeToJPG(100), image.width, image.height);
	}

	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return DoTheHardWork_PNG(image.EncodeToPNG(), image.width, image.height);
	}

	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		int startIndex = 0;
		int chunkSize = 0;
		while (!SearchChunkForXMP_JPEG(fileBytes, ref startIndex, ref chunkSize) && startIndex != -1)
		{
		}
		int num2;
		int num;
		if (startIndex == -1)
		{
			num2 = (num = FindIndexToInsertXMPCode_JPEG(fileBytes));
		}
		else
		{
			num2 = startIndex;
			num = startIndex + 2 + chunkSize;
		}
		string text = "http://ns.adobe.com/xap/1.0/" + "\0" + string.Format("<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>", 75f.ToString("F1"), imageWidth, imageHeight);
		int num3 = text.Length + 2;
		text = string.Concat('ÿ', 'á', (char)(num3 / 256), (char)(num3 % 256), text);
		byte[] array = new byte[num2 + text.Length + (fileBytes.Length - num)];
		Array.Copy(fileBytes, 0, array, 0, num2);
		for (int i = 0; i < text.Length; i++)
		{
			array[num2 + i] = (byte)text[i];
		}
		Array.Copy(fileBytes, num, array, num2 + text.Length, fileBytes.Length - num);
		return array;
	}

	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		for (int i = 0; i < "http://ns.adobe.com/xap/1.0/".Length; i++)
		{
			if (bytes[startIndex + i] != "http://ns.adobe.com/xap/1.0/"[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		if (startIndex + 4 < bytes.Length && bytes[startIndex] == byte.MaxValue)
		{
			byte b = bytes[startIndex + 1];
			switch (b)
			{
			case 218:
				startIndex = -1;
				return false;
			case 1:
			case 208:
			case 209:
			case 210:
			case 211:
			case 212:
			case 213:
			case 214:
			case 215:
			case 216:
			case 217:
				startIndex += 2;
				return false;
			}
			chunkSize = bytes[startIndex + 2] * 256 + bytes[startIndex + 3];
			if (b == 225 && chunkSize >= 31 && CheckBytesForXMPNamespace_JPEG(bytes, startIndex + 4))
			{
				return true;
			}
			startIndex = startIndex + 2 + chunkSize;
		}
		return false;
	}

	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return bytes[4] * 256 + bytes[5] + 4;
	}

	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		string text = "iTXt" + string.Format("XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>", 75f.ToString("F1"), imageWidth, imageHeight);
		int num = 33;
		int num2 = text.Length - 4;
		string text2 = CalculateCRC_PNG(text);
		text = string.Concat((char)(num2 >> 24), (char)(num2 >> 16), (char)(num2 >> 8), (char)num2, text, text2);
		byte[] array = new byte[fileBytes.Length + text.Length];
		Array.Copy(fileBytes, 0, array, 0, num);
		for (int i = 0; i < text.Length; i++)
		{
			array[num + i] = (byte)text[i];
		}
		Array.Copy(fileBytes, num, array, num + text.Length, fileBytes.Length - num);
		return array;
	}

	private static string CalculateCRC_PNG(string xmpContent)
	{
		if (CRC_TABLE_PNG == null)
		{
			CalculateCRCTable_PNG();
		}
		byte[] array = CalculateCRCBytes_PNG(~UpdateCRC_PNG(xmpContent));
		return string.Concat((char)array[0], (char)array[1], (char)array[2], (char)array[3]);
	}

	private static uint UpdateCRC_PNG(string xmpContent)
	{
		uint num = uint.MaxValue;
		for (int i = 0; i < xmpContent.Length; i++)
		{
			num = (num >> 8) ^ CRC_TABLE_PNG[xmpContent[i] ^ (num & 0xFF)];
		}
		return num;
	}

	private static void CalculateCRCTable_PNG()
	{
		CRC_TABLE_PNG = new uint[256];
		for (uint num = 0u; num < 256; num++)
		{
			uint num2 = num;
			for (int i = 0; i < 8; i++)
			{
				num2 = (((num2 & 1) != 1) ? (num2 >> 1) : ((num2 >> 1) ^ 0xEDB88320u));
			}
			CRC_TABLE_PNG[num] = num2;
		}
	}

	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		byte[] bytes = BitConverter.GetBytes(crc);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse((Array)bytes);
		}
		return bytes;
	}
}
