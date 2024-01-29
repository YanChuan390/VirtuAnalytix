using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using FLUID;
using FLUID.Core.Input;
using FLUID.Core.Primitives;
using Il2CppDummyDll;
using Silhouette;
using Silhouette.HandTracking;
using Silhouette.ShadowPeople;
using TMPro;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public enum AudioGroups
{
	[Token(Token = "0x4000002")]
	Master,
	[Token(Token = "0x4000003")]
	SFX,
	[Token(Token = "0x4000004")]
	Gameplay,
	[Token(Token = "0x4000005")]
	Ambience,
	[Token(Token = "0x4000006")]
	Music
}
[Token(Token = "0x2000003")]
public class AudioMixerController : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioMixer mixer;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x16208CC", Offset = "0x16208CC", VA = "0x16208CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1620B40", Offset = "0x1620B40", VA = "0x1620B40")]
	public void SetVolume(AudioGroups group, float value)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1620BEC", Offset = "0x1620BEC", VA = "0x1620BEC")]
	private void SetVolume(string param, float linearValue)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1620CD0", Offset = "0x1620CD0", VA = "0x1620CD0")]
	public AudioMixerController()
	{
	}
}
[Token(Token = "0x2000004")]
public static class BetterStreamingAssets
{
	[Token(Token = "0x2000005")]
	internal struct ReadInfo
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string readPath;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long size;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long offset;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint crc32;
	}

	[Token(Token = "0x2000006")]
	internal static class ApkImpl
	{
		[Token(Token = "0x2000007")]
		private struct PartInfo
		{
			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long size;

			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public long offset;

			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint crc32;
		}

		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F1F4", Offset = "0x71F1F4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string searchPattern;

			[Token(Token = "0x600001D")]
			[Address(RVA = "0x16084C0", Offset = "0x16084C0", VA = "0x16084C0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x16084C8", Offset = "0x16084C8", VA = "0x16084C8")]
			internal bool <GetFiles>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000009")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F204", Offset = "0x71F204")]
		private sealed class <>c__DisplayClass7_1
		{
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Regex regex;

			[Token(Token = "0x600001F")]
			[Address(RVA = "0x16084F8", Offset = "0x16084F8", VA = "0x16084F8")]
			public <>c__DisplayClass7_1()
			{
			}

			[Token(Token = "0x6000020")]
			[Address(RVA = "0x1608500", Offset = "0x1608500", VA = "0x1608500")]
			internal bool <GetFiles>b__1(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string[] s_paths;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PartInfo[] s_streamingAssets;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string s_root;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xF00618", Offset = "0xF00618", VA = "0xF00618")]
		public static void Initialize(string dataPath, string streamingAssetsPath)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xF010A8", Offset = "0xF010A8", VA = "0xF010A8")]
		public static bool TryGetInfo(string path, out ReadInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xF01220", Offset = "0xF01220", VA = "0xF01220")]
		public static bool DirectoryExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xF01498", Offset = "0xF01498", VA = "0xF01498")]
		public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xF01954", Offset = "0xF01954", VA = "0xF01954")]
		public static byte[] ReadAllBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xF01C1C", Offset = "0xF01C1C", VA = "0xF01C1C")]
		public static Stream OpenRead(string path)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xF012A4", Offset = "0xF012A4", VA = "0xF012A4")]
		private static int GetDirectoryIndex(string path)
		{
			return default(int);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xF00858", Offset = "0xF00858", VA = "0xF00858")]
		private static void GetStreamingAssetsInfoFromJar(string apkPath, List<string> paths, List<PartInfo> parts)
		{
		}
	}

	[Token(Token = "0x17000001")]
	public static string Root
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1620CD8", Offset = "0x1620CD8", VA = "0x1620CD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1620D24", Offset = "0x1620D24", VA = "0x1620D24")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1620D5C", Offset = "0x1620D5C", VA = "0x1620D5C")]
	public static bool FileExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1620D8C", Offset = "0x1620D8C", VA = "0x1620D8C")]
	public static bool DirectoryExists(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1620D94", Offset = "0x1620D94", VA = "0x1620D94")]
	public static AssetBundleCreateRequest LoadAssetBundleAsync(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1620E20", Offset = "0x1620E20", VA = "0x1620E20")]
	public static AssetBundle LoadAssetBundle(string path, uint crc = 0u)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1620E5C", Offset = "0x1620E5C", VA = "0x1620E5C")]
	public static Stream OpenRead(string path)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1620F14", Offset = "0x1620F14", VA = "0x1620F14")]
	public static StreamReader OpenText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x162101C", Offset = "0x162101C", VA = "0x162101C")]
	public static string ReadAllText(string path)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x162116C", Offset = "0x162116C", VA = "0x162116C")]
	public static string[] ReadAllLines(string path)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1621358", Offset = "0x1621358", VA = "0x1621358")]
	public static byte[] ReadAllBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1621410", Offset = "0x1621410", VA = "0x1621410")]
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1621418", Offset = "0x1621418", VA = "0x1621418")]
	public static string[] GetFiles(string path)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1621428", Offset = "0x1621428", VA = "0x1621428")]
	public static string[] GetFiles(string path, string searchPattern)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1620DD0", Offset = "0x1620DD0", VA = "0x1620DD0")]
	private static ReadInfo GetInfoOrThrow(string path)
	{
		return default(ReadInfo);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1621434", Offset = "0x1621434", VA = "0x1621434")]
	private static void ThrowFileNotFound(string path)
	{
	}
}
[Token(Token = "0x200000A")]
public class CameraCapture : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F214", Offset = "0x71F214")]
	private sealed class <TakeAPhotoCoroutine>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CameraCapture <>4__this;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xF01E74", Offset = "0xF01E74", VA = "0xF01E74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xF01EBC", Offset = "0xF01EBC", VA = "0xF01EBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xF01D70", Offset = "0xF01D70", VA = "0xF01D70")]
		[DebuggerHidden]
		public <TakeAPhotoCoroutine>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xF01D9C", Offset = "0xF01D9C", VA = "0xF01D9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xF01DA0", Offset = "0xF01DA0", VA = "0xF01DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xF01E7C", Offset = "0xF01E7C", VA = "0xF01E7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FAE8", Offset = "0x71FAE8")]
	public Camera renderCamera;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera mainCamera;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform playerHand1;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform playerHand2;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public IHand leftHandRef;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IHand rightHandRef;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 corner1ScPos;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 corner2ScPos;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 corner1WPos;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 corner2WPos;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 corner3WPos;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 corner4WPos;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 centerWPos;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x71FB20", Offset = "0x71FB20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FB20", Offset = "0x71FB20")]
	public RenderTexture cameraRenderer;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Canvas cameraPreviewCanvas;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RawImage cameraPreview;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CanvasGroup camPreviewCanvasGroup;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool canTakePhotos;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	private bool isTakingPhotos;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Coroutine takeAPhotoCoroutine;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x71FB70", Offset = "0x71FB70")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FB70", Offset = "0x71FB70")]
	public Canvas photoCanvas;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image photo;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Image photoBorders;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector2 photoMaxDimensions;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float displayPhotoDuration;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float photoBordersThickness;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private CanvasGroup photoCanvasGroup;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x71FBC0", Offset = "0x71FBC0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FBC0", Offset = "0x71FBC0")]
	public Canvas decalPhotoCanvas;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Image decalPhoto;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public LayerMask shadowSurfaceLayerMask;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public string shadowDecalLayerName;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float decalPhotoOffset;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Material decalPhotoCutoutMat;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private bool canPlacePhotos;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
	private bool isPlacingPhotos;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private CanvasGroup decalPhotoCanvasGroup;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Texture2D currentDecalTexture;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public bool photoMode;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
	public bool taking;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public PhotoQuad photoQuad;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1621DA8", Offset = "0x1621DA8", VA = "0x1621DA8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1621ED4", Offset = "0x1621ED4", VA = "0x1621ED4")]
	private void ValidateHandDirection()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x16221C8", Offset = "0x16221C8", VA = "0x16221C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1623264", Offset = "0x1623264", VA = "0x1623264")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1623410", Offset = "0x1623410", VA = "0x1623410")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1623420", Offset = "0x1623420", VA = "0x1623420")]
	public void TakePhotograph()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1623820", Offset = "0x1623820", VA = "0x1623820")]
	private Rect ComputePlayerHandsRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x16228F4", Offset = "0x16228F4", VA = "0x16228F4")]
	private void SetRenderCameraProjMatrix()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1623900", Offset = "0x1623900", VA = "0x1623900")]
	private void UpdateCameraPreview()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1623AA8", Offset = "0x1623AA8", VA = "0x1623AA8")]
	private RaycastHit GetProjectedPointOnShadowSurface(Vector3 pointToCheck)
	{
		return default(RaycastHit);
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1622D18", Offset = "0x1622D18", VA = "0x1622D18")]
	private void UpdateDecalPhoto()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x162303C", Offset = "0x162303C", VA = "0x162303C")]
	private void GenerateShadowDecalObject()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x16227E8", Offset = "0x16227E8", VA = "0x16227E8")]
	private void ComputeRenderCameraCornersPos()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1623C10", Offset = "0x1623C10", VA = "0x1623C10")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7214EC", Offset = "0x7214EC")]
	private IEnumerator TakeAPhotoCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1623C7C", Offset = "0x1623C7C", VA = "0x1623C7C")]
	public CameraCapture()
	{
	}
}
[Token(Token = "0x200000C")]
public class FollowTransform : MonoBehaviour
{
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x16298FC", Offset = "0x16298FC", VA = "0x16298FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x16299C4", Offset = "0x16299C4", VA = "0x16299C4")]
	public FollowTransform()
	{
	}
}
[Token(Token = "0x200000D")]
public class Handgun : MonoBehaviour
{
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnShoot;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x162EA2C", Offset = "0x162EA2C", VA = "0x162EA2C")]
	public void Shoot()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x162EAC4", Offset = "0x162EAC4", VA = "0x162EAC4")]
	public void Arm()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x162EB4C", Offset = "0x162EB4C", VA = "0x162EB4C")]
	public Handgun()
	{
	}
}
[Token(Token = "0x200000E")]
public class HelpSetDestination : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PuzzleManager puzzleManager;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool stop;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool on;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	private bool _on;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool reset;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private bool _stop;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	private bool _reset;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool setDestination;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ShadowMesh shadowMesh;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x162EB54", Offset = "0x162EB54", VA = "0x162EB54")]
	private void Start()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x162EB7C", Offset = "0x162EB7C", VA = "0x162EB7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x162EC9C", Offset = "0x162EC9C", VA = "0x162EC9C")]
	public HelpSetDestination()
	{
	}
}
[Token(Token = "0x200000F")]
public class OVRHandPhysicsCapsulesCustom : MonoBehaviour
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private HandSkeletonVisual _handSkeleton;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _capsulesGO;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<BoneCapsule> _capsules;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FC30", Offset = "0x71FC30")]
	private IList<BoneCapsule> <Capsules>k__BackingField;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private OVRPlugin.Skeleton2 _skeleton;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public HandBoneUpdater handUpdater;

	[Token(Token = "0x17000004")]
	public IList<BoneCapsule> Capsules
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0xB2019C", Offset = "0xB2019C", VA = "0xB2019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72159C", Offset = "0x72159C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003F")]
		[Address(RVA = "0xB201A4", Offset = "0xB201A4", VA = "0xB201A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215AC", Offset = "0x7215AC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB201AC", Offset = "0xB201AC", VA = "0xB201AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB201B0", Offset = "0xB201B0", VA = "0xB201B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB208AC", Offset = "0xB208AC", VA = "0xB208AC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB20A70", Offset = "0xB20A70", VA = "0xB20A70")]
	public OVRHandPhysicsCapsulesCustom()
	{
	}
}
[Token(Token = "0x2000010")]
public class BoneCapsule
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FC40", Offset = "0x71FC40")]
	private short <BoneIndex>k__BackingField;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FC50", Offset = "0x71FC50")]
	private Rigidbody <CapsuleRigidbody>k__BackingField;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FC60", Offset = "0x71FC60")]
	private CapsuleCollider <CapsuleCollider>k__BackingField;

	[Token(Token = "0x17000005")]
	public short BoneIndex
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1621490", Offset = "0x1621490", VA = "0x1621490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215BC", Offset = "0x7215BC")]
		get
		{
			return default(short);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1621498", Offset = "0x1621498", VA = "0x1621498")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215CC", Offset = "0x7215CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public Rigidbody CapsuleRigidbody
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x16214A0", Offset = "0x16214A0", VA = "0x16214A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215DC", Offset = "0x7215DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x16214A8", Offset = "0x16214A8", VA = "0x16214A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215EC", Offset = "0x7215EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public CapsuleCollider CapsuleCollider
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x16214B0", Offset = "0x16214B0", VA = "0x16214B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7215FC", Offset = "0x7215FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x16214B8", Offset = "0x16214B8", VA = "0x16214B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x72160C", Offset = "0x72160C")]
		set
		{
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x16214C0", Offset = "0x16214C0", VA = "0x16214C0")]
	public BoneCapsule()
	{
	}
}
[Token(Token = "0x2000011")]
public class PlayerLocomotionSmooth : MonoBehaviour
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody rb;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float movementX;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float movementY;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB227C4", Offset = "0xB227C4", VA = "0xB227C4")]
	private void Start()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB22818", Offset = "0xB22818", VA = "0xB22818")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB228BC", Offset = "0xB228BC", VA = "0xB228BC")]
	private void OnMove(InputValue movementValue)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB22924", Offset = "0xB22924", VA = "0xB22924")]
	public PlayerLocomotionSmooth()
	{
	}
}
[Token(Token = "0x2000012")]
public class PlayerLocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 target;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform cameraRig;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform centerEye;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LineRenderer rayRenderer;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform leftHand;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform rightHand;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform rayOriginLeft;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform rayOriginRight;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform rayOrigin;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int raySegmentCount;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float raySegmentLength;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float rayDropPerSegment;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool rayActivated;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool validTeleportTarget;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public LayerMask collisionMask;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public LayerMask rayStoppingLayers;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Color rayValidColor;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Color rayInvalidColor;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float rotationIncrement;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x71FC70", Offset = "0x71FC70")]
	[SerializeField]
	private MonoBehaviour optionalIActiveStateMono;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private IActiveState optionalActiveState;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private TeleportNode activeNode;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private TeleportNode previousActiveNode;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float previousNodeActivationTime;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private TeleportNode validTargetNode;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public TeleportNode currentNode;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SmoothedVector3 handPosition;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioSource teleportAudioSource;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float teleportRayFacingThreshold;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private bool activatedOnce;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private HandStateManager handStateManager;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string handStateLeft;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string handStateRight;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string previousHand;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public UnityEvent whenPlayerRotate;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public UnityEvent whenPlayerTeleport;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool wasActivatedBeforeDisable;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB22934", Offset = "0xB22934", VA = "0xB22934")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB22A24", Offset = "0xB22A24", VA = "0xB22A24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB22B84", Offset = "0xB22B84", VA = "0xB22B84")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB22BCC", Offset = "0xB22BCC", VA = "0xB22BCC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB22D00", Offset = "0xB22D00", VA = "0xB22D00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB22F30", Offset = "0xB22F30", VA = "0xB22F30")]
	private void LookForTeleportTarget()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB236F4", Offset = "0xB236F4", VA = "0xB236F4")]
	public void DrawRay(Vector3 origin, Vector3 target, Vector3 forward)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB23400", Offset = "0xB23400", VA = "0xB23400")]
	private TeleportNode LookForTeleportTargetRay(Vector3 forwardDirection, float dropPerSegment)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB22C40", Offset = "0xB22C40", VA = "0xB22C40")]
	public void ActivateTeleportRay(Hands hand)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB22B90", Offset = "0xB22B90", VA = "0xB22B90")]
	public void DeactivateTeleportRay()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB2380C", Offset = "0xB2380C", VA = "0xB2380C")]
	public void Teleport()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB23994", Offset = "0xB23994", VA = "0xB23994")]
	public void Teleport(TeleportNode node)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB23664", Offset = "0xB23664", VA = "0xB23664")]
	private void DeactivateNode()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB23A0C", Offset = "0xB23A0C", VA = "0xB23A0C")]
	public void RotatePlayer(Hands hand = Hands.Right)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB23C40", Offset = "0xB23C40", VA = "0xB23C40")]
	public PlayerLocomotionTeleport()
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class Puppet : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F224", Offset = "0x71F224")]
	private sealed class <>c
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Vector3, float> <>9__9_0;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Vector2, float> <>9__9_1;

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xF03D28", Offset = "0xF03D28", VA = "0xF03D28")]
		public <>c()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xF03D30", Offset = "0xF03D30", VA = "0xF03D30")]
		internal float <CreateShadowCollision>b__9_0(Vector3 v)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xF03D38", Offset = "0xF03D38", VA = "0xF03D38")]
		internal float <CreateShadowCollision>b__9_1(Vector2 v)
		{
			return default(float);
		}
	}

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject obj;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 origin;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3[] vertices;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] sortedVectors;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector2> pointsList;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2[] sortedPoints;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Vector3> shadowVerts;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int index;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB25CE0", Offset = "0xB25CE0", VA = "0xB25CE0")]
	public void Create(GameObject go, Vector3 v)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB25D84", Offset = "0xB25D84", VA = "0xB25D84")]
	public void CreateShadowCollision()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB264C4", Offset = "0xB264C4", VA = "0xB264C4")]
	public Puppet()
	{
	}
}
[Token(Token = "0x2000015")]
public class RotatoPotato : MonoBehaviour
{
	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB2999C", Offset = "0xB2999C", VA = "0xB2999C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB299A0", Offset = "0xB299A0", VA = "0xB299A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB29A24", Offset = "0xB29A24", VA = "0xB29A24")]
	public RotatoPotato()
	{
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class Save
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool empty;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string sceneName;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] playerPosition;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float[] playerRotation;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int activePuzzleId;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string currentTeleportNodeName;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int[] zoneCullingIds;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool[] zoneCullingActive;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int[] nodeGroupIds;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool[] nodeGroupActive;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int[] beachPuzzlesFinished;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int[] forestPuzzlesFinished;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int[] cavePuzzlesFinished;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int[] templePuzzlesFinished;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB29B64", Offset = "0xB29B64", VA = "0xB29B64")]
	public Save()
	{
	}
}
[Token(Token = "0x2000017")]
public class ShadowCollision : MonoBehaviour
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] casters;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objInLight;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Puppet> puppets;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<EdgeCollider2D> ecList;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject edgeCollider;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Light light;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float a;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float b;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float c;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB2BDCC", Offset = "0xB2BDCC", VA = "0xB2BDCC")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xB2BE54", Offset = "0xB2BE54", VA = "0xB2BE54")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB2BE58", Offset = "0xB2BE58", VA = "0xB2BE58")]
	private void CheckObjectsInLight()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB2C418", Offset = "0xB2C418", VA = "0xB2C418")]
	public ShadowCollision()
	{
	}
}
[Token(Token = "0x2000018")]
public class ShadowProjectorCamera : MonoBehaviour
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Camera cam;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Shader replacementShader;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xBAD644", Offset = "0xBAD644", VA = "0xBAD644")]
	private void Start()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xBAD6C0", Offset = "0xBAD6C0", VA = "0xBAD6C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xBAD6C4", Offset = "0xBAD6C4", VA = "0xBAD6C4")]
	public ShadowProjectorCamera()
	{
	}
}
[Token(Token = "0x2000019")]
public class SolidShadowCaster : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	private class Edge
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int a;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int b;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1607048", Offset = "0x1607048", VA = "0x1607048")]
		public Edge(int a, int b)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1607080", Offset = "0x1607080", VA = "0x1607080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1607154", Offset = "0x1607154", VA = "0x1607154", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform lightTransform;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh mesh;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int[] triangles;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3[] vertices;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3[] projectedVertices;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LayerMask mask;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 pointOnPlane;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 planeNormal;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3[] newVertices;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> newTriangles;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Mesh newMesh;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MeshCollider newMeshCollider;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MeshFilter filter;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public string lookForTag;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool skinnedMesh;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private SkinnedMeshRenderer skinnedMeshRenderer;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3[][] outsideEdges;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Edge> edges;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Dictionary<int, int> vertexReplacements;

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xBB1534", Offset = "0xBB1534", VA = "0xBB1534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xBB17A0", Offset = "0xBB17A0", VA = "0xBB17A0")]
	private Dictionary<int, int> ComputeVertexWelding(Vector3[] vertices)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xBB1920", Offset = "0xBB1920", VA = "0xBB1920")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xBB2090", Offset = "0xBB2090", VA = "0xBB2090")]
	private void AddEdgeToList(Edge e)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xBB2154", Offset = "0xBB2154", VA = "0xBB2154")]
	private Vector3 ComputeProjection(Vector3 pointOnPlane, Vector3 pointToProject, Vector3 planeNormal, Vector3 lightDirection)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xBB21B8", Offset = "0xBB21B8", VA = "0xBB21B8")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xBB2428", Offset = "0xBB2428", VA = "0xBB2428")]
	public SolidShadowCaster()
	{
	}
}
[Token(Token = "0x200001B")]
public class VolumeSlider : MonoBehaviour
{
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Slider slider;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioGroups group;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerController mixerController;

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xEF94CC", Offset = "0xEF94CC", VA = "0xEF94CC")]
	private void Start()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xEF95EC", Offset = "0xEF95EC", VA = "0xEF95EC")]
	public void SetVolume()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xEF963C", Offset = "0xEF963C", VA = "0xEF963C")]
	public VolumeSlider()
	{
	}
}
[Token(Token = "0x200001C")]
public class ZoneCulling : MonoBehaviour
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsInZone;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public int id;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool[] objectsActive;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _active;

	[Token(Token = "0x17000008")]
	public bool active
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xEFFF20", Offset = "0xEFFF20", VA = "0xEFFF20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xEFFF28", Offset = "0xEFFF28", VA = "0xEFFF28")]
		set
		{
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xEFFF3C", Offset = "0xEFFF3C", VA = "0xEFFF3C")]
	public void On()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xF00080", Offset = "0xF00080", VA = "0xF00080")]
	public void Off()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xF00128", Offset = "0xF00128", VA = "0xF00128")]
	private void MemorizeObjectsActived()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xF001FC", Offset = "0xF001FC", VA = "0xF001FC")]
	public ZoneCulling()
	{
	}
}
[Token(Token = "0x200001D")]
public class PlatformRotating : RestorableObject
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F234", Offset = "0x71F234")]
	private sealed class <RotateCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlatformRotating <>4__this;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float targetLerp;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <lerpValue>5__2;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <animationRunning>5__3;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool <leftRight>5__4;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xF03760", Offset = "0xF03760", VA = "0xF03760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xF037A8", Offset = "0xF037A8", VA = "0xF037A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xF03510", Offset = "0xF03510", VA = "0xF03510")]
		[DebuggerHidden]
		public <RotateCoroutine>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xF0353C", Offset = "0xF0353C", VA = "0xF0353C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xF03540", Offset = "0xF03540", VA = "0xF03540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xF03768", Offset = "0xF03768", VA = "0xF03768", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public UnityEvent OnRotationStarted;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public UnityEvent OnRotationRunning;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public UnityEvent OnRotationFinished;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x71FD00", Offset = "0x71FD00")]
	public float speed;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float rangeTransform;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 localEuler;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Coroutine _cor;

	[Token(Token = "0x17000009")]
	public bool IsCoroutineNull
	{
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB218D8", Offset = "0xB218D8", VA = "0xB218D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB218E8", Offset = "0xB218E8", VA = "0xB218E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB21900", Offset = "0xB21900", VA = "0xB21900")]
	public void Rotate(float targetLerp)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xB21960", Offset = "0xB21960", VA = "0xB21960")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x72161C", Offset = "0x72161C")]
	private IEnumerator RotateCoroutine(float targetLerp)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xB219DC", Offset = "0xB219DC", VA = "0xB219DC", Slot = "6")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xB21A18", Offset = "0xB21A18", VA = "0xB21A18", Slot = "7")]
	public override void Restore()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xB21A5C", Offset = "0xB21A5C", VA = "0xB21A5C")]
	public PlatformRotating()
	{
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200001F")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		private class CameraState
		{
			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1606E28", Offset = "0x1606E28", VA = "0x1606E28")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1606EB0", Offset = "0x1606EB0", VA = "0x1606EB0")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0x1606F2C", Offset = "0x1606F2C", VA = "0x1606F2C")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1606FF4", Offset = "0x1606FF4", VA = "0x1606FF4")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x1607040", Offset = "0x1607040", VA = "0x1607040")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FD1C", Offset = "0x71FD1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FD1C", Offset = "0x71FD1C")]
		public float boost;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x71FD7C", Offset = "0x71FD7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FD7C", Offset = "0x71FD7C")]
		public float positionLerpTime;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x71FDD4", Offset = "0x71FDD4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FDD4", Offset = "0x71FDD4")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FE34", Offset = "0x71FE34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x71FE34", Offset = "0x71FE34")]
		public float rotationLerpTime;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FE8C", Offset = "0x71FE8C")]
		public bool invertY;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputAction movementAction;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private InputAction verticalMovementAction;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private InputAction lookAction;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InputAction boostFactorAction;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool mouseRightButtonPressed;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xBAF4E4", Offset = "0xBAF4E4", VA = "0xBAF4E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xBAFBF0", Offset = "0xBAFBF0", VA = "0xBAFBF0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xBAFC50", Offset = "0xBAFC50", VA = "0xBAFC50")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xBAFCD8", Offset = "0xBAFCD8", VA = "0xBAFCD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xBB0268", Offset = "0xBB0268", VA = "0xBB0268")]
		private float GetBoostFactor()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xBB0144", Offset = "0xBB0144", VA = "0xBB0144")]
		private Vector2 GetInputLookRotation()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xBB0198", Offset = "0xBB0198", VA = "0xBB0198")]
		private bool IsBoostPressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xBAFEF0", Offset = "0xBAFEF0", VA = "0xBAFEF0")]
		private bool IsEscapePressed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xBB003C", Offset = "0xBB003C", VA = "0xBB003C")]
		private bool IsCameraRotationAllowed()
		{
			return default(bool);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xBAFF60", Offset = "0xBAFF60", VA = "0xBAFF60")]
		private bool IsRightMouseButtonDown()
		{
			return default(bool);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xBAFFD0", Offset = "0xBAFFD0", VA = "0xBAFFD0")]
		private bool IsRightMouseButtonUp()
		{
			return default(bool);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xBB02CC", Offset = "0xBB02CC", VA = "0xBB02CC")]
		public SimpleCameraController()
		{
		}
	}
}
namespace TeamPanoptes.Localisation
{
	[Token(Token = "0x2000021")]
	public class TMProDropdownTranslator : Translator
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Dropdown dropdown;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<TMP_Text> optionLabels;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> optionCodes;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xBB4838", Offset = "0xBB4838", VA = "0xBB4838", Slot = "5")]
		public override void Translate(string lg = "")
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xBB4B5C", Offset = "0xBB4B5C", VA = "0xBB4B5C", Slot = "4")]
		public override void CatchComponent()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xBB4D3C", Offset = "0xBB4D3C", VA = "0xBB4D3C")]
		public TMProDropdownTranslator()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TMProTranslator : Translator
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text textComponent;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xBB4D44", Offset = "0xBB4D44", VA = "0xBB4D44", Slot = "5")]
		public override void Translate(string lg = "")
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xBB4FE0", Offset = "0xBB4FE0", VA = "0xBB4FE0", Slot = "4")]
		public override void CatchComponent()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xBB50F8", Offset = "0xBB50F8", VA = "0xBB50F8")]
		public TMProTranslator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TextCatcher : MonoBehaviour
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xBB6314", Offset = "0xBB6314", VA = "0xBB6314")]
		public void UploadText(bool onlyWithComponent = false)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xBB78EC", Offset = "0xBB78EC", VA = "0xBB78EC")]
		private List<string> CatchThemAll()
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xBB76E4", Offset = "0xBB76E4", VA = "0xBB76E4")]
		private List<string> CatchtThemAllWithComponent()
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xBB7E2C", Offset = "0xBB7E2C", VA = "0xBB7E2C")]
		public void ClearAllCode()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xBB7FA8", Offset = "0xBB7FA8", VA = "0xBB7FA8")]
		public TextCatcher()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class Translation
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool loaded;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string PATH;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string FILE_PREFIX;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Dictionary<string, Dictionary<string, string>> traductions;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] languages;

		[Token(Token = "0x40000E7")]
		public const string referenceLanguage = "en";

		[Token(Token = "0x1700000C")]
		public static string currentLanguage
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xBB4AFC", Offset = "0xBB4AFC", VA = "0xBB4AFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public static Dictionary<string, Dictionary<string, string>> Traductions
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xBB81D0", Offset = "0xBB81D0", VA = "0xBB81D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xBB8234", Offset = "0xBB8234", VA = "0xBB8234")]
			set
			{
			}
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xBB6F2C", Offset = "0xBB6F2C", VA = "0xBB6F2C")]
		public static void LoadTraduction()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xBB0C5C", Offset = "0xBB0C5C", VA = "0xBB0C5C")]
		public static string GetTraduction(string id, string lg = "", [Optional] GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xBB829C", Offset = "0xBB829C", VA = "0xBB829C")]
		public static void TranslateScene(string lg = "")
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xBB8480", Offset = "0xBB8480", VA = "0xBB8480")]
		public Translation()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public abstract class Translator : MonoBehaviour
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string code;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xEF7EC0", Offset = "0xEF7EC0", VA = "0xEF7EC0")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xEF7EFC", Offset = "0xEF7EFC", VA = "0xEF7EFC")]
		public void Init()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xEF7F38", Offset = "0xEF7F38", VA = "0xEF7F38")]
		public string GetLanguage()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		public abstract void CatchComponent();

		[Token(Token = "0x60000B8")]
		public abstract void Translate(string lg);

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEF80E8", Offset = "0xEF80E8", VA = "0xEF80E8")]
		protected Translator()
		{
		}
	}
}
namespace Better.StreamingAssets
{
	[Token(Token = "0x2000026")]
	public static class PathUtil
	{
		[Token(Token = "0x2000027")]
		private enum NormalizeState
		{
			[Token(Token = "0x40000EA")]
			PrevSlash,
			[Token(Token = "0x40000EB")]
			PrevDot,
			[Token(Token = "0x40000EC")]
			PrevDoubleDot,
			[Token(Token = "0x40000ED")]
			NothingSpecial
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB20D64", Offset = "0xB20D64", VA = "0xB20D64")]
		public static bool IsDirectorySeparator(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB20D80", Offset = "0xB20D80", VA = "0xB20D80")]
		public static string FixTrailingDirectorySeparators(string path)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xB20EAC", Offset = "0xB20EAC", VA = "0xB20EAC")]
		public static string CombineSlash(string a, string b)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xB21014", Offset = "0xB21014", VA = "0xB21014")]
		public static string NormalizeRelativePath(string relative, bool forceTrailingSlash = false)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xB21440", Offset = "0xB21440", VA = "0xB21440")]
		public static bool IsValidCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xB214A4", Offset = "0xB214A4", VA = "0xB214A4")]
		public static Regex WildcardToRegex(string pattern)
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	internal class SubReadOnlyStream : Stream
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly long m_offset;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly bool m_leaveOpen;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long? m_length;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Stream m_actualStream;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private long m_position;

		[Token(Token = "0x1700000E")]
		public override long Length
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xBB34D4", Offset = "0xBB34D4", VA = "0xBB34D4", Slot = "10")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000F")]
		public override long Position
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xBB361C", Offset = "0xBB361C", VA = "0xBB361C", Slot = "11")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xBB3648", Offset = "0xBB3648", VA = "0xBB3648", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public override bool CanRead
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xBB368C", Offset = "0xBB368C", VA = "0xBB368C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		public override bool CanSeek
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xBB36AC", Offset = "0xBB36AC", VA = "0xBB36AC", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public override bool CanWrite
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xBB36CC", Offset = "0xBB36CC", VA = "0xBB36CC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xBB32F4", Offset = "0xBB32F4", VA = "0xBB32F4")]
		public SubReadOnlyStream(Stream actualStream, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xBB33C4", Offset = "0xBB33C4", VA = "0xBB33C4")]
		public SubReadOnlyStream(Stream actualStream, long offset, long length, bool leaveOpen = false)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xBB36D4", Offset = "0xBB36D4", VA = "0xBB36D4", Slot = "22")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xBB384C", Offset = "0xBB384C", VA = "0xBB384C", Slot = "20")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xBB3914", Offset = "0xBB3914", VA = "0xBB3914", Slot = "21")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xBB3954", Offset = "0xBB3954", VA = "0xBB3954", Slot = "24")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xBB3994", Offset = "0xBB3994", VA = "0xBB3994", Slot = "15")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xBB39D4", Offset = "0xBB39D4", VA = "0xBB39D4", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xBB3594", Offset = "0xBB3594", VA = "0xBB3594")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xBB37F0", Offset = "0xBB37F0", VA = "0xBB37F0")]
		private void ThrowIfCantRead()
		{
		}
	}
}
namespace Better.StreamingAssets.ZipArchive
{
	[Token(Token = "0x2000029")]
	internal struct ZipGenericExtraField
	{
		[Token(Token = "0x40000F3")]
		private const int SizeOfHeader = 4;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _tag;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private ushort _size;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private byte[] _data;

