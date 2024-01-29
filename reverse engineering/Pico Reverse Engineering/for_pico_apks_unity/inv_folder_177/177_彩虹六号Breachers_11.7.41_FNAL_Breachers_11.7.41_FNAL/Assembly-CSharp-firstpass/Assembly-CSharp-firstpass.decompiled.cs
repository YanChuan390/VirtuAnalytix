using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RenderHeads.Media.AVProMovieCapture
{
	[Token(Token = "0x2000002")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera", 1)]
	public class CaptureFromCamera : CaptureBase
	{
		[Token(Token = "0x2000003")]
		[CompilerGenerated]
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
				[Address(RVA = "0xFE697C", Offset = "0xFE697C", VA = "0xFE697C", Slot = "4")]
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
				[Address(RVA = "0xFE69C4", Offset = "0xFE69C4", VA = "0xFE69C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0xFE3F04", Offset = "0xFE3F04", VA = "0xFE3F04")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0xFE6914", Offset = "0xFE6914", VA = "0xFE6914", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0xFE6918", Offset = "0xFE6918", VA = "0xFE6918", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0xFE6984", Offset = "0xFE6984", VA = "0xFE6984", Slot = "8")]
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
			[Address(RVA = "0xFE39D4", Offset = "0xFE39D4", VA = "0xFE39D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0xFE39DC", Offset = "0xFE39DC", VA = "0xFE39DC")]
			set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xFE39E8", Offset = "0xFE39E8", VA = "0xFE39E8")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0xFE3AD8", Offset = "0xFE3AD8", VA = "0xFE3AD8")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xFE3B0C", Offset = "0xFE3B0C", VA = "0xFE3B0C")]
		private bool HasCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xFE3B6C", Offset = "0xFE3B6C", VA = "0xFE3B6C")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xFE3B94", Offset = "0xFE3B94", VA = "0xFE3B94", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xFE3BF8", Offset = "0xFE3BF8", VA = "0xFE3BF8")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__13))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xFE3D38", Offset = "0xFE3D38", VA = "0xFE3D38")]
		private void Capture()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xFE40A0", Offset = "0xFE40A0", VA = "0xFE40A0")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xFE46AC", Offset = "0xFE46AC", VA = "0xFE46AC", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xFE47E8", Offset = "0xFE47E8", VA = "0xFE47E8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xFE47F0", Offset = "0xFE47F0", VA = "0xFE47F0", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xFE63B0", Offset = "0xFE63B0", VA = "0xFE63B0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xFE64AC", Offset = "0xFE64AC", VA = "0xFE64AC")]
		public CaptureFromCamera()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 (VR)", 100)]
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
		[CompilerGenerated]
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
				[Address(RVA = "0xFE9060", Offset = "0xFE9060", VA = "0xFE9060", Slot = "4")]
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
				[Address(RVA = "0xFE90A8", Offset = "0xFE90A8", VA = "0xFE90A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0xFE6D60", Offset = "0xFE6D60", VA = "0xFE6D60")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0xFE8FF8", Offset = "0xFE8FF8", VA = "0xFE8FF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0xFE8FFC", Offset = "0xFE8FFC", VA = "0xFE8FFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0xFE9068", Offset = "0xFE9068", VA = "0xFE9068", Slot = "8")]
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
		[Tooltip("Render 180 degree equirectangular instead of 360 degrees")]
		public bool _render180Degrees;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		public StereoPacking _stereoRendering;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[Tooltip("Makes assumption that 1 Unity unit is 1m")]
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
		[Address(RVA = "0xFE69CC", Offset = "0xFE69CC", VA = "0xFE69CC")]
		public CaptureFromCamera360()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xFE6A44", Offset = "0xFE6A44", VA = "0xFE6A44")]
		private CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return default(CubemapRenderMethod);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xFE6A7C", Offset = "0xFE6A7C", VA = "0xFE6A7C")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xFE6A8C", Offset = "0xFE6A8C", VA = "0xFE6A8C", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xFE6ADC", Offset = "0xFE6ADC", VA = "0xFE6ADC")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__20))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xFE6B50", Offset = "0xFE6B50", VA = "0xFE6B50")]
		private void Capture()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xFE71C4", Offset = "0xFE71C4", VA = "0xFE71C4")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xFE7398", Offset = "0xFE7398", VA = "0xFE7398")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xFE6E54", Offset = "0xFE6E54", VA = "0xFE6E54")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xFE7518", Offset = "0xFE7518", VA = "0xFE7518")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xFE6D88", Offset = "0xFE6D88", VA = "0xFE6D88")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xFE7F24", Offset = "0xFE7F24", VA = "0xFE7F24", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xFE8B40", Offset = "0xFE8B40", VA = "0xFE8B40", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xFE8B70", Offset = "0xFE8B70", VA = "0xFE8B70", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xFE8E10", Offset = "0xFE8E10", VA = "0xFE8E10", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Camera 360 Stereo ODS (VR)", 101)]
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
			[Tooltip("Render 180 degree equirectangular instead of 360 degrees.  Also faster rendering")]
			[SerializeField]
			public bool render180Degrees;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes assumption that 1 Unity unit is 1m")]
			[SerializeField]
			public float ipd;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Tooltip("Higher value meant less slices to render, but can affect quality.")]
			public int pixelSliceSize;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[Range(1f, 31f)]
			[Tooltip("May need to be increased to work with some post image effects. Value is in pixels.")]
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
			[Address(RVA = "0xFE9194", Offset = "0xFE9194", VA = "0xFE9194")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x2000009")]
		[CompilerGenerated]
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
				[Address(RVA = "0xFEAEA4", Offset = "0xFEAEA4", VA = "0xFEAEA4", Slot = "4")]
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
				[Address(RVA = "0xFEAEEC", Offset = "0xFEAEEC", VA = "0xFEAEEC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0xFE9AE8", Offset = "0xFE9AE8", VA = "0xFE9AE8")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0xFEAE3C", Offset = "0xFEAE3C", VA = "0xFEAE3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0xFEAE40", Offset = "0xFEAE40", VA = "0xFEAE40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0xFEAEAC", Offset = "0xFEAEAC", VA = "0xFEAEAC", Slot = "8")]
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
			[Address(RVA = "0xFE90B0", Offset = "0xFE90B0", VA = "0xFE90B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xFE90B8", Offset = "0xFE90B8", VA = "0xFE90B8")]
		public CaptureFromCamera360ODS()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFE91C4", Offset = "0xFE91C4", VA = "0xFE91C4")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xFE91E0", Offset = "0xFE91E0", VA = "0xFE91E0", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xFE9328", Offset = "0xFE9328", VA = "0xFE9328")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFE9868", Offset = "0xFE9868", VA = "0xFE9868", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFE98B8", Offset = "0xFE98B8", VA = "0xFE98B8")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__20))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFE992C", Offset = "0xFE992C", VA = "0xFE992C")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFE9B10", Offset = "0xFE9B10", VA = "0xFE9B10")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFE9BE4", Offset = "0xFE9BE4", VA = "0xFE9BE4")]
		private void RenderFrame()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xFE9FF8", Offset = "0xFE9FF8", VA = "0xFE9FF8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xFEA028", Offset = "0xFEA028", VA = "0xFEA028", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xFEAB54", Offset = "0xFEAB54", VA = "0xFEAB54")]
		private static void DestroyEye(Camera camera)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xFEAC18", Offset = "0xFEAC18", VA = "0xFEAC18", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Screen", 0)]
	public class CaptureFromScreen : CaptureBase
	{
		[Token(Token = "0x200000B")]
		[CompilerGenerated]
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
				[Address(RVA = "0xFEB2EC", Offset = "0xFEB2EC", VA = "0xFEB2EC", Slot = "4")]
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
				[Address(RVA = "0xFEB334", Offset = "0xFEB334", VA = "0xFEB334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0xFEB134", Offset = "0xFEB134", VA = "0xFEB134")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0xFEB19C", Offset = "0xFEB19C", VA = "0xFEB19C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0xFEB1A0", Offset = "0xFEB1A0", VA = "0xFEB1A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0xFEB2F4", Offset = "0xFEB2F4", VA = "0xFEB2F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFEAEF4", Offset = "0xFEAEF4", VA = "0xFEAEF4", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFEB0C0", Offset = "0xFEB0C0", VA = "0xFEB0C0")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__1))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFEB15C", Offset = "0xFEB15C", VA = "0xFEB15C", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFEB198", Offset = "0xFEB198", VA = "0xFEB198")]
		public CaptureFromScreen()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AddComponentMenu("AVPro Movie Capture/Capture From Texture", 3)]
	public class CaptureFromTexture : CaptureBase
	{
		[Token(Token = "0x200000D")]
		[CompilerGenerated]
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
				[Address(RVA = "0xFEBEC4", Offset = "0xFEBEC4", VA = "0xFEBEC4", Slot = "4")]
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
				[Address(RVA = "0xFEBF0C", Offset = "0xFEBF0C", VA = "0xFEBF0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0xFEB9BC", Offset = "0xFEB9BC", VA = "0xFEB9BC")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0xFEBE5C", Offset = "0xFEBE5C", VA = "0xFEBE5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0xFEBE60", Offset = "0xFEBE60", VA = "0xFEBE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0xFEBECC", Offset = "0xFEBECC", VA = "0xFEBECC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[Tooltip("If enabled the method the encoder will only process frames each time UpdateSourceTexture() is called. This is useful if the texture is updating at a different rate compared to Unity, eg for webcam capture.")]
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
		[Address(RVA = "0xFEB33C", Offset = "0xFEB33C", VA = "0xFEB33C")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xFEB5E0", Offset = "0xFEB5E0", VA = "0xFEB5E0")]
		public void UpdateSourceTexture()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFEB5EC", Offset = "0xFEB5EC", VA = "0xFEB5EC")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xFEB66C", Offset = "0xFEB66C", VA = "0xFEB66C")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xFEB68C", Offset = "0xFEB68C", VA = "0xFEB68C", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xFEB6CC", Offset = "0xFEB6CC", VA = "0xFEB6CC")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__10))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xFEB740", Offset = "0xFEB740", VA = "0xFEB740")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xFEB9E4", Offset = "0xFEB9E4", VA = "0xFEB9E4")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xFEBA80", Offset = "0xFEBA80", VA = "0xFEBA80", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFEBB18", Offset = "0xFEBB18", VA = "0xFEBB18", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFEBD44", Offset = "0xFEBD44", VA = "0xFEBD44", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFEBE08", Offset = "0xFEBE08", VA = "0xFEBE08")]
		public CaptureFromTexture()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AddComponentMenu("AVPro Movie Capture/Capture GUI", 300)]
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
		[Address(RVA = "0xFEBF14", Offset = "0xFEBF14", VA = "0xFEBF14")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xFEBF8C", Offset = "0xFEBF8C", VA = "0xFEBF8C")]
		private void CreateGUI()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xFED454", Offset = "0xFED454", VA = "0xFED454")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xFED6F0", Offset = "0xFED6F0", VA = "0xFED6F0")]
		private void MyWindow(int id)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFEF4B4", Offset = "0xFEF4B4", VA = "0xFEF4B4")]
		private void GUI_RecordingStatus()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xFF070C", Offset = "0xFF070C", VA = "0xFF070C")]
		private void DrawGuiField(string a, string b)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFF0614", Offset = "0xFF0614", VA = "0xFF0614")]
		private void StartCapture()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xFF09C4", Offset = "0xFF09C4", VA = "0xFF09C4")]
		private void StopCapture()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xFF0944", Offset = "0xFF0944", VA = "0xFF0944")]
		private void CancelCapture()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xFF08C4", Offset = "0xFF08C4", VA = "0xFF08C4")]
		private void ResumeCapture()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFF0844", Offset = "0xFF0844", VA = "0xFF0844")]
		private void PauseCapture()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFF0CDC", Offset = "0xFF0CDC", VA = "0xFF0CDC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xFF0F5C", Offset = "0xFF0F5C", VA = "0xFF0F5C")]
		public CaptureGUI()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AddComponentMenu("AVPro Movie Capture/Motion Blur", 301)]
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
			[Address(RVA = "0xFF10AC", Offset = "0xFF10AC", VA = "0xFF10AC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xFF10B4", Offset = "0xFF10B4", VA = "0xFF10B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int NumSamples
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xFF10C0", Offset = "0xFF10C0", VA = "0xFF10C0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xFF10C8", Offset = "0xFF10C8", VA = "0xFF10C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int FrameCount
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xFF119C", Offset = "0xFF119C", VA = "0xFF119C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xFF11A4", Offset = "0xFF11A4", VA = "0xFF11A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFF11AC", Offset = "0xFF11AC", VA = "0xFF11AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFF1250", Offset = "0xFF1250", VA = "0xFF1250")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFF1278", Offset = "0xFF1278", VA = "0xFF1278")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFF15C0", Offset = "0xFF15C0", VA = "0xFF15C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFF127C", Offset = "0xFF127C", VA = "0xFF127C")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFF15CC", Offset = "0xFF15CC", VA = "0xFF15CC")]
		private void ClearAccumulation()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xFF1620", Offset = "0xFF1620", VA = "0xFF1620")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFF10D0", Offset = "0xFF10D0", VA = "0xFF10D0")]
		public void OnNumSamplesChanged()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFF1804", Offset = "0xFF1804", VA = "0xFF1804")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFF1814", Offset = "0xFF1814", VA = "0xFF1814")]
		private void ApplyWeighting()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xFE7E38", Offset = "0xFE7E38", VA = "0xFE7E38")]
		public void Accumulate(Texture src)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFF18E0", Offset = "0xFF18E0", VA = "0xFF18E0")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFF195C", Offset = "0xFF195C", VA = "0xFF195C")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AddComponentMenu("AVPro Movie Capture/Mouse Cursor", 302)]
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
		[Range(1f, 16f)]
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
		[Address(RVA = "0xFF1978", Offset = "0xFF1978", VA = "0xFF1978")]
		private void Start()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFF1980", Offset = "0xFF1980", VA = "0xFF1980")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFF1A50", Offset = "0xFF1A50", VA = "0xFF1A50")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFF1B68", Offset = "0xFF1B68", VA = "0xFF1B68")]
		public MouseCursor()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AddComponentMenu("AVPro Movie Capture/Unity Audio Capture", 500)]
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
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GCHandle _bufferHandle;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _numChannels;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _overflowCount;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object _lockObject;

		[Token(Token = "0x17000011")]
		public float[] Buffer
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xFF1BCC", Offset = "0xFF1BCC", VA = "0xFF1BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public int BufferLength
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xFF1BD4", Offset = "0xFF1BD4", VA = "0xFF1BD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public int NumChannels
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xFF1BDC", Offset = "0xFF1BDC", VA = "0xFF1BDC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xFF1BE4", Offset = "0xFF1BE4", VA = "0xFF1BE4")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000015")]
		public int OverflowCount
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xFF1BF0", Offset = "0xFF1BF0", VA = "0xFF1BF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFF1BF8", Offset = "0xFF1BF8", VA = "0xFF1BF8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xFF1FF4", Offset = "0xFF1FF4", VA = "0xFF1FF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xFE452C", Offset = "0xFE452C", VA = "0xFE452C")]
		public IntPtr ReadData(out int length)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xFF2114", Offset = "0xFF2114", VA = "0xFF2114")]
		public void FlushBuffer()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFF21D0", Offset = "0xFF21D0", VA = "0xFF21D0")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFF1FD0", Offset = "0xFF1FD0", VA = "0xFF1FD0")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFF240C", Offset = "0xFF240C", VA = "0xFF240C")]
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
			[SerializeField]
			[Tooltip("Move the 'moov' atom in the MP4 file from the end to the start of the file to make streaming start fast.  Also called 'Fast Start' in some encoders")]
			public bool writeFastStartStreamingForMp4;

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xFF4004", Offset = "0xFF4004", VA = "0xFF4004")]
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
		[Tooltip("Timelapse scale makes the frame capture run at a fraction of the target frame rate.  Default value is 1")]
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
		[SerializeField]
		[Tooltip("Flushing the GPU during each capture results in less latency, but can slow down rendering performance for complex scenes.")]
		private bool _forceGpuFlush;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[Tooltip("This option can help issues where skinning is used, or other animation/rendering effects that only complete later in the frame.")]
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
		[Range(2f, 12f)]
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
		[Range(0f, 64f)]
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
			[Address(RVA = "0xFF24D4", Offset = "0xFF24D4", VA = "0xFF24D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xFF24DC", Offset = "0xFF24DC", VA = "0xFF24DC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000018")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xFF24E4", Offset = "0xFF24E4", VA = "0xFF24E4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000019")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xFF24EC", Offset = "0xFF24EC", VA = "0xFF24EC")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001A")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xFF24F4", Offset = "0xFF24F4", VA = "0xFF24F4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001B")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xFF24FC", Offset = "0xFF24FC", VA = "0xFF24FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xFF2504", Offset = "0xFF2504", VA = "0xFF2504")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int TimelapseScale
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xFF2524", Offset = "0xFF2524", VA = "0xFF2524")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xFF252C", Offset = "0xFF252C", VA = "0xFF252C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xFF2534", Offset = "0xFF2534", VA = "0xFF2534")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xFF253C", Offset = "0xFF253C", VA = "0xFF253C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public PostCaptureSettings PostCapture
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xFF2548", Offset = "0xFF2548", VA = "0xFF2548")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static string LastFileSaved
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xFF06A8", Offset = "0xFF06A8", VA = "0xFF06A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xFF374C", Offset = "0xFF374C", VA = "0xFF374C")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float FPS
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xFF3FB8", Offset = "0xFF3FB8", VA = "0xFF3FB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float FramesTotal
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xFF3FC0", Offset = "0xFF3FC0", VA = "0xFF3FC0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFF2550", Offset = "0xFF2550", VA = "0xFF2550", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFF2D54", Offset = "0xFF2D54", VA = "0xFF2D54")]
		protected void SetupRenderFunctions()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFE8D80", Offset = "0xFE8D80", VA = "0xFE8D80", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFECD7C", Offset = "0xFECD7C", VA = "0xFECD7C")]
		public void SelectCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFED04C", Offset = "0xFED04C", VA = "0xFED04C")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFED2E8", Offset = "0xFED2E8", VA = "0xFED2E8")]
		public void SelectAudioDevice(bool display)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFF2D7C", Offset = "0xFF2D7C", VA = "0xFF2D7C")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xFE4FD8", Offset = "0xFE4FD8", VA = "0xFE4FD8")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xFE647C", Offset = "0xFE647C", VA = "0xFE647C", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFF2EAC", Offset = "0xFF2EAC", VA = "0xFF2EAC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFF2F24", Offset = "0xFF2F24", VA = "0xFF2F24")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFF2FA0", Offset = "0xFF2FA0", VA = "0xFF2FA0")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFE44F8", Offset = "0xFE44F8", VA = "0xFE44F8")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFE3F58", Offset = "0xFE3F58", VA = "0xFE3F58")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFF3028", Offset = "0xFF3028", VA = "0xFF3028", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFF30A8", Offset = "0xFF30A8", VA = "0xFF30A8")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFF30B0", Offset = "0xFF30B0", VA = "0xFF30B0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFF30B8", Offset = "0xFF30B8", VA = "0xFF30B8")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFF30C0", Offset = "0xFF30C0", VA = "0xFF30C0")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFF30C8", Offset = "0xFF30C8", VA = "0xFF30C8", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xFF349C", Offset = "0xFF349C", VA = "0xFF349C")]
		private static string GetFolder(OutputPath outputPathType, string path)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFF35AC", Offset = "0xFF35AC", VA = "0xFF35AC")]
		private static string AutoGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xFF362C", Offset = "0xFF362C", VA = "0xFF362C")]
		private static string ManualGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFF36E0", Offset = "0xFF36E0", VA = "0xFF36E0")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFE510C", Offset = "0xFE510C", VA = "0xFE510C")]
		protected void GenerateFilename()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFE5544", Offset = "0xFE5544", VA = "0xFE5544", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFF3710", Offset = "0xFF3710", VA = "0xFF3710")]
		public void QueueStartCapture()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFF0A50", Offset = "0xFF0A50", VA = "0xFF0A50")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFF0C6C", Offset = "0xFF0C6C", VA = "0xFF0C6C")]
		public void PauseCapture()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFF0BE0", Offset = "0xFF0BE0", VA = "0xFF0BE0")]
		public void ResumeCapture()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFF0B98", Offset = "0xFF0B98", VA = "0xFF0B98")]
		public void CancelCapture()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xFE4760", Offset = "0xFE4760", VA = "0xFE4760", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xFE4438", Offset = "0xFE4438", VA = "0xFE4438")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xFF3798", Offset = "0xFF3798", VA = "0xFF3798", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xFF3A5C", Offset = "0xFF3A5C", VA = "0xFF3A5C")]
		protected void ApplyPostOperations(string path)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xFF3DD0", Offset = "0xFF3DD0", VA = "0xFF3DD0")]
		private void ToggleCapture()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xFF3DEC", Offset = "0xFF3DEC", VA = "0xFF3DEC")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xFF3DF4", Offset = "0xFF3DF4", VA = "0xFF3DF4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xFF3E58", Offset = "0xFF3E58", VA = "0xFF3E58")]
		private void CheckFreeDiskSpace()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xFF3E90", Offset = "0xFF3E90", VA = "0xFF3E90")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xFF3F1C", Offset = "0xFF3F1C", VA = "0xFF3F1C")]
		public float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xFF3724", Offset = "0xFF3724", VA = "0xFF3724")]
		protected float GetSecondsPerCaptureFrame()
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xFE3FD8", Offset = "0xFE3FD8", VA = "0xFE3FD8")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xFE3F2C", Offset = "0xFE3F2C", VA = "0xFE3F2C")]
		protected void TickFrameTimer()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xFE4670", Offset = "0xFE4670", VA = "0xFE4670")]
		protected void RenormTimer()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xFF3FB0", Offset = "0xFF3FB0", VA = "0xFF3FB0", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xFE3C6C", Offset = "0xFE3C6C", VA = "0xFE3C6C", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xFF371C", Offset = "0xFF371C", VA = "0xFF371C")]
		protected void ResetFPS()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xFE4618", Offset = "0xFE4618", VA = "0xFE4618")]
		public void UpdateFPS()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xFE4E20", Offset = "0xFE4E20", VA = "0xFE4E20")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xFF3FCC", Offset = "0xFF3FCC", VA = "0xFF3FCC")]
		private void ConfigureCodec()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xFF0E90", Offset = "0xFF0E90", VA = "0xFF0E90")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xFE4DF4", Offset = "0xFE4DF4", VA = "0xFE4DF4")]
		public static void GetResolution(Resolution res, ref int width, ref int height)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xFF2EA0", Offset = "0xFF2EA0", VA = "0xFF2EA0")]
		protected static int NextMultipleOf4(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xFE6508", Offset = "0xFE6508", VA = "0xFE6508")]
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

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xFF59A0", Offset = "0xFF59A0", VA = "0xFF59A0")]
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

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xFF3BE0", Offset = "0xFF3BE0", VA = "0xFF3BE0")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xFF4014", Offset = "0xFF4014", VA = "0xFF4014")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xFF43E4", Offset = "0xFF43E4", VA = "0xFF43E4")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xFF472C", Offset = "0xFF472C", VA = "0xFF472C")]
		public void Close()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xFF4980", Offset = "0xFF4980", VA = "0xFF4980")]
		private static Chunk GetFirstChunkOfType(uint id, List<Chunk> chunks)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xFF4764", Offset = "0xFF4764", VA = "0xFF4764")]
		private List<Chunk> ReadChildChunks(Chunk parentChunk)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xFF502C", Offset = "0xFF502C", VA = "0xFF502C")]
		private Chunk ReadChunkHeader()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xFF4AD8", Offset = "0xFF4AD8", VA = "0xFF4AD8")]
		private bool ChunkContainsChildChunkWithId(Chunk chunk, uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xFF4FD0", Offset = "0xFF4FD0", VA = "0xFF4FD0")]
		private void WriteChunk(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xFF53B4", Offset = "0xFF53B4", VA = "0xFF53B4")]
		private void WriteChunkHeader(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFF52CC", Offset = "0xFF52CC", VA = "0xFF52CC")]
		private void CopyBytes(long numBytes)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFF4BDC", Offset = "0xFF4BDC", VA = "0xFF4BDC")]
		private void WriteChunk_moov(Chunk parentChunk, ulong byteOffset)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xFF5194", Offset = "0xFF5194", VA = "0xFF5194")]
		private uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xFF5230", Offset = "0xFF5230", VA = "0xFF5230")]
		private ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xFF5410", Offset = "0xFF5410", VA = "0xFF5410")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xFF54CC", Offset = "0xFF54CC", VA = "0xFF54CC")]
		private void WriteUInt64(ulong value)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xFF557C", Offset = "0xFF557C", VA = "0xFF557C")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xFF5758", Offset = "0xFF5758", VA = "0xFF5758")]
		private static uint ChunkId(string id)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xFF43DC", Offset = "0xFF43DC", VA = "0xFF43DC")]
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
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xFF59A8", Offset = "0xFF59A8", VA = "0xFF59A8")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFF5A10", Offset = "0xFF5A10", VA = "0xFF5A10")]
		public static extern IntPtr GetFreeResourcesEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFF5A78", Offset = "0xFF5A78", VA = "0xFF5A78")]
		public static extern bool Init();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFF5AE8", Offset = "0xFF5AE8", VA = "0xFF5AE8")]
		public static extern void Deinit();

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFF5B4C", Offset = "0xFF5B4C", VA = "0xFF5B4C")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xFF5C14", Offset = "0xFF5C14", VA = "0xFF5C14")]
		public static extern bool IsTrialVersion();

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xFF5C84", Offset = "0xFF5C84", VA = "0xFF5C84")]
		public static extern int GetNumAVIVideoCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xFF5CEC", Offset = "0xFF5CEC", VA = "0xFF5CEC")]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xFF5D70", Offset = "0xFF5D70", VA = "0xFF5D70")]
		public static extern void ConfigureVideoCodec(int index);

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFF5DEC", Offset = "0xFF5DEC", VA = "0xFF5DEC")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xFF5F6C", Offset = "0xFF5F6C", VA = "0xFF5F6C")]
		public static extern int GetNumAVIAudioCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFF5FD4", Offset = "0xFF5FD4", VA = "0xFF5FD4")]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFF6058", Offset = "0xFF6058", VA = "0xFF6058")]
		public static extern void ConfigureAudioCodec(int index);

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xFF60D4", Offset = "0xFF60D4", VA = "0xFF60D4")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xFF6254", Offset = "0xFF6254", VA = "0xFF6254")]
		public static extern int GetNumAVIAudioInputDevices();

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFF62BC", Offset = "0xFF62BC", VA = "0xFF62BC")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xFF643C", Offset = "0xFF643C", VA = "0xFF643C")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xFF6590", Offset = "0xFF6590", VA = "0xFF6590")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xFF6690", Offset = "0xFF6690", VA = "0xFF6690")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFF6764", Offset = "0xFF6764", VA = "0xFF6764")]
		public static extern bool Start(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFF67E8", Offset = "0xFF67E8", VA = "0xFF67E8")]
		public static extern bool IsNewFrameDue(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xFF686C", Offset = "0xFF686C", VA = "0xFF686C")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xFF68F0", Offset = "0xFF68F0", VA = "0xFF68F0")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xFF6984", Offset = "0xFF6984", VA = "0xFF6984")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFF6A20", Offset = "0xFF6A20", VA = "0xFF6A20")]
		public static extern void Pause(int handle);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFF6A9C", Offset = "0xFF6A9C", VA = "0xFF6A9C")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFF6B20", Offset = "0xFF6B20", VA = "0xFF6B20")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xFF6BA0", Offset = "0xFF6BA0", VA = "0xFF6BA0")]
		public static extern void FreeRecorder(int handle);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xFF6C1C", Offset = "0xFF6C1C", VA = "0xFF6C1C")]
		public static extern uint GetNumDroppedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xFF6C98", Offset = "0xFF6C98", VA = "0xFF6C98")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xFF6D14", Offset = "0xFF6D14", VA = "0xFF6D14")]
		public static extern uint GetNumEncodedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xFF6D90", Offset = "0xFF6D90", VA = "0xFF6D90")]
		public static extern uint GetEncodedSeconds(int handle);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xFF5BAC", Offset = "0xFF5BAC", VA = "0xFF5BAC")]
		private static extern IntPtr GetPluginVersion();

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xFF5EAC", Offset = "0xFF5EAC", VA = "0xFF5EAC")]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0xFF6194", Offset = "0xFF6194", VA = "0xFF6194")]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0xFF637C", Offset = "0xFF637C", VA = "0xFF637C")]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xFF6E08", Offset = "0xFF6E08", VA = "0xFF6E08")]
		public NativePlugin()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Utils
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xFF6E10", Offset = "0xFF6E10", VA = "0xFF6E10")]
		public static Camera GetUltimateRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xFF6FA8", Offset = "0xFF6FA8", VA = "0xFF6FA8")]
		public static bool HasContributingCameras(Camera parentCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFF7068", Offset = "0xFF7068", VA = "0xFF7068")]
		public static Camera[] FindContributingCameras(Camera parentCamera)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFF7588", Offset = "0xFF7588", VA = "0xFF7588")]
		public static bool ShowInExplorer(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFF7668", Offset = "0xFF7668", VA = "0xFF7668")]
		public static bool OpenInDefaultApp(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFF7748", Offset = "0xFF7748", VA = "0xFF7748")]
		public static long GetFileSize(string filename)
		{
			return default(long);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFF77B0", Offset = "0xFF77B0", VA = "0xFF77B0")]
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

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xFF7BA0", Offset = "0xFF7BA0", VA = "0xFF7BA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xFF7C58", Offset = "0xFF7C58", VA = "0xFF7C58")]
		private void Update()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xFF7F00", Offset = "0xFF7F00", VA = "0xFF7F00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xFF7FF0", Offset = "0xFF7FF0", VA = "0xFF7FF0")]
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

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFF8008", Offset = "0xFF8008", VA = "0xFF8008")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFF80CC", Offset = "0xFF80CC", VA = "0xFF80CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFF80D0", Offset = "0xFF80D0", VA = "0xFF80D0")]
		public void CreateVideoFromByteArray(string filePath, int width, int height, int frameRate)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xFF8074", Offset = "0xFF8074", VA = "0xFF8074")]
		private static int FindVideoCodecIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xFF8230", Offset = "0xFF8230", VA = "0xFF8230")]
		public ScriptCaptureDemo()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class SurroundCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		[CompilerGenerated]
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
				[Token(Token = "0x6000129")]
				[Address(RVA = "0xFF88AC", Offset = "0xFF88AC", VA = "0xFF88AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000023")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0xFF88F4", Offset = "0xFF88F4", VA = "0xFF88F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0xFF8710", Offset = "0xFF8710", VA = "0xFF8710")]
			[DebuggerHidden]
			public <KillCube>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0xFF87D4", Offset = "0xFF87D4", VA = "0xFF87D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0xFF87D8", Offset = "0xFF87D8", VA = "0xFF87D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0xFF88B4", Offset = "0xFF88B4", VA = "0xFF88B4", Slot = "8")]
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

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xFF8238", Offset = "0xFF8238", VA = "0xFF8238")]
		private void Update()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xFF82E0", Offset = "0xFF82E0", VA = "0xFF82E0")]
		private void SpawnCube()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xFF85A0", Offset = "0xFF85A0", VA = "0xFF85A0")]
		private void RemoveCube()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xFF869C", Offset = "0xFF869C", VA = "0xFF869C")]
		[IteratorStateMachine(typeof(<KillCube>d__10))]
		private IEnumerator KillCube(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xFF8738", Offset = "0xFF8738", VA = "0xFF8738")]
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

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFF88FC", Offset = "0xFF88FC", VA = "0xFF88FC")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFF8A88", Offset = "0xFF8A88", VA = "0xFF8A88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFF8B90", Offset = "0xFF8B90", VA = "0xFF8B90")]
		private void Update()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFF8B94", Offset = "0xFF8B94", VA = "0xFF8B94")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFF8C08", Offset = "0xFF8C08", VA = "0xFF8C08")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFF8DA0", Offset = "0xFF8DA0", VA = "0xFF8DA0")]
		public TextureCaptureDemo()
		{
		}
	}
}
