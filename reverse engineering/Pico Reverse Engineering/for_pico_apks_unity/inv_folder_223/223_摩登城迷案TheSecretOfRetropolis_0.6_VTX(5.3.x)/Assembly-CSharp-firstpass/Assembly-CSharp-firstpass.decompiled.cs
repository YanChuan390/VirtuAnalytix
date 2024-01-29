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
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5481D8", Offset = "0x5481D8")]
	public class CaptureFromCamera : CaptureBase
	{
		[Token(Token = "0x2000003")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548214", Offset = "0x548214")]
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
				[Address(RVA = "0x1414204", Offset = "0x1414204", VA = "0x1414204", Slot = "4")]
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
				[Address(RVA = "0x141424C", Offset = "0x141424C", VA = "0x141424C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1414160", Offset = "0x1414160", VA = "0x1414160")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000011")]
			[Address(RVA = "0x141418C", Offset = "0x141418C", VA = "0x141418C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1414190", Offset = "0x1414190", VA = "0x1414190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000014")]
			[Address(RVA = "0x141420C", Offset = "0x141420C", VA = "0x141420C", Slot = "8")]
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
			[Address(RVA = "0x129C834", Offset = "0x129C834", VA = "0x129C834")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x129C83C", Offset = "0x129C83C", VA = "0x129C83C")]
			set
			{
			}
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x129C848", Offset = "0x129C848", VA = "0x129C848")]
		public void SetCamera(Camera mainCamera, bool useContributingCameras = true)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x129C944", Offset = "0x129C944", VA = "0x129C944")]
		public void SetCamera(Camera mainCamera, Camera[] contributingCameras)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x129C97C", Offset = "0x129C97C", VA = "0x129C97C")]
		private bool HasCamera()
		{
			return default(bool);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x129C9E8", Offset = "0x129C9E8", VA = "0x129C9E8")]
		private bool HasContributingCameras()
		{
			return default(bool);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x129CA10", Offset = "0x129CA10", VA = "0x129CA10", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x129CA84", Offset = "0x129CA84", VA = "0x129CA84")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548AF4", Offset = "0x548AF4")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x129CAFC", Offset = "0x129CAFC", VA = "0x129CAFC")]
		private void Capture()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x129CCE0", Offset = "0x129CCE0", VA = "0x129CCE0")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x129D1E8", Offset = "0x129D1E8", VA = "0x129D1E8", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x129D28C", Offset = "0x129D28C", VA = "0x129D28C", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x129D294", Offset = "0x129D294", VA = "0x129D294", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x129D894", Offset = "0x129D894", VA = "0x129D894", Slot = "6")]
		public override void OnDestroy()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x129D958", Offset = "0x129D958", VA = "0x129D958")]
		public CaptureFromCamera()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548224", Offset = "0x548224")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548260", Offset = "0x548260")]
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
				[Address(RVA = "0x14142F8", Offset = "0x14142F8", VA = "0x14142F8", Slot = "4")]
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
				[Address(RVA = "0x1414340", Offset = "0x1414340", VA = "0x1414340", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1414254", Offset = "0x1414254", VA = "0x1414254")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1414280", Offset = "0x1414280", VA = "0x1414280", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1414284", Offset = "0x1414284", VA = "0x1414284", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1414300", Offset = "0x1414300", VA = "0x1414300", Slot = "8")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5484D4", Offset = "0x5484D4")]
		public bool _render180Degrees;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		[SerializeField]
		public StereoPacking _stereoRendering;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548530", Offset = "0x548530")]
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
		[Address(RVA = "0x129D9D0", Offset = "0x129D9D0", VA = "0x129D9D0")]
		public CaptureFromCamera360()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x129DA64", Offset = "0x129DA64", VA = "0x129DA64")]
		private CubemapRenderMethod GetCubemapRenderingMethod()
		{
			return default(CubemapRenderMethod);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x129DA9C", Offset = "0x129DA9C", VA = "0x129DA9C")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x129DAAC", Offset = "0x129DAAC", VA = "0x129DAAC", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x129DB08", Offset = "0x129DB08", VA = "0x129DB08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548BA4", Offset = "0x548BA4")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x129DB80", Offset = "0x129DB80", VA = "0x129DB80")]
		private void Capture()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x129E1B4", Offset = "0x129E1B4", VA = "0x129E1B4")]
		private static void ClearCubemap(RenderTexture texture, Color color)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x129E394", Offset = "0x129E394", VA = "0x129E394")]
		private void RenderCubemapToEquiRect(RenderTexture cubemap, RenderTexture target, bool supportRotation, Quaternion rotation, bool isEyeLeft)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x129DE8C", Offset = "0x129DE8C", VA = "0x129DE8C")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x129E538", Offset = "0x129E538", VA = "0x129E538")]
		private void RenderCameraToCubemap(Camera camera, RenderTexture cubemapTarget)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x129DDA0", Offset = "0x129DDA0", VA = "0x129DDA0")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x129EC48", Offset = "0x129EC48", VA = "0x129EC48", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x129F8B8", Offset = "0x129F8B8", VA = "0x129F8B8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x129F8F8", Offset = "0x129F8F8", VA = "0x129F8F8", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x129FB28", Offset = "0x129FB28", VA = "0x129FB28", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548270", Offset = "0x548270")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5485AC", Offset = "0x5485AC")]
			public bool render180Degrees;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5485F8", Offset = "0x5485F8")]
			public float ipd;

			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548644", Offset = "0x548644")]
			[SerializeField]
			public int pixelSliceSize;

			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548690", Offset = "0x548690")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x548690", Offset = "0x548690")]
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
			[Address(RVA = "0x141443C", Offset = "0x141443C", VA = "0x141443C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5482AC", Offset = "0x5482AC")]
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
				[Address(RVA = "0x14143EC", Offset = "0x14143EC", VA = "0x14143EC", Slot = "4")]
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
				[Address(RVA = "0x1414434", Offset = "0x1414434", VA = "0x1414434", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1414348", Offset = "0x1414348", VA = "0x1414348")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x600003B")]
			[Address(RVA = "0x1414374", Offset = "0x1414374", VA = "0x1414374", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600003C")]
			[Address(RVA = "0x1414378", Offset = "0x1414378", VA = "0x1414378", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x14143F4", Offset = "0x14143F4", VA = "0x14143F4", Slot = "8")]
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
			[Address(RVA = "0x129FD38", Offset = "0x129FD38", VA = "0x129FD38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x129FD40", Offset = "0x129FD40", VA = "0x129FD40")]
		public CaptureFromCamera360ODS()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x129FE04", Offset = "0x129FE04", VA = "0x129FE04")]
		public void SetCamera(Camera camera)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x129FE20", Offset = "0x129FE20", VA = "0x129FE20", Slot = "5")]
		public override void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x129FF74", Offset = "0x129FF74", VA = "0x129FF74")]
		private Camera CreateEye(Camera camera, string gameObjectName, float yRot, float xOffset, int cameraTargetHeight, int cullingMask, float fov, float aspect, int aalevel)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x12A04D8", Offset = "0x12A04D8", VA = "0x12A04D8", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x12A0534", Offset = "0x12A0534", VA = "0x12A0534")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548C54", Offset = "0x548C54")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x12A05AC", Offset = "0x12A05AC", VA = "0x12A05AC")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x12A0760", Offset = "0x12A0760", VA = "0x12A0760")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x12A0854", Offset = "0x12A0854", VA = "0x12A0854")]
		private void RenderFrame()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x12A0BC8", Offset = "0x12A0BC8", VA = "0x12A0BC8", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x12A0C08", Offset = "0x12A0C08", VA = "0x12A0C08", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x12A1760", Offset = "0x12A1760", VA = "0x12A1760")]
		private static void DestroyEye(Camera camera)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x12A1838", Offset = "0x12A1838", VA = "0x12A1838", Slot = "6")]
		public override void OnDestroy()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5482BC", Offset = "0x5482BC")]
	public class CaptureFromScreen : CaptureBase
	{
		[Token(Token = "0x200000B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5482F8", Offset = "0x5482F8")]
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
				[Address(RVA = "0x14145E4", Offset = "0x14145E4", VA = "0x14145E4", Slot = "4")]
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
				[Address(RVA = "0x141462C", Offset = "0x141462C", VA = "0x141462C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000044")]
			[Address(RVA = "0x141448C", Offset = "0x141448C", VA = "0x141448C")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000045")]
			[Address(RVA = "0x14144B8", Offset = "0x14144B8", VA = "0x14144B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x14144BC", Offset = "0x14144BC", VA = "0x14144BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x14145EC", Offset = "0x14145EC", VA = "0x14145EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x12A1A74", Offset = "0x12A1A74", VA = "0x12A1A74", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x12A1C68", Offset = "0x12A1C68", VA = "0x12A1C68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548D04", Offset = "0x548D04")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x12A1CE0", Offset = "0x12A1CE0", VA = "0x12A1CE0", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x12A1D28", Offset = "0x12A1D28", VA = "0x12A1D28")]
		public CaptureFromScreen()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548308", Offset = "0x548308")]
	public class CaptureFromTexture : CaptureBase
	{
		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548344", Offset = "0x548344")]
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
				[Address(RVA = "0x14146D8", Offset = "0x14146D8", VA = "0x14146D8", Slot = "4")]
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
				[Address(RVA = "0x1414720", Offset = "0x1414720", VA = "0x1414720", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000056")]
			[Address(RVA = "0x1414634", Offset = "0x1414634", VA = "0x1414634")]
			[DebuggerHidden]
			public <FinalRenderCapture>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1414660", Offset = "0x1414660", VA = "0x1414660", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1414664", Offset = "0x1414664", VA = "0x1414664", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600005A")]
			[Address(RVA = "0x14146E0", Offset = "0x14146E0", VA = "0x14146E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548724", Offset = "0x548724")]
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
		[Address(RVA = "0x12A1D88", Offset = "0x12A1D88", VA = "0x12A1D88")]
		public void SetSourceTexture(Texture texture)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x12A2098", Offset = "0x12A2098", VA = "0x12A2098")]
		public void UpdateSourceTexture()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x12A20A4", Offset = "0x12A20A4", VA = "0x12A20A4")]
		private bool ShouldCaptureFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x12A2130", Offset = "0x12A2130", VA = "0x12A2130")]
		private bool HasSourceTextureChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x12A2150", Offset = "0x12A2150", VA = "0x12A2150", Slot = "13")]
		public override void UpdateFrame()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x12A219C", Offset = "0x12A219C", VA = "0x12A219C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548DB4", Offset = "0x548DB4")]
		private IEnumerator FinalRenderCapture()
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x12A2214", Offset = "0x12A2214", VA = "0x12A2214")]
		private void Capture()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x12A2480", Offset = "0x12A2480", VA = "0x12A2480")]
		private void AccumulateMotionBlur()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x12A2528", Offset = "0x12A2528", VA = "0x12A2528", Slot = "12")]
		public override Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x12A25C8", Offset = "0x12A25C8", VA = "0x12A25C8", Slot = "9")]
		public override bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x12A2830", Offset = "0x12A2830", VA = "0x12A2830", Slot = "10")]
		public override void UnprepareCapture()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x12A28E4", Offset = "0x12A28E4", VA = "0x12A28E4")]
		public CaptureFromTexture()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548354", Offset = "0x548354")]
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
		[Address(RVA = "0x12A2954", Offset = "0x12A2954", VA = "0x12A2954")]
		private void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x12A29D8", Offset = "0x12A29D8", VA = "0x12A29D8")]
		private void CreateGUI()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12A37B4", Offset = "0x12A37B4", VA = "0x12A37B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x12A3A54", Offset = "0x12A3A54", VA = "0x12A3A54")]
		private void MyWindow(int id)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x12A638C", Offset = "0x12A638C", VA = "0x12A638C")]
		private void GUI_RecordingStatus()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12A7A60", Offset = "0x12A7A60", VA = "0x12A7A60")]
		private void DrawGuiField(string a, string b)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x12A79C0", Offset = "0x12A79C0", VA = "0x12A79C0")]
		private void StartCapture()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x12A7E14", Offset = "0x12A7E14", VA = "0x12A7E14")]
		private void StopCapture()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12A7D88", Offset = "0x12A7D88", VA = "0x12A7D88")]
		private void CancelCapture()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x12A7CFC", Offset = "0x12A7CFC", VA = "0x12A7CFC")]
		private void ResumeCapture()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x12A7C70", Offset = "0x12A7C70", VA = "0x12A7C70")]
		private void PauseCapture()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x12A7EAC", Offset = "0x12A7EAC", VA = "0x12A7EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x12A8014", Offset = "0x12A8014", VA = "0x12A8014")]
		public CaptureGUI()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548390", Offset = "0x548390")]
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
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548790", Offset = "0x548790")]
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
			[Address(RVA = "0x12A99C0", Offset = "0x12A99C0", VA = "0x12A99C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548E64", Offset = "0x548E64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x12A99C8", Offset = "0x12A99C8", VA = "0x12A99C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548E74", Offset = "0x548E74")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public int NumSamples
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x12A99D4", Offset = "0x12A99D4", VA = "0x12A99D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x129A938", Offset = "0x129A938", VA = "0x129A938")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int FrameCount
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x12A9AB4", Offset = "0x12A9AB4", VA = "0x12A9AB4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		public RenderTexture FinalTexture
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x12A9ABC", Offset = "0x12A9ABC", VA = "0x12A9ABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x12A9AC4", Offset = "0x12A9AC4", VA = "0x12A9AC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x129A940", Offset = "0x129A940", VA = "0x129A940")]
		public void SetTargetSize(int width, int height)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x12A9B6C", Offset = "0x12A9B6C", VA = "0x12A9B6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x12A9ED0", Offset = "0x12A9ED0", VA = "0x12A9ED0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x12A9B70", Offset = "0x12A9B70", VA = "0x12A9B70")]
		private void Setup()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12A9EDC", Offset = "0x12A9EDC", VA = "0x12A9EDC")]
		private void ClearAccumulation()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12A9F34", Offset = "0x12A9F34", VA = "0x12A9F34")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x12A99DC", Offset = "0x12A99DC", VA = "0x12A99DC")]
		public void OnNumSamplesChanged()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x12AA15C", Offset = "0x12AA15C", VA = "0x12AA15C")]
		private static float LerpUnclamped(float a, float b, float t)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12AA16C", Offset = "0x12AA16C", VA = "0x12AA16C")]
		private void ApplyWeighting()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x129EB40", Offset = "0x129EB40", VA = "0x129EB40")]
		public void Accumulate(Texture src)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x12AA23C", Offset = "0x12AA23C", VA = "0x12AA23C")]
		private void OnRenderImage(RenderTexture src, RenderTexture dst)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12AA2C4", Offset = "0x12AA2C4", VA = "0x12AA2C4")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5483CC", Offset = "0x5483CC")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5487D0", Offset = "0x5487D0")]
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
		[Address(RVA = "0x12AA2E0", Offset = "0x12AA2E0", VA = "0x12AA2E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x12AA2E8", Offset = "0x12AA2E8", VA = "0x12AA2E8")]
		public void SetTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x12AA3BC", Offset = "0x12AA3BC", VA = "0x12AA3BC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x12AA4E8", Offset = "0x12AA4E8", VA = "0x12AA4E8")]
		public MouseCursor()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x548408", Offset = "0x548408")]
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
			[Address(RVA = "0x1411D58", Offset = "0x1411D58", VA = "0x1411D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public int BufferLength
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x1411D60", Offset = "0x1411D60", VA = "0x1411D60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000013")]
		public int NumChannels
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x1411D68", Offset = "0x1411D68", VA = "0x1411D68")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000014")]
		public IntPtr BufferPtr
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x1411D70", Offset = "0x1411D70", VA = "0x1411D70")]
			get
			{
				return default(IntPtr);
			}
		}

		[Token(Token = "0x17000015")]
		public int OverflowCount
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x1411D7C", Offset = "0x1411D7C", VA = "0x1411D7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1411D84", Offset = "0x1411D84", VA = "0x1411D84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x14121FC", Offset = "0x14121FC", VA = "0x14121FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1412310", Offset = "0x1412310", VA = "0x1412310")]
		public IntPtr ReadData(out int length)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1412404", Offset = "0x1412404", VA = "0x1412404")]
		public void FlushBuffer()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x14124C8", Offset = "0x14124C8", VA = "0x14124C8")]
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x14121D8", Offset = "0x14121D8", VA = "0x14121D8")]
		public static int GetNumChannels(AudioSpeakerMode mode)
		{
			return default(int);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1412768", Offset = "0x1412768", VA = "0x1412768")]
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
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548998", Offset = "0x548998")]
			[SerializeField]
			public bool writeFastStartStreamingForMp4;

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1414150", Offset = "0x1414150", VA = "0x1414150")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548870", Offset = "0x548870")]
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
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x5488BC", Offset = "0x5488BC")]
		[SerializeField]
		private bool _forceGpuFlush;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x548908", Offset = "0x548908")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x548954", Offset = "0x548954")]
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
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x54896C", Offset = "0x54896C")]
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
			[Address(RVA = "0x1296E90", Offset = "0x1296E90", VA = "0x1296E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public uint NumDroppedFrames
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0x1296E98", Offset = "0x1296E98", VA = "0x1296E98")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000018")]
		public uint NumDroppedEncoderFrames
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0x1296EA0", Offset = "0x1296EA0", VA = "0x1296EA0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000019")]
		public uint NumEncodedFrames
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x1296EA8", Offset = "0x1296EA8", VA = "0x1296EA8")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001A")]
		public uint TotalEncodedSeconds
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1296EB0", Offset = "0x1296EB0", VA = "0x1296EB0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700001B")]
		public string[] VideoCodecPriority
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1296EB8", Offset = "0x1296EB8", VA = "0x1296EB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x1296EC0", Offset = "0x1296EC0", VA = "0x1296EC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public int TimelapseScale
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x12971D0", Offset = "0x12971D0", VA = "0x12971D0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x12971D8", Offset = "0x12971D8", VA = "0x12971D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool UseWaitForEndOfFrame
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x12971E0", Offset = "0x12971E0", VA = "0x12971E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x12971E8", Offset = "0x12971E8", VA = "0x12971E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public PostCaptureSettings PostCapture
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x12971F4", Offset = "0x12971F4", VA = "0x12971F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public static string LastFileSaved
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x129AFE8", Offset = "0x129AFE8", VA = "0x129AFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x129B050", Offset = "0x129B050", VA = "0x129B050")]
			set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public float FPS
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x129C0A0", Offset = "0x129C0A0", VA = "0x129C0A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float FramesTotal
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x129C0A8", Offset = "0x129C0A8", VA = "0x129C0A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x12971FC", Offset = "0x12971FC", VA = "0x12971FC", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1297B78", Offset = "0x1297B78", VA = "0x1297B78")]
		protected void SetupRenderFunctions()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x12980DC", Offset = "0x12980DC", VA = "0x12980DC", Slot = "5")]
		public virtual void Start()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1296EEC", Offset = "0x1296EEC", VA = "0x1296EEC")]
		public void SelectCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1297BA4", Offset = "0x1297BA4", VA = "0x1297BA4")]
		public void SelectAudioCodec(bool listCodecs)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1297E80", Offset = "0x1297E80", VA = "0x1297E80")]
		public void SelectAudioDevice(bool display)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1298664", Offset = "0x1298664", VA = "0x1298664")]
		public static Vector2 GetRecordingResolution(int width, int height, DownScale downscale, Vector2 maxVideoSize)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x129874C", Offset = "0x129874C", VA = "0x129874C")]
		public void SelectRecordingResolution(int width, int height)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x129883C", Offset = "0x129883C", VA = "0x129883C", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1298878", Offset = "0x1298878", VA = "0x1298878")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1298990", Offset = "0x1298990", VA = "0x1298990")]
		protected void EncodeTexture(Texture2D texture)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1298A10", Offset = "0x1298A10", VA = "0x1298A10")]
		protected bool IsUsingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1298AA4", Offset = "0x1298AA4", VA = "0x1298AA4")]
		protected bool IsRecordingUnityAudio()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1298AE8", Offset = "0x1298AE8", VA = "0x1298AE8")]
		protected bool IsUsingMotionBlur()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1298B74", Offset = "0x1298B74", VA = "0x1298B74", Slot = "7")]
		public virtual void EncodePointer(IntPtr ptr)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1298D34", Offset = "0x1298D34", VA = "0x1298D34")]
		public bool IsCapturing()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1298D3C", Offset = "0x1298D3C", VA = "0x1298D3C")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1298D44", Offset = "0x1298D44", VA = "0x1298D44")]
		public int GetRecordingWidth()
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1298D4C", Offset = "0x1298D4C", VA = "0x1298D4C")]
		public int GetRecordingHeight()
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1298D54", Offset = "0x1298D54", VA = "0x1298D54", Slot = "8")]
		protected virtual string GenerateTimestampedFilename(string filenamePrefix, string filenameExtension)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1299138", Offset = "0x1299138", VA = "0x1299138")]
		private static string GetFolder(OutputPath outputPathType, string path)
		{
			return null;
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1299264", Offset = "0x1299264", VA = "0x1299264")]
		private static string AutoGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x129931C", Offset = "0x129931C", VA = "0x129931C")]
		private static string ManualGenerateFilename(OutputPath outputPathType, string path, string filename)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1299410", Offset = "0x1299410", VA = "0x1299410")]
		protected static bool HasExtension(string path, string extension)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x129944C", Offset = "0x129944C", VA = "0x129944C")]
		protected void GenerateFilename()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x129994C", Offset = "0x129994C", VA = "0x129994C", Slot = "9")]
		public virtual bool PrepareCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x129ACA8", Offset = "0x129ACA8", VA = "0x129ACA8")]
		public void QueueStartCapture()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1298168", Offset = "0x1298168", VA = "0x1298168")]
		public bool StartCapture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x129AD6C", Offset = "0x129AD6C", VA = "0x129AD6C")]
		public void PauseCapture()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x129AE64", Offset = "0x129AE64", VA = "0x129AE64")]
		public void ResumeCapture()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x129AEFC", Offset = "0x129AEFC", VA = "0x129AEFC")]
		public void CancelCapture()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x129AF54", Offset = "0x129AF54", VA = "0x129AF54", Slot = "10")]
		public virtual void UnprepareCapture()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x129B0A0", Offset = "0x129B0A0", VA = "0x129B0A0")]
		protected void RenderThreadEvent(NativePlugin.PluginEvent renderEvent)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x129B14C", Offset = "0x129B14C", VA = "0x129B14C", Slot = "11")]
		public virtual void StopCapture(bool skipPendingFrames = false)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x129B5B8", Offset = "0x129B5B8", VA = "0x129B5B8")]
		protected void ApplyPostOperations(string path)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x129B9F8", Offset = "0x129B9F8", VA = "0x129B9F8")]
		private void ToggleCapture()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x129BA14", Offset = "0x129BA14", VA = "0x129BA14")]
		private bool IsEnoughDiskSpace()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x129BA1C", Offset = "0x129BA1C", VA = "0x129BA1C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x129BA84", Offset = "0x129BA84", VA = "0x129BA84")]
		private void CheckFreeDiskSpace()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x129BAC8", Offset = "0x129BAC8", VA = "0x129BAC8")]
		protected bool IsProgressComplete()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x129BB60", Offset = "0x129BB60", VA = "0x129BB60")]
		public float GetProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x129AD44", Offset = "0x129AD44", VA = "0x129AD44")]
		protected float GetSecondsPerCaptureFrame()
		{
			return default(float);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x129BC00", Offset = "0x129BC00", VA = "0x129BC00")]
		protected bool CanOutputFrame()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x129BD50", Offset = "0x129BD50", VA = "0x129BD50")]
		protected void TickFrameTimer()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x129BD88", Offset = "0x129BD88", VA = "0x129BD88")]
		protected void RenormTimer()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x129BDC4", Offset = "0x129BDC4", VA = "0x129BDC4", Slot = "12")]
		public virtual Texture GetPreviewTexture()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x129BDCC", Offset = "0x129BDCC", VA = "0x129BDCC", Slot = "13")]
		public virtual void UpdateFrame()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x129AD3C", Offset = "0x129AD3C", VA = "0x129AD3C")]
		protected void ResetFPS()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x129C0B4", Offset = "0x129C0B4", VA = "0x129C0B4")]
		public void UpdateFPS()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x129C118", Offset = "0x129C118", VA = "0x129C118")]
		protected int GetCameraAntiAliasingLevel(Camera camera)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x129C300", Offset = "0x129C300", VA = "0x129C300")]
		private void ConfigureCodec()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x129C3C0", Offset = "0x129C3C0", VA = "0x129C3C0")]
		public long GetCaptureFileSize()
		{
			return default(long);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x129C498", Offset = "0x129C498", VA = "0x129C498")]
		public static void GetResolution(Resolution res, ref int width, ref int height)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1298740", Offset = "0x1298740", VA = "0x1298740")]
		protected static int NextMultipleOf4(int value)
		{
			return default(int);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x129C4C4", Offset = "0x129C4C4", VA = "0x129C4C4")]
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
			[Address(RVA = "0x1414728", Offset = "0x1414728", VA = "0x1414728")]
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
		[Address(RVA = "0x129B7A8", Offset = "0x129B7A8", VA = "0x129B7A8")]
		public static bool ApplyFastStart(string filePath, bool keepBackup)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x12A813C", Offset = "0x12A813C", VA = "0x12A813C")]
		public static bool ApplyFastStart(string srcPath, string dstPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x12A845C", Offset = "0x12A845C", VA = "0x12A845C")]
		public bool Open(Stream srcStream, Stream dstStream)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x12A87B0", Offset = "0x12A87B0", VA = "0x12A87B0")]
		public void Close()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x12A89D0", Offset = "0x12A89D0", VA = "0x12A89D0")]
		private static Chunk GetFirstChunkOfType(uint id, List<Chunk> chunks)
		{
			return null;
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x12A87F8", Offset = "0x12A87F8", VA = "0x12A87F8")]
		private List<Chunk> ReadChildChunks(Chunk parentChunk)
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x12A905C", Offset = "0x12A905C", VA = "0x12A905C")]
		private Chunk ReadChunkHeader()
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x12A8B04", Offset = "0x12A8B04", VA = "0x12A8B04")]
		private bool ChunkContainsChildChunkWithId(Chunk chunk, uint id)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12A8FFC", Offset = "0x12A8FFC", VA = "0x12A8FFC")]
		private void WriteChunk(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x12A93E4", Offset = "0x12A93E4", VA = "0x12A93E4")]
		private void WriteChunkHeader(Chunk chunk)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x12A92F0", Offset = "0x12A92F0", VA = "0x12A92F0")]
		private void CopyBytes(long numBytes)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x12A8C14", Offset = "0x12A8C14", VA = "0x12A8C14")]
		private void WriteChunk_moov(Chunk parentChunk, ulong byteOffset)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x12A91C8", Offset = "0x12A91C8", VA = "0x12A91C8")]
		private uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x12A925C", Offset = "0x12A925C", VA = "0x12A925C")]
		private ulong ReadUInt64()
		{
			return default(ulong);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x12A9444", Offset = "0x12A9444", VA = "0x12A9444")]
		private void WriteUInt32(uint value, bool isBigEndian = true)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x12A94F8", Offset = "0x12A94F8", VA = "0x12A94F8")]
		private void WriteUInt64(ulong value)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x12A95A0", Offset = "0x12A95A0", VA = "0x12A95A0")]
		private static string ChunkType(uint id)
		{
			return null;
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12A9790", Offset = "0x12A9790", VA = "0x12A9790")]
		private static uint ChunkId(string id)
		{
			return default(uint);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x12A8454", Offset = "0x12A8454", VA = "0x12A8454")]
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
		[Address(RVA = "0x1297FF4", Offset = "0x1297FF4", VA = "0x1297FF4")]
		public static extern IntPtr GetRenderEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1298068", Offset = "0x1298068", VA = "0x1298068")]
		public static extern IntPtr GetFreeResourcesEventFunc();

		[PreserveSig]
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1297AFC", Offset = "0x1297AFC", VA = "0x1297AFC")]
		public static extern bool Init();

		[PreserveSig]
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1298920", Offset = "0x1298920", VA = "0x1298920")]
		public static extern void Deinit();

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1297A90", Offset = "0x1297A90", VA = "0x1297A90")]
		public static string GetPluginVersionString()
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x12AA598", Offset = "0x12AA598", VA = "0x12AA598")]
		public static extern bool IsTrialVersion();

		[PreserveSig]
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x12982BC", Offset = "0x12982BC", VA = "0x12982BC")]
		public static extern int GetNumAVIVideoCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x12A36A4", Offset = "0x12A36A4", VA = "0x12A36A4")]
		public static extern bool IsConfigureVideoCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x129C340", Offset = "0x129C340", VA = "0x129C340")]
		public static extern void ConfigureVideoCodec(int index);

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1298330", Offset = "0x1298330", VA = "0x1298330")]
		public static string GetAVIVideoCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x12983F4", Offset = "0x12983F4", VA = "0x12983F4")]
		public static extern int GetNumAVIAudioCodecs();

		[PreserveSig]
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x12A372C", Offset = "0x12A372C", VA = "0x12A372C")]
		public static extern bool IsConfigureAudioCodecSupported(int index);

		[PreserveSig]
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x12A7940", Offset = "0x12A7940", VA = "0x12A7940")]
		public static extern void ConfigureAudioCodec(int index);

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1298468", Offset = "0x1298468", VA = "0x1298468")]
		public static string GetAVIAudioCodecName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x129852C", Offset = "0x129852C", VA = "0x129852C")]
		public static extern int GetNumAVIAudioInputDevices();

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x12985A0", Offset = "0x12985A0", VA = "0x12985A0")]
		public static string GetAVIAudioInputDeviceName(int index)
		{
			return null;
		}

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x129A968", Offset = "0x129A968", VA = "0x129A968")]
		public static extern int CreateRecorderVideo(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, int videoCodecIndex, bool hasAudio, int audioSampleRate, int audioChannelCount, int audioInputDeviceIndex, int audioCodecIndex, bool isRealTime, bool useMediaFoundation, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x129AAB8", Offset = "0x129AAB8", VA = "0x129AAB8")]
		public static extern int CreateRecorderImages(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool isRealTime, int imageFormatType, bool supportAlpha, bool forceGpuFlush, int startFrame);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x129ABC8", Offset = "0x129ABC8", VA = "0x129ABC8")]
		public static extern int CreateRecorderPipe(string filename, uint width, uint height, int frameRate, int format, bool isTopDown, bool supportAlpha, bool forceGpuFlush);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x129ACB4", Offset = "0x129ACB4", VA = "0x129ACB4")]
		public static extern bool Start(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x129BCC8", Offset = "0x129BCC8", VA = "0x129BCC8")]
		public static extern bool IsNewFrameDue(int handle);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1298BFC", Offset = "0x1298BFC", VA = "0x1298BFC")]
		public static extern void EncodeFrame(int handle, IntPtr data);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x129D150", Offset = "0x129D150", VA = "0x129D150")]
		public static extern void EncodeAudio(int handle, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1298C8C", Offset = "0x1298C8C", VA = "0x1298C8C")]
		public static extern void EncodeFrameWithAudio(int handle, IntPtr videoData, IntPtr audioData, uint audioLength);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x129ADE4", Offset = "0x129ADE4", VA = "0x129ADE4")]
		public static extern void Pause(int handle);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x129B4A8", Offset = "0x129B4A8", VA = "0x129B4A8")]
		public static extern void Stop(int handle, bool skipPendingFrames);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x129D0C4", Offset = "0x129D0C4", VA = "0x129D0C4")]
		public static extern void SetTexturePointer(int handle, IntPtr texture);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x129B538", Offset = "0x129B538", VA = "0x129B538")]
		public static extern void FreeRecorder(int handle);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x129BEA4", Offset = "0x129BEA4", VA = "0x129BEA4")]
		public static extern uint GetNumDroppedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x129BF24", Offset = "0x129BF24", VA = "0x129BF24")]
		public static extern uint GetNumDroppedEncoderFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x129BFA4", Offset = "0x129BFA4", VA = "0x129BFA4")]
		public static extern uint GetNumEncodedFrames(int handle);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x129C024", Offset = "0x129C024", VA = "0x129C024")]
		public static extern uint GetEncodedSeconds(int handle);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x12AA524", Offset = "0x12AA524", VA = "0x12AA524")]
		private static extern IntPtr GetPluginVersion();

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x12AA614", Offset = "0x12AA614", VA = "0x12AA614")]
		private static extern bool GetAVIVideoCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12AA6D8", Offset = "0x12AA6D8", VA = "0x12AA6D8")]
		private static extern bool GetAVIAudioCodecName(int index, StringBuilder name, int nameBufferLength);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x12AA79C", Offset = "0x12AA79C", VA = "0x12AA79C")]
		private static extern bool GetAVIAudioInputDeviceName(int index, StringBuilder name, int nameBufferLength);

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x12AA860", Offset = "0x12AA860", VA = "0x12AA860")]
		public NativePlugin()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Utils
	{
		[Serializable]
		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548444", Offset = "0x548444")]
		private sealed class <>c
		{
			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<Camera> <>9__2_0;

			[Token(Token = "0x6000117")]
			[Address(RVA = "0x14148EC", Offset = "0x14148EC", VA = "0x14148EC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0x14148F4", Offset = "0x14148F4", VA = "0x14148F4")]
			internal int <FindContributingCameras>b__2_0(Camera a, Camera b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1412824", Offset = "0x1412824", VA = "0x1412824")]
		public static Camera GetUltimateRenderCamera()
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x14129E0", Offset = "0x14129E0", VA = "0x14129E0")]
		public static bool HasContributingCameras(Camera parentCamera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1412AAC", Offset = "0x1412AAC", VA = "0x1412AAC")]
		public static Camera[] FindContributingCameras(Camera parentCamera)
		{
			return null;
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1412FFC", Offset = "0x1412FFC", VA = "0x1412FFC")]
		public static bool ShowInExplorer(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x14130E8", Offset = "0x14130E8", VA = "0x14130E8")]
		public static bool OpenInDefaultApp(string itemPath)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x14131D4", Offset = "0x14131D4", VA = "0x14131D4")]
		public static long GetFileSize(string filename)
		{
			return default(long);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1413240", Offset = "0x1413240", VA = "0x1413240")]
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
		[Address(RVA = "0x12AA868", Offset = "0x12AA868", VA = "0x12AA868")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x12AA8FC", Offset = "0x12AA8FC", VA = "0x12AA8FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x12AAB70", Offset = "0x12AAB70", VA = "0x12AAB70")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x12AAC6C", Offset = "0x12AAC6C", VA = "0x12AAC6C")]
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
		[Address(RVA = "0x12AAC84", Offset = "0x12AAC84", VA = "0x12AAC84")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12AAD58", Offset = "0x12AAD58", VA = "0x12AAD58")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x12AAD5C", Offset = "0x12AAD5C", VA = "0x12AAD5C")]
		public void CreateVideoFromByteArray(string filePath, int width, int height, int frameRate)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x12AACF4", Offset = "0x12AACF4", VA = "0x12AACF4")]
		private static int FindVideoCodecIndex(string name)
		{
			return default(int);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12AAEC0", Offset = "0x12AAEC0", VA = "0x12AAEC0")]
		public ScriptCaptureDemo()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class SurroundCaptureDemo : MonoBehaviour
	{
		[Token(Token = "0x200002B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x548454", Offset = "0x548454")]
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
				[Address(RVA = "0x1414838", Offset = "0x1414838", VA = "0x1414838", Slot = "4")]
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
				[Address(RVA = "0x1414880", Offset = "0x1414880", VA = "0x1414880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1414730", Offset = "0x1414730", VA = "0x1414730")]
			[DebuggerHidden]
			public <KillCube>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x141475C", Offset = "0x141475C", VA = "0x141475C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1414760", Offset = "0x1414760", VA = "0x1414760", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1414840", Offset = "0x1414840", VA = "0x1414840", Slot = "8")]
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
		[Address(RVA = "0x12AAEC8", Offset = "0x12AAEC8", VA = "0x12AAEC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x12AAF74", Offset = "0x12AAF74", VA = "0x12AAF74")]
		private void SpawnCube()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x12AB1C8", Offset = "0x12AB1C8", VA = "0x12AB1C8")]
		private void RemoveCube()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x12AB2BC", Offset = "0x12AB2BC", VA = "0x12AB2BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x548E84", Offset = "0x548E84")]
		private IEnumerator KillCube(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x12AB334", Offset = "0x12AB334", VA = "0x12AB334")]
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
		[Address(RVA = "0x1411848", Offset = "0x1411848", VA = "0x1411848")]
		private void Start()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x14119E4", Offset = "0x14119E4", VA = "0x14119E4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1411B10", Offset = "0x1411B10", VA = "0x1411B10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1411B14", Offset = "0x1411B14", VA = "0x1411B14")]
		private void UpdateTexture()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1411B9C", Offset = "0x1411B9C", VA = "0x1411B9C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1411D48", Offset = "0x1411D48", VA = "0x1411D48")]
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
			[Address(RVA = "0x14134F8", Offset = "0x14134F8", VA = "0x14134F8")]
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
		[Address(RVA = "0x1413248", Offset = "0x1413248", VA = "0x1413248")]
		private void Start()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x14135E4", Offset = "0x14135E4", VA = "0x14135E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x14136BC", Offset = "0x14136BC", VA = "0x14136BC")]
		private void StartWebcam(Instance instance)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x14137BC", Offset = "0x14137BC", VA = "0x14137BC")]
		private void StopWebcam(Instance instance)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1413904", Offset = "0x1413904", VA = "0x1413904")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1413500", Offset = "0x1413500", VA = "0x1413500")]
		private void SelectWebcam(int index)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x141396C", Offset = "0x141396C", VA = "0x141396C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x141412C", Offset = "0x141412C", VA = "0x141412C")]
		public WebcamCaptureDemo()
		{
		}
	}
}
