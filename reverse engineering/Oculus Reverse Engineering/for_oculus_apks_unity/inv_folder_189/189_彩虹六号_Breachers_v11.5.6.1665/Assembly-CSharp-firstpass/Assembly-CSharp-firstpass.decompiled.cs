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
				[Address(RVA = "0x1041C40", Offset = "0x1041C40", VA = "0x1041C40", Slot = "4")]
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
				[Address(RVA = "0x1041C88", Offset = "0x1041C88", VA = "0x1041C88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x103F1C8", Offset = "0x103F1C8", VA = "0x103F1C8")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1041BD8", Offset = "0x1041BD8", VA = "0x1041BD8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1041BDC", Offset = "0x1041BDC", VA = "0x1041BDC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1041C48", Offset = "0x1041C48", VA = "0x1041C48", Slot = "8")]
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
			[Address(RVA = "0x103EC98", Offset = "0x103EC98", VA = "0x103EC98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x103ECA0", Offset = "0x103ECA0", VA = "0x103ECA0")]
			set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x103ECAC", Offset = "0x103ECAC", VA = "0x103ECAC")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x103ED9C", Offset = "0x103ED9C", VA = "0x103ED9C")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x103EDD0", Offset = "0x103EDD0", VA = "0x103EDD0")]
		private bool HasCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x103EE30", Offset = "0x103EE30", VA = "0x103EE30")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x103EE58", Offset = "0x103EE58", VA = "0x103EE58", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x103EEBC", Offset = "0x103EEBC", VA = "0x103EEBC")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__13))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x103EFFC", Offset = "0x103EFFC", VA = "0x103EFFC")]
		private void Capture()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x103F364", Offset = "0x103F364", VA = "0x103F364")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x103F970", Offset = "0x103F970", VA = "0x103F970", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x103FAAC", Offset = "0x103FAAC", VA = "0x103FAAC", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x103FAB4", Offset = "0x103FAB4", VA = "0x103FAB4", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1041674", Offset = "0x1041674", VA = "0x1041674", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1041770", Offset = "0x1041770", VA = "0x1041770")]
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
				[Address(RVA = "0x1044324", Offset = "0x1044324", VA = "0x1044324", Slot = "4")]
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
				[Address(RVA = "0x104436C", Offset = "0x104436C", VA = "0x104436C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1042024", Offset = "0x1042024", VA = "0x1042024")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x10442BC", Offset = "0x10442BC", VA = "0x10442BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x10442C0", Offset = "0x10442C0", VA = "0x10442C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x104432C", Offset = "0x104432C", VA = "0x104432C", Slot = "8")]
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
		[Address(RVA = "0x1041C90", Offset = "0x1041C90", VA = "0x1041C90")]
		public CaptureFromCamera360()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1041D08", Offset = "0x1041D08", VA = "0x1041D08")]
		private CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return default(CubemapRenderMethod);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1041D40", Offset = "0x1041D40", VA = "0x1041D40")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1041D50", Offset = "0x1041D50", VA = "0x1041D50", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1041DA0", Offset = "0x1041DA0", VA = "0x1041DA0")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__20))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1041E14", Offset = "0x1041E14", VA = "0x1041E14")]
		private void Capture()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1042488", Offset = "0x1042488", VA = "0x1042488")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x104265C", Offset = "0x104265C", VA = "0x104265C")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1042118", Offset = "0x1042118", VA = "0x1042118")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10427DC", Offset = "0x10427DC", VA = "0x10427DC")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x104204C", Offset = "0x104204C", VA = "0x104204C")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x10431E8", Offset = "0x10431E8", VA = "0x10431E8", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1043E04", Offset = "0x1043E04", VA = "0x1043E04", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1043E34", Offset = "0x1043E34", VA = "0x1043E34", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x10440D4", Offset = "0x10440D4", VA = "0x10440D4", Slot = "6")]
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
			[Address(RVA = "0x1044458", Offset = "0x1044458", VA = "0x1044458")]
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
				[Address(RVA = "0x1046168", Offset = "0x1046168", VA = "0x1046168", Slot = "4")]
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
				[Address(RVA = "0x10461B0", Offset = "0x10461B0", VA = "0x10461B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1044DAC", Offset = "0x1044DAC", VA = "0x1044DAC")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1046100", Offset = "0x1046100", VA = "0x1046100", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1046104", Offset = "0x1046104", VA = "0x1046104", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x1046170", Offset = "0x1046170", VA = "0x1046170", Slot = "8")]
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
			[Address(RVA = "0x1044374", Offset = "0x1044374", VA = "0x1044374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x104437C", Offset = "0x104437C", VA = "0x104437C")]
		public CaptureFromCamera360ODS()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1044488", Offset = "0x1044488", VA = "0x1044488")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x10444A4", Offset = "0x10444A4", VA = "0x10444A4", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x10445EC", Offset = "0x10445EC", VA = "0x10445EC")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1044B2C", Offset = "0x1044B2C", VA = "0x1044B2C", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1044B7C", Offset = "0x1044B7C", VA = "0x1044B7C")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__20))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1044BF0", Offset = "0x1044BF0", VA = "0x1044BF0")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1044DD4", Offset = "0x1044DD4", VA = "0x1044DD4")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1044EA8", Offset = "0x1044EA8", VA = "0x1044EA8")]
		private void RenderFrame()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x10452BC", Offset = "0x10452BC", VA = "0x10452BC", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x10452EC", Offset = "0x10452EC", VA = "0x10452EC", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1045E18", Offset = "0x1045E18", VA = "0x1045E18")]
		private static void DestroyEye(Camera camera)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1045EDC", Offset = "0x1045EDC", VA = "0x1045EDC", Slot = "6")]
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
				[Address(RVA = "0x10465B0", Offset = "0x10465B0", VA = "0x10465B0", Slot = "4")]
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
				[Address(RVA = "0x10465F8", Offset = "0x10465F8", VA = "0x10465F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x10463F8", Offset = "0x10463F8", VA = "0x10463F8")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x1046460", Offset = "0x1046460", VA = "0x1046460", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1046464", Offset = "0x1046464", VA = "0x1046464", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x10465B8", Offset = "0x10465B8", VA = "0x10465B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10461B8", Offset = "0x10461B8", VA = "0x10461B8", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1046384", Offset = "0x1046384", VA = "0x1046384")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__1))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1046420", Offset = "0x1046420", VA = "0x1046420", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x104645C", Offset = "0x104645C", VA = "0x104645C")]
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
				[Address(RVA = "0x1047188", Offset = "0x1047188", VA = "0x1047188", Slot = "4")]
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
				[Address(RVA = "0x10471D0", Offset = "0x10471D0", VA = "0x10471D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1046C80", Offset = "0x1046C80", VA = "0x1046C80")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1047120", Offset = "0x1047120", VA = "0x1047120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1047124", Offset = "0x1047124", VA = "0x1047124", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x1047190", Offset = "0x1047190", VA = "0x1047190", Slot = "8")]
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
		[Address(RVA = "0x1046600", Offset = "0x1046600", VA = "0x1046600")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x10468A4", Offset = "0x10468A4", VA = "0x10468A4")]
		public void UpdateSourceTexture()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x10468B0", Offset = "0x10468B0", VA = "0x10468B0")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1046930", Offset = "0x1046930", VA = "0x1046930")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1046950", Offset = "0x1046950", VA = "0x1046950", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1046990", Offset = "0x1046990", VA = "0x1046990")]
		[IteratorStateMachine(typeof(<FinalRenderCapture>d__10))]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1046A04", Offset = "0x1046A04", VA = "0x1046A04")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1046CA8", Offset = "0x1046CA8", VA = "0x1046CA8")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1046D44", Offset = "0x1046D44", VA = "0x1046D44", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1046DDC", Offset = "0x1046DDC", VA = "0x1046DDC", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1047008", Offset = "0x1047008", VA = "0x1047008", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x10470CC", Offset = "0x10470CC", VA = "0x10470CC")]
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
		[Address(RVA = "0x10471D8", Offset = "0x10471D8", VA = "0x10471D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1047250", Offset = "0x1047250", VA = "0x1047250")]
		private void CreateGUI()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1048718", Offset = "0x1048718", VA = "0x1048718")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x10489B4", Offset = "0x10489B4", VA = "0x10489B4")]
		private void MyWindow(int id)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x104A778", Offset = "0x104A778", VA = "0x104A778")]
		private void GUI_RecordingStatus()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x104B9D0", Offset = "0x104B9D0", VA = "0x104B9D0")]
		private void DrawGuiField(string a, string b)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x104B8D8", Offset = "0x104B8D8", VA = "0x104B8D8")]
		private void StartCapture()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x104BC88", Offset = "0x104BC88", VA = "0x104BC88")]
		private void StopCapture()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x104BC08", Offset = "0x104BC08", VA = "0x104BC08")]
		private void CancelCapture()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x104BB88", Offset = "0x104BB88", VA = "0x104BB88")]
		private void ResumeCapture()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x104BB08", Offset = "0x104BB08", VA = "0x104BB08")]
		private void PauseCapture()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x104BFA0", Offset = "0x104BFA0", VA = "0x104BFA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x104C220", Offset = "0x104C220", VA = "0x104C220")]
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
			[Address(RVA = "0x104C370", Offset = "0x104C370", VA = "0x104C370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x104C378", Offset = "0x104C378", VA = "0x104C378")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int NumSamples
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x104C384", Offset = "0x104C384", VA = "0x104C384")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x104C38C", Offset = "0x104C38C", VA = "0x104C38C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int FrameCount
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x104C460", Offset = "0x104C460", VA = "0x104C460")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x104C468", Offset = "0x104C468", VA = "0x104C468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x104C470", Offset = "0x104C470", VA = "0x104C470")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x104C514", Offset = "0x104C514", VA = "0x104C514")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x104C53C", Offset = "0x104C53C", VA = "0x104C53C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x104C884", Offset = "0x104C884", VA = "0x104C884")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x104C540", Offset = "0x104C540", VA = "0x104C540")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x104C890", Offset = "0x104C890", VA = "0x104C890")]
		private void ClearAccumulation()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x104C8E4", Offset = "0x104C8E4", VA = "0x104C8E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x104C394", Offset = "0x104C394", VA = "0x104C394")]
		public void OnNumSamplesChanged()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x104CAC8", Offset = "0x104CAC8", VA = "0x104CAC8")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x104CAD8", Offset = "0x104CAD8", VA = "0x104CAD8")]
		private void ApplyWeighting()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x10430FC", Offset = "0x10430FC", VA = "0x10430FC")]
		public void Accumulate(Texture src)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x104CBA4", Offset = "0x104CBA4", VA = "0x104CBA4")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x104CC20", Offset = "0x104CC20", VA = "0x104CC20")]
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
		[Address(RVA = "0x104CC3C", Offset = "0x104CC3C", VA = "0x104CC3C")]
		private void Start()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x104CC44", Offset = "0x104CC44", VA = "0x104CC44")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x104CD14", Offset = "0x104CD14", VA = "0x104CD14")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x104CE2C", Offset = "0x104CE2C", VA = "0x104CE2C")]
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
			[Address(RVA = "0x104CE90", Offset = "0x104CE90", VA = "0x104CE90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public int BufferLength
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x104CE98", Offset = "0x104CE98", VA = "0x104CE98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public int NumChannels
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x104CEA0", Offset = "0x104CEA0", VA = "0x104CEA0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x104CEA8", Offset = "0x104CEA8", VA = "0x104CEA8")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000015")]
		public int OverflowCount
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x104CEB4", Offset = "0x104CEB4", VA = "0x104CEB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x104CEBC", Offset = "0x104CEBC", VA = "0x104CEBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x104D2B8", Offset = "0x104D2B8", VA = "0x104D2B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x103F7F0", Offset = "0x103F7F0", VA = "0x103F7F0")]
		public IntPtr ReadData(out int length)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x104D3D8", Offset = "0x104D3D8", VA = "0x104D3D8")]
		public void FlushBuffer()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x104D494", Offset = "0x104D494", VA = "0x104D494")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x104D294", Offset = "0x104D294", VA = "0x104D294")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x104D6D0", Offset = "0x104D6D0", VA = "0x104D6D0")]
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
			[Address(RVA = "0x104F2C8", Offset = "0x104F2C8", VA = "0x104F2C8")]
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
			[Address(RVA = "0x104D798", Offset = "0x104D798", VA = "0x104D798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x104D7A0", Offset = "0x104D7A0", VA = "0x104D7A0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000018")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x104D7A8", Offset = "0x104D7A8", VA = "0x104D7A8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000019")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x104D7B0", Offset = "0x104D7B0", VA = "0x104D7B0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001A")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x104D7B8", Offset = "0x104D7B8", VA = "0x104D7B8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001B")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x104D7C0", Offset = "0x104D7C0", VA = "0x104D7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x104D7C8", Offset = "0x104D7C8", VA = "0x104D7C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int TimelapseScale
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x104D7E8", Offset = "0x104D7E8", VA = "0x104D7E8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x104D7F0", Offset = "0x104D7F0", VA = "0x104D7F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x104D7F8", Offset = "0x104D7F8", VA = "0x104D7F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x104D800", Offset = "0x104D800", VA = "0x104D800")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public PostCaptureSettings PostCapture
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x104D80C", Offset = "0x104D80C", VA = "0x104D80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static string LastFileSaved
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x104B96C", Offset = "0x104B96C", VA = "0x104B96C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x104EA10", Offset = "0x104EA10", VA = "0x104EA10")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float FPS
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x104F27C", Offset = "0x104F27C", VA = "0x104F27C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float FramesTotal
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x104F284", Offset = "0x104F284", VA = "0x104F284")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x104D814", Offset = "0x104D814", VA = "0x104D814", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x104E018", Offset = "0x104E018", VA = "0x104E018")]
		protected void SetupRenderFunctions()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1044044", Offset = "0x1044044", VA = "0x1044044", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1048040", Offset = "0x1048040", VA = "0x1048040")]
		public void SelectCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1048310", Offset = "0x1048310", VA = "0x1048310")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x10485AC", Offset = "0x10485AC", VA = "0x10485AC")]
		public void SelectAudioDevice(bool display)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x104E040", Offset = "0x104E040", VA = "0x104E040")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x104029C", Offset = "0x104029C", VA = "0x104029C")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1041740", Offset = "0x1041740", VA = "0x1041740", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x104E170", Offset = "0x104E170", VA = "0x104E170")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x104E1E8", Offset = "0x104E1E8", VA = "0x104E1E8")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x104E264", Offset = "0x104E264", VA = "0x104E264")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x103F7BC", Offset = "0x103F7BC", VA = "0x103F7BC")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x103F21C", Offset = "0x103F21C", VA = "0x103F21C")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x104E2EC", Offset = "0x104E2EC", VA = "0x104E2EC", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x104E36C", Offset = "0x104E36C", VA = "0x104E36C")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x104E374", Offset = "0x104E374", VA = "0x104E374")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x104E37C", Offset = "0x104E37C", VA = "0x104E37C")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x104E384", Offset = "0x104E384", VA = "0x104E384")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x104E38C", Offset = "0x104E38C", VA = "0x104E38C", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x104E760", Offset = "0x104E760", VA = "0x104E760")]
		private static string GetFolder(OutputPath outputPathType, string path)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x104E870", Offset = "0x104E870", VA = "0x104E870")]
		private static string AutoGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x104E8F0", Offset = "0x104E8F0", VA = "0x104E8F0")]
		private static string ManualGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x104E9A4", Offset = "0x104E9A4", VA = "0x104E9A4")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10403D0", Offset = "0x10403D0", VA = "0x10403D0")]
		protected void GenerateFilename()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1040808", Offset = "0x1040808", VA = "0x1040808", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x104E9D4", Offset = "0x104E9D4", VA = "0x104E9D4")]
		public void QueueStartCapture()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x104BD14", Offset = "0x104BD14", VA = "0x104BD14")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x104BF30", Offset = "0x104BF30", VA = "0x104BF30")]
		public void PauseCapture()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x104BEA4", Offset = "0x104BEA4", VA = "0x104BEA4")]
		public void ResumeCapture()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x104BE5C", Offset = "0x104BE5C", VA = "0x104BE5C")]
		public void CancelCapture()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x103FA24", Offset = "0x103FA24", VA = "0x103FA24", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x103F6FC", Offset = "0x103F6FC", VA = "0x103F6FC")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x104EA5C", Offset = "0x104EA5C", VA = "0x104EA5C", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x104ED20", Offset = "0x104ED20", VA = "0x104ED20")]
		protected void ApplyPostOperations(string path)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x104F094", Offset = "0x104F094", VA = "0x104F094")]
		private void ToggleCapture()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x104F0B0", Offset = "0x104F0B0", VA = "0x104F0B0")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x104F0B8", Offset = "0x104F0B8", VA = "0x104F0B8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x104F11C", Offset = "0x104F11C", VA = "0x104F11C")]
		private void CheckFreeDiskSpace()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x104F154", Offset = "0x104F154", VA = "0x104F154")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x104F1E0", Offset = "0x104F1E0", VA = "0x104F1E0")]
		public float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x104E9E8", Offset = "0x104E9E8", VA = "0x104E9E8")]
		protected float GetSecondsPerCaptureFrame()
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x103F29C", Offset = "0x103F29C", VA = "0x103F29C")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x103F1F0", Offset = "0x103F1F0", VA = "0x103F1F0")]
		protected void TickFrameTimer()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x103F934", Offset = "0x103F934", VA = "0x103F934")]
		protected void RenormTimer()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x104F274", Offset = "0x104F274", VA = "0x104F274", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x103EF30", Offset = "0x103EF30", VA = "0x103EF30", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x104E9E0", Offset = "0x104E9E0", VA = "0x104E9E0")]
		protected void ResetFPS()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x103F8DC", Offset = "0x103F8DC", VA = "0x103F8DC")]
		public void UpdateFPS()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x10400E4", Offset = "0x10400E4", VA = "0x10400E4")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x104F290", Offset = "0x104F290", VA = "0x104F290")]
		private void ConfigureCodec()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x104C154", Offset = "0x104C154", VA = "0x104C154")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x10400B8", Offset = "0x10400B8", VA = "0x10400B8")]
		public static void GetResolution(Resolution res, ref int width, ref int height)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x104E164", Offset = "0x104E164", VA = "0x104E164")]
		protected static int NextMultipleOf4(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x10417CC", Offset = "0x10417CC", VA = "0x10417CC")]
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
			[Address(RVA = "0x1050C64", Offset = "0x1050C64", VA = "0x1050C64")]
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
		[Address(RVA = "0x104EEA4", Offset = "0x104EEA4", VA = "0x104EEA4")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x104F2D8", Offset = "0x104F2D8", VA = "0x104F2D8")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x104F6A8", Offset = "0x104F6A8", VA = "0x104F6A8")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x104F9F0", Offset = "0x104F9F0", VA = "0x104F9F0")]
		public void Close()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x104FC44", Offset = "0x104FC44", VA = "0x104FC44")]
		private static Chunk GetFirstChunkOfType(uint id, List<Chunk> chunks)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x104FA28", Offset = "0x104FA28", VA = "0x104FA28")]
		private List<Chunk> ReadChildChunks(Chunk parentChunk)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x10502F0", Offset = "0x10502F0", VA = "0x10502F0")]
		private Chunk ReadChunkHeader()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x104FD9C", Offset = "0x104FD9C", VA = "0x104FD9C")]
		private bool ChunkContainsChildChunkWithId(Chunk chunk, uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1050294", Offset = "0x1050294", VA = "0x1050294")]
		private void WriteChunk(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1050678", Offset = "0x1050678", VA = "0x1050678")]
		private void WriteChunkHeader(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1050590", Offset = "0x1050590", VA = "0x1050590")]
		private void CopyBytes(long numBytes)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x104FEA0", Offset = "0x104FEA0", VA = "0x104FEA0")]
		private void WriteChunk_moov(Chunk parentChunk, ulong byteOffset)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1050458", Offset = "0x1050458", VA = "0x1050458")]
		private uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x10504F4", Offset = "0x10504F4", VA = "0x10504F4")]
		private ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x10506D4", Offset = "0x10506D4", VA = "0x10506D4")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1050790", Offset = "0x1050790", VA = "0x1050790")]
		private void WriteUInt64(ulong value)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1050840", Offset = "0x1050840", VA = "0x1050840")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1050A1C", Offset = "0x1050A1C", VA = "0x1050A1C")]
		private static uint ChunkId(string id)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x104F6A0", Offset = "0x104F6A0", VA = "0x104F6A0")]
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
		[Address(RVA = "0x1050C6C", Offset = "0x1050C6C", VA = "0x1050C6C")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1050CD4", Offset = "0x1050CD4", VA = "0x1050CD4")]
		public static extern IntPtr GetFreeResourcesEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1050D3C", Offset = "0x1050D3C", VA = "0x1050D3C")]
		public static extern bool Init();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1050DAC", Offset = "0x1050DAC", VA = "0x1050DAC")]
		public static extern void Deinit();

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1050E10", Offset = "0x1050E10", VA = "0x1050E10")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1050ED8", Offset = "0x1050ED8", VA = "0x1050ED8")]
		public static extern bool IsTrialVersion();

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1050F48", Offset = "0x1050F48", VA = "0x1050F48")]
		public static extern int GetNumAVIVideoCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1050FB0", Offset = "0x1050FB0", VA = "0x1050FB0")]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1051034", Offset = "0x1051034", VA = "0x1051034")]
		public static extern void ConfigureVideoCodec(int index);

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x10510B0", Offset = "0x10510B0", VA = "0x10510B0")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1051230", Offset = "0x1051230", VA = "0x1051230")]
		public static extern int GetNumAVIAudioCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1051298", Offset = "0x1051298", VA = "0x1051298")]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x105131C", Offset = "0x105131C", VA = "0x105131C")]
		public static extern void ConfigureAudioCodec(int index);

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1051398", Offset = "0x1051398", VA = "0x1051398")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1051518", Offset = "0x1051518", VA = "0x1051518")]
		public static extern int GetNumAVIAudioInputDevices();

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1051580", Offset = "0x1051580", VA = "0x1051580")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1051700", Offset = "0x1051700", VA = "0x1051700")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1051854", Offset = "0x1051854", VA = "0x1051854")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1051954", Offset = "0x1051954", VA = "0x1051954")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1051A28", Offset = "0x1051A28", VA = "0x1051A28")]
		public static extern bool Start(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1051AAC", Offset = "0x1051AAC", VA = "0x1051AAC")]
		public static extern bool IsNewFrameDue(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1051B30", Offset = "0x1051B30", VA = "0x1051B30")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1051BB4", Offset = "0x1051BB4", VA = "0x1051BB4")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1051C48", Offset = "0x1051C48", VA = "0x1051C48")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1051CE4", Offset = "0x1051CE4", VA = "0x1051CE4")]
		public static extern void Pause(int handle);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1051D60", Offset = "0x1051D60", VA = "0x1051D60")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1051DE4", Offset = "0x1051DE4", VA = "0x1051DE4")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1051E64", Offset = "0x1051E64", VA = "0x1051E64")]
		public static extern void FreeRecorder(int handle);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1051EE0", Offset = "0x1051EE0", VA = "0x1051EE0")]
		public static extern uint GetNumDroppedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1051F5C", Offset = "0x1051F5C", VA = "0x1051F5C")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1051FD8", Offset = "0x1051FD8", VA = "0x1051FD8")]
		public static extern uint GetNumEncodedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1052054", Offset = "0x1052054", VA = "0x1052054")]
		public static extern uint GetEncodedSeconds(int handle);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1050E70", Offset = "0x1050E70", VA = "0x1050E70")]
		private static extern IntPtr GetPluginVersion();

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1051170", Offset = "0x1051170", VA = "0x1051170")]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1051458", Offset = "0x1051458", VA = "0x1051458")]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1051640", Offset = "0x1051640", VA = "0x1051640")]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10520CC", Offset = "0x10520CC", VA = "0x10520CC")]
		public NativePlugin()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Utils
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10520D4", Offset = "0x10520D4", VA = "0x10520D4")]
		public static Camera GetUltimateRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x105226C", Offset = "0x105226C", VA = "0x105226C")]
		public static bool HasContributingCameras(Camera parentCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x105232C", Offset = "0x105232C", VA = "0x105232C")]
		public static Camera[] FindContributingCameras(Camera parentCamera)
		{
			return null;
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x105284C", Offset = "0x105284C", VA = "0x105284C")]
		public static bool ShowInExplorer(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x105292C", Offset = "0x105292C", VA = "0x105292C")]
		public static bool OpenInDefaultApp(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1052A0C", Offset = "0x1052A0C", VA = "0x1052A0C")]
		public static long GetFileSize(string filename)
		{
			return default(long);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1052A74", Offset = "0x1052A74", VA = "0x1052A74")]
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
		[Address(RVA = "0x1052E64", Offset = "0x1052E64", VA = "0x1052E64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1052F1C", Offset = "0x1052F1C", VA = "0x1052F1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x10531C4", Offset = "0x10531C4", VA = "0x10531C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x10532B4", Offset = "0x10532B4", VA = "0x10532B4")]
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
		[Address(RVA = "0x10532CC", Offset = "0x10532CC", VA = "0x10532CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1053390", Offset = "0x1053390", VA = "0x1053390")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1053394", Offset = "0x1053394", VA = "0x1053394")]
		public void CreateVideoFromByteArray(string filePath, int width, int height, int frameRate)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1053338", Offset = "0x1053338", VA = "0x1053338")]
		private static int FindVideoCodecIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x10534F4", Offset = "0x10534F4", VA = "0x10534F4")]
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
				[Address(RVA = "0x1053B70", Offset = "0x1053B70", VA = "0x1053B70", Slot = "4")]
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
				[Address(RVA = "0x1053BB8", Offset = "0x1053BB8", VA = "0x1053BB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x10539D4", Offset = "0x10539D4", VA = "0x10539D4")]
			[DebuggerHidden]
			public <KillCube>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1053A98", Offset = "0x1053A98", VA = "0x1053A98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1053A9C", Offset = "0x1053A9C", VA = "0x1053A9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1053B78", Offset = "0x1053B78", VA = "0x1053B78", Slot = "8")]
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
		[Address(RVA = "0x10534FC", Offset = "0x10534FC", VA = "0x10534FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x10535A4", Offset = "0x10535A4", VA = "0x10535A4")]
		private void SpawnCube()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1053864", Offset = "0x1053864", VA = "0x1053864")]
		private void RemoveCube()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1053960", Offset = "0x1053960", VA = "0x1053960")]
		[IteratorStateMachine(typeof(<KillCube>d__10))]
		private IEnumerator KillCube(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x10539FC", Offset = "0x10539FC", VA = "0x10539FC")]
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
		[Address(RVA = "0x1053BC0", Offset = "0x1053BC0", VA = "0x1053BC0")]
		private void Start()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1053D4C", Offset = "0x1053D4C", VA = "0x1053D4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1053E54", Offset = "0x1053E54", VA = "0x1053E54")]
		private void Update()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1053E58", Offset = "0x1053E58", VA = "0x1053E58")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1053ECC", Offset = "0x1053ECC", VA = "0x1053ECC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1054064", Offset = "0x1054064", VA = "0x1054064")]
		public TextureCaptureDemo()
		{
		}
	}
}
