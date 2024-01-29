using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using ScreenshotCompanionFramework;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class ScreenshotCompanion : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum FileType
	{
		[Token(Token = "0x400000B")]
		PNG,
		[Token(Token = "0x400000C")]
		JPG
	}

	[Token(Token = "0x2000004")]
	public enum CaptureMethod
	{
		[Token(Token = "0x400000E")]
		CaptureScreenshot,
		[Token(Token = "0x400000F")]
		RenderTexture,
		[Token(Token = "0x4000010")]
		Cutout
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14AF8", Offset = "0xB14AF8")]
	private sealed class <CaptureCutout>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScreenshotCompanion <>4__this;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int id;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1AA5ACC", Offset = "0x1AA5ACC", VA = "0x1AA5ACC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1AA5B34", Offset = "0x1AA5B34", VA = "0x1AA5B34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1AA4A38", Offset = "0x1AA4A38", VA = "0x1AA4A38")]
		[DebuggerHidden]
		public <CaptureCutout>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1AA5620", Offset = "0x1AA5620", VA = "0x1AA5620", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1AA5624", Offset = "0x1AA5624", VA = "0x1AA5624", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1AA5AD4", Offset = "0x1AA5AD4", VA = "0x1AA5AD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<CameraObject> list;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public SettingsaObject settings;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool foldoutSettings;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int lastCamID;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Camera lastCam;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GUIStyle cutoutBoxStyle;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector2 lastP;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector2 lastS;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float timer;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1AA36C8", Offset = "0x1AA36C8", VA = "0x1AA36C8")]
	public void Create()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1AA374C", Offset = "0x1AA374C", VA = "0x1AA374C")]
	public void RequestDelete(int id)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1AA37D0", Offset = "0x1AA37D0", VA = "0x1AA37D0")]
	public void Delete(int id)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1AA3880", Offset = "0x1AA3880", VA = "0x1AA3880")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1AA3918", Offset = "0x1AA3918", VA = "0x1AA3918")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1AA42B8", Offset = "0x1AA42B8", VA = "0x1AA42B8")]
	private void activateCameraID(int id)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1AA43FC", Offset = "0x1AA43FC", VA = "0x1AA43FC")]
	public string getSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1AA44B4", Offset = "0x1AA44B4", VA = "0x1AA44B4")]
	private string checkSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1AA44F0", Offset = "0x1AA44F0", VA = "0x1AA44F0")]
	private void initCutoutBoxStyle()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1AA4708", Offset = "0x1AA4708", VA = "0x1AA4708")]
	private void clampCutoutBox()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1AA486C", Offset = "0x1AA486C", VA = "0x1AA486C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1AA49E0", Offset = "0x1AA49E0", VA = "0x1AA49E0")]
	public void CaptureCutoutVoid(int id)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1AA40B4", Offset = "0x1AA40B4", VA = "0x1AA40B4")]
	public IEnumerator CaptureCutout(int id)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1AA4A64", Offset = "0x1AA4A64", VA = "0x1AA4A64")]
	private void cutoutEmptyCheck()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1AA3C28", Offset = "0x1AA3C28", VA = "0x1AA3C28")]
	public void CaptureScreenshots(int id, bool fallback)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1AA3D50", Offset = "0x1AA3D50", VA = "0x1AA3D50")]
	public void CaptureRenderTexture(Camera attachedCam, int id)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1AA4D6C", Offset = "0x1AA4D6C", VA = "0x1AA4D6C")]
	public string getFileName(int camID)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1AA5184", Offset = "0x1AA5184", VA = "0x1AA5184")]
	public string getResolution()
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1AA4134", Offset = "0x1AA4134", VA = "0x1AA4134")]
	private void DebugLogExtended(string log)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1AA5158", Offset = "0x1AA5158", VA = "0x1AA5158")]
	private void postCapture()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1AA55B0", Offset = "0x1AA55B0", VA = "0x1AA55B0")]
	public ScreenshotCompanion()
	{
	}
}
namespace ScreenshotCompanionFramework
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public class CameraObject
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject cam;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool deleteQuestion;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public KeyCode hotkey;

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1AA3744", Offset = "0x1AA3744", VA = "0x1AA3744")]
		public CameraObject()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class SettingsaObject
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color signatureColor;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string customFileName;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool includeProject;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool includeCamera;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool includeDate;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool includeResolution;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool includeCounter;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int counter;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public ScreenshotCompanion.FileType fileType;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool applicationPath;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string customDirectoryName;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ScreenshotCompanion.CaptureMethod captureMethod;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool singleCamera;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float renderSizeMultiplier;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int captureSizeMultiplier;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2 cutoutPosition;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector2 cutoutSize;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1AA5B3C", Offset = "0x1AA5B3C", VA = "0x1AA5B3C")]
		public SettingsaObject()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000008")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B18", Offset = "0xB14B18")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1AA2088", Offset = "0x1AA2088", VA = "0x1AA2088")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1AA2090", Offset = "0x1AA2090", VA = "0x1AA2090")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000021")]
			[Address(RVA = "0x1AA20AC", Offset = "0x1AA20AC", VA = "0x1AA20AC")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1AA1F24", Offset = "0x1AA1F24", VA = "0x1AA1F24")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200000A")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B38", Offset = "0xB14B38")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1AA20C8", Offset = "0x1AA20C8", VA = "0x1AA20C8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1AA23E4", Offset = "0x1AA23E4", VA = "0x1AA23E4")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B48", Offset = "0xB14B48")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1AA20D0", Offset = "0x1AA20D0", VA = "0x1AA20D0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1AA2520", Offset = "0x1AA2520", VA = "0x1AA2520")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B58", Offset = "0xB14B58")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1AA2250", Offset = "0x1AA2250", VA = "0x1AA2250")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1AA253C", Offset = "0x1AA253C", VA = "0x1AA253C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B68", Offset = "0xB14B68")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1AA23DC", Offset = "0x1AA23DC", VA = "0x1AA23DC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1AA2400", Offset = "0x1AA2400", VA = "0x1AA2400")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1AA241C", Offset = "0x1AA241C", VA = "0x1AA241C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1A9F4C8", Offset = "0x1A9F4C8", VA = "0x1A9F4C8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1A9F7A0", Offset = "0x1A9F7A0", VA = "0x1A9F7A0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1AA20D8", Offset = "0x1AA20D8", VA = "0x1AA20D8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1AA2258", Offset = "0x1AA2258", VA = "0x1AA2258")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000010")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B88", Offset = "0xB14B88")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1AA2558", Offset = "0x1AA2558", VA = "0x1AA2558")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1AA2868", Offset = "0x1AA2868", VA = "0x1AA2868")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000011")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14B98", Offset = "0xB14B98")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1AA2560", Offset = "0x1AA2560", VA = "0x1AA2560")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1AA2884", Offset = "0x1AA2884", VA = "0x1AA2884")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14BA8", Offset = "0xB14BA8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1AA26D4", Offset = "0x1AA26D4", VA = "0x1AA26D4")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1AA28A0", Offset = "0x1AA28A0", VA = "0x1AA28A0")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x1AA2930", Offset = "0x1AA2930", VA = "0x1AA2930")]
			internal void <DOPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14BB8", Offset = "0xB14BB8")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody2D target;

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1AA2860", Offset = "0x1AA2860", VA = "0x1AA2860")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1AA29D4", Offset = "0x1AA29D4", VA = "0x1AA29D4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1AA29F0", Offset = "0x1AA29F0", VA = "0x1AA29F0")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1A9F638", Offset = "0x1A9F638", VA = "0x1A9F638")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1A9F90C", Offset = "0x1A9F90C", VA = "0x1A9F90C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1AA2568", Offset = "0x1AA2568", VA = "0x1AA2568")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1AA26DC", Offset = "0x1AA26DC", VA = "0x1AA26DC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000014")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14BD8", Offset = "0xB14BD8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1AA2B1C", Offset = "0x1AA2B1C", VA = "0x1AA2B1C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x1AA2B2C", Offset = "0x1AA2B2C", VA = "0x1AA2B2C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1AA2B48", Offset = "0x1AA2B48", VA = "0x1AA2B48")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14BE8", Offset = "0xB14BE8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x1AA2B24", Offset = "0x1AA2B24", VA = "0x1AA2B24")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x1AA2B64", Offset = "0x1AA2B64", VA = "0x1AA2B64")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x1AA2B80", Offset = "0x1AA2B80", VA = "0x1AA2B80")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1A9FBA8", Offset = "0x1A9FBA8", VA = "0x1A9FBA8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1A9FFD4", Offset = "0x1A9FFD4", VA = "0x1A9FFD4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000018")]
		public static class Utils
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1A9F0B8", Offset = "0x1A9F0B8", VA = "0x1A9F0B8")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C08", Offset = "0xB14C08")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1AA2B9C", Offset = "0x1AA2B9C", VA = "0x1AA2B9C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1AA2D58", Offset = "0x1AA2D58", VA = "0x1AA2D58")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1AA2D74", Offset = "0x1AA2D74", VA = "0x1AA2D74")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C18", Offset = "0xB14C18")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x1AA2BA4", Offset = "0x1AA2BA4", VA = "0x1AA2BA4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x1AA2DC8", Offset = "0x1AA2DC8", VA = "0x1AA2DC8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1AA2DEC", Offset = "0x1AA2DEC", VA = "0x1AA2DEC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C28", Offset = "0xB14C28")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1AA2BAC", Offset = "0x1AA2BAC", VA = "0x1AA2BAC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1AA30B0", Offset = "0x1AA30B0", VA = "0x1AA30B0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1AA30D4", Offset = "0x1AA30D4", VA = "0x1AA30D4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C38", Offset = "0xB14C38")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1AA2D18", Offset = "0x1AA2D18", VA = "0x1AA2D18")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x1AA31D0", Offset = "0x1AA31D0", VA = "0x1AA31D0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1AA31F4", Offset = "0x1AA31F4", VA = "0x1AA31F4")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C48", Offset = "0xB14C48")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1AA2D20", Offset = "0x1AA2D20", VA = "0x1AA2D20")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0x1AA2D90", Offset = "0x1AA2D90", VA = "0x1AA2D90")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600005F")]
			[Address(RVA = "0x1AA2DAC", Offset = "0x1AA2DAC", VA = "0x1AA2DAC")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C58", Offset = "0xB14C58")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1AA2D28", Offset = "0x1AA2D28", VA = "0x1AA2D28")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1AA2E10", Offset = "0x1AA2E10", VA = "0x1AA2E10")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x1AA2E2C", Offset = "0x1AA2E2C", VA = "0x1AA2E2C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C68", Offset = "0xB14C68")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1AA2D30", Offset = "0x1AA2D30", VA = "0x1AA2D30")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x1AA2E48", Offset = "0x1AA2E48", VA = "0x1AA2E48")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x1AA2ED8", Offset = "0x1AA2ED8", VA = "0x1AA2ED8")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C78", Offset = "0xB14C78")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x1AA2D38", Offset = "0x1AA2D38", VA = "0x1AA2D38")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x1AA2F7C", Offset = "0x1AA2F7C", VA = "0x1AA2F7C")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x1AA300C", Offset = "0x1AA300C", VA = "0x1AA300C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C88", Offset = "0xB14C88")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x1AA2D40", Offset = "0x1AA2D40", VA = "0x1AA2D40")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x1AA30F8", Offset = "0x1AA30F8", VA = "0x1AA30F8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x1AA311C", Offset = "0x1AA311C", VA = "0x1AA311C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14C98", Offset = "0xB14C98")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x1AA2D48", Offset = "0x1AA2D48", VA = "0x1AA2D48")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1AA3140", Offset = "0x1AA3140", VA = "0x1AA3140")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1AA3164", Offset = "0x1AA3164", VA = "0x1AA3164")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14CA8", Offset = "0xB14CA8")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x1AA2D50", Offset = "0x1AA2D50", VA = "0x1AA2D50")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x1AA3188", Offset = "0x1AA3188", VA = "0x1AA3188")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x1AA31AC", Offset = "0x1AA31AC", VA = "0x1AA31AC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1AA0388", Offset = "0x1AA0388", VA = "0x1AA0388")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1A9FD0C", Offset = "0x1A9FD0C", VA = "0x1A9FD0C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1AA0110", Offset = "0x1AA0110", VA = "0x1AA0110")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1AA2BB4", Offset = "0x1AA2BB4", VA = "0x1AA2BB4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1A9F364", Offset = "0x1A9F364", VA = "0x1A9F364")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1A9FA4C", Offset = "0x1A9FA4C", VA = "0x1A9FA4C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1AA0698", Offset = "0x1AA0698", VA = "0x1AA0698")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1AA0848", Offset = "0x1AA0848", VA = "0x1AA0848")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1A9FE70", Offset = "0x1A9FE70", VA = "0x1A9FE70")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1AA024C", Offset = "0x1AA024C", VA = "0x1AA024C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1AA04C4", Offset = "0x1AA04C4", VA = "0x1AA04C4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x2000024")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000025")]
		public static class Physics
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x1AA335C", Offset = "0x1AA335C", VA = "0x1AA335C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1AA3464", Offset = "0x1AA3464", VA = "0x1AA3464")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1AA34F4", Offset = "0x1AA34F4", VA = "0x1AA34F4")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1AA3218", Offset = "0x1AA3218", VA = "0x1AA3218")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1AA32BC", Offset = "0x1AA32BC", VA = "0x1AA32BC")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class DOTweenAnimation : ABSAnimationComponent
	{
		[Token(Token = "0x2000027")]
		public enum AnimationType
		{
			[Token(Token = "0x400006B")]
			None,
			[Token(Token = "0x400006C")]
			Move,
			[Token(Token = "0x400006D")]
			LocalMove,
			[Token(Token = "0x400006E")]
			Rotate,
			[Token(Token = "0x400006F")]
			LocalRotate,
			[Token(Token = "0x4000070")]
			Scale,
			[Token(Token = "0x4000071")]
			Color,
			[Token(Token = "0x4000072")]
			Fade,
			[Token(Token = "0x4000073")]
			Text,
			[Token(Token = "0x4000074")]
			PunchPosition,
			[Token(Token = "0x4000075")]
			PunchRotation,
			[Token(Token = "0x4000076")]
			PunchScale,
			[Token(Token = "0x4000077")]
			ShakePosition,
			[Token(Token = "0x4000078")]
			ShakeRotation,
			[Token(Token = "0x4000079")]
			ShakeScale,
			[Token(Token = "0x400007A")]
			CameraAspect,
			[Token(Token = "0x400007B")]
			CameraBackgroundColor,
			[Token(Token = "0x400007C")]
			CameraFieldOfView,
			[Token(Token = "0x400007D")]
			CameraOrthoSize,
			[Token(Token = "0x400007E")]
			CameraPixelRect,
			[Token(Token = "0x400007F")]
			CameraRect,
			[Token(Token = "0x4000080")]
			UIWidthHeight
		}

		[Token(Token = "0x2000028")]
		public enum TargetType
		{
			[Token(Token = "0x4000082")]
			Unset,
			[Token(Token = "0x4000083")]
			Camera,
			[Token(Token = "0x4000084")]
			CanvasGroup,
			[Token(Token = "0x4000085")]
			Image,
			[Token(Token = "0x4000086")]
			Light,
			[Token(Token = "0x4000087")]
			RectTransform,
			[Token(Token = "0x4000088")]
			Renderer,
			[Token(Token = "0x4000089")]
			SpriteRenderer,
			[Token(Token = "0x400008A")]
			Rigidbody,
			[Token(Token = "0x400008B")]
			Rigidbody2D,
			[Token(Token = "0x400008C")]
			Text,
			[Token(Token = "0x400008D")]
			Transform,
			[Token(Token = "0x400008E")]
			tk2dBaseSprite,
			[Token(Token = "0x400008F")]
			tk2dTextMesh,
			[Token(Token = "0x4000090")]
			TextMeshPro,
			[Token(Token = "0x4000091")]
			TextMeshProUGUI
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool targetIsSelf;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject targetGO;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool tweenTargetIsTargetGO;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float delay;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float duration;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Ease easeType;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AnimationCurve easeCurve;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LoopType loopType;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int loops;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string id;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool isRelative;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool isFrom;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		public bool isIndependentUpdate;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		public bool autoKill;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool autoGenerate;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool isActive;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		public bool isValid;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Component target;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AnimationType animationType;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetType targetType;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TargetType forcedTargetType;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool autoPlay;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool useTargetAsV3;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float endValueFloat;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Vector3 endValueV3;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector2 endValueV2;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Color endValueColor;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public string endValueString;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Rect endValueRect;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform endValueTransform;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public bool optionalBool0;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		public bool optionalBool1;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float optionalFloat0;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public int optionalInt0;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public RotateMode optionalRotationMode;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public ScrambleMode optionalScrambleMode;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public string optionalString;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool _tweenAutoGenerationCalled;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private int _playCount;

		[Token(Token = "0x14000001")]
		public static event Action<DOTweenAnimation> OnReset
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1A9D67C", Offset = "0x1A9D67C", VA = "0x1A9D67C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14EB8", Offset = "0xB14EB8")]
			add
			{
			}
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1A9D730", Offset = "0x1A9D730", VA = "0x1A9D730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14EC8", Offset = "0xB14EC8")]
			remove
			{
			}
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1A9D7E4", Offset = "0x1A9D7E4", VA = "0x1A9D7E4")]
		private static void Dispatch_OnReset(DOTweenAnimation anim)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1A9D858", Offset = "0x1A9D858", VA = "0x1A9D858")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1A9EDB8", Offset = "0x1A9EDB8", VA = "0x1A9EDB8")]
		private void Start()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1A9EE04", Offset = "0x1A9EE04", VA = "0x1A9EE04")]
		private void Reset()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1A9EE08", Offset = "0x1A9EE08", VA = "0x1A9EE08")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1A9EE44", Offset = "0x1A9EE44", VA = "0x1A9EE44")]
		public void RewindThenRecreateTween()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1A9EE88", Offset = "0x1A9EE88", VA = "0x1A9EE88")]
		public void RewindThenRecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1A9EECC", Offset = "0x1A9EECC", VA = "0x1A9EECC")]
		public void RecreateTween()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1A9EED8", Offset = "0x1A9EED8", VA = "0x1A9EED8")]
		public void RecreateTweenAndPlay()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1A9D8B0", Offset = "0x1A9D8B0", VA = "0x1A9D8B0")]
		public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1AA0A34", Offset = "0x1AA0A34", VA = "0x1AA0A34")]
		public List<Tween> GetTweens()
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1AA0B2C", Offset = "0x1AA0B2C", VA = "0x1AA0B2C")]
		public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1AA0C00", Offset = "0x1AA0C00", VA = "0x1AA0C00", Slot = "4")]
		public override void DOPlay()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1AA0C90", Offset = "0x1AA0C90", VA = "0x1AA0C90", Slot = "5")]
		public override void DOPlayBackwards()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1AA0D20", Offset = "0x1AA0D20", VA = "0x1AA0D20", Slot = "6")]
		public override void DOPlayForward()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1AA0DB0", Offset = "0x1AA0DB0", VA = "0x1AA0DB0", Slot = "7")]
		public override void DOPause()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1AA0E40", Offset = "0x1AA0E40", VA = "0x1AA0E40", Slot = "8")]
		public override void DOTogglePause()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1AA0ED0", Offset = "0x1AA0ED0", VA = "0x1AA0ED0", Slot = "9")]
		public override void DORewind()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1AA0FCC", Offset = "0x1AA0FCC", VA = "0x1AA0FCC", Slot = "10")]
		public override void DORestart()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1AA0FDC", Offset = "0x1AA0FDC", VA = "0x1AA0FDC", Slot = "11")]
		public override void DORestart(bool fromHere)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1AA13A4", Offset = "0x1AA13A4", VA = "0x1AA13A4", Slot = "12")]
		public override void DOComplete()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1AA1438", Offset = "0x1AA1438", VA = "0x1AA1438", Slot = "13")]
		public override void DOKill()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1AA14D4", Offset = "0x1AA14D4", VA = "0x1AA14D4")]
		public void DOPlayById(string id)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1AA1574", Offset = "0x1AA1574", VA = "0x1AA1574")]
		public void DOPlayAllById(string id)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1AA15DC", Offset = "0x1AA15DC", VA = "0x1AA15DC")]
		public void DOPauseAllById(string id)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1AA1644", Offset = "0x1AA1644", VA = "0x1AA1644")]
		public void DOPlayBackwardsById(string id)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1AA16E4", Offset = "0x1AA16E4", VA = "0x1AA16E4")]
		public void DOPlayBackwardsAllById(string id)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1AA174C", Offset = "0x1AA174C", VA = "0x1AA174C")]
		public void DOPlayForwardById(string id)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1AA17EC", Offset = "0x1AA17EC", VA = "0x1AA17EC")]
		public void DOPlayForwardAllById(string id)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1AA1854", Offset = "0x1AA1854", VA = "0x1AA1854")]
		public void DOPlayNext()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1AA1990", Offset = "0x1AA1990", VA = "0x1AA1990")]
		public void DORewindAndPlayNext()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1AA1A34", Offset = "0x1AA1A34", VA = "0x1AA1A34")]
		public void DORewindAllById(string id)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1AA1AB4", Offset = "0x1AA1AB4", VA = "0x1AA1AB4")]
		public void DORestartById(string id)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1AA1B64", Offset = "0x1AA1B64", VA = "0x1AA1B64")]
		public void DORestartAllById(string id)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1AA1BE8", Offset = "0x1AA1BE8", VA = "0x1AA1BE8")]
		public void DOKillById(string id)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1AA1C8C", Offset = "0x1AA1C8C", VA = "0x1AA1C8C")]
		public void DOKillAllById(string id)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1A9EEFC", Offset = "0x1A9EEFC", VA = "0x1A9EEFC")]
		public static TargetType TypeToDOTargetType(Type t)
		{
			return default(TargetType);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1AA1CF8", Offset = "0x1AA1CF8", VA = "0x1AA1CF8")]
		public Tween CreateEditorPreview()
		{
			return null;
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1A9EEE4", Offset = "0x1A9EEE4", VA = "0x1A9EEE4")]
		private GameObject GetTweenGO()
		{
			return null;
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1AA0A14", Offset = "0x1AA0A14", VA = "0x1AA0A14")]
		private GameObject GetTweenTarget()
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1AA110C", Offset = "0x1AA110C", VA = "0x1AA110C")]
		private void ReEvaluateRelativeTween()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1AA1D3C", Offset = "0x1AA1D3C", VA = "0x1AA1D3C")]
		public DOTweenAnimation()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1AA1F1C", Offset = "0x1AA1F1C", VA = "0x1AA1F1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14ED8", Offset = "0xB14ED8")]
		private void <CreateTween>b__53_0()
		{
		}
	}
}
namespace CrazyMinnow.SALSA.OneClicks
{
	[Token(Token = "0x2000029")]
	public class OneClickBase : MonoBehaviour
	{
		[Token(Token = "0x4000092")]
		public const string RESOURCE_CLIP = "Assets/Crazy Minnow Studio/Examples/Audio/Promo-male.mp3";

		[Token(Token = "0x4000093")]
		public const string PREFAB_ALERT_TITLE = "Prefab Unpack Warning";

		[Token(Token = "0x4000094")]
		public const string PREFAB_ALERT_MSG = "Your selection is a prefab and must be unpacked to apply this setup. You can create a new prefab once the setup is complete. Do you want to proceed?";

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<SkinnedMeshRenderer> requiredSmrs;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static List<OneClickConfiguration> oneClickConfigurations;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static Salsa salsa;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected static Emoter emoter;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static UmaUepProxy uepProxy;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static GameObject selectedObject;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static float emphasizerTrigger;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected static bool autoAdjustAnalysis;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		protected static bool autoAdjustMicrophone;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static float audioUpdateDelay;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected static float loCutoff;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static float hiCutoff;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected static bool useAdvDyn;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected static float advDynPrimaryBias;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected static bool useAdvDynJitter;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected static float advDynJitterAmount;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected static float advDynJitterProb;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected static float advDynSecondaryMix;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected static float emphasisChance;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected static bool useRandomEmotes;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected static bool isChancePerEmote;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		protected static int numRandomEmotesPerCycle;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected static float randomEmoteMinTimer;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected static float randomEmoteMaxTimer;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected static float randomChance;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		protected static bool useRandomFrac;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected static float randomFracBias;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected static bool useRandomHoldDuration;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected static float randomHoldDurationMin;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected static float randomHoldDurationMax;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected static LerpEasings.EasingType easingType;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static OneClickConfiguration currentConfiguration;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1A99340", Offset = "0x1A99340", VA = "0x1A99340")]
		protected static void NewConfiguration(OneClickConfiguration.ConfigType configType)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1A99508", Offset = "0x1A99508", VA = "0x1A99508")]
		protected static void AddSmrSearch(string search)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1A99594", Offset = "0x1A99594", VA = "0x1A99594")]
		protected static void NewExpression(string expressionName)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1A9977C", Offset = "0x1A9977C", VA = "0x1A9977C")]
		protected static void AddShapeComponent(string[] blendshapeNames, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f, bool useRegex = false)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1A99930", Offset = "0x1A99930", VA = "0x1A99930")]
		protected static void AddUepPoseComponent(string poseName, float durOn, float durHold, float durOff, string componentName = "", float amount = 1f)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1A99AC0", Offset = "0x1A99AC0", VA = "0x1A99AC0")]
		protected static void AddAnimatorComponent(string componentName, string animatorSearch, float durOn, float durHold, float durOff, int parmIndex, bool isTriggereParmBiDir = false)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1A99BF4", Offset = "0x1A99BF4", VA = "0x1A99BF4")]
		protected static void AddBoneComponent(string componentSearchName, TformBase maxTform, float durOn, float durHold, float durOff, string componentName = "", bool constrainPos = false, bool constrainRot = true, bool constrainScl = false)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1A99E24", Offset = "0x1A99E24", VA = "0x1A99E24")]
		protected static void AddEmoteFlags(bool isRandom, bool isEmph, bool isRepeater, float frac = 1f, bool isAlwaysEmph = false)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1A99F70", Offset = "0x1A99F70", VA = "0x1A99F70")]
		protected static void DoOneClickiness(GameObject go, AudioClip clip)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1A9A238", Offset = "0x1A9A238", VA = "0x1A9A238")]
		private static bool FindSkinnedMeshRenderers(OneClickConfiguration configuration)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1A9AA94", Offset = "0x1A9AA94", VA = "0x1A9AA94")]
		private static void ConfigEmoterSettings(QueueProcessor qp)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1A9A6D8", Offset = "0x1A9A6D8", VA = "0x1A9A6D8")]
		private static void ConfigureSalsaSettings(AudioClip clip, QueueProcessor qp)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1A9B75C", Offset = "0x1A9B75C", VA = "0x1A9B75C")]
		protected static void Init()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1A9AD78", Offset = "0x1A9AD78", VA = "0x1A9AD78")]
		private static void ConfigureModuleExpressions(OneClickConfiguration configuration)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1A9B7F8", Offset = "0x1A9B7F8", VA = "0x1A9B7F8")]
		private static Expression InitializeExpressionType(OneClickConfiguration configuration, int exp)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1A9BBB0", Offset = "0x1A9BBB0", VA = "0x1A9BBB0")]
		private static int RegexFindBlendshapeName(SkinnedMeshRenderer smr, string bName)
		{
			return default(int);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1A9C254", Offset = "0x1A9C254", VA = "0x1A9C254")]
		private static string[] GetBlendshapeNames(SkinnedMeshRenderer smr)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1A9BFC0", Offset = "0x1A9BFC0", VA = "0x1A9BFC0")]
		private static TformBase ConvertBoneToTform(Transform bone)
		{
			return default(TformBase);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1A9BE90", Offset = "0x1A9BE90", VA = "0x1A9BE90")]
		private static Transform FindBone(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1A9C124", Offset = "0x1A9C124", VA = "0x1A9C124")]
		private static Animator FindAnimator(string componentSearchName)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1A9BDA4", Offset = "0x1A9BDA4", VA = "0x1A9BDA4")]
		private static void ApplyCommonSettingsToComponent(ExpressionComponent component, OneClickComponent oneClickComponent, int componentNumber)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1A9BCB8", Offset = "0x1A9BCB8", VA = "0x1A9BCB8")]
		private static int CreateNewComponent(int componentCount, Expression expression)
		{
			return default(int);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1A9C384", Offset = "0x1A9C384", VA = "0x1A9C384")]
		public OneClickBase()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class OneClickBoxHead : OneClickBase
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1A9C530", Offset = "0x1A9C530", VA = "0x1A9C530")]
		public static void Setup(GameObject gameObject, AudioClip clip)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1A9CBB0", Offset = "0x1A9CBB0", VA = "0x1A9CBB0")]
		public OneClickBoxHead()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class OneClickBoxHeadEyes : MonoBehaviour
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1A9CC18", Offset = "0x1A9CC18", VA = "0x1A9CC18")]
		public static void Setup(GameObject go)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1A9D66C", Offset = "0x1A9D66C", VA = "0x1A9D66C")]
		public OneClickBoxHeadEyes()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class OneClickComponent
	{
		[Token(Token = "0x200002D")]
		public enum ComponentType
		{
			[Token(Token = "0x40000BB")]
			Shape,
			[Token(Token = "0x40000BC")]
			UMA,
			[Token(Token = "0x40000BD")]
			Bone,
			[Token(Token = "0x40000BE")]
			Animator
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ComponentType type;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string componentName;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float durOn;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float durHold;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float durOff;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1A99338", Offset = "0x1A99338", VA = "0x1A99338")]
		public OneClickComponent()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class OneClickShapeComponent : OneClickComponent
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] blendshapeNames;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool useRegex;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1A998AC", Offset = "0x1A998AC", VA = "0x1A998AC")]
		public OneClickShapeComponent(string componentName, string[] blendshapeNames, float maxAmount, float durOn, float durHold, float durOff, ComponentType type, bool useRegex)
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class OneClickBoneComponent : OneClickComponent
	{
		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TformBase max;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool usePos;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useRot;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useScl;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1A99D70", Offset = "0x1A99D70", VA = "0x1A99D70")]
		public OneClickBoneComponent(string componentName, string boneSearchName, TformBase max, bool usePos, bool useRot, bool useScl, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class OneClickUepComponent : OneClickComponent
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string poseName;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxAmount;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1A99A50", Offset = "0x1A99A50", VA = "0x1A99A50")]
		public OneClickUepComponent(string componentName, string poseName, float maxAmount, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class OneClickAnimatorComponent : OneClickComponent
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string componentSearchName;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int animationParmIndex;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool isTriggerParmBiDirectional;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1A992B4", Offset = "0x1A992B4", VA = "0x1A992B4")]
		public OneClickAnimatorComponent(string componentName, string animatorSearchName, int animationParmIndex, bool isTriggerParmBiDirectional, float durOn, float durHold, float durOff, ComponentType type)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class OneClickConfiguration
	{
		[Token(Token = "0x2000033")]
		public enum ConfigType
		{
			[Token(Token = "0x40000D0")]
			Salsa,
			[Token(Token = "0x40000D1")]
			Emoter
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ConfigType type;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> smrSearches;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<OneClickExpression> oneClickExpressions;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1A9942C", Offset = "0x1A9942C", VA = "0x1A9942C")]
		public OneClickConfiguration(ConfigType type)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class OneClickExpression
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OneClickComponent> components;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1A9D674", Offset = "0x1A9D674", VA = "0x1A9D674")]
		public OneClickExpression()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1A99704", Offset = "0x1A99704", VA = "0x1A99704")]
		public OneClickExpression(string name, List<OneClickComponent> components)
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class OneClickEmoterExpression : OneClickExpression
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isRandom;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool isEmphasis;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool isAlwaysEmphasis;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool isRepeater;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float expressionDynamics;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1A9973C", Offset = "0x1A9973C", VA = "0x1A9973C")]
		public OneClickEmoterExpression(string name, List<OneClickComponent> components)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1A99F48", Offset = "0x1A99F48", VA = "0x1A99F48")]
		public void SetEmoterBools(bool isRand, bool isEmph, bool isRep, float frac, bool isAlwaysEmph = false)
		{
		}
	}
}
