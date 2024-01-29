using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using AmazingEngine;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public abstract class AlgorithmBase : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	private sealed class <StartCamera>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AlgorithmBase <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1490334", Offset = "0x1490334", VA = "0x1490334", Slot = "4")]
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
			[Address(RVA = "0x149039C", Offset = "0x149039C", VA = "0x149039C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x148E660", Offset = "0x148E660", VA = "0x148E660")]
		[DebuggerHidden]
		public <StartCamera>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x148FE2C", Offset = "0x148FE2C", VA = "0x148FE2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x148FE30", Offset = "0x148FE30", VA = "0x148FE30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x149033C", Offset = "0x149033C", VA = "0x149033C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000004")]
	private sealed class <DetectVideo>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AlgorithmBase <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x148FDBC", Offset = "0x148FDBC", VA = "0x148FDBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x148FE24", Offset = "0x148FE24", VA = "0x148FE24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x148E708", Offset = "0x148E708", VA = "0x148E708")]
		[DebuggerHidden]
		public <DetectVideo>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x148FCE0", Offset = "0x148FCE0", VA = "0x148FCE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x148FCE4", Offset = "0x148FCE4", VA = "0x148FCE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x148FDC4", Offset = "0x148FDC4", VA = "0x148FDC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string applicationName;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string modelPath;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string modelListPath;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected string graphConfig;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected long algorithmSystemPtr;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected WebCamTexture webCamTexture;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected int textureWidth;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	protected int textureHeight;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IEnumerator videoCor;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool cameraOn;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	protected bool executeOn;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RawImage showImage;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected int imageWidth;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected int imageHeight;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private string screenLog;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string screenLogBuf;

	[Token(Token = "0x4000011")]
	private const int GUI_FONT_SIZE = 40;

	[Token(Token = "0x4000012")]
	private const int GUI_SPACE = 50;

	[Token(Token = "0x4000013")]
	private const int GUI_BTN_WIDTH = 250;

	[Token(Token = "0x4000014")]
	private const int GUI_BTN_HEIGHT = 150;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Rect btn1Rect;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Rect btn2Rect;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Rect logRect;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x148E158", Offset = "0x148E158", VA = "0x148E158")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x148E3F4", Offset = "0x148E3F4", VA = "0x148E3F4")]
	private IEnumerator StartCamera()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x148E470", Offset = "0x148E470", VA = "0x148E470")]
	private void StartDetect()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x148E68C", Offset = "0x148E68C", VA = "0x148E68C")]
	private IEnumerator DetectVideo()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x148E734", Offset = "0x148E734", VA = "0x148E734")]
	private void InitBach()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x148E4D8", Offset = "0x148E4D8", VA = "0x148E4D8")]
	private void ReleaseBach()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x148EE7C", Offset = "0x148EE7C", VA = "0x148EE7C")]
	private void CopyAndroidModels(string modelListPath)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x148E580", Offset = "0x148E580", VA = "0x148E580")]
	protected void AddLog(string str)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x148E5F4", Offset = "0x148E5F4", VA = "0x148E5F4")]
	protected void FlushLog()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x148F988", Offset = "0x148F988", VA = "0x148F988")]
	public int GetCurImageWidth()
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x148FA14", Offset = "0x148FA14", VA = "0x148FA14")]
	public int GetCurImageHeight()
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x148F9BC", Offset = "0x148F9BC", VA = "0x148F9BC")]
	public bool NeedTransXY()
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x148F7D0", Offset = "0x148F7D0", VA = "0x148F7D0")]
	public BACH_AERotateMode GetRotateMode()
	{
		return default(BACH_AERotateMode);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x148FA48", Offset = "0x148FA48", VA = "0x148FA48")]
	public int GetScreenRotateAngle()
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x148FA84", Offset = "0x148FA84", VA = "0x148FA84")]
	public BACH_AERotateMode GetSLAMRotateMode()
	{
		return default(BACH_AERotateMode);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x148F824", Offset = "0x148F824", VA = "0x148F824")]
	public bool GetVerticallyMirrored()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	protected abstract void GUIShow();

	[Token(Token = "0x6000012")]
	protected abstract void InitBachIntParam(SWIGTYPE_p_BACH_AlgorithmIntParamMap intParamMap);

	[Token(Token = "0x6000013")]
	protected abstract bool Execute();

	[Token(Token = "0x6000014")]
	protected abstract void GetResult();

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x148FB1C", Offset = "0x148FB1C", VA = "0x148FB1C")]
	protected AlgorithmBase()
	{
	}
}
[Token(Token = "0x2000005")]
public class AlgorithmFace : AlgorithmBase
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<Rect> rectList;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x14903A4", Offset = "0x14903A4", VA = "0x14903A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x14903F8", Offset = "0x14903F8", VA = "0x14903F8", Slot = "5")]
	protected override void InitBachIntParam(SWIGTYPE_p_BACH_AlgorithmIntParamMap intParamMap)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x149052C", Offset = "0x149052C", VA = "0x149052C", Slot = "4")]
	protected override void GUIShow()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1490630", Offset = "0x1490630", VA = "0x1490630", Slot = "6")]
	protected override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1490C78", Offset = "0x1490C78", VA = "0x1490C78", Slot = "7")]
	protected override void GetResult()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1491D20", Offset = "0x1491D20", VA = "0x1491D20")]
	public AlgorithmFace()
	{
	}
}
[Token(Token = "0x2000006")]
public class AlgorithmSLAM : AlgorithmBase
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Camera mainCamera;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform modelTransform;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1491D98", Offset = "0x1491D98", VA = "0x1491D98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1491DEC", Offset = "0x1491DEC", VA = "0x1491DEC", Slot = "5")]
	protected override void InitBachIntParam(SWIGTYPE_p_BACH_AlgorithmIntParamMap intParamMap)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1491F08", Offset = "0x1491F08", VA = "0x1491F08", Slot = "4")]
	protected override void GUIShow()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1492390", Offset = "0x1492390", VA = "0x1492390", Slot = "6")]
	protected override bool Execute()
	{
		return default(bool);
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1492B6C", Offset = "0x1492B6C", VA = "0x1492B6C", Slot = "7")]
	protected override void GetResult()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1494648", Offset = "0x1494648", VA = "0x1494648")]
	public AlgorithmSLAM()
	{
	}
}
[Token(Token = "0x2000007")]
public class AlgorithmUtils
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static Vector4 col0;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static Vector4 col1;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected static Vector4 col2;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected static Vector4 col3;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected static Matrix4x4 m;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x149464C", Offset = "0x149464C", VA = "0x149464C")]
	public static void CopyAndroidModels(string modelListPath, string model)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1490934", Offset = "0x1490934", VA = "0x1490934")]
	public static IntPtr Color32ArrayToIntptr(Color32[] colors, int length)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x148F908", Offset = "0x148F908", VA = "0x148F908")]
	public static string GetFileContent(string path)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1493EE4", Offset = "0x1493EE4", VA = "0x1493EE4")]
	public static Matrix4x4 ArrayToMatrix4x4(BACH_FloatArray floatArray)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x14943C4", Offset = "0x14943C4", VA = "0x14943C4")]
	public static Matrix4x4 ArrayToMatrix4x4LR(BACH_FloatArray floatArray)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1494154", Offset = "0x1494154", VA = "0x1494154")]
	public static Matrix4x4 ProjectionMatrix4x4TRANSXY(BACH_FloatArray floatArray)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x14934D8", Offset = "0x14934D8", VA = "0x14934D8")]
	public static string MatrixToString(BACH_FloatArray floatArray)
	{
		return null;
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000008")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x2000009")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1499AE0", Offset = "0x1499AE0", VA = "0x1499AE0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x149A308", Offset = "0x149A308", VA = "0x149A308")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000A")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600003D")]
			[Address(RVA = "0x1499C80", Offset = "0x1499C80", VA = "0x1499C80")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x149A444", Offset = "0x149A444", VA = "0x149A444")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000B")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1499E20", Offset = "0x1499E20", VA = "0x1499E20")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x149A460", Offset = "0x149A460", VA = "0x149A460")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000C")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x1499FC0", Offset = "0x1499FC0", VA = "0x1499FC0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x149A47C", Offset = "0x149A47C", VA = "0x149A47C")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000D")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000043")]
			[Address(RVA = "0x149A150", Offset = "0x149A150", VA = "0x149A150")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x149A498", Offset = "0x149A498", VA = "0x149A498")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200000E")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x149A300", Offset = "0x149A300", VA = "0x149A300")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x149A324", Offset = "0x149A324", VA = "0x149A324")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x149A340", Offset = "0x149A340", VA = "0x149A340")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1499960", Offset = "0x1499960", VA = "0x1499960")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1499AE8", Offset = "0x1499AE8", VA = "0x1499AE8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1499C88", Offset = "0x1499C88", VA = "0x1499C88")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1499E28", Offset = "0x1499E28", VA = "0x1499E28")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1499FC8", Offset = "0x1499FC8", VA = "0x1499FC8")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x149A158", Offset = "0x149A158", VA = "0x149A158")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200000F")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000010")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x149A600", Offset = "0x149A600", VA = "0x149A600")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x149BB48", Offset = "0x149BB48", VA = "0x149BB48")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000059")]
			[Address(RVA = "0x149BB64", Offset = "0x149BB64", VA = "0x149BB64")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000011")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x149A77C", Offset = "0x149A77C", VA = "0x149A77C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600005B")]
			[Address(RVA = "0x149BC60", Offset = "0x149BC60", VA = "0x149BC60")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x149BC84", Offset = "0x149BC84", VA = "0x149BC84")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000012")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x600005D")]
			[Address(RVA = "0x149A8F8", Offset = "0x149A8F8", VA = "0x149A8F8")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600005E")]
			[Address(RVA = "0x149BEA8", Offset = "0x149BEA8", VA = "0x149BEA8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600005F")]
			[Address(RVA = "0x149BECC", Offset = "0x149BECC", VA = "0x149BECC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000013")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000060")]
			[Address(RVA = "0x149AA4C", Offset = "0x149AA4C", VA = "0x149AA4C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0x149BEF0", Offset = "0x149BEF0", VA = "0x149BEF0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x149BF14", Offset = "0x149BF14", VA = "0x149BF14")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000014")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x149ABC4", Offset = "0x149ABC4", VA = "0x149ABC4")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000064")]
			[Address(RVA = "0x149BF38", Offset = "0x149BF38", VA = "0x149BF38")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x149BF54", Offset = "0x149BF54", VA = "0x149BF54")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000015")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000066")]
			[Address(RVA = "0x149AD40", Offset = "0x149AD40", VA = "0x149AD40")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000067")]
			[Address(RVA = "0x149BB80", Offset = "0x149BB80", VA = "0x149BB80")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000068")]
			[Address(RVA = "0x149BB9C", Offset = "0x149BB9C", VA = "0x149BB9C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000016")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000069")]
			[Address(RVA = "0x149AEC8", Offset = "0x149AEC8", VA = "0x149AEC8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x600006A")]
			[Address(RVA = "0x149BBB8", Offset = "0x149BBB8", VA = "0x149BBB8")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600006B")]
			[Address(RVA = "0x149BBD4", Offset = "0x149BBD4", VA = "0x149BBD4")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000017")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x149B050", Offset = "0x149B050", VA = "0x149B050")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x149BBF0", Offset = "0x149BBF0", VA = "0x149BBF0")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x149BC0C", Offset = "0x149BC0C", VA = "0x149BC0C")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000018")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600006F")]
			[Address(RVA = "0x149B1D4", Offset = "0x149B1D4", VA = "0x149B1D4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x149BC28", Offset = "0x149BC28", VA = "0x149BC28")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000071")]
			[Address(RVA = "0x149BC44", Offset = "0x149BC44", VA = "0x149BC44")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000019")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000072")]
			[Address(RVA = "0x149B350", Offset = "0x149B350", VA = "0x149B350")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000073")]
			[Address(RVA = "0x149BCA8", Offset = "0x149BCA8", VA = "0x149BCA8")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000074")]
			[Address(RVA = "0x149BCC4", Offset = "0x149BCC4", VA = "0x149BCC4")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200001A")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x149B4BC", Offset = "0x149B4BC", VA = "0x149B4BC")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x149BCE0", Offset = "0x149BCE0", VA = "0x149BCE0")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x149BD04", Offset = "0x149BD04", VA = "0x149BD04")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200001B")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x149B638", Offset = "0x149B638", VA = "0x149B638")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x149BD28", Offset = "0x149BD28", VA = "0x149BD28")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600007A")]
			[Address(RVA = "0x149BD4C", Offset = "0x149BD4C", VA = "0x149BD4C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001C")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int v;

			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Text target;

			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool addThousandsSeparator;

			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CultureInfo cInfo;

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x149B800", Offset = "0x149B800", VA = "0x149B800")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x600007C")]
			[Address(RVA = "0x149BD70", Offset = "0x149BD70", VA = "0x149BD70")]
			internal int <DOCounter>b__0()
			{
				return default(int);
			}

			[Token(Token = "0x600007D")]
			[Address(RVA = "0x149BD78", Offset = "0x149BD78", VA = "0x149BD78")]
			internal void <DOCounter>b__1(int x)
			{
			}
		}

		[Token(Token = "0x200001D")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600007E")]
			[Address(RVA = "0x149B954", Offset = "0x149B954", VA = "0x149B954")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600007F")]
			[Address(RVA = "0x149BE18", Offset = "0x149BE18", VA = "0x149BE18")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000080")]
			[Address(RVA = "0x149BE3C", Offset = "0x149BE3C", VA = "0x149BE3C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200001E")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000081")]
			[Address(RVA = "0x149BB40", Offset = "0x149BB40", VA = "0x149BB40")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000082")]
			[Address(RVA = "0x149BE60", Offset = "0x149BE60", VA = "0x149BE60")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000083")]
			[Address(RVA = "0x149BE84", Offset = "0x149BE84", VA = "0x149BE84")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x149A4B4", Offset = "0x149A4B4", VA = "0x149A4B4")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x149A608", Offset = "0x149A608", VA = "0x149A608")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x149A784", Offset = "0x149A784", VA = "0x149A784")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x149A900", Offset = "0x149A900", VA = "0x149A900")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x149AA54", Offset = "0x149AA54", VA = "0x149AA54")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x149ABCC", Offset = "0x149ABCC", VA = "0x149ABCC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x149AD48", Offset = "0x149AD48", VA = "0x149AD48")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x149AED0", Offset = "0x149AED0", VA = "0x149AED0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x149B058", Offset = "0x149B058", VA = "0x149B058")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x149B1DC", Offset = "0x149B1DC", VA = "0x149B1DC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x149B358", Offset = "0x149B358", VA = "0x149B358")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x149B4C4", Offset = "0x149B4C4", VA = "0x149B4C4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x149B640", Offset = "0x149B640", VA = "0x149B640")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x149B808", Offset = "0x149B808", VA = "0x149B808")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x149B95C", Offset = "0x149B95C", VA = "0x149B95C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000020")]
		public static class Physics
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x149C0B4", Offset = "0x149C0B4", VA = "0x149C0B4")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000087")]
			[Address(RVA = "0x149C1BC", Offset = "0x149C1BC", VA = "0x149C1BC")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000088")]
			[Address(RVA = "0x149C24C", Offset = "0x149C24C", VA = "0x149C24C")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x149BF70", Offset = "0x149BF70", VA = "0x149BF70")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x149C014", Offset = "0x149C014", VA = "0x149C014")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace StarkPatch
{
	[Token(Token = "0x2000021")]
	internal class DownloadCallback : AndroidJavaProxy
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<string, long, long, long, long> mOnProgressChanged;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Action<string, int, string> mOnError;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Action mOnFinish;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x14A04D8", Offset = "0x14A04D8", VA = "0x14A04D8")]
		public DownloadCallback(Action<string, long, long, long, long> onProgressChanged, Action<string, int, string> onError, Action onCompelete)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x14A0598", Offset = "0x14A0598", VA = "0x14A0598")]
		public void onProgressChanged(string itemName, long itemDownloadedSize, long itemTotalSize, long totalDownloadedSize, long totalSize)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x14A0630", Offset = "0x14A0630", VA = "0x14A0630")]
		public void onError(string strCurFileName, int errCode, string errorMessage)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x14A06B0", Offset = "0x14A06B0", VA = "0x14A06B0")]
		public void onFinish()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class StarkPatchManager
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AndroidJavaObject mUpdateManagerAndroidObject;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AndroidJavaObject mBundleManagerAndroidObject;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AndroidJavaObject mDownloadManagerAndroidObject;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StarkPatchManager mInst;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x14A06CC", Offset = "0x14A06CC", VA = "0x14A06CC")]
		private static StarkPatchManager inst()
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x14A0750", Offset = "0x14A0750", VA = "0x14A0750")]
		private StarkPatchManager()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x14A0A2C", Offset = "0x14A0A2C", VA = "0x14A0A2C")]
		public static void DownloadPatches(string downloadDir, Action<string, long, long, long, long> onProgressChanged, Action<string, int, string> onError, Action onCompelete)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x14A0CFC", Offset = "0x14A0CFC", VA = "0x14A0CFC")]
		public static string GetLatestPatches()
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x14A0DE8", Offset = "0x14A0DE8", VA = "0x14A0DE8")]
		public static void RestartApp()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x14A0F0C", Offset = "0x14A0F0C", VA = "0x14A0F0C")]
		internal static void SetLaunchFlag(bool value)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x14A1008", Offset = "0x14A1008", VA = "0x14A1008")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x897098", Offset = "0x897098")]
		private static void OnRuntimeMethodLoad()
		{
		}
	}
}
namespace AmazingEngine
{
	[Token(Token = "0x2000023")]
	public class BACH
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SWIGTYPE_p_f_p_void_p_q_const__char_long_long__bool BACH_LocalFileResourceFinderReleaseCallback;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SWIGTYPE_p_f_p_void_p_q_const__char_p_long_long__p_char BACH_LocalFileResourceFinderCallback;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1492AD0", Offset = "0x1492AD0", VA = "0x1492AD0")]
		public static bool BACH_BlitImageBuffer(SWIGTYPE_p_BACH_AlgorithmInput _in, SWIGTYPE_p_BACH_AlgorithmInput _out)
		{
			return default(bool);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x14908D8", Offset = "0x14908D8", VA = "0x14908D8")]
		public static double BACH_GetSensorTimestamp()
		{
			return default(double);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x148F5C0", Offset = "0x148F5C0", VA = "0x148F5C0")]
		public static SWIGTYPE_p_BACH_AlgorithmIntParamMap BACH_NewAlgorithmIntParamMap()
		{
			return null;
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x148F6E4", Offset = "0x148F6E4", VA = "0x148F6E4")]
		public static void BACH_DeleteAlgorithmIntParamMap(SWIGTYPE_p_BACH_AlgorithmIntParamMap params_)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x149049C", Offset = "0x149049C", VA = "0x149049C")]
		public static void BACH_AlgorithmIntParamMapSet(SWIGTYPE_p_BACH_AlgorithmIntParamMap params_, string key, long value)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1492154", Offset = "0x1492154", VA = "0x1492154")]
		public static SWIGTYPE_p_BACH_AlgorithmFloatParamMap BACH_NewAlgorithmFloatParamMap()
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1492318", Offset = "0x1492318", VA = "0x1492318")]
		public static void BACH_DeleteAlgorithmFloatParamMap(SWIGTYPE_p_BACH_AlgorithmFloatParamMap params_)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x14921F0", Offset = "0x14921F0", VA = "0x14921F0")]
		public static void BACH_AlgorithmFloatParamMapSet(SWIGTYPE_p_BACH_AlgorithmFloatParamMap params_, string key, float value)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1490C00", Offset = "0x1490C00", VA = "0x1490C00")]
		public static void BACH_DeleteAlgorithmInput(SWIGTYPE_p_BACH_AlgorithmInput input)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1490A70", Offset = "0x1490A70", VA = "0x1490A70")]
		public static SWIGTYPE_p_BACH_AlgorithmInput BACH_NewImageBuffer(int width, int height, SWIGTYPE_p_unsigned_char data, BACH_AEPixelFormat format, BACH_AERotateMode rotateMode, BACH_AEFlipMode flipMode, double timestamp)
		{
			return null;
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x148EE20", Offset = "0x148EE20", VA = "0x148EE20")]
		public static long BACH_NewAlgorithmSystem()
		{
			return default(long);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x148F8A4", Offset = "0x148F8A4", VA = "0x148F8A4")]
		public static void BACH_DeleteAlgorithmSystem(long handle)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x148F538", Offset = "0x148F538", VA = "0x148F538")]
		public static BACH_ErrorCode BACH_AlgorithmSystemInit(long handle, BACH_InitConfig config)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x148F75C", Offset = "0x148F75C", VA = "0x148F75C")]
		public static BACH_ErrorCode BACH_AlgorithmSystemInitGraph(long handle, string config)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1490B78", Offset = "0x1490B78", VA = "0x1490B78")]
		public static BACH_ErrorCode BACH_AlgorithmSystemExcute(long handle, SWIGTYPE_p_BACH_AlgorithmInput input)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1491824", Offset = "0x1491824", VA = "0x1491824")]
		public static IntPtr BACH_AlgorithmSystemGetResultByType(long handle, BACH_AlgorithmType type)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1492288", Offset = "0x1492288", VA = "0x1492288")]
		public static BACH_ErrorCode BACH_AlgorithmSystemSetFloatParamsByType(long handle, BACH_AlgorithmType type, SWIGTYPE_p_BACH_AlgorithmFloatParamMap params_)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x148F65C", Offset = "0x148F65C", VA = "0x148F65C")]
		public static BACH_ErrorCode BACH_AlgorithmSystemSetIntParamsCommon(long handle, SWIGTYPE_p_BACH_AlgorithmIntParamMap params_)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1491898", Offset = "0x1491898", VA = "0x1491898")]
		public static uint BACH_FaceBufferGetFaceBaseInfoSize(IntPtr buffer)
		{
			return default(uint);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x149196C", Offset = "0x149196C", VA = "0x149196C")]
		public static BACH_ErrorCode BACH_FaceBufferGetFaceBaseInfo(IntPtr buffer, int index, BACH_Face106 info)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x14931E0", Offset = "0x14931E0", VA = "0x14931E0")]
		public static BACH_ErrorCode BACH_SlamBufferGetSlamInfo(IntPtr buffer, BACH_SlamResult info)
		{
			return default(BACH_ErrorCode);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x148F1A0", Offset = "0x148F1A0", VA = "0x148F1A0")]
		public static void BACH_CreateLocalFileResourceFinder(IntPtr userData, string path)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x148F840", Offset = "0x148F840", VA = "0x148F840")]
		public static void BACH_ReleaseLocalFileResourceFinder(IntPtr userData)
		{
		}
	}
	[Token(Token = "0x2000024")]
	internal class BACHPINVOKE
	{
		[Token(Token = "0x2000025")]
		internal class MonoPInvokeCallbackAttribute : Attribute
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x14969E8", Offset = "0x14969E8", VA = "0x14969E8")]
			public MonoPInvokeCallbackAttribute()
			{
			}
		}

		[Token(Token = "0x2000026")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x2000027")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x2000028")]
			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static ExceptionDelegate applicationDelegate;

			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ExceptionDelegate arithmeticDelegate;

			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static ExceptionDelegate divideByZeroDelegate;

			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static ExceptionDelegate indexOutOfRangeDelegate;

			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static ExceptionDelegate invalidCastDelegate;

			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static ExceptionDelegate invalidOperationDelegate;

			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static ExceptionDelegate ioDelegate;

			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static ExceptionDelegate nullReferenceDelegate;

			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static ExceptionDelegate outOfMemoryDelegate;

			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static ExceptionDelegate overflowDelegate;

			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static ExceptionDelegate systemDelegate;

			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static ExceptionArgumentDelegate argumentDelegate;

			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static ExceptionArgumentDelegate argumentNullDelegate;

			[Token(Token = "0x4000058")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1497308", Offset = "0x1497308", VA = "0x1497308")]
			public static extern void SWIGRegisterExceptionCallbacks_BACH(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x149747C", Offset = "0x149747C", VA = "0x149747C")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_BACH(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x14969F0", Offset = "0x14969F0", VA = "0x14969F0")]
			[MonoPInvokeCallback]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1496A8C", Offset = "0x1496A8C", VA = "0x1496A8C")]
			[MonoPInvokeCallback]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1496B28", Offset = "0x1496B28", VA = "0x1496B28")]
			[MonoPInvokeCallback]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1496BC4", Offset = "0x1496BC4", VA = "0x1496BC4")]
			[MonoPInvokeCallback]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1496C60", Offset = "0x1496C60", VA = "0x1496C60")]
			[MonoPInvokeCallback]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1496CFC", Offset = "0x1496CFC", VA = "0x1496CFC")]
			[MonoPInvokeCallback]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1496D98", Offset = "0x1496D98", VA = "0x1496D98")]
			[MonoPInvokeCallback]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1496E34", Offset = "0x1496E34", VA = "0x1496E34")]
			[MonoPInvokeCallback]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1496ED0", Offset = "0x1496ED0", VA = "0x1496ED0")]
			[MonoPInvokeCallback]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1496F6C", Offset = "0x1496F6C", VA = "0x1496F6C")]
			[MonoPInvokeCallback]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1497008", Offset = "0x1497008", VA = "0x1497008")]
			[MonoPInvokeCallback]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x14970A4", Offset = "0x14970A4", VA = "0x14970A4")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1497148", Offset = "0x1497148", VA = "0x1497148")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1497228", Offset = "0x1497228", VA = "0x1497228")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1497888", Offset = "0x1497888", VA = "0x1497888")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1495CE8", Offset = "0x1495CE8", VA = "0x1495CE8")]
			public SWIGExceptionHelper()
			{
			}
		}

		[Token(Token = "0x2000029")]
		public class SWIGPendingException
		{
			[Token(Token = "0x4000059")]
			[ThreadStatic]
			private static Exception pendingException;

			[Token(Token = "0x400005A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int numExceptionsPending;

			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static object exceptionsLock;

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x14976A4", Offset = "0x14976A4", VA = "0x14976A4")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1497534", Offset = "0x1497534", VA = "0x1497534")]
			public static Exception Retrieve()
			{
				return null;
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x14984F0", Offset = "0x14984F0", VA = "0x14984F0")]
			static SWIGPendingException()
			{
			}
		}

		[Token(Token = "0x200002A")]
		protected class SWIGStringHelper
		{
			[Token(Token = "0x200002B")]
			public delegate string SWIGStringDelegate(string message);

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1498564", Offset = "0x1498564", VA = "0x1498564")]
			public static extern void SWIGRegisterStringCallback_BACH(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x1498560", Offset = "0x1498560", VA = "0x1498560")]
			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return null;
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x14985E8", Offset = "0x14985E8", VA = "0x14985E8")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x6000100")]
			[Address(RVA = "0x1495CF0", Offset = "0x1495CF0", VA = "0x1495CF0")]
			public SWIGStringHelper()
			{
			}
		}

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static SWIGExceptionHelper swigExceptionHelper;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static SWIGStringHelper swigStringHelper;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1495C48", Offset = "0x1495C48", VA = "0x1495C48")]
		static BACHPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1495CF8", Offset = "0x1495CF8", VA = "0x1495CF8")]
		public static extern void delete_BACH_FloatArray(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1495D78", Offset = "0x1495D78", VA = "0x1495D78")]
		public static extern float BACH_FloatArray_getitem(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1495E08", Offset = "0x1495E08", VA = "0x1495E08")]
		public static extern IntPtr BACH_FloatArray_frompointer(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1494910", Offset = "0x1494910", VA = "0x1494910")]
		public static extern bool BACH_BlitImageBuffer(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x14949A8", Offset = "0x14949A8", VA = "0x14949A8")]
		public static extern double BACH_GetSensorTimestamp();

		[PreserveSig]
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1494A18", Offset = "0x1494A18", VA = "0x1494A18")]
		public static extern IntPtr BACH_NewAlgorithmIntParamMap();

		[PreserveSig]
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1494B5C", Offset = "0x1494B5C", VA = "0x1494B5C")]
		public static extern void BACH_DeleteAlgorithmIntParamMap(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1494BDC", Offset = "0x1494BDC", VA = "0x1494BDC")]
		public static extern void BACH_AlgorithmIntParamMapSet(HandleRef jarg1, string jarg2, long jarg3);

		[PreserveSig]
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1494C88", Offset = "0x1494C88", VA = "0x1494C88")]
		public static extern IntPtr BACH_NewAlgorithmFloatParamMap();

		[PreserveSig]
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1494DCC", Offset = "0x1494DCC", VA = "0x1494DCC")]
		public static extern void BACH_DeleteAlgorithmFloatParamMap(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1494E4C", Offset = "0x1494E4C", VA = "0x1494E4C")]
		public static extern void BACH_AlgorithmFloatParamMapSet(HandleRef jarg1, string jarg2, float jarg3);

		[PreserveSig]
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1494F00", Offset = "0x1494F00", VA = "0x1494F00")]
		public static extern void BACH_DeleteAlgorithmInput(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1494FF4", Offset = "0x1494FF4", VA = "0x1494FF4")]
		public static extern IntPtr BACH_NewImageBuffer(int jarg1, int jarg2, HandleRef jarg3, int jarg4, int jarg5, int jarg6, double jarg7);

		[PreserveSig]
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1495E88", Offset = "0x1495E88", VA = "0x1495E88")]
		public static extern void BACH_ResourceFinder_userData_set(HandleRef jarg1, IntPtr jarg2);

		[PreserveSig]
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1495F18", Offset = "0x1495F18", VA = "0x1495F18")]
		public static extern void BACH_ResourceFinder_findResource_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1495FA8", Offset = "0x1495FA8", VA = "0x1495FA8")]
		public static extern void BACH_ResourceFinder_releaseResource_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1496038", Offset = "0x1496038", VA = "0x1496038")]
		public static extern IntPtr new_BACH_ResourceFinder();

		[PreserveSig]
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x14960AC", Offset = "0x14960AC", VA = "0x14960AC")]
		public static extern void delete_BACH_ResourceFinder(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x149612C", Offset = "0x149612C", VA = "0x149612C")]
		public static extern void BACH_InitConfig_finder_set(HandleRef jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x14961BC", Offset = "0x14961BC", VA = "0x14961BC")]
		public static extern void BACH_InitConfig_applicationName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1496260", Offset = "0x1496260", VA = "0x1496260")]
		public static extern void BACH_InitConfig_deviceName_set(HandleRef jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1496304", Offset = "0x1496304", VA = "0x1496304")]
		public static extern IntPtr new_BACH_InitConfig();

		[PreserveSig]
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1496378", Offset = "0x1496378", VA = "0x1496378")]
		public static extern void delete_BACH_InitConfig(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1495120", Offset = "0x1495120", VA = "0x1495120")]
		public static extern long BACH_NewAlgorithmSystem();

		[PreserveSig]
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1495194", Offset = "0x1495194", VA = "0x1495194")]
		public static extern void BACH_DeleteAlgorithmSystem(long jarg1);

		[PreserveSig]
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1495288", Offset = "0x1495288", VA = "0x1495288")]
		public static extern int BACH_AlgorithmSystemInit(long jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1495318", Offset = "0x1495318", VA = "0x1495318")]
		public static extern int BACH_AlgorithmSystemInitGraph(long jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x14953C4", Offset = "0x14953C4", VA = "0x14953C4")]
		public static extern int BACH_AlgorithmSystemExcute(long jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1495454", Offset = "0x1495454", VA = "0x1495454")]
		public static extern IntPtr BACH_AlgorithmSystemGetResultByType(long jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x14954E4", Offset = "0x14954E4", VA = "0x14954E4")]
		public static extern int BACH_AlgorithmSystemSetFloatParamsByType(long jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x149557C", Offset = "0x149557C", VA = "0x149557C")]
		public static extern int BACH_AlgorithmSystemSetIntParamsCommon(long jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x149560C", Offset = "0x149560C", VA = "0x149560C")]
		public static extern uint BACH_FaceBufferGetFaceBaseInfoSize(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1495700", Offset = "0x1495700", VA = "0x1495700")]
		public static extern int BACH_FaceBufferGetFaceBaseInfo(IntPtr jarg1, int jarg2, HandleRef jarg3);

		[PreserveSig]
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x149580C", Offset = "0x149580C", VA = "0x149580C")]
		public static extern int BACH_SlamBufferGetSlamInfo(IntPtr jarg1, HandleRef jarg2);

		[PreserveSig]
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x14963F8", Offset = "0x14963F8", VA = "0x14963F8")]
		public static extern IntPtr BACH_Face106_rect_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1496478", Offset = "0x1496478", VA = "0x1496478")]
		public static extern float BACH_Face106_yaw_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x14964F8", Offset = "0x14964F8", VA = "0x14964F8")]
		public static extern float BACH_Face106_pitch_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1496578", Offset = "0x1496578", VA = "0x1496578")]
		public static extern float BACH_Face106_roll_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x14965F8", Offset = "0x14965F8", VA = "0x14965F8")]
		public static extern IntPtr new_BACH_Face106();

		[PreserveSig]
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x149666C", Offset = "0x149666C", VA = "0x149666C")]
		public static extern void delete_BACH_Face106(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x14966EC", Offset = "0x14966EC", VA = "0x14966EC")]
		public static extern bool BACH_SlamResult_projDirty_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1496774", Offset = "0x1496774", VA = "0x1496774")]
		public static extern IntPtr BACH_SlamResult_projection_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x14967F4", Offset = "0x14967F4", VA = "0x14967F4")]
		public static extern IntPtr BACH_SlamResult_view_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1496874", Offset = "0x1496874", VA = "0x1496874")]
		public static extern IntPtr BACH_SlamResult_planeTransform_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x14968F4", Offset = "0x14968F4", VA = "0x14968F4")]
		public static extern IntPtr new_BACH_SlamResult();

		[PreserveSig]
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1496968", Offset = "0x1496968", VA = "0x1496968")]
		public static extern void delete_BACH_SlamResult(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x149589C", Offset = "0x149589C", VA = "0x149589C")]
		public static extern void BACH_CreateLocalFileResourceFinder(IntPtr jarg1, string jarg2);

		[PreserveSig]
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1495940", Offset = "0x1495940", VA = "0x1495940")]
		public static extern void BACH_ReleaseLocalFileResourceFinder(IntPtr jarg1);

		[PreserveSig]
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1495AA8", Offset = "0x1495AA8", VA = "0x1495AA8")]
		public static extern IntPtr BACH_LocalFileResourceFinderReleaseCallback_get();

		[PreserveSig]
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1495B78", Offset = "0x1495B78", VA = "0x1495B78")]
		public static extern IntPtr BACH_LocalFileResourceFinderCallback_get();
	}
	[Token(Token = "0x200002C")]
	public enum BACH_AEFlipMode
	{
		[Token(Token = "0x400005E")]
		BACH_FLIP_NONE,
		[Token(Token = "0x400005F")]
		BACH_FLIP_VERTICAL,
		[Token(Token = "0x4000060")]
		BACH_FLIP_HORIZONAL,
		[Token(Token = "0x4000061")]
		BACH_FLIP_BOTH
	}
	[Token(Token = "0x200002D")]
	public enum BACH_AEPixelFormat
	{
		[Token(Token = "0x4000063")]
		BACH_INVALID = -1,
		[Token(Token = "0x4000064")]
		BACH_RGBA8UNORM,
		[Token(Token = "0x4000065")]
		BACH_BGRA8UNORM,
		[Token(Token = "0x4000066")]
		BACH_BGR8UNORM,
		[Token(Token = "0x4000067")]
		BACH_RGB8UNORM,
		[Token(Token = "0x4000068")]
		BACH_GRAY8,
		[Token(Token = "0x4000069")]
		BACH_YUV420P,
		[Token(Token = "0x400006A")]
		BACH_NV12,
		[Token(Token = "0x400006B")]
		BACH_NV21
	}
	[Token(Token = "0x200002E")]
	public enum BACH_AERotateMode
	{
		[Token(Token = "0x400006D")]
		BACH_ROTATE_CW_0,
		[Token(Token = "0x400006E")]
		BACH_ROTATE_CW_90,
		[Token(Token = "0x400006F")]
		BACH_ROTATE_CW_180,
		[Token(Token = "0x4000070")]
		BACH_ROTATE_CW_270
	}
	[Token(Token = "0x200002F")]
	public enum BACH_AlgorithmType
	{
		[Token(Token = "0x4000072")]
		BACH_TYPE_INVALID = -1,
		[Token(Token = "0x4000073")]
		BACH_RAW_IMAGE_PRODUCER,
		[Token(Token = "0x4000074")]
		BACH_EXT_TEXTURE_PRODUCER,
		[Token(Token = "0x4000075")]
		BACH_ARRAY_BUFFER_PRODUCER,
		[Token(Token = "0x4000076")]
		BACH_TEXTURE_BLIT,
		[Token(Token = "0x4000077")]
		BACH_FACE,
		[Token(Token = "0x4000078")]
		BACH_FAKE_FACE,
		[Token(Token = "0x4000079")]
		BACH_HAND,
		[Token(Token = "0x400007A")]
		BACH_SKELETON,
		[Token(Token = "0x400007B")]
		BACH_FACE_VERIFY,
		[Token(Token = "0x400007C")]
		BACH_FACE_ATTR,
		[Token(Token = "0x400007D")]
		BACH_FACE_CLUSTING,
		[Token(Token = "0x400007E")]
		BACH_HAIR,
		[Token(Token = "0x400007F")]
		BACH_MATTING,
		[Token(Token = "0x4000080")]
		BACH_SLAM_NAIL,
		[Token(Token = "0x4000081")]
		BACH_CAT_FACE,
		[Token(Token = "0x4000082")]
		BACH_MUG,
		[Token(Token = "0x4000083")]
		BACH_FACE_FITTING,
		[Token(Token = "0x4000084")]
		BACH_AVATAR_DRIVE,
		[Token(Token = "0x4000085")]
		BACH_OBJECT_DETECT,
		[Token(Token = "0x4000086")]
		BACH_ARSCAN,
		[Token(Token = "0x4000087")]
		BACH_CLOTHES_SEG,
		[Token(Token = "0x4000088")]
		BACH_CAR_SEG,
		[Token(Token = "0x4000089")]
		BACH_HEAD_SEG,
		[Token(Token = "0x400008A")]
		BACH_ENIGMA,
		[Token(Token = "0x400008B")]
		BACH_FACE_PART_BEAUTY,
		[Token(Token = "0x400008C")]
		BACH_SCENE_RECOGNITION,
		[Token(Token = "0x400008D")]
		BACH_FACE_GAN,
		[Token(Token = "0x400008E")]
		BACH_OLD_GAN,
		[Token(Token = "0x400008F")]
		BACH_TRACKING_AR,
		[Token(Token = "0x4000090")]
		BACH_SIMILARITY,
		[Token(Token = "0x4000091")]
		BACH_AFTER_EFFECT,
		[Token(Token = "0x4000092")]
		BACH_AUTO_REFRAME,
		[Token(Token = "0x4000093")]
		BACH_SCENE_RECOG_V2,
		[Token(Token = "0x4000094")]
		BACH_PORN_CLS,
		[Token(Token = "0x4000095")]
		BACH_VIDEO_MOMENT,
		[Token(Token = "0x4000096")]
		BACH_VIDEO_TEMP_REC,
		[Token(Token = "0x4000097")]
		BACH_VIDEO_CLS,
		[Token(Token = "0x4000098")]
		BACH_VIDEO_MATTING,
		[Token(Token = "0x4000099")]
		BACH_BLING,
		[Token(Token = "0x400009A")]
		BACH_YOUNG_GAN,
		[Token(Token = "0x400009B")]
		BACH_LAUGH_GAN,
		[Token(Token = "0x400009C")]
		BACH_SKELETON_POSE_3D,
		[Token(Token = "0x400009D")]
		BACH_UPPERBODY3D,
		[Token(Token = "0x400009E")]
		BACH_AVATAR_3D,
		[Token(Token = "0x400009F")]
		BACH_GROUND_SEG,
		[Token(Token = "0x40000A0")]
		BACH_FOOT,
		[Token(Token = "0x40000A1")]
		BACH_EXPRESSION_DETECT,
		[Token(Token = "0x40000A2")]
		BACH_BUILDING_SEG,
		[Token(Token = "0x40000A3")]
		BACH_BEAUTY_GAN,
		[Token(Token = "0x40000A4")]
		BACH_SKIN_SEG,
		[Token(Token = "0x40000A5")]
		BACH_SWAPPERME,
		[Token(Token = "0x40000A6")]
		BACH_FACE_LIGHT,
		[Token(Token = "0x40000A7")]
		BACH_IDREAM,
		[Token(Token = "0x40000A8")]
		BACH_FCEALIGN,
		[Token(Token = "0x40000A9")]
		BACH_CVTCOLOR,
		[Token(Token = "0x40000AA")]
		BACH_RESIZE,
		[Token(Token = "0x40000AB")]
		BACH_DATACONVERT,
		[Token(Token = "0x40000AC")]
		BACH_BYTENN,
		[Token(Token = "0x40000AD")]
		BACH_SCENE_RECOG_V3,
		[Token(Token = "0x40000AE")]
		BACH_DEPTH,
		[Token(Token = "0x40000AF")]
		BACH_SALIENCY_SEG,
		[Token(Token = "0x40000B0")]
		BACH_DYNAMIC_GESTURE,
		[Token(Token = "0x40000B1")]
		BACH_HEAD_FITTING,
		[Token(Token = "0x40000B2")]
		BACH_DEEP_INPAINT,
		[Token(Token = "0x40000B3")]
		BACH_SKY_SEG,
		[Token(Token = "0x40000B4")]
		BACH_HUMAN_PARSING,
		[Token(Token = "0x40000B5")]
		BACH_PICTURE_AR,
		[Token(Token = "0x40000B6")]
		BACH_EAR_SEG,
		[Token(Token = "0x40000B7")]
		BACH_CLOTH_CLASS,
		[Token(Token = "0x40000B8")]
		BACH_SCENE_NORMAL,
		[Token(Token = "0x40000B9")]
		BACH_FOOD_COMICS,
		[Token(Token = "0x40000BA")]
		BACH_PET_MATTING,
		[Token(Token = "0x40000BB")]
		BACH_ACTION_DETECT,
		[Token(Token = "0x40000BC")]
		BACH_GAZE_ESTIMATION,
		[Token(Token = "0x40000BD")]
		BACH_TEETH,
		[Token(Token = "0x40000BE")]
		BACH_NAIL,
		[Token(Token = "0x40000BF")]
		BACH_NODE_HUB_IMAGE_TRANSFORM,
		[Token(Token = "0x40000C0")]
		BACH_NODE_HUB_FACE_SELECT,
		[Token(Token = "0x40000C1")]
		BACH_NODE_HUB_FACE_ALIGN,
		[Token(Token = "0x40000C2")]
		BACH_NODE_HUB_HAND_ALIGN,
		[Token(Token = "0x40000C3")]
		BACH_NODE_HUB_INFERENCE,
		[Token(Token = "0x40000C4")]
		BACH_KIRA,
		[Token(Token = "0x40000C5")]
		BACH_HAND_TV,
		[Token(Token = "0x40000C6")]
		BACH_LICENSE_PLATE_DETECT,
		[Token(Token = "0x40000C7")]
		BACH_MEMOJI_MATCH,
		[Token(Token = "0x40000C8")]
		BACH_HDR_NET,
		[Token(Token = "0x40000C9")]
		BACH_FACE_MASK,
		[Token(Token = "0x40000CA")]
		BACH_MV_TEMP_REC,
		[Token(Token = "0x40000CB")]
		BACH_BLOCKGAN,
		[Token(Token = "0x40000CC")]
		BACH_JOINTS1,
		[Token(Token = "0x40000CD")]
		BACH_JOINTS2,
		[Token(Token = "0x40000CE")]
		BACH_FIND_CONTOUR,
		[Token(Token = "0x40000CF")]
		BACH_RGBD2MESH,
		[Token(Token = "0x40000D0")]
		BACH_OIL_PAINT,
		[Token(Token = "0x40000D1")]
		BACH_BIG_GAN,
		[Token(Token = "0x40000D2")]
		BACH_FACE_PET_DETECT,
		[Token(Token = "0x40000D3")]
		BACH_GENDER_GAN,
		[Token(Token = "0x40000D4")]
		BACH_FEMALE_GAN,
		[Token(Token = "0x40000D5")]
		BACH_MANGA,
		[Token(Token = "0x40000D6")]
		BACH_VIDEO_SR,
		[Token(Token = "0x40000D7")]
		BACH_OBJECT_DETECTION2,
		[Token(Token = "0x40000D8")]
		BACH_AUDIO_PRODUCER,
		[Token(Token = "0x40000D9")]
		BACH_AUDIO_AVATAR,
		[Token(Token = "0x40000DA")]
		BACH_APOLLOFACE3D,
		[Token(Token = "0x40000DB")]
		BACH_AVACAP,
		[Token(Token = "0x40000DC")]
		BACH_SCENE_LIGHT,
		[Token(Token = "0x40000DD")]
		BACH_CAR_SERIES,
		[Token(Token = "0x40000DE")]
		BACH_ACTION_RECOGNITION,
		[Token(Token = "0x40000DF")]
		BACH_FACE_SMOOTH_CPU,
		[Token(Token = "0x40000E0")]
		BACH_INDOOR_SEG,
		[Token(Token = "0x40000E1")]
		BACH_BUILDING_NORMAL,
		[Token(Token = "0x40000E2")]
		BACH_FACE_NEW_LANDMARK,
		[Token(Token = "0x40000E3")]
		BACH_INTERACTIVE_MATTING,
		[Token(Token = "0x40000E4")]
		BACH_FACE_BEAUTIFY,
		[Token(Token = "0x40000E5")]
		BACH_SKIN_UNIFIED,
		[Token(Token = "0x40000E6")]
		BACH_HAND_OBJECT_SEG_TRACK,
		[Token(Token = "0x40000E7")]
		BACH_NH_INFERENCE,
		[Token(Token = "0x40000E8")]
		BACH_NH_MODEL_PREVIEW,
		[Token(Token = "0x40000E9")]
		BACH_NH_IMAGE_TRANSFORM,
		[Token(Token = "0x40000EA")]
		BACH_NH_CONVERT_TO_TENSOR,
		[Token(Token = "0x40000EB")]
		BACH_NH_STYLE_TRANSFER_POST_PROCESS,
		[Token(Token = "0x40000EC")]
		BACH_NH_CLASSIFICATION,
		[Token(Token = "0x40000ED")]
		BACH_NH_FACE_ALIGN,
		[Token(Token = "0x40000EE")]
		BACH_NH_HAND_ALIGN,
		[Token(Token = "0x40000EF")]
		BACH_NH_FACE_SELECT,
		[Token(Token = "0x40000F0")]
		BACH_NAVI_AVATAR_DRIVE,
		[Token(Token = "0x40000F1")]
		BACH_OBJECT_TRACKING,
		[Token(Token = "0x40000F2")]
		BACH_HAIR_FLOW,
		[Token(Token = "0x40000F3")]
		BACH_HAVATAR,
		[Token(Token = "0x40000F4")]
		BACH_WATCH_TRYON,
		[Token(Token = "0x40000F5")]
		BACH_RELATION_RECOG,
		[Token(Token = "0x40000F6")]
		BACH_FREID,
		[Token(Token = "0x40000F7")]
		BACH_FACE_REENACT_ANIMATION,
		[Token(Token = "0x40000F8")]
		BACH_FACE_REENACT_KEYPOINT_DETECTION,
		[Token(Token = "0x40000F9")]
		BACH_AVATAR3D_FUSION,
		[Token(Token = "0x40000FA")]
		BACH_FOREHEAD_SEG,
		[Token(Token = "0x40000FB")]
		BACH_CONTENT_RECOMMEND,
		[Token(Token = "0x40000FC")]
		BACH_SWAP_LIVE,
		[Token(Token = "0x40000FD")]
		BACH_GPU_RENDER,
		[Token(Token = "0x40000FE")]
		BACH_COLOR_MAPPING,
		[Token(Token = "0x40000FF")]
		BACH_CLOTH_GAN,
		[Token(Token = "0x4000100")]
		BACH_F_PARSING,
		[Token(Token = "0x4000101")]
		BACH_EYE_FITTING,
		[Token(Token = "0x4000102")]
		BACH_SENSOR
	}
	[Token(Token = "0x2000030")]
	public enum BACH_ErrorCode
	{
		[Token(Token = "0x4000104")]
		BACH_NO_ERROR,
		[Token(Token = "0x4000105")]
		BACH_INVALID_RES_FINDER,
		[Token(Token = "0x4000106")]
		BACH_NOT_INIT,
		[Token(Token = "0x4000107")]
		BACH_INVALID_CONFIG,
		[Token(Token = "0x4000108")]
		BACH_INVALID_GRAPH,
		[Token(Token = "0x4000109")]
		BACH_INVALID_MODEL,
		[Token(Token = "0x400010A")]
		BACH_INVALID_TYPE,
		[Token(Token = "0x400010B")]
		BACH_INVALID_NODE,
		[Token(Token = "0x400010C")]
		BACH_INVALID_FORMAT,
		[Token(Token = "0x400010D")]
		BACH_INTERNAL_ERROR
	}
	[Token(Token = "0x2000031")]
	public class BACH_Face106 : IDisposable
	{
		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000005")]
		public SWIGTYPE_p_float rect
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x14919FC", Offset = "0x14919FC", VA = "0x14919FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public float yaw
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x1491BCC", Offset = "0x1491BCC", VA = "0x1491BCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000007")]
		public float pitch
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1491C38", Offset = "0x1491C38", VA = "0x1491C38")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000008")]
		public float roll
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1491B60", Offset = "0x1491B60", VA = "0x1491B60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1498A64", Offset = "0x1498A64", VA = "0x1498A64")]
		internal BACH_Face106(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x149568C", Offset = "0x149568C", VA = "0x149568C")]
		internal static HandleRef getCPtr(BACH_Face106 obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1498AD4", Offset = "0x1498AD4", VA = "0x1498AD4", Slot = "1")]
		~BACH_Face106()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1498B48", Offset = "0x1498B48", VA = "0x1498B48", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1498BC4", Offset = "0x1498BC4", VA = "0x1498BC4", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x14918FC", Offset = "0x14918FC", VA = "0x14918FC")]
		public BACH_Face106()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class BACH_FloatArray : IDisposable
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1498D50", Offset = "0x1498D50", VA = "0x1498D50")]
		internal BACH_FloatArray(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1498DC0", Offset = "0x1498DC0", VA = "0x1498DC0", Slot = "1")]
		~BACH_FloatArray()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1498E34", Offset = "0x1498E34", VA = "0x1498E34", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1498EB0", Offset = "0x1498EB0", VA = "0x1498EB0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1491CA4", Offset = "0x1491CA4", VA = "0x1491CA4")]
		public float getitem(int index)
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1491AA8", Offset = "0x1491AA8", VA = "0x1491AA8")]
		public static BACH_FloatArray frompointer(SWIGTYPE_p_float t)
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	public class BACH_InitConfig : IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000009")]
		public BACH_ResourceFinder finder
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x148F4A8", Offset = "0x148F4A8", VA = "0x148F4A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public string applicationName
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x148F3B0", Offset = "0x148F3B0", VA = "0x148F3B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public string deviceName
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x148F42C", Offset = "0x148F42C", VA = "0x148F42C")]
			set
			{
			}
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1499054", Offset = "0x1499054", VA = "0x1499054")]
		internal BACH_InitConfig(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1495214", Offset = "0x1495214", VA = "0x1495214")]
		internal static HandleRef getCPtr(BACH_InitConfig obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x14990C4", Offset = "0x14990C4", VA = "0x14990C4", Slot = "1")]
		~BACH_InitConfig()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1499138", Offset = "0x1499138", VA = "0x1499138", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x14991B4", Offset = "0x14991B4", VA = "0x14991B4", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x148F0C0", Offset = "0x148F0C0", VA = "0x148F0C0")]
		public BACH_InitConfig()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class BACH_ResourceFinder : IDisposable
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700000C")]
		public IntPtr userData
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x148F214", Offset = "0x148F214", VA = "0x148F214")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public SWIGTYPE_p_f_p_void_p_q_const__char_p_long_long__p_char findResource
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x148F290", Offset = "0x148F290", VA = "0x148F290")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public SWIGTYPE_p_f_p_void_p_q_const__char_long_long__bool releaseResource
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x148F320", Offset = "0x148F320", VA = "0x148F320")]
			set
			{
			}
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1499358", Offset = "0x1499358", VA = "0x1499358")]
		internal BACH_ResourceFinder(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x14992E4", Offset = "0x14992E4", VA = "0x14992E4")]
		internal static HandleRef getCPtr(BACH_ResourceFinder obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x14993C8", Offset = "0x14993C8", VA = "0x14993C8", Slot = "1")]
		~BACH_ResourceFinder()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x149943C", Offset = "0x149943C", VA = "0x149943C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x14994B8", Offset = "0x14994B8", VA = "0x14994B8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x148F130", Offset = "0x148F130", VA = "0x148F130")]
		public BACH_ResourceFinder()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class BACH_SlamResult : IDisposable
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x1700000F")]
		public bool projDirty
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1493268", Offset = "0x1493268", VA = "0x1493268")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		public SWIGTYPE_p_float projection
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1493380", Offset = "0x1493380", VA = "0x1493380")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public SWIGTYPE_p_float view
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x14932D4", Offset = "0x14932D4", VA = "0x14932D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public SWIGTYPE_p_float planeTransform
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x149342C", Offset = "0x149342C", VA = "0x149342C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x14996D0", Offset = "0x14996D0", VA = "0x14996D0")]
		internal BACH_SlamResult(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1495798", Offset = "0x1495798", VA = "0x1495798")]
		internal static HandleRef getCPtr(BACH_SlamResult obj)
		{
			return default(HandleRef);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1499740", Offset = "0x1499740", VA = "0x1499740", Slot = "1")]
		~BACH_SlamResult()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x14997B4", Offset = "0x14997B4", VA = "0x14997B4", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1499830", Offset = "0x1499830", VA = "0x1499830", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1493170", Offset = "0x1493170", VA = "0x1493170")]
		public BACH_SlamResult()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class SWIGTYPE_p_BACH_AlgorithmFloatParamMap
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1494CFC", Offset = "0x1494CFC", VA = "0x1494CFC")]
		internal SWIGTYPE_p_BACH_AlgorithmFloatParamMap(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1494D58", Offset = "0x1494D58", VA = "0x1494D58")]
		internal static HandleRef getCPtr(SWIGTYPE_p_BACH_AlgorithmFloatParamMap obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x2000037")]
	public class SWIGTYPE_p_BACH_AlgorithmInput
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x14950C4", Offset = "0x14950C4", VA = "0x14950C4")]
		internal SWIGTYPE_p_BACH_AlgorithmInput(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x149489C", Offset = "0x149489C", VA = "0x149489C")]
		internal static HandleRef getCPtr(SWIGTYPE_p_BACH_AlgorithmInput obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x2000038")]
	public class SWIGTYPE_p_BACH_AlgorithmIntParamMap
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1494A8C", Offset = "0x1494A8C", VA = "0x1494A8C")]
		internal SWIGTYPE_p_BACH_AlgorithmIntParamMap(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1494AE8", Offset = "0x1494AE8", VA = "0x1494AE8")]
		internal static HandleRef getCPtr(SWIGTYPE_p_BACH_AlgorithmIntParamMap obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x2000039")]
	public class SWIGTYPE_p_f_p_void_p_q_const__char_long_long__bool
	{
		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1495B1C", Offset = "0x1495B1C", VA = "0x1495B1C")]
		internal SWIGTYPE_p_f_p_void_p_q_const__char_long_long__bool(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x149965C", Offset = "0x149965C", VA = "0x149965C")]
		internal static HandleRef getCPtr(SWIGTYPE_p_f_p_void_p_q_const__char_long_long__bool obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x200003A")]
	public class SWIGTYPE_p_f_p_void_p_q_const__char_p_long_long__p_char
	{
		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1495BEC", Offset = "0x1495BEC", VA = "0x1495BEC")]
		internal SWIGTYPE_p_f_p_void_p_q_const__char_p_long_long__p_char(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x14995E8", Offset = "0x14995E8", VA = "0x14995E8")]
		internal static HandleRef getCPtr(SWIGTYPE_p_f_p_void_p_q_const__char_p_long_long__p_char obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x200003B")]
	public class SWIGTYPE_p_float
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1498CF4", Offset = "0x1498CF4", VA = "0x1498CF4")]
		internal SWIGTYPE_p_float(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1498FE0", Offset = "0x1498FE0", VA = "0x1498FE0")]
		internal static HandleRef getCPtr(SWIGTYPE_p_float obj)
		{
			return default(HandleRef);
		}
	}
	[Token(Token = "0x200003C")]
	public class SWIGTYPE_p_unsigned_char
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public HandleRef swigCPtr;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1490A14", Offset = "0x1490A14", VA = "0x1490A14")]
		public SWIGTYPE_p_unsigned_char(IntPtr cPtr, bool futureUse)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1494F80", Offset = "0x1494F80", VA = "0x1494F80")]
		public static HandleRef getCPtr(SWIGTYPE_p_unsigned_char obj)
		{
			return default(HandleRef);
		}
	}
}
namespace Stark
{
	[Token(Token = "0x200003D")]
	public enum AEPixelFormat
	{
		[Token(Token = "0x4000120")]
		INVALID = -1,
		[Token(Token = "0x4000121")]
		RGBA8UNORM,
		[Token(Token = "0x4000122")]
		BGRA8UNORM,
		[Token(Token = "0x4000123")]
		BGR8UNORM,
		[Token(Token = "0x4000124")]
		RGB8UNORM,
		[Token(Token = "0x4000125")]
		GRAY8,
		[Token(Token = "0x4000126")]
		YUV420P,
		[Token(Token = "0x4000127")]
		NV12,
		[Token(Token = "0x4000128")]
		NV21
	}
	[Token(Token = "0x200003E")]
	public enum AERotateMode
	{
		[Token(Token = "0x400012A")]
		ROTATE_CW_0,
		[Token(Token = "0x400012B")]
		ROTATE_CW_90,
		[Token(Token = "0x400012C")]
		ROTATE_CW_180,
		[Token(Token = "0x400012D")]
		ROTATE_CW_270
	}
	[Token(Token = "0x200003F")]
	public class BachSDK
	{
		[Token(Token = "0x2000040")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool withDevice;

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x149C400", Offset = "0x149C400", VA = "0x149C400")]
			public <>c__DisplayClass3_0()
			{
			}
		}

		[Token(Token = "0x2000041")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000132")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int type;

			[Token(Token = "0x4000133")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public double[] data;

			[Token(Token = "0x4000134")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int dataLen;

			[Token(Token = "0x4000135")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double timestamp;

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x149C534", Offset = "0x149C534", VA = "0x149C534")]
			public <>c__DisplayClass4_0()
			{
			}
		}

		[Token(Token = "0x2000042")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000136")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string graphConfig;

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x149C6DC", Offset = "0x149C6DC", VA = "0x149C6DC")]
			public <>c__DisplayClass7_0()
			{
			}
		}

		[Token(Token = "0x2000043")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000137")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string modelDir;

			[Token(Token = "0x4000138")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string applicationName;

			[Token(Token = "0x4000139")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string deviceName;

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x149C8B0", Offset = "0x149C8B0", VA = "0x149C8B0")]
			public <>c__DisplayClass17_0()
			{
			}
		}

		[Token(Token = "0x2000044")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool cameraConfigValid;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int front;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int orientation;

			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool sensorConfigValid;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int oriSupport;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int accSupport;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int graSupport;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int gyroSupport;

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x149CA68", Offset = "0x149CA68", VA = "0x149CA68")]
			public <>c__DisplayClass18_0()
			{
			}
		}

		[Token(Token = "0x2000045")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int width;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int height;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IntPtr textureHandle;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int format;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int rotateMode;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int flipMode;

			[Token(Token = "0x4000148")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public double timestamp;

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x149CC14", Offset = "0x149CC14", VA = "0x149CC14")]
			public <>c__DisplayClass19_0()
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<GraphicsFormat, AEPixelFormat> formatTransformDic;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Dictionary<int, AERotateMode> rotateTransformDic;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TAG;

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x149C394", Offset = "0x149C394", VA = "0x149C394")]
		public static void CreateAlgorithmSystemInstance(bool withDevice = false)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x149C488", Offset = "0x149C488", VA = "0x149C488")]
		public static int SetDeviceData(int type, double[] data, int dataLen, double timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x149C5EC", Offset = "0x149C5EC", VA = "0x149C5EC")]
		public static int ReleaseAlgorithmSystemInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x149C664", Offset = "0x149C664", VA = "0x149C664")]
		public static int InitGraph(string graphConfig)
		{
			return default(int);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x149C778", Offset = "0x149C778", VA = "0x149C778")]
		public static int RemoveGraph()
		{
			return default(int);
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x149C7F0", Offset = "0x149C7F0", VA = "0x149C7F0")]
		public static int InitConfig(string modelDir, string applicationName, string deviceName)
		{
			return default(int);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x149C994", Offset = "0x149C994", VA = "0x149C994")]
		public static int InitDevice(bool cameraConfigValid, int front, int orientation, bool sensorConfigValid, int oriSupport, int accSupport, int graSupport, int gyroSupport)
		{
			return default(int);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x149CB48", Offset = "0x149CB48", VA = "0x149CB48")]
		public static int Execute(int width, int height, IntPtr textureHandle, int format, int rotateMode, int flipMode, double timestamp)
		{
			return default(int);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x149CCEC", Offset = "0x149CCEC", VA = "0x149CCEC")]
		public static SlamBuffer GetSlamBuffer()
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x149CD7C", Offset = "0x149CD7C", VA = "0x149CD7C")]
		public static AEPixelFormat GetPixelFormat(GraphicsFormat format)
		{
			return default(AEPixelFormat);
		}
	}
	[Token(Token = "0x2000046")]
	internal class BachSDKPINVOKE
	{
		[Token(Token = "0x2000047")]
		internal class MonoPInvokeCallbackAttribute : Attribute
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x149D66C", Offset = "0x149D66C", VA = "0x149D66C")]
			public MonoPInvokeCallbackAttribute()
			{
			}
		}

		[Token(Token = "0x2000048")]
		protected class SWIGExceptionHelper
		{
			[Token(Token = "0x2000049")]
			public delegate void ExceptionDelegate(string message);

			[Token(Token = "0x200004A")]
			public delegate void ExceptionArgumentDelegate(string message, string paramName);

			[Token(Token = "0x400014B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static ExceptionDelegate applicationDelegate;

			[Token(Token = "0x400014C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static ExceptionDelegate arithmeticDelegate;

			[Token(Token = "0x400014D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static ExceptionDelegate divideByZeroDelegate;

			[Token(Token = "0x400014E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static ExceptionDelegate indexOutOfRangeDelegate;

			[Token(Token = "0x400014F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static ExceptionDelegate invalidCastDelegate;

			[Token(Token = "0x4000150")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static ExceptionDelegate invalidOperationDelegate;

			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static ExceptionDelegate ioDelegate;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static ExceptionDelegate nullReferenceDelegate;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static ExceptionDelegate outOfMemoryDelegate;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private static ExceptionDelegate overflowDelegate;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private static ExceptionDelegate systemDelegate;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private static ExceptionArgumentDelegate argumentDelegate;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private static ExceptionArgumentDelegate argumentNullDelegate;

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

			[PreserveSig]
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x149DF8C", Offset = "0x149DF8C", VA = "0x149DF8C")]
			public static extern void SWIGRegisterExceptionCallbacks_BachSDK(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

			[PreserveSig]
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x149E100", Offset = "0x149E100", VA = "0x149E100")]
			public static extern void SWIGRegisterExceptionCallbacksArgument_BachSDK(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x149D674", Offset = "0x149D674", VA = "0x149D674")]
			[MonoPInvokeCallback]
			private static void SetPendingApplicationException(string message)
			{
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0x149D710", Offset = "0x149D710", VA = "0x149D710")]
			[MonoPInvokeCallback]
			private static void SetPendingArithmeticException(string message)
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0x149D7AC", Offset = "0x149D7AC", VA = "0x149D7AC")]
			[MonoPInvokeCallback]
			private static void SetPendingDivideByZeroException(string message)
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0x149D848", Offset = "0x149D848", VA = "0x149D848")]
			[MonoPInvokeCallback]
			private static void SetPendingIndexOutOfRangeException(string message)
			{
			}

			[Token(Token = "0x6000164")]
			[Address(RVA = "0x149D8E4", Offset = "0x149D8E4", VA = "0x149D8E4")]
			[MonoPInvokeCallback]
			private static void SetPendingInvalidCastException(string message)
			{
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0x149D980", Offset = "0x149D980", VA = "0x149D980")]
			[MonoPInvokeCallback]
			private static void SetPendingInvalidOperationException(string message)
			{
			}

			[Token(Token = "0x6000166")]
			[Address(RVA = "0x149DA1C", Offset = "0x149DA1C", VA = "0x149DA1C")]
			[MonoPInvokeCallback]
			private static void SetPendingIOException(string message)
			{
			}

			[Token(Token = "0x6000167")]
			[Address(RVA = "0x149DAB8", Offset = "0x149DAB8", VA = "0x149DAB8")]
			[MonoPInvokeCallback]
			private static void SetPendingNullReferenceException(string message)
			{
			}

			[Token(Token = "0x6000168")]
			[Address(RVA = "0x149DB54", Offset = "0x149DB54", VA = "0x149DB54")]
			[MonoPInvokeCallback]
			private static void SetPendingOutOfMemoryException(string message)
			{
			}

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x149DBF0", Offset = "0x149DBF0", VA = "0x149DBF0")]
			[MonoPInvokeCallback]
			private static void SetPendingOverflowException(string message)
			{
			}

			[Token(Token = "0x600016A")]
			[Address(RVA = "0x149DC8C", Offset = "0x149DC8C", VA = "0x149DC8C")]
			[MonoPInvokeCallback]
			private static void SetPendingSystemException(string message)
			{
			}

			[Token(Token = "0x600016B")]
			[Address(RVA = "0x149DD28", Offset = "0x149DD28", VA = "0x149DD28")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentException(string message, string paramName)
			{
			}

			[Token(Token = "0x600016C")]
			[Address(RVA = "0x149DDCC", Offset = "0x149DDCC", VA = "0x149DDCC")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentNullException(string message, string paramName)
			{
			}

			[Token(Token = "0x600016D")]
			[Address(RVA = "0x149DEAC", Offset = "0x149DEAC", VA = "0x149DEAC")]
			[MonoPInvokeCallback]
			private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
			{
			}

			[Token(Token = "0x600016E")]
			[Address(RVA = "0x149E50C", Offset = "0x149E50C", VA = "0x149E50C")]
			static SWIGExceptionHelper()
			{
			}

			[Token(Token = "0x600016F")]
			[Address(RVA = "0x149D080", Offset = "0x149D080", VA = "0x149D080")]
			public SWIGExceptionHelper()
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class SWIGPendingException
		{
			[Token(Token = "0x4000159")]
			[ThreadStatic]
			private static Exception pendingException;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static int numExceptionsPending;

			[Token(Token = "0x400015B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static object exceptionsLock;

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x149E328", Offset = "0x149E328", VA = "0x149E328")]
			public static void Set(Exception e)
			{
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x149E1B8", Offset = "0x149E1B8", VA = "0x149E1B8")]
			public static Exception Retrieve()
			{
				return null;
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x149F174", Offset = "0x149F174", VA = "0x149F174")]
			static SWIGPendingException()
			{
			}
		}

		[Token(Token = "0x200004C")]
		protected class SWIGStringHelper
		{
			[Token(Token = "0x200004D")]
			public delegate string SWIGStringDelegate(string message);

			[Token(Token = "0x400015C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static SWIGStringDelegate stringDelegate;

			[PreserveSig]
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x149F1E8", Offset = "0x149F1E8", VA = "0x149F1E8")]
			public static extern void SWIGRegisterStringCallback_BachSDK(SWIGStringDelegate stringDelegate);

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x149F1E4", Offset = "0x149F1E4", VA = "0x149F1E4")]
			[MonoPInvokeCallback]
			private static string CreateString(string cString)
			{
				return null;
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x149F268", Offset = "0x149F268", VA = "0x149F268")]
			static SWIGStringHelper()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x149D088", Offset = "0x149D088", VA = "0x149D088")]
			public SWIGStringHelper()
			{
			}
		}

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static SWIGExceptionHelper swigExceptionHelper;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static SWIGStringHelper swigStringHelper;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x149CFE0", Offset = "0x149CFE0", VA = "0x149CFE0")]
		static BachSDKPINVOKE()
		{
		}

		[PreserveSig]
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x149D090", Offset = "0x149D090", VA = "0x149D090")]
		public static extern float Vector4f_x_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x149D10C", Offset = "0x149D10C", VA = "0x149D10C")]
		public static extern float Vector4f_y_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x149D188", Offset = "0x149D188", VA = "0x149D188")]
		public static extern float Vector4f_z_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x149D204", Offset = "0x149D204", VA = "0x149D204")]
		public static extern float Vector4f_w_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x149D280", Offset = "0x149D280", VA = "0x149D280")]
		public static extern void delete_Vector4f(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x149D2FC", Offset = "0x149D2FC", VA = "0x149D2FC")]
		public static extern IntPtr Matrix4x4f_GetRow(HandleRef jarg1, int jarg2);

		[PreserveSig]
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x149D38C", Offset = "0x149D38C", VA = "0x149D38C")]
		public static extern void delete_Matrix4x4f(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x149D408", Offset = "0x149D408", VA = "0x149D408")]
		public static extern IntPtr SlamResult_view_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x149D484", Offset = "0x149D484", VA = "0x149D484")]
		public static extern void delete_SlamResult(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x149D500", Offset = "0x149D500", VA = "0x149D500")]
		public static extern IntPtr SlamBuffer_m_slamInfo_get(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x149D57C", Offset = "0x149D57C", VA = "0x149D57C")]
		public static extern void delete_SlamBuffer(HandleRef jarg1);

		[PreserveSig]
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x149D5F8", Offset = "0x149D5F8", VA = "0x149D5F8")]
		public static extern IntPtr BachSystem_GetSlamBuffer();
	}
	[Token(Token = "0x200004E")]
	public class BachSystem
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x149CCF0", Offset = "0x149CCF0", VA = "0x149CCF0")]
		public static SlamBuffer GetSlamBuffer()
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class Matrix4x4f : IDisposable
	{
		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x149F754", Offset = "0x149F754", VA = "0x149F754")]
		internal Matrix4x4f(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x149F7C4", Offset = "0x149F7C4", VA = "0x149F7C4", Slot = "1")]
		~Matrix4x4f()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x149F838", Offset = "0x149F838", VA = "0x149F838", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x149F8B4", Offset = "0x149F8B4", VA = "0x149F8B4", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x149F9E4", Offset = "0x149F9E4", VA = "0x149F9E4")]
		public Vector4f GetRow(int row)
		{
			return null;
		}
	}
	[Token(Token = "0x2000050")]
	public class SlamBuffer : IDisposable
	{
		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000013")]
		public SlamResult m_slamInfo
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x149FD20", Offset = "0x149FD20", VA = "0x149FD20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x149F6E4", Offset = "0x149F6E4", VA = "0x149F6E4")]
		internal SlamBuffer(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x149FB00", Offset = "0x149FB00", VA = "0x149FB00", Slot = "1")]
		~SlamBuffer()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x149FB74", Offset = "0x149FB74", VA = "0x149FB74", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x149FBF0", Offset = "0x149FBF0", VA = "0x149FBF0", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class SlamResult : IDisposable
	{
		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000014")]
		public Matrix4x4f view
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x14A005C", Offset = "0x14A005C", VA = "0x14A005C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x149FDCC", Offset = "0x149FDCC", VA = "0x149FDCC")]
		internal SlamResult(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x149FE3C", Offset = "0x149FE3C", VA = "0x149FE3C", Slot = "1")]
		~SlamResult()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x149FEB0", Offset = "0x149FEB0", VA = "0x149FEB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x149FF2C", Offset = "0x149FF2C", VA = "0x149FF2C", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class Vector4f : IDisposable
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HandleRef swigCPtr;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool swigCMemOwn;

		[Token(Token = "0x17000015")]
		public float x
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x14A0328", Offset = "0x14A0328", VA = "0x14A0328")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000016")]
		public float y
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x14A0394", Offset = "0x14A0394", VA = "0x14A0394")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000017")]
		public float z
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x14A0400", Offset = "0x14A0400", VA = "0x14A0400")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public float w
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x14A046C", Offset = "0x14A046C", VA = "0x14A046C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x149FA90", Offset = "0x149FA90", VA = "0x149FA90")]
		internal Vector4f(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x14A0108", Offset = "0x14A0108", VA = "0x14A0108", Slot = "1")]
		~Vector4f()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x14A017C", Offset = "0x14A017C", VA = "0x14A017C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x14A01F8", Offset = "0x14A01F8", VA = "0x14A01F8", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
namespace Stark.Extern
{
	[Token(Token = "0x2000053")]
	internal class BachSDKExtern
	{
		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x149C408", Offset = "0x149C408", VA = "0x149C408")]
		public static extern void CreateAlgorithmSystemInstance(bool withDevice);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x149C8B8", Offset = "0x149C8B8", VA = "0x149C8B8")]
		public static extern int InitConfig(string modelDir, string applicationName, string deviceName);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x149C6E4", Offset = "0x149C6E4", VA = "0x149C6E4")]
		public static extern int InitGraph(string config);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x149C77C", Offset = "0x149C77C", VA = "0x149C77C")]
		public static extern int RemoveGraph();

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x149CC1C", Offset = "0x149CC1C", VA = "0x149CC1C")]
		public static extern int Execute(int width, int height, IntPtr textureHandle, int format, int rotateMode, int flipMode, double timestamp);

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x149C5F0", Offset = "0x149C5F0", VA = "0x149C5F0")]
		public static extern int ReleaseAlgorithmSystemInstance();

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x149CA70", Offset = "0x149CA70", VA = "0x149CA70")]
		public static extern int InitDevice(bool cameraConfigValid, int front, int orientation, bool sensorConfigValid, int oriSupport, int accSupport, int graSupport, int gyroSupport);

		[PreserveSig]
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x149C53C", Offset = "0x149C53C", VA = "0x149C53C")]
		public static extern int SetDeviceData(int type, double[] data, int dataLen, double timestamp);
	}
}
