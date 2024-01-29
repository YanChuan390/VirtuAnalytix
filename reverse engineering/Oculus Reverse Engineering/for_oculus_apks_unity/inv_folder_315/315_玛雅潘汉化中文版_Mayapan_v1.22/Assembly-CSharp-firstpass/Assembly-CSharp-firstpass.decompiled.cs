using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using ScreenshotCompanionFramework;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class ScreenshotCompanion : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum FileType
	{
		[Token(Token = "0x400000D")]
		PNG,
		[Token(Token = "0x400000E")]
		JPG
	}

	[Token(Token = "0x2000004")]
	public enum CaptureMethod
	{
		[Token(Token = "0x4000010")]
		CaptureScreenshot,
		[Token(Token = "0x4000011")]
		RenderTexture,
		[Token(Token = "0x4000012")]
		Cutout
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F4DAC", Offset = "0x5F4DAC")]
	private sealed class <CaptureCutout>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x20")]
		public ScreenshotCompanion <>4__this;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x28")]
		public int id;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x13E5738", Offset = "0x13E5738", VA = "0x13E5738", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x13E5780", Offset = "0x13E5780", VA = "0x13E5780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x13E4270", Offset = "0x13E4270", VA = "0x13E4270")]
		[DebuggerHidden]
		public <CaptureCutout>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x13E519C", Offset = "0x13E519C", VA = "0x13E519C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x13E51A0", Offset = "0x13E51A0", VA = "0x13E51A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x13E5740", Offset = "0x13E5740", VA = "0x13E5740", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F4DBC", Offset = "0x5F4DBC")]
	private sealed class <HideCamera>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x20")]
		public ScreenshotCompanion <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x13E5888", Offset = "0x13E5888", VA = "0x13E5888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x13E58D0", Offset = "0x13E58D0", VA = "0x13E58D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x13E4AF4", Offset = "0x13E4AF4", VA = "0x13E4AF4")]
		[DebuggerHidden]
		public <HideCamera>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x13E5788", Offset = "0x13E5788", VA = "0x13E5788", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x13E578C", Offset = "0x13E578C", VA = "0x13E578C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x13E5890", Offset = "0x13E5890", VA = "0x13E5890", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public static ScreenshotCompanion Instance;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x18")]
	public List<CameraObject> list;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	public SettingsaObject settings;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public bool foldoutSettings;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	public int lastCamID;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Camera lastCam;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	private GUIStyle cutoutBoxStyle;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x8")]
	private static int framesToRender;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x40")]
	private Vector2 lastP;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 lastS;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x50")]
	private float timer;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x13E3000", Offset = "0x13E3000", VA = "0x13E3000")]
	public void Create()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x13E3084", Offset = "0x13E3084", VA = "0x13E3084")]
	public void RequestDelete(int id)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x13E3104", Offset = "0x13E3104", VA = "0x13E3104")]
	public void Delete(int id)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x13E31C8", Offset = "0x13E31C8", VA = "0x13E31C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13E32A4", Offset = "0x13E32A4", VA = "0x13E32A4")]
	public static void TakeScreenshot()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x13E3350", Offset = "0x13E3350", VA = "0x13E3350")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x13E3AE4", Offset = "0x13E3AE4", VA = "0x13E3AE4")]
	private void activateCameraID(int id)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x13E3C3C", Offset = "0x13E3C3C", VA = "0x13E3C3C")]
	public string getSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x13E3D08", Offset = "0x13E3D08", VA = "0x13E3D08")]
	private string checkSaveDirectory()
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x13E3D44", Offset = "0x13E3D44", VA = "0x13E3D44")]
	private void initCutoutBoxStyle()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x13E3F88", Offset = "0x13E3F88", VA = "0x13E3F88")]
	private void clampCutoutBox()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x13E409C", Offset = "0x13E409C", VA = "0x13E409C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x13E4218", Offset = "0x13E4218", VA = "0x13E4218")]
	public void CaptureCutoutVoid(int id)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x13E3A5C", Offset = "0x13E3A5C", VA = "0x13E3A5C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5F4E0C", Offset = "0x5F4E0C")]
	public IEnumerator CaptureCutout(int id)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x13E429C", Offset = "0x13E429C", VA = "0x13E429C")]
	private void cutoutEmptyCheck()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x13E3564", Offset = "0x13E3564", VA = "0x13E3564")]
	public void CaptureScreenshots(int id, bool fallback)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x13E4A7C", Offset = "0x13E4A7C", VA = "0x13E4A7C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5F4E6C", Offset = "0x5F4E6C")]
	private IEnumerator HideCamera()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x13E36B4", Offset = "0x13E36B4", VA = "0x13E36B4")]
	public void CaptureRenderTexture(Camera attachedCam, int id)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x13E45F0", Offset = "0x13E45F0", VA = "0x13E45F0")]
	public string getFileName(int camID)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x13E4B20", Offset = "0x13E4B20", VA = "0x13E4B20")]
	public string getResolution()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x13E4F80", Offset = "0x13E4F80", VA = "0x13E4F80")]
	private void DebugLogExtended(string log)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x13E4A50", Offset = "0x13E4A50", VA = "0x13E4A50")]
	private void postCapture()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x13E5060", Offset = "0x13E5060", VA = "0x13E5060")]
	public ScreenshotCompanion()
	{
	}
}
namespace ScreenshotCompanionFramework;

[Serializable]
[Token(Token = "0x2000007")]
public class CameraObject
{
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x10")]
	public GameObject cam;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool deleteQuestion;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x1C")]
	public KeyCode hotkey;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x13E2FF8", Offset = "0x13E2FF8", VA = "0x13E2FF8")]
	public CameraObject()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class SettingsaObject
{
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x10")]
	public Color signatureColor;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x20")]
	public string customFileName;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x28")]
	public bool includeProject;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x29")]
	public bool includeCamera;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x2A")]
	public bool includeDate;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x2B")]
	public bool includeResolution;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x2C")]
	public bool includeCounter;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x30")]
	public int counter;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x34")]
	public ScreenshotCompanion.FileType fileType;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x38")]
	public bool applicationPath;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x40")]
	public string customDirectoryName;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x48")]
	public ScreenshotCompanion.CaptureMethod captureMethod;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x4C")]
	public bool singleCamera;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x50")]
	public float renderSizeMultiplier;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x54")]
	public int captureSizeMultiplier;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 cutoutPosition;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 cutoutSize;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x13E50E4", Offset = "0x13E50E4", VA = "0x13E50E4")]
	public SettingsaObject()
	{
	}
}