		[Token(Token = "0x17000013")]
		public ushort Tag
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xEFFBB8", Offset = "0xEFFBB8", VA = "0xEFFBB8")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000014")]
		public ushort Size
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xEFFBC0", Offset = "0xEFFBC0", VA = "0xEFFBC0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000015")]
		public byte[] Data
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xEFFBC8", Offset = "0xEFFBC8", VA = "0xEFFBC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xEFEBF0", Offset = "0xEFEBF0", VA = "0xEFEBF0")]
		public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002A")]
	internal struct Zip64ExtraField
	{
		[Token(Token = "0x40000F7")]
		public const int OffsetToFirstField = 4;

		[Token(Token = "0x40000F8")]
		private const ushort TagConstant = 1;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _size;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private long? _uncompressedSize;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private long? _compressedSize;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long? _localHeaderOffset;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int? _startDiskNumber;

		[Token(Token = "0x17000016")]
		public long? UncompressedSize
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xEFE338", Offset = "0xEFE338", VA = "0xEFE338")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xEFE344", Offset = "0xEFE344", VA = "0xEFE344")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public long? CompressedSize
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xEFE3D8", Offset = "0xEFE3D8", VA = "0xEFE3D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xEFE3E4", Offset = "0xEFE3E4", VA = "0xEFE3E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public long? LocalHeaderOffset
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xEFE3EC", Offset = "0xEFE3EC", VA = "0xEFE3EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xEFE3F8", Offset = "0xEFE3F8", VA = "0xEFE3F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public int? StartDiskNumber
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xEFE400", Offset = "0xEFE400", VA = "0xEFE400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xEFE34C", Offset = "0xEFE34C", VA = "0xEFE34C")]
		private void UpdateSize()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xEFE408", Offset = "0xEFE408", VA = "0xEFE408")]
		public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber)
		{
			return default(Zip64ExtraField);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xEFE650", Offset = "0xEFE650", VA = "0xEFE650")]
		private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002B")]
	internal struct Zip64EndOfCentralDirectoryLocator
	{
		[Token(Token = "0x40000FE")]
		public const uint SignatureConstant = 117853008u;

		[Token(Token = "0x40000FF")]
		public const int SizeOfBlockWithoutSignature = 16;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint NumberOfDiskWithZip64EOCD;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong OffsetOfZip64EOCD;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint TotalNumberOfDisks;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEFE158", Offset = "0xEFE158", VA = "0xEFE158")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002C")]
	internal struct Zip64EndOfCentralDirectoryRecord
	{
		[Token(Token = "0x4000103")]
		private const uint SignatureConstant = 101075792u;

		[Token(Token = "0x4000104")]
		private const ulong NormalSize = 44uL;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ulong SizeOfThisRecord;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort VersionMadeBy;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint NumberOfThisDisk;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint NumberOfDiskWithStartOfCD;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong NumberOfEntriesOnThisDisk;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ulong NumberOfEntriesTotal;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ulong SizeOfCentralDirectory;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ulong OffsetOfCentralDirectory;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xEFE1FC", Offset = "0xEFE1FC", VA = "0xEFE1FC")]
		public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002D")]
	internal struct ZipLocalFileHeader
	{
		[Token(Token = "0x400010E")]
		public const uint DataDescriptorSignature = 134695760u;

		[Token(Token = "0x400010F")]
		public const uint SignatureConstant = 67324752u;

		[Token(Token = "0x4000110")]
		public const int OffsetToCrcFromHeaderStart = 14;

		[Token(Token = "0x4000111")]
		public const int OffsetToBitFlagFromHeaderStart = 6;

		[Token(Token = "0x4000112")]
		public const int SizeOfLocalHeader = 30;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEFFD94", Offset = "0xEFFD94", VA = "0xEFFD94")]
		public static bool TrySkipBlock(BinaryReader reader)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002E")]
	internal struct ZipCentralDirectoryFileHeader
	{
		[Token(Token = "0x4000113")]
		public const uint SignatureConstant = 33639248u;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public byte VersionMadeByCompatibility;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public byte VersionMadeBySpecification;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public ushort VersionNeededToExtract;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort GeneralPurposeBitFlag;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort CompressionMethod;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint LastModified;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint Crc32;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public long CompressedSize;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long UncompressedSize;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ushort FilenameLength;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public ushort ExtraFieldLength;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ushort FileCommentLength;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int DiskNumberStart;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ushort InternalFileAttributes;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public uint ExternalFileAttributes;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public long RelativeOffsetOfLocalHeader;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte[] Filename;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public byte[] FileComment;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<ZipGenericExtraField> ExtraFields;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xEFF51C", Offset = "0xEFF51C", VA = "0xEFF51C")]
		public static bool TryReadBlock(BinaryReader reader, out ZipCentralDirectoryFileHeader header)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200002F")]
	internal struct ZipEndOfCentralDirectoryBlock
	{
		[Token(Token = "0x4000127")]
		public const uint SignatureConstant = 101010256u;

		[Token(Token = "0x4000128")]
		public const int SizeOfBlockWithoutSignature = 18;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint Signature;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ushort NumberOfThisDisk;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
		public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
		public ushort NumberOfEntriesInTheCentralDirectory;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint SizeOfCentralDirectory;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte[] ArchiveComment;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xEFF3F4", Offset = "0xEFF3F4", VA = "0xEFF3F4")]
		public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000030")]
	internal static class ZipHelper
	{
		[Token(Token = "0x4000131")]
		internal const uint Mask32Bit = uint.MaxValue;

		[Token(Token = "0x4000132")]
		internal const ushort Mask16Bit = ushort.MaxValue;

		[Token(Token = "0x4000133")]
		private const int BackwardsSeekingBufferSize = 32;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xEFFBD0", Offset = "0xEFFBD0", VA = "0xEFFBD0")]
		internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xEFF2F0", Offset = "0xEFF2F0", VA = "0xEFF2F0")]
		internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEFFAC8", Offset = "0xEFFAC8", VA = "0xEFFAC8")]
		internal static void AdvanceToPosition(this Stream stream, long position)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xEFFC78", Offset = "0xEFFC78", VA = "0xEFFC78")]
		private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public class ZipArchiveException : Exception
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xEFECD4", Offset = "0xEFECD4", VA = "0xEFECD4")]
		public ZipArchiveException(string msg)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xEFED48", Offset = "0xEFED48", VA = "0xEFED48")]
		public ZipArchiveException(string msg, Exception inner)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class ZipArchiveUtils
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xEFEDC4", Offset = "0xEFEDC4", VA = "0xEFEDC4")]
		public static void ReadEndOfCentralDirectory(Stream stream, BinaryReader reader, out long expectedNumberOfEntries, out long centralDirectoryStart)
		{
		}
	}
}
namespace Silhouette
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F254", Offset = "0x71F254")]
	public class AmbienceSoundBlender : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F2B4", Offset = "0x71F2B4")]
		private sealed class <Blending>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AmbienceSoundBlender <>4__this;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool AOrB;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float delay;

			[Token(Token = "0x4000142")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <elapsedDelay>5__2;

			[Token(Token = "0x4000143")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <blendTimeA>5__3;

			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <blendTimeB>5__4;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private bool <ADone>5__5;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			private bool <BDone>5__6;

			[Token(Token = "0x4000147")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			private bool <blendingDone>5__7;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F3")]
				[Address(RVA = "0xF005C8", Offset = "0xF005C8", VA = "0xF005C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0xF00610", Offset = "0xF00610", VA = "0xF00610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xF0020C", Offset = "0xF0020C", VA = "0xF0020C")]
			[DebuggerHidden]
			public <Blending>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xF00238", Offset = "0xF00238", VA = "0xF00238", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xF0023C", Offset = "0xF0023C", VA = "0xF0023C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xF005D0", Offset = "0xF005D0", VA = "0xF005D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] clips;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxDelay;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blendingDuration;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource sourceA;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioSource sourceB;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool AIsCurrent;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool blending;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _cor;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x161E614", Offset = "0x161E614", VA = "0x161E614")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x161E768", Offset = "0x161E768", VA = "0x161E768")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x161E870", Offset = "0x161E870", VA = "0x161E870")]
		private void Switch(bool AOrB)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x161E6FC", Offset = "0x161E6FC", VA = "0x161E6FC")]
		private void Switch(bool AOrB, float delay)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x161E8A4", Offset = "0x161E8A4", VA = "0x161E8A4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7216DC", Offset = "0x7216DC")]
		private IEnumerator Blending(bool AOrB, float delay)
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x161E934", Offset = "0x161E934", VA = "0x161E934")]
		public AmbienceSoundBlender()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Analytics : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Analytics instance;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameManager manager;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<List<string>> data;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string savePath;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x161E950", Offset = "0x161E950", VA = "0x161E950")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x161EA6C", Offset = "0x161EA6C", VA = "0x161EA6C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x161EBB8", Offset = "0x161EBB8", VA = "0x161EBB8")]
		public void AddData(List<string> row)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x161ECAC", Offset = "0x161ECAC", VA = "0x161ECAC")]
		public void Save()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x161F0D8", Offset = "0x161F0D8", VA = "0x161F0D8")]
		public Analytics()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class AreaManager : MonoBehaviour
	{
		[Token(Token = "0x2000037")]
		public enum Biome
		{
			[Token(Token = "0x400015A")]
			Beach,
			[Token(Token = "0x400015B")]
			Forest,
			[Token(Token = "0x400015C")]
			Cave,
			[Token(Token = "0x400015D")]
			Temple
		}

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Biome biome;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PuzzleManager[] puzzles;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int activePuzzleId;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ShadowGun shadowGun;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PuzzleManager activeOnStart;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PuzzleManager currentlyActive;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RenderTexture shadowMaskRenderTexture;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public RayInteractor[] rayInteractors;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public DirectionActiveState[] activeStates;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ZoneCulling[] zonesCulling;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NodeGroup[] nodeGroups;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ZoneCulling[] zonesCullingActivateAtStart;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public NodeGroup[] nodeGroupsAtStart;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x161F72C", Offset = "0x161F72C", VA = "0x161F72C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x161F730", Offset = "0x161F730", VA = "0x161F730")]
		public void Initialize(bool beforeLoading = false)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x161FE5C", Offset = "0x161FE5C", VA = "0x161FE5C")]
		public void ActivatePuzzle(int id)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x161FC5C", Offset = "0x161FC5C", VA = "0x161FC5C")]
		public void ActivatePuzzle(PuzzleManager puzzle)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1620214", Offset = "0x1620214", VA = "0x1620214")]
		public void RestorePuzzle(int id)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1620258", Offset = "0x1620258", VA = "0x1620258")]
		public void RestorePuzzle(PuzzleManager puzzle)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1620270", Offset = "0x1620270", VA = "0x1620270")]
		public void RestoreActivePuzzle()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1620278", Offset = "0x1620278", VA = "0x1620278")]
		public void PuzzleIsFinished(PuzzleManager puzzle)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x162048C", Offset = "0x162048C", VA = "0x162048C")]
		public AreaManager()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class AsyncSceneLoader : MonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AsyncOperation asyncNextScene;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string nextSceneName;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string LOADING_SCENE;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent whenLevelIsReady;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool whenLevelIsReadyInvoked;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x162049C", Offset = "0x162049C", VA = "0x162049C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1620564", Offset = "0x1620564", VA = "0x1620564")]
		private void Update()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x162060C", Offset = "0x162060C", VA = "0x162060C")]
		public static void PrepareLoadingScene([Optional] string sceneName)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x16207B8", Offset = "0x16207B8", VA = "0x16207B8")]
		public static void LoadScene([Optional] string sceneName)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1620854", Offset = "0x1620854", VA = "0x1620854")]
		public AsyncSceneLoader()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class ConfinementZone : MonoBehaviour
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float startingFadeDistance;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float fadeRadius;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Image blindingImage;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform playerHead;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector2 horizontalPosition;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector2 headHorizontalPosition;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float fadeFactor;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TeleportNode teleportNode;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x16246B8", Offset = "0x16246B8", VA = "0x16246B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x16247D0", Offset = "0x16247D0", VA = "0x16247D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x162492C", Offset = "0x162492C", VA = "0x162492C")]
		private float ComputeFadeFactor(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1624940", Offset = "0x1624940", VA = "0x1624940")]
		public ConfinementZone()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ConfinementZoneActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x1700001C")]
		public bool Active
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1624954", Offset = "0x1624954", VA = "0x1624954", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x16249B4", Offset = "0x16249B4", VA = "0x16249B4")]
		public ConfinementZoneActiveState()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class CreditNamesScrolling : MonoBehaviour
	{
		[Token(Token = "0x200003C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F2C4", Offset = "0x71F2C4")]
		private sealed class <Scroll>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000172")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000173")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000174")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CreditNamesScrolling <>4__this;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0xF020F8", Offset = "0xF020F8", VA = "0xF020F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0xF02140", Offset = "0xF02140", VA = "0xF02140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000117")]
			[Address(RVA = "0xF01EC4", Offset = "0xF01EC4", VA = "0xF01EC4")]
			[DebuggerHidden]
			public <Scroll>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000118")]
			[Address(RVA = "0xF01EF0", Offset = "0xF01EF0", VA = "0xF01EF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000119")]
			[Address(RVA = "0xF01EF4", Offset = "0xF01EF4", VA = "0xF01EF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600011B")]
			[Address(RVA = "0xF02100", Offset = "0xF02100", VA = "0xF02100", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Transform> Initialgroups;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Transform> groups;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float offset;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float speed;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float yLimit;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float spaceAfterEnd;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float lastY;

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x16249BC", Offset = "0x16249BC", VA = "0x16249BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1624A3C", Offset = "0x1624A3C", VA = "0x1624A3C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1624C10", Offset = "0x1624C10", VA = "0x1624C10")]
		public void Run()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1624CBC", Offset = "0x1624CBC", VA = "0x1624CBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1624CC4", Offset = "0x1624CC4", VA = "0x1624CC4")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1624C50", Offset = "0x1624C50", VA = "0x1624C50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x72178C", Offset = "0x72178C")]
		private IEnumerator Scroll()
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1624CCC", Offset = "0x1624CCC", VA = "0x1624CCC")]
		public CreditNamesScrolling()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class CutsceneDirector : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayableDirector introDirector;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayableDirector endingDirector;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool playEndingOnStart;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x16250B8", Offset = "0x16250B8", VA = "0x16250B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x162517C", Offset = "0x162517C", VA = "0x162517C")]
		public void PlayIntro()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1625160", Offset = "0x1625160", VA = "0x1625160")]
		public void PlayEnding()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1625198", Offset = "0x1625198", VA = "0x1625198")]
		public CutsceneDirector()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class DemoLevelButton : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text text;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1625458", Offset = "0x1625458", VA = "0x1625458")]
		private void Start()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1625590", Offset = "0x1625590", VA = "0x1625590")]
		public void ChangeDemoMode()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x16256A8", Offset = "0x16256A8", VA = "0x16256A8")]
		public DemoLevelButton()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F2D4", Offset = "0x71F2D4")]
	public class DM_RandomAudioPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] audioClips;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioSource audioSource;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minPitch;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxPitch;

		[Token(Token = "0x1700001F")]
		public bool isPlaying
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x16251A4", Offset = "0x16251A4", VA = "0x16251A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1625288", Offset = "0x1625288", VA = "0x1625288")]
		public void PlayRandomAudioClip()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x16253F4", Offset = "0x16253F4", VA = "0x16253F4")]
		public DM_RandomAudioPlayer()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class DestinationMarker : MonoBehaviour
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Sprite spritePathOk;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Sprite spritePathNotOk;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color colorPathOk;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color colorPathNotOk;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SpriteRenderer _spriteRenderer;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WayPoint wayPoint;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PuzzleManager puzzleManager;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _isActive;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isPreview;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool _destinationIsValid;

		[Token(Token = "0x17000020")]
		private SpriteRenderer spriteRenderer
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x16256B0", Offset = "0x16256B0", VA = "0x16256B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public bool isActive
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x16257E8", Offset = "0x16257E8", VA = "0x16257E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x16257F0", Offset = "0x16257F0", VA = "0x16257F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public bool isPreview
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1625834", Offset = "0x1625834", VA = "0x1625834")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x162583C", Offset = "0x162583C", VA = "0x162583C")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public bool destinationIsValid
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x16258C4", Offset = "0x16258C4", VA = "0x16258C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x16258CC", Offset = "0x16258CC", VA = "0x16258CC")]
			set
			{
			}
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1625984", Offset = "0x1625984", VA = "0x1625984")]
		private void Start()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1625988", Offset = "0x1625988", VA = "0x1625988")]
		public void Initialize(PuzzleManager puzzleManager)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1625990", Offset = "0x1625990", VA = "0x1625990")]
		private void Update()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1625A60", Offset = "0x1625A60", VA = "0x1625A60")]
		public void SetPosition(WayPoint wp)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1625B38", Offset = "0x1625B38", VA = "0x1625B38")]
		public void SetPosition(WayPoint wp, GameObject item)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1625C88", Offset = "0x1625C88", VA = "0x1625C88")]
		public DestinationMarker()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class DestroyIfNotDebug : MonoBehaviour
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1625C90", Offset = "0x1625C90", VA = "0x1625C90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1625D08", Offset = "0x1625D08", VA = "0x1625D08")]
		public DestroyIfNotDebug()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class DestroyIfNotDemo : MonoBehaviour
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1625D10", Offset = "0x1625D10", VA = "0x1625D10")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1625D88", Offset = "0x1625D88", VA = "0x1625D88")]
		public DestroyIfNotDemo()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class DirectionActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layerMask;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayInteractor interactor;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayIndicator indicator;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform originPointer;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71FF04", Offset = "0x71FF04")]
		public bool isLeftRight;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform handAnchor;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public ShadowMesh shadowMesh;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float maximumAngleFromReferenceDirection;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private RaycastHit hit;

		[Token(Token = "0x17000024")]
		public bool Active
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1625D90", Offset = "0x1625D90", VA = "0x1625D90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1626164", Offset = "0x1626164", VA = "0x1626164")]
		private bool IsBetweenLanternAndSurface()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x16262C4", Offset = "0x16262C4", VA = "0x16262C4")]
		private Vector3 GetTargetPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1626490", Offset = "0x1626490", VA = "0x1626490")]
		public DirectionActiveState()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class DisableButtonOnClose : MonoBehaviour
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject button;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1626498", Offset = "0x1626498", VA = "0x1626498")]
		public void DisableButton()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x16264B8", Offset = "0x16264B8", VA = "0x16264B8")]
		public DisableButtonOnClose()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class DisableInMenuActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x17000025")]
		public bool Active
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x16264C0", Offset = "0x16264C0", VA = "0x16264C0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x162652C", Offset = "0x162652C", VA = "0x162652C")]
		public DisableInMenuActiveState()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class DisableLayersOnMainCamera : MonoBehaviour
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera mainCamera;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1626534", Offset = "0x1626534", VA = "0x1626534")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x16265C8", Offset = "0x16265C8", VA = "0x16265C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x162665C", Offset = "0x162665C", VA = "0x162665C")]
		public DisableLayersOnMainCamera()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class DoorChip : MonoBehaviour
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DoorSlide door;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource activateAudioSource;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource deactivateAudioSource;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform buttonTransform;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool activated;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayerBracelet bracelet;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1626664", Offset = "0x1626664", VA = "0x1626664")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x162677C", Offset = "0x162677C", VA = "0x162677C")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1626864", Offset = "0x1626864", VA = "0x1626864")]
		public void OpenDoor()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x16268E4", Offset = "0x16268E4", VA = "0x16268E4")]
		public DoorChip()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public class DoorOpeningButton : MonoBehaviour
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DoorSlide door;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x16268EC", Offset = "0x16268EC", VA = "0x16268EC")]
		public void OpenDoor()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1626930", Offset = "0x1626930", VA = "0x1626930")]
		public DoorOpeningButton()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class DoorSlide : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F334", Offset = "0x71F334")]
		private sealed class <_SendUnlockShapes>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DoorSlide <>4__this;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <numShapes>5__2;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <i>5__3;

			[Token(Token = "0x17000027")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000158")]
				[Address(RVA = "0xF0294C", Offset = "0xF0294C", VA = "0xF0294C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000028")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600015A")]
				[Address(RVA = "0xF02994", Offset = "0xF02994", VA = "0xF02994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000155")]
			[Address(RVA = "0xF025E4", Offset = "0xF025E4", VA = "0xF025E4")]
			[DebuggerHidden]
			public <_SendUnlockShapes>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000156")]
			[Address(RVA = "0xF02610", Offset = "0xF02610", VA = "0xF02610", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000157")]
			[Address(RVA = "0xF02614", Offset = "0xF02614", VA = "0xF02614", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000159")]
			[Address(RVA = "0xF02954", Offset = "0xF02954", VA = "0xF02954", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F344", Offset = "0x71F344")]
		private sealed class <_Open>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DoorSlide <>4__this;

			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <startPosition>5__2;

			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <time>5__3;

			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <ratio>5__4;

			[Token(Token = "0x17000029")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600015E")]
				[Address(RVA = "0xF02594", Offset = "0xF02594", VA = "0xF02594", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000160")]
				[Address(RVA = "0xF025DC", Offset = "0xF025DC", VA = "0xF025DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0xF023A0", Offset = "0xF023A0", VA = "0xF023A0")]
			[DebuggerHidden]
			public <_Open>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x600015C")]
			[Address(RVA = "0xF023CC", Offset = "0xF023CC", VA = "0xF023CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0xF023D0", Offset = "0xF023D0", VA = "0xF023D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0xF0259C", Offset = "0xF0259C", VA = "0xF0259C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200004C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F354", Offset = "0x71F354")]
		private sealed class <_Close>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DoorSlide <>4__this;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <startPosition>5__2;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <time>5__3;

			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <ratio>5__4;

			[Token(Token = "0x1700002B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000164")]
				[Address(RVA = "0xF02350", Offset = "0xF02350", VA = "0xF02350", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0xF02398", Offset = "0xF02398", VA = "0xF02398", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000161")]
			[Address(RVA = "0xF02148", Offset = "0xF02148", VA = "0xF02148")]
			[DebuggerHidden]
			public <_Close>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000162")]
			[Address(RVA = "0xF02174", Offset = "0xF02174", VA = "0xF02174", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000163")]
			[Address(RVA = "0xF02178", Offset = "0xF02178", VA = "0xF02178", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000165")]
			[Address(RVA = "0xF02358", Offset = "0xF02358", VA = "0xF02358", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource sound;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource tryUnlockSound;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float duration;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 positionClosed;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 positionOpened;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent beforeOpening;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent afterOpening;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent beforeClosing;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent afterClosing;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isOpening;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool isClosing;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool open;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool ready;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DoorSlide> surroundingDoors;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool otherDoorSoundPlaying;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float initialSoundVolume;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float lowerSoundVolume;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] unlockShapePositions;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int numberOfPuzzlesDoneRequired;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool arePuzzlesRequiredInTemple;

		[Token(Token = "0x17000026")]
		private bool canBeUnlocked
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1626938", Offset = "0x1626938", VA = "0x1626938")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x16269B0", Offset = "0x16269B0", VA = "0x16269B0")]
		public void Start()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1626B40", Offset = "0x1626B40", VA = "0x1626B40")]
		public void Open()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1626C0C", Offset = "0x1626C0C", VA = "0x1626C0C")]
		public void Close()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x16268B4", Offset = "0x16268B4", VA = "0x16268B4")]
		public void SendUnlockShapes()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1626CCC", Offset = "0x1626CCC", VA = "0x1626CCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x72183C", Offset = "0x72183C")]
		private IEnumerator _SendUnlockShapes()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1626BA0", Offset = "0x1626BA0", VA = "0x1626BA0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x72189C", Offset = "0x72189C")]
		private IEnumerator _Open()
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1626C60", Offset = "0x1626C60", VA = "0x1626C60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7218FC", Offset = "0x7218FC")]
		private IEnumerator _Close()
		{
			return null;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1626D38", Offset = "0x1626D38", VA = "0x1626D38")]
		public void CheckForOtherDoorSound()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1626B08", Offset = "0x1626B08", VA = "0x1626B08")]
		public void ResetSoundVolume()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1626E08", Offset = "0x1626E08", VA = "0x1626E08")]
		public DoorSlide()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class Edge
	{
		[Token(Token = "0x200004E")]
		public enum Etype
		{
			[Token(Token = "0x40001C3")]
			nwUpwards,
			[Token(Token = "0x40001C4")]
			nwDownwards,
			[Token(Token = "0x40001C5")]
			wStraightRight,
			[Token(Token = "0x40001C6")]
			nwStraightLeft,
			[Token(Token = "0x40001C7")]
			wDownwardsRight,
			[Token(Token = "0x40001C8")]
			wUpwardsLeft,
			[Token(Token = "0x40001C9")]
			nwDownwardsLeft,
			[Token(Token = "0x40001CA")]
			nwUpwardsLeft,
			[Token(Token = "0x40001CB")]
			nwTop,
			[Token(Token = "0x40001CC")]
			wHandStraight,
			[Token(Token = "0x40001CD")]
			wHandDownwardsRight,
			[Token(Token = "0x40001CE")]
			wHandUpwardsLeft,
			[Token(Token = "0x40001CF")]
			undefined
		}

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 a;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 b;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Etype etype;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1626F98", Offset = "0x1626F98", VA = "0x1626F98")]
		public Edge(Vector3 a, Vector3 b, Etype etype = Etype.undefined)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1627000", Offset = "0x1627000", VA = "0x1627000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x16270CC", Offset = "0x16270CC", VA = "0x16270CC")]
		public static bool operator ==(Edge leftEdge, Edge rightEdge)
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x162711C", Offset = "0x162711C", VA = "0x162711C")]
		public static bool operator !=(Edge edgeLeft, Edge edgeRight)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1627138", Offset = "0x1627138", VA = "0x1627138", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x16271DC", Offset = "0x16271DC", VA = "0x16271DC")]
		public static int SearchEdgeIndex(Vector3 point, List<Edge> edges, Transform wall, [Optional] int[] bounds)
		{
			return default(int);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x162738C", Offset = "0x162738C", VA = "0x162738C")]
		public Edge2D ProjectOnTransform(Transform t)
		{
			return null;
		}
	}
	[Token(Token = "0x200004F")]
	public class Edge2D
	{
		[Token(Token = "0x2000050")]
		public enum Etype
		{
			[Token(Token = "0x40001D5")]
			nwUpwards,
			[Token(Token = "0x40001D6")]
			nwDownwards,
			[Token(Token = "0x40001D7")]
			wStraightRight,
			[Token(Token = "0x40001D8")]
			nwStraightLeft,
			[Token(Token = "0x40001D9")]
			wDownwardsRight,
			[Token(Token = "0x40001DA")]
			wUpwardsLeft,
			[Token(Token = "0x40001DB")]
			nwDownwardsLeft,
			[Token(Token = "0x40001DC")]
			nwUpwardsLeft,
			[Token(Token = "0x40001DD")]
			nwTop,
			[Token(Token = "0x40001DE")]
			wHandStraight,
			[Token(Token = "0x40001DF")]
			wHandDownwardsRight,
			[Token(Token = "0x40001E0")]
			wHandUpwardsLeft,
			[Token(Token = "0x40001E1")]
			undefined
		}

		[Token(Token = "0x2000051")]
		private class SortByIncreasingXHelper : IComparer
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xF02B44", Offset = "0xF02B44", VA = "0xF02B44", Slot = "4")]
			private int System.Collections.IComparer.Compare(object a, object b)
			{
				return default(int);
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0xF02C28", Offset = "0xF02C28", VA = "0xF02C28")]
			public SortByIncreasingXHelper()
			{
			}
		}

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 a;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 b;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Etype etype;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _length;

		[Token(Token = "0x1700002D")]
		public float length
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x16274BC", Offset = "0x16274BC", VA = "0x16274BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002E")]
		public Vector2 direction
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x16275A8", Offset = "0x16275A8", VA = "0x16275A8")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x16274F8", Offset = "0x16274F8", VA = "0x16274F8")]
		public static IComparer SortByIncreasingX()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1627550", Offset = "0x1627550", VA = "0x1627550")]
		public Edge2D()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1627460", Offset = "0x1627460", VA = "0x1627460")]
		public Edge2D(Vector2 a, Vector2 b, Etype etype = Etype.undefined)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1627560", Offset = "0x1627560", VA = "0x1627560")]
		public void Update(Edge2DData edge2DData)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x16275D8", Offset = "0x16275D8", VA = "0x16275D8")]
		public new string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1627664", Offset = "0x1627664", VA = "0x1627664")]
		public bool Equals(Edge2D other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x162772C", Offset = "0x162772C", VA = "0x162772C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x16276E4", Offset = "0x16276E4", VA = "0x16276E4")]
		public static bool operator ==(Edge2D leftEdge, Edge2D rightEdge)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1627734", Offset = "0x1627734", VA = "0x1627734")]
		public static bool operator !=(Edge2D edgeLeft, Edge2D edgeRight)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1627750", Offset = "0x1627750", VA = "0x1627750", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x16277E0", Offset = "0x16277E0", VA = "0x16277E0")]
		private bool IsCounterClockWise(Vector2 a, Vector2 b, Vector2 c)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1627804", Offset = "0x1627804", VA = "0x1627804")]
		public bool Intersect(Edge2D other)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x16278FC", Offset = "0x16278FC", VA = "0x16278FC")]
		public bool Intersect(Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x16279E0", Offset = "0x16279E0", VA = "0x16279E0")]
		public Edge2D Move(Vector2 move)
		{
			return null;
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1627A80", Offset = "0x1627A80", VA = "0x1627A80")]
		public static int SearchEdgeIndex(Vector2 point, List<Edge2D> edges, Transform wall, [Optional] int[] bounds)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000052")]
	public class WayPoint
	{
		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector2 point;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HashSet<WayPoint> walkPoints;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<WayPoint> jumpPoints;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HashSet<WayPoint> fallPoints;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HashSet<WayPoint> reverseFallPoints;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<ShadowPersonAgent, float> weights;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float DistanceFromGoal;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Edge2D edge;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Edge2D.Etype edgeType;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool isOnHand;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int type;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xEFD9C0", Offset = "0xEFD9C0", VA = "0xEFD9C0")]
		public WayPoint(Vector2 point, Edge2D.Etype edgeType)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEFDB1C", Offset = "0xEFDB1C", VA = "0xEFDB1C")]
		public WayPoint(Vector2 point, WayPoint[] walkPoints, Edge2D.Etype edgeType)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xEFDB9C", Offset = "0xEFDB9C", VA = "0xEFDB9C")]
		public void addWalkPoint(WayPoint point)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEFDC18", Offset = "0xEFDC18", VA = "0xEFDC18")]
		public void addJumpPoint(WayPoint point)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEFDC94", Offset = "0xEFDC94", VA = "0xEFDC94")]
		public void addFallPoint(WayPoint point)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEFDD50", Offset = "0xEFDD50", VA = "0xEFDD50")]
		public void Update(Vector2 point, Edge2D.Etype edgeType)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEFDE3C", Offset = "0xEFDE3C", VA = "0xEFDE3C")]
		public void Update(Vector2 point, WayPoint[] walkPoints, Edge2D.Etype edgeType)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEFDEBC", Offset = "0xEFDEBC", VA = "0xEFDEBC")]
		public bool Equals(WayPoint other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEFDEF0", Offset = "0xEFDEF0", VA = "0xEFDEF0")]
		public void AddWeight(ShadowPersonAgent agent, float value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xEFDFCC", Offset = "0xEFDFCC", VA = "0xEFDFCC")]
		public static int SearchEdgeIndex(Vector2 point, List<WayPoint> edges, [Optional] int[] bounds)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000053")]
	public class EnableInMenuActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x1700002F")]
		public bool Active
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1627C1C", Offset = "0x1627C1C", VA = "0x1627C1C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1627C80", Offset = "0x1627C80", VA = "0x1627C80")]
		public EnableInMenuActiveState()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EndingUnlocker : MonoBehaviour
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1627C88", Offset = "0x1627C88", VA = "0x1627C88")]
		private void Start()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1627DAC", Offset = "0x1627DAC", VA = "0x1627DAC")]
		public EndingUnlocker()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class FaucetTapSplashSoundController : MonoBehaviour
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioSource faucetAudioSource;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DM_RandomAudioPlayer DM_RandomAudioPlayer;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource splashAudioSource;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool handInWater;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public WaterFlow[] waterFlows;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool theWaterIsFlowing;

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1627DB4", Offset = "0x1627DB4", VA = "0x1627DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1627FC8", Offset = "0x1627FC8", VA = "0x1627FC8")]
		private void SplashMusic()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1628004", Offset = "0x1628004", VA = "0x1628004")]
		private void FaucetMusic()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x162803C", Offset = "0x162803C", VA = "0x162803C")]
		public FaucetTapSplashSoundController()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public static class FeatureFlags
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool recordingCamera;
	}
	[Token(Token = "0x2000057")]
	public class FingerPointerPose : MonoBehaviour
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x71FF6C", Offset = "0x71FF6C")]
		[SerializeField]
		private MonoBehaviour _handRef;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FFDC", Offset = "0x71FFDC")]
		private IHand <HandRef>k__BackingField;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandFinger finger;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private HandJointId poseJoint;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion pointFingerTipForward;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SmoothedVector3 fingerTipPosition;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SmoothedVector3 handPosition;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Hands hand;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform handTransform;

		[Token(Token = "0x17000030")]
		public IHand HandRef
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x1628094", Offset = "0x1628094", VA = "0x1628094")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A4C", Offset = "0x721A4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x162809C", Offset = "0x162809C", VA = "0x162809C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A5C", Offset = "0x721A5C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x16280A4", Offset = "0x16280A4", VA = "0x16280A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16281EC", Offset = "0x16281EC", VA = "0x16281EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1628530", Offset = "0x1628530", VA = "0x1628530")]
		public FingerPointerPose()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class FinishTest : MonoBehaviour
	{
		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AreaManager areaManager;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject puzzle;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool weTest;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PuzzleManager[] puzzleCollection;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1628538", Offset = "0x1628538", VA = "0x1628538")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x16285D4", Offset = "0x16285D4", VA = "0x16285D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x162864C", Offset = "0x162864C", VA = "0x162864C")]
		private void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x16285E4", Offset = "0x16285E4", VA = "0x16285E4")]
		private void EveryFinishedPuzzle()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x16286DC", Offset = "0x16286DC", VA = "0x16286DC")]
		public FinishTest()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class Flow
	{
		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool flowing;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 start;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 startVelocity;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] currentPoints;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int startIndex;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int endIndex;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool hitSomething;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 directionNormal;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly int maxIndex;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public RaycastHit hit;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RaycastHit[] hits;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly WaterFlow waterFlow;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float timer;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Collider ignoredCollider;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Collider currentCollider;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		public Collider lastCollider;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Flow subFlow;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private int subFlowIndex;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private float subFlowTime;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float startTime;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float endTime;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float maxTime;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[HideInInspector]
		public bool readyToDelete;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		private bool dirty;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16286EC", Offset = "0x16286EC", VA = "0x16286EC")]
		public Flow(WaterFlow waterFlow, Vector3 startingPosition, Vector3 startingVelocity, bool flowing = true, [Optional] Collider ignoredCollider, int maxIndex = 0, float startTime = 0f, float endTime = 0f)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16287F8", Offset = "0x16287F8", VA = "0x16287F8")]
		public Vector3 PlotTrajectoryAtTime(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x16288A4", Offset = "0x16288A4", VA = "0x16288A4")]
		private Vector3 GetVelocityAtTime(float time)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1628918", Offset = "0x1628918", VA = "0x1628918")]
		public void PlotTrajectory(float timestep, Vector3 constraintAxis)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1629058", Offset = "0x1629058", VA = "0x1629058")]
		private void CreateSubFlow(Vector3 position, Vector3 velocity, int index, float time)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1629030", Offset = "0x1629030", VA = "0x1629030")]
		private void StopSubFlow()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x16291A0", Offset = "0x16291A0", VA = "0x16291A0")]
		public bool UpdateFlow(Vector3 constraintAxis, float dt)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x16292DC", Offset = "0x16292DC", VA = "0x16292DC")]
		private void DrawTrajectory()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class FollowHand : MonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool followBothHands;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform wrist;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform dominantWrist;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform secondaryWrist;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRHand dominantOVRHand;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRHand secondaryOVRHand;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform button;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isButtonActive;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 currentVelocity;

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x162676C", Offset = "0x162676C", VA = "0x162676C")]
		public void SetChipActive(bool state, Transform buttonTransform)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16294D4", Offset = "0x16294D4", VA = "0x16294D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16295D4", Offset = "0x16295D4", VA = "0x16295D4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1629848", Offset = "0x1629848", VA = "0x1629848")]
		public FollowHand()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class GameManager : MonoBehaviour
	{
		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static GameManager instance;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool isInMenu;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public AreaManager currentAreaManager;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public SaveManager saveManager;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public List<int> beachPuzzlesFinished;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<int> forestPuzzlesFinished;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public List<int> cavePuzzlesFinished;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public List<int> templePuzzlesFinished;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public List<int> currentAreaPuzzlesFinished;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[HideInInspector]
		public bool whiteOut;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7200FC", Offset = "0x7200FC")]
		public List<TeleportNode> startingNodes;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Analytics analytics;

		[Token(Token = "0x17000031")]
		public static bool isDemoMode
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1625588", Offset = "0x1625588", VA = "0x1625588")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1625658", Offset = "0x1625658", VA = "0x1625658")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public int puzzlesOutsideTempleCompleted
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x16299CC", Offset = "0x16299CC", VA = "0x16299CC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000033")]
		public int puzzlesInsideTempleCompleted
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1629A38", Offset = "0x1629A38", VA = "0x1629A38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public int puzzlesCompleted
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1627D7C", Offset = "0x1627D7C", VA = "0x1627D7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1629A84", Offset = "0x1629A84", VA = "0x1629A84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1629C24", Offset = "0x1629C24", VA = "0x1629C24")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x162A2E4", Offset = "0x162A2E4", VA = "0x162A2E4")]
		public void ConnectAnalytics(Analytics analytics)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x16200E4", Offset = "0x16200E4", VA = "0x16200E4")]
		public void AddAnalytic(string code, string comment = "")
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1620400", Offset = "0x1620400", VA = "0x1620400")]
		public void SaveAnalytics()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x162A2EC", Offset = "0x162A2EC", VA = "0x162A2EC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x162A370", Offset = "0x162A370", VA = "0x162A370")]
		public void SetActiveAreaManager(AreaManager areaManager)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x161FCF0", Offset = "0x161FCF0", VA = "0x161FCF0")]
		public void SetPuzzlesFinishedState(AreaManager area)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1620360", Offset = "0x1620360", VA = "0x1620360")]
		public void AddPuzzleToFinishedList(int id)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x162A494", Offset = "0x162A494", VA = "0x162A494")]
		public bool ThereIsEnoughPuzzlesDone(int number, bool isInTemple = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x162A4C8", Offset = "0x162A4C8", VA = "0x162A4C8")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1629D30", Offset = "0x1629D30", VA = "0x1629D30")]
		private void InitializeSaveManagerAndArea()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x162A588", Offset = "0x162A588", VA = "0x162A588")]
		public GameManager()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public static class GameOptions
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float teleportTime;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float sittingOffset;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float standingOffset;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x162A654", Offset = "0x162A654", VA = "0x162A654")]
		public static void UpdateOption(string name, float value)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x162A7E4", Offset = "0x162A7E4", VA = "0x162A7E4")]
		public static void UpdateOption(string name, int value)
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class Goal : MonoBehaviour
	{
		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject lockGO;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject blockGO;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gate gate;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isLocked;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isBlocked;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SpawnPoint spawnPoint;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool initialLocked;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PuzzleManager puzzleManager;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform checkShadow;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnlockShape unlockShape;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool inTemple;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x162AB34", Offset = "0x162AB34", VA = "0x162AB34")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x162AC84", Offset = "0x162AC84", VA = "0x162AC84")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x162AAF8", Offset = "0x162AAF8", VA = "0x162AAF8")]
		public void SetLock(bool locked)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x162AD78", Offset = "0x162AD78", VA = "0x162AD78")]
		public void ResetGoal()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x162AE2C", Offset = "0x162AE2C", VA = "0x162AE2C")]
		public void EmitUnlockShape()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x162ABE8", Offset = "0x162ABE8", VA = "0x162ABE8")]
		public void SetBlockingState(bool IsBlocked)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x162AEA8", Offset = "0x162AEA8", VA = "0x162AEA8")]
		public bool IsInShadow()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x162AF10", Offset = "0x162AF10", VA = "0x162AF10")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x162AFAC", Offset = "0x162AFAC", VA = "0x162AFAC")]
		public Goal()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public class HandActionSelector : MonoBehaviour, ISelector
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F364", Offset = "0x71F364")]
		private sealed class <>c
		{
			[Token(Token = "0x4000240")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000241")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__8_0;

			[Token(Token = "0x4000242")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action <>9__8_1;

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0xF02C90", Offset = "0xF02C90", VA = "0xF02C90")]
			public <>c()
			{
			}

			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xF02C98", Offset = "0xF02C98", VA = "0xF02C98")]
			internal void <.ctor>b__8_0()
			{
			}

			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xF02C9C", Offset = "0xF02C9C", VA = "0xF02C9C")]
			internal void <.ctor>b__8_1()
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event Action OnSelect
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x162B7B4", Offset = "0x162B7B4", VA = "0x162B7B4", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A6C", Offset = "0x721A6C")]
			add
			{
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x162B854", Offset = "0x162B854", VA = "0x162B854", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A7C", Offset = "0x721A7C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action OnRelease
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x162B8F4", Offset = "0x162B8F4", VA = "0x162B8F4", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A8C", Offset = "0x721A8C")]
			add
			{
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x162B994", Offset = "0x162B994", VA = "0x162B994", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721A9C", Offset = "0x721A9C")]
			remove
			{
			}
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x162BA34", Offset = "0x162BA34", VA = "0x162BA34")]
		public void ActionDetected()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x162BAC0", Offset = "0x162BAC0", VA = "0x162BAC0")]
		public void ActionEnded()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x162BB4C", Offset = "0x162BB4C", VA = "0x162BB4C")]
		public HandActionSelector()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class HandBlindzones : MonoBehaviour
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float handsDeactivationDistance;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform playerLHand;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform playerRHand;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float leftHandToNodeDistance;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float rightHandToNodeDistance;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoxCollider leftHandWaterCollider;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoxCollider rightHandWaterCollider;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRHandPhysicsCapsulesCustom leftHandCapsules;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRHandPhysicsCapsulesCustom rightHandCapsules;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer leftHandRenderer;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer rightHandRenderer;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TeleportNode teleportNode;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<Material> handMaterials;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PokeInteractor leftPokeInteractor;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PokeInteractor rightPokeInteractor;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private GrabInteractor leftGrabInteractor;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GrabInteractor rightGrabInteractor;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 leftHandPosition;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector2 rightHandPosition;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector2 activeNodePosition;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		public bool leftHandActive;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[HideInInspector]
		public bool rightHandActive;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x162BCD0", Offset = "0x162BCD0", VA = "0x162BCD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x162BDF4", Offset = "0x162BDF4", VA = "0x162BDF4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x162BFA0", Offset = "0x162BFA0", VA = "0x162BFA0")]
		private void DeactivatePlayerHand(bool onOff, string side)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x162C3F8", Offset = "0x162C3F8", VA = "0x162C3F8")]
		public void SetHandsActive(bool onOff)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x162C408", Offset = "0x162C408", VA = "0x162C408")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x162C4B4", Offset = "0x162C4B4", VA = "0x162C4B4")]
		public HandBlindzones()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class HandBoneUpdater : RunOnSpecificFrames
	{
		[Serializable]
		[Token(Token = "0x2000062")]
		public struct HandBoneLink
		{
			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform originBone;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform destinationBone;
		}

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform originParent;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform destinationParent;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform originArmature;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform destinationArmature;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x720174", Offset = "0x720174")]
		public HandBoneLink[] boneLinks;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool paused;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool focus;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[SerializeField]
		private bool updateArmatureScale;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Renderer handRenderer;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float disappearDuration;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float disappearTime;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float opacity;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private bool startToDisappear;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[SerializeField]
		private bool disappearing;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Hand hand;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x162C4C4", Offset = "0x162C4C4", VA = "0x162C4C4")]
		private void PopulateLinks()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x162C620", Offset = "0x162C620", VA = "0x162C620")]
		private new void Update()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x162C794", Offset = "0x162C794", VA = "0x162C794")]
		private void UpdateHandOpacity()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x162C7FC", Offset = "0x162C7FC", VA = "0x162C7FC")]
		private void OnApplicationPause(bool isPaused)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x162CA4C", Offset = "0x162CA4C", VA = "0x162CA4C")]
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x162C838", Offset = "0x162C838", VA = "0x162C838")]
		private void UpdateBonesTransforms()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x162CA58", Offset = "0x162CA58", VA = "0x162CA58", Slot = "8")]
		public override void IntervalLateUpdate()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x162CAB8", Offset = "0x162CAB8", VA = "0x162CAB8")]
		public HandBoneUpdater()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class HandColliderDisabler : MonoBehaviour
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OVRHandPhysicsCapsulesCustom[] physicsCapsules;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoxCollider[] handColliders;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AreaManager areaManager;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowMesh activeShadowMesh;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float dotProductThreshold;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 playerForward;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 puzzleForward;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float playerToPuzzleDirection;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool initialFacing;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x162CBD4", Offset = "0x162CBD4", VA = "0x162CBD4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x162CC70", Offset = "0x162CC70", VA = "0x162CC70")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x162CD08", Offset = "0x162CD08", VA = "0x162CD08")]
		private void PuzzleInteractionEnabler()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x162CE24", Offset = "0x162CE24", VA = "0x162CE24")]
		public void EnableHandsCollider(bool onOff)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x162D04C", Offset = "0x162D04C", VA = "0x162D04C")]
		public HandColliderDisabler()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public interface IRestorable
	{
		[Token(Token = "0x60001E6")]
		void Initialize();

		[Token(Token = "0x60001E7")]
		void Restore();
	}
	[Token(Token = "0x2000065")]
	public interface IRunOnSpecificFrames
	{
		[Token(Token = "0x60001E8")]
		void IntervalUpdate();

		[Token(Token = "0x60001E9")]
		void NonIntervalUpdate();
	}
	[Token(Token = "0x2000066")]
	public class InGameMenu : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F374", Offset = "0x71F374")]
		private sealed class <Disable>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InGameMenu <>4__this;

			[Token(Token = "0x17000035")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001F6")]
				[Address(RVA = "0xF02ED4", Offset = "0xF02ED4", VA = "0xF02ED4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000036")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001F8")]
				[Address(RVA = "0xF02F1C", Offset = "0xF02F1C", VA = "0xF02F1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001F3")]
			[Address(RVA = "0xF02DF4", Offset = "0xF02DF4", VA = "0xF02DF4")]
			[DebuggerHidden]
			public <Disable>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xF02E20", Offset = "0xF02E20", VA = "0xF02E20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xF02E24", Offset = "0xF02E24", VA = "0xF02E24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xF02EDC", Offset = "0xF02EDC", VA = "0xF02EDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float distanceFromEye;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float intervalSpeed;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LevelLoader loader;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BoxCollider[] handColliders;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OVRHandPhysicsCapsulesCustom[] physicsCapsules;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject[] puzzleProgressIndicator;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AreaManager areaManager;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject puzzleIndicatorPrefab;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform puzzleIndicatorsRoot;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 velocity;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x162ECAC", Offset = "0x162ECAC", VA = "0x162ECAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x162EFC4", Offset = "0x162EFC4", VA = "0x162EFC4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x162F154", Offset = "0x162F154", VA = "0x162F154")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x162F1B8", Offset = "0x162F1B8", VA = "0x162F1B8")]
		public void MenuTitle()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x162F210", Offset = "0x162F210", VA = "0x162F210")]
		public void BackToHub()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x162E3B0", Offset = "0x162E3B0", VA = "0x162E3B0")]
		public void Resume()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x162E1A4", Offset = "0x162E1A4", VA = "0x162E1A4")]
		public void EnableHandsCollider(bool onOff)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x162F268", Offset = "0x162F268", VA = "0x162F268")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721AAC", Offset = "0x721AAC")]
		private IEnumerator Disable()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x162F2D4", Offset = "0x162F2D4", VA = "0x162F2D4")]
		public InGameMenu()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class InGameMenuActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InGameMenu menu;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform originPointer;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask layerMask;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RayInteractor interactor;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayIndicator indicator;

		[Token(Token = "0x17000037")]
		public bool Active
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x162F354", Offset = "0x162F354", VA = "0x162F354", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x162F528", Offset = "0x162F528", VA = "0x162F528")]
		public InGameMenuActiveState()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class InGameMenuDebugPanel : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F384", Offset = "0x71F384")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int index;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InGameMenuDebugPanel <>4__this;

			[Token(Token = "0x60001FF")]
			[Address(RVA = "0xF02F24", Offset = "0xF02F24", VA = "0xF02F24")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000200")]
			[Address(RVA = "0xF02F2C", Offset = "0xF02F2C", VA = "0xF02F2C")]
			internal void <Start>b__0()
			{
			}
		}

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject buttonPrefab;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InGameMenu inGameMenu;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AreaManager areaManager;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerLocomotionTeleport teleport;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x162F530", Offset = "0x162F530", VA = "0x162F530")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x162F8D8", Offset = "0x162F8D8", VA = "0x162F8D8")]
		public void WarpToPuzzle(int index)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x162FBAC", Offset = "0x162FBAC", VA = "0x162FBAC")]
		public InGameMenuDebugPanel()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x162FBB4", Offset = "0x162FBB4", VA = "0x162FBB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721B5C", Offset = "0x721B5C")]
		private void <Start>b__4_1()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class IndexPointingActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform root;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform indexTip;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform thumbTip;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angleThreshold;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float margin;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool invert;

		[Token(Token = "0x17000038")]
		public bool Active
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xB1BB2C", Offset = "0xB1BB2C", VA = "0xB1BB2C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB1BC38", Offset = "0xB1BC38", VA = "0xB1BC38")]
		public IndexPointingActiveState()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class InputFocusActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x17000039")]
		public bool Active
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xB1BC4C", Offset = "0xB1BC4C", VA = "0xB1BC4C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB1BCA8", Offset = "0xB1BCA8", VA = "0xB1BCA8")]
		public InputFocusActiveState()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class InputFocusPause : MonoBehaviour
	{
		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB1BCB0", Offset = "0xB1BCB0", VA = "0xB1BCB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xB1BD9C", Offset = "0xB1BD9C", VA = "0xB1BD9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xB1BE88", Offset = "0xB1BE88", VA = "0xB1BE88")]
		private void FocusAcquired()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xB1BEAC", Offset = "0xB1BEAC", VA = "0xB1BEAC")]
		private void FocusLost()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xB1BED0", Offset = "0xB1BED0", VA = "0xB1BED0")]
		public InputFocusPause()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class JarSound : MonoBehaviour
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterReceptacle[] waterReceptacles;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioSource jarWaterAudioSource;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isOneFilling;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xB1C288", Offset = "0xB1C288", VA = "0xB1C288")]
		private void Update()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB1C31C", Offset = "0xB1C31C", VA = "0xB1C31C")]
		private void PlayJarAudioSource()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xB1C368", Offset = "0xB1C368", VA = "0xB1C368")]
		private void StopJarAudioSource()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xB1C3B4", Offset = "0xB1C3B4", VA = "0xB1C3B4")]
		public JarSound()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class LanguageManager : MonoBehaviour
	{
		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguagesGroupScriptableObject languagesGroup;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int index;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text languageLabel;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xB1C3C4", Offset = "0xB1C3C4", VA = "0xB1C3C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xB1C5FC", Offset = "0xB1C5FC", VA = "0xB1C5FC")]
		public void Move(bool forward = true)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xB1C4F4", Offset = "0xB1C4F4", VA = "0xB1C4F4")]
		private void Display(int index)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xB1C6AC", Offset = "0xB1C6AC", VA = "0xB1C6AC")]
		public void MoveLeft()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xB1C6B4", Offset = "0xB1C6B4", VA = "0xB1C6B4")]
		public void MoveRight()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xB1C6BC", Offset = "0xB1C6BC", VA = "0xB1C6BC")]
		public LanguageManager()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class LeftHandInteractorsActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x1700003A")]
		public bool Active
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0xB1CC24", Offset = "0xB1CC24", VA = "0xB1CC24", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xB1CC94", Offset = "0xB1CC94", VA = "0xB1CC94")]
		public LeftHandInteractorsActiveState()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LeftHandWaterDetection : MonoBehaviour
	{
		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider selfCollider;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterFlow[] foundWaterflows;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AreaManager areaManager;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xB1CC9C", Offset = "0xB1CC9C", VA = "0xB1CC9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xB1CD58", Offset = "0xB1CD58", VA = "0xB1CD58")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xB1CDF8", Offset = "0xB1CDF8", VA = "0xB1CDF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xB1CE4C", Offset = "0xB1CE4C", VA = "0xB1CE4C")]
		private void Update()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xB1CF9C", Offset = "0xB1CF9C", VA = "0xB1CF9C")]
		private void CheckWaterInteraction()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xB1CD5C", Offset = "0xB1CD5C", VA = "0xB1CD5C")]
		private void SetUp()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xB1D0AC", Offset = "0xB1D0AC", VA = "0xB1D0AC")]
		public LeftHandWaterDetection()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F394", Offset = "0x71F394")]
	public class LevelLoader : MonoBehaviour
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string sceneToLoad;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image fadeImage;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color defaultFadeColor;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color newGameFadeColor;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RenderPipelineAsset defaultShadowsAsset;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RenderPipelineAsset sceneRenderAsset;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IsPreparingLoadingScene;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string previousSceneName;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Image blindingImage;

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xB1D0B4", Offset = "0xB1D0B4", VA = "0xB1D0B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xB1D12C", Offset = "0xB1D12C", VA = "0xB1D12C")]
		private void Start()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xB1D338", Offset = "0xB1D338", VA = "0xB1D338")]
		public void PrepareScene(string sceneName)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xB1D39C", Offset = "0xB1D39C", VA = "0xB1D39C")]
		public void LoadScene(string sceneName)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xB1D4D4", Offset = "0xB1D4D4", VA = "0xB1D4D4")]
		public void OnFadeStart()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xB1D4F4", Offset = "0xB1D4F4", VA = "0xB1D4F4")]
		public void OnFadeInComplete()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xB1D598", Offset = "0xB1D598", VA = "0xB1D598")]
		public void OnFadeOutComplete()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xB1D62C", Offset = "0xB1D62C", VA = "0xB1D62C")]
		public void SetWhiteOut(bool onOff)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xB1D6A4", Offset = "0xB1D6A4", VA = "0xB1D6A4")]
		public LevelLoader()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class LoadingSceneDirector : MonoBehaviour
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScreenFader screenFader;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xB1E268", Offset = "0xB1E268", VA = "0xB1E268")]
		public void TransitionToScene()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xB1E340", Offset = "0xB1E340", VA = "0xB1E340")]
		private void AllowSceneActivation()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xB1E3B4", Offset = "0xB1E3B4", VA = "0xB1E3B4")]
		public LoadingSceneDirector()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class LoadingScreenCharacterTranslator : MonoBehaviour
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 firstPosition;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 secondPosition;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720210", Offset = "0x720210")]
		public float targetPosition;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float currentFactor;

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xB1E3BC", Offset = "0xB1E3BC", VA = "0xB1E3BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB1E558", Offset = "0xB1E558", VA = "0xB1E558")]
		public LoadingScreenCharacterTranslator()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class LoadingScreenDiorama : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F3F4", Offset = "0x71F3F4")]
		private sealed class <>c
		{
			[Token(Token = "0x40002AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<string> <>9__1_0;

			[Token(Token = "0x600022E")]
			[Address(RVA = "0xF03208", Offset = "0xF03208", VA = "0xF03208")]
			public <>c()
			{
			}

			[Token(Token = "0x600022F")]
			[Address(RVA = "0xF03210", Offset = "0xF03210", VA = "0xF03210")]
			internal bool <Start>b__1_0(string element)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] activeForScenes;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xB1E560", Offset = "0xB1E560", VA = "0xB1E560")]
		private void Start()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xB1E6B4", Offset = "0xB1E6B4", VA = "0xB1E6B4")]
		public LoadingScreenDiorama()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class Language
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string name;

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xB1C3BC", Offset = "0xB1C3BC", VA = "0xB1C3BC")]
		public Language()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x71F404", Offset = "0x71F404")]
	public class LanguagesGroupScriptableObject : ScriptableObject
	{
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Language> languages;

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xB1C6C4", Offset = "0xB1C6C4", VA = "0xB1C6C4")]
		public LanguagesGroupScriptableObject()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MainMenuManager : MonoBehaviour
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720228", Offset = "0x720228")]
		public string firstSceneName;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720260", Offset = "0x720260")]
		public GameObject chooseSlotPanel;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject confirmOverwritePanel;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SaveSlot[] slotsDisplay;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720298", Offset = "0x720298")]
		public SaveManager saveManager;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LevelLoader levelLoader;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xB1E6BC", Offset = "0xB1E6BC", VA = "0xB1E6BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xB1EEBC", Offset = "0xB1EEBC", VA = "0xB1EEBC")]
		public void CreateNewGame(int index)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xB1F01C", Offset = "0xB1F01C", VA = "0xB1F01C")]
		public void EraseSlot(int index)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xB1F06C", Offset = "0xB1F06C", VA = "0xB1F06C")]
		public void DeleteSlot()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xB1F164", Offset = "0xB1F164", VA = "0xB1F164")]
		public void ContinueGame(int index)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xB1F268", Offset = "0xB1F268", VA = "0xB1F268")]
		public void QuitGame()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xB1F270", Offset = "0xB1F270", VA = "0xB1F270")]
		public MainMenuManager()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class MenuPanelManager : MonoBehaviour
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text pageNumberLabel;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<GameObject> panels;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject leftButton;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject rightButton;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int index;

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xB1F580", Offset = "0xB1F580", VA = "0xB1F580")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xB1F58C", Offset = "0xB1F58C", VA = "0xB1F58C")]
		private void Display(int index)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xB1F768", Offset = "0xB1F768", VA = "0xB1F768")]
		public void Move(bool forward = true)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xB1F810", Offset = "0xB1F810", VA = "0xB1F810")]
		public void MoveLeft()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xB1F818", Offset = "0xB1F818", VA = "0xB1F818")]
		public void MoveRight()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xB1F820", Offset = "0xB1F820", VA = "0xB1F820")]
		public MenuPanelManager()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F458", Offset = "0x71F458")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F458", Offset = "0x71F458")]
	public class MeshCombiner : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200007C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F4EC", Offset = "0x71F4EC")]
		private sealed class <>c
		{
			[Token(Token = "0x40002BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<MeshFilter> <>9__1_0;

			[Token(Token = "0x6000242")]
			[Address(RVA = "0xF032E0", Offset = "0xF032E0", VA = "0xF032E0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0xF032E8", Offset = "0xF032E8", VA = "0xF032E8")]
			internal bool <Start>b__1_0(MeshFilter m)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int lightmapIndex;

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xB1F898", Offset = "0xB1F898", VA = "0xB1F898")]
		private void Start()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xB1FCA8", Offset = "0xB1FCA8", VA = "0xB1FCA8")]
		public MeshCombiner()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F4FC", Offset = "0x71F4FC")]
	public class MusicManager : MonoBehaviour
	{
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F55C", Offset = "0x71F55C")]
		private sealed class <PlayTrack>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MusicManager <>4__this;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float delay;

			[Token(Token = "0x1700003B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600024B")]
				[Address(RVA = "0xF034C0", Offset = "0xF034C0", VA = "0xF034C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600024D")]
				[Address(RVA = "0xF03508", Offset = "0xF03508", VA = "0xF03508", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000248")]
			[Address(RVA = "0xF0336C", Offset = "0xF0336C", VA = "0xF0336C")]
			[DebuggerHidden]
			public <PlayTrack>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0xF03398", Offset = "0xF03398", VA = "0xF03398", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600024A")]
			[Address(RVA = "0xF0339C", Offset = "0xF0339C", VA = "0xF0339C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600024C")]
			[Address(RVA = "0xF034C8", Offset = "0xF034C8", VA = "0xF034C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] tracks;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7202D0", Offset = "0x7202D0")]
		public float minDelay;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720308", Offset = "0x720308")]
		public float maxDelay;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720340", Offset = "0x720340")]
		public float startDelay;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AudioSource source;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float delay;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool readyToPlay;

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xB1FD9C", Offset = "0xB1FD9C", VA = "0xB1FD9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xB1FE84", Offset = "0xB1FE84", VA = "0xB1FE84")]
		private void Update()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xB1FE08", Offset = "0xB1FE08", VA = "0xB1FE08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721B6C", Offset = "0x721B6C")]
		private IEnumerator PlayTrack(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xB1FEF0", Offset = "0xB1FEF0", VA = "0xB1FEF0")]
		public MusicManager()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class NoPoseActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x720378", Offset = "0x720378")]
		private bool <Active>k__BackingField;

		[Token(Token = "0x1700003D")]
		public bool Active
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xB1FF0C", Offset = "0xB1FF0C", VA = "0xB1FF0C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721C1C", Offset = "0x721C1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0xB1FF14", Offset = "0xB1FF14", VA = "0xB1FF14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721C2C", Offset = "0x721C2C")]
			set
			{
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xB1FF20", Offset = "0xB1FF20", VA = "0xB1FF20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xB1FF2C", Offset = "0xB1FF2C", VA = "0xB1FF2C")]
		public NoPoseActiveState()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class NodeGroup : MonoBehaviour
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public int id;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TeleportNode[] nodes;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public bool activate;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PlayerLocomotionTeleport playerLocomotionTeleport;

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xB1FF34", Offset = "0xB1FF34", VA = "0xB1FF34")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xB2001C", Offset = "0xB2001C", VA = "0xB2001C")]
		public void On()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xB20100", Offset = "0xB20100", VA = "0xB20100")]
		public void Off(bool deactivateNodes = false)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xB20184", Offset = "0xB20184", VA = "0xB20184")]
		public NodeGroup()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class ObjectPool : MonoBehaviour
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject objectToPool;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numberToPreAllocate;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public List<GameObject> pooledObjects;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xB20A78", Offset = "0xB20A78", VA = "0xB20A78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xB20ABC", Offset = "0xB20ABC", VA = "0xB20ABC")]
		private GameObject InstantiateObject()
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xB20B80", Offset = "0xB20B80", VA = "0xB20B80")]
		public GameObject GetPooledObject()
		{
			return null;
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xB20C60", Offset = "0xB20C60", VA = "0xB20C60")]
		public ObjectPool()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class OnlyOnDemo : MonoBehaviour
	{
		[Token(Token = "0x2000083")]
		public enum visibilityStatus
		{
			[Token(Token = "0x40002D3")]
			onDemo,
			[Token(Token = "0x40002D4")]
			notOnDemo
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public visibilityStatus visibility;

		[Token(Token = "0x1700003E")]
		public bool isActive
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0xB20C68", Offset = "0xB20C68", VA = "0xB20C68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xB20D18", Offset = "0xB20D18", VA = "0xB20D18")]
		private void Start()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xB20D5C", Offset = "0xB20D5C", VA = "0xB20D5C")]
		public OnlyOnDemo()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class PhotoQuad : MonoBehaviour
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshFilter meshFilter;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int[] triangles;

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xB215F0", Offset = "0xB215F0", VA = "0xB215F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xB21658", Offset = "0xB21658", VA = "0xB21658")]
		public void UpdateMesh(Vector3 center, Vector3 v0, Vector3 v1, Vector3 v2, Vector3 v3)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xB21858", Offset = "0xB21858", VA = "0xB21858")]
		public PhotoQuad()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class PlayerBracelet : MonoBehaviour
	{
		[Token(Token = "0x2000086")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F56C", Offset = "0x71F56C")]
		private sealed class <OffsetElements>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool templeElement;

			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PlayerBracelet <>4__this;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startTime>5__2;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<PlayerBraceletElement> <elements>5__3;

			[Token(Token = "0x1700003F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600026D")]
				[Address(RVA = "0xF03C60", Offset = "0xF03C60", VA = "0xF03C60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000040")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0xF03CA8", Offset = "0xF03CA8", VA = "0xF03CA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600026A")]
			[Address(RVA = "0xF037B0", Offset = "0xF037B0", VA = "0xF037B0")]
			[DebuggerHidden]
			public <OffsetElements>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x600026B")]
			[Address(RVA = "0xF037DC", Offset = "0xF037DC", VA = "0xF037DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600026C")]
			[Address(RVA = "0xF037E0", Offset = "0xF037E0", VA = "0xF037E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600026E")]
			[Address(RVA = "0xF03C68", Offset = "0xF03C68", VA = "0xF03C68", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<PlayerBraceletElement> braceletElements;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<PlayerBraceletElement> braceletElementsTemple1;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<PlayerBraceletElement> braceletElementsTemple2;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float radius;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rotationSpeed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float transitionTime;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject braceletElementPrefab;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float triangleSize;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float templeShapeSize;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int maxNumberOfElements;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int startingElements;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int startingElementsTemple;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject shapePrefab;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject shapeTemplePrefab;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xB21B4C", Offset = "0xB21B4C", VA = "0xB21B4C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xB21E7C", Offset = "0xB21E7C", VA = "0xB21E7C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xB21D3C", Offset = "0xB21D3C", VA = "0xB21D3C")]
		private void CreateElementAtStart(float offset, GameObject shapePrefab, bool temple = false)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xB222F0", Offset = "0xB222F0", VA = "0xB222F0")]
		public int GetNumberOfShapes(bool inTemple = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xB2236C", Offset = "0xB2236C", VA = "0xB2236C")]
		public PlayerBraceletElement GetElement(int index, bool inTemple = false)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xB22410", Offset = "0xB22410", VA = "0xB22410")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x721C3C", Offset = "0x721C3C")]
		public void AddElement([Optional] UnlockShape shape)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xB225A4", Offset = "0xB225A4", VA = "0xB225A4")]
		public void AddElementTemple([Optional] UnlockShape shape)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xB21F04", Offset = "0xB21F04", VA = "0xB21F04")]
		private GameObject CreateElement(float angleOffset = 0f, bool templeElement = false)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xB22524", Offset = "0xB22524", VA = "0xB22524")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721C74", Offset = "0x721C74")]
		private IEnumerator OffsetElements(bool templeElement = false)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xB226B8", Offset = "0xB226B8", VA = "0xB226B8")]
		public PlayerBracelet()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class PlayerBraceletElement : MonoBehaviour
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public UnlockShape unlockShape;

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xB22768", Offset = "0xB22768", VA = "0xB22768")]
		public void SendUnlockShape(Transform targetTransform)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xB2277C", Offset = "0xB2277C", VA = "0xB2277C")]
		public void RetrieveUnlockShape()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xB227BC", Offset = "0xB227BC", VA = "0xB227BC")]
		public PlayerBraceletElement()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F57C", Offset = "0x71F57C")]
	public class PlayerPrefOptionSlider : MonoBehaviour
	{
		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string playerPref;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Slider slider;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool isInteger;

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xB23C6C", Offset = "0xB23C6C", VA = "0xB23C6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xB23CC0", Offset = "0xB23CC0", VA = "0xB23CC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xB23E5C", Offset = "0xB23E5C", VA = "0xB23E5C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xB23F20", Offset = "0xB23F20", VA = "0xB23F20")]
		private void UpdateOptionValue(float value)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xB23FFC", Offset = "0xB23FFC", VA = "0xB23FFC")]
		public PlayerPrefOptionSlider()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class PlayerReferences : MonoBehaviour
	{
		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static PlayerReferences instance;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool DeactivateTeleportationInBlindZones;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool leftHandInBlindZone;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool rightHandInBlindZone;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[HideInInspector]
		public bool leftHandInWater;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool rightHandInWater;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[HideInInspector]
		public bool headOutsideConfinementZone;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720418", Offset = "0x720418")]
		public Transform headAnchor;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHandAnchor;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHandAnchor;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720450", Offset = "0x720450")]
		public OVRSkeleton leftHandSkeleton;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OVRSkeleton rightHandSkeleton;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720488", Offset = "0x720488")]
		public OVRHand leftOVRHand;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVRHand rightOVRHand;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7204C0", Offset = "0x7204C0")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x7204C0", Offset = "0x7204C0")]
		private MonoBehaviour _leftHandRef;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x720554", Offset = "0x720554")]
		private IHand <leftHandRef>k__BackingField;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x720564", Offset = "0x720564")]
		[SerializeField]
		private MonoBehaviour _rightHandRef;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7205D4", Offset = "0x7205D4")]
		private IHand <rightHandRef>k__BackingField;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public SkinnedMeshRenderer leftHandRenderer;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public SkinnedMeshRenderer rightHandRenderer;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7205E4", Offset = "0x7205E4")]
		public OVRHandPhysicsCapsulesCustom leftHandPhysicsCapsules;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public OVRHandPhysicsCapsulesCustom rightHandPhysicsCapsules;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public BoxCollider leftHandWaterCollider;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public BoxCollider rightHandWaterCollider;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72061C", Offset = "0x72061C")]
		public RayInteractor leftHandRayInteractor;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public RayInteractor rightHandRayInteractor;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720654", Offset = "0x720654")]
		public List<Material> handMaterials;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72068C", Offset = "0x72068C")]
		public ShadowGun shadowGun;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7206C4", Offset = "0x7206C4")]
		public PlayerLocomotionTeleport teleport;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7206FC", Offset = "0x7206FC")]
		public PlayerBracelet bracelet;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720734", Offset = "0x720734")]
		public Transform defaultBraceletPosition;

		[Token(Token = "0x17000041")]
		public IHand leftHandRef
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xB24050", Offset = "0xB24050", VA = "0xB24050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D24", Offset = "0x721D24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xB24058", Offset = "0xB24058", VA = "0xB24058")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D34", Offset = "0x721D34")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public IHand rightHandRef
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xB24060", Offset = "0xB24060", VA = "0xB24060")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D44", Offset = "0x721D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xB24068", Offset = "0xB24068", VA = "0xB24068")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D54", Offset = "0x721D54")]
			private set
			{
			}
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xB24070", Offset = "0xB24070", VA = "0xB24070")]
		private void Awake()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xB240F4", Offset = "0xB240F4", VA = "0xB240F4")]
		public PlayerReferences()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class PokeInteractorScale : MonoBehaviour
	{
		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PokeInteractable pokeInteractable;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<PokeInteractor> pokeInteractors;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minDistance;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 fullScale;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 originalScale;

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xB24104", Offset = "0xB24104", VA = "0xB24104")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xB242E0", Offset = "0xB242E0", VA = "0xB242E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xB244C4", Offset = "0xB244C4", VA = "0xB244C4")]
		private void HandleAddTrackedInteractor(PokeInteractor pokeInteractor)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xB24528", Offset = "0xB24528", VA = "0xB24528")]
		private void HandleRemoveTrackedInteractor(PokeInteractor pokeInteractor)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xB2458C", Offset = "0xB2458C", VA = "0xB2458C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xB24620", Offset = "0xB24620", VA = "0xB24620")]
		private void Update()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB24850", Offset = "0xB24850", VA = "0xB24850")]
		public PokeInteractorScale()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class Polygon
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F5DC", Offset = "0x71F5DC")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LinkedListNode<int> toCheck;

			[Token(Token = "0x600028A")]
			[Address(RVA = "0xF03CB0", Offset = "0xF03CB0", VA = "0xF03CB0")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600028B")]
			[Address(RVA = "0xF03CB8", Offset = "0xF03CB8", VA = "0xF03CB8")]
			internal bool <Triangulate>b__0(LinkedListNode<int> x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LinkedList<int> vertices;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<LinkedListNode<int>> reflex;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<LinkedListNode<int>> convex;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Queue<LinkedListNode<int>> ears;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 normal;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> substitutions;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<Vector2> coordinates;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<int> triangles;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xB24898", Offset = "0xB24898", VA = "0xB24898")]
		public Polygon(ShadowMesh.Contour c)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB24B14", Offset = "0xB24B14", VA = "0xB24B14")]
		public void CategorizeVertices()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xB25178", Offset = "0xB25178", VA = "0xB25178")]
		public void Simplify(ShadowMesh.Contour c)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB25C0C", Offset = "0xB25C0C", VA = "0xB25C0C")]
		public void Triangulate()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xB25C7C", Offset = "0xB25C7C", VA = "0xB25C7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721D64", Offset = "0x721D64")]
		private bool <CategorizeVertices>b__9_0(LinkedListNode<int> item)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008D")]
	public class PuzzleManager : MonoBehaviour
	{
		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F5EC", Offset = "0x71F5EC")]
		private sealed class <_Restore>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuzzleManager <>4__this;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002A8")]
				[Address(RVA = "0xF040F4", Offset = "0xF040F4", VA = "0xF040F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AA")]
				[Address(RVA = "0xF0413C", Offset = "0xF0413C", VA = "0xF0413C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xF03FE8", Offset = "0xF03FE8", VA = "0xF03FE8")]
			[DebuggerHidden]
			public <_Restore>d__38(int <>1__state)
			{
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0xF04014", Offset = "0xF04014", VA = "0xF04014", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0xF04018", Offset = "0xF04018", VA = "0xF04018", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xF040FC", Offset = "0xF040FC", VA = "0xF040FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F5FC", Offset = "0x71F5FC")]
		private sealed class <LightFade>d__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool onOff;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PuzzleManager <>4__this;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lerpValue>5__2;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <speed>5__3;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool <fadeFinished>5__4;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002AE")]
				[Address(RVA = "0xF03F98", Offset = "0xF03F98", VA = "0xF03F98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B0")]
				[Address(RVA = "0xF03FE0", Offset = "0xF03FE0", VA = "0xF03FE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xF03D3C", Offset = "0xF03D3C", VA = "0xF03D3C")]
			[DebuggerHidden]
			public <LightFade>d__51(int <>1__state)
			{
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xF03D68", Offset = "0xF03D68", VA = "0xF03D68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xF03D6C", Offset = "0xF03D6C", VA = "0xF03D6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xF03FA0", Offset = "0xF03FA0", VA = "0xF03FA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int id;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public AreaManager area;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShadowMesh mesh;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light _lanternSpotLight;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Animator lanternAnimator;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioSource lanternAudioSource;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Animator resetButtonAnimator;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float lightInstensityAtStart;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine lightCoroutine;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float MaxRayInteractorLength;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool setDestinationOnStart;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent whenPuzzleFinish;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent whenPuzzleDeactivate;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool finished;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject targetPrefab;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private DestinationMarker target;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private DestinationMarker targetPreview;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool firstActivation;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shootable[] shootables;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public RestorableObject[] objectsInPuzzle;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Animator fadingScreen;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool _isActive;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72078C", Offset = "0x72078C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72078C", Offset = "0x72078C")]
		public TeleportNode warpNode;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public ZoneCulling[] activeZones;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public NodeGroup[] activeNodeGroups;

		[Token(Token = "0x17000043")]
		public GameObject lanternSpotLight
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0xB2657C", Offset = "0xB2657C", VA = "0xB2657C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public bool isActive
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0xB26688", Offset = "0xB26688", VA = "0xB26688")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xB266A0", Offset = "0xB266A0", VA = "0xB266A0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xB269F0", Offset = "0xB269F0", VA = "0xB269F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xB26C60", Offset = "0xB26C60", VA = "0xB26C60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xB26DC4", Offset = "0xB26DC4", VA = "0xB26DC4")]
		public void On(ShadowMesh mesh, bool calledFromArea = false)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xB27288", Offset = "0xB27288", VA = "0xB27288")]
		public void On(bool calledFromArea = false)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xB26D5C", Offset = "0xB26D5C", VA = "0xB26D5C")]
		public void Finish()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xB26AD0", Offset = "0xB26AD0", VA = "0xB26AD0")]
		public void Off()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xB27384", Offset = "0xB27384", VA = "0xB27384")]
		public void Restore()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xB2743C", Offset = "0xB2743C", VA = "0xB2743C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721D74", Offset = "0x721D74")]
		private IEnumerator _Restore()
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xB274A8", Offset = "0xB274A8", VA = "0xB274A8")]
		public void RestoreOnActivation()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xB27598", Offset = "0xB27598", VA = "0xB27598")]
		public void TargetPosition(WayPoint wp, [Optional] GameObject itemDestination, [Optional] DestinationMarker marker)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xB2768C", Offset = "0xB2768C", VA = "0xB2768C")]
		public void TargetPosition(Vector2 position, [Optional] GameObject itemDestination, [Optional] DestinationMarker marker)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xB276DC", Offset = "0xB276DC", VA = "0xB276DC")]
		public void TargetPosition([Optional] GameObject itemDestination, [Optional] DestinationMarker marker)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xB276F8", Offset = "0xB276F8", VA = "0xB276F8")]
		public void SetDestination(Vector2 position)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xB277C0", Offset = "0xB277C0", VA = "0xB277C0")]
		public void SetPreviewDestination(Vector3 position)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xB278AC", Offset = "0xB278AC", VA = "0xB278AC")]
		public void DeactivatePreview()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xB278CC", Offset = "0xB278CC", VA = "0xB278CC")]
		public void SetDestination(Vector3 position)
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xB2799C", Offset = "0xB2799C", VA = "0xB2799C")]
		public void RemoveDestination()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xB27A38", Offset = "0xB27A38", VA = "0xB27A38")]
		public void StopAgents()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xB27B48", Offset = "0xB27B48", VA = "0xB27B48")]
		public void ResumeAgents()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xB27078", Offset = "0xB27078", VA = "0xB27078")]
		private void SwitchLight(bool onOff)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xB27C58", Offset = "0xB27C58", VA = "0xB27C58")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721DD4", Offset = "0x721DD4")]
		private IEnumerator LightFade(bool onOff)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xB27CD8", Offset = "0xB27CD8", VA = "0xB27CD8")]
		public PuzzleManager()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class RadialJauge : MonoBehaviour
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MeshRenderer renderer;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent onSelectionConfirmed;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve curve;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float elapsedTime;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool touching;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool isPulsating;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float pulseElapsedTime;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float pulseDuration;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float jaugeScale;

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xB27DA0", Offset = "0xB27DA0", VA = "0xB27DA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xB27E0C", Offset = "0xB27E0C", VA = "0xB27E0C")]
		public void OnSelected()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xB27E18", Offset = "0xB27E18", VA = "0xB27E18")]
		public void OnRelease()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xB27E20", Offset = "0xB27E20", VA = "0xB27E20")]
		private void Update()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xB28000", Offset = "0xB28000", VA = "0xB28000")]
		public RadialJauge()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class RayIndicator : RunOnSpecificFrames
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LineRenderer line;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MonoBehaviour _iActiveStateMono;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IActiveState activeState;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xB2801C", Offset = "0xB2801C", VA = "0xB2801C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xB28070", Offset = "0xB28070", VA = "0xB28070")]
		public void UpdateLine(Vector3 start, Vector3 end)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xB28128", Offset = "0xB28128", VA = "0xB28128", Slot = "6")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xB2828C", Offset = "0xB2828C", VA = "0xB2828C", Slot = "10")]
		public new virtual void NonIntervalUpdate()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xB28290", Offset = "0xB28290", VA = "0xB28290")]
		public RayIndicator()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class RaySetDestinationActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x17000049")]
		public bool Active
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0xB28298", Offset = "0xB28298", VA = "0xB28298", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xB28358", Offset = "0xB28358", VA = "0xB28358")]
		public RaySetDestinationActiveState()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F60C", Offset = "0x71F60C")]
	internal struct SetupJob : IJobParallelFor
	{
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<RaycastCommand> commands;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float3 origin;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int resolution;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float3 rayDir;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float3 rayStepHorizontal;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float3 rayStepVertical;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float depth;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LayerMask layerMaskAll;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LayerMask layerMaskWalkables;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LayerMask layerMaskHands;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int offset;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int sections;

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xB2B968", Offset = "0xB2B968", VA = "0xB2B968", Slot = "4")]
		public void Execute(int i)
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F61C", Offset = "0x71F61C")]
	internal struct TransferResults : IJobParallelFor
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> raycastsResults;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[NativeDisableParallelForRestriction]
		public NativeArray<RaycastHit> results;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int resolution;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int offset;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int sections;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xBB7FC4", Offset = "0xBB7FC4", VA = "0xBB7FC4", Slot = "4")]
		public void Execute(int i)
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class RaycastGatlingGun : RunOnSpecificFrames
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int resolution;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fov;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float depth;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LayerMask layerMaskWithProjectors;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask layerMaskOnlyWalkables;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayerMask layerMaskHandProjectors;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int shadowSurfaceLayer;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public NativeArray<int> boolResults;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool showRays;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool lowerHalf;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int section;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int numSections;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xB28360", Offset = "0xB28360", VA = "0xB28360")]
		private void DebugDrawEye()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xB28638", Offset = "0xB28638", VA = "0xB28638")]
		private void ComputeRayDirections(NativeArray<RaycastCommand> commands, LayerMask layerMaskAll, LayerMask layerMaskWalkables, LayerMask layerMaskHands)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0xB288F4", Offset = "0xB288F4", VA = "0xB288F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0xB289C8", Offset = "0xB289C8", VA = "0xB289C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0xB28A14", Offset = "0xB28A14", VA = "0xB28A14", Slot = "6")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xB28BF4", Offset = "0xB28BF4", VA = "0xB28BF4")]
		public RaycastGatlingGun()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public abstract class RestorableAndRunOnSpecificFrame : MonoBehaviour, IRunOnSpecificFrames, IRestorable
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72081C", Offset = "0x72081C")]
		public int frameInterval;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int frameOffset;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invert;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720854", Offset = "0x720854")]
		public bool IsResetChildren;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 memoPosition;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3[] memoChildrenPosition;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion memoRotation;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion[] memoChildrenRotation;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 memoScale;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3[] memoChildrenScale;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool memoIsActive;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] memoChildrenIsActive;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected bool isInitialized;

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xB28C18", Offset = "0xB28C18", VA = "0xB28C18")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002C6")]
		public abstract void IntervalUpdate();

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xB28C7C", Offset = "0xB28C7C", VA = "0xB28C7C", Slot = "9")]
		public virtual void NonIntervalUpdate()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xB28C80", Offset = "0xB28C80", VA = "0xB28C80", Slot = "10")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xB28F70", Offset = "0xB28F70", VA = "0xB28F70", Slot = "11")]
		public virtual void Restore()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xB29270", Offset = "0xB29270", VA = "0xB29270")]
		protected RestorableAndRunOnSpecificFrame()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class RestorableObject : MonoBehaviour, IRestorable
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsResetChildren;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 memoPosition;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] memoChildrenPosition;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion memoRotation;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion[] memoChildrenRotation;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 memoScale;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3[] memoChildrenScale;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool memoIsActive;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool[] memoChildrenIsActive;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected bool isInitialized;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent onRestore;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xB1D708", Offset = "0xB1D708", VA = "0xB1D708", Slot = "6")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xB1C7E4", Offset = "0xB1C7E4", VA = "0xB1C7E4", Slot = "7")]
		public virtual void Restore()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xB1CB10", Offset = "0xB1CB10", VA = "0xB1CB10")]
		public RestorableObject()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class RightHandInteractorsActiveState : MonoBehaviour, IActiveState
	{
		[Token(Token = "0x1700004A")]
		public bool Active
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0xB29288", Offset = "0xB29288", VA = "0xB29288", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xB292F8", Offset = "0xB292F8", VA = "0xB292F8")]
		public RightHandInteractorsActiveState()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class RightHandWaterDetection : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider selfCollider;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterFlow[] foundWaterflows;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AreaManager areaManager;

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xB29300", Offset = "0xB29300", VA = "0xB29300")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xB293BC", Offset = "0xB293BC", VA = "0xB293BC")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xB2945C", Offset = "0xB2945C", VA = "0xB2945C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xB294B0", Offset = "0xB294B0", VA = "0xB294B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xB29600", Offset = "0xB29600", VA = "0xB29600")]
		private void CheckWaterInteraction()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xB293C0", Offset = "0xB293C0", VA = "0xB293C0")]
		private void SetUp()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xB29710", Offset = "0xB29710", VA = "0xB29710")]
		public RightHandWaterDetection()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class RotatitiveItem : RestorableObject
	{
		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F62C", Offset = "0x71F62C")]
		private sealed class <_Rotation>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RotatitiveItem <>4__this;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int index;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <ratio>5__2;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <time>5__3;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0xF04580", Offset = "0xF04580", VA = "0xF04580", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E1")]
				[Address(RVA = "0xF045C8", Offset = "0xF045C8", VA = "0xF045C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xF04394", Offset = "0xF04394", VA = "0xF04394")]
			[DebuggerHidden]
			public <_Rotation>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xF043C0", Offset = "0xF043C0", VA = "0xF043C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xF043C4", Offset = "0xF043C4", VA = "0xF043C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xF04588", Offset = "0xF04588", VA = "0xF04588", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Quaternion[] rotations;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int indexRotationOnStart;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int currentIndex;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float timeToSwitch;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UnityEvent whenRotationStart;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UnityEvent whenRotationEnd;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xB297EC", Offset = "0xB297EC", VA = "0xB297EC", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xB29868", Offset = "0xB29868", VA = "0xB29868", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xB298DC", Offset = "0xB298DC", VA = "0xB298DC")]
		public void Rotation(int index)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xB29908", Offset = "0xB29908", VA = "0xB29908")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721ED4", Offset = "0x721ED4")]
		private IEnumerator _Rotation(int index)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xB29984", Offset = "0xB29984", VA = "0xB29984")]
		public RotatitiveItem()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class RunOnSpecificFrames : MonoBehaviour, IRunOnSpecificFrames
	{
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool[] frames;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool invert;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xB29A2C", Offset = "0xB29A2C", VA = "0xB29A2C")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xB29AC0", Offset = "0xB29AC0", VA = "0xB29AC0")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xB29B54", Offset = "0xB29B54", VA = "0xB29B54", Slot = "6")]
		public virtual void IntervalUpdate()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xB29B58", Offset = "0xB29B58", VA = "0xB29B58", Slot = "7")]
		public virtual void NonIntervalUpdate()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xB29B5C", Offset = "0xB29B5C", VA = "0xB29B5C", Slot = "8")]
		public virtual void IntervalLateUpdate()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xB29B60", Offset = "0xB29B60", VA = "0xB29B60", Slot = "9")]
		public virtual void NonIntervalLateUpdate()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xB1FD94", Offset = "0xB1FD94", VA = "0xB1FD94")]
		protected RunOnSpecificFrames()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class SaveManager : MonoBehaviour
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[HideInInspector]
		public static int currentSaveIndex;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72089C", Offset = "0x72089C")]
		public bool loadOnStart;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool saveOnStart;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string fileName;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string fileExtension;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string currentSaveName;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string savePath;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7208E4", Offset = "0x7208E4")]
		public string sceneName;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 playerPosition;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Quaternion playerRotation;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int activePuzzleId;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string currentTeleportNodeName;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Dictionary<int, bool> zoneCullingActive;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<int, bool> nodeGroupsActive;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x72091C", Offset = "0x72091C")]
		public AreaManager areaManager;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject ovrCameraRig;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public PlayerLocomotionTeleport teleport;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Animator savingIncon;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static bool restoreDataOnNextSceneLoad;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool debugTriggerSave;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool debugMessages;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SitStandHeightOffset ssho;

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xB29B74", Offset = "0xB29B74", VA = "0xB29B74")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xB2A838", Offset = "0xB2A838", VA = "0xB2A838")]
		private void Update()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xB2A84C", Offset = "0xB2A84C", VA = "0xB2A84C")]
		private void RefreshSaveData()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xB2AD50", Offset = "0xB2AD50", VA = "0xB2AD50")]
		private Save CreateSaveObject()
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xB2A670", Offset = "0xB2A670", VA = "0xB2A670")]
		public void SaveGame()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xB1F124", Offset = "0xB1F124", VA = "0xB1F124")]
		public void DeleteSave()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xB2A088", Offset = "0xB2A088", VA = "0xB2A088")]
		public void LoadGame()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xB1EF4C", Offset = "0xB1EF4C", VA = "0xB1EF4C")]
		public void SetCurrentSaveIndex(int index)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xB1E7F4", Offset = "0xB1E7F4", VA = "0xB1E7F4")]
		public bool CheckEmptySlot(int index, out Save save)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xB2A52C", Offset = "0xB2A52C", VA = "0xB2A52C")]
		private string FindPathName(GameObject obj)
		{
			return null;
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xB2B170", Offset = "0xB2B170", VA = "0xB2B170")]
		public SaveManager()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class SaveSlot : MonoBehaviour
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int index;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainMenuManager menu;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text zoneText;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TMP_Text nbrOfPuzzles;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject existingSaveButtons;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject emptySaveButtons;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720964", Offset = "0x720964")]
		public Sprite[] bg_images;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Save datas;

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xB2B1E4", Offset = "0xB2B1E4", VA = "0xB2B1E4")]
		private void ChangeBG(int index = 0)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xB2B274", Offset = "0xB2B274", VA = "0xB2B274")]
		public void Continue()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xB2B294", Offset = "0xB2B294", VA = "0xB2B294")]
		public void Erase()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xB2B2B4", Offset = "0xB2B2B4", VA = "0xB2B2B4")]
		public void NewGame()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xB1EAA8", Offset = "0xB1EAA8", VA = "0xB1EAA8")]
		public void Display(Save save)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xB2B2D4", Offset = "0xB2B2D4", VA = "0xB2B2D4")]
		public SaveSlot()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class ScreenFader : MonoBehaviour
	{
		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F63C", Offset = "0x71F63C")]
		private sealed class <FadingCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ScreenFader <>4__this;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action callback;

			[Token(Token = "0x1700004E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0xF0470C", Offset = "0xF0470C", VA = "0xF0470C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000309")]
				[Address(RVA = "0xF04754", Offset = "0xF04754", VA = "0xF04754", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0xF045D0", Offset = "0xF045D0", VA = "0xF045D0")]
			[DebuggerHidden]
			public <FadingCoroutine>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0xF045FC", Offset = "0xF045FC", VA = "0xF045FC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0xF04600", Offset = "0xF04600", VA = "0xF04600", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000308")]
			[Address(RVA = "0xF04714", Offset = "0xF04714", VA = "0xF04714", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color fadeColor;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Image fadeImage;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool fadeInOnStart;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Color currentColor;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _currentOpacity;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float targetOpacity;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float startingOpacity;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float startTime;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float fadeDuration;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool fadeInProgress;

		[Token(Token = "0x1700004D")]
		public float currentOpacity
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xB2B2DC", Offset = "0xB2B2DC", VA = "0xB2B2DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xB2B2E4", Offset = "0xB2B2E4", VA = "0xB2B2E4")]
			set
			{
			}
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xB2B360", Offset = "0xB2B360", VA = "0xB2B360")]
		public void FadeIn(Color color, float duration)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xB2B440", Offset = "0xB2B440", VA = "0xB2B440")]
		public void FadeOut(Color color, float duration)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xB1E2FC", Offset = "0xB1E2FC", VA = "0xB1E2FC")]
		public void FadeToBlack(float duration, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB2B36C", Offset = "0xB2B36C", VA = "0xB2B36C")]
		private void Fade(Color color, float duration, float finalOpacity, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xB2B44C", Offset = "0xB2B44C", VA = "0xB2B44C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x721F84", Offset = "0x721F84")]
		private IEnumerator FadingCoroutine([Optional] Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xB2B4C4", Offset = "0xB2B4C4", VA = "0xB2B4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xB2B504", Offset = "0xB2B504", VA = "0xB2B504")]
		public ScreenFader()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class ShadowGun : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F64C", Offset = "0x71F64C")]
		private sealed class <>c
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<RaycastHit> <>9__21_0;

			[Token(Token = "0x6000316")]
			[Address(RVA = "0xF04808", Offset = "0xF04808", VA = "0xF04808")]
			public <>c()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0xF04810", Offset = "0xF04810", VA = "0xF04810")]
			internal int <Shoot>b__21_0(RaycastHit x, RaycastHit y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject hand;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LayerMask shootLayerMask;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject shadowObjectPrefab;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject shadowObject;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ShadowMesh shadowMesh;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform shootPoint;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject feedbackPrefab;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject gunTarget;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int memoLayer;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7209AC", Offset = "0x7209AC")]
		[SerializeField]
		private float hitDetectionDistance;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float maxRayDistance;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private LayerMask shootableMask;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LayerMask shadowmeshMask;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Handgun handgun;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int direction;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent OnShoot;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnSwap;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnUnSwap;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xB2C510", Offset = "0xB2C510", VA = "0xB2C510")]
		private void Start()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xB2C77C", Offset = "0xB2C77C", VA = "0xB2C77C")]
		private void Update()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xB2C670", Offset = "0xB2C670", VA = "0xB2C670")]
		private Transform FindTag(Transform t, string tag)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xB2CB24", Offset = "0xB2CB24", VA = "0xB2CB24")]
		public void Shoot()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xB2D078", Offset = "0xB2D078", VA = "0xB2D078")]
		public void HandleShot(Vector3 point, RaycastHit hit)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xB2D400", Offset = "0xB2D400", VA = "0xB2D400")]
		public void Swap(GameObject hand, int swap = 1)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xB2D5F0", Offset = "0xB2D5F0", VA = "0xB2D5F0")]
		public void Arm()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xB2D604", Offset = "0xB2D604", VA = "0xB2D604")]
		public void UnSwap()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xB2D70C", Offset = "0xB2D70C", VA = "0xB2D70C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xB2C9AC", Offset = "0xB2C9AC", VA = "0xB2C9AC")]
		private bool IsBetweenLanternAndSurface()
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xB2D8DC", Offset = "0xB2D8DC", VA = "0xB2D8DC")]
		public ShadowGun()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class ShadowMesh : RunOnSpecificFrames
	{
		[Token(Token = "0x20000A4")]
		public class Contour
		{
			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Edge2D> edges;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool closed;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int cornerVertexIndex;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 cornerVertex;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int rightMostVertexIndex;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Edge2D startEdge;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Edge2D endEdge;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float minX;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float minY;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float maxX;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float maxY;

			[Token(Token = "0x600032B")]
			[Address(RVA = "0xF04974", Offset = "0xF04974", VA = "0xF04974")]
			public Contour(Edge2D firstEdge)
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xF04A30", Offset = "0xF04A30", VA = "0xF04A30")]
			public Contour()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xF04AAC", Offset = "0xF04AAC", VA = "0xF04AAC")]
			public bool AddEdge(Edge2D e)
			{
				return default(bool);
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0xF04BE8", Offset = "0xF04BE8", VA = "0xF04BE8")]
			public void Merge(Contour c)
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0xF04E6C", Offset = "0xF04E6C", VA = "0xF04E6C")]
			public Vector2 GetVertex(int index)
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0xF04F04", Offset = "0xF04F04", VA = "0xF04F04")]
			public bool IsOrientedClockwise()
			{
				return default(bool);
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0xF050F8", Offset = "0xF050F8", VA = "0xF050F8")]
			public bool IsPointInside(Vector2 point)
			{
				return default(bool);
			}

			[Token(Token = "0x6000332")]
			[Address(RVA = "0xF0533C", Offset = "0xF0533C", VA = "0xF0533C")]
			public Vector2 FindRightmostVertex()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000333")]
			[Address(RVA = "0xF05454", Offset = "0xF05454", VA = "0xF05454")]
			public void ComputeBounds()
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F65C", Offset = "0x71F65C")]
		private sealed class <GrabRenderTexturePixelsCoroutine>d__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShadowMesh <>4__this;

			[Token(Token = "0x17000050")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000337")]
				[Address(RVA = "0xF04924", Offset = "0xF04924", VA = "0xF04924", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000051")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0xF0496C", Offset = "0xF0496C", VA = "0xF0496C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0xF04854", Offset = "0xF04854", VA = "0xF04854")]
			[DebuggerHidden]
			public <GrabRenderTexturePixelsCoroutine>d__58(int <>1__state)
			{
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0xF04880", Offset = "0xF04880", VA = "0xF04880", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0xF04884", Offset = "0xF04884", VA = "0xF04884", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0xF0492C", Offset = "0xF0492C", VA = "0xF0492C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RenderTexture shadowTexture;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture activeTexture;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rect rectReadPicture;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Mesh mesh;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> vertices;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> triangles;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Texture2D texture;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private NativeArray<Color32> pixels;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int resolution;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MeshCollider meshCollider;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float voxelSize;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float offset;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public LayerMask shadowSurfaceMask;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject shadowSurface;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 shadowSurfaceNormal;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Vector3 shadowSurfacePoint;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool shadowSurfaceFound;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		public Edge2D[] allEdges;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public int allEdgesIndex;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public Edge2D[] walkableEdges2D;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		public int walkableEdges2DIndex;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[HideInInspector]
		public Edge2D[] nonWalkableEdges2D;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public int nonWalkableEdges2DIndex;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[HideInInspector]
		public Contour[] contours;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int contoursIndex;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public int contoursDimension;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[HideInInspector]
		public Contour[] contours2D;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public int contours2DIndex;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public int contours2DDimension;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720AA8", Offset = "0x720AA8")]
		public float thickness;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool debug;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector2 downLeft;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector2 midLeft;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector2 upLeft;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector2 downMid;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Vector2 upMid;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector2 downRight;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector2 midRight;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector2 upRight;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private int vertexCount;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 cameraPosition;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool showContours;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		private bool updated;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Dictionary<Vector2, int> incidentEdges;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public RaycastGatlingGun shadowRaycasts;

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xB2D8E4", Offset = "0xB2D8E4", VA = "0xB2D8E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xB2DC5C", Offset = "0xB2DC5C", VA = "0xB2DC5C", Slot = "6")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xB2EA34", Offset = "0xB2EA34", VA = "0xB2EA34", Slot = "7")]
		public override void NonIntervalUpdate()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xB2EA3C", Offset = "0xB2EA3C", VA = "0xB2EA3C")]
		private new void LateUpdate()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xB270D0", Offset = "0xB270D0", VA = "0xB270D0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xB2DB60", Offset = "0xB2DB60", VA = "0xB2DB60")]
		private void PositionMesh()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xB2DCD0", Offset = "0xB2DCD0", VA = "0xB2DCD0")]
		public void LookForProjectionSurface()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xB2E108", Offset = "0xB2E108", VA = "0xB2E108")]
		private void RefreshMesh()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xB2EA60", Offset = "0xB2EA60", VA = "0xB2EA60")]
		private void ComputeEdges()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xB2E004", Offset = "0xB2E004", VA = "0xB2E004")]
		public Matrix4x4 ComputeProjectionMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xB2F6C4", Offset = "0xB2F6C4", VA = "0xB2F6C4")]
		public void GrabRenderTexturePixels()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xB2F7B8", Offset = "0xB2F7B8", VA = "0xB2F7B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722034", Offset = "0x722034")]
		public IEnumerator GrabRenderTexturePixelsCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xB2F4F0", Offset = "0xB2F4F0", VA = "0xB2F4F0")]
		private Edge2D ComputeProjection(Edge2D edge, bool localSpace = true)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xB2F60C", Offset = "0xB2F60C", VA = "0xB2F60C")]
		public Vector3 ComputeProjection(Vector3 pointToProject, bool localSpace = true)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xB2C9A0", Offset = "0xB2C9A0", VA = "0xB2C9A0")]
		public Vector3 ComputeWorldProjection(Vector3 pointToProject)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xB2F178", Offset = "0xB2F178", VA = "0xB2F178")]
		private void ComputeContours(Edge2D[] edges, int maxIndex)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xB2F824", Offset = "0xB2F824", VA = "0xB2F824")]
		public bool IsPointInShadow2D(Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xB2FA84", Offset = "0xB2FA84", VA = "0xB2FA84")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xB2FE1C", Offset = "0xB2FE1C", VA = "0xB2FE1C")]
		public ShadowMesh()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public struct Edge2DData
	{
		[Token(Token = "0x20000A7")]
		public enum Etype
		{
			[Token(Token = "0x4000414")]
			nwUpwards,
			[Token(Token = "0x4000415")]
			nwDownwards,
			[Token(Token = "0x4000416")]
			wStraightRight,
			[Token(Token = "0x4000417")]
			nwStraightLeft,
			[Token(Token = "0x4000418")]
			wDownwardsRight,
			[Token(Token = "0x4000419")]
			wUpwardsLeft,
			[Token(Token = "0x400041A")]
			nwDownwardsLeft,
			[Token(Token = "0x400041B")]
			nwUpwardsLeft,
			[Token(Token = "0x400041C")]
			nwTop,
			[Token(Token = "0x400041D")]
			wHandStraight,
			[Token(Token = "0x400041E")]
			wHandDownwardsRight,
			[Token(Token = "0x400041F")]
			wHandUpwardsLeft,
			[Token(Token = "0x4000420")]
			undefined
		}

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float2 a;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float2 b;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Etype etype;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1627C0C", Offset = "0x1627C0C", VA = "0x1627C0C")]
		public Edge2DData(float2 a, float2 b, Etype etype)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F66C", Offset = "0x71F66C")]
	public struct TriangulateCellJob : IJobParallelFor
	{
		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public int resolution;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[ReadOnly]
		public NativeArray<int> pixels;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ReadOnly]
		public int cells;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int x;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int y;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool hands;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[ReadOnly]
		public float voxelSize;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[ReadOnly]
		public float2 downLeft;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[ReadOnly]
		public float2 midLeft;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[ReadOnly]
		public float2 upLeft;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[ReadOnly]
		public float2 downMid;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[ReadOnly]
		public float2 upMid;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[ReadOnly]
		public float2 downRight;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[ReadOnly]
		public float2 midRight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[ReadOnly]
		public float2 upRight;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public NativeQueue<Edge2DData>.ParallelWriter allEdgesData;

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEF80F0", Offset = "0xEF80F0", VA = "0xEF80F0", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F67C", Offset = "0x71F67C")]
	public struct QueueToListJob : IJob
	{
		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public NativeQueue<Edge2DData> source;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NativeList<Edge2DData> result;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xB27CF4", Offset = "0xB27CF4", VA = "0xB27CF4", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F68C", Offset = "0x71F68C")]
	public struct ComputeProjectionJob : IJobParallelFor
	{
		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeList<Edge2DData> edges;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NativeArray<Edge2DData> projectedEdges;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public Matrix4x4 projectionMatrix;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[ReadOnly]
		public Matrix4x4 shadowSurfaceWorldToLocal;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[ReadOnly]
		public Matrix4x4 shadowMeshLocalToWorld;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x16244E4", Offset = "0x16244E4", VA = "0x16244E4", Slot = "4")]
		public void Execute(int index)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class ShadowMeshRenderTextureUpdate : MonoBehaviour
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShadowMesh shadowMesh;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera shadowCamera;

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xBA65B8", Offset = "0xBA65B8", VA = "0xBA65B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xBA66B8", Offset = "0xBA66B8", VA = "0xBA66B8")]
		private void OnBeginFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xBA6710", Offset = "0xBA6710", VA = "0xBA6710")]
		private void OnEndFrameRendering(ScriptableRenderContext context, Camera[] cameras)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xBA6784", Offset = "0xBA6784", VA = "0xBA6784")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xBA6884", Offset = "0xBA6884", VA = "0xBA6884")]
		public ShadowMeshRenderTextureUpdate()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public struct WayPointData
	{
		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Vector2 point;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Edge2DData.Etype edgeType;
	}
	[Token(Token = "0x20000AD")]
	public struct Contour2DData
	{
		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float minX;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float maxX;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float minY;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float maxY;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int startIndex;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int endIndex;
	}
	[Token(Token = "0x20000AE")]
	public struct WayPointLinkData
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int first;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int second;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool isFall;
	}
	[Token(Token = "0x20000AF")]
	[AttributeAttribute(Name = "BurstCompileAttribute", RVA = "0x71F69C", Offset = "0x71F69C")]
	public struct ComputeJumpsAndFallsJob : IJobParallelFor
	{
		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<WayPointData> ways;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeArray<int> waysIndexes;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public NativeArray<Contour2DData> contours2D;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[ReadOnly]
		public int waysListIndex;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[ReadOnly]
		public int waysListDimension;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ReadOnly]
		public int waysDimension;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[ReadOnly]
		public float MaxDistance;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[ReadOnly]
		public float jumpHeight;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[ReadOnly]
		public float fallHeight;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[ReadOnly]
		public float jumpWidth;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[ReadOnly]
		public float fallWidth;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[ReadOnly]
		public NativeArray<Edge2DData> edges;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public NativeQueue<WayPointLinkData>.ParallelWriter wayPointLinks;

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1623E44", Offset = "0x1623E44", VA = "0x1623E44", Slot = "4")]
		public void Execute(int index)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1624024", Offset = "0x1624024", VA = "0x1624024")]
		private bool TestWayPoint(WayPointData wayPoint, WayPointData waypointToTest, int wayIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1624198", Offset = "0x1624198", VA = "0x1624198")]
		private bool IsThereIsASecant(Vector2 begin, Vector2 end)
		{
			return default(bool);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x16242F0", Offset = "0x16242F0", VA = "0x16242F0")]
		private bool Intersect(Edge2DData edge, Vector2 a, Vector2 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x16244C0", Offset = "0x16244C0", VA = "0x16244C0")]
		private bool IsCounterClockWise(Vector2 a, Vector2 b, Vector2 c)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B0")]
	public class ShadowSoulsEmitter : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F6AC", Offset = "0x71F6AC")]
		private sealed class <CreateSoul>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShadowSoulsEmitter <>4__this;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int nbrOfSouls;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Transform <target>5__2;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__3;

			[Token(Token = "0x17000052")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034E")]
				[Address(RVA = "0xF05D38", Offset = "0xF05D38", VA = "0xF05D38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000053")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000350")]
				[Address(RVA = "0xF05D80", Offset = "0xF05D80", VA = "0xF05D80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0xF05A6C", Offset = "0xF05A6C", VA = "0xF05A6C")]
			[DebuggerHidden]
			public <CreateSoul>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0xF05A98", Offset = "0xF05A98", VA = "0xF05A98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0xF05A9C", Offset = "0xF05A9C", VA = "0xF05A9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0xF05D40", Offset = "0xF05D40", VA = "0xF05D40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject soulParticle;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] possibleTargets;

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xBAD6CC", Offset = "0xBAD6CC", VA = "0xBAD6CC")]
		public void GenerateSoul(int nbrOfSouls)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xBAD6F8", Offset = "0xBAD6F8", VA = "0xBAD6F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7220E4", Offset = "0x7220E4")]
		private IEnumerator CreateSoul(int nbrOfSouls)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xBAD774", Offset = "0xBAD774", VA = "0xBAD774")]
		public ShadowSoulsEmitter()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class ShadowSubmesh : MonoBehaviour
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool done;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ShadowCastingMode scm;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xBAD77C", Offset = "0xBAD77C", VA = "0xBAD77C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xBAD8C4", Offset = "0xBAD8C4", VA = "0xBAD8C4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xBAD7E4", Offset = "0xBAD7E4", VA = "0xBAD7E4")]
		private void Check()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xBAD8C8", Offset = "0xBAD8C8", VA = "0xBAD8C8")]
		public ShadowSubmesh()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class ShadowSurfaceInteractable : MonoBehaviour
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x720C80", Offset = "0x720C80")]
		private MonoBehaviour _iInteractableViewMono;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IInteractableView<RayInteractor> _interactableView;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PuzzleManager manager;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityAction onPuzzleFinished;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Goal goal;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xBAD8D0", Offset = "0xBAD8D0", VA = "0xBAD8D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xBAD9EC", Offset = "0xBAD9EC", VA = "0xBAD9EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xBADB00", Offset = "0xBADB00", VA = "0xBADB00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xBADC14", Offset = "0xBADC14", VA = "0xBADC14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xBADF80", Offset = "0xBADF80", VA = "0xBADF80")]
		private void ProcessNewState()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xBAE38C", Offset = "0xBAE38C", VA = "0xBAE38C")]
		private void OnStateChanged(InteractableStateChangeArgs args)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xBAE390", Offset = "0xBAE390", VA = "0xBAE390")]
		private void DisableCollider()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xBAE41C", Offset = "0xBAE41C", VA = "0xBAE41C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xBAE4E8", Offset = "0xBAE4E8", VA = "0xBAE4E8")]
		public ShadowSurfaceInteractable()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class ShootFeedback : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F6BC", Offset = "0x71F6BC")]
		private sealed class <ExpandRay>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float distanceFromScreen;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ShootFeedback <>4__this;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float lenght;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0xF0611C", Offset = "0xF0611C", VA = "0xF0611C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000366")]
				[Address(RVA = "0xF06164", Offset = "0xF06164", VA = "0xF06164", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000361")]
			[Address(RVA = "0xF05D88", Offset = "0xF05D88", VA = "0xF05D88")]
			[DebuggerHidden]
			public <ExpandRay>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0xF05DB4", Offset = "0xF05DB4", VA = "0xF05DB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000363")]
			[Address(RVA = "0xF05DB8", Offset = "0xF05DB8", VA = "0xF05DB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xF06124", Offset = "0xF06124", VA = "0xF06124", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem startParticle;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ParticleSystem endParticle;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem projectileParticle;

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xBAE4F0", Offset = "0xBAE4F0", VA = "0xBAE4F0")]
		public void BeingShooted(float lenght, float distanceFromScreen)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xBAE51C", Offset = "0xBAE51C", VA = "0xBAE51C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722194", Offset = "0x722194")]
		private IEnumerator ExpandRay(float lenght, float distanceFromScreen)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xBAE5A0", Offset = "0xBAE5A0", VA = "0xBAE5A0")]
		public ShootFeedback()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F6CC", Offset = "0x71F6CC")]
	public class Shootable : RestorableAndRunOnSpecificFrame
	{
		[Token(Token = "0x20000B7")]
		private class Edge
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int a;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int b;

			[Token(Token = "0x6000370")]
			[Address(RVA = "0xF0616C", Offset = "0xF0616C", VA = "0xF0616C")]
			public Edge(int a, int b)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0xF061A4", Offset = "0xF061A4", VA = "0xF061A4", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0xF06278", Offset = "0xF06278", VA = "0xF06278", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public ShadowMesh shadowMesh;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform cameraTransform;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int[] triangles;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] vertices;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] projectedVertices;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] newVertices;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<int> newTriangles;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Mesh newMesh;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private MeshCollider newMeshCollider;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private MeshFilter filter;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private MeshFilter originalMesh;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool skinnedMesh;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<Edge> edges;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Dictionary<int, int> vertexReplacements;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public GameObject shadowObject;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<Edge> outsideEdges;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool UpdateMeshColliderOnlyOnStart;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool isRunning;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public UnityEvent WhenIsShooted;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xBAE5A8", Offset = "0xBAE5A8", VA = "0xBAE5A8", Slot = "10")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xBAEE90", Offset = "0xBAEE90", VA = "0xBAEE90", Slot = "11")]
		public override void Restore()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xBAEEB8", Offset = "0xBAEEB8", VA = "0xBAEEB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xBAF180", Offset = "0xBAF180", VA = "0xBAF180")]
		private Dictionary<int, int> ComputeVertexWelding(Vector3[] vertices)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xBAF300", Offset = "0xBAF300", VA = "0xBAF300", Slot = "8")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xBAE5E4", Offset = "0xBAE5E4", VA = "0xBAE5E4")]
		public void UpdateMeshCollider()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xBAF318", Offset = "0xBAF318", VA = "0xBAF318")]
		private void AddEdgeToList(Edge e)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xBAF3DC", Offset = "0xBAF3DC", VA = "0xBAF3DC")]
		public void Action()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xBAF424", Offset = "0xBAF424", VA = "0xBAF424")]
		public Shootable()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class SitStandHeightOffset : MonoBehaviour
	{
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool forceResetOnTeleportNode;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider slider;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject offsetSlider;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SittingStandingToggle sittingToggle;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 sittingOffset;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 standingOffset;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool sitting;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public SittingStandingToggle sittingStanding;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xBB0480", Offset = "0xBB0480", VA = "0xBB0480")]
		public void SetSitting(bool value)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xBB061C", Offset = "0xBB061C", VA = "0xBB061C")]
		public void SwitchMode()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xBB062C", Offset = "0xBB062C", VA = "0xBB062C")]
		public void SwitchMode(Toggle toggle)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xBB0644", Offset = "0xBB0644", VA = "0xBB0644")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xBB06C0", Offset = "0xBB06C0", VA = "0xBB06C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xBB0784", Offset = "0xBB0784", VA = "0xBB0784")]
		private void Update()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xBB0818", Offset = "0xBB0818", VA = "0xBB0818")]
		public void SetSittingOffset(float value)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xBB08F8", Offset = "0xBB08F8", VA = "0xBB08F8")]
		public void SetStandingOffset(float value)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xBB09D8", Offset = "0xBB09D8", VA = "0xBB09D8")]
		public void AdaptSittingPosToValue(Slider slider)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xBB0A18", Offset = "0xBB0A18", VA = "0xBB0A18")]
		public SitStandHeightOffset()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class SittingStandingToggle : MonoBehaviour
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string onLabel;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string offLabel;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject offsetSliderSitting;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject offsetSliderStanding;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isSitting;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshProUGUI label;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Toggle toggle;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xBB0A20", Offset = "0xBB0A20", VA = "0xBB0A20")]
		private void Start()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xBB0A98", Offset = "0xBB0A98", VA = "0xBB0A98")]
		public void SetLabel()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xBB0EE8", Offset = "0xBB0EE8", VA = "0xBB0EE8")]
		public SittingStandingToggle()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class SliderToValue : MonoBehaviour
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI text;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Slider slider;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xBB0EF0", Offset = "0xBB0EF0", VA = "0xBB0EF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xBB0F90", Offset = "0xBB0F90", VA = "0xBB0F90")]
		public void SetTextToValue(float value)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xBB1014", Offset = "0xBB1014", VA = "0xBB1014")]
		public SliderToValue()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform followTarget;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool updatePosition;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool updateRotation;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xBB101C", Offset = "0xBB101C", VA = "0xBB101C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xBB1158", Offset = "0xBB1158", VA = "0xBB1158")]
		private void Update()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xBB119C", Offset = "0xBB119C", VA = "0xBB119C")]
		private void UpdatePositionSmooth()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xBB1268", Offset = "0xBB1268", VA = "0xBB1268")]
		private void UpdateRotationSmooth()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xBB134C", Offset = "0xBB134C", VA = "0xBB134C")]
		public SmoothFollow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BC")]
	public class SmoothedVector3
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int smoothingSteps;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Vector3 _value;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] storedValues;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int currentIndex;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int totalStepsRecorded;

		[Token(Token = "0x17000056")]
		public Vector3 value
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0xBB135C", Offset = "0xBB135C", VA = "0xBB135C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000389")]
			[Address(RVA = "0xBB1368", Offset = "0xBB1368", VA = "0xBB1368")]
			set
			{
			}
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xBB14C4", Offset = "0xBB14C4", VA = "0xBB14C4")]
		public SmoothedVector3()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xBB136C", Offset = "0xBB136C", VA = "0xBB136C")]
		public void Add(Vector3 value)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xBB152C", Offset = "0xBB152C", VA = "0xBB152C")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public class SoulParticles : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F72C", Offset = "0x71F72C")]
		private sealed class <StartTrajectory>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoulParticles <>4__this;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform target;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 <startingPosition>5__2;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <lerpValue>5__3;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool <targetReached>5__4;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000393")]
				[Address(RVA = "0x16073E4", Offset = "0x16073E4", VA = "0x16073E4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000395")]
				[Address(RVA = "0x160742C", Offset = "0x160742C", VA = "0x160742C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1607190", Offset = "0x1607190", VA = "0x1607190")]
			[DebuggerHidden]
			public <StartTrajectory>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x16071BC", Offset = "0x16071BC", VA = "0x16071BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x16071C0", Offset = "0x16071C0", VA = "0x16071C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x16073EC", Offset = "0x16073EC", VA = "0x16073EC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049B")]
		private const float speed = 0.6f;

		[Token(Token = "0x400049C")]
		private const float amplitude = 0.1f;

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xBB2430", Offset = "0xBB2430", VA = "0xBB2430")]
		public void LaunchTrajectory(Transform target)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xBB245C", Offset = "0xBB245C", VA = "0xBB245C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722244", Offset = "0x722244")]
		private IEnumerator StartTrajectory(Transform target)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xBB24D4", Offset = "0xBB24D4", VA = "0xBB24D4")]
		public SoulParticles()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class SoundEffectsRandom : MonoBehaviour
	{
		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject cameraParent;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject audioGameObject;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioSource audioSource;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip[] audioClipArray;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int audioClipIndex;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<int> previousList;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float chronoSound;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float chronoSoundMaxTime;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float chronoSoundMin;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float chronoSoundMax;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float randomPitch;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float randomPitchMin;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float randomPitchMax;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float randomPan;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float randomPanLeft;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float randomPanRight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float randomVolume;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomVolumeMin;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomVolumeMax;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int countClip;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xBB24DC", Offset = "0xBB24DC", VA = "0xBB24DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xBB25DC", Offset = "0xBB25DC", VA = "0xBB25DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xBB264C", Offset = "0xBB264C", VA = "0xBB264C")]
		public void PlayDropSound()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xBB27A0", Offset = "0xBB27A0", VA = "0xBB27A0")]
		public AudioClip GetRandomAudioClip()
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xBB28A0", Offset = "0xBB28A0", VA = "0xBB28A0")]
		private bool PreviousArrayContainsAudioClipIndex()
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xBB2588", Offset = "0xBB2588", VA = "0xBB2588")]
		public void SetParent(GameObject newParent)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xBB294C", Offset = "0xBB294C", VA = "0xBB294C")]
		public SoundEffectsRandom()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class SpawnParticleEffect : MonoBehaviour
	{
		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject particleEffect;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xBB29F8", Offset = "0xBB29F8", VA = "0xBB29F8")]
		public GameObject SpawnEffectNearTransform(Transform origin, [Optional] Vector3 offset)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xBB2B04", Offset = "0xBB2B04", VA = "0xBB2B04")]
		public SpawnParticleEffect()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F73C", Offset = "0x71F73C")]
	public class SuccessVFX : MonoBehaviour
	{
		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem particle;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Animator animator;

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xBB3A20", Offset = "0xBB3A20", VA = "0xBB3A20")]
		public void PlayAnimation()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xBB3A78", Offset = "0xBB3A78", VA = "0xBB3A78")]
		public void PlayParticle()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xBB3A94", Offset = "0xBB3A94", VA = "0xBB3A94")]
		public SuccessVFX()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class SwitchHandle : RestorableObject, ITransformer
	{
		[Serializable]
		[Token(Token = "0x20000C3")]
		public class SwitchUnityEvent : UnityEvent<int>
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x160743C", Offset = "0x160743C", VA = "0x160743C")]
			public SwitchUnityEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Constraints
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FloatConstraint MinAngle;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FloatConstraint MaxAngle;

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x1607434", Offset = "0x1607434", VA = "0x1607434")]
			public Constraints()
			{
			}
		}

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720D10", Offset = "0x720D10")]
		public int numberOfPositions;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720D28", Offset = "0x720D28")]
		public int startingPosition;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int currentPos;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public int lastSelectedPos;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int lastDisplayedPos;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float angleBetweenPositions;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Transform _optionalPivotTransform;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Constraints _constraints;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _relativeAngle;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float memoRelativeAngle;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _constrainedRelativeAngle;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float memoConstrainedRelativeAngle;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ITransformable _transformable;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion memoTransformableRotation;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool autoRotate;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float targetConstrainedAngle;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720D60", Offset = "0x720D60")]
		public GameObject[] markers;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MeshRenderer[] markersRenderers;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Color selectedColor;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720D98", Offset = "0x720D98")]
		public UnityEvent onGrabbed;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public SwitchUnityEvent onPositionReached;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public UnityEvent onPosition0Reached;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public UnityEvent onPosition1Reached;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public UnityEvent onPosition2Reached;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public UnityEvent onPosition3Reached;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public UnityEvent onPosition4Reached;

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xBB3A9C", Offset = "0xBB3A9C", VA = "0xBB3A9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xBB3D84", Offset = "0xBB3D84", VA = "0xBB3D84", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xBB3E10", Offset = "0xBB3E10", VA = "0xBB3E10", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xBB3F1C", Offset = "0xBB3F1C", VA = "0xBB3F1C", Slot = "8")]
		public void Initialize(ITransformable transformable)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xBB3DF4", Offset = "0xBB3DF4", VA = "0xBB3DF4")]
		public void SetStartingPosition()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xBB3F24", Offset = "0xBB3F24", VA = "0xBB3F24", Slot = "9")]
		public void BeginTransform()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xBB3F40", Offset = "0xBB3F40", VA = "0xBB3F40", Slot = "10")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xBB43C0", Offset = "0xBB43C0", VA = "0xBB43C0", Slot = "11")]
		public void EndTransform()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xBB44CC", Offset = "0xBB44CC", VA = "0xBB44CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xBB46A0", Offset = "0xBB46A0", VA = "0xBB46A0")]
		public SwitchHandle()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class SwitchLantern : RestorableObject
	{
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F79C", Offset = "0x71F79C")]
		private sealed class <_Move>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SwitchLantern <>4__this;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform target;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float[] <targets>5__2;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float[] <starts>5__3;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float[] <targetRots>5__4;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float[] <startRots>5__5;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private int[] <orderPos>5__6;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int[] <orderRot>5__7;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <i>5__8;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float <ratio>5__9;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private float <time>5__10;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private float <t>5__11;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x1607C20", Offset = "0x1607C20", VA = "0x1607C20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x1607C68", Offset = "0x1607C68", VA = "0x1607C68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1607488", Offset = "0x1607488", VA = "0x1607488")]
			[DebuggerHidden]
			public <_Move>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x16074B4", Offset = "0x16074B4", VA = "0x16074B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x16074B8", Offset = "0x16074B8", VA = "0x16074B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1607C28", Offset = "0x1607C28", VA = "0x1607C28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent OnMovementStart;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnMovementEnd;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float speed;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform[] targets;

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xBB4708", Offset = "0xBB4708", VA = "0xBB4708")]
		public void Move(int index)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xBB4744", Offset = "0xBB4744", VA = "0xBB4744")]
		public void Move(Transform target)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xBB4784", Offset = "0xBB4784", VA = "0xBB4784")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7222F4", Offset = "0x7222F4")]
		private IEnumerator _Move(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xBB47FC", Offset = "0xBB47FC", VA = "0xBB47FC", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xBB4828", Offset = "0xBB4828", VA = "0xBB4828")]
		public SwitchLantern()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class TeleportNode : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		public enum Type
		{
			[Token(Token = "0x4000500")]
			PositionOnly,
			[Token(Token = "0x4000501")]
			PositionRotation
		}

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool sittingOffsetAcquired;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static SitStandHeightOffset ssho;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Transform ovrCameraRigTransform;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type nodeType;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720DD0", Offset = "0x720DD0")]
		public float neighbourDetectionRadius;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TeleportNode> neighbors;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator animator;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem particle;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool startingNode;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TeleportNode[] allNodes;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float maxAnimationSpeedMultiplier;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve speedMultiplierCurve;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent onReachNode;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent onLeaveNode;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public NodeGroup nodeGroup;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<ZoneCulling> zonesActivesFromHere;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ZoneCulling[] zones;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool activeNode;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private HandBlindzones handBlindzones;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public PlayerLocomotionTeleport playerTeleport;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Scene sittingOffsetScene;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioSource rotationAudioSource;

		[Token(Token = "0x1700005B")]
		public bool canBeActivated
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0xBB5100", Offset = "0xBB5100", VA = "0xBB5100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xBB5194", Offset = "0xBB5194", VA = "0xBB5194")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xBB5538", Offset = "0xBB5538", VA = "0xBB5538")]
		private void Start()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xBB53A4", Offset = "0xBB53A4", VA = "0xBB53A4")]
		public void SetActive(bool state)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xBB5B68", Offset = "0xBB5B68", VA = "0xBB5B68")]
		public void SetAnimationSpeedMultiplier(float value)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xBB5BFC", Offset = "0xBB5BFC", VA = "0xBB5BFC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xBB5DD8", Offset = "0xBB5DD8", VA = "0xBB5DD8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xBB58BC", Offset = "0xBB58BC", VA = "0xBB58BC")]
		public void SetAsCurrentNode(bool addOffset = true)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xBB5E54", Offset = "0xBB5E54", VA = "0xBB5E54")]
		public void ActivateNeighbors()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xBB6054", Offset = "0xBB6054", VA = "0xBB6054")]
		public void LeaveNode()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xBB60A0", Offset = "0xBB60A0", VA = "0xBB60A0")]
		public void CheckActiveNode(bool onOff)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xBB60AC", Offset = "0xBB60AC", VA = "0xBB60AC")]
		public TeleportNode()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xBB60C0", Offset = "0xBB60C0", VA = "0xBB60C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7223A4", Offset = "0x7223A4")]
		private void <Start>b__26_0()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xBB60CC", Offset = "0xBB60CC", VA = "0xBB60CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7223B4", Offset = "0x7223B4")]
		private void <Start>b__26_1()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class TestAsyncCube : MonoBehaviour
	{
		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F7AC", Offset = "0x71F7AC")]
		private sealed class <_LoadNow>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TestAsyncCube <>4__this;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <dt>5__2;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0x1607E54", Offset = "0x1607E54", VA = "0x1607E54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x1607E9C", Offset = "0x1607E9C", VA = "0x1607E9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1607C70", Offset = "0x1607C70", VA = "0x1607C70")]
			[DebuggerHidden]
			public <_LoadNow>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1607C9C", Offset = "0x1607C9C", VA = "0x1607C9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1607CA0", Offset = "0x1607CA0", VA = "0x1607CA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1607E5C", Offset = "0x1607E5C", VA = "0x1607E5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text text;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xBB60D4", Offset = "0xBB60D4", VA = "0xBB60D4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xBB60D8", Offset = "0xBB60D8", VA = "0xBB60D8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xBB61AC", Offset = "0xBB61AC", VA = "0xBB61AC")]
		public void LoadNow()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xBB61D8", Offset = "0xBB61D8", VA = "0xBB61D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7223C4", Offset = "0x7223C4")]
		private IEnumerator _LoadNow()
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xBB6244", Offset = "0xBB6244", VA = "0xBB6244")]
		public void Ready()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xBB630C", Offset = "0xBB630C", VA = "0xBB630C")]
		public TestAsyncCube()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class TitleScreenMenu : MonoBehaviour
	{
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xBB7FB0", Offset = "0xBB7FB0", VA = "0xBB7FB0")]
		public void StartGame()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xBB7FB4", Offset = "0xBB7FB4", VA = "0xBB7FB4")]
		public void Quit()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xBB7FBC", Offset = "0xBB7FBC", VA = "0xBB7FBC")]
		public TitleScreenMenu()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class TreeNode<T>
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TreeNode<T> parent;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LinkedList<TreeNode<T>> children;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T value;

		[Token(Token = "0x60003D7")]
		public TreeNode(T value)
		{
		}

		[Token(Token = "0x60003D8")]
		public TreeNode<T> AddChild(T value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000CD")]
	public class TriggerEvent : MonoBehaviour
	{
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string tagToLookFor;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent onTriggerEnter;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool alreadyActivated;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEF90DC", Offset = "0xEF90DC", VA = "0xEF90DC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xEF918C", Offset = "0xEF918C", VA = "0xEF918C")]
		public TriggerEvent()
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class UnlockShape : MonoBehaviour
	{
		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F7BC", Offset = "0x71F7BC")]
		private sealed class <GoToDestination>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnlockShape <>4__this;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <timer>5__2;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 <startPosition>5__3;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <p2>5__4;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Quaternion <startRotation>5__5;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 <startScale>5__6;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x1608320", Offset = "0x1608320", VA = "0x1608320", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x1608368", Offset = "0x1608368", VA = "0x1608368", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1607EA4", Offset = "0x1607EA4", VA = "0x1607EA4")]
			[DebuggerHidden]
			public <GoToDestination>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1607ED0", Offset = "0x1607ED0", VA = "0x1607ED0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1607ED4", Offset = "0x1607ED4", VA = "0x1607ED4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1608328", Offset = "0x1608328", VA = "0x1608328", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform target;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool reachedDestination;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float timeToMove;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720E1C", Offset = "0x720E1C")]
		public float delay;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform debugTarget;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEF9194", Offset = "0xEF9194", VA = "0xEF9194")]
		public void SetTarget(Transform newTarget)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEF9240", Offset = "0xEF9240", VA = "0xEF9240")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722474", Offset = "0x722474")]
		private IEnumerator GoToDestination()
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEF92AC", Offset = "0xEF92AC", VA = "0xEF92AC")]
		public UnlockShape()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class UpdateCameraFOV : MonoBehaviour
	{
		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera ownCamera;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera targetCamera;

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEF92B4", Offset = "0xEF92B4", VA = "0xEF92B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEF9308", Offset = "0xEF9308", VA = "0xEF9308")]
		private void Update()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEF93E4", Offset = "0xEF93E4", VA = "0xEF93E4")]
		public UpdateCameraFOV()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class VersionningTitle : MonoBehaviour
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_Text versionText;

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEF93EC", Offset = "0xEF93EC", VA = "0xEF93EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEF94C4", Offset = "0xEF94C4", VA = "0xEF94C4")]
		public VersionningTitle()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class WaterFlow : RestorableObject
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F7CC", Offset = "0x71F7CC")]
		private sealed class <>c
		{
			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Flow> <>9__37_0;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x16083D0", Offset = "0x16083D0", VA = "0x16083D0")]
			public <>c()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x16083D8", Offset = "0x16083D8", VA = "0x16083D8")]
			internal bool <Update>b__37_0(Flow f)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool flowingOnInit;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public LayerMask collisionLayerMask;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float maxRaycastDistance;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool debug;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int maxNumberOfSegments;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float gravity;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float initialSpeed;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720E54", Offset = "0x720E54")]
		public float dampening;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float timeStep;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float meshRadius;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int numFaces;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GameObject splashEffect;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameObject[] splashPool;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<Flow> flows;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Flow primaryFlow;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool[] framesUpdate;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _flowing;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float startTime;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public MeshCollider meshCollider;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public bool debugManualStart;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool debugManualStartPrevious;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[HideInInspector]
		public Vector3 startPosition;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public Vector3 startVelocity;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Mesh mesh;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720E8C", Offset = "0x720E8C")]
		public float velocityCutoff;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public ShadowMesh shadowMesh;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[HideInInspector]
		public Collider interactingCollider;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public float moveThreshold;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public bool dirty;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public float dotProductCutoff;

		[Token(Token = "0x17000060")]
		public bool Flowing
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xEF9644", Offset = "0xEF9644", VA = "0xEF9644")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xEF964C", Offset = "0xEF964C", VA = "0xEF964C")]
			set
			{
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xEF97D0", Offset = "0xEF97D0", VA = "0xEF97D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xEF9AB0", Offset = "0xEF9AB0", VA = "0xEF9AB0", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEF9AF0", Offset = "0xEF9AF0", VA = "0xEF9AF0", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEF9B74", Offset = "0xEF9B74", VA = "0xEF9B74")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEFAD74", Offset = "0xEFAD74", VA = "0xEFAD74")]
		private void GenerateMeshRing(Vector3 center, Vector3 previousDirection, Vector3 nextDirection, Vector3[] vertices, int startIndex, int numberOfPoints)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEFA33C", Offset = "0xEFA33C", VA = "0xEFA33C")]
		private void GenerateMesh()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEFAFF0", Offset = "0xEFAFF0", VA = "0xEFAFF0")]
		public WaterFlow()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class WaterReceptacle : RestorableObject
	{
		[Token(Token = "0x20000D5")]
		public enum Shape
		{
			[Token(Token = "0x4000550")]
			Cylinder,
			[Token(Token = "0x4000551")]
			Box,
			[Token(Token = "0x4000552")]
			Octagon
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public struct OverflowPoint
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x720FC0", Offset = "0x720FC0")]
			public float threshold;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool active;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public WaterFlow waterFlow;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float emptyingRate;
		}

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720ED4", Offset = "0x720ED4")]
		public float fillRate;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x720F0C", Offset = "0x720F0C")]
		private float fillDelay;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float fillMultiplier;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public OverflowPoint[] overflowPoints;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool[] memoOverflowPointsActive;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720F58", Offset = "0x720F58")]
		public WaterReceptacleSurface waterSurface;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Shape shape;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Collider trigger;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float volume;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float surface;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float content;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float memoContent;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float filledFraction;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float timeLastParticleReceived;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		public bool filling;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		[HideInInspector]
		public bool emptying;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float minimumSurfaceScale;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEFB114", Offset = "0xEFB114", VA = "0xEFB114")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xEFB434", Offset = "0xEFB434", VA = "0xEFB434", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xEFB510", Offset = "0xEFB510", VA = "0xEFB510", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEFB5A0", Offset = "0xEFB5A0", VA = "0xEFB5A0")]
		public void Fill()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEFB5D0", Offset = "0xEFB5D0", VA = "0xEFB5D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEFB7A0", Offset = "0xEFB7A0", VA = "0xEFB7A0")]
		public void ActivateOverflowPoint(int index)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEFB8E0", Offset = "0xEFB8E0", VA = "0xEFB8E0")]
		public WaterReceptacle()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class WaterReceptacleSurface : MonoBehaviour
	{
		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterReceptacle receptacle;

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEFB908", Offset = "0xEFB908", VA = "0xEFB908")]
		public void FilledByWaterFlow()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEFB940", Offset = "0xEFB940", VA = "0xEFB940")]
		public WaterReceptacleSurface()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class WaterflowPhysics : RestorableObject
	{
		[Serializable]
		[Token(Token = "0x20000D9")]
		public struct FlowBoundaries
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int start;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int end;
		}

		[Serializable]
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F7DC", Offset = "0x71F7DC")]
		private sealed class <>c
		{
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<WaterflowSphere> <>9__26_0;

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1608450", Offset = "0x1608450", VA = "0x1608450")]
			public <>c()
			{
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1608458", Offset = "0x1608458", VA = "0x1608458")]
			internal bool <Update>b__26_0(WaterflowSphere e)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool flowingOnInit;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 initialVelocity;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x720FD8", Offset = "0x720FD8")]
		public ObjectPool waterSpherePool;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float spawnRate;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float maxAge;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x721010", Offset = "0x721010")]
		public float meshRadius;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int numFaces;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float mergingDistance;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x721048", Offset = "0x721048")]
		[SerializeField]
		private ShadowMesh shadowMesh;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x721094", Offset = "0x721094")]
		[SerializeField]
		private bool debug;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<WaterflowSphere> spheres;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private List<FlowBoundaries> flowBoundaries;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Mesh mesh;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private MeshCollider meshCollider;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private MeshFilter meshFilter;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool currentlyFlowing;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float timer;

		[Token(Token = "0x17000061")]
		public bool flowing
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xEFB948", Offset = "0xEFB948", VA = "0xEFB948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003FF")]
			[Address(RVA = "0xEFB950", Offset = "0xEFB950", VA = "0xEFB950")]
			set
			{
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEFBBB0", Offset = "0xEFBBB0", VA = "0xEFBBB0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEFBD28", Offset = "0xEFBD28", VA = "0xEFBD28", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEFBD80", Offset = "0xEFBD80", VA = "0xEFBD80", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEFBDE0", Offset = "0xEFBDE0", VA = "0xEFBDE0")]
		private void ResetFlow()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEFCE60", Offset = "0xEFCE60", VA = "0xEFCE60")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEFCEC8", Offset = "0xEFCEC8", VA = "0xEFCEC8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xEFB998", Offset = "0xEFB998", VA = "0xEFB998")]
		private void SpawnSphere()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEFBEBC", Offset = "0xEFBEBC", VA = "0xEFBEBC")]
		private void ComputeFlows()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEFD0DC", Offset = "0xEFD0DC", VA = "0xEFD0DC")]
		private void DisplayTrajectory()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEFD2CC", Offset = "0xEFD2CC", VA = "0xEFD2CC")]
		private void GenerateMeshRing(Vector3 center, Vector3 previousDirection, Vector3 nextDirection, Vector3[] vertices, int startIndex, int numberOfPoints)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEFC084", Offset = "0xEFC084", VA = "0xEFC084")]
		private void GenerateMesh()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEFD690", Offset = "0xEFD690", VA = "0xEFD690")]
		public WaterflowPhysics()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class WaterflowSphere : MonoBehaviour
	{
		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float timeOfBirth;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool readyToDelete;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float maximumAge;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Vector3 constraintAxis;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody rb;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xEFD750", Offset = "0xEFD750", VA = "0xEFD750")]
		private void Start()
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xEFD7A4", Offset = "0xEFD7A4", VA = "0xEFD7A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xEFD7D0", Offset = "0xEFD7D0", VA = "0xEFD7D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xEFD810", Offset = "0xEFD810", VA = "0xEFD810")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xEFD8B4", Offset = "0xEFD8B4", VA = "0xEFD8B4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xEFD98C", Offset = "0xEFD98C", VA = "0xEFD98C")]
		public WaterflowSphere()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F7EC", Offset = "0x71F7EC")]
	public class AnimatedDomino : MonoBehaviour
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x161F150", Offset = "0x161F150", VA = "0x161F150")]
		public void LaunchAnimation()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x161F1E4", Offset = "0x161F1E4", VA = "0x161F1E4")]
		public void LaunchReverseAnim()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x161F278", Offset = "0x161F278", VA = "0x161F278")]
		public AnimatedDomino()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F84C", Offset = "0x71F84C")]
	public class AnimatedHelix : MonoBehaviour
	{
		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animController;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x161F280", Offset = "0x161F280", VA = "0x161F280")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x161F344", Offset = "0x161F344", VA = "0x161F344")]
		public void SetState(int state)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x161F680", Offset = "0x161F680", VA = "0x161F680")]
		public void StopRigidbody(Rigidbody obj)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x161F71C", Offset = "0x161F71C", VA = "0x161F71C")]
		public void Restore()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x161F724", Offset = "0x161F724", VA = "0x161F724")]
		public AnimatedHelix()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class CamelPuzzle : RestorableObject
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform leftLeg;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform rightLeg;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform square;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion memoLeftLegRotation;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion memoRightLegRotation;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion memoSquareRotation;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float rotationStep;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x721120", Offset = "0x721120")]
		public float leftTargetRotation;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x72113C", Offset = "0x72113C")]
		public float rightTargetRotation;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Animator animator;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioSource audio;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Color greenColor;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Color redColor;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Color greyColor;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public SpriteRenderer[] sprites;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public SpriteRenderer centralSprite;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public InteractableUnityEventWrapper[] buttons;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public PokeInteractable[] pokeButtons;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721158", Offset = "0x721158")]
		private bool <running>k__BackingField;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		private bool animationRunning;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float leftStepRotation;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float rightStepRotation;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float squareStepRotation;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool leftRunning;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		private bool rightRunning;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		private bool squareRunning;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		private bool correctRotations;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float leftSpeedMultiplier;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private float rightSpeedMultiplier;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private LanternSlide leftSlide;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private LanternSlide rightSlide;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private LanternSlide squareSlide;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public UnityEvent OnRunningStart;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public UnityEvent OnRunningEnd;

		[Token(Token = "0x17000062")]
		public bool running
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x16214C8", Offset = "0x16214C8", VA = "0x16214C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722524", Offset = "0x722524")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x16214D0", Offset = "0x16214D0", VA = "0x16214D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722534", Offset = "0x722534")]
			set
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x16214DC", Offset = "0x16214DC", VA = "0x16214DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x16215B4", Offset = "0x16215B4", VA = "0x16215B4", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x16217F0", Offset = "0x16217F0", VA = "0x16217F0", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x162187C", Offset = "0x162187C", VA = "0x162187C")]
		public void LeftRotate()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1621930", Offset = "0x1621930", VA = "0x1621930")]
		public void RightRotate()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x16218D8", Offset = "0x16218D8", VA = "0x16218D8")]
		public void SquareRotate(bool positive)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x162198C", Offset = "0x162198C", VA = "0x162198C")]
		public void CheckRotations()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1621AE8", Offset = "0x1621AE8", VA = "0x1621AE8")]
		public void AnimationFinished()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1621AF0", Offset = "0x1621AF0", VA = "0x1621AF0")]
		private bool RotatePiece(Transform piece, ref float stepRotation, float multiplier)
		{
			return default(bool);
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x16215E8", Offset = "0x16215E8", VA = "0x16215E8")]
		private void UpdateButtons()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1621CCC", Offset = "0x1621CCC", VA = "0x1621CCC")]
		private void Update()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1621D8C", Offset = "0x1621D8C", VA = "0x1621D8C")]
		public CamelPuzzle()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class CheckRotation : MonoBehaviour
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanternSlide slideObj;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lerpValue;

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1623D68", Offset = "0x1623D68", VA = "0x1623D68")]
		public void Check(float rotationZ)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1623E20", Offset = "0x1623E20", VA = "0x1623E20")]
		public void LaunchSlide(LanternSlide obj, float lerpValue)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1623E3C", Offset = "0x1623E3C", VA = "0x1623E3C")]
		public CheckRotation()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class DualRotatingWalls : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F8AC", Offset = "0x71F8AC")]
		private sealed class <RotateWithDelay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DualRotatingWalls <>4__this;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float lerpValue;

			[Token(Token = "0x17000063")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000434")]
				[Address(RVA = "0xF02AF4", Offset = "0xF02AF4", VA = "0xF02AF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000064")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000436")]
				[Address(RVA = "0xF02B3C", Offset = "0xF02B3C", VA = "0xF02B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0xF0299C", Offset = "0xF0299C", VA = "0xF0299C")]
			[DebuggerHidden]
			public <RotateWithDelay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0xF029C8", Offset = "0xF029C8", VA = "0xF029C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000433")]
			[Address(RVA = "0xF029CC", Offset = "0xF029CC", VA = "0xF029CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xF02AFC", Offset = "0xF02AFC", VA = "0xF02AFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlatformRotating left;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlatformRotating right;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Coroutine _cor;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioSource delayAudioSource;

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1626EB4", Offset = "0x1626EB4", VA = "0x1626EB4")]
		public void SetDisposition(float lerpValue)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1626F14", Offset = "0x1626F14", VA = "0x1626F14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722544", Offset = "0x722544")]
		private IEnumerator RotateWithDelay(float lerpValue)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1626F90", Offset = "0x1626F90", VA = "0x1626F90")]
		public DualRotatingWalls()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class FollowObject : MonoBehaviour
	{
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1629850", Offset = "0x1629850", VA = "0x1629850")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x16298F4", Offset = "0x16298F4", VA = "0x16298F4")]
		public FollowObject()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class LanternSlide : RestorableObject
	{
		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F8BC", Offset = "0x71F8BC")]
		private sealed class <SlideCoroutine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanternSlide <>4__this;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float targetLerp;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <lerpValue>5__2;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private bool <animationRunning>5__3;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			private bool <leftRight>5__4;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0xF03158", Offset = "0xF03158", VA = "0xF03158", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0xF031A0", Offset = "0xF031A0", VA = "0xF031A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xF02F50", Offset = "0xF02F50", VA = "0xF02F50")]
			[DebuggerHidden]
			public <SlideCoroutine>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xF02F7C", Offset = "0xF02F7C", VA = "0xF02F7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xF02F80", Offset = "0xF02F80", VA = "0xF02F80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xF03160", Offset = "0xF03160", VA = "0xF03160", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent OnSlideStarted;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnSlideRunning;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnSlideFinished;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x721168", Offset = "0x721168")]
		public float speed;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float rangeTransform;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Coroutine _cor;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xB1C6CC", Offset = "0xB1C6CC", VA = "0xB1C6CC")]
		private void Start()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB1C6E4", Offset = "0xB1C6E4", VA = "0xB1C6E4")]
		public void Slide(float targetLerp)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB1C740", Offset = "0xB1C740", VA = "0xB1C740")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7225F4", Offset = "0x7225F4")]
		private IEnumerator SlideCoroutine(float targetLerp)
		{
			return null;
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB1C7BC", Offset = "0xB1C7BC", VA = "0xB1C7BC", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xB1CAF4", Offset = "0xB1CAF4", VA = "0xB1CAF4")]
		public LanternSlide()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class LiftingObject : RestorableObject
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float range;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public LayerMask layerMask;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float maxHeight;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool minHeightIsSetup;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float minHeight;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 targetPosition;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float velocity;

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xB1D6B4", Offset = "0xB1D6B4", VA = "0xB1D6B4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xB1D6F0", Offset = "0xB1D6F0", VA = "0xB1D6F0", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xB1D9F8", Offset = "0xB1D9F8", VA = "0xB1D9F8", Slot = "7")]
		public override void Restore()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xB1DA08", Offset = "0xB1DA08", VA = "0xB1DA08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xB1DFA4", Offset = "0xB1DFA4", VA = "0xB1DFA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xB1E0A0", Offset = "0xB1E0A0", VA = "0xB1E0A0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xB1E258", Offset = "0xB1E258", VA = "0xB1E258")]
		public LiftingObject()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class MovingGoal : RunOnSpecificFrames
	{
		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 memoPosition;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xB1FCB0", Offset = "0xB1FCB0", VA = "0xB1FCB0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xB1FCEC", Offset = "0xB1FCEC", VA = "0xB1FCEC", Slot = "6")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xB1FD8C", Offset = "0xB1FD8C", VA = "0xB1FD8C")]
		public MovingGoal()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F8CC", Offset = "0x71F8CC")]
	public class PlayAnimation : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		public enum animChoice
		{
			[Token(Token = "0x40005BB")]
			Idle,
			[Token(Token = "0x40005BC")]
			Dance_1,
			[Token(Token = "0x40005BD")]
			Dance_2,
			[Token(Token = "0x40005BE")]
			EnterHouse,
			[Token(Token = "0x40005BF")]
			ExitHouse,
			[Token(Token = "0x40005C0")]
			IdleThenWalk,
			[Token(Token = "0x40005C1")]
			Jump,
			[Token(Token = "0x40005C2")]
			Walk,
			[Token(Token = "0x40005C3")]
			PipeJump,
			[Token(Token = "0x40005C4")]
			WalkRightUp,
			[Token(Token = "0x40005C5")]
			PlatformJumps,
			[Token(Token = "0x40005C6")]
			TraverseRight,
			[Token(Token = "0x40005C7")]
			UpStairs
		}

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public animChoice animationName;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xB21AA4", Offset = "0xB21AA4", VA = "0xB21AA4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xB21B44", Offset = "0xB21B44", VA = "0xB21B44")]
		public PlayAnimation()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class Rotate : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F92C", Offset = "0x71F92C")]
		private sealed class <_Rotation>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rotate <>4__this;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float angle;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <angleStart>5__2;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <angleEnd>5__3;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <rotation>5__4;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <time>5__5;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <t>5__6;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <ratio>5__7;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000456")]
				[Address(RVA = "0xF04344", Offset = "0xF04344", VA = "0xF04344", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000458")]
				[Address(RVA = "0xF0438C", Offset = "0xF0438C", VA = "0xF0438C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0xF04144", Offset = "0xF04144", VA = "0xF04144")]
			[DebuggerHidden]
			public <_Rotation>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0xF04170", Offset = "0xF04170", VA = "0xF04170", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000455")]
			[Address(RVA = "0xF04174", Offset = "0xF04174", VA = "0xF04174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000457")]
			[Address(RVA = "0xF0434C", Offset = "0xF0434C", VA = "0xF0434C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float speed;

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xB29718", Offset = "0xB29718", VA = "0xB29718")]
		public void Rotation(float angle)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xB29760", Offset = "0xB29760", VA = "0xB29760")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7226A4", Offset = "0x7226A4")]
		private IEnumerator _Rotation(float angle)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB297DC", Offset = "0xB297DC", VA = "0xB297DC")]
		public Rotate()
		{
		}
	}
}
namespace Silhouette.Utils
{
	[Token(Token = "0x20000EB")]
	public static class LayerMaskUtils
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0xB1CB20", Offset = "0xB1CB20", VA = "0xB1CB20")]
		public static bool Contains(this LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xB1CB58", Offset = "0xB1CB58", VA = "0xB1CB58")]
		public static void ShowLayer(Camera cam, int layer)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xB1CB9C", Offset = "0xB1CB9C", VA = "0xB1CB9C")]
		public static void HideLayer(Camera cam, int layer)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xB1CBE0", Offset = "0xB1CBE0", VA = "0xB1CBE0")]
		public static void ToggleLayer(Camera cam, int layer)
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class MathUtils
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0xB1F2CC", Offset = "0xB1F2CC", VA = "0xB1F2CC")]
		public static float SignedAngle(Vector3 first, Vector3 second, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xB1F384", Offset = "0xB1F384", VA = "0xB1F384")]
		public static float SignedAngle2D(Vector2 first, Vector2 second)
		{
			return default(float);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xB1F3D0", Offset = "0xB1F3D0", VA = "0xB1F3D0")]
		public static bool PointInTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 P, bool inclusive = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xB1F4E4", Offset = "0xB1F4E4", VA = "0xB1F4E4")]
		public static Vector3 ComputeBezierCurvePoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xB1F578", Offset = "0xB1F578", VA = "0xB1F578")]
		public MathUtils()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public class PriorityQueue<T>
	{
		[Token(Token = "0x20000EE")]
		private class Node
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721184", Offset = "0x721184")]
			private float <Priority>k__BackingField;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x721194", Offset = "0x721194")]
			private T <Object>k__BackingField;

			[Token(Token = "0x1700006A")]
			public float Priority
			{
				[Token(Token = "0x600046F")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722764", Offset = "0x722764")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000470")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722774", Offset = "0x722774")]
				set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public T Object
			{
				[Token(Token = "0x6000471")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722784", Offset = "0x722784")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x6000472")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722794", Offset = "0x722794")]
				set
				{
				}
			}

			[Token(Token = "0x6000473")]
			public Node()
			{
			}
		}

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<Node> queue;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int heapSize;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isMinPriorityQueue;

		[Token(Token = "0x17000069")]
		public int Count
		{
			[Token(Token = "0x6000462")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000463")]
		public PriorityQueue(bool isMinPriorityQueue = false)
		{
		}

		[Token(Token = "0x6000464")]
		public void Enqueue(float priority, T obj)
		{
		}

		[Token(Token = "0x6000465")]
		public T Dequeue()
		{
			return (T)null;
		}

		[Token(Token = "0x6000466")]
		public void UpdatePriority(T obj, float priority)
		{
		}

		[Token(Token = "0x6000467")]
		public bool IsInQueue(T obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		private void BuildHeapMax(int i)
		{
		}

		[Token(Token = "0x6000469")]
		private void BuildHeapMin(int i)
		{
		}

		[Token(Token = "0x600046A")]
		private void MaxHeapify(int i)
		{
		}

		[Token(Token = "0x600046B")]
		private void MinHeapify(int i)
		{
		}

		[Token(Token = "0x600046C")]
		private void Swap(int i, int j)
		{
		}

		[Token(Token = "0x600046D")]
		private int ChildL(int i)
		{
			return default(int);
		}

		[Token(Token = "0x600046E")]
		private int ChildR(int i)
		{
			return default(int);
		}
	}
}
namespace Silhouette.ShadowPeople
{
	[Token(Token = "0x20000EF")]
	public class Gate : MonoBehaviour
	{
		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 position2D;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Item key;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float distanceMaxWaypoint;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Goal goal;

		[Token(Token = "0x1700006C")]
		public WayPoint wayPoint
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x162A88C", Offset = "0x162A88C", VA = "0x162A88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x162A8E4", Offset = "0x162A8E4", VA = "0x162A8E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x162A968", Offset = "0x162A968", VA = "0x162A968")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x162AA18", Offset = "0x162AA18", VA = "0x162AA18")]
		public void UnLock(Item item)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x162AB20", Offset = "0x162AB20", VA = "0x162AB20")]
		public Gate()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class Item : MonoBehaviour
	{
		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float distanceMaxWaypoint;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 position2D;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector2 originalPosition2D;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 originalLocalRotation;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform originalParent;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool used;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float aura;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useLocalPosition;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 localOriginalPos;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool initialized;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public ShadowPersonAgent agent;

		[Token(Token = "0x1700006D")]
		public WayPoint wayPoint
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0xB1BED8", Offset = "0xB1BED8", VA = "0xB1BED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xB1BF30", Offset = "0xB1BF30", VA = "0xB1BF30")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xB1BFE8", Offset = "0xB1BFE8", VA = "0xB1BFE8")]
		public void Restore()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xB1C110", Offset = "0xB1C110", VA = "0xB1C110")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xB1C1D4", Offset = "0xB1C1D4", VA = "0xB1C1D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xB1C270", Offset = "0xB1C270", VA = "0xB1C270")]
		public Item()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class ShadowNavmesh : RunOnSpecificFrames
	{
		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<ShadowPersonAgent> agents;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ShadowMesh activeShadowMesh;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector2 shadowPersonBox;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float jumpHeight;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float jumpWidth;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float fallHeight;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float fallWidth;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool showNonWalkable;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool showJumpAndFall;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool keepEditorRotation;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		private bool goalOrientedUp;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool spawnOrientedUp;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float MaxDistance;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private WayPoint[,] ways;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int waysListDimension;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int waysDimension;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int waysListIndex;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int[] waysIndexes;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public WayPoint[] navMap;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public int navMapIndex;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int navMapDimension;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Vector2[] spawnPoints;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject[] spawnPointsGO;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Vector2 goalPoint;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject goalPointGO;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public WayPoint finalGoal;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public WayPoint wayPointFinalGoal;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float distanceBetweenAgent;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Vector3 offset;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool active;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Vector2 destination;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float selectionRange;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Item[] items;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Item itemSelected;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Goal goalLock;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public SpawnPoint nextSpawn;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool waitForInitialization;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool noDestination;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x102")]
		private bool initialized;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public PuzzleManager manager;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[HideInInspector]
		public bool setDestinationAsBeenDone;

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xBA688C", Offset = "0xBA688C", VA = "0xBA688C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xBA6B6C", Offset = "0xBA6B6C", VA = "0xBA6B6C")]
		public void Initialize(ShadowMesh mesh)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xBA6DD0", Offset = "0xBA6DD0", VA = "0xBA6DD0")]
		public void InitSpawnPoints()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xBA7018", Offset = "0xBA7018", VA = "0xBA7018")]
		public void InitGoal()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xBA72D0", Offset = "0xBA72D0", VA = "0xBA72D0")]
		public void Restore()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xBA779C", Offset = "0xBA779C", VA = "0xBA779C")]
		public void Activate()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xBA77A8", Offset = "0xBA77A8", VA = "0xBA77A8")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xBA79EC", Offset = "0xBA79EC", VA = "0xBA79EC")]
		public void AddAgent(ShadowPersonAgent agent)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xBA7A5C", Offset = "0xBA7A5C", VA = "0xBA7A5C")]
		public void removeAgent(ShadowPersonAgent agent)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xBA7AC0", Offset = "0xBA7AC0", VA = "0xBA7AC0")]
		public void CheckAgents()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xBA8110", Offset = "0xBA8110", VA = "0xBA8110")]
		private bool NeedToIdle(ShadowPersonAgent agent1, ShadowPersonAgent agent2, out bool hasReachedLimit)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xBA82E0", Offset = "0xBA82E0", VA = "0xBA82E0")]
		public WayPoint GetDestination(Vector2 position, out GameObject itemDestination)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xBA875C", Offset = "0xBA875C", VA = "0xBA875C")]
		public void SetDestination(Vector2 position, out GameObject itemDestination)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xBA8874", Offset = "0xBA8874", VA = "0xBA8874")]
		public WayPoint GetDestination(Vector3 position, out GameObject itemDestination)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xBA88A0", Offset = "0xBA88A0", VA = "0xBA88A0")]
		public void SetDestination(Vector3 position, out GameObject itemDestination)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xBA808C", Offset = "0xBA808C", VA = "0xBA808C")]
		public void RemoveDestination()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xBA88D0", Offset = "0xBA88D0", VA = "0xBA88D0")]
		public Item GiveItem(Vector3 grabPosition)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xBA8A38", Offset = "0xBA8A38", VA = "0xBA8A38")]
		public void ActiveGate(WayPoint wp, Item item)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xBA8B18", Offset = "0xBA8B18", VA = "0xBA8B18", Slot = "6")]
		public override void IntervalUpdate()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xBA9458", Offset = "0xBA9458", VA = "0xBA9458", Slot = "7")]
		public override void NonIntervalUpdate()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xBA9500", Offset = "0xBA9500", VA = "0xBA9500")]
		private new void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xBA865C", Offset = "0xBA865C", VA = "0xBA865C")]
		public WayPoint FindTheNearestPoint(Vector2 point)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xBA954C", Offset = "0xBA954C", VA = "0xBA954C")]
		private WayPoint FindTheNearestPointBelow(Vector2 point, bool left)
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xBA719C", Offset = "0xBA719C", VA = "0xBA719C")]
		public Vector3 From2DTo3D(Vector2 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xBA7140", Offset = "0xBA7140", VA = "0xBA7140")]
		public Vector2 From3DTo2D(Vector3 point)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xBA8BD4", Offset = "0xBA8BD4", VA = "0xBA8BD4")]
		private void Compute()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xBA9D7C", Offset = "0xBA9D7C", VA = "0xBA9D7C")]
		private bool CheckBox(Edge2D edge)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xBA969C", Offset = "0xBA969C", VA = "0xBA969C")]
		public void ComputeJumpsAndFalls()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xBAA368", Offset = "0xBAA368", VA = "0xBAA368")]
		public bool IsPointInShadow(Vector2 point)
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xBAA384", Offset = "0xBAA384", VA = "0xBAA384")]
		public ShadowNavmesh()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ShadowPeopleAnimatorBehavior : StateMachineBehaviour
	{
		[Token(Token = "0x600049D")]
		[Address(RVA = "0xBAA444", Offset = "0xBAA444", VA = "0xBAA444", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xBAA528", Offset = "0xBAA528", VA = "0xBAA528")]
		public ShadowPeopleAnimatorBehavior()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x71F94C", Offset = "0x71F94C")]
	public class ShadowPersonAgent : MonoBehaviour
	{
		[Token(Token = "0x20000F4")]
		public enum state
		{
			[Token(Token = "0x400064C")]
			walking,
			[Token(Token = "0x400064D")]
			jumping,
			[Token(Token = "0x400064E")]
			falling,
			[Token(Token = "0x400064F")]
			landing,
			[Token(Token = "0x4000650")]
			idling,
			[Token(Token = "0x4000651")]
			atGoal,
			[Token(Token = "0x4000652")]
			stopped,
			[Token(Token = "0x4000653")]
			waiting,
			[Token(Token = "0x4000654")]
			softLanding,
			[Token(Token = "0x4000655")]
			dying,
			[Token(Token = "0x4000656")]
			dyingOutsideNavmesh,
			[Token(Token = "0x4000657")]
			carried
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F9AC", Offset = "0x71F9AC")]
		private sealed class <_ChangeScale>d__67 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShadowPersonAgent <>4__this;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float scale;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Vector3 <scaleBegin>5__2;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <scaleEnd>5__3;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <t>5__4;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <time>5__5;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float <ratio>5__6;

			[Token(Token = "0x17000071")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C3")]
				[Address(RVA = "0xF057A8", Offset = "0xF057A8", VA = "0xF057A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000072")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004C5")]
				[Address(RVA = "0xF057F0", Offset = "0xF057F0", VA = "0xF057F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xF055D8", Offset = "0xF055D8", VA = "0xF055D8")]
			[DebuggerHidden]
			public <_ChangeScale>d__67(int <>1__state)
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xF05604", Offset = "0xF05604", VA = "0xF05604", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C2")]
			[Address(RVA = "0xF05608", Offset = "0xF05608", VA = "0xF05608", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C4")]
			[Address(RVA = "0xF057B0", Offset = "0xF057B0", VA = "0xF057B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71F9BC", Offset = "0x71F9BC")]
		private sealed class <_Die>d__88 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShadowPersonAgent <>4__this;

			[Token(Token = "0x17000073")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C9")]
				[Address(RVA = "0xF05A1C", Offset = "0xF05A1C", VA = "0xF05A1C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004CB")]
				[Address(RVA = "0xF05A64", Offset = "0xF05A64", VA = "0xF05A64", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xF057F8", Offset = "0xF057F8", VA = "0xF057F8")]
			[DebuggerHidden]
			public <_Die>d__88(int <>1__state)
			{
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xF05824", Offset = "0xF05824", VA = "0xF05824", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xF05828", Offset = "0xF05828", VA = "0xF05828", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xF05A24", Offset = "0xF05A24", VA = "0xF05A24", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool debugOn;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int agentID;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _active;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool pathFound;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public state status;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool hasBeenStopped;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int _direction;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool hasLeftFloor;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distanceFromDestination;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool atDestination;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float speed;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxVelocity;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float rangeSnapping;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _speed;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<WayPoint> path;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private WayPoint startWP;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Animator animator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Rigidbody rb;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3[] positionToCheckShadowOffset;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector2[] positionToCheckShadow2D;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int numberOFPointInShadowToDie;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[HideInInspector]
		public Vector2 position2D;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float timeInDark;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float timeInDarkBeforeDying;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public SpawnPoint originSpawn;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float distanceMinForJump;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float distanceForFall;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector2 destination;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Item item;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GameObject shadowPersonPrefab;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3 offSet;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Transform grabPoint;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool isGrounded;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool collisionDetected;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE2")]
		private bool navmeshCollision;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float memoY;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float deltaYToFall;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector3 startScale;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool scaleChanging;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float scaleSpeed;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool leaving;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool isDying;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioSource exitAudioSource;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioSource dieAudioSource;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioSource grabItemAudioSource;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public DM_RandomAudioPlayer jumpRandomAudioPlayer;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public DM_RandomAudioPlayer fallRandomAudioPlayer;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public DM_RandomAudioPlayer whenSetDestinationIsValidRandomAudioPlayer;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public DM_RandomAudioPlayer whenSetDestinationIsNotValidRandomAudioPlayer;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3? memoLightPosition;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private GameObject sp;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private SpawnParticleEffect spawnParticleEffect;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private WayPoint nearestWP;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool onHand;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float memoX;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public ParticleSystem victoryHearts;

		[Token(Token = "0x1700006E")]
		public bool active
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xBAA530", Offset = "0xBAA530", VA = "0xBAA530")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xBAA538", Offset = "0xBAA538", VA = "0xBAA538")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int direction
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xBAA570", Offset = "0xBAA570", VA = "0xBAA570")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xBAA578", Offset = "0xBAA578", VA = "0xBAA578")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		private bool lightIsMoving
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xBAA5C4", Offset = "0xBAA5C4", VA = "0xBAA5C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xBAA72C", Offset = "0xBAA72C", VA = "0xBAA72C")]
		public void ChangeScale(float scale)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xBAA758", Offset = "0xBAA758", VA = "0xBAA758")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7227A4", Offset = "0x7227A4")]
		public IEnumerator _ChangeScale(float scale)
		{
			return null;
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xBAA7D4", Offset = "0xBAA7D4", VA = "0xBAA7D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xBAA870", Offset = "0xBAA870", VA = "0xBAA870")]
		private void Start()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xBAAA0C", Offset = "0xBAAA0C", VA = "0xBAAA0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xBAAAB4", Offset = "0xBAAAB4", VA = "0xBAAAB4")]
		public void AnimatorUpdate()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xBAAC44", Offset = "0xBAAC44", VA = "0xBAAC44")]
		private void FallingUpdate()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xBAACE0", Offset = "0xBAACE0", VA = "0xBAACE0")]
		private void LandingUpdate()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xBAAD54", Offset = "0xBAAD54", VA = "0xBAAD54")]
		private void SoftLandingUpdate()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xBAADCC", Offset = "0xBAADCC", VA = "0xBAADCC")]
		private void JumpingUpdate()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xBAADEC", Offset = "0xBAADEC", VA = "0xBAADEC")]
		private void Jump(Vector2 begin, Vector2 end)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xBAB4B0", Offset = "0xBAB4B0", VA = "0xBAB4B0")]
		private void WalkingUpdate()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xBAC21C", Offset = "0xBAC21C", VA = "0xBAC21C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xBAC228", Offset = "0xBAC228", VA = "0xBAC228")]
		public void Resume()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xBAC240", Offset = "0xBAC240", VA = "0xBAC240")]
		public void StoppedUpdate()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xBAC248", Offset = "0xBAC248", VA = "0xBAC248")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xBACAD0", Offset = "0xBACAD0", VA = "0xBACAD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xBACAD8", Offset = "0xBACAD8", VA = "0xBACAD8")]
		public void ComputePath(WayPoint wpDestination)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xBAB8AC", Offset = "0xBAB8AC", VA = "0xBAB8AC")]
		private WayPoint FindWayPointFromAStar(WayPoint wpDestination)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xBAC92C", Offset = "0xBAC92C", VA = "0xBAC92C")]
		public void ArriveAtGoal()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xBAD2B8", Offset = "0xBAD2B8", VA = "0xBAD2B8")]
		public void Kill(bool outside = false)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xBAC8F4", Offset = "0xBAC8F4", VA = "0xBAC8F4")]
		private void Die()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xBAD2DC", Offset = "0xBAD2DC", VA = "0xBAD2DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722804", Offset = "0x722804")]
		private IEnumerator _Die()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xBA81EC", Offset = "0xBA81EC", VA = "0xBA81EC")]
		public void AddItem(Item item)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xBAD348", Offset = "0xBAD348", VA = "0xBAD348")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xBAD45C", Offset = "0xBAD45C", VA = "0xBAD45C")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xBAC804", Offset = "0xBAC804", VA = "0xBAC804")]
		protected bool IsInShadow()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xBAD564", Offset = "0xBAD564", VA = "0xBAD564")]
		public ShadowPersonAgent()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class SpawnPoint : MonoBehaviour
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Queue<int> pool;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 position2D;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject blockGO;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool isBlocked;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float delay;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float timer;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float personSnappingRange;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int number;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject[] prefabs;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ShadowPersonAgent> agents;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ShadowNavmesh navmesh;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AudioSource audioSource;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x721214", Offset = "0x721214")]
		public float DistanceMinForSpwan;

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xBA6B04", Offset = "0xBA6B04", VA = "0xBA6B04")]
		public void Initialize(ShadowNavmesh navmesh)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xBA7468", Offset = "0xBA7468", VA = "0xBA7468")]
		public void Restore()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xBA789C", Offset = "0xBA789C", VA = "0xBA789C")]
		public void Deactivate()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xBAD19C", Offset = "0xBAD19C", VA = "0xBAD19C")]
		public void RemoveAgent(int id)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xBAD204", Offset = "0xBAD204", VA = "0xBAD204")]
		public void AddAgent(ShadowPersonAgent agent)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xBB2B0C", Offset = "0xBB2B0C", VA = "0xBB2B0C")]
		private bool AgentInZone()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xBB2CA4", Offset = "0xBB2CA4", VA = "0xBB2CA4")]
		private void Spawn()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xBB304C", Offset = "0xBB304C", VA = "0xBB304C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xBB30F4", Offset = "0xBB30F4", VA = "0xBB30F4")]
		public void KillAgent(int id)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xBA7248", Offset = "0xBA7248", VA = "0xBA7248")]
		public void SetBlockingState(bool IsBlocked)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xBB3224", Offset = "0xBB3224", VA = "0xBB3224")]
		public SpawnPoint()
		{
		}
	}
}
namespace Silhouette.HandTracking
{
	[Token(Token = "0x20000F8")]
	public class CustomPointerPose : MonoBehaviour
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x72124C", Offset = "0x72124C")]
		[SerializeField]
		private MonoBehaviour _iHandMono;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7212BC", Offset = "0x7212BC")]
		private IHand <Hand>k__BackingField;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7212CC", Offset = "0x7212CC")]
		public float offset;

		[Token(Token = "0x17000075")]
		public IHand Hand
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x1624CE4", Offset = "0x1624CE4", VA = "0x1624CE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722904", Offset = "0x722904")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x1624CEC", Offset = "0x1624CEC", VA = "0x1624CEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x722914", Offset = "0x722914")]
			private set
			{
			}
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1624CF4", Offset = "0x1624CF4", VA = "0x1624CF4")]
		protected void Awake()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1624D48", Offset = "0x1624D48", VA = "0x1624D48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1624E48", Offset = "0x1624E48", VA = "0x1624E48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1624F48", Offset = "0x1624F48", VA = "0x1624F48")]
		private void HandleHandUpdated()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x16250A8", Offset = "0x16250A8", VA = "0x16250A8")]
		public CustomPointerPose()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x71F9CC", Offset = "0x71F9CC")]
	public class HandAction : ScriptableObject
	{
		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string actionName;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<HandGesture> gestures;

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x162AFB4", Offset = "0x162AFB4", VA = "0x162AFB4")]
		public HandAction()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public class HandActionProcessor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000FB")]
		public struct HandActionReactions
		{
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public HandAction action;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HandAction previousAction;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UnityEvent reaction;
		}

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<HandActionReactions> reactions;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<HandActionReactions> endReactions;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HandAction lastAction;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float lastActionEndedTimestamp;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool printDebugMessages;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x162B008", Offset = "0x162B008", VA = "0x162B008")]
		public void ProcessGesture(HandGesture gesture)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x162B460", Offset = "0x162B460", VA = "0x162B460")]
		public void ProcessGestureEnd(HandGesture gesture)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x162B7AC", Offset = "0x162B7AC", VA = "0x162B7AC")]
		public HandActionProcessor()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class HandBonesHandler : MonoBehaviour
	{
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71FA20", Offset = "0x71FA20")]
		private sealed class <GrabSkeleton>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandBonesHandler <>4__this;

			[Token(Token = "0x17000076")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E8")]
				[Address(RVA = "0xF02D9C", Offset = "0xF02D9C", VA = "0xF02D9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000077")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004EA")]
				[Address(RVA = "0xF02DE4", Offset = "0xF02DE4", VA = "0xF02DE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xF02CA0", Offset = "0xF02CA0", VA = "0xF02CA0")]
			[DebuggerHidden]
			public <GrabSkeleton>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xF02CCC", Offset = "0xF02CCC", VA = "0xF02CCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xF02CD0", Offset = "0xF02CD0", VA = "0xF02CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xF02DA4", Offset = "0xF02DA4", VA = "0xF02DA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Hands hand;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected OVRSkeleton skeleton;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<OVRBone> fingerBones;

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x162CAD8", Offset = "0x162CAD8", VA = "0x162CAD8")]
		protected void Start()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x162CB60", Offset = "0x162CB60", VA = "0x162CB60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x722924", Offset = "0x722924")]
		public IEnumerator GrabSkeleton()
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x162CBCC", Offset = "0x162CBCC", VA = "0x162CBCC")]
		public HandBonesHandler()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public enum Hands
	{
		[Token(Token = "0x4000686")]
		Left,
		[Token(Token = "0x4000687")]
		Right
	}
	[Token(Token = "0x20000FF")]
	public enum HandPose
	{
		[Token(Token = "0x4000689")]
		None,
		[Token(Token = "0x400068A")]
		FistClosed,
		[Token(Token = "0x400068B")]
		IndexPointing,
		[Token(Token = "0x400068C")]
		ThumbsUp,
		[Token(Token = "0x400068D")]
		ThumbsUpAndIndexPointing,
		[Token(Token = "0x400068E")]
		FingerGun,
		[Token(Token = "0x400068F")]
		IndexAndMiddlePointing,
		[Token(Token = "0x4000690")]
		OpenFingers,
		[Token(Token = "0x4000691")]
		ClosedFingers,
		[Token(Token = "0x4000692")]
		Menu
	}
	[Token(Token = "0x2000100")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x71FA30", Offset = "0x71FA30")]
	public class HandGesture : ScriptableObject
	{
		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string gestureName;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hands hand;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3> fingerData;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x162D0D8", Offset = "0x162D0D8", VA = "0x162D0D8")]
		public HandGesture()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000101")]
	public class HandGestureUnityEvent : UnityEvent<HandGesture>
	{
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x162D7D8", Offset = "0x162D7D8", VA = "0x162D7D8")]
		public HandGestureUnityEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000102")]
	public class HandGestureTransitionUnityEvent : UnityEvent<HandGesture, HandGesture, Hands>
	{
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x162D78C", Offset = "0x162D78C", VA = "0x162D78C")]
		public HandGestureTransitionUnityEvent()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class HandGestureDetector : HandBonesHandler
	{
		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7212EC", Offset = "0x7212EC")]
		public float detectionThreshold;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x721324", Offset = "0x721324")]
		public float detectionDelay;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float detectionTimer;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x72135C", Offset = "0x72135C")]
		public List<HandGesture> gestures;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public HandGestureUnityEvent onGestureDetected;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public HandGestureUnityEvent onGestureEnded;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HandGestureTransitionUnityEvent onGestureTransition;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public HandGesture previousGesture;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool printDebugMessages;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x162D134", Offset = "0x162D134", VA = "0x162D134")]
		private new void Start()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x162D158", Offset = "0x162D158", VA = "0x162D158")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x162D490", Offset = "0x162D490", VA = "0x162D490")]
		private HandGesture RecognizeGesture()
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x162D778", Offset = "0x162D778", VA = "0x162D778")]
		public HandGestureDetector()
		{
		}
	}
	[Token(Token = "0x2000104")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x71FA84", Offset = "0x71FA84")]
	public class HandPoseDefinition : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class GesturePosePair
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public HandGesture gesture;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HandPose pose;

			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xF02DEC", Offset = "0xF02DEC", VA = "0xF02DEC")]
			public GesturePosePair()
			{
			}
		}

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GesturePosePair> gesturePosePairs;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x162D824", Offset = "0x162D824", VA = "0x162D824")]
		public Dictionary<HandGesture, HandPose> ToDict()
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x162DB30", Offset = "0x162DB30", VA = "0x162DB30")]
		public HandPoseDefinition()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class HandStateManager : MonoBehaviour
	{
		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform leftHandTransform;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform rightHandTransform;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ShadowGun shadowGun;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x721394", Offset = "0x721394")]
		public PlayerLocomotionTeleport teleport;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CameraCapture photoCapture;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x7213CC", Offset = "0x7213CC")]
		public float timeoutBetweenDetections;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] timesOfLastChange;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVRHand[] handsDatas;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public InGameMenu inGameMenu;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public NoPoseActiveState[] poseStates;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject[] leftHandObjects;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject[] rightHandObjects;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool[] lastUpdateConfidence;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float lastTimeConfidenceTracked;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent OnLeftHandConfidenceChanged;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent OnRightHandConfidenceChanged;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x721404", Offset = "0x721404")]
		public bool showDebugMessages;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private HandPose[] currentPoses;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private HandPose[] previousPoses;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public HandPose[] actualPoses;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x162DB38", Offset = "0x162DB38", VA = "0x162DB38")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x162DC3C", Offset = "0x162DC3C", VA = "0x162DC3C")]
		public void HandleNewPose(HandPose newPose, Hands hand)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x162DCC0", Offset = "0x162DCC0", VA = "0x162DCC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x162E438", Offset = "0x162E438", VA = "0x162E438")]
		public void UpdateState(Hands hand)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x162E8EC", Offset = "0x162E8EC", VA = "0x162E8EC")]
		public HandStateManager()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class SelectorHandPoseUnityEventWrapper : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000108")]
		public class HandPoseUnityEvent : UnityEvent<HandPose, Hands>
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0xF0475C", Offset = "0xF0475C", VA = "0xF0475C")]
			public HandPoseUnityEvent()
			{
			}
		}

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandPose pose;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Hands hand;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "InterfaceAttribute", RVA = "0x72145C", Offset = "0x72145C")]
		private MonoBehaviour _iSelectorMono;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ISelector _selector;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HandPoseUnityEvent _onSelect;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private HandPoseUnityEvent _onRelease;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xB2B50C", Offset = "0xB2B50C", VA = "0xB2B50C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xB2B560", Offset = "0xB2B560", VA = "0xB2B560")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xB2B704", Offset = "0xB2B704", VA = "0xB2B704")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xB2B8AC", Offset = "0xB2B8AC", VA = "0xB2B8AC")]
		private void HandleSelect()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xB2B904", Offset = "0xB2B904", VA = "0xB2B904")]
		private void HandleRelease()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xB2B960", Offset = "0xB2B960", VA = "0xB2B960")]
		public SelectorHandPoseUnityEventWrapper()
		{
		}
	}
}
