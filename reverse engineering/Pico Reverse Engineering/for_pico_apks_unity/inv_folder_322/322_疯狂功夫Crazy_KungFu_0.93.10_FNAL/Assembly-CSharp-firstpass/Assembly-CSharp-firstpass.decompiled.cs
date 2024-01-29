using System;
using System.Collections;
using System.Collections.Generic;
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
			[Address(RVA = "0xC753D8", Offset = "0xC753D8", VA = "0xC753D8", Slot = "4")]
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
			[Address(RVA = "0xC75420", Offset = "0xC75420", VA = "0xC75420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xC74B8C", Offset = "0xC74B8C", VA = "0xC74B8C")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xC74BCC", Offset = "0xC74BCC", VA = "0xC74BCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xC74BD0", Offset = "0xC74BD0", VA = "0xC74BD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xC753E0", Offset = "0xC753E0", VA = "0xC753E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int imageWidth;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool saveAsJPEG;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xC74B24", Offset = "0xC74B24", VA = "0xC74B24")]
	[IteratorStateMachine(typeof(<Start>d__2))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC74BB4", Offset = "0xC74BB4", VA = "0xC74BB4")]
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
	[Address(RVA = "0xC74DB0", Offset = "0xC74DB0", VA = "0xC74DB0")]
	public static byte[] Capture(int width = 1024, bool encodeAsJPEG = true, [Optional] Camera renderCam, bool faceCameraDirection = true)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC75484", Offset = "0xC75484", VA = "0xC75484")]
	public static byte[] InsertXMPIntoTexture2D_JPEG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC75428", Offset = "0xC75428", VA = "0xC75428")]
	public static byte[] InsertXMPIntoTexture2D_PNG(Texture2D image)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xC754E4", Offset = "0xC754E4", VA = "0xC754E4")]
	private static byte[] DoTheHardWork_JPEG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xC75DCC", Offset = "0xC75DCC", VA = "0xC75DCC")]
	private static bool CheckBytesForXMPNamespace_JPEG(byte[] bytes, int startIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xC75C7C", Offset = "0xC75C7C", VA = "0xC75C7C")]
	private static bool SearchChunkForXMP_JPEG(byte[] bytes, ref int startIndex, ref int chunkSize)
	{
		return default(bool);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xC75D90", Offset = "0xC75D90", VA = "0xC75D90")]
	private static int FindIndexToInsertXMPCode_JPEG(byte[] bytes)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xC758DC", Offset = "0xC758DC", VA = "0xC758DC")]
	private static byte[] DoTheHardWork_PNG(byte[] fileBytes, int imageWidth, int imageHeight)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xC75E98", Offset = "0xC75E98", VA = "0xC75E98")]
	private static string CalculateCRC_PNG(string xmpContent)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xC7615C", Offset = "0xC7615C", VA = "0xC7615C")]
	private static uint UpdateCRC_PNG(string xmpContent)
	{
		return default(uint);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xC7609C", Offset = "0xC7609C", VA = "0xC7609C")]
	private static void CalculateCRCTable_PNG()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xC76224", Offset = "0xC76224", VA = "0xC76224")]
	private static byte[] CalculateCRCBytes_PNG(uint crc)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xC762B8", Offset = "0xC762B8", VA = "0xC762B8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xC76470", Offset = "0xC76470", VA = "0xC76470", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xC76754", Offset = "0xC76754", VA = "0xC76754")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000006")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000018")]
	[Address(RVA = "0xC7675C", Offset = "0xC7675C", VA = "0xC7675C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xC76864", Offset = "0xC76864", VA = "0xC76864")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000007")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600001A")]
	[Address(RVA = "0xC7686C", Offset = "0xC7686C", VA = "0xC7686C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xC76994", Offset = "0xC76994", VA = "0xC76994")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000008")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000009")]
		public enum Mode
		{
			[Token(Token = "0x4000013")]
			Trigger,
			[Token(Token = "0x4000014")]
			Replace,
			[Token(Token = "0x4000015")]
			Activate,
			[Token(Token = "0x4000016")]
			Enable,
			[Token(Token = "0x4000017")]
			Animate,
			[Token(Token = "0x4000018")]
			Deactivate
		}

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xC7699C", Offset = "0xC7699C", VA = "0xC7699C")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xC76DD8", Offset = "0xC76DD8", VA = "0xC76DD8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xC76DDC", Offset = "0xC76DDC", VA = "0xC76DDC")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000B")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000021")]
			[Address(RVA = "0xC77814", Offset = "0xC77814", VA = "0xC77814")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000C")]
		public class ReplacementList
		{
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0xC7781C", Offset = "0xC7781C", VA = "0xC7781C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xC76DF4", Offset = "0xC76DF4", VA = "0xC76DF4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xC7780C", Offset = "0xC7780C", VA = "0xC7780C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000026")]
			[Address(RVA = "0xC7795C", Offset = "0xC7795C", VA = "0xC7795C")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xC77874", Offset = "0xC77874", VA = "0xC77874")]
		private void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xC77890", Offset = "0xC77890", VA = "0xC77890")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xC77954", Offset = "0xC77954", VA = "0xC77954")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xC7796C", Offset = "0xC7796C", VA = "0xC7796C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xC779C0", Offset = "0xC779C0", VA = "0xC779C0")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xC779C8", Offset = "0xC779C8", VA = "0xC779C8")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xC779D0", Offset = "0xC779D0", VA = "0xC779D0")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xC77ABC", Offset = "0xC77ABC", VA = "0xC77ABC")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xC77B00", Offset = "0xC77B00", VA = "0xC77B00")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xC77BA0", Offset = "0xC77BA0", VA = "0xC77BA0")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xC77C90", Offset = "0xC77C90", VA = "0xC77C90")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000003")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000036")]
				[Address(RVA = "0xC785EC", Offset = "0xC785EC", VA = "0xC785EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000004")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000038")]
				[Address(RVA = "0xC78634", Offset = "0xC78634", VA = "0xC78634", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000033")]
			[Address(RVA = "0xC78390", Offset = "0xC78390", VA = "0xC78390")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0xC783C0", Offset = "0xC783C0", VA = "0xC783C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000035")]
			[Address(RVA = "0xC783C4", Offset = "0xC783C4", VA = "0xC783C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0xC785F4", Offset = "0xC785F4", VA = "0xC785F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000031")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000032")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000033")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000034")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000035")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000036")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xC77ED0", Offset = "0xC77ED0", VA = "0xC77ED0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xC78318", Offset = "0xC78318", VA = "0xC78318")]
		[IteratorStateMachine(typeof(<DragObject>d__8))]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xC7826C", Offset = "0xC7826C", VA = "0xC7826C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xC783B8", Offset = "0xC783B8", VA = "0xC783B8")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xC7863C", Offset = "0xC7863C", VA = "0xC7863C")]
		private void Start()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xC78664", Offset = "0xC78664", VA = "0xC78664")]
		private void Update()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xC78888", Offset = "0xC78888", VA = "0xC78888")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xC788BC", Offset = "0xC788BC", VA = "0xC788BC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xC78918", Offset = "0xC78918", VA = "0xC78918")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class FOVKick
	{
		[Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000047")]
				[Address(RVA = "0xC78CC4", Offset = "0xC78CC4", VA = "0xC78CC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0xC78D0C", Offset = "0xC78D0C", VA = "0xC78D0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xC78AC4", Offset = "0xC78AC4", VA = "0xC78AC4")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0xC78B98", Offset = "0xC78B98", VA = "0xC78B98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0xC78B9C", Offset = "0xC78B9C", VA = "0xC78B9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0xC78CCC", Offset = "0xC78CCC", VA = "0xC78CCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000059")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600004D")]
				[Address(RVA = "0xC78E54", Offset = "0xC78E54", VA = "0xC78E54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0xC78E9C", Offset = "0xC78E9C", VA = "0xC78E9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0xC78B54", Offset = "0xC78B54", VA = "0xC78B54")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0xC78D14", Offset = "0xC78D14", VA = "0xC78D14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004C")]
			[Address(RVA = "0xC78D18", Offset = "0xC78D18", VA = "0xC78D18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0xC78E5C", Offset = "0xC78E5C", VA = "0xC78E5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xC78930", Offset = "0xC78930", VA = "0xC78930")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xC7896C", Offset = "0xC7896C", VA = "0xC7896C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xC78A54", Offset = "0xC78A54", VA = "0xC78A54")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xC78A5C", Offset = "0xC78A5C", VA = "0xC78A5C")]
		[IteratorStateMachine(typeof(<FOVKickUp>d__9))]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xC78AEC", Offset = "0xC78AEC", VA = "0xC78AEC")]
		[IteratorStateMachine(typeof(<FOVKickDown>d__10))]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xC78B7C", Offset = "0xC78B7C", VA = "0xC78B7C")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400005A")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400005E")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xC78EA4", Offset = "0xC78EA4", VA = "0xC78EA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xC78F08", Offset = "0xC78F08", VA = "0xC78F08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xC78FFC", Offset = "0xC78FFC", VA = "0xC78FFC")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000059")]
				[Address(RVA = "0xC79244", Offset = "0xC79244", VA = "0xC79244", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005B")]
				[Address(RVA = "0xC7928C", Offset = "0xC7928C", VA = "0xC7928C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0xC79074", Offset = "0xC79074", VA = "0xC79074")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0xC790A4", Offset = "0xC790A4", VA = "0xC790A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0xC790A8", Offset = "0xC790A8", VA = "0xC790A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0xC7924C", Offset = "0xC7924C", VA = "0xC7924C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xC79004", Offset = "0xC79004", VA = "0xC79004")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xC7900C", Offset = "0xC7900C", VA = "0xC7900C")]
		[IteratorStateMachine(typeof(<DoBobCycle>d__4))]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xC7909C", Offset = "0xC7909C", VA = "0xC7909C")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000063")]
				[Address(RVA = "0xC796EC", Offset = "0xC796EC", VA = "0xC796EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000065")]
				[Address(RVA = "0xC79734", Offset = "0xC79734", VA = "0xC79734", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000060")]
			[Address(RVA = "0xC79438", Offset = "0xC79438", VA = "0xC79438")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0xC79468", Offset = "0xC79468", VA = "0xC79468", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0xC7946C", Offset = "0xC7946C", VA = "0xC7946C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0xC796F4", Offset = "0xC796F4", VA = "0xC796F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xC79294", Offset = "0xC79294", VA = "0xC79294")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xC793A0", Offset = "0xC793A0", VA = "0xC793A0")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xC793C0", Offset = "0xC793C0", VA = "0xC793C0")]
		[IteratorStateMachine(typeof(<ResetCoroutine>d__6))]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xC79460", Offset = "0xC79460", VA = "0xC79460")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600006C")]
				[Address(RVA = "0xC79B04", Offset = "0xC79B04", VA = "0xC79B04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600006E")]
				[Address(RVA = "0xC79B4C", Offset = "0xC79B4C", VA = "0xC79B4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000069")]
			[Address(RVA = "0xC797A4", Offset = "0xC797A4", VA = "0xC797A4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0xC797EC", Offset = "0xC797EC", VA = "0xC797EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0xC797F0", Offset = "0xC797F0", VA = "0xC797F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0xC79B0C", Offset = "0xC79B0C", VA = "0xC79B0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xC7973C", Offset = "0xC7973C", VA = "0xC7973C")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xC797CC", Offset = "0xC797CC", VA = "0xC797CC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xC797D8", Offset = "0xC797D8", VA = "0xC797D8")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400007D")]
			Standalone,
			[Token(Token = "0x400007E")]
			Mobile
		}

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xC79B54", Offset = "0xC79B54", VA = "0xC79B54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xC79B58", Offset = "0xC79B58", VA = "0xC79B58")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xC79B68", Offset = "0xC79B68", VA = "0xC79B68")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xC79F54", Offset = "0xC79F54", VA = "0xC79F54")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text camSwitchButton;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xC79FD8", Offset = "0xC79FD8", VA = "0xC79FD8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xC7A030", Offset = "0xC7A030", VA = "0xC7A030")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xC7A0F0", Offset = "0xC7A0F0", VA = "0xC7A0F0")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xC7A0F8", Offset = "0xC7A0F8", VA = "0xC7A0F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xC7A128", Offset = "0xC7A128", VA = "0xC7A128")]
		private void Update()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xC7A5A0", Offset = "0xC7A5A0", VA = "0xC7A5A0")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xC7A5C0", Offset = "0xC7A5C0", VA = "0xC7A5C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xC7A5C4", Offset = "0xC7A5C4", VA = "0xC7A5C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xC7A8F8", Offset = "0xC7A8F8", VA = "0xC7A8F8")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum Action
		{
			[Token(Token = "0x4000093")]
			Activate,
			[Token(Token = "0x4000094")]
			Deactivate,
			[Token(Token = "0x4000095")]
			Destroy,
			[Token(Token = "0x4000096")]
			ReloadLevel,
			[Token(Token = "0x4000097")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000026")]
		public class Entry
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000081")]
			[Address(RVA = "0xC7AC44", Offset = "0xC7AC44", VA = "0xC7AC44")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000027")]
		public class Entries
		{
			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000082")]
			[Address(RVA = "0xC7AC3C", Offset = "0xC7AC3C", VA = "0xC7AC3C")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700000F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000086")]
				[Address(RVA = "0xC7AD14", Offset = "0xC7AD14", VA = "0xC7AD14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000010")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000088")]
				[Address(RVA = "0xC7AD5C", Offset = "0xC7AD5C", VA = "0xC7AD5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0xC7AB5C", Offset = "0xC7AB5C", VA = "0xC7AB5C")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000084")]
			[Address(RVA = "0xC7AC4C", Offset = "0xC7AC4C", VA = "0xC7AC4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000085")]
			[Address(RVA = "0xC7AC50", Offset = "0xC7AC50", VA = "0xC7AC50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0xC7AD1C", Offset = "0xC7AD1C", VA = "0xC7AD1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000029")]
		[CompilerGenerated]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000011")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0xC7AE2C", Offset = "0xC7AE2C", VA = "0xC7AE2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000012")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600008E")]
				[Address(RVA = "0xC7AE74", Offset = "0xC7AE74", VA = "0xC7AE74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000089")]
			[Address(RVA = "0xC7AB84", Offset = "0xC7AB84", VA = "0xC7AB84")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600008A")]
			[Address(RVA = "0xC7AD64", Offset = "0xC7AD64", VA = "0xC7AD64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0xC7AD68", Offset = "0xC7AD68", VA = "0xC7AD68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0xC7AE34", Offset = "0xC7AE34", VA = "0xC7AE34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0xC7AF80", Offset = "0xC7AF80", VA = "0xC7AF80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000094")]
				[Address(RVA = "0xC7AFC8", Offset = "0xC7AFC8", VA = "0xC7AFC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0xC7ABAC", Offset = "0xC7ABAC", VA = "0xC7ABAC")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000090")]
			[Address(RVA = "0xC7AE7C", Offset = "0xC7AE7C", VA = "0xC7AE7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0xC7AE80", Offset = "0xC7AE80", VA = "0xC7AE80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0xC7AF88", Offset = "0xC7AF88", VA = "0xC7AF88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xC7A90C", Offset = "0xC7A90C", VA = "0xC7A90C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xC7AA24", Offset = "0xC7AA24", VA = "0xC7AA24")]
		[IteratorStateMachine(typeof(<Activate>d__5))]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xC7AA8C", Offset = "0xC7AA8C", VA = "0xC7AA8C")]
		[IteratorStateMachine(typeof(<Deactivate>d__6))]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xC7AAF4", Offset = "0xC7AAF4", VA = "0xC7AAF4")]
		[IteratorStateMachine(typeof(<ReloadLevel>d__7))]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xC7ABD4", Offset = "0xC7ABD4", VA = "0xC7ABD4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xC7AFD0", Offset = "0xC7AFD0", VA = "0xC7AFD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xC7B020", Offset = "0xC7B020", VA = "0xC7B020")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xC7B0B0", Offset = "0xC7B0B0", VA = "0xC7B0B0")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002D")]
		public class WaypointList
		{
			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xC7BB94", Offset = "0xC7BB94", VA = "0xC7BB94")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200002E")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xC7B78C", Offset = "0xC7B78C", VA = "0xC7B78C")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000015")]
		public float Length
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xC7B0C0", Offset = "0xC7B0C0", VA = "0xC7B0C0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xC7B0C8", Offset = "0xC7B0C8", VA = "0xC7B0C8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0xC7B0D0", Offset = "0xC7B0D0", VA = "0xC7B0D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xC7B0EC", Offset = "0xC7B0EC", VA = "0xC7B0EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xC7B3FC", Offset = "0xC7B3FC", VA = "0xC7B3FC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xC7B52C", Offset = "0xC7B52C", VA = "0xC7B52C")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xC7B79C", Offset = "0xC7B79C", VA = "0xC7B79C")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xC7B13C", Offset = "0xC7B13C", VA = "0xC7B13C")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xC7B8A8", Offset = "0xC7B8A8", VA = "0xC7B8A8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xC7BB18", Offset = "0xC7BB18", VA = "0xC7BB18")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xC7B8B0", Offset = "0xC7B8B0", VA = "0xC7B8B0")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xC7BB20", Offset = "0xC7BB20", VA = "0xC7BB20")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000CB")]
			SmoothAlongRoute,
			[Token(Token = "0x40000CC")]
			PointToPoint
		}

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000017")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xC7BBEC", Offset = "0xC7BBEC", VA = "0xC7BBEC")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xC7BC00", Offset = "0xC7BC00", VA = "0xC7BC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xC7BC14", Offset = "0xC7BC14", VA = "0xC7BC14")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xC7BC28", Offset = "0xC7BC28", VA = "0xC7BC28")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xC7BC3C", Offset = "0xC7BC3C", VA = "0xC7BC3C")]
			[CompilerGenerated]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xC7BC50", Offset = "0xC7BC50", VA = "0xC7BC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xC7BC64", Offset = "0xC7BC64", VA = "0xC7BC64")]
		private void Start()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xC7BD48", Offset = "0xC7BD48", VA = "0xC7BD48")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xC7BE14", Offset = "0xC7BE14", VA = "0xC7BE14")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xC7C2EC", Offset = "0xC7C2EC", VA = "0xC7C2EC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xC7C448", Offset = "0xC7C448", VA = "0xC7C448")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000031")]
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xC7C464", Offset = "0xC7C464", VA = "0xC7C464")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xC7C508", Offset = "0xC7C508", VA = "0xC7C508")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xC7CA60", Offset = "0xC7CA60", VA = "0xC7CA60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xC7CF78", Offset = "0xC7CF78", VA = "0xC7CF78")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000BB")]
				[Address(RVA = "0xC7D694", Offset = "0xC7D694", VA = "0xC7D694", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000BD")]
				[Address(RVA = "0xC7D6DC", Offset = "0xC7D6DC", VA = "0xC7D6DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xC7CFF4", Offset = "0xC7CFF4", VA = "0xC7CFF4")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xC7D170", Offset = "0xC7D170", VA = "0xC7D170", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xC7D174", Offset = "0xC7D174", VA = "0xC7D174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xC7D69C", Offset = "0xC7D69C", VA = "0xC7D69C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xC7CF8C", Offset = "0xC7CF8C", VA = "0xC7CF8C")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xC7D01C", Offset = "0xC7D01C", VA = "0xC7D01C")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xC7D168", Offset = "0xC7D168", VA = "0xC7D168")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C3")]
				[Address(RVA = "0xC7DB54", Offset = "0xC7DB54", VA = "0xC7DB54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C5")]
				[Address(RVA = "0xC7DB9C", Offset = "0xC7DB9C", VA = "0xC7DB9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xC7D74C", Offset = "0xC7D74C", VA = "0xC7D74C")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xC7D784", Offset = "0xC7D784", VA = "0xC7D784", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xC7D788", Offset = "0xC7D788", VA = "0xC7D788", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xC7DB5C", Offset = "0xC7DB5C", VA = "0xC7DB5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xC7D6E4", Offset = "0xC7D6E4", VA = "0xC7D6E4")]
		[IteratorStateMachine(typeof(<Start>d__1))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xC7D774", Offset = "0xC7D774", VA = "0xC7D774")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x1700001E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CD")]
				[Address(RVA = "0xC7E028", Offset = "0xC7E028", VA = "0xC7E028", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CF")]
				[Address(RVA = "0xC7E070", Offset = "0xC7E070", VA = "0xC7E070", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xC7DC68", Offset = "0xC7DC68", VA = "0xC7DC68")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xC7DCBC", Offset = "0xC7DCBC", VA = "0xC7DCBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xC7DCC0", Offset = "0xC7DCC0", VA = "0xC7DCC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xC7E030", Offset = "0xC7E030", VA = "0xC7E030", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xC7DBA4", Offset = "0xC7DBA4", VA = "0xC7DBA4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xC7DBF4", Offset = "0xC7DBF4", VA = "0xC7DBF4")]
		[IteratorStateMachine(typeof(<OnCollisionEnter>d__8))]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xC7DC90", Offset = "0xC7DC90", VA = "0xC7DC90")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xC7DC98", Offset = "0xC7DC98", VA = "0xC7DC98")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xC7E078", Offset = "0xC7E078", VA = "0xC7E078")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xC7E0C8", Offset = "0xC7E0C8", VA = "0xC7E0C8")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xC7E140", Offset = "0xC7E140", VA = "0xC7E140")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xC7E150", Offset = "0xC7E150", VA = "0xC7E150")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xC7E1B8", Offset = "0xC7E1B8", VA = "0xC7E1B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xC7E3A0", Offset = "0xC7E3A0", VA = "0xC7E3A0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xC7E3C8", Offset = "0xC7E3C8", VA = "0xC7E3C8")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xC7E3D8", Offset = "0xC7E3D8", VA = "0xC7E3D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xC7E558", Offset = "0xC7E558", VA = "0xC7E558")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xC7E574", Offset = "0xC7E574", VA = "0xC7E574")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xC7E6B4", Offset = "0xC7E6B4", VA = "0xC7E6B4")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xC7E6C4", Offset = "0xC7E6C4", VA = "0xC7E6C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xC7E774", Offset = "0xC7E774", VA = "0xC7E774")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xC7E77C", Offset = "0xC7E77C", VA = "0xC7E77C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xC7E7CC", Offset = "0xC7E7CC", VA = "0xC7E7CC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xC7E9EC", Offset = "0xC7E9EC", VA = "0xC7E9EC")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x200003E")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xC7EA70", Offset = "0xC7EA70", VA = "0xC7EA70")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xC7ECC0", Offset = "0xC7ECC0", VA = "0xC7ECC0")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xC7EE3C", Offset = "0xC7EE3C", VA = "0xC7EE3C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xC7EEAC", Offset = "0xC7EEAC", VA = "0xC7EEAC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xC7EF78", Offset = "0xC7EF78", VA = "0xC7EF78", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xC7EFDC", Offset = "0xC7EFDC", VA = "0xC7EFDC")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xC7F040", Offset = "0xC7F040", VA = "0xC7F040")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xC7F044", Offset = "0xC7F044", VA = "0xC7F044")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xC7F10C", Offset = "0xC7F10C", VA = "0xC7F10C")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xC7F1D4", Offset = "0xC7F1D4", VA = "0xC7F1D4")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xC7F29C", Offset = "0xC7F29C", VA = "0xC7F29C")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xC7F364", Offset = "0xC7F364", VA = "0xC7F364")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xC7F42C", Offset = "0xC7F42C", VA = "0xC7F42C")]
		public void Update()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xC7F430", Offset = "0xC7F430", VA = "0xC7F430")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000041")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000106")]
			Hardware,
			[Token(Token = "0x4000107")]
			Touch
		}

		[Token(Token = "0x2000042")]
		public class VirtualAxis
		{
			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x17000021")]
			public string name
			{
				[Token(Token = "0x6000107")]
				[Address(RVA = "0xC800F4", Offset = "0xC800F4", VA = "0xC800F4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000108")]
				[Address(RVA = "0xC800FC", Offset = "0xC800FC", VA = "0xC800FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000022")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000109")]
				[Address(RVA = "0xC80104", Offset = "0xC80104", VA = "0xC80104")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600010A")]
				[Address(RVA = "0xC8010C", Offset = "0xC8010C", VA = "0xC8010C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000023")]
			public float GetValue
			{
				[Token(Token = "0x600010F")]
				[Address(RVA = "0xC80154", Offset = "0xC80154", VA = "0xC80154")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000024")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000110")]
				[Address(RVA = "0xC8015C", Offset = "0xC8015C", VA = "0xC8015C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0xC7EBC0", Offset = "0xC7EBC0", VA = "0xC7EBC0")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0xC80118", Offset = "0xC80118", VA = "0xC80118")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0xC7EE54", Offset = "0xC7EE54", VA = "0xC7EE54")]
			public void Remove()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0xC8014C", Offset = "0xC8014C", VA = "0xC8014C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000043")]
		public class VirtualButton
		{
			[Token(Token = "0x400010D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x400010E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x400010F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000025")]
			public string name
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0xC80164", Offset = "0xC80164", VA = "0xC80164")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000112")]
				[Address(RVA = "0xC8016C", Offset = "0xC8016C", VA = "0xC8016C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0xC80174", Offset = "0xC80174", VA = "0xC80174")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000114")]
				[Address(RVA = "0xC8017C", Offset = "0xC8017C", VA = "0xC8017C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public bool GetButton
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0xC802A0", Offset = "0xC802A0", VA = "0xC802A0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000028")]
			public bool GetButtonDown
			{
				[Token(Token = "0x600011B")]
				[Address(RVA = "0xC802A8", Offset = "0xC802A8", VA = "0xC802A8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000029")]
			public bool GetButtonUp
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0xC802CC", Offset = "0xC802CC", VA = "0xC802CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000115")]
			[Address(RVA = "0xC80188", Offset = "0xC80188", VA = "0xC80188")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000116")]
			[Address(RVA = "0xC801C0", Offset = "0xC801C0", VA = "0xC801C0")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0xC801FC", Offset = "0xC801FC", VA = "0xC801FC")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0xC80228", Offset = "0xC80228", VA = "0xC80228")]
			public void Released()
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0xC80248", Offset = "0xC80248", VA = "0xC80248")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000020")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0xC7FF20", Offset = "0xC7FF20", VA = "0xC7FF20")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xC7F438", Offset = "0xC7F438", VA = "0xC7F438")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xC7F4F0", Offset = "0xC7F4F0", VA = "0xC7F4F0")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xC7EB58", Offset = "0xC7EB58", VA = "0xC7EB58")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xC7F5D8", Offset = "0xC7F5D8", VA = "0xC7F5D8")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xC7EBF0", Offset = "0xC7EBF0", VA = "0xC7EBF0")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xC7F820", Offset = "0xC7F820", VA = "0xC7F820")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xC7FA10", Offset = "0xC7FA10", VA = "0xC7FA10")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xC7FB58", Offset = "0xC7FB58", VA = "0xC7FB58")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xC7EC58", Offset = "0xC7EC58", VA = "0xC7EC58")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xC7A548", Offset = "0xC7A548", VA = "0xC7A548")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xC7FD64", Offset = "0xC7FD64", VA = "0xC7FD64")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xC7FCE4", Offset = "0xC7FCE4", VA = "0xC7FCE4")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xC7FDBC", Offset = "0xC7FDBC", VA = "0xC7FDBC")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xC76924", Offset = "0xC76924", VA = "0xC76924")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xC7FE2C", Offset = "0xC7FE2C", VA = "0xC7FE2C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xC7F09C", Offset = "0xC7F09C", VA = "0xC7F09C")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xC7F164", Offset = "0xC7F164", VA = "0xC7F164")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xC7F22C", Offset = "0xC7F22C", VA = "0xC7F22C")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xC7F3BC", Offset = "0xC7F3BC", VA = "0xC7F3BC")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xC7F2F4", Offset = "0xC7F2F4", VA = "0xC7F2F4")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xC7FE9C", Offset = "0xC7FE9C", VA = "0xC7FE9C")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xC7FF8C", Offset = "0xC7FF8C", VA = "0xC7FF8C")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xC80004", Offset = "0xC80004", VA = "0xC80004")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xC8007C", Offset = "0xC8007C", VA = "0xC8007C")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xC802F0", Offset = "0xC802F0", VA = "0xC802F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xC802F4", Offset = "0xC802F4", VA = "0xC802F4")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xC80364", Offset = "0xC80364", VA = "0xC80364")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000046")]
		public enum AxisOption
		{
			[Token(Token = "0x400011B")]
			Both,
			[Token(Token = "0x400011C")]
			OnlyHorizontal,
			[Token(Token = "0x400011D")]
			OnlyVertical
		}

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xC8036C", Offset = "0xC8036C", VA = "0xC8036C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xC80494", Offset = "0xC80494", VA = "0xC80494")]
		private void Start()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xC804C4", Offset = "0xC804C4", VA = "0xC804C4")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xC80370", Offset = "0xC80370", VA = "0xC80370")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xC80524", Offset = "0xC80524", VA = "0xC80524", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xC80670", Offset = "0xC80670", VA = "0xC80670", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xC806AC", Offset = "0xC806AC", VA = "0xC806AC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xC806B0", Offset = "0xC806B0", VA = "0xC806B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xC806F0", Offset = "0xC806F0", VA = "0xC806F0")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0xC8076C", Offset = "0xC8076C", VA = "0xC8076C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xC8077C", Offset = "0xC8077C", VA = "0xC8077C")]
		private void Start()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xC80774", Offset = "0xC80774", VA = "0xC80774")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xC80884", Offset = "0xC80884", VA = "0xC80884")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xC80B7C", Offset = "0xC80B7C", VA = "0xC80B7C")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000124")]
			ForwardAxis,
			[Token(Token = "0x4000125")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200004A")]
		public class AxisMapping
		{
			[Token(Token = "0x200004B")]
			public enum MappingType
			{
				[Token(Token = "0x4000129")]
				NamedAxis,
				[Token(Token = "0x400012A")]
				MousePositionX,
				[Token(Token = "0x400012B")]
				MousePositionY,
				[Token(Token = "0x400012C")]
				MousePositionZ
			}

			[Token(Token = "0x4000126")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000127")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000132")]
			[Address(RVA = "0xC80EBC", Offset = "0xC80EBC", VA = "0xC80EBC")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xC80B84", Offset = "0xC80B84", VA = "0xC80B84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xC80C44", Offset = "0xC80C44", VA = "0xC80C44")]
		private void Update()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xC80E94", Offset = "0xC80E94", VA = "0xC80E94")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xC80EAC", Offset = "0xC80EAC", VA = "0xC80EAC")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200004D")]
		public enum AxisOption
		{
			[Token(Token = "0x4000140")]
			Both,
			[Token(Token = "0x4000141")]
			OnlyHorizontal,
			[Token(Token = "0x4000142")]
			OnlyVertical
		}

		[Token(Token = "0x200004E")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000144")]
			Absolute,
			[Token(Token = "0x4000145")]
			Relative,
			[Token(Token = "0x4000146")]
			Swipe
		}

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xC80EC4", Offset = "0xC80EC4", VA = "0xC80EC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xC80FEC", Offset = "0xC80FEC", VA = "0xC80FEC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xC80EC8", Offset = "0xC80EC8", VA = "0xC80EC8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xC81060", Offset = "0xC81060", VA = "0xC81060")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xC81160", Offset = "0xC81160", VA = "0xC81160", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xC81198", Offset = "0xC81198", VA = "0xC81198")]
		private void Update()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xC81370", Offset = "0xC81370", VA = "0xC81370", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xC813D0", Offset = "0xC813D0", VA = "0xC813D0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xC81490", Offset = "0xC81490", VA = "0xC81490")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700002A")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xC81514", Offset = "0xC81514", VA = "0xC81514")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0xC81520", Offset = "0xC81520", VA = "0xC81520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xC7F580", Offset = "0xC7F580", VA = "0xC7F580")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xC7F640", Offset = "0xC7F640", VA = "0xC7F640")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xC7F698", Offset = "0xC7F698", VA = "0xC7F698")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xC7F888", Offset = "0xC7F888", VA = "0xC7F888")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xC7FAC8", Offset = "0xC7FAC8", VA = "0xC7FAC8")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xC7FBC0", Offset = "0xC7FBC0", VA = "0xC7FBC0")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xC7FC50", Offset = "0xC7FC50", VA = "0xC7FC50")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xC7FFFC", Offset = "0xC7FFFC", VA = "0xC7FFFC")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xC80074", Offset = "0xC80074", VA = "0xC80074")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xC800EC", Offset = "0xC800EC", VA = "0xC800EC")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000148")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000149")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x600014A")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x600014B")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x600014C")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600014D")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600014E")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600014F")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000150")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000151")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000152")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xC8152C", Offset = "0xC8152C", VA = "0xC8152C")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000050")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xC81630", Offset = "0xC81630", VA = "0xC81630")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xC816C8", Offset = "0xC816C8", VA = "0xC816C8")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xC81758", Offset = "0xC81758", VA = "0xC81758", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xC817F0", Offset = "0xC817F0", VA = "0xC817F0", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xC818A4", Offset = "0xC818A4", VA = "0xC818A4", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xC8194C", Offset = "0xC8194C", VA = "0xC8194C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xC819E8", Offset = "0xC819E8", VA = "0xC819E8", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xC81A84", Offset = "0xC81A84", VA = "0xC81A84", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xC81B1C", Offset = "0xC81B1C", VA = "0xC81B1C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xC81BC0", Offset = "0xC81BC0", VA = "0xC81BC0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0xC81C6C", Offset = "0xC81C6C", VA = "0xC81C6C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xC81D18", Offset = "0xC81D18", VA = "0xC81D18", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xC81DB0", Offset = "0xC81DB0", VA = "0xC81DB0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xC7F4E8", Offset = "0xC7F4E8", VA = "0xC7F4E8")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xC81DBC", Offset = "0xC81DBC", VA = "0xC81DBC", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xC81DD0", Offset = "0xC81DD0", VA = "0xC81DD0", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xC81DDC", Offset = "0xC81DDC", VA = "0xC81DDC", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xC81DE8", Offset = "0xC81DE8", VA = "0xC81DE8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xC81DF4", Offset = "0xC81DF4", VA = "0xC81DF4", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xC81E44", Offset = "0xC81E44", VA = "0xC81E44", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xC81E94", Offset = "0xC81E94", VA = "0xC81E94", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xC81EE4", Offset = "0xC81EE4", VA = "0xC81EE4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xC81F34", Offset = "0xC81F34", VA = "0xC81F34", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xC81F84", Offset = "0xC81F84", VA = "0xC81F84", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xC81FD4", Offset = "0xC81FD4", VA = "0xC81FD4", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xC7F4EC", Offset = "0xC7F4EC", VA = "0xC7F4EC")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000052")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400014F")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xC81FDC", Offset = "0xC81FDC", VA = "0xC81FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xC82048", Offset = "0xC82048", VA = "0xC82048")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xC821BC", Offset = "0xC821BC", VA = "0xC821BC")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xC821E0", Offset = "0xC821E0", VA = "0xC821E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xC822EC", Offset = "0xC822EC", VA = "0xC822EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xC826CC", Offset = "0xC826CC", VA = "0xC826CC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xC826FC", Offset = "0xC826FC", VA = "0xC826FC")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000054")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	[RequireComponent(typeof(NavMeshAgent))]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x1700002B")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xC82704", Offset = "0xC82704", VA = "0xC82704")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xC8270C", Offset = "0xC8270C", VA = "0xC8270C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xC82714", Offset = "0xC82714", VA = "0xC82714")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xC8271C", Offset = "0xC8271C", VA = "0xC8271C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xC82724", Offset = "0xC82724", VA = "0xC82724")]
		private void Start()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xC827CC", Offset = "0xC827CC", VA = "0xC827CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xC82B50", Offset = "0xC82B50", VA = "0xC82B50")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xC82B58", Offset = "0xC82B58", VA = "0xC82B58")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(1f, 4f)]
		private float m_GravityMultiplier;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x4000165")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xC82B60", Offset = "0xC82B60", VA = "0xC82B60")]
		private void Start()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xC828F4", Offset = "0xC828F4", VA = "0xC828F4")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xC83004", Offset = "0xC83004", VA = "0xC83004")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xC83224", Offset = "0xC83224", VA = "0xC83224")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xC833A4", Offset = "0xC833A4", VA = "0xC833A4")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xC82F6C", Offset = "0xC82F6C", VA = "0xC82F6C")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xC82E50", Offset = "0xC82E50", VA = "0xC82E50")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xC82DCC", Offset = "0xC82DCC", VA = "0xC82DCC")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xC83664", Offset = "0xC83664", VA = "0xC83664")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xC82C48", Offset = "0xC82C48", VA = "0xC82C48")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xC83704", Offset = "0xC83704", VA = "0xC83704")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xC83724", Offset = "0xC83724", VA = "0xC83724")]
		private void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xC83838", Offset = "0xC83838", VA = "0xC83838")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xC838B4", Offset = "0xC838B4", VA = "0xC838B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xC83B48", Offset = "0xC83B48", VA = "0xC83B48")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_WalkSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xC83B50", Offset = "0xC83B50", VA = "0xC83B50")]
		private void Start()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xC83CA8", Offset = "0xC83CA8", VA = "0xC83CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xC83E08", Offset = "0xC83E08", VA = "0xC83E08")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xC83E50", Offset = "0xC83E50", VA = "0xC83E50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xC84460", Offset = "0xC84460", VA = "0xC84460")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xC84494", Offset = "0xC84494", VA = "0xC84494")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xC84834", Offset = "0xC84834", VA = "0xC84834")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xC845E4", Offset = "0xC845E4", VA = "0xC845E4")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xC84250", Offset = "0xC84250", VA = "0xC84250")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xC83DB8", Offset = "0xC83DB8", VA = "0xC83DB8")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xC84CD8", Offset = "0xC84CD8", VA = "0xC84CD8")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xC84DFC", Offset = "0xC84DFC", VA = "0xC84DFC")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xC84F14", Offset = "0xC84F14", VA = "0xC84F14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xC84F60", Offset = "0xC84F60", VA = "0xC84F60")]
		private void Update()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xC851D8", Offset = "0xC851D8", VA = "0xC851D8")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class MouseLook
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xC83C58", Offset = "0xC83C58", VA = "0xC83C58")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xC8496C", Offset = "0xC8496C", VA = "0xC8496C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xC852D0", Offset = "0xC852D0", VA = "0xC852D0")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xC84824", Offset = "0xC84824", VA = "0xC84824")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xC85304", Offset = "0xC85304", VA = "0xC85304")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xC8526C", Offset = "0xC8526C", VA = "0xC8526C")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xC8537C", Offset = "0xC8537C", VA = "0xC8537C")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005B")]
		public class MovementSettings
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xC861FC", Offset = "0xC861FC", VA = "0xC861FC")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xC863B8", Offset = "0xC863B8", VA = "0xC863B8")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005C")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;

			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xC86568", Offset = "0xC86568", VA = "0xC86568")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700002D")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0xC851B4", Offset = "0xC851B4", VA = "0xC851B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool Grounded
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xC853B0", Offset = "0xC853B0", VA = "0xC853B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool Jumping
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0xC853B8", Offset = "0xC853B8", VA = "0xC853B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public bool Running
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xC851D0", Offset = "0xC851D0", VA = "0xC851D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xC853C0", Offset = "0xC853C0", VA = "0xC853C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xC85478", Offset = "0xC85478", VA = "0xC85478")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xC8567C", Offset = "0xC8567C", VA = "0xC8567C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xC85D50", Offset = "0xC85D50", VA = "0xC85D50")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xC85EB0", Offset = "0xC85EB0", VA = "0xC85EB0")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xC85C98", Offset = "0xC85C98", VA = "0xC85C98")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xC85500", Offset = "0xC85500", VA = "0xC85500")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xC85ACC", Offset = "0xC85ACC", VA = "0xC85ACC")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xC862B4", Offset = "0xC862B4", VA = "0xC862B4")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200005D")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public enum UpdateType
		{
			[Token(Token = "0x40001C1")]
			FixedUpdate,
			[Token(Token = "0x40001C2")]
			LateUpdate,
			[Token(Token = "0x40001C3")]
			ManualUpdate
		}

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000031")]
		public Transform Target
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xC86948", Offset = "0xC86948", VA = "0xC86948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xC86584", Offset = "0xC86584", VA = "0xC86584", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xC866EC", Offset = "0xC866EC", VA = "0xC866EC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xC867B0", Offset = "0xC867B0", VA = "0xC867B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xC86878", Offset = "0xC86878", VA = "0xC86878")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001B6")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xC86628", Offset = "0xC86628", VA = "0xC86628")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xC86940", Offset = "0xC86940", VA = "0xC86940", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xC86950", Offset = "0xC86950", VA = "0xC86950")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xC86960", Offset = "0xC86960", VA = "0xC86960", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xC86F2C", Offset = "0xC86F2C", VA = "0xC86F2C")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 10f)]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40001D9")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xC86FB8", Offset = "0xC86FB8", VA = "0xC86FB8", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xC87074", Offset = "0xC87074", VA = "0xC87074")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xC873C4", Offset = "0xC873C4", VA = "0xC873C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xC873E4", Offset = "0xC873E4", VA = "0xC873E4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xC870C4", Offset = "0xC870C4", VA = "0xC870C4")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xC87508", Offset = "0xC87508", VA = "0xC87508")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xC88528", Offset = "0xC88528", VA = "0xC88528", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xC889C4", Offset = "0xC889C4", VA = "0xC889C4")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xC889F4", Offset = "0xC889F4", VA = "0xC889F4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xC88660", Offset = "0xC88660", VA = "0xC88660", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xC889E4", Offset = "0xC889E4", VA = "0xC889E4")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xC88A30", Offset = "0xC88A30", VA = "0xC88A30", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xC88AA0", Offset = "0xC88AA0", VA = "0xC88AA0")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0xC891D0", Offset = "0xC891D0", VA = "0xC891D0", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xC88BE4", Offset = "0xC88BE4", VA = "0xC88BE4")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000032")]
		public bool protecting
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xC88AA8", Offset = "0xC88AA8", VA = "0xC88AA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xC88AB0", Offset = "0xC88AB0", VA = "0xC88AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xC88ABC", Offset = "0xC88ABC", VA = "0xC88ABC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xC88BEC", Offset = "0xC88BEC", VA = "0xC88BEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xC89160", Offset = "0xC89160", VA = "0xC89160")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xC892C4", Offset = "0xC892C4", VA = "0xC892C4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xC89520", Offset = "0xC89520", VA = "0xC89520", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xC89660", Offset = "0xC89660", VA = "0xC89660", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xC89330", Offset = "0xC89330", VA = "0xC89330")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xC89684", Offset = "0xC89684", VA = "0xC89684")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets._2D
{
	[Token(Token = "0x2000067")]
	public class Camera2DFollow : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float damping;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float lookAheadFactor;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float lookAheadReturnSpeed;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float lookAheadMoveThreshold;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_OffsetZ;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_LastTargetPosition;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 m_CurrentVelocity;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_LookAheadPos;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xC89698", Offset = "0xC89698", VA = "0xC89698")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xC89718", Offset = "0xC89718", VA = "0xC89718")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xC89A24", Offset = "0xC89A24", VA = "0xC89A24")]
		public Camera2DFollow()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class CameraFollow : MonoBehaviour
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float xMargin;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMargin;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float xSmooth;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float ySmooth;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 maxXAndY;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 minXAndY;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Player;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xC89A38", Offset = "0xC89A38", VA = "0xC89A38")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xC89A98", Offset = "0xC89A98", VA = "0xC89A98")]
		private bool CheckXMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xC89AEC", Offset = "0xC89AEC", VA = "0xC89AEC")]
		private bool CheckYMargin()
		{
			return default(bool);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xC89B40", Offset = "0xC89B40", VA = "0xC89B40")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xC89B44", Offset = "0xC89B44", VA = "0xC89B44")]
		private void TrackPlayer()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xC89CE4", Offset = "0xC89CE4", VA = "0xC89CE4")]
		public CameraFollow()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[RequireComponent(typeof(PlatformerCharacter2D))]
	public class Platformer2DUserControl : MonoBehaviour
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private PlatformerCharacter2D m_Character;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_Jump;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xC89CF8", Offset = "0xC89CF8", VA = "0xC89CF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xC89D48", Offset = "0xC89D48", VA = "0xC89D48")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xC89DC8", Offset = "0xC89DC8", VA = "0xC89DC8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xC8A0D4", Offset = "0xC8A0D4", VA = "0xC8A0D4")]
		public Platformer2DUserControl()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class PlatformerCharacter2D : MonoBehaviour
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MaxSpeed;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_JumpForce;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CrouchSpeed;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_AirControl;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_WhatIsGround;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_GroundCheck;

		[Token(Token = "0x4000217")]
		private const float k_GroundedRadius = 0.2f;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_Grounded;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_CeilingCheck;

		[Token(Token = "0x400021A")]
		private const float k_CeilingRadius = 0.01f;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator m_Anim;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Rigidbody2D m_Rigidbody2D;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_FacingRight;

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xC8A0DC", Offset = "0xC8A0DC", VA = "0xC8A0DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xC8A1BC", Offset = "0xC8A1BC", VA = "0xC8A1BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xC89E68", Offset = "0xC89E68", VA = "0xC89E68")]
		public void Move(float move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xC8A37C", Offset = "0xC8A37C", VA = "0xC8A37C")]
		private void Flip()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xC8A3EC", Offset = "0xC8A3EC", VA = "0xC8A3EC")]
		public PlatformerCharacter2D()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Restarter : MonoBehaviour
	{
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xC8A414", Offset = "0xC8A414", VA = "0xC8A414")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xC8A4C4", Offset = "0xC8A4C4", VA = "0xC8A4C4")]
		public Restarter()
		{
		}
	}
}
