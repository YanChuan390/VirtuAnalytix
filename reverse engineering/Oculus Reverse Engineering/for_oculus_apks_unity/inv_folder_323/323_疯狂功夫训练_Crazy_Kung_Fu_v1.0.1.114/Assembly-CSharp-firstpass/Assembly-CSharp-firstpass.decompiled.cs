using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class Capture360 : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Capture360 <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x21DE400", Offset = "0x21DD400", VA = "0x21DE400", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x21DE440", Offset = "0x21DD440", VA = "0x21DE440", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x21DDBD0", Offset = "0x21DCBD0", VA = "0x21DDBD0")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x21DDC10", Offset = "0x21DCC10", VA = "0x21DDC10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x21DDC14", Offset = "0x21DCC14", VA = "0x21DDC14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x21DE408", Offset = "0x21DD408", VA = "0x21DE408", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int imageWidth;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool saveAsJPEG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x21DDB70", Offset = "0x21DCB70", VA = "0x21DDB70")]
	[IteratorStateMachine(typeof(<Start>d__2))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x21DDBF8", Offset = "0x21DCBF8", VA = "0x21DDBF8")]
	public Capture360()
	{
	}
}
[Token(Token = "0x2000004")]
public static class I360Render
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Material equirectangularConverter;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int paddingX;

	[Token(Token = "0x4000008")]
	private const string XMP_NAMESPACE_JPEG = "http://ns.adobe.com/xap/1.0/";

	[Token(Token = "0x4000009")]
	private const string XMP_CONTENT_TO_FORMAT_JPEG = "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" GPano:UsePanoramaViewer=\"True\" GPano:CaptureSoftware=\"Unity3D\" GPano:StitchingSoftware=\"Unity3D\" GPano:ProjectionType=\"equirectangular\" GPano:PoseHeadingDegrees=\"180.0\" GPano:InitialViewHeadingDegrees=\"0.0\" GPano:InitialViewPitchDegrees=\"0.0\" GPano:InitialViewRollDegrees=\"0.0\" GPano:InitialHorizontalFOVDegrees=\"{0}\" GPano:CroppedAreaLeftPixels=\"0\" GPano:CroppedAreaTopPixels=\"0\" GPano:CroppedAreaImageWidthPixels=\"{1}\" GPano:CroppedAreaImageHeightPixels=\"{2}\" GPano:FullPanoWidthPixels=\"{1}\" GPano:FullPanoHeightPixels=\"{2}\"/></rdf:RDF></x:xmpmeta>";

	[Token(Token = "0x400000A")]
	private const string XMP_CONTENT_TO_FORMAT_PNG = "XML:com.adobe.xmp\0\0\0\0\0<?xpacket begin=\"ï»¿\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.1.0-jc003\"> <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"> <rdf:Description rdf:about=\"\" xmlns:GPano=\"http://ns.google.com/photos/1.0/panorama/\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\" xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"> <GPano:UsePanoramaViewer>True</GPano:UsePanoramaViewer> <GPano:CaptureSoftware>Unity3D</GPano:CaptureSoftware> <GPano:StitchingSoftware>Unity3D</GPano:StitchingSoftware> <GPano:ProjectionType>equirectangular</GPano:ProjectionType> <GPano:PoseHeadingDegrees>180.0</GPano:PoseHeadingDegrees> <GPano:InitialViewHeadingDegrees>0.0</GPano:InitialViewHeadingDegrees> <GPano:InitialViewPitchDegrees>0.0</GPano:InitialViewPitchDegrees> <GPano:InitialViewRollDegrees>0.0</GPano:InitialViewRollDegrees> <GPano:InitialHorizontalFOVDegrees>{0}</GPano:InitialHorizontalFOVDegrees> <GPano:CroppedAreaLeftPixels>0</GPano:CroppedAreaLeftPixels> <GPano:CroppedAreaTopPixels>0</GPano:CroppedAreaTopPixels> <GPano:CroppedAreaImageWidthPixels>{1}</GPano:CroppedAreaImageWidthPixels> <GPano:CroppedAreaImageHeightPixels>{2}</GPano:CroppedAreaImageHeightPixels> <GPano:FullPanoWidthPixels>{1}</GPano:FullPanoWidthPixels> <GPano:FullPanoHeightPixels>{2}</GPano:FullPanoHeightPixels> <tiff:Orientation>1</tiff:Orientation> <exif:PixelXDimension>{1}</exif:PixelXDimension> <exif:PixelYDimension>{2}</exif:PixelYDimension> </rdf:Description></rdf:RDF></x:xmpmeta><?xpacket end=\"w\"?>";

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static uint[] CRC_TABLE_PNG;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x21DDDFC", Offset = "0x21DCDFC", VA = "0x21DDDFC")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x21DE4A4", Offset = "0x21DD4A4", VA = "0x21DE4A4")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x21DE448", Offset = "0x21DD448", VA = "0x21DE448")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x21DE504", Offset = "0x21DD504", VA = "0x21DE504")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x21DEDEC", Offset = "0x21DDDEC", VA = "0x21DEDEC")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x21DEC9C", Offset = "0x21DDC9C", VA = "0x21DEC9C")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x21DEDB0", Offset = "0x21DDDB0", VA = "0x21DEDB0")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x21DE8FC", Offset = "0x21DD8FC", VA = "0x21DE8FC")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x21DEEBC", Offset = "0x21DDEBC", VA = "0x21DEEBC")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x21DF180", Offset = "0x21DE180", VA = "0x21DF180")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x21DF0C0", Offset = "0x21DE0C0", VA = "0x21DF0C0")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x21DF248", Offset = "0x21DE248", VA = "0x21DF248")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Image _image;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x21DF2A4", Offset = "0x21DE2A4", VA = "0x21DF2A4")]
	public void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x21DF45C", Offset = "0x21DE45C", VA = "0x21DF45C", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x21DF6C8", Offset = "0x21DE6C8", VA = "0x21DF6C8")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000006")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x21DF6D0", Offset = "0x21DE6D0", VA = "0x21DF6D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x21DF7D8", Offset = "0x21DE7D8", VA = "0x21DF7D8")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000007")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x21DF7E0", Offset = "0x21DE7E0", VA = "0x21DF7E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x21DF904", Offset = "0x21DE904", VA = "0x21DF904")]
	public ForcedReset()
	{
	}
}
[Token(Token = "0x2000008")]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
[EditorBrowsable(EditorBrowsableState.Never)]
[CompilerGenerated]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
	[Token(Token = "0x2000009")]
	private struct MonoScriptData
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte[] FilePathsData;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public byte[] TypesData;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int TotalTypes;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int TotalFiles;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsEditorOnly;
	}

	[MethodImpl(256)]
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x21DF90C", Offset = "0x21DE90C", VA = "0x21DF90C")]
	private static MonoScriptData Get()
	{
		return default(MonoScriptData);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x21DF9D0", Offset = "0x21DE9D0", VA = "0x21DF9D0")]
	public UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200000A")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x200000B")]
		public enum Mode
		{
			[Token(Token = "0x4000018")]
			Trigger,
			[Token(Token = "0x4000019")]
			Replace,
			[Token(Token = "0x400001A")]
			Activate,
			[Token(Token = "0x400001B")]
			Enable,
			[Token(Token = "0x400001C")]
			Animate,
			[Token(Token = "0x400001D")]
			Deactivate
		}

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mode action;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject source;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int triggerCount;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool repeatTrigger;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x21DF9D8", Offset = "0x21DE9D8", VA = "0x21DF9D8")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x21DFE14", Offset = "0x21DEE14", VA = "0x21DFE14")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x21DFE18", Offset = "0x21DEE18", VA = "0x21DFE18")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x21E0694", Offset = "0x21DF694", VA = "0x21E0694")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public class ReplacementList
		{
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x21E069C", Offset = "0x21DF69C", VA = "0x21E069C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x21DFE30", Offset = "0x21DEE30", VA = "0x21DFE30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x21E068C", Offset = "0x21DF68C", VA = "0x21E068C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000010")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x21E07DC", Offset = "0x21DF7DC", VA = "0x21E07DC")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_LastRealTime;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x21E06F4", Offset = "0x21DF6F4", VA = "0x21E06F4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x21E0710", Offset = "0x21DF710", VA = "0x21E0710")]
		private void Update()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x21E07D4", Offset = "0x21DF7D4", VA = "0x21E07D4")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x21E07EC", Offset = "0x21DF7EC", VA = "0x21E07EC")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x21E0840", Offset = "0x21DF840", VA = "0x21E0840")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x21E0848", Offset = "0x21DF848", VA = "0x21E0848")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x21E0850", Offset = "0x21DF850", VA = "0x21E0850")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x21E0988", Offset = "0x21DF988", VA = "0x21E0988")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000012")]
	public class CurveControlledBob
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x21E09CC", Offset = "0x21DF9CC", VA = "0x21E09CC")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x21E0A6C", Offset = "0x21DFA6C", VA = "0x21E0A6C")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x21E0B70", Offset = "0x21DFB70", VA = "0x21E0B70")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0x21E149C", Offset = "0x21E049C", VA = "0x21E149C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x21E14DC", Offset = "0x21E04DC", VA = "0x21E14DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x21E1240", Offset = "0x21E0240", VA = "0x21E1240")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x21E1270", Offset = "0x21E0270", VA = "0x21E1270", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x21E1274", Offset = "0x21E0274", VA = "0x21E1274", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x21E14A4", Offset = "0x21E04A4", VA = "0x21E14A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000036")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000037")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000038")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000039")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x400003A")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x400003B")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x21E0DAC", Offset = "0x21DFDAC", VA = "0x21E0DAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x21E11D0", Offset = "0x21E01D0", VA = "0x21E11D0")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x21E1124", Offset = "0x21E0124", VA = "0x21E1124")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x21E1268", Offset = "0x21E0268", VA = "0x21E1268")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Light sunLight;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minHeight;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minShadowDistance;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float minShadowBias;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxHeight;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxShadowDistance;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxShadowBias;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float adaptTime;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_SmoothHeight;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OriginalStrength;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x21E14E4", Offset = "0x21E04E4", VA = "0x21E14E4")]
		private void Start()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x21E150C", Offset = "0x21E050C", VA = "0x21E150C")]
		private void Update()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x21E17F0", Offset = "0x21E07F0", VA = "0x21E17F0")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x21E181C", Offset = "0x21E081C", VA = "0x21E181C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x21E1878", Offset = "0x21E0878", VA = "0x21E1878")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class FOVKick
	{
		[Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0x21E1C1C", Offset = "0x21E0C1C", VA = "0x21E1C1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x21E1C5C", Offset = "0x21E0C5C", VA = "0x21E1C5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x21E1A9C", Offset = "0x21E0A9C", VA = "0x21E1A9C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x21E1AE0", Offset = "0x21E0AE0", VA = "0x21E1AE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x21E1AE4", Offset = "0x21E0AE4", VA = "0x21E1AE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x21E1C24", Offset = "0x21E0C24", VA = "0x21E1C24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000019")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0x21E1D8C", Offset = "0x21E0D8C", VA = "0x21E1D8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000051")]
				[Address(RVA = "0x21E1DCC", Offset = "0x21E0DCC", VA = "0x21E1DCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0x21E1A14", Offset = "0x21E0A14", VA = "0x21E1A14")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x21E1C64", Offset = "0x21E0C64", VA = "0x21E1C64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x21E1C68", Offset = "0x21E0C68", VA = "0x21E1C68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000050")]
			[Address(RVA = "0x21E1D94", Offset = "0x21E0D94", VA = "0x21E1D94", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x21E1890", Offset = "0x21E0890", VA = "0x21E1890")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x21E18CC", Offset = "0x21E08CC", VA = "0x21E18CC")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x21E19AC", Offset = "0x21E09AC", VA = "0x21E19AC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x21E19B4", Offset = "0x21E09B4", VA = "0x21E19B4")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x21E1A3C", Offset = "0x21E0A3C", VA = "0x21E1A3C")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x21E1AC4", Offset = "0x21E0AC4", VA = "0x21E1AC4")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400005F")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentFps;

		[Token(Token = "0x4000063")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Text m_Text;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x21E1DD4", Offset = "0x21E0DD4", VA = "0x21E1DD4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x21E1E38", Offset = "0x21E0E38", VA = "0x21E1E38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x21E1F2C", Offset = "0x21E0F2C", VA = "0x21E1F2C")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600005B")]
				[Address(RVA = "0x21E2168", Offset = "0x21E1168", VA = "0x21E2168", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005D")]
				[Address(RVA = "0x21E21A8", Offset = "0x21E11A8", VA = "0x21E21A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x21E1F9C", Offset = "0x21E0F9C", VA = "0x21E1F9C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x21E1FCC", Offset = "0x21E0FCC", VA = "0x21E1FCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x21E1FD0", Offset = "0x21E0FD0", VA = "0x21E1FD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x21E2170", Offset = "0x21E1170", VA = "0x21E2170", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x21E1F34", Offset = "0x21E0F34", VA = "0x21E1F34")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x21E1F3C", Offset = "0x21E0F3C", VA = "0x21E1F3C")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x21E1FC4", Offset = "0x21E0FC4", VA = "0x21E1FC4")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000065")]
				[Address(RVA = "0x21E25F8", Offset = "0x21E15F8", VA = "0x21E25F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x21E2638", Offset = "0x21E1638", VA = "0x21E2638", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x21E2348", Offset = "0x21E1348", VA = "0x21E2348")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x21E2378", Offset = "0x21E1378", VA = "0x21E2378", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x21E237C", Offset = "0x21E137C", VA = "0x21E237C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x21E2600", Offset = "0x21E1600", VA = "0x21E2600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 originalPosition;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion originalRotation;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x21E21B0", Offset = "0x21E11B0", VA = "0x21E21B0")]
		private void Start()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x21E22B8", Offset = "0x21E12B8", VA = "0x21E22B8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x21E22D8", Offset = "0x21E12D8", VA = "0x21E22D8")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x21E2370", Offset = "0x21E1370", VA = "0x21E2370")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600006E")]
				[Address(RVA = "0x21E2A00", Offset = "0x21E1A00", VA = "0x21E2A00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000070")]
				[Address(RVA = "0x21E2A40", Offset = "0x21E1A40", VA = "0x21E2A40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x21E26A0", Offset = "0x21E16A0", VA = "0x21E26A0")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x21E26E8", Offset = "0x21E16E8", VA = "0x21E26E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x21E26EC", Offset = "0x21E16EC", VA = "0x21E26EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x21E2A08", Offset = "0x21E1A08", VA = "0x21E2A08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDuration;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxDuration;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x21E2640", Offset = "0x21E1640", VA = "0x21E2640")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x21E26C8", Offset = "0x21E16C8", VA = "0x21E26C8")]
		public void Stop()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x21E26D4", Offset = "0x21E16D4", VA = "0x21E26D4")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000022")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000082")]
			Standalone,
			[Token(Token = "0x4000083")]
			Mobile
		}

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x21E2A48", Offset = "0x21E1A48", VA = "0x21E2A48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x21E2A4C", Offset = "0x21E1A4C", VA = "0x21E2A4C")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x21E2A5C", Offset = "0x21E1A5C", VA = "0x21E2A5C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x21E2E44", Offset = "0x21E1E44", VA = "0x21E2E44")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text camSwitchButton;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] objects;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x21E2EC8", Offset = "0x21E1EC8", VA = "0x21E2EC8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x21E2F20", Offset = "0x21E1F20", VA = "0x21E2F20")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x21E2FE0", Offset = "0x21E1FE0", VA = "0x21E2FE0")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rotationSpeed;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float dampingTime;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool relative;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x21E2FE8", Offset = "0x21E1FE8", VA = "0x21E2FE8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x21E3018", Offset = "0x21E2018", VA = "0x21E3018")]
		private void Update()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x21E3498", Offset = "0x21E2498", VA = "0x21E3498")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x21E34B8", Offset = "0x21E24B8", VA = "0x21E34B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x21E34BC", Offset = "0x21E24BC", VA = "0x21E34BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x21E37F0", Offset = "0x21E27F0", VA = "0x21E37F0")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000027")]
		public enum Action
		{
			[Token(Token = "0x4000098")]
			Activate,
			[Token(Token = "0x4000099")]
			Deactivate,
			[Token(Token = "0x400009A")]
			Destroy,
			[Token(Token = "0x400009B")]
			ReloadLevel,
			[Token(Token = "0x400009C")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000028")]
		public class Entry
		{
			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x21E3B1C", Offset = "0x21E2B1C", VA = "0x21E3B1C")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000029")]
		public class Entries
		{
			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000084")]
			[Address(RVA = "0x21E3B14", Offset = "0x21E2B14", VA = "0x21E3B14")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0x21E3BE8", Offset = "0x21E2BE8", VA = "0x21E3BE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x21E3C28", Offset = "0x21E2C28", VA = "0x21E3C28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0x21E3A3C", Offset = "0x21E2A3C", VA = "0x21E3A3C")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000086")]
			[Address(RVA = "0x21E3B24", Offset = "0x21E2B24", VA = "0x21E3B24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x21E3B28", Offset = "0x21E2B28", VA = "0x21E3B28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0x21E3BF0", Offset = "0x21E2BF0", VA = "0x21E3BF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x21E3CF4", Offset = "0x21E2CF4", VA = "0x21E3CF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000090")]
				[Address(RVA = "0x21E3D34", Offset = "0x21E2D34", VA = "0x21E3D34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x21E3A64", Offset = "0x21E2A64", VA = "0x21E3A64")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x21E3C30", Offset = "0x21E2C30", VA = "0x21E3C30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x21E3C34", Offset = "0x21E2C34", VA = "0x21E3C34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0x21E3CFC", Offset = "0x21E2CFC", VA = "0x21E3CFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002C")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000094")]
				[Address(RVA = "0x21E3E34", Offset = "0x21E2E34", VA = "0x21E3E34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000096")]
				[Address(RVA = "0x21E3E74", Offset = "0x21E2E74", VA = "0x21E3E74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0x21E3A8C", Offset = "0x21E2A8C", VA = "0x21E3A8C")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x21E3D3C", Offset = "0x21E2D3C", VA = "0x21E3D3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x21E3D40", Offset = "0x21E2D40", VA = "0x21E3D40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0x21E3E3C", Offset = "0x21E2E3C", VA = "0x21E3E3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Entries entries;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x21E3804", Offset = "0x21E2804", VA = "0x21E3804")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x21E391C", Offset = "0x21E291C", VA = "0x21E391C")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x21E397C", Offset = "0x21E297C", VA = "0x21E397C")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x21E39DC", Offset = "0x21E29DC", VA = "0x21E39DC")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x21E3AB4", Offset = "0x21E2AB4", VA = "0x21E3AB4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x21E3E7C", Offset = "0x21E2E7C", VA = "0x21E3E7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x21E3ECC", Offset = "0x21E2ECC", VA = "0x21E3ECC")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x21E3F5C", Offset = "0x21E2F5C", VA = "0x21E3F5C")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002F")]
		public class WaypointList
		{
			[Token(Token = "0x40000BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x21E4A34", Offset = "0x21E3A34", VA = "0x21E4A34")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000030")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x21E4634", Offset = "0x21E3634", VA = "0x21E4634")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaypointList waypointList;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int numPoints;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] points;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] distances;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p0n;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p1n;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int p2n;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int p3n;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float i;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 P0;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 P1;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 P2;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 P3;

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x21E3F6C", Offset = "0x21E2F6C", VA = "0x21E3F6C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x21E3F74", Offset = "0x21E2F74", VA = "0x21E3F74")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x21E3F7C", Offset = "0x21E2F7C", VA = "0x21E3F7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x21E3F98", Offset = "0x21E2F98", VA = "0x21E3F98")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x21E42A8", Offset = "0x21E32A8", VA = "0x21E42A8")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x21E43D8", Offset = "0x21E33D8", VA = "0x21E43D8")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x21E4644", Offset = "0x21E3644", VA = "0x21E4644")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x21E3FE8", Offset = "0x21E2FE8", VA = "0x21E3FE8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x21E4750", Offset = "0x21E3750", VA = "0x21E4750")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x21E49C0", Offset = "0x21E39C0", VA = "0x21E49C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x21E4758", Offset = "0x21E3758", VA = "0x21E4758")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x21E49C8", Offset = "0x21E39C8", VA = "0x21E49C8")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000D0")]
			SmoothAlongRoute,
			[Token(Token = "0x40000D1")]
			PointToPoint
		}

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform target;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float progressDistance;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int progressNum;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private float speed;

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x21E4A8C", Offset = "0x21E3A8C", VA = "0x21E4A8C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x21E4AA0", Offset = "0x21E3AA0", VA = "0x21E4AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x21E4AB4", Offset = "0x21E3AB4", VA = "0x21E4AB4")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x21E4AC8", Offset = "0x21E3AC8", VA = "0x21E4AC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x21E4ADC", Offset = "0x21E3ADC", VA = "0x21E4ADC")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x21E4AF0", Offset = "0x21E3AF0", VA = "0x21E4AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x21E4B04", Offset = "0x21E3B04", VA = "0x21E4B04")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x21E4BE8", Offset = "0x21E3BE8", VA = "0x21E4BE8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x21E4CB4", Offset = "0x21E3CB4", VA = "0x21E4CB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x21E51A4", Offset = "0x21E41A4", VA = "0x21E51A4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x21E5340", Offset = "0x21E4340", VA = "0x21E5340")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000033")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectAngle;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float effectWidth;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float effectDistance;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float force;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x21E535C", Offset = "0x21E435C", VA = "0x21E535C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x21E5400", Offset = "0x21E4400", VA = "0x21E5400")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x21E5990", Offset = "0x21E4990", VA = "0x21E5990")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x21E5EA4", Offset = "0x21E4EA4", VA = "0x21E5EA4")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0x21E671C", Offset = "0x21E571C", VA = "0x21E671C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0x21E675C", Offset = "0x21E575C", VA = "0x21E675C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x21E5F18", Offset = "0x21E4F18", VA = "0x21E5F18")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x21E6094", Offset = "0x21E5094", VA = "0x21E6094", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x21E6098", Offset = "0x21E5098", VA = "0x21E6098", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x21E6724", Offset = "0x21E5724", VA = "0x21E6724", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform firePrefab;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int numDebrisPieces;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int numFires;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x21E5EB8", Offset = "0x21E4EB8", VA = "0x21E5EB8")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x21E5F40", Offset = "0x21E4F40", VA = "0x21E5F40")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x21E608C", Offset = "0x21E508C", VA = "0x21E608C")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0x21E6C10", Offset = "0x21E5C10", VA = "0x21E6C10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C7")]
				[Address(RVA = "0x21E6C50", Offset = "0x21E5C50", VA = "0x21E6C50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x21E67C4", Offset = "0x21E57C4", VA = "0x21E67C4")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x21E67FC", Offset = "0x21E57FC", VA = "0x21E67FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x21E6800", Offset = "0x21E5800", VA = "0x21E6800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x21E6C18", Offset = "0x21E5C18", VA = "0x21E6C18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float explosionForce;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x21E6764", Offset = "0x21E5764", VA = "0x21E6764")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x21E67EC", Offset = "0x21E57EC", VA = "0x21E67EC")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0x21E70C4", Offset = "0x21E60C4", VA = "0x21E70C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0x21E7104", Offset = "0x21E6104", VA = "0x21E7104", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x21E6D14", Offset = "0x21E5D14", VA = "0x21E6D14")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x21E6D68", Offset = "0x21E5D68", VA = "0x21E6D68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x21E6D6C", Offset = "0x21E5D6C", VA = "0x21E6D6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x21E70CC", Offset = "0x21E60CC", VA = "0x21E70CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sizeMultiplier;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool reset;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float resetTimeDelay;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Exploded;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x21E6C58", Offset = "0x21E5C58", VA = "0x21E6C58")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x21E6CA8", Offset = "0x21E5CA8", VA = "0x21E6CA8")]
		[IteratorStateMachine(typeof(<OnCollisionEnter>d__8))]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x21E6D3C", Offset = "0x21E5D3C", VA = "0x21E6D3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x21E6D44", Offset = "0x21E5D44", VA = "0x21E6D44")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float multiplier;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x21E710C", Offset = "0x21E610C", VA = "0x21E710C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x21E715C", Offset = "0x21E615C", VA = "0x21E715C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x21E71D4", Offset = "0x21E61D4", VA = "0x21E71D4")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_Rnd;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_Burning;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Light m_Light;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x21E71E4", Offset = "0x21E61E4", VA = "0x21E71E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x21E724C", Offset = "0x21E624C", VA = "0x21E724C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x21E7434", Offset = "0x21E6434", VA = "0x21E7434")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x21E745C", Offset = "0x21E645C", VA = "0x21E745C")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxPower;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minPower;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float changeSpeed;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_Power;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x21E746C", Offset = "0x21E646C", VA = "0x21E746C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x21E75E8", Offset = "0x21E65E8", VA = "0x21E75E8")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float multiplier;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x21E7604", Offset = "0x21E6604", VA = "0x21E7604")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x21E7744", Offset = "0x21E6744", VA = "0x21E7744")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x21E7754", Offset = "0x21E6754", VA = "0x21E7754")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x21E7804", Offset = "0x21E6804", VA = "0x21E7804")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float force;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x21E780C", Offset = "0x21E680C", VA = "0x21E780C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x21E785C", Offset = "0x21E685C", VA = "0x21E785C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x21E7A7C", Offset = "0x21E6A7C", VA = "0x21E7A7C")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000040")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string axisName;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float axisValue;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float responseSpeed;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x21E7B00", Offset = "0x21E6B00", VA = "0x21E7B00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x21E7D48", Offset = "0x21E6D48", VA = "0x21E7D48")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x21E7EC0", Offset = "0x21E6EC0", VA = "0x21E7EC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x21E7F30", Offset = "0x21E6F30", VA = "0x21E7F30", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x21E7FF4", Offset = "0x21E6FF4", VA = "0x21E7FF4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x21E8050", Offset = "0x21E7050", VA = "0x21E8050")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Name;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x21E80B4", Offset = "0x21E70B4", VA = "0x21E80B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x21E80B8", Offset = "0x21E70B8", VA = "0x21E80B8")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x21E8180", Offset = "0x21E7180", VA = "0x21E8180")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x21E8248", Offset = "0x21E7248", VA = "0x21E8248")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x21E8310", Offset = "0x21E7310", VA = "0x21E8310")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x21E83D8", Offset = "0x21E73D8", VA = "0x21E83D8")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x21E84A0", Offset = "0x21E74A0", VA = "0x21E84A0")]
		public void Update()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x21E84A4", Offset = "0x21E74A4", VA = "0x21E84A4")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000043")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x400010B")]
			Hardware,
			[Token(Token = "0x400010C")]
			Touch
		}

		[Token(Token = "0x2000044")]
		public class VirtualAxis
		{
			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000021")]
			public string name
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0x21E9160", Offset = "0x21E8160", VA = "0x21E9160")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600010A")]
				[Address(RVA = "0x21E9168", Offset = "0x21E8168", VA = "0x21E9168")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600010B")]
				[Address(RVA = "0x21E9170", Offset = "0x21E8170", VA = "0x21E9170")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600010C")]
				[Address(RVA = "0x21E9178", Offset = "0x21E8178", VA = "0x21E9178")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float GetValue
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0x21E91C0", Offset = "0x21E81C0", VA = "0x21E91C0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000024")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0x21E91C8", Offset = "0x21E81C8", VA = "0x21E91C8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x21E7C48", Offset = "0x21E6C48", VA = "0x21E7C48")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x21E9184", Offset = "0x21E8184", VA = "0x21E9184")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x21E7ED8", Offset = "0x21E6ED8", VA = "0x21E7ED8")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x21E91B8", Offset = "0x21E81B8", VA = "0x21E91B8")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000045")]
		public class VirtualButton
		{
			[Token(Token = "0x4000112")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000113")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000114")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000025")]
			public string name
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0x21E91D0", Offset = "0x21E81D0", VA = "0x21E91D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x21E91D8", Offset = "0x21E81D8", VA = "0x21E91D8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000115")]
				[Address(RVA = "0x21E91E0", Offset = "0x21E81E0", VA = "0x21E91E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x21E91E8", Offset = "0x21E81E8", VA = "0x21E91E8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButton
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x21E930C", Offset = "0x21E830C", VA = "0x21E930C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000028")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x21E9314", Offset = "0x21E8314", VA = "0x21E9314")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000029")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x21E9338", Offset = "0x21E8338", VA = "0x21E9338")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x21E91F4", Offset = "0x21E81F4", VA = "0x21E91F4")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x21E922C", Offset = "0x21E822C", VA = "0x21E922C")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0x21E9268", Offset = "0x21E8268", VA = "0x21E9268")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600011A")]
			[Address(RVA = "0x21E9294", Offset = "0x21E8294", VA = "0x21E9294")]
			public void Released()
			{
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0x21E92B4", Offset = "0x21E82B4", VA = "0x21E92B4")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000020")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x21E8F8C", Offset = "0x21E7F8C", VA = "0x21E8F8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x21E84AC", Offset = "0x21E74AC", VA = "0x21E84AC")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x21E8560", Offset = "0x21E7560", VA = "0x21E8560")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x21E7BE0", Offset = "0x21E6BE0", VA = "0x21E7BE0")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x21E8650", Offset = "0x21E7650", VA = "0x21E8650")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x21E7C78", Offset = "0x21E6C78", VA = "0x21E7C78")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x21E8894", Offset = "0x21E7894", VA = "0x21E8894")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x21E8A80", Offset = "0x21E7A80", VA = "0x21E8A80")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x21E8BC4", Offset = "0x21E7BC4", VA = "0x21E8BC4")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x21E7CE0", Offset = "0x21E6CE0", VA = "0x21E7CE0")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x21E3440", Offset = "0x21E2440", VA = "0x21E3440")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x21E8DD0", Offset = "0x21E7DD0", VA = "0x21E8DD0")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x21E8D50", Offset = "0x21E7D50", VA = "0x21E8D50")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x21E8E28", Offset = "0x21E7E28", VA = "0x21E8E28")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x21DF894", Offset = "0x21DE894", VA = "0x21DF894")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x21E8E98", Offset = "0x21E7E98", VA = "0x21E8E98")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x21E8110", Offset = "0x21E7110", VA = "0x21E8110")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x21E81D8", Offset = "0x21E71D8", VA = "0x21E81D8")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x21E82A0", Offset = "0x21E72A0", VA = "0x21E82A0")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x21E8430", Offset = "0x21E7430", VA = "0x21E8430")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x21E8368", Offset = "0x21E7368", VA = "0x21E8368")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x21E8F08", Offset = "0x21E7F08", VA = "0x21E8F08")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x21E8FF8", Offset = "0x21E7FF8", VA = "0x21E8FF8")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x21E9070", Offset = "0x21E8070", VA = "0x21E9070")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x21E90E8", Offset = "0x21E80E8", VA = "0x21E90E8")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string axis;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x21E935C", Offset = "0x21E835C", VA = "0x21E935C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x21E9360", Offset = "0x21E8360", VA = "0x21E9360")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x21E93D0", Offset = "0x21E83D0", VA = "0x21E93D0")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000048")]
		public enum AxisOption
		{
			[Token(Token = "0x4000120")]
			Both,
			[Token(Token = "0x4000121")]
			OnlyHorizontal,
			[Token(Token = "0x4000122")]
			OnlyVertical
		}

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MovementRange;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string horizontalAxisName;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string verticalAxisName;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_UseX;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		private bool m_UseY;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x21E93D8", Offset = "0x21E83D8", VA = "0x21E93D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x21E9518", Offset = "0x21E8518", VA = "0x21E9518")]
		private void Start()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x21E9548", Offset = "0x21E8548", VA = "0x21E9548")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x21E93DC", Offset = "0x21E83DC", VA = "0x21E93DC")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x21E95A8", Offset = "0x21E85A8", VA = "0x21E95A8", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x21E96F4", Offset = "0x21E86F4", VA = "0x21E96F4", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x21E9730", Offset = "0x21E8730", VA = "0x21E9730", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x21E9734", Offset = "0x21E8734", VA = "0x21E9734")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x21E9774", Offset = "0x21E8774", VA = "0x21E9774")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x21E97EC", Offset = "0x21E87EC", VA = "0x21E97EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x21E97FC", Offset = "0x21E87FC", VA = "0x21E97FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x21E97F4", Offset = "0x21E87F4", VA = "0x21E97F4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x21E9904", Offset = "0x21E8904", VA = "0x21E9904")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x21E9BFC", Offset = "0x21E8BFC", VA = "0x21E9BFC")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000129")]
			ForwardAxis,
			[Token(Token = "0x400012A")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200004C")]
		public class AxisMapping
		{
			[Token(Token = "0x200004D")]
			public enum MappingType
			{
				[Token(Token = "0x400012E")]
				NamedAxis,
				[Token(Token = "0x400012F")]
				MousePositionX,
				[Token(Token = "0x4000130")]
				MousePositionY,
				[Token(Token = "0x4000131")]
				MousePositionZ
			}

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000134")]
			[Address(RVA = "0x21E9F3C", Offset = "0x21E8F3C", VA = "0x21E9F3C")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisMapping mapping;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fullTiltAngle;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float centreAngleOffset;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x21E9C04", Offset = "0x21E8C04", VA = "0x21E9C04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x21E9CB4", Offset = "0x21E8CB4", VA = "0x21E9CB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x21E9F14", Offset = "0x21E8F14", VA = "0x21E9F14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x21E9F2C", Offset = "0x21E8F2C", VA = "0x21E9F2C")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200004F")]
		public enum AxisOption
		{
			[Token(Token = "0x4000145")]
			Both,
			[Token(Token = "0x4000146")]
			OnlyHorizontal,
			[Token(Token = "0x4000147")]
			OnlyVertical
		}

		[Token(Token = "0x2000050")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000149")]
			Absolute,
			[Token(Token = "0x400014A")]
			Relative,
			[Token(Token = "0x400014B")]
			Swipe
		}

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string horizontalAxisName;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string verticalAxisName;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Xsensitivity;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Ysensitivity;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_UseX;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_UseY;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_Dragging;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_Id;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 m_Center;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image m_Image;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x21E9F44", Offset = "0x21E8F44", VA = "0x21E9F44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x21EA084", Offset = "0x21E9084", VA = "0x21EA084")]
		private void Start()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x21E9F48", Offset = "0x21E8F48", VA = "0x21E9F48")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x21EA0F8", Offset = "0x21E90F8", VA = "0x21EA0F8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x21EA1F8", Offset = "0x21E91F8", VA = "0x21EA1F8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x21EA234", Offset = "0x21E9234", VA = "0x21EA234")]
		private void Update()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x21EA40C", Offset = "0x21E940C", VA = "0x21EA40C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x21EA46C", Offset = "0x21E946C", VA = "0x21EA46C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x21EA52C", Offset = "0x21E952C", VA = "0x21EA52C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700002A")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x21EA5AC", Offset = "0x21E95AC", VA = "0x21EA5AC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x21EA5B8", Offset = "0x21E95B8", VA = "0x21EA5B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x21E85F8", Offset = "0x21E75F8", VA = "0x21E85F8")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x21E86B8", Offset = "0x21E76B8", VA = "0x21E86B8")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x21E8710", Offset = "0x21E7710", VA = "0x21E8710")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x21E88FC", Offset = "0x21E78FC", VA = "0x21E88FC")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x21E8B34", Offset = "0x21E7B34", VA = "0x21E8B34")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x21E8C2C", Offset = "0x21E7C2C", VA = "0x21E8C2C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x21E8CBC", Offset = "0x21E7CBC", VA = "0x21E8CBC")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x21E9068", Offset = "0x21E8068", VA = "0x21E9068")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x21E90E0", Offset = "0x21E80E0", VA = "0x21E90E0")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x21E9158", Offset = "0x21E8158", VA = "0x21E9158")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600014A")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x600014B")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600014C")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600014D")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600014E")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600014F")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000150")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000151")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000152")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000153")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000154")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x21EA5C4", Offset = "0x21E95C4", VA = "0x21EA5C4")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000052")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x21EA6D0", Offset = "0x21E96D0", VA = "0x21EA6D0")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x21EA768", Offset = "0x21E9768", VA = "0x21EA768")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x21EA7F8", Offset = "0x21E97F8", VA = "0x21EA7F8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x21EA890", Offset = "0x21E9890", VA = "0x21EA890", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x21EA944", Offset = "0x21E9944", VA = "0x21EA944", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x21EA9EC", Offset = "0x21E99EC", VA = "0x21EA9EC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x21EAA88", Offset = "0x21E9A88", VA = "0x21EAA88", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x21EAB24", Offset = "0x21E9B24", VA = "0x21EAB24", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x21EABBC", Offset = "0x21E9BBC", VA = "0x21EABBC", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x21EAC60", Offset = "0x21E9C60", VA = "0x21EAC60", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x21EAD0C", Offset = "0x21E9D0C", VA = "0x21EAD0C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x21EADB8", Offset = "0x21E9DB8", VA = "0x21EADB8", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x21EAE50", Offset = "0x21E9E50", VA = "0x21EAE50", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x21E8558", Offset = "0x21E7558", VA = "0x21E8558")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x21EAE5C", Offset = "0x21E9E5C", VA = "0x21EAE5C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x21EAE70", Offset = "0x21E9E70", VA = "0x21EAE70", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x21EAE7C", Offset = "0x21E9E7C", VA = "0x21EAE7C", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x21EAE88", Offset = "0x21E9E88", VA = "0x21EAE88", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x21EAE94", Offset = "0x21E9E94", VA = "0x21EAE94", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x21EAEE0", Offset = "0x21E9EE0", VA = "0x21EAEE0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x21EAF2C", Offset = "0x21E9F2C", VA = "0x21EAF2C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x21EAF78", Offset = "0x21E9F78", VA = "0x21EAF78", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x21EAFC4", Offset = "0x21E9FC4", VA = "0x21EAFC4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x21EB010", Offset = "0x21EA010", VA = "0x21EB010", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x21EB05C", Offset = "0x21EA05C", VA = "0x21EB05C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x21E855C", Offset = "0x21E755C", VA = "0x21E855C")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000054")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000154")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x21EB064", Offset = "0x21EA064", VA = "0x21EB064")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x21EB0D0", Offset = "0x21EA0D0", VA = "0x21EB0D0")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x21EB2A0", Offset = "0x21EA2A0", VA = "0x21EB2A0")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Ball ball;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 move;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform cam;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 camForward;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool jump;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x21EB2C4", Offset = "0x21EA2C4", VA = "0x21EB2C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x21EB3D0", Offset = "0x21EA3D0", VA = "0x21EB3D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x21EB7B0", Offset = "0x21EA7B0", VA = "0x21EB7B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x21EB7E0", Offset = "0x21EA7E0", VA = "0x21EB7E0")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000056")]
	[RequireComponent(typeof(NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform target;

		[Token(Token = "0x1700002B")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x21EB7E8", Offset = "0x21EA7E8", VA = "0x21EB7E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x21EB7F0", Offset = "0x21EA7F0", VA = "0x21EB7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x21EB7F8", Offset = "0x21EA7F8", VA = "0x21EB7F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x21EB800", Offset = "0x21EA800", VA = "0x21EB800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x21EB808", Offset = "0x21EA808", VA = "0x21EB808")]
		private void Start()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x21EB8B0", Offset = "0x21EA8B0", VA = "0x21EB8B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x21EBC34", Offset = "0x21EAC34", VA = "0x21EBC34")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x21EBC3C", Offset = "0x21EAC3C", VA = "0x21EBC3C")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(1f, 4f)]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Animator;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x400016A")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_TurnAmount;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float m_ForwardAmount;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CapsuleHeight;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_Crouching;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x21EBC44", Offset = "0x21EAC44", VA = "0x21EBC44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x21EB9D8", Offset = "0x21EA9D8", VA = "0x21EB9D8")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x21EC19C", Offset = "0x21EB19C", VA = "0x21EC19C")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x21EC490", Offset = "0x21EB490", VA = "0x21EC490")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x21EC6E0", Offset = "0x21EB6E0", VA = "0x21EC6E0")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x21EC0C4", Offset = "0x21EB0C4", VA = "0x21EC0C4")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x21EBFA8", Offset = "0x21EAFA8", VA = "0x21EBFA8")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x21EBF24", Offset = "0x21EAF24", VA = "0x21EBF24")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x21EC99C", Offset = "0x21EB99C", VA = "0x21EC99C")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x21EBD2C", Offset = "0x21EAD2C", VA = "0x21EBD2C")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x21ECA3C", Offset = "0x21EBA3C", VA = "0x21ECA3C")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Cam;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Move;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_Jump;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x21ECA58", Offset = "0x21EBA58", VA = "0x21ECA58")]
		private void Start()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x21ECB6C", Offset = "0x21EBB6C", VA = "0x21ECB6C")]
		private void Update()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x21ECBE8", Offset = "0x21EBBE8", VA = "0x21ECBE8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x21ECE7C", Offset = "0x21EBE7C", VA = "0x21ECE7C")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000059")]
	[RequireComponent(typeof(AudioSource))]
	[RequireComponent(typeof(CharacterController))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Camera m_Camera;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool m_Jump;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float m_YRotation;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 m_Input;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_StepCycle;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float m_NextStep;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private bool m_Jumping;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x21ECE84", Offset = "0x21EBE84", VA = "0x21ECE84")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x21ECFDC", Offset = "0x21EBFDC", VA = "0x21ECFDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x21ED13C", Offset = "0x21EC13C", VA = "0x21ED13C")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x21ED184", Offset = "0x21EC184", VA = "0x21ED184")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x21ED7C8", Offset = "0x21EC7C8", VA = "0x21ED7C8")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x21ED7FC", Offset = "0x21EC7FC", VA = "0x21ED7FC")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x21EDB90", Offset = "0x21ECB90", VA = "0x21EDB90")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x21ED948", Offset = "0x21EC948", VA = "0x21ED948")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x21ED5BC", Offset = "0x21EC5BC", VA = "0x21ED5BC")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x21ED0EC", Offset = "0x21EC0EC", VA = "0x21ED0EC")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x21EDFEC", Offset = "0x21ECFEC", VA = "0x21EDFEC")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x21EE110", Offset = "0x21ED110", VA = "0x21EE110")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera Camera;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float StrideInterval;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x21EE220", Offset = "0x21ED220", VA = "0x21EE220")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x21EE26C", Offset = "0x21ED26C", VA = "0x21EE26C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x21EE4E4", Offset = "0x21ED4E4", VA = "0x21EE4E4")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class MouseLook
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x21ECF8C", Offset = "0x21EBF8C", VA = "0x21ECF8C")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x21EDC80", Offset = "0x21ECC80", VA = "0x21EDC80")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x21EE5D8", Offset = "0x21ED5D8", VA = "0x21EE5D8")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x21EDB80", Offset = "0x21ECB80", VA = "0x21EDB80")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x21EE60C", Offset = "0x21ED60C", VA = "0x21EE60C")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x21EE574", Offset = "0x21ED574", VA = "0x21EE574")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x21EE684", Offset = "0x21ED684", VA = "0x21EE684")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005D")]
		public class MovementSettings
		{
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x21EF584", Offset = "0x21EE584", VA = "0x21EF584")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x21EF734", Offset = "0x21EE734", VA = "0x21EF734")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;

			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x21EF8E0", Offset = "0x21EE8E0", VA = "0x21EF8E0")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera cam;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MouseLook mouseLook;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_YRotation;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_Jump;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool m_Jumping;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700002D")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x21EE4C0", Offset = "0x21ED4C0", VA = "0x21EE4C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Grounded
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x21EE6B8", Offset = "0x21ED6B8", VA = "0x21EE6B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool Jumping
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x21EE6C0", Offset = "0x21ED6C0", VA = "0x21EE6C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public bool Running
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x21EE4DC", Offset = "0x21ED4DC", VA = "0x21EE4DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x21EE6C8", Offset = "0x21ED6C8", VA = "0x21EE6C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x21EE780", Offset = "0x21ED780", VA = "0x21EE780")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x21EE984", Offset = "0x21ED984", VA = "0x21EE984")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x21EF094", Offset = "0x21EE094", VA = "0x21EF094")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x21EF1F4", Offset = "0x21EE1F4", VA = "0x21EF1F4")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x21EEFDC", Offset = "0x21EDFDC", VA = "0x21EEFDC")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x21EE808", Offset = "0x21ED808", VA = "0x21EE808")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x21EEDD4", Offset = "0x21EDDD4", VA = "0x21EEDD4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x21EF638", Offset = "0x21EE638", VA = "0x21EF638")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200005F")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000060")]
		public enum UpdateType
		{
			[Token(Token = "0x40001C6")]
			FixedUpdate,
			[Token(Token = "0x40001C7")]
			LateUpdate,
			[Token(Token = "0x40001C8")]
			ManualUpdate
		}

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000031")]
		public Transform Target
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x21EFCC0", Offset = "0x21EECC0", VA = "0x21EFCC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x21EF8FC", Offset = "0x21EE8FC", VA = "0x21EF8FC", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x21EFA64", Offset = "0x21EEA64", VA = "0x21EFA64")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x21EFB28", Offset = "0x21EEB28", VA = "0x21EFB28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x21EFBF0", Offset = "0x21EEBF0", VA = "0x21EFBF0")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001B8")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x21EF9A0", Offset = "0x21EE9A0", VA = "0x21EF9A0")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x21EFCB8", Offset = "0x21EECB8", VA = "0x21EFCB8", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x21EFCC8", Offset = "0x21EECC8", VA = "0x21EFCC8")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x21EFCD8", Offset = "0x21EECD8", VA = "0x21EFCD8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x21F02DC", Offset = "0x21EF2DC", VA = "0x21F02DC")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Range(0f, 10f)]
		private float m_TurnSpeed;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_LookAngle;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TiltAngle;

		[Token(Token = "0x40001DE")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x21F0368", Offset = "0x21EF368", VA = "0x21F0368", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x21F0424", Offset = "0x21EF424", VA = "0x21F0424")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x21F0774", Offset = "0x21EF774", VA = "0x21F0774")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x21F0794", Offset = "0x21EF794", VA = "0x21F0794", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x21F0474", Offset = "0x21EF474", VA = "0x21F0474")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x21F08B8", Offset = "0x21EF8B8", VA = "0x21F08B8")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float m_TrackingBias;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x21F08D8", Offset = "0x21EF8D8", VA = "0x21F08D8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x21F0D78", Offset = "0x21EFD78", VA = "0x21F0D78")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x21F0DA8", Offset = "0x21EFDA8", VA = "0x21F0DA8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x21F0A10", Offset = "0x21EFA10", VA = "0x21F0A10", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x21F0D98", Offset = "0x21EFD98", VA = "0x21F0D98")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Cam;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform m_Pivot;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x21F0DE4", Offset = "0x21EFDE4", VA = "0x21F0DE4", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x21F0E54", Offset = "0x21EFE54", VA = "0x21F0E54")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x21F1694", Offset = "0x21F0694", VA = "0x21F1694", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x21F0F94", Offset = "0x21EFF94", VA = "0x21F0F94")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float clipMoveTime;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float returnTime;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float sphereCastRadius;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool visualiseInEditor;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float closestDistance;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string dontClipTag;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Cam;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_Pivot;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_OriginalDist;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_MoveVelocity;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float m_CurrentDist;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Ray m_Ray;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000032")]
		public bool protecting
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x21F0E5C", Offset = "0x21EFE5C", VA = "0x21F0E5C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x21F0E64", Offset = "0x21EFE64", VA = "0x21F0E64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x21F0E70", Offset = "0x21EFE70", VA = "0x21F0E70")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x21F0F9C", Offset = "0x21EFF9C", VA = "0x21F0F9C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x21F1624", Offset = "0x21F0624", VA = "0x21F1624")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_BoundSize;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera m_Cam;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform m_LastTarget;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x21F1788", Offset = "0x21F0788", VA = "0x21F1788", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x21F1AD4", Offset = "0x21F0AD4", VA = "0x21F1AD4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x21F1C14", Offset = "0x21F0C14", VA = "0x21F1C14", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x21F17F4", Offset = "0x21F07F4", VA = "0x21F17F4")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x21F1C38", Offset = "0x21F0C38", VA = "0x21F1C38")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x2000069")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform target;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float damping;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadFactor;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_OffsetZ;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x21F1C4C", Offset = "0x21F0C4C", VA = "0x21F1C4C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x21F1CCC", Offset = "0x21F0CCC", VA = "0x21F1CCC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x21F1FD8", Offset = "0x21F0FD8", VA = "0x21F1FD8")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xMargin;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float yMargin;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float xSmooth;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ySmooth;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 maxXAndY;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 minXAndY;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Player;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x21F1FEC", Offset = "0x21F0FEC", VA = "0x21F1FEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x21F204C", Offset = "0x21F104C", VA = "0x21F204C")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x21F20A0", Offset = "0x21F10A0", VA = "0x21F20A0")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x21F20F4", Offset = "0x21F10F4", VA = "0x21F20F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x21F20F8", Offset = "0x21F10F8", VA = "0x21F20F8")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x21F2294", Offset = "0x21F1294", VA = "0x21F2294")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[RequireComponent(typeof(PlatformerCharacter2D))]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_Jump;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x21F22A8", Offset = "0x21F12A8", VA = "0x21F22A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x21F22F8", Offset = "0x21F12F8", VA = "0x21F22F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x21F2378", Offset = "0x21F1378", VA = "0x21F2378")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x21F2684", Offset = "0x21F1684", VA = "0x21F2684")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_GroundCheck;

		[Token(Token = "0x400021C")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Grounded;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400021F")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animator m_Anim;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_FacingRight;

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x21F268C", Offset = "0x21F168C", VA = "0x21F268C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x21F276C", Offset = "0x21F176C", VA = "0x21F276C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x21F2418", Offset = "0x21F1418", VA = "0x21F2418")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x21F292C", Offset = "0x21F192C", VA = "0x21F292C")]
		private void Flip()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x21F299C", Offset = "0x21F199C", VA = "0x21F299C")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x21F29C4", Offset = "0x21F19C4", VA = "0x21F29C4")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x21F2A70", Offset = "0x21F1A70", VA = "0x21F2A70")]
		public Restarter()
		{
		}
	}
}
