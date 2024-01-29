using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RenderHeads.Media.AVProMovieCapture
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A8288", Offset = "0x5A8288")]
	public class CaptureFromCamera : CaptureBase
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A82C4", Offset = "0x5A82C4")]
		private sealed class <FinalRenderCapture>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera <>4__this;

			[Token(Token = "0x17000002")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000013")]
				[Address(RVA = "0x132EB00", Offset = "0x132EB00", VA = "0x132EB00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000003")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000015")]
				[Address(RVA = "0x132EB48", Offset = "0x132EB48", VA = "0x132EB48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x132EA5C", Offset = "0x132EA5C", VA = "0x132EA5C")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x132EA88", Offset = "0x132EA88", VA = "0x132EA88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x132EA8C", Offset = "0x132EA8C", VA = "0x132EA8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x132EB08", Offset = "0x132EB08", VA = "0x132EB08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Camera _lastCamera;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private Camera[] _contribCameras;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private bool _useContributingCameras;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private RenderTexture _target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x17000001")]
		public bool UseContributingCameras
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x11D8B64", Offset = "0x11D8B64", VA = "0x11D8B64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x11D8B6C", Offset = "0x11D8B6C", VA = "0x11D8B6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x11D8B78", Offset = "0x11D8B78", VA = "0x11D8B78")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x11D8C74", Offset = "0x11D8C74", VA = "0x11D8C74")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x11D8CAC", Offset = "0x11D8CAC", VA = "0x11D8CAC")]
		private bool HasCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x11D8D18", Offset = "0x11D8D18", VA = "0x11D8D18")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x11D8D40", Offset = "0x11D8D40", VA = "0x11D8D40", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x11D8DB4", Offset = "0x11D8DB4", VA = "0x11D8DB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8BA4", Offset = "0x5A8BA4")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x11D8E2C", Offset = "0x11D8E2C", VA = "0x11D8E2C")]
		private void Capture()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x11D9010", Offset = "0x11D9010", VA = "0x11D9010")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x11D9518", Offset = "0x11D9518", VA = "0x11D9518", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x11D95BC", Offset = "0x11D95BC", VA = "0x11D95BC", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x11D95C4", Offset = "0x11D95C4", VA = "0x11D95C4", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x11D9BC4", Offset = "0x11D9BC4", VA = "0x11D9BC4", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x11D9C88", Offset = "0x11D9C88", VA = "0x11D9C88")]
		public CaptureFromCamera()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A82D4", Offset = "0x5A82D4")]
	public class CaptureFromCamera360 : CaptureBase
	{
		[Token(Token = "0x2000005")]
		private enum CubemapRenderMethod
		{
			[Token(Token = "0x4000019")]
			Manual,
			[Token(Token = "0x400001A")]
			Unity,
			[Token(Token = "0x400001B")]
			Unity2018
		}

		[Token(Token = "0x2000006")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A8310", Offset = "0x5A8310")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360 <>4__this;

			[Token(Token = "0x17000004")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x132EBF4", Offset = "0x132EBF4", VA = "0x132EBF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000005")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0x132EC3C", Offset = "0x132EC3C", VA = "0x132EC3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x132EB50", Offset = "0x132EB50", VA = "0x132EB50")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x132EB7C", Offset = "0x132EB7C", VA = "0x132EB7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x132EB80", Offset = "0x132EB80", VA = "0x132EB80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x132EBFC", Offset = "0x132EBFC", VA = "0x132EBFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		public int _cubemapResolution;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		public int _cubemapDepth;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		public bool _supportGUI;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		[SerializeField]
		public bool _supportCameraRotation;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A8584", Offset = "0x5A8584")]
		public bool _render180Degrees;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		public StereoPacking _stereoRendering;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A85E0", Offset = "0x5A85E0")]
		[SerializeField]
		public float _ipd;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private RenderTexture _faceTarget;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Material _blitMaterial;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Material _cubemapToEquirectangularMaterial;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RenderTexture _cubeTarget;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private RenderTexture _finalTarget;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _propFlipX;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x11D9D00", Offset = "0x11D9D00", VA = "0x11D9D00")]
		public CaptureFromCamera360()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x11D9D94", Offset = "0x11D9D94", VA = "0x11D9D94")]
		private CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return default(CubemapRenderMethod);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x11D9DCC", Offset = "0x11D9DCC", VA = "0x11D9DCC")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x11D9DDC", Offset = "0x11D9DDC", VA = "0x11D9DDC", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x11D9E38", Offset = "0x11D9E38", VA = "0x11D9E38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8C54", Offset = "0x5A8C54")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x11D9EB0", Offset = "0x11D9EB0", VA = "0x11D9EB0")]
		private void Capture()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x11DA4E4", Offset = "0x11DA4E4", VA = "0x11DA4E4")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x11DA6C4", Offset = "0x11DA6C4", VA = "0x11DA6C4")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x11DA1BC", Offset = "0x11DA1BC", VA = "0x11DA1BC")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11DA868", Offset = "0x11DA868", VA = "0x11DA868")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x11DA0D0", Offset = "0x11DA0D0", VA = "0x11DA0D0")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x11DAF78", Offset = "0x11DAF78", VA = "0x11DAF78", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x11DBBE8", Offset = "0x11DBBE8", VA = "0x11DBBE8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x11DBC28", Offset = "0x11DBC28", VA = "0x11DBC28", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x11DBE58", Offset = "0x11DBE58", VA = "0x11DBE58", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A8320", Offset = "0x5A8320")]
	public class CaptureFromCamera360ODS : CaptureBase
	{
		[Serializable]
		[Token(Token = "0x2000008")]
		public class Settings
		{
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Camera camera;

			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A865C", Offset = "0x5A865C")]
			public bool render180Degrees;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A86A8", Offset = "0x5A86A8")]
			public float ipd;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A86F4", Offset = "0x5A86F4")]
			[SerializeField]
			public int pixelSliceSize;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A8740", Offset = "0x5A8740")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A8740", Offset = "0x5A8740")]
			public int paddingSize;

			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			public CameraClearFlags cameraClearMode;

			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			public Color cameraClearColor;

			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[SerializeField]
			public Behaviour[] cameraImageEffects;

			[Token(Token = "0x6000039")]
			[Address(RVA = "0x132ED38", Offset = "0x132ED38", VA = "0x132ED38")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A835C", Offset = "0x5A835C")]
		private sealed class <FinalRenderCapture>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromCamera360ODS <>4__this;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x132ECE8", Offset = "0x132ECE8", VA = "0x132ECE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x132ED30", Offset = "0x132ED30", VA = "0x132ED30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x132EC44", Offset = "0x132EC44", VA = "0x132EC44")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x132EC70", Offset = "0x132EC70", VA = "0x132EC70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x132EC74", Offset = "0x132EC74", VA = "0x132EC74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x132ECF0", Offset = "0x132ECF0", VA = "0x132ECF0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int _eyeWidth;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _eyeHeight;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Transform _cameraGroup;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Camera _leftCameraTop;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Camera _leftCameraBot;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Camera _rightCameraTop;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Camera _rightCameraBot;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private RenderTexture _final;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Material _finalMaterial;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private int _propSliceCenter;

		[Token(Token = "0x17000006")]
		public Settings Setup
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x11DC068", Offset = "0x11DC068", VA = "0x11DC068")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x11DC070", Offset = "0x11DC070", VA = "0x11DC070")]
		public CaptureFromCamera360ODS()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x11DC134", Offset = "0x11DC134", VA = "0x11DC134")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x11DC150", Offset = "0x11DC150", VA = "0x11DC150", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x11DC2A4", Offset = "0x11DC2A4", VA = "0x11DC2A4")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x11DC808", Offset = "0x11DC808", VA = "0x11DC808", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x11DC864", Offset = "0x11DC864", VA = "0x11DC864")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8D04", Offset = "0x5A8D04")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x11DC8DC", Offset = "0x11DC8DC", VA = "0x11DC8DC")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x11DCA90", Offset = "0x11DCA90", VA = "0x11DCA90")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x11DCB84", Offset = "0x11DCB84", VA = "0x11DCB84")]
		private void RenderFrame()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x11DCEF8", Offset = "0x11DCEF8", VA = "0x11DCEF8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x11DCF38", Offset = "0x11DCF38", VA = "0x11DCF38", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x11DDA90", Offset = "0x11DDA90", VA = "0x11DDA90")]
		private static void DestroyEye(Camera camera)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x11DDB68", Offset = "0x11DDB68", VA = "0x11DDB68", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A836C", Offset = "0x5A836C")]
	public class CaptureFromScreen : CaptureBase
	{
		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A83A8", Offset = "0x5A83A8")]
		private sealed class <FinalRenderCapture>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromScreen <>4__this;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000047")]
				[Address(RVA = "0x132EEE0", Offset = "0x132EEE0", VA = "0x132EEE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0x132EF28", Offset = "0x132EF28", VA = "0x132EF28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x132ED88", Offset = "0x132ED88", VA = "0x132ED88")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x132EDB4", Offset = "0x132EDB4", VA = "0x132EDB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x132EDB8", Offset = "0x132EDB8", VA = "0x132EDB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x132EEE8", Offset = "0x132EEE8", VA = "0x132EEE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x11DDDA4", Offset = "0x11DDDA4", VA = "0x11DDDA4", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x11DDF98", Offset = "0x11DDF98", VA = "0x11DDF98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8DB4", Offset = "0x5A8DB4")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x11DE010", Offset = "0x11DE010", VA = "0x11DE010", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x11DE058", Offset = "0x11DE058", VA = "0x11DE058")]
		public CaptureFromScreen()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A83B8", Offset = "0x5A83B8")]
	public class CaptureFromTexture : CaptureBase
	{
		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A83F4", Offset = "0x5A83F4")]
		private sealed class <FinalRenderCapture>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromTexture <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000059")]
				[Address(RVA = "0x132EFD4", Offset = "0x132EFD4", VA = "0x132EFD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600005B")]
				[Address(RVA = "0x132F01C", Offset = "0x132F01C", VA = "0x132F01C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x132EF30", Offset = "0x132EF30", VA = "0x132EF30")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x132EF5C", Offset = "0x132EF5C", VA = "0x132EF5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x132EF60", Offset = "0x132EF60", VA = "0x132EF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x132EFDC", Offset = "0x132EFDC", VA = "0x132EFDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A87D4", Offset = "0x5A87D4")]
		[SerializeField]
		private bool _manualUpdate;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Texture _sourceTexture;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private RenderTexture _renderTexture;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private IntPtr _targetNativePointer;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool _isSourceTextureChanged;

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x11DE0B8", Offset = "0x11DE0B8", VA = "0x11DE0B8")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x11DE3C8", Offset = "0x11DE3C8", VA = "0x11DE3C8")]
		public void UpdateSourceTexture()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x11DE3D4", Offset = "0x11DE3D4", VA = "0x11DE3D4")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x11DE460", Offset = "0x11DE460", VA = "0x11DE460")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x11DE480", Offset = "0x11DE480", VA = "0x11DE480", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x11DE4CC", Offset = "0x11DE4CC", VA = "0x11DE4CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8E64", Offset = "0x5A8E64")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x11DE544", Offset = "0x11DE544", VA = "0x11DE544")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x11DE7B0", Offset = "0x11DE7B0", VA = "0x11DE7B0")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x11DE858", Offset = "0x11DE858", VA = "0x11DE858", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x11DE8F8", Offset = "0x11DE8F8", VA = "0x11DE8F8", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x11DEB60", Offset = "0x11DEB60", VA = "0x11DEB60", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x11DEC14", Offset = "0x11DEC14", VA = "0x11DEC14")]
		public CaptureFromTexture()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A8404", Offset = "0x5A8404")]
	public class CaptureGUI : MonoBehaviour
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CaptureBase _movieCapture;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _showUI;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool _whenRecordingAutoHideUI;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GUISkin _guiSkin;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _shownSection;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string[] _videoCodecNames;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] _audioCodecNames;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool[] _videoCodecConfigurable;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool[] _audioCodecConfigurable;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string[] _audioDeviceNames;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string[] _downScales;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string[] _frameRates;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string[] _outputType;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _downScaleIndex;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int _frameRateIndex;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2 _videoPos;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector2 _audioPos;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector2 _audioCodecPos;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private long _lastFileSize;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private uint _lastEncodedMinutes;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private uint _lastEncodedSeconds;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private uint _lastEncodedFrame;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x11DEC84", Offset = "0x11DEC84", VA = "0x11DEC84")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x11DED08", Offset = "0x11DED08", VA = "0x11DED08")]
		private void CreateGUI()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x11DFAE4", Offset = "0x11DFAE4", VA = "0x11DFAE4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x11DFD84", Offset = "0x11DFD84", VA = "0x11DFD84")]
		private void MyWindow(int id)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x11E26BC", Offset = "0x11E26BC", VA = "0x11E26BC")]
		private void GUI_RecordingStatus()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x11E3D90", Offset = "0x11E3D90", VA = "0x11E3D90")]
		private void DrawGuiField(string a, string b)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x11E3CF0", Offset = "0x11E3CF0", VA = "0x11E3CF0")]
		private void StartCapture()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x11E4144", Offset = "0x11E4144", VA = "0x11E4144")]
		private void StopCapture()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x11E40B8", Offset = "0x11E40B8", VA = "0x11E40B8")]
		private void CancelCapture()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x11E402C", Offset = "0x11E402C", VA = "0x11E402C")]
		private void ResumeCapture()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x11E3FA0", Offset = "0x11E3FA0", VA = "0x11E3FA0")]
		private void PauseCapture()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x11E41DC", Offset = "0x11E41DC", VA = "0x11E41DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x11E4344", Offset = "0x11E4344", VA = "0x11E4344")]
		public CaptureGUI()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A8440", Offset = "0x5A8440")]
	public class MotionBlur : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public RenderTextureFormat _format;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _numSamples;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RenderTexture _accum;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture _lastComp;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _addMaterial;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material _divMaterial;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _frameCount;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _targetWidth;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _targetHeight;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _isDirty;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _propNumSamples;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int _propWeight;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A8840", Offset = "0x5A8840")]
		private bool <IsFrameAccumulated>k__BackingField;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float _bias;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _total;

		[Token(Token = "0x1700000D")]
		public bool IsFrameAccumulated
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x11E5CF0", Offset = "0x11E5CF0", VA = "0x11E5CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A8F14", Offset = "0x5A8F14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x11E5CF8", Offset = "0x11E5CF8", VA = "0x11E5CF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A8F24", Offset = "0x5A8F24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int NumSamples
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x11E5D04", Offset = "0x11E5D04", VA = "0x11E5D04")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x11D6C68", Offset = "0x11D6C68", VA = "0x11D6C68")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int FrameCount
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x11E5DE4", Offset = "0x11E5DE4", VA = "0x11E5DE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x11E5DEC", Offset = "0x11E5DEC", VA = "0x11E5DEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x11E5DF4", Offset = "0x11E5DF4", VA = "0x11E5DF4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x11D6C70", Offset = "0x11D6C70", VA = "0x11D6C70")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x11E5E9C", Offset = "0x11E5E9C", VA = "0x11E5E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x11E6200", Offset = "0x11E6200", VA = "0x11E6200")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x11E5EA0", Offset = "0x11E5EA0", VA = "0x11E5EA0")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x11E620C", Offset = "0x11E620C", VA = "0x11E620C")]
		private void ClearAccumulation()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x11E6264", Offset = "0x11E6264", VA = "0x11E6264")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x11E5D0C", Offset = "0x11E5D0C", VA = "0x11E5D0C")]
		public void OnNumSamplesChanged()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x11E648C", Offset = "0x11E648C", VA = "0x11E648C")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x11E649C", Offset = "0x11E649C", VA = "0x11E649C")]
		private void ApplyWeighting()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x11DAE70", Offset = "0x11DAE70", VA = "0x11DAE70")]
		public void Accumulate(Texture src)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x11E656C", Offset = "0x11E656C", VA = "0x11E656C")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11E65F4", Offset = "0x11E65F4", VA = "0x11E65F4")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A847C", Offset = "0x5A847C")]
	public class MouseCursor : MonoBehaviour
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture2D _texture;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _hotspotOffset;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A8880", Offset = "0x5A8880")]
		[SerializeField]
		private int _sizeScale;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _depth;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GUIContent _content;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x11E6610", Offset = "0x11E6610", VA = "0x11E6610")]
		private void Start()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x11E6618", Offset = "0x11E6618", VA = "0x11E6618")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x11E66EC", Offset = "0x11E66EC", VA = "0x11E66EC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11E6818", Offset = "0x11E6818", VA = "0x11E6818")]
		public MouseCursor()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5A84B8", Offset = "0x5A84B8")]
	public class UnityAudioCapture : MonoBehaviour
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _debugLogging;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _muteAudio;

		[Token(Token = "0x400006D")]
		private const int BufferSize = 16;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float[] _buffer;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _readBuffer;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int _bufferIndex;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private GCHandle _bufferHandle;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _numChannels;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _overflowCount;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _lockObject;

		[Token(Token = "0x17000011")]
		public float[] Buffer
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x132C654", Offset = "0x132C654", VA = "0x132C654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public int BufferLength
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x132C65C", Offset = "0x132C65C", VA = "0x132C65C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public int NumChannels
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x132C664", Offset = "0x132C664", VA = "0x132C664")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x132C66C", Offset = "0x132C66C", VA = "0x132C66C")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000015")]
		public int OverflowCount
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x132C678", Offset = "0x132C678", VA = "0x132C678")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x132C680", Offset = "0x132C680", VA = "0x132C680")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x132CAF8", Offset = "0x132CAF8", VA = "0x132CAF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x132CC0C", Offset = "0x132CC0C", VA = "0x132CC0C")]
		public IntPtr ReadData(out int length)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x132CD00", Offset = "0x132CD00", VA = "0x132CD00")]
		public void FlushBuffer()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x132CDC4", Offset = "0x132CDC4", VA = "0x132CDC4")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x132CAD4", Offset = "0x132CAD4", VA = "0x132CAD4")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x132D064", Offset = "0x132D064", VA = "0x132D064")]
		public UnityAudioCapture()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class CaptureBase : MonoBehaviour
	{
		[Token(Token = "0x2000013")]
		public enum FrameRate
		{
			[Token(Token = "0x40000CC")]
			One = 1,
			[Token(Token = "0x40000CD")]
			Ten = 10,
			[Token(Token = "0x40000CE")]
			Fifteen = 15,
			[Token(Token = "0x40000CF")]
			TwentyFour = 24,
			[Token(Token = "0x40000D0")]
			TwentyFive = 25,
			[Token(Token = "0x40000D1")]
			Thirty = 30,
			[Token(Token = "0x40000D2")]
			Fifty = 50,
			[Token(Token = "0x40000D3")]
			Sixty = 60,
			[Token(Token = "0x40000D4")]
			SeventyFive = 75,
			[Token(Token = "0x40000D5")]
			Ninety = 90,
			[Token(Token = "0x40000D6")]
			OneTwenty = 120
		}

		[Token(Token = "0x2000014")]
		public enum Resolution
		{
			[Token(Token = "0x40000D8")]
			POW2_8192x8192,
			[Token(Token = "0x40000D9")]
			POW2_8192x4096,
			[Token(Token = "0x40000DA")]
			POW2_4096x4096,
			[Token(Token = "0x40000DB")]
			POW2_4096x2048,
			[Token(Token = "0x40000DC")]
			POW2_2048x4096,
			[Token(Token = "0x40000DD")]
			UHD_3840x2160,
			[Token(Token = "0x40000DE")]
			UHD_3840x2048,
			[Token(Token = "0x40000DF")]
			UHD_3840x1920,
			[Token(Token = "0x40000E0")]
			POW2_2048x2048,
			[Token(Token = "0x40000E1")]
			POW2_2048x1024,
			[Token(Token = "0x40000E2")]
			HD_1920x1080,
			[Token(Token = "0x40000E3")]
			HD_1280x720,
			[Token(Token = "0x40000E4")]
			SD_1024x768,
			[Token(Token = "0x40000E5")]
			SD_800x600,
			[Token(Token = "0x40000E6")]
			SD_800x450,
			[Token(Token = "0x40000E7")]
			SD_640x480,
			[Token(Token = "0x40000E8")]
			SD_640x360,
			[Token(Token = "0x40000E9")]
			SD_320x240,
			[Token(Token = "0x40000EA")]
			Original,
			[Token(Token = "0x40000EB")]
			Custom
		}

		[Token(Token = "0x2000015")]
		public enum CubemapDepth
		{
			[Token(Token = "0x40000ED")]
			Depth_24 = 24,
			[Token(Token = "0x40000EE")]
			Depth_16 = 16,
			[Token(Token = "0x40000EF")]
			Depth_Zero = 0
		}

		[Token(Token = "0x2000016")]
		public enum CubemapResolution
		{
			[Token(Token = "0x40000F1")]
			POW2_4096 = 4096,
			[Token(Token = "0x40000F2")]
			POW2_2048 = 2048,
			[Token(Token = "0x40000F3")]
			POW2_1024 = 1024,
			[Token(Token = "0x40000F4")]
			POW2_512 = 512,
			[Token(Token = "0x40000F5")]
			POW2_256 = 256
		}

		[Token(Token = "0x2000017")]
		public enum AntiAliasingLevel
		{
			[Token(Token = "0x40000F7")]
			UseCurrent,
			[Token(Token = "0x40000F8")]
			ForceNone,
			[Token(Token = "0x40000F9")]
			ForceSample2,
			[Token(Token = "0x40000FA")]
			ForceSample4,
			[Token(Token = "0x40000FB")]
			ForceSample8
		}

		[Token(Token = "0x2000018")]
		public enum DownScale
		{
			[Token(Token = "0x40000FD")]
			Original = 1,
			[Token(Token = "0x40000FE")]
			Half = 2,
			[Token(Token = "0x40000FF")]
			Quarter = 4,
			[Token(Token = "0x4000100")]
			Eighth = 8,
			[Token(Token = "0x4000101")]
			Sixteenth = 16,
			[Token(Token = "0x4000102")]
			Custom = 100
		}

		[Token(Token = "0x2000019")]
		public enum OutputPath
		{
			[Token(Token = "0x4000104")]
			RelativeToProject,
			[Token(Token = "0x4000105")]
			RelativeToPeristentData,
			[Token(Token = "0x4000106")]
			Absolute
		}

		[Token(Token = "0x200001A")]
		public enum OutputExtension
		{
			[Token(Token = "0x4000108")]
			AVI = 0,
			[Token(Token = "0x4000109")]
			MP4 = 1,
			[Token(Token = "0x400010A")]
			PNG = 2,
			[Token(Token = "0x400010B")]
			Custom = 100
		}

		[Token(Token = "0x200001B")]
		public enum OutputType
		{
			[Token(Token = "0x400010D")]
			VideoFile,
			[Token(Token = "0x400010E")]
			ImageSequence,
			[Token(Token = "0x400010F")]
			NamedPipe
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public class PostCaptureSettings
		{
			[Token(Token = "0x4000110")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A8A48", Offset = "0x5A8A48")]
			[SerializeField]
			public bool writeFastStartStreamingForMp4;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x132EA4C", Offset = "0x132EA4C", VA = "0x132EA4C")]
			public PostCaptureSettings()
			{
			}
		}

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PostCaptureSettings _postCaptureSettings;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KeyCode _captureKey;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool _captureOnStart;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool _startPaused;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool _listVideoCodecsOnStart;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool _isRealTime;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _persistAcrossSceneLoads;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StopMode _stopMode;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int _stopFrames;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float _stopSeconds;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool _useMediaFoundationH264;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string[] _videoCodecPriority;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FrameRate _frameRate;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A8920", Offset = "0x5A8920")]
		private int _timelapseScale;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public DownScale _downScale;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector2 _maxVideoSize;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int _forceVideoCodecIndex;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool _flipVertically;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool _supportAlpha;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A896C", Offset = "0x5A896C")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5A89B8", Offset = "0x5A89B8")]
		[SerializeField]
		protected bool _useWaitForEndOfFrame;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool _noAudio;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string[] _audioCodecPriority;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int _forceAudioCodecIndex;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int _forceAudioDeviceIndex;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityAudioCapture _audioCapture;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool _autoGenerateFilename;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public OutputPath _outputFolderType;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string _outputFolderPath;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string _autoFilenamePrefix;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string _autoFilenameExtension;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string _forceFilename;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int _imageSequenceStartFrame;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A8A04", Offset = "0x5A8A04")]
		public int _imageSequenceZeroDigits;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public OutputType _outputType;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public ImageSequenceFormat _imageSequenceFormat;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Resolution _renderResolution;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Vector2 _renderSize;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public int _renderAntiAliasing;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool _useMotionBlur;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A8A1C", Offset = "0x5A8A1C")]
		public int _motionBlurSamples;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Camera[] _motionBlurCameras;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected MotionBlur _motionBlur;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool _allowVSyncDisable;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		[SerializeField]
		protected bool _supportTextureRecreate;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		public bool _captureMouseCursor;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public MouseCursor _mouseCursor;

		[NonSerialized]
		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string _codecName;

		[NonSerialized]
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int _codecIndex;

		[NonSerialized]
		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public string _audioCodecName;

		[NonSerialized]
		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int _audioCodecIndex;

		[NonSerialized]
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public string _audioDeviceName;

		[NonSerialized]
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int _audioDeviceIndex;

		[NonSerialized]
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public int _unityAudioSampleRate;

		[NonSerialized]
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public int _unityAudioChannelCount;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected Texture2D _texture;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected int _handle;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		protected int _targetWidth;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected int _targetHeight;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		protected bool _capturing;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		protected bool _paused;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected string _filePath;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected FileInfo _fileInfo;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected NativePlugin.PixelFormat _pixelFormat;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private int _oldVSyncCount;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float _oldFixedDeltaTime;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		protected bool _isTopDown;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		protected bool _isDirectX11;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		private bool _queuedStartCapture;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		private bool _queuedStopCapture;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float _captureStartTime;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float _timeSinceLastFrame;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected YieldInstruction _waitForEndOfFrame;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public int _minimumDiskSpaceMB;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private long _freeDiskSpaceMB;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private uint _numDroppedFrames;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private uint _numDroppedEncoderFrames;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private uint _numEncodedFrames;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private uint _totalEncodedSeconds;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _isInitialised;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected IntPtr _renderEventFunction;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected IntPtr _freeEventFunction;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float _fps;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private int _frameTotal;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _frameCount;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private float _startFrameTime;

		[Token(Token = "0x17000016")]
		public string LastFilePath
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x11D31C0", Offset = "0x11D31C0", VA = "0x11D31C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x11D31C8", Offset = "0x11D31C8", VA = "0x11D31C8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000018")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x11D31D0", Offset = "0x11D31D0", VA = "0x11D31D0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000019")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x11D31D8", Offset = "0x11D31D8", VA = "0x11D31D8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001A")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x11D31E0", Offset = "0x11D31E0", VA = "0x11D31E0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001B")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x11D31E8", Offset = "0x11D31E8", VA = "0x11D31E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x11D31F0", Offset = "0x11D31F0", VA = "0x11D31F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int TimelapseScale
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x11D3500", Offset = "0x11D3500", VA = "0x11D3500")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x11D3508", Offset = "0x11D3508", VA = "0x11D3508")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x11D3510", Offset = "0x11D3510", VA = "0x11D3510")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x11D3518", Offset = "0x11D3518", VA = "0x11D3518")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public PostCaptureSettings PostCapture
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x11D3524", Offset = "0x11D3524", VA = "0x11D3524")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static string LastFileSaved
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x11D7318", Offset = "0x11D7318", VA = "0x11D7318")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x11D7380", Offset = "0x11D7380", VA = "0x11D7380")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float FPS
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x11D83D0", Offset = "0x11D83D0", VA = "0x11D83D0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float FramesTotal
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x11D83D8", Offset = "0x11D83D8", VA = "0x11D83D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x11D352C", Offset = "0x11D352C", VA = "0x11D352C", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x11D3EA8", Offset = "0x11D3EA8", VA = "0x11D3EA8")]
		protected void SetupRenderFunctions()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x11D440C", Offset = "0x11D440C", VA = "0x11D440C", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x11D321C", Offset = "0x11D321C", VA = "0x11D321C")]
		public void SelectCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x11D3ED4", Offset = "0x11D3ED4", VA = "0x11D3ED4")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x11D41B0", Offset = "0x11D41B0", VA = "0x11D41B0")]
		public void SelectAudioDevice(bool display)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x11D4994", Offset = "0x11D4994", VA = "0x11D4994")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x11D4A7C", Offset = "0x11D4A7C", VA = "0x11D4A7C")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x11D4B6C", Offset = "0x11D4B6C", VA = "0x11D4B6C", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x11D4BA8", Offset = "0x11D4BA8", VA = "0x11D4BA8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x11D4CC0", Offset = "0x11D4CC0", VA = "0x11D4CC0")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x11D4D40", Offset = "0x11D4D40", VA = "0x11D4D40")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x11D4DD4", Offset = "0x11D4DD4", VA = "0x11D4DD4")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x11D4E18", Offset = "0x11D4E18", VA = "0x11D4E18")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x11D4EA4", Offset = "0x11D4EA4", VA = "0x11D4EA4", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x11D5064", Offset = "0x11D5064", VA = "0x11D5064")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x11D506C", Offset = "0x11D506C", VA = "0x11D506C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x11D5074", Offset = "0x11D5074", VA = "0x11D5074")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x11D507C", Offset = "0x11D507C", VA = "0x11D507C")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x11D5084", Offset = "0x11D5084", VA = "0x11D5084", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x11D5468", Offset = "0x11D5468", VA = "0x11D5468")]
		private static string GetFolder(OutputPath outputPathType, string path)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x11D5594", Offset = "0x11D5594", VA = "0x11D5594")]
		private static string AutoGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x11D564C", Offset = "0x11D564C", VA = "0x11D564C")]
		private static string ManualGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x11D5740", Offset = "0x11D5740", VA = "0x11D5740")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x11D577C", Offset = "0x11D577C", VA = "0x11D577C")]
		protected void GenerateFilename()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x11D5C7C", Offset = "0x11D5C7C", VA = "0x11D5C7C", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x11D6FD8", Offset = "0x11D6FD8", VA = "0x11D6FD8")]
		public void QueueStartCapture()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x11D4498", Offset = "0x11D4498", VA = "0x11D4498")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x11D709C", Offset = "0x11D709C", VA = "0x11D709C")]
		public void PauseCapture()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x11D7194", Offset = "0x11D7194", VA = "0x11D7194")]
		public void ResumeCapture()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x11D722C", Offset = "0x11D722C", VA = "0x11D722C")]
		public void CancelCapture()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x11D7284", Offset = "0x11D7284", VA = "0x11D7284", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x11D73D0", Offset = "0x11D73D0", VA = "0x11D73D0")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x11D747C", Offset = "0x11D747C", VA = "0x11D747C", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x11D78E8", Offset = "0x11D78E8", VA = "0x11D78E8")]
		protected void ApplyPostOperations(string path)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x11D7D28", Offset = "0x11D7D28", VA = "0x11D7D28")]
		private void ToggleCapture()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x11D7D44", Offset = "0x11D7D44", VA = "0x11D7D44")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x11D7D4C", Offset = "0x11D7D4C", VA = "0x11D7D4C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x11D7DB4", Offset = "0x11D7DB4", VA = "0x11D7DB4")]
		private void CheckFreeDiskSpace()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x11D7DF8", Offset = "0x11D7DF8", VA = "0x11D7DF8")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x11D7E90", Offset = "0x11D7E90", VA = "0x11D7E90")]
		public float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x11D7074", Offset = "0x11D7074", VA = "0x11D7074")]
		protected float GetSecondsPerCaptureFrame()
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x11D7F30", Offset = "0x11D7F30", VA = "0x11D7F30")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x11D8080", Offset = "0x11D8080", VA = "0x11D8080")]
		protected void TickFrameTimer()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x11D80B8", Offset = "0x11D80B8", VA = "0x11D80B8")]
		protected void RenormTimer()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x11D80F4", Offset = "0x11D80F4", VA = "0x11D80F4", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x11D80FC", Offset = "0x11D80FC", VA = "0x11D80FC", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11D706C", Offset = "0x11D706C", VA = "0x11D706C")]
		protected void ResetFPS()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11D83E4", Offset = "0x11D83E4", VA = "0x11D83E4")]
		public void UpdateFPS()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x11D8448", Offset = "0x11D8448", VA = "0x11D8448")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x11D8630", Offset = "0x11D8630", VA = "0x11D8630")]
		private void ConfigureCodec()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x11D86F0", Offset = "0x11D86F0", VA = "0x11D86F0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x11D87C8", Offset = "0x11D87C8", VA = "0x11D87C8")]
		public static void GetResolution(Resolution res, ref int width, ref int height)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x11D4A70", Offset = "0x11D4A70", VA = "0x11D4A70")]
		protected static int NextMultipleOf4(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x11D87F4", Offset = "0x11D87F4", VA = "0x11D87F4")]
		public CaptureBase()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class MP4FileProcessing
	{
		[Token(Token = "0x200001E")]
		private class Chunk
		{
			[Token(Token = "0x400011E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint id;

			[Token(Token = "0x400011F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public long size;

			[Token(Token = "0x4000120")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public long offset;

			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x132F024", Offset = "0x132F024", VA = "0x132F024")]
			public Chunk()
			{
			}
		}

		[Token(Token = "0x4000111")]
		private const int ChunkHeaderSize = 8;

		[Token(Token = "0x4000112")]
		private const int CopyBufferSize = 65536;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static uint Atom_moov;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static uint Atom_mdat;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static uint Atom_cmov;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static uint Atom_trak;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static uint Atom_mdia;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static uint Atom_minf;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static uint Atom_stbl;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static uint Atom_stco;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static uint Atom_co64;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private BinaryReader _reader;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stream _writeFile;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x11D7AD8", Offset = "0x11D7AD8", VA = "0x11D7AD8")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x11E446C", Offset = "0x11E446C", VA = "0x11E446C")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x11E478C", Offset = "0x11E478C", VA = "0x11E478C")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x11E4AE0", Offset = "0x11E4AE0", VA = "0x11E4AE0")]
		public void Close()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x11E4D00", Offset = "0x11E4D00", VA = "0x11E4D00")]
		private static Chunk GetFirstChunkOfType(uint id, List<Chunk> chunks)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x11E4B28", Offset = "0x11E4B28", VA = "0x11E4B28")]
		private List<Chunk> ReadChildChunks(Chunk parentChunk)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11E538C", Offset = "0x11E538C", VA = "0x11E538C")]
		private Chunk ReadChunkHeader()
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x11E4E34", Offset = "0x11E4E34", VA = "0x11E4E34")]
		private bool ChunkContainsChildChunkWithId(Chunk chunk, uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x11E532C", Offset = "0x11E532C", VA = "0x11E532C")]
		private void WriteChunk(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11E5714", Offset = "0x11E5714", VA = "0x11E5714")]
		private void WriteChunkHeader(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11E5620", Offset = "0x11E5620", VA = "0x11E5620")]
		private void CopyBytes(long numBytes)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x11E4F44", Offset = "0x11E4F44", VA = "0x11E4F44")]
		private void WriteChunk_moov(Chunk parentChunk, ulong byteOffset)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11E54F8", Offset = "0x11E54F8", VA = "0x11E54F8")]
		private uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11E558C", Offset = "0x11E558C", VA = "0x11E558C")]
		private ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11E5774", Offset = "0x11E5774", VA = "0x11E5774")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11E5828", Offset = "0x11E5828", VA = "0x11E5828")]
		private void WriteUInt64(ulong value)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11E58D0", Offset = "0x11E58D0", VA = "0x11E58D0")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x11E5AC0", Offset = "0x11E5AC0", VA = "0x11E5AC0")]
		private static uint ChunkId(string id)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x11E4784", Offset = "0x11E4784", VA = "0x11E4784")]
		public MP4FileProcessing()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public enum StereoPacking
	{
		[Token(Token = "0x4000122")]
		None,
		[Token(Token = "0x4000123")]
		TopBottom,
		[Token(Token = "0x4000124")]
		LeftRight
	}
	[Token(Token = "0x2000020")]
	public enum StopMode
	{
		[Token(Token = "0x4000126")]
		None,
		[Token(Token = "0x4000127")]
		FramesEncoded,
		[Token(Token = "0x4000128")]
		SecondsEncoded,
		[Token(Token = "0x4000129")]
		SecondsElapsed
	}
	[Token(Token = "0x2000021")]
	public enum ImageSequenceFormat
	{
		[Token(Token = "0x400012B")]
		PNG
	}
	[Token(Token = "0x2000022")]
	public enum FileWriterType
	{
		[Token(Token = "0x400012D")]
		AVI,
		[Token(Token = "0x400012E")]
		MediaFoundation,
		[Token(Token = "0x400012F")]
		PNG
	}
	[Token(Token = "0x2000023")]
	public class NativePlugin
	{
		[Token(Token = "0x2000024")]
		public enum PixelFormat
		{
			[Token(Token = "0x4000136")]
			RGBA32,
			[Token(Token = "0x4000137")]
			BGRA32,
			[Token(Token = "0x4000138")]
			YCbCr422_YUY2,
			[Token(Token = "0x4000139")]
			YCbCr422_UYVY,
			[Token(Token = "0x400013A")]
			YCbCr422_HDYC
		}

		[Token(Token = "0x2000025")]
		public enum PluginEvent
		{
			[Token(Token = "0x400013C")]
			CaptureFrameBuffer,
			[Token(Token = "0x400013D")]
			FreeResources
		}

		[Token(Token = "0x4000130")]
		public const int PluginID = 262340608;

		[Token(Token = "0x4000131")]
		public const string ScriptVersion = "3.7.4";

		[Token(Token = "0x4000132")]
		public const string ExpectedPluginVersion = "3.7.4";

		[Token(Token = "0x4000133")]
		public const int MaxRenderWidth = 16384;

		[Token(Token = "0x4000134")]
		public const int MaxRenderHeight = 16384;

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x11D4324", Offset = "0x11D4324", VA = "0x11D4324")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x11D4398", Offset = "0x11D4398", VA = "0x11D4398")]
		public static extern IntPtr GetFreeResourcesEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x11D3E2C", Offset = "0x11D3E2C", VA = "0x11D3E2C")]
		public static extern bool Init();

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x11D4C50", Offset = "0x11D4C50", VA = "0x11D4C50")]
		public static extern void Deinit();

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x11D3DC0", Offset = "0x11D3DC0", VA = "0x11D3DC0")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x11E68C8", Offset = "0x11E68C8", VA = "0x11E68C8")]
		public static extern bool IsTrialVersion();

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x11D45EC", Offset = "0x11D45EC", VA = "0x11D45EC")]
		public static extern int GetNumAVIVideoCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x11DF9D4", Offset = "0x11DF9D4", VA = "0x11DF9D4")]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x11D8670", Offset = "0x11D8670", VA = "0x11D8670")]
		public static extern void ConfigureVideoCodec(int index);

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x11D4660", Offset = "0x11D4660", VA = "0x11D4660")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x11D4724", Offset = "0x11D4724", VA = "0x11D4724")]
		public static extern int GetNumAVIAudioCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x11DFA5C", Offset = "0x11DFA5C", VA = "0x11DFA5C")]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x11E3C70", Offset = "0x11E3C70", VA = "0x11E3C70")]
		public static extern void ConfigureAudioCodec(int index);

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x11D4798", Offset = "0x11D4798", VA = "0x11D4798")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x11D485C", Offset = "0x11D485C", VA = "0x11D485C")]
		public static extern int GetNumAVIAudioInputDevices();

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x11D48D0", Offset = "0x11D48D0", VA = "0x11D48D0")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x11D6C98", Offset = "0x11D6C98", VA = "0x11D6C98")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x11D6DE8", Offset = "0x11D6DE8", VA = "0x11D6DE8")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x11D6EF8", Offset = "0x11D6EF8", VA = "0x11D6EF8")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x11D6FE4", Offset = "0x11D6FE4", VA = "0x11D6FE4")]
		public static extern bool Start(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x11D7FF8", Offset = "0x11D7FF8", VA = "0x11D7FF8")]
		public static extern bool IsNewFrameDue(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x11D4F2C", Offset = "0x11D4F2C", VA = "0x11D4F2C")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x11D9480", Offset = "0x11D9480", VA = "0x11D9480")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x11D4FBC", Offset = "0x11D4FBC", VA = "0x11D4FBC")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x11D7114", Offset = "0x11D7114", VA = "0x11D7114")]
		public static extern void Pause(int handle);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x11D77D8", Offset = "0x11D77D8", VA = "0x11D77D8")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x11D93F4", Offset = "0x11D93F4", VA = "0x11D93F4")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x11D7868", Offset = "0x11D7868", VA = "0x11D7868")]
		public static extern void FreeRecorder(int handle);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x11D81D4", Offset = "0x11D81D4", VA = "0x11D81D4")]
		public static extern uint GetNumDroppedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x11D8254", Offset = "0x11D8254", VA = "0x11D8254")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x11D82D4", Offset = "0x11D82D4", VA = "0x11D82D4")]
		public static extern uint GetNumEncodedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x11D8354", Offset = "0x11D8354", VA = "0x11D8354")]
		public static extern uint GetEncodedSeconds(int handle);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x11E6854", Offset = "0x11E6854", VA = "0x11E6854")]
		private static extern IntPtr GetPluginVersion();

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x11E6944", Offset = "0x11E6944", VA = "0x11E6944")]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x11E6A08", Offset = "0x11E6A08", VA = "0x11E6A08")]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x11E6ACC", Offset = "0x11E6ACC", VA = "0x11E6ACC")]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x11E6B90", Offset = "0x11E6B90", VA = "0x11E6B90")]
		public NativePlugin()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Utils
	{
		[Serializable]
		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A84F4", Offset = "0x5A84F4")]
		private sealed class <>c
		{
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Camera> <>9__2_0;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x132F1E8", Offset = "0x132F1E8", VA = "0x132F1E8")]
			public <>c()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x132F1F0", Offset = "0x132F1F0", VA = "0x132F1F0")]
			internal int <FindContributingCameras>b__2_0(Camera a, Camera b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x132D120", Offset = "0x132D120", VA = "0x132D120")]
		public static Camera GetUltimateRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x132D2DC", Offset = "0x132D2DC", VA = "0x132D2DC")]
		public static bool HasContributingCameras(Camera parentCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x132D3A8", Offset = "0x132D3A8", VA = "0x132D3A8")]
		public static Camera[] FindContributingCameras(Camera parentCamera)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x132D8F8", Offset = "0x132D8F8", VA = "0x132D8F8")]
		public static bool ShowInExplorer(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x132D9E4", Offset = "0x132D9E4", VA = "0x132D9E4")]
		public static bool OpenInDefaultApp(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x132DAD0", Offset = "0x132DAD0", VA = "0x132DAD0")]
		public static long GetFileSize(string filename)
		{
			return default(long);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x132DB3C", Offset = "0x132DB3C", VA = "0x132DB3C")]
		public Utils()
		{
		}
	}
}
namespace RenderHeads.Media.AVProMovieCapture.Demos
{
	[Token(Token = "0x2000028")]
	public class ScreenCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip _audioBG;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _audioHit;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speed;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CaptureBase _capture;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GUISkin _guiSkin;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _spinCamera;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _timer;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x11E6B98", Offset = "0x11E6B98", VA = "0x11E6B98")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x11E6C2C", Offset = "0x11E6C2C", VA = "0x11E6C2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x11E6EA0", Offset = "0x11E6EA0", VA = "0x11E6EA0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x11E6F9C", Offset = "0x11E6F9C", VA = "0x11E6F9C")]
		public ScreenCaptureDemo()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class ScriptCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		private const string X264CodecName = "x264vfw - H.264/MPEG-4 AVC codec";

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _videoCodecIndex;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _encoderHandle;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x11E6FB4", Offset = "0x11E6FB4", VA = "0x11E6FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x11E7088", Offset = "0x11E7088", VA = "0x11E7088")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x11E708C", Offset = "0x11E708C", VA = "0x11E708C")]
		public void CreateVideoFromByteArray(string filePath, int width, int height, int frameRate)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x11E7024", Offset = "0x11E7024", VA = "0x11E7024")]
		private static int FindVideoCodecIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x11E71F0", Offset = "0x11E71F0", VA = "0x11E71F0")]
		public ScriptCaptureDemo()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class SurroundCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5A8504", Offset = "0x5A8504")]
		private sealed class <KillCube>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000151")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000152")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public GameObject go;

			[Token(Token = "0x17000022")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600012A")]
				[Address(RVA = "0x132F134", Offset = "0x132F134", VA = "0x132F134", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600012C")]
				[Address(RVA = "0x132F17C", Offset = "0x132F17C", VA = "0x132F17C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x132F02C", Offset = "0x132F02C", VA = "0x132F02C")]
			[DebuggerHidden]
			public <KillCube>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x132F058", Offset = "0x132F058", VA = "0x132F058", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x132F05C", Offset = "0x132F05C", VA = "0x132F05C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x132F13C", Offset = "0x132F13C", VA = "0x132F13C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _spawnPoint;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _cubePrefab;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _spawn;

		[Token(Token = "0x400014D")]
		private const int MaxCubes = 48;

		[Token(Token = "0x400014E")]
		private const float SpawnTime = 0.25f;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _timer;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GameObject> _cubes;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x11E71F8", Offset = "0x11E71F8", VA = "0x11E71F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x11E72A4", Offset = "0x11E72A4", VA = "0x11E72A4")]
		private void SpawnCube()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x11E74F8", Offset = "0x11E74F8", VA = "0x11E74F8")]
		private void RemoveCube()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x11E75EC", Offset = "0x11E75EC", VA = "0x11E75EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5A8F34", Offset = "0x5A8F34")]
		private IEnumerator KillCube(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x11E7664", Offset = "0x11E7664", VA = "0x11E7664")]
		public SurroundCaptureDemo()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class TextureCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _textureWidth;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _textureHeight;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CaptureFromTexture _movieCapture;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _material;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture _texture;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x132C144", Offset = "0x132C144", VA = "0x132C144")]
		private void Start()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x132C2E0", Offset = "0x132C2E0", VA = "0x132C2E0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x132C40C", Offset = "0x132C40C", VA = "0x132C40C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x132C410", Offset = "0x132C410", VA = "0x132C410")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x132C498", Offset = "0x132C498", VA = "0x132C498")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x132C644", Offset = "0x132C644", VA = "0x132C644")]
		public TextureCaptureDemo()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class WebcamCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		private class Instance
		{
			[Token(Token = "0x4000160")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			[Token(Token = "0x4000161")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WebCamTexture texture;

			[Token(Token = "0x4000162")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CaptureFromTexture capture;

			[Token(Token = "0x4000163")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CaptureGUI gui;

			[Token(Token = "0x600013B")]
			[Address(RVA = "0x132DDF4", Offset = "0x132DDF4", VA = "0x132DDF4")]
			public Instance()
			{
			}
		}

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GUISkin _skin;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _prefab;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _webcamResolutionWidth;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _webcamResolutionHeight;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _webcamFrameRate;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Instance[] _instances;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _selectedWebcamIndex;

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x132DB44", Offset = "0x132DB44", VA = "0x132DB44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x132DEE0", Offset = "0x132DEE0", VA = "0x132DEE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x132DFB8", Offset = "0x132DFB8", VA = "0x132DFB8")]
		private void StartWebcam(Instance instance)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x132E0B8", Offset = "0x132E0B8", VA = "0x132E0B8")]
		private void StopWebcam(Instance instance)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x132E200", Offset = "0x132E200", VA = "0x132E200")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x132DDFC", Offset = "0x132DDFC", VA = "0x132DDFC")]
		private void SelectWebcam(int index)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x132E268", Offset = "0x132E268", VA = "0x132E268")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x132EA28", Offset = "0x132EA28", VA = "0x132EA28")]
		public WebcamCaptureDemo()
		{
		}
	}
}
