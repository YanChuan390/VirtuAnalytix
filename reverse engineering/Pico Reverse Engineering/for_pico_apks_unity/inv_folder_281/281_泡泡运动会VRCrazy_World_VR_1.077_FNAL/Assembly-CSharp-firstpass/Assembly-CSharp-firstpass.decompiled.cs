using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Dissonance;
using Dissonance.Audio;
using Dissonance.Audio.Capture;
using Dissonance.Audio.Codecs;
using Dissonance.Audio.Codecs.Opus;
using Dissonance.Audio.Playback;
using Dissonance.Config;
using Dissonance.Datastructures;
using Dissonance.Networking;
using Dissonance.Networking.Client;
using Dissonance.Networking.Server;
using Dissonance.Threading;
using Dissonance.VAD;
using HandyCollections.Heap;
using Il2CppDummyDll;
using NAudio.Dsp;
using NAudio.Wave;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class NativeGallery
{
	[Token(Token = "0x2000003")]
	public struct ImageProperties
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int width;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly int height;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string mimeType;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ImageOrientation orientation;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x9985E0", Offset = "0x9985E0", VA = "0x9985E0")]
		public ImageProperties(int width, int height, string mimeType, ImageOrientation orientation)
		{
		}
	}

	[Token(Token = "0x2000004")]
	public struct VideoProperties
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int width;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly int height;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly long duration;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float rotation;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x9988C8", Offset = "0x9988C8", VA = "0x9988C8")]
		public VideoProperties(int width, int height, long duration, float rotation)
		{
		}
	}

	[Token(Token = "0x2000005")]
	public enum Permission
	{
		[Token(Token = "0x4000010")]
		Denied,
		[Token(Token = "0x4000011")]
		Granted,
		[Token(Token = "0x4000012")]
		ShouldAsk
	}

	[Token(Token = "0x2000006")]
	private enum MediaType
	{
		[Token(Token = "0x4000014")]
		Image,
		[Token(Token = "0x4000015")]
		Video,
		[Token(Token = "0x4000016")]
		Audio
	}

	[Token(Token = "0x2000007")]
	public enum ImageOrientation
	{
		[Token(Token = "0x4000018")]
		Unknown = -1,
		[Token(Token = "0x4000019")]
		Normal,
		[Token(Token = "0x400001A")]
		Rotate90,
		[Token(Token = "0x400001B")]
		Rotate180,
		[Token(Token = "0x400001C")]
		Rotate270,
		[Token(Token = "0x400001D")]
		FlipHorizontal,
		[Token(Token = "0x400001E")]
		Transpose,
		[Token(Token = "0x400001F")]
		FlipVertical,
		[Token(Token = "0x4000020")]
		Transverse
	}

	[Token(Token = "0x2000008")]
	public delegate void MediaSaveCallback(string error);

	[Token(Token = "0x2000009")]
	public delegate void MediaPickCallback(string path);

	[Token(Token = "0x200000A")]
	public delegate void MediaPickMultipleCallback(string[] paths);

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AndroidJavaClass m_ajc;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AndroidJavaObject m_context;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string m_temporaryImagePath;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static string m_selectedImagePath;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string m_selectedVideoPath;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string m_selectedAudioPath;

	[Token(Token = "0x17000001")]
	private static AndroidJavaClass AJC
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x995A3C", Offset = "0x995A3C", VA = "0x995A3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	private static AndroidJavaObject Context
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x995AE8", Offset = "0x995AE8", VA = "0x995AE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	private static string TemporaryImagePath
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x995CEC", Offset = "0x995CEC", VA = "0x995CEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	private static string SelectedImagePath
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x995DB4", Offset = "0x995DB4", VA = "0x995DB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	private static string SelectedVideoPath
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x995E7C", Offset = "0x995E7C", VA = "0x995E7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	private static string SelectedAudioPath
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x995F44", Offset = "0x995F44", VA = "0x995F44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x99600C", Offset = "0x99600C", VA = "0x99600C")]
	public static Permission CheckPermission(bool readPermissionOnly = false)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x99617C", Offset = "0x99617C", VA = "0x99617C")]
	public static Permission RequestPermission(bool readPermissionOnly = false)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9965A0", Offset = "0x9965A0", VA = "0x9965A0")]
	public static bool CanOpenSettings()
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9965A8", Offset = "0x9965A8", VA = "0x9965A8")]
	public static void OpenSettings()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x99666C", Offset = "0x99666C", VA = "0x99666C")]
	public static Permission SaveImageToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x996858", Offset = "0x996858", VA = "0x996858")]
	public static Permission SaveImageToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x996ADC", Offset = "0x996ADC", VA = "0x996ADC")]
	public static Permission SaveImageToGallery(Texture2D image, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x996D60", Offset = "0x996D60", VA = "0x996D60")]
	public static Permission SaveVideoToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x996D6C", Offset = "0x996D6C", VA = "0x996D6C")]
	public static Permission SaveVideoToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x996D78", Offset = "0x996D78", VA = "0x996D78")]
	private static Permission SaveAudioToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x996D84", Offset = "0x996D84", VA = "0x996D84")]
	private static Permission SaveAudioToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x996D90", Offset = "0x996D90", VA = "0x996D90")]
	public static bool CanSelectMultipleFilesFromGallery()
	{
		return default(bool);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x996E5C", Offset = "0x996E5C", VA = "0x996E5C")]
	public static Permission GetImageFromGallery(MediaPickCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x997108", Offset = "0x997108", VA = "0x997108")]
	public static Permission GetVideoFromGallery(MediaPickCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x997114", Offset = "0x997114", VA = "0x997114")]
	private static Permission GetAudioFromGallery(MediaPickCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x997120", Offset = "0x997120", VA = "0x997120")]
	public static Permission GetImagesFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9973F4", Offset = "0x9973F4", VA = "0x9973F4")]
	public static Permission GetVideosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x997400", Offset = "0x997400", VA = "0x997400")]
	private static Permission GetAudiosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x99740C", Offset = "0x99740C", VA = "0x99740C")]
	public static bool IsMediaPickerBusy()
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x996678", Offset = "0x996678", VA = "0x996678")]
	private static Permission SaveToGallery(byte[] mediaBytes, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x996864", Offset = "0x996864", VA = "0x996864")]
	private static Permission SaveToGallery(string existingMediaPath, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9974B0", Offset = "0x9974B0", VA = "0x9974B0")]
	private static void SaveToGalleryInternal(string path, string album, MediaType mediaType, MediaSaveCallback callback)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x997414", Offset = "0x997414", VA = "0x997414")]
	private static string GetTemporarySavePath(string filename)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x996E68", Offset = "0x996E68", VA = "0x996E68")]
	private static Permission GetMediaFromGallery(MediaPickCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x99712C", Offset = "0x99712C", VA = "0x99712C")]
	private static Permission GetMultipleMediaFromGallery(MediaPickMultipleCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x996C80", Offset = "0x996C80", VA = "0x996C80")]
	private static byte[] GetTextureBytes(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x997758", Offset = "0x997758", VA = "0x997758")]
	private static byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x997C88", Offset = "0x997C88", VA = "0x997C88")]
	public static Texture2D LoadImageAtPath(string imagePath, int maxSize = -1, bool markTextureNonReadable = true, bool generateMipmaps = true, bool linearColorSpace = false)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x9981C8", Offset = "0x9981C8", VA = "0x9981C8")]
	public static ImageProperties GetImageProperties(string imagePath)
	{
		return default(ImageProperties);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x9985F0", Offset = "0x9985F0", VA = "0x9985F0")]
	public static VideoProperties GetVideoProperties(string videoPath)
	{
		return default(VideoProperties);
	}
}
[Token(Token = "0x200000B")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x200000D")]
	private delegate void ApplyTween();

	[Token(Token = "0x200000E")]
	public enum EaseType
	{
		[Token(Token = "0x4000047")]
		easeInQuad,
		[Token(Token = "0x4000048")]
		easeOutQuad,
		[Token(Token = "0x4000049")]
		easeInOutQuad,
		[Token(Token = "0x400004A")]
		easeInCubic,
		[Token(Token = "0x400004B")]
		easeOutCubic,
		[Token(Token = "0x400004C")]
		easeInOutCubic,
		[Token(Token = "0x400004D")]
		easeInQuart,
		[Token(Token = "0x400004E")]
		easeOutQuart,
		[Token(Token = "0x400004F")]
		easeInOutQuart,
		[Token(Token = "0x4000050")]
		easeInQuint,
		[Token(Token = "0x4000051")]
		easeOutQuint,
		[Token(Token = "0x4000052")]
		easeInOutQuint,
		[Token(Token = "0x4000053")]
		easeInSine,
		[Token(Token = "0x4000054")]
		easeOutSine,
		[Token(Token = "0x4000055")]
		easeInOutSine,
		[Token(Token = "0x4000056")]
		easeInExpo,
		[Token(Token = "0x4000057")]
		easeOutExpo,
		[Token(Token = "0x4000058")]
		easeInOutExpo,
		[Token(Token = "0x4000059")]
		easeInCirc,
		[Token(Token = "0x400005A")]
		easeOutCirc,
		[Token(Token = "0x400005B")]
		easeInOutCirc,
		[Token(Token = "0x400005C")]
		linear,
		[Token(Token = "0x400005D")]
		spring,
		[Token(Token = "0x400005E")]
		easeInBounce,
		[Token(Token = "0x400005F")]
		easeOutBounce,
		[Token(Token = "0x4000060")]
		easeInOutBounce,
		[Token(Token = "0x4000061")]
		easeInBack,
		[Token(Token = "0x4000062")]
		easeOutBack,
		[Token(Token = "0x4000063")]
		easeInOutBack,
		[Token(Token = "0x4000064")]
		easeInElastic,
		[Token(Token = "0x4000065")]
		easeOutElastic,
		[Token(Token = "0x4000066")]
		easeInOutElastic,
		[Token(Token = "0x4000067")]
		punch
	}

	[Token(Token = "0x200000F")]
	public enum LoopType
	{
		[Token(Token = "0x4000069")]
		none,
		[Token(Token = "0x400006A")]
		loop,
		[Token(Token = "0x400006B")]
		pingPong
	}

	[Token(Token = "0x2000010")]
	public enum NamedValueColor
	{
		[Token(Token = "0x400006D")]
		_Color,
		[Token(Token = "0x400006E")]
		_SpecColor,
		[Token(Token = "0x400006F")]
		_Emission,
		[Token(Token = "0x4000070")]
		_ReflectColor
	}

	[Token(Token = "0x2000011")]
	public static class Defaults
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x2000012")]
	private class CRSpline
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x998EBC", Offset = "0x998EBC", VA = "0x998EBC")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x998F34", Offset = "0x998F34", VA = "0x998F34")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x999230", Offset = "0x999230", VA = "0x999230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x999278", Offset = "0x999278", VA = "0x999278", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x999134", Offset = "0x999134", VA = "0x999134")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x99915C", Offset = "0x99915C", VA = "0x99915C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x999160", Offset = "0x999160", VA = "0x999160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x999238", Offset = "0x999238", VA = "0x999238", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x999384", Offset = "0x999384", VA = "0x999384", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x9993CC", Offset = "0x9993CC", VA = "0x9993CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x999280", Offset = "0x999280", VA = "0x999280")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x9992A8", Offset = "0x9992A8", VA = "0x9992A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x9992AC", Offset = "0x9992AC", VA = "0x9992AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x99938C", Offset = "0x99938C", VA = "0x99938C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x9994A4", Offset = "0x9994A4", VA = "0x9994A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x9994EC", Offset = "0x9994EC", VA = "0x9994EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x9993D4", Offset = "0x9993D4", VA = "0x9993D4")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x9993FC", Offset = "0x9993FC", VA = "0x9993FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x999400", Offset = "0x999400", VA = "0x999400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x9994AC", Offset = "0x9994AC", VA = "0x9994AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x973934", Offset = "0x973934", VA = "0x973934")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x973BD0", Offset = "0x973BD0", VA = "0x973BD0")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x974D40", Offset = "0x974D40", VA = "0x974D40")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x97502C", Offset = "0x97502C", VA = "0x97502C")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x975B90", Offset = "0x975B90", VA = "0x975B90")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x975D58", Offset = "0x975D58", VA = "0x975D58")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x976398", Offset = "0x976398", VA = "0x976398")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x975090", Offset = "0x975090", VA = "0x975090")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x976594", Offset = "0x976594", VA = "0x976594")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x975DBC", Offset = "0x975DBC", VA = "0x975DBC")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x976790", Offset = "0x976790", VA = "0x976790")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x9769E0", Offset = "0x9769E0", VA = "0x9769E0")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x976E84", Offset = "0x976E84", VA = "0x976E84")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x9770D4", Offset = "0x9770D4", VA = "0x9770D4")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x977268", Offset = "0x977268", VA = "0x977268")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x97741C", Offset = "0x97741C", VA = "0x97741C")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x9774D4", Offset = "0x9774D4", VA = "0x9774D4")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x9776C4", Offset = "0x9776C4", VA = "0x9776C4")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x977E2C", Offset = "0x977E2C", VA = "0x977E2C")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x97801C", Offset = "0x97801C", VA = "0x97801C")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x978358", Offset = "0x978358", VA = "0x978358")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x978548", Offset = "0x978548", VA = "0x978548")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x9788E8", Offset = "0x9788E8", VA = "0x9788E8")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x978AD8", Offset = "0x978AD8", VA = "0x978AD8")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x979444", Offset = "0x979444", VA = "0x979444")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x979634", Offset = "0x979634", VA = "0x979634")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x9739E0", Offset = "0x9739E0", VA = "0x9739E0")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x979730", Offset = "0x979730", VA = "0x979730")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x97982C", Offset = "0x97982C", VA = "0x97982C")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x979A1C", Offset = "0x979A1C", VA = "0x979A1C")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x979DA8", Offset = "0x979DA8", VA = "0x979DA8")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x979F98", Offset = "0x979F98", VA = "0x979F98")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x97A4A0", Offset = "0x97A4A0", VA = "0x97A4A0")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x97A690", Offset = "0x97A690", VA = "0x97A690")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x97A78C", Offset = "0x97A78C", VA = "0x97A78C")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x97A97C", Offset = "0x97A97C", VA = "0x97A97C")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x97AA78", Offset = "0x97AA78", VA = "0x97AA78")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x97AC68", Offset = "0x97AC68", VA = "0x97AC68")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x97B008", Offset = "0x97B008", VA = "0x97B008")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x97B1F8", Offset = "0x97B1F8", VA = "0x97B1F8")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x97B7E8", Offset = "0x97B7E8", VA = "0x97B7E8")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x97B9D8", Offset = "0x97B9D8", VA = "0x97B9D8")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x97BAD4", Offset = "0x97BAD4", VA = "0x97BAD4")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x97BCC4", Offset = "0x97BCC4", VA = "0x97BCC4")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x97BDC0", Offset = "0x97BDC0", VA = "0x97BDC0")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x97BFB0", Offset = "0x97BFB0", VA = "0x97BFB0")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x97C0AC", Offset = "0x97C0AC", VA = "0x97C0AC")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x97C29C", Offset = "0x97C29C", VA = "0x97C29C")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x97C398", Offset = "0x97C398", VA = "0x97C398")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x97C588", Offset = "0x97C588", VA = "0x97C588")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x97C684", Offset = "0x97C684", VA = "0x97C684")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x97C874", Offset = "0x97C874", VA = "0x97C874")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x97C9D4", Offset = "0x97C9D4", VA = "0x97C9D4")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x97CBC4", Offset = "0x97CBC4", VA = "0x97CBC4")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x97CD24", Offset = "0x97CD24", VA = "0x97CD24")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x97CF14", Offset = "0x97CF14", VA = "0x97CF14")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x97D074", Offset = "0x97D074", VA = "0x97D074")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x97E2B0", Offset = "0x97E2B0", VA = "0x97E2B0")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x97E138", Offset = "0x97E138", VA = "0x97E138")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x97DE88", Offset = "0x97DE88", VA = "0x97DE88")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x97DBF8", Offset = "0x97DBF8", VA = "0x97DBF8")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x97D9E8", Offset = "0x97D9E8", VA = "0x97D9E8")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x97E3F8", Offset = "0x97E3F8", VA = "0x97E3F8")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x97ED54", Offset = "0x97ED54", VA = "0x97ED54")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x983F5C", Offset = "0x983F5C", VA = "0x983F5C")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x9835E0", Offset = "0x9835E0", VA = "0x9835E0")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x97F084", Offset = "0x97F084", VA = "0x97F084")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x97F754", Offset = "0x97F754", VA = "0x97F754")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x97FE24", Offset = "0x97FE24", VA = "0x97FE24")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x980454", Offset = "0x980454", VA = "0x980454")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x980A0C", Offset = "0x980A0C", VA = "0x980A0C")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x980E78", Offset = "0x980E78", VA = "0x980E78")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x9812D8", Offset = "0x9812D8", VA = "0x9812D8")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x9819EC", Offset = "0x9819EC", VA = "0x9819EC")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x981E54", Offset = "0x981E54", VA = "0x981E54")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x9822F4", Offset = "0x9822F4", VA = "0x9822F4")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x982610", Offset = "0x982610", VA = "0x982610")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x982900", Offset = "0x982900", VA = "0x982900")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x982BF0", Offset = "0x982BF0", VA = "0x982BF0")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x982F60", Offset = "0x982F60", VA = "0x982F60")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x9832A4", Offset = "0x9832A4", VA = "0x9832A4")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x984674", Offset = "0x984674", VA = "0x984674")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x984980", Offset = "0x984980", VA = "0x984980")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x984BCC", Offset = "0x984BCC", VA = "0x984BCC")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x984DD4", Offset = "0x984DD4", VA = "0x984DD4")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x984F78", Offset = "0x984F78", VA = "0x984F78")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x9850CC", Offset = "0x9850CC", VA = "0x9850CC")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x9855E8", Offset = "0x9855E8", VA = "0x9855E8")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x985758", Offset = "0x985758", VA = "0x985758")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x98575C", Offset = "0x98575C", VA = "0x98575C")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x985A6C", Offset = "0x985A6C", VA = "0x985A6C")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x985C80", Offset = "0x985C80", VA = "0x985C80")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x985F60", Offset = "0x985F60", VA = "0x985F60")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x9860D4", Offset = "0x9860D4", VA = "0x9860D4")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x986234", Offset = "0x986234", VA = "0x986234")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x9864A8", Offset = "0x9864A8", VA = "0x9864A8")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x9866D0", Offset = "0x9866D0", VA = "0x9866D0")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x986A24", Offset = "0x986A24", VA = "0x986A24")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x986BA4", Offset = "0x986BA4", VA = "0x986BA4")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x986DC4", Offset = "0x986DC4", VA = "0x986DC4")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x987290", Offset = "0x987290", VA = "0x987290")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x987634", Offset = "0x987634", VA = "0x987634")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x9878E0", Offset = "0x9878E0", VA = "0x9878E0")]
	[IteratorStateMachine(typeof(<TweenDelay>d__145))]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x987948", Offset = "0x987948", VA = "0x987948")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x9883E4", Offset = "0x9883E4", VA = "0x9883E4")]
	[IteratorStateMachine(typeof(<TweenRestart>d__147))]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x98844C", Offset = "0x98844C", VA = "0x98844C")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x988524", Offset = "0x988524", VA = "0x988524")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x988608", Offset = "0x988608", VA = "0x988608")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x9886AC", Offset = "0x9886AC", VA = "0x9886AC")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x988860", Offset = "0x988860", VA = "0x988860")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x9888C8", Offset = "0x9888C8", VA = "0x9888C8")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x988824", Offset = "0x988824", VA = "0x988824")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x988914", Offset = "0x988914", VA = "0x988914")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x9894B8", Offset = "0x9894B8", VA = "0x9894B8")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x9889DC", Offset = "0x9889DC", VA = "0x9889DC")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x989680", Offset = "0x989680", VA = "0x989680")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x98987C", Offset = "0x98987C", VA = "0x98987C")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x989DE4", Offset = "0x989DE4", VA = "0x989DE4")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x98A034", Offset = "0x98A034", VA = "0x98A034")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x98A790", Offset = "0x98A790", VA = "0x98A790")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x98A980", Offset = "0x98A980", VA = "0x98A980")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x98AFD0", Offset = "0x98AFD0", VA = "0x98AFD0")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x98B1C0", Offset = "0x98B1C0", VA = "0x98B1C0")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x98C56C", Offset = "0x98C56C", VA = "0x98C56C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x98BAA4", Offset = "0x98BAA4", VA = "0x98BAA4")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x98C75C", Offset = "0x98C75C", VA = "0x98C75C")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x98C94C", Offset = "0x98C94C", VA = "0x98C94C")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x9844EC", Offset = "0x9844EC", VA = "0x9844EC")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x98CF68", Offset = "0x98CF68", VA = "0x98CF68")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x98D000", Offset = "0x98D000", VA = "0x98D000")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x98D088", Offset = "0x98D088", VA = "0x98D088")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x98D1B4", Offset = "0x98D1B4", VA = "0x98D1B4")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x98D2C8", Offset = "0x98D2C8", VA = "0x98D2C8")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x98D3C0", Offset = "0x98D3C0", VA = "0x98D3C0")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x98D628", Offset = "0x98D628", VA = "0x98D628")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x98D6E8", Offset = "0x98D6E8", VA = "0x98D6E8")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x98D854", Offset = "0x98D854", VA = "0x98D854")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x98D99C", Offset = "0x98D99C", VA = "0x98D99C")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x98DA80", Offset = "0x98DA80", VA = "0x98DA80")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x98DB40", Offset = "0x98DB40", VA = "0x98DB40")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x98DCAC", Offset = "0x98DCAC", VA = "0x98DCAC")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x98DDF4", Offset = "0x98DDF4", VA = "0x98DDF4")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x98DED8", Offset = "0x98DED8", VA = "0x98DED8")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x98DF98", Offset = "0x98DF98", VA = "0x98DF98")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x98E104", Offset = "0x98E104", VA = "0x98E104")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x98E24C", Offset = "0x98E24C", VA = "0x98E24C")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x98E2B4", Offset = "0x98E2B4", VA = "0x98E2B4")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x98E594", Offset = "0x98E594", VA = "0x98E594")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x98E654", Offset = "0x98E654", VA = "0x98E654")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x98E7C0", Offset = "0x98E7C0", VA = "0x98E7C0")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x98E908", Offset = "0x98E908", VA = "0x98E908")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x98E9EC", Offset = "0x98E9EC", VA = "0x98E9EC")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x98EAAC", Offset = "0x98EAAC", VA = "0x98EAAC")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x98EC18", Offset = "0x98EC18", VA = "0x98EC18")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x98ED60", Offset = "0x98ED60", VA = "0x98ED60")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x98EE44", Offset = "0x98EE44", VA = "0x98EE44")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x98EF04", Offset = "0x98EF04", VA = "0x98EF04")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x98F070", Offset = "0x98F070", VA = "0x98F070")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x98F1B8", Offset = "0x98F1B8", VA = "0x98F1B8")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x98F29C", Offset = "0x98F29C", VA = "0x98F29C")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x98F5CC", Offset = "0x98F5CC", VA = "0x98F5CC")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x98F720", Offset = "0x98F720", VA = "0x98F720")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x98FB44", Offset = "0x98FB44", VA = "0x98FB44")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x98FC6C", Offset = "0x98FC6C", VA = "0x98FC6C")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x98FEA0", Offset = "0x98FEA0", VA = "0x98FEA0")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x98FFF4", Offset = "0x98FFF4", VA = "0x98FFF4")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x990324", Offset = "0x990324", VA = "0x990324")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x9904D8", Offset = "0x9904D8", VA = "0x9904D8")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x99095C", Offset = "0x99095C", VA = "0x99095C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x990A84", Offset = "0x990A84", VA = "0x990A84")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x990CB8", Offset = "0x990CB8", VA = "0x990CB8")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x990D28", Offset = "0x990D28", VA = "0x990D28")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x990F20", Offset = "0x990F20", VA = "0x990F20")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x990F7C", Offset = "0x990F7C", VA = "0x990F7C")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x9910D4", Offset = "0x9910D4", VA = "0x9910D4")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x991324", Offset = "0x991324", VA = "0x991324")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x9916A4", Offset = "0x9916A4", VA = "0x9916A4")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x991248", Offset = "0x991248", VA = "0x991248")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x9919DC", Offset = "0x9919DC", VA = "0x9919DC")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x991558", Offset = "0x991558", VA = "0x991558")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x9918D8", Offset = "0x9918D8", VA = "0x9918D8")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x991D0C", Offset = "0x991D0C", VA = "0x991D0C")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x992128", Offset = "0x992128", VA = "0x992128")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x974F08", Offset = "0x974F08", VA = "0x974F08")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x9924FC", Offset = "0x9924FC", VA = "0x9924FC")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x992524", Offset = "0x992524", VA = "0x992524")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x9937EC", Offset = "0x9937EC", VA = "0x9937EC")]
	[IteratorStateMachine(typeof(<Start>d__229))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x993854", Offset = "0x993854", VA = "0x993854")]
	private void Update()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x993890", Offset = "0x993890", VA = "0x993890")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x9938CC", Offset = "0x9938CC", VA = "0x9938CC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x993A00", Offset = "0x993A00", VA = "0x993A00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x993A74", Offset = "0x993A74", VA = "0x993A74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x98D4A4", Offset = "0x98D4A4", VA = "0x98D4A4")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x98E398", Offset = "0x98E398", VA = "0x98E398")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x98CB54", Offset = "0x98CB54", VA = "0x98CB54")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x98CD74", Offset = "0x98CD74", VA = "0x98CD74")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x974BBC", Offset = "0x974BBC", VA = "0x974BBC")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x974144", Offset = "0x974144", VA = "0x974144")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x993A78", Offset = "0x993A78", VA = "0x993A78")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x992554", Offset = "0x992554", VA = "0x992554")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x993AA4", Offset = "0x993AA4", VA = "0x993AA4")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x9884B8", Offset = "0x9884B8", VA = "0x9884B8")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x987B18", Offset = "0x987B18", VA = "0x987B18")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x9842D0", Offset = "0x9842D0", VA = "0x9842D0")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x987E2C", Offset = "0x987E2C", VA = "0x987E2C")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x9883E0", Offset = "0x9883E0", VA = "0x9883E0")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x9886A8", Offset = "0x9886A8", VA = "0x9886A8")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x993A28", Offset = "0x993A28", VA = "0x993A28")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x993FA4", Offset = "0x993FA4", VA = "0x993FA4")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x984488", Offset = "0x984488", VA = "0x984488")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x993FC8", Offset = "0x993FC8", VA = "0x993FC8")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x994078", Offset = "0x994078", VA = "0x994078")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x99408C", Offset = "0x99408C", VA = "0x99408C")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x9940A8", Offset = "0x9940A8", VA = "0x9940A8")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x9940FC", Offset = "0x9940FC", VA = "0x9940FC")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x994114", Offset = "0x994114", VA = "0x994114")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x99413C", Offset = "0x99413C", VA = "0x99413C")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x994194", Offset = "0x994194", VA = "0x994194")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x9941B0", Offset = "0x9941B0", VA = "0x9941B0")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x9941D8", Offset = "0x9941D8", VA = "0x9941D8")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x994234", Offset = "0x994234", VA = "0x994234")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x994254", Offset = "0x994254", VA = "0x994254")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x994284", Offset = "0x994284", VA = "0x994284")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x9942EC", Offset = "0x9942EC", VA = "0x9942EC")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x994324", Offset = "0x994324", VA = "0x994324")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x994358", Offset = "0x994358", VA = "0x994358")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x99439C", Offset = "0x99439C", VA = "0x99439C")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x9943D4", Offset = "0x9943D4", VA = "0x9943D4")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x99440C", Offset = "0x99440C", VA = "0x99440C")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x99447C", Offset = "0x99447C", VA = "0x99447C")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x9944A4", Offset = "0x9944A4", VA = "0x9944A4")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x9944CC", Offset = "0x9944CC", VA = "0x9944CC")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x994520", Offset = "0x994520", VA = "0x994520")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x994558", Offset = "0x994558", VA = "0x994558")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x994620", Offset = "0x994620", VA = "0x994620")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x9946A0", Offset = "0x9946A0", VA = "0x9946A0")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x9946D0", Offset = "0x9946D0", VA = "0x9946D0")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x994710", Offset = "0x994710", VA = "0x994710")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x987220", Offset = "0x987220", VA = "0x987220")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x994794", Offset = "0x994794", VA = "0x994794")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x994824", Offset = "0x994824", VA = "0x994824")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x9948B4", Offset = "0x9948B4", VA = "0x9948B4")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000016")]
[AddComponentMenu("Pixelplacement/iTweenPath")]
public class iTweenPath : MonoBehaviour
{
	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string pathName;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color pathColor;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> nodes;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int nodeCount;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Dictionary<string, iTweenPath> paths;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool initialized;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string initialName;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool pathVisible;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x9994F4", Offset = "0x9994F4", VA = "0x9994F4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x9995E0", Offset = "0x9995E0", VA = "0x9995E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x999678", Offset = "0x999678", VA = "0x999678")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x99975C", Offset = "0x99975C", VA = "0x99975C")]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x9998E4", Offset = "0x9998E4", VA = "0x9998E4")]
	public static Vector3[] GetPathReversed(string requestedName)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x999AF4", Offset = "0x999AF4", VA = "0x999AF4")]
	public iTweenPath()
	{
	}
}
[Token(Token = "0x2000017")]
public class MoveSample : MonoBehaviour
{
	[Token(Token = "0x600014A")]
	[Address(RVA = "0x999D74", Offset = "0x999D74", VA = "0x999D74")]
	private void Start()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x99A06C", Offset = "0x99A06C", VA = "0x99A06C")]
	public MoveSample()
	{
	}
}
[Token(Token = "0x2000018")]
public class RotateSample : MonoBehaviour
{
	[Token(Token = "0x600014C")]
	[Address(RVA = "0x99A074", Offset = "0x99A074", VA = "0x99A074")]
	private void Start()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x99A358", Offset = "0x99A358", VA = "0x99A358")]
	public RotateSample()
	{
	}
}
[Token(Token = "0x2000019")]
public class SampleInfo : MonoBehaviour
{
	[Token(Token = "0x600014E")]
	[Address(RVA = "0x99A360", Offset = "0x99A360", VA = "0x99A360")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x99A518", Offset = "0x99A518", VA = "0x99A518")]
	public SampleInfo()
	{
	}
}
namespace NativeGalleryNamespace
{
	[Token(Token = "0x200001A")]
	public class NGCallbackHelper : MonoBehaviour
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Action mainThreadAction;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x99A520", Offset = "0x99A520", VA = "0x99A520")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x99A58C", Offset = "0x99A58C", VA = "0x99A58C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x99A5AC", Offset = "0x99A5AC", VA = "0x99A5AC")]
		public void CallOnMainThread(Action function)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x99A5B4", Offset = "0x99A5B4", VA = "0x99A5B4")]
		public NGCallbackHelper()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class NGMediaReceiveCallbackAndroid : AndroidJavaProxy
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly NativeGallery.MediaPickCallback callback;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly NativeGallery.MediaPickMultipleCallback callbackMultiple;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly NGCallbackHelper callbackHelper;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x997664", Offset = "0x997664", VA = "0x997664")]
		public NGMediaReceiveCallbackAndroid(NativeGallery.MediaPickCallback callback, NativeGallery.MediaPickMultipleCallback callbackMultiple)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x99A5BC", Offset = "0x99A5BC", VA = "0x99A5BC")]
		public void OnMediaReceived(string path)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x99A684", Offset = "0x99A684", VA = "0x99A684")]
		public void OnMultipleMediaReceived(string paths)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x99A8BC", Offset = "0x99A8BC", VA = "0x99A8BC")]
		private void MediaReceiveCallback(string path)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x99A9D4", Offset = "0x99A9D4", VA = "0x99A9D4")]
		private void MediaReceiveMultipleCallback(string[] paths)
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class NGPermissionCallbackAndroid : AndroidJavaProxy
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object threadLock;

		[Token(Token = "0x1700000D")]
		public int Result
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x99AB24", Offset = "0x99AB24", VA = "0x99AB24")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x99AB2C", Offset = "0x99AB2C", VA = "0x99AB2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x996514", Offset = "0x996514", VA = "0x996514")]
		public NGPermissionCallbackAndroid(object threadLock)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x99AB34", Offset = "0x99AB34", VA = "0x99AB34")]
		public void OnPermissionResult(int result)
		{
		}
	}
}
namespace NAudio.Dsp
{
	[Token(Token = "0x200001F")]
	internal class WdlResampler
	{
		[Token(Token = "0x2000020")]
		private class WDL_Resampler_IIRFilter
		{
			[Token(Token = "0x40000B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private double m_fpos;

			[Token(Token = "0x40000B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private double m_a1;

			[Token(Token = "0x40000B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private double m_a2;

			[Token(Token = "0x40000B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private double m_b0;

			[Token(Token = "0x40000B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private double m_b1;

			[Token(Token = "0x40000B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private double m_b2;

			[Token(Token = "0x40000B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private double[,] m_hist;

			[Token(Token = "0x6000170")]
			[Address(RVA = "0x99BA2C", Offset = "0x99BA2C", VA = "0x99BA2C")]
			public WDL_Resampler_IIRFilter()
			{
			}

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x99AD9C", Offset = "0x99AD9C", VA = "0x99AD9C")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x99BA50", Offset = "0x99BA50", VA = "0x99BA50")]
			public void setParms(double fpos, double Q)
			{
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x99BB54", Offset = "0x99BB54", VA = "0x99BB54")]
			public void Apply(float[] inBuffer, int inIndex, float[] outBuffer, int outIndex, int ns, int span, int w)
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x99C358", Offset = "0x99C358", VA = "0x99C358")]
			private double denormal_filter(float x)
			{
				return default(double);
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x99C354", Offset = "0x99C354", VA = "0x99C354")]
			private double denormal_filter(double x)
			{
				return default(double);
			}
		}

		[Token(Token = "0x400009C")]
		private const int WDL_RESAMPLE_MAX_FILTERS = 4;

		[Token(Token = "0x400009D")]
		private const int WDL_RESAMPLE_MAX_NCH = 64;

		[Token(Token = "0x400009E")]
		private const double PI = Math.PI;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_sratein;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private double m_srateout;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double m_fracpos;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double m_ratio;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double m_filter_ratio;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_filterq;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_filterpos;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float[] m_rsinbuf;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float[] m_filter_coeffs;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WDL_Resampler_IIRFilter m_iirfilter;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_filter_coeffs_size;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_last_requested;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_filtlatency;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_samples_in_rsinbuf;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_lp_oversize;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_sincsize;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_filtercnt;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_sincoversize;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_interp;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		private bool m_feedmode;

		[Token(Token = "0x1700000E")]
		public double InputSampleRate
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x99AE38", Offset = "0x99AE38", VA = "0x99AE38")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700000F")]
		public double OutputSampleRate
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x99AE40", Offset = "0x99AE40", VA = "0x99AE40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x99ABFC", Offset = "0x99ABFC", VA = "0x99ABFC")]
		public WdlResampler()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x99AC88", Offset = "0x99AC88", VA = "0x99AC88")]
		public void SetMode(bool interp, int filtercnt, bool sinc, int sinc_size = 64, int sinc_interpsize = 32)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x99AD88", Offset = "0x99AD88", VA = "0x99AD88")]
		public void SetFilterParms(float filterpos = 0.693f, float filterq = 0.707f)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x99AD90", Offset = "0x99AD90", VA = "0x99AD90")]
		public void SetFeedMode(bool wantInputDriven)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x99AC68", Offset = "0x99AC68", VA = "0x99AC68")]
		public void Reset(double fracpos = 0.0)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x99AE04", Offset = "0x99AE04", VA = "0x99AE04")]
		public void SetRates(double rate_in, double rate_out)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x99AE48", Offset = "0x99AE48", VA = "0x99AE48")]
		public double GetCurrentLatency()
		{
			return default(double);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x99AE6C", Offset = "0x99AE6C", VA = "0x99AE6C")]
		public int ResamplePrepare(int out_samples, int nch, out float[] inbuffer, out int inbufferOffset)
		{
			return default(int);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x99B01C", Offset = "0x99B01C", VA = "0x99B01C")]
		public int ResampleOut(float[] outBuffer, int outBufferIndex, int nsamples_in, int nsamples_out, int nch)
		{
			return default(int);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x99BC5C", Offset = "0x99BC5C", VA = "0x99BC5C")]
		private void BuildLowPass(double filtpos)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x99C21C", Offset = "0x99C21C", VA = "0x99C21C")]
		private void SincSample(float[] outBuffer, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, int nch, float[] filter, int filterIndex, int filtsz)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x99BF20", Offset = "0x99BF20", VA = "0x99BF20")]
		private void SincSample1(float[] outBuffer, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, float[] filter, int filterIndex, int filtsz)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x99C01C", Offset = "0x99C01C", VA = "0x99C01C")]
		private void SincSample2(float[] outptr, int outBufferIndex, float[] inBuffer, int inBufferIndex, double fracpos, float[] filter, int filterIndex, int filtsz)
		{
		}
	}
}
namespace NAudio.Wave
{
	[Token(Token = "0x2000021")]
	internal interface ISampleProvider
	{
		[Token(Token = "0x17000010")]
		[NotNull]
		WaveFormat WaveFormat
		{
			[Token(Token = "0x6000176")]
			get;
		}

		[Token(Token = "0x6000177")]
		int Read([NotNull] float[] buffer, int offset, int count);
	}
	[Token(Token = "0x2000022")]
	internal class WaveFileWriter : Stream
	{
		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stream _outStream;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private BinaryWriter _writer;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long _dataSizePos;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long _factSampleCountPos;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _dataChunkSize;

		[Token(Token = "0x17000011")]
		public string Filename
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x99C834", Offset = "0x99C834", VA = "0x99C834")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x99C83C", Offset = "0x99C83C", VA = "0x99C83C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public override long Length
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x99C844", Offset = "0x99C844", VA = "0x99C844", Slot = "11")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000013")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x99C84C", Offset = "0x99C84C", VA = "0x99C84C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x99C854", Offset = "0x99C854", VA = "0x99C854")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public override bool CanRead
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x99C85C", Offset = "0x99C85C", VA = "0x99C85C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x99C864", Offset = "0x99C864", VA = "0x99C864", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x99C86C", Offset = "0x99C86C", VA = "0x99C86C", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public override long Position
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x99C964", Offset = "0x99C964", VA = "0x99C964", Slot = "12")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x99C96C", Offset = "0x99C96C", VA = "0x99C96C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x99C360", Offset = "0x99C360", VA = "0x99C360")]
		public WaveFileWriter(Stream outStream, WaveFormat format)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x99C79C", Offset = "0x99C79C", VA = "0x99C79C")]
		public WaveFileWriter(string filename, WaveFormat format)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x99C6E8", Offset = "0x99C6E8", VA = "0x99C6E8")]
		private void WriteDataChunkHeader()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x99C618", Offset = "0x99C618", VA = "0x99C618")]
		private void CreateFactChunk()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x99C82C", Offset = "0x99C82C", VA = "0x99C82C")]
		private bool HasFactChunk()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x99C874", Offset = "0x99C874", VA = "0x99C874", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x99C8C4", Offset = "0x99C8C4", VA = "0x99C8C4", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x99C914", Offset = "0x99C914", VA = "0x99C914", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x99C9BC", Offset = "0x99C9BC", VA = "0x99C9BC", Slot = "34")]
		public override void Write(byte[] data, int offset, int count)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x99CA00", Offset = "0x99CA00", VA = "0x99CA00")]
		public void WriteSample(float sample)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x99CA38", Offset = "0x99CA38", VA = "0x99CA38")]
		public void WriteSamples(float[] samples, int offset, int count)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x99CAB4", Offset = "0x99CAB4", VA = "0x99CAB4", Slot = "20")]
		public override void Flush()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x99CAD4", Offset = "0x99CAD4", VA = "0x99CAD4", Slot = "19")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x99CBA4", Offset = "0x99CBA4", VA = "0x99CBA4", Slot = "37")]
		protected virtual void UpdateHeader(BinaryWriter writer)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x99CCD0", Offset = "0x99CCD0", VA = "0x99CCD0")]
		private void UpdateDataChunk(BinaryWriter writer)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x99CBF4", Offset = "0x99CBF4", VA = "0x99CBF4")]
		private void UpdateRiffChunk(BinaryWriter writer)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x99CC58", Offset = "0x99CC58", VA = "0x99CC58")]
		private void UpdateFactChunk(BinaryWriter writer)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x99CD20", Offset = "0x99CD20", VA = "0x99CD20", Slot = "1")]
		~WaveFileWriter()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public sealed class WaveFormat
	{
		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int _channels;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly int _sampleRate;

		[Token(Token = "0x17000018")]
		public int Channels
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x99CDC4", Offset = "0x99CDC4", VA = "0x99CDC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		public int SampleRate
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x99CDCC", Offset = "0x99CDCC", VA = "0x99CDCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x99CDD4", Offset = "0x99CDD4", VA = "0x99CDD4")]
		public WaveFormat(int sampleRate, int channels)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x99CE68", Offset = "0x99CE68", VA = "0x99CE68")]
		public bool Equals(WaveFormat other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x99CEA4", Offset = "0x99CEA4", VA = "0x99CEA4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x99CEC8", Offset = "0x99CEC8", VA = "0x99CEC8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace HandyCollections.Heap
{
	[Token(Token = "0x2000024")]
	internal interface IMinHeap<T>
	{
		[Token(Token = "0x1700001A")]
		int Count
		{
			[Token(Token = "0x600019A")]
			get;
		}

		[Token(Token = "0x1700001B")]
		T Minimum
		{
			[Token(Token = "0x600019B")]
			get;
		}

		[Token(Token = "0x600019C")]
		void Add(T item);

		[Token(Token = "0x600019D")]
		void Add(IEnumerable<T> items);

		[Token(Token = "0x600019E")]
		T RemoveMin();

		[Token(Token = "0x600019F")]
		T RemoveAt(int index);

		[Token(Token = "0x60001A0")]
		int IndexOf(T item);

		[Token(Token = "0x60001A1")]
		int IndexOf(Predicate<T> predicate);

		[Token(Token = "0x60001A2")]
		void Clear();
	}
	[Token(Token = "0x2000025")]
	internal class MinHeap<T> : IMinHeap<T>
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> _heap;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IComparer<T> _comparer;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _allowResize;

		[Token(Token = "0x1700001C")]
		public int Count
		{
			[Token(Token = "0x60001A3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public T Minimum
		{
			[Token(Token = "0x60001A4")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x1700001E")]
		public bool AllowHeapResize
		{
			[Token(Token = "0x60001A5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A6")]
			set
			{
			}
		}

		[Token(Token = "0x60001A7")]
		public MinHeap()
		{
		}

		[Token(Token = "0x60001A8")]
		public MinHeap(int capacity)
		{
		}

		[Token(Token = "0x60001A9")]
		public MinHeap(int capacity, IComparer<T> comparer)
		{
		}

		[Token(Token = "0x60001AA")]
		public MinHeap(IComparer<T> comparer)
		{
		}

		[Token(Token = "0x60001AB")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x60001AC")]
		public void Add(IEnumerable<T> items)
		{
		}

		[Token(Token = "0x60001AD")]
		public void Heapify()
		{
		}

		[Token(Token = "0x60001AE")]
		public void Heapify(int mutated)
		{
		}

		[Token(Token = "0x60001AF")]
		public T RemoveMin()
		{
			return (T)null;
		}

		[Token(Token = "0x60001B0")]
		public T RemoveAt(int index)
		{
			return (T)null;
		}

		[Token(Token = "0x60001B1")]
		public void Clear()
		{
		}

		[Token(Token = "0x60001B2")]
		private void BubbleUp(int index)
		{
		}

		[Token(Token = "0x60001B3")]
		private int TrickleDown(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60001B4")]
		private void DebugCheckHeapProperty()
		{
		}

		[Token(Token = "0x60001B5")]
		private bool IsLessThan(T a, T b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		private static int ParentIndex(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60001B7")]
		private void Swap(int a, int b)
		{
		}

		[Token(Token = "0x60001B8")]
		private static int LeftChild(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60001B9")]
		private static int RightChild(int i)
		{
			return default(int);
		}

		[Token(Token = "0x60001BA")]
		private int SmallestChildSmallerThan(int i, T item)
		{
			return default(int);
		}

		[Token(Token = "0x60001BB")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x60001BC")]
		public int IndexOf(Predicate<T> predicate)
		{
			return default(int);
		}
	}
}
namespace Dissonance
{
	[Token(Token = "0x2000026")]
	public enum AudioQuality
	{
		[Token(Token = "0x40000C7")]
		Low,
		[Token(Token = "0x40000C8")]
		Medium,
		[Token(Token = "0x40000C9")]
		High
	}
	[Token(Token = "0x2000027")]
	public abstract class BaseCommsTrigger : MonoBehaviour, IAccessTokenCollection
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Log Log;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _wasColliderTriggered;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<GameObject> _entitiesInCollider;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TokenSet _tokens;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool? _cachedTokenActivation;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DissonanceComms _comms;

		[Token(Token = "0x1700001F")]
		public abstract bool UseColliderTrigger
		{
			[Token(Token = "0x60001BD")]
			get;
			[Token(Token = "0x60001BE")]
			set;
		}

		[Token(Token = "0x17000020")]
		[Obsolete("Replaced with UseColliderTrigger")]
		public bool UseTrigger
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x99CF68", Offset = "0x99CF68", VA = "0x99CF68")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x99CF74", Offset = "0x99CF74", VA = "0x99CF74")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public abstract bool CanTrigger
		{
			[Token(Token = "0x60001C1")]
			get;
		}

		[Token(Token = "0x17000022")]
		public bool IsColliderTriggered
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x99CF84", Offset = "0x99CF84", VA = "0x99CF84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public IEnumerable<string> Tokens
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x99CFF0", Offset = "0x99CFF0", VA = "0x99CFF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		protected DissonanceComms Comms
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x99CFF8", Offset = "0x99CFF8", VA = "0x99CFF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x99D000", Offset = "0x99D000", VA = "0x99D000")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		protected bool TokenActivationState
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x99D9E0", Offset = "0x99D9E0", VA = "0x99D9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x99D21C", Offset = "0x99D21C", VA = "0x99D21C")]
		protected BaseCommsTrigger()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x99D404", Offset = "0x99D404", VA = "0x99D404", Slot = "11")]
		[UsedImplicitly]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x99D624", Offset = "0x99D624", VA = "0x99D624", Slot = "12")]
		[UsedImplicitly]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x99D628", Offset = "0x99D628", VA = "0x99D628", Slot = "13")]
		[UsedImplicitly]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x99D77C", Offset = "0x99D77C", VA = "0x99D77C", Slot = "14")]
		[UsedImplicitly]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x99D9CC", Offset = "0x99D9CC", VA = "0x99D9CC", Slot = "15")]
		[UsedImplicitly]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x99D9D0", Offset = "0x99D9D0", VA = "0x99D9D0", Slot = "16")]
		[UsedImplicitly]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x99D9D8", Offset = "0x99D9D8", VA = "0x99D9D8", Slot = "17")]
		protected virtual void TokensModified(string token)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x99DB70", Offset = "0x99DB70", VA = "0x99DB70", Slot = "5")]
		public bool ContainsToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x99DBC4", Offset = "0x99DBC4", VA = "0x99DBC4", Slot = "6")]
		public bool AddToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x99DCDC", Offset = "0x99DCDC", VA = "0x99DCDC", Slot = "7")]
		public bool RemoveToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x99DDEC", Offset = "0x99DDEC", VA = "0x99DDEC", Slot = "18")]
		protected virtual void ColliderTriggerChanged()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x99DDF0", Offset = "0x99DDF0", VA = "0x99DDF0")]
		[UsedImplicitly]
		private void OnTriggerEnter([NotNull] Collider other)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x99DF94", Offset = "0x99DF94", VA = "0x99DF94")]
		[UsedImplicitly]
		private void OnTriggerExit([NotNull] Collider other)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x99E08C", Offset = "0x99E08C", VA = "0x99E08C", Slot = "19")]
		protected virtual bool ColliderTriggerFilter([NotNull] Collider other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x99D6AC", Offset = "0x99D6AC", VA = "0x99D6AC")]
		[CanBeNull]
		private DissonanceComms FindLocalVoiceComm()
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x99D8EC", Offset = "0x99D8EC", VA = "0x99D8EC")]
		protected bool CheckVoiceComm()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000028")]
	public enum ChannelPriority
	{
		[Token(Token = "0x40000D1")]
		None = -2,
		[Token(Token = "0x40000D2")]
		Low,
		[Token(Token = "0x40000D3")]
		Default,
		[Token(Token = "0x40000D4")]
		Medium,
		[Token(Token = "0x40000D5")]
		High
	}
	[Token(Token = "0x2000029")]
	public sealed class ChannelProperties
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IChannelPriorityProvider _defaultPriority;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _amplitudeMultiplier;

		[Token(Token = "0x17000026")]
		public ushort Id
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x99E3A0", Offset = "0x99E3A0", VA = "0x99E3A0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x99E3A8", Offset = "0x99E3A8", VA = "0x99E3A8")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public bool Positional
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x99E3B0", Offset = "0x99E3B0", VA = "0x99E3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x99E3B8", Offset = "0x99E3B8", VA = "0x99E3B8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x99E3C4", Offset = "0x99E3C4", VA = "0x99E3C4")]
			[CompilerGenerated]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x99E3CC", Offset = "0x99E3CC", VA = "0x99E3CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		internal ChannelPriority TransmitPriority
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x99E3D4", Offset = "0x99E3D4", VA = "0x99E3D4")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x1700002A")]
		internal float AmplitudeMultiplier
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x99E48C", Offset = "0x99E48C", VA = "0x99E48C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x99E494", Offset = "0x99E494", VA = "0x99E494")]
			set
			{
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x99E514", Offset = "0x99E514", VA = "0x99E514")]
		internal ChannelProperties(IChannelPriorityProvider defaultPriority)
		{
		}
	}
	[Token(Token = "0x200002A")]
	public abstract class Channels<T, TId> where T : IChannel<TId>, IEquatable<T> where TId : IEquatable<TId>
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Log Log;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<ushort, T> _openChannelsBySubId;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Pool<ChannelProperties> _propertiesPool;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _nextId;

		[Token(Token = "0x1700002B")]
		public int Count
		{
			[Token(Token = "0x60001E6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000001")]
		public event Action<TId, ChannelProperties> OpenedChannel
		{
			[Token(Token = "0x60001E2")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001E3")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event Action<TId, ChannelProperties> ClosedChannel
		{
			[Token(Token = "0x60001E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001E5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60001E7")]
		internal Channels([NotNull] IChannelPriorityProvider priorityProvider)
		{
		}

		[Token(Token = "0x60001E8")]
		[NotNull]
		protected abstract T CreateChannel(ushort subscriptionId, TId channelId, ChannelProperties properties);

		[Token(Token = "0x60001E9")]
		public bool Contains([NotNull] T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[NotNull]
		public T Open([NotNull] TId id, bool positional = false, ChannelPriority priority = ChannelPriority.Default, float amplitudeMultiplier = 1f)
		{
			return (T)null;
		}

		[Token(Token = "0x60001EB")]
		public bool Close([NotNull] T channel)
		{
			return default(bool);
		}

		[Token(Token = "0x60001EC")]
		internal void Refresh()
		{
		}

		[Token(Token = "0x60001ED")]
		public Dictionary<ushort, T>.Enumerator GetEnumerator()
		{
			return default(Dictionary<ushort, T>.Enumerator);
		}
	}
	[Token(Token = "0x200002C")]
	public interface IChannel<T> : IDisposable
	{
		[Token(Token = "0x1700002C")]
		T TargetId
		{
			[Token(Token = "0x60001F0")]
			get;
		}

		[Token(Token = "0x1700002D")]
		ushort SubscriptionId
		{
			[Token(Token = "0x60001F1")]
			get;
		}

		[Token(Token = "0x1700002E")]
		[NotNull]
		ChannelProperties Properties
		{
			[Token(Token = "0x60001F2")]
			get;
		}
	}
	[Token(Token = "0x200002D")]
	public struct PlayerChannel : IChannel<string>, IDisposable, IEquatable<PlayerChannel>
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort _subscriptionId;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string _playerId;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ChannelProperties _properties;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PlayerChannels _channels;

		[Token(Token = "0x1700002F")]
		public ushort SubscriptionId
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x99E54C", Offset = "0x99E54C", VA = "0x99E54C", Slot = "5")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000030")]
		[NotNull]
		public string TargetId
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x99E554", Offset = "0x99E554", VA = "0x99E554", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private ChannelProperties Dissonance.IChannel<System.String>.Properties
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x99E55C", Offset = "0x99E55C", VA = "0x99E55C", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		[NotNull]
		internal ChannelProperties Properties
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x99E564", Offset = "0x99E564", VA = "0x99E564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsOpen
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x99E56C", Offset = "0x99E56C", VA = "0x99E56C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public bool Positional
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x99E5E0", Offset = "0x99E5E0", VA = "0x99E5E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x99E674", Offset = "0x99E674", VA = "0x99E674")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x99E6A8", Offset = "0x99E6A8", VA = "0x99E6A8")]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x99E6CC", Offset = "0x99E6CC", VA = "0x99E6CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public float Volume
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x99E6FC", Offset = "0x99E6FC", VA = "0x99E6FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x99E720", Offset = "0x99E720", VA = "0x99E720")]
			set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x99E53C", Offset = "0x99E53C", VA = "0x99E53C")]
		internal PlayerChannel(ushort subscriptionId, string playerId, PlayerChannels channels, ChannelProperties properties)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x99E750", Offset = "0x99E750", VA = "0x99E750", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x99E604", Offset = "0x99E604", VA = "0x99E604")]
		private void CheckValidProperties()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x99E828", Offset = "0x99E828", VA = "0x99E828", Slot = "8")]
		public bool Equals(PlayerChannel other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x99E850", Offset = "0x99E850", VA = "0x99E850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x99E8DC", Offset = "0x99E8DC", VA = "0x99E8DC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x200002E")]
	public sealed class PlayerChannels : Channels<PlayerChannel, string>
	{
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x99E914", Offset = "0x99E914", VA = "0x99E914")]
		internal PlayerChannels(IChannelPriorityProvider priorityProvider)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x99EAD4", Offset = "0x99EAD4", VA = "0x99EAD4", Slot = "4")]
		protected override PlayerChannel CreateChannel(ushort subscriptionId, string channelId, ChannelProperties properties)
		{
			return default(PlayerChannel);
		}
	}
	[Token(Token = "0x2000030")]
	public struct RemoteChannel
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _target;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly ChannelType _type;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly PlaybackOptions _options;

		[Token(Token = "0x17000037")]
		public ChannelType Type
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x99EB58", Offset = "0x99EB58", VA = "0x99EB58")]
			get
			{
				return default(ChannelType);
			}
		}

		[Token(Token = "0x17000038")]
		public PlaybackOptions Options
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x99EB60", Offset = "0x99EB60", VA = "0x99EB60")]
			get
			{
				return default(PlaybackOptions);
			}
		}

		[Token(Token = "0x17000039")]
		public string TargetName
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x99EB70", Offset = "0x99EB70", VA = "0x99EB70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x99EB78", Offset = "0x99EB78", VA = "0x99EB78")]
		internal RemoteChannel([NotNull] string targetName, ChannelType type, PlaybackOptions options)
		{
		}
	}
	[Token(Token = "0x2000031")]
	public struct RoomChannel : IChannel<string>, IDisposable, IEquatable<RoomChannel>
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort _subscriptionId;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly string _roomId;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ChannelProperties _properties;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly RoomChannels _channels;

		[Token(Token = "0x1700003A")]
		public ushort SubscriptionId
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x99EBF4", Offset = "0x99EBF4", VA = "0x99EBF4", Slot = "5")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x1700003B")]
		[NotNull]
		public string TargetId
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x99EBFC", Offset = "0x99EBFC", VA = "0x99EBFC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private ChannelProperties Dissonance.IChannel<System.String>.Properties
		{
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x99EC04", Offset = "0x99EC04", VA = "0x99EC04", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		[NotNull]
		internal ChannelProperties Properties
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x99EC0C", Offset = "0x99EC0C", VA = "0x99EC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsOpen
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x99EC14", Offset = "0x99EC14", VA = "0x99EC14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool Positional
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x99EC88", Offset = "0x99EC88", VA = "0x99EC88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x99ED80", Offset = "0x99ED80", VA = "0x99ED80")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x99EDB4", Offset = "0x99EDB4", VA = "0x99EDB4")]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x99EDD8", Offset = "0x99EDD8", VA = "0x99EDD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public float Volume
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x99EE08", Offset = "0x99EE08", VA = "0x99EE08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x99EE2C", Offset = "0x99EE2C", VA = "0x99EE2C")]
			set
			{
			}
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x99EBE4", Offset = "0x99EBE4", VA = "0x99EBE4")]
		internal RoomChannel(ushort subscriptionId, string roomId, RoomChannels channels, ChannelProperties properties)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x99EE6C", Offset = "0x99EE6C", VA = "0x99EE6C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x99ECAC", Offset = "0x99ECAC", VA = "0x99ECAC")]
		private void CheckValidProperties()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x99EF7C", Offset = "0x99EF7C", VA = "0x99EF7C", Slot = "8")]
		public bool Equals(RoomChannel other)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x99EFA4", Offset = "0x99EFA4", VA = "0x99EFA4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x99F030", Offset = "0x99F030", VA = "0x99F030", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000032")]
	public sealed class RoomChannels : Channels<RoomChannel, string>
	{
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x99F144", Offset = "0x99F144", VA = "0x99F144")]
		internal RoomChannels([NotNull] IChannelPriorityProvider priorityProvider)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x99F304", Offset = "0x99F304", VA = "0x99F304", Slot = "4")]
		protected override RoomChannel CreateChannel(ushort subscriptionId, string channelId, ChannelProperties properties)
		{
			return default(RoomChannel);
		}
	}
	[Token(Token = "0x2000034")]
	public enum ChannelType
	{
		[Token(Token = "0x40000F5")]
		Room,
		[Token(Token = "0x40000F6")]
		Player
	}
	[Token(Token = "0x2000035")]
	public struct CodecSettings
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Codec _codec;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private readonly uint _frameSize;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int _sampleRate;

		[Token(Token = "0x17000042")]
		public Codec Codec
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x99F394", Offset = "0x99F394", VA = "0x99F394")]
			get
			{
				return default(Codec);
			}
		}

		[Token(Token = "0x17000043")]
		public uint FrameSize
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x99F39C", Offset = "0x99F39C", VA = "0x99F39C")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000044")]
		public int SampleRate
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x99F3A4", Offset = "0x99F3A4", VA = "0x99F3A4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x99F388", Offset = "0x99F388", VA = "0x99F388")]
		public CodecSettings(Codec codec, uint frameSize, int sampleRate)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x99F3AC", Offset = "0x99F3AC", VA = "0x99F3AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	internal class CodecSettingsLoader
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _started;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _settingsReady;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object _settingsWriteLock;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CodecSettings _config;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private AudioQuality _encoderQuality;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FrameSize _encoderFrameSize;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Codec _codec;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool _encodeFec;

		[Token(Token = "0x17000045")]
		public CodecSettings Config
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x99F4B0", Offset = "0x99F4B0", VA = "0x99F4B0")]
			get
			{
				return default(CodecSettings);
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x99F67C", Offset = "0x99F67C", VA = "0x99F67C")]
		public void Start(Codec codec = Codec.Opus)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x99F4CC", Offset = "0x99F4CC", VA = "0x99F4CC")]
		private void GenerateSettings()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x99F7AC", Offset = "0x99F7AC", VA = "0x99F7AC")]
		private static CodecSettings GetEncoderSettings(Codec codec, AudioQuality quality, FrameSize frameSize)
		{
			return default(CodecSettings);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x99F8E0", Offset = "0x99F8E0", VA = "0x99F8E0")]
		[NotNull]
		public IVoiceEncoder CreateEncoder()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x99FA98", Offset = "0x99FA98", VA = "0x99FA98", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x99FACC", Offset = "0x99FACC", VA = "0x99FACC")]
		public CodecSettingsLoader()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public enum CommActivationMode
	{
		[Token(Token = "0x4000104")]
		None,
		[Token(Token = "0x4000105")]
		VoiceActivation,
		[Token(Token = "0x4000106")]
		PushToTalk
	}
	[Token(Token = "0x2000038")]
	public enum CommTriggerTarget
	{
		[Token(Token = "0x4000108")]
		Room,
		[Token(Token = "0x4000109")]
		Player,
		[Token(Token = "0x400010A")]
		Self
	}
	[Token(Token = "0x2000039")]
	public class DissonanceException : Exception
	{
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x99E7C0", Offset = "0x99E7C0", VA = "0x99E7C0")]
		public DissonanceException(string message)
		{
		}
	}
	[Token(Token = "0x200003A")]
	public enum FrameSize
	{
		[Token(Token = "0x400010C")]
		Tiny = -1,
		[Token(Token = "0x400010D")]
		Small,
		[Token(Token = "0x400010E")]
		Medium,
		[Token(Token = "0x400010F")]
		Large
	}
	[Token(Token = "0x200003B")]
	internal struct FrameSkipDetector
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly float _maxFrameTime;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private readonly float _minimumBreakerDuration;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly float _maxBreakerDuration;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly float _breakerResetPerSecond;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float _breakerCloseTimer;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float _currentBreakerDuration;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _breakerClosed;

		[Token(Token = "0x17000046")]
		internal bool IsBreakerClosed
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x99FC18", Offset = "0x99FC18", VA = "0x99FC18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x99FC20", Offset = "0x99FC20", VA = "0x99FC20")]
		public FrameSkipDetector(TimeSpan maxFrameTime, TimeSpan minimumBreakerDuration, TimeSpan maxBreakerDuration, TimeSpan breakerResetPerSecond)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x99FCA0", Offset = "0x99FCA0", VA = "0x99FCA0")]
		public bool IsFrameSkip(float deltaTime)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x99FCDC", Offset = "0x99FCDC", VA = "0x99FCDC")]
		private void UpdateBreaker(bool skip, float dt)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public enum NetworkPlayerType
	{
		[Token(Token = "0x4000118")]
		Unknown,
		[Token(Token = "0x4000119")]
		Local,
		[Token(Token = "0x400011A")]
		Remote
	}
	[Token(Token = "0x200003D")]
	public interface IDissonancePlayer
	{
		[Token(Token = "0x17000047")]
		string PlayerId
		{
			[Token(Token = "0x6000238")]
			get;
		}

		[Token(Token = "0x17000048")]
		Vector3 Position
		{
			[Token(Token = "0x6000239")]
			get;
		}

		[Token(Token = "0x17000049")]
		Quaternion Rotation
		{
			[Token(Token = "0x600023A")]
			get;
		}

		[Token(Token = "0x1700004A")]
		NetworkPlayerType Type
		{
			[Token(Token = "0x600023B")]
			get;
		}

		[Token(Token = "0x1700004B")]
		bool IsTracking
		{
			[Token(Token = "0x600023C")]
			get;
		}
	}
	[Token(Token = "0x200003E")]
	internal interface ILossEstimator
	{
		[Token(Token = "0x1700004C")]
		float PacketLoss
		{
			[Token(Token = "0x600023D")]
			get;
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	internal sealed class CanBeNullAttribute : Attribute
	{
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x99FDB8", Offset = "0x99FDB8", VA = "0x99FDB8")]
		public CanBeNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate | AttributeTargets.GenericParameter)]
	internal sealed class NotNullAttribute : Attribute
	{
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x99FDC0", Offset = "0x99FDC0", VA = "0x99FDC0")]
		public NotNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class ItemNotNullAttribute : Attribute
	{
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x99FDC8", Offset = "0x99FDC8", VA = "0x99FDC8")]
		public ItemNotNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	internal sealed class ItemCanBeNullAttribute : Attribute
	{
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x99FDD0", Offset = "0x99FDD0", VA = "0x99FDD0")]
		public ItemCanBeNullAttribute()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
	internal sealed class StringFormatMethodAttribute : Attribute
	{
		[Token(Token = "0x1700004D")]
		[NotNull]
		public string FormatParameterName
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x99FE00", Offset = "0x99FE00", VA = "0x99FE00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x99FE08", Offset = "0x99FE08", VA = "0x99FE08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x99FDD8", Offset = "0x99FDD8", VA = "0x99FDD8")]
		public StringFormatMethodAttribute([NotNull] string formatParameterName)
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = true)]
	internal sealed class ValueProviderAttribute : Attribute
	{
		[Token(Token = "0x1700004E")]
		[NotNull]
		public string Name
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0x99FE38", Offset = "0x99FE38", VA = "0x99FE38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x99FE40", Offset = "0x99FE40", VA = "0x99FE40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x99FE10", Offset = "0x99FE10", VA = "0x99FE10")]
		public ValueProviderAttribute([NotNull] string name)
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class InvokerParameterNameAttribute : Attribute
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x99FE48", Offset = "0x99FE48", VA = "0x99FE48")]
		public InvokerParameterNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class NotifyPropertyChangedInvocatorAttribute : Attribute
	{
		[Token(Token = "0x1700004F")]
		[CanBeNull]
		public string ParameterName
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x99FE80", Offset = "0x99FE80", VA = "0x99FE80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x99FE88", Offset = "0x99FE88", VA = "0x99FE88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x99FE50", Offset = "0x99FE50", VA = "0x99FE50")]
		public NotifyPropertyChangedInvocatorAttribute()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x99FE58", Offset = "0x99FE58", VA = "0x99FE58")]
		public NotifyPropertyChangedInvocatorAttribute([NotNull] string parameterName)
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	internal sealed class ContractAnnotationAttribute : Attribute
	{
		[Token(Token = "0x17000050")]
		[NotNull]
		public string Contract
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x99FEF0", Offset = "0x99FEF0", VA = "0x99FEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x99FEF8", Offset = "0x99FEF8", VA = "0x99FEF8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool ForceFullStates
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x99FF00", Offset = "0x99FF00", VA = "0x99FF00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x99FF08", Offset = "0x99FF08", VA = "0x99FF08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x99FE90", Offset = "0x99FE90", VA = "0x99FE90")]
		public ContractAnnotationAttribute([NotNull] string contract)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x99FEBC", Offset = "0x99FEBC", VA = "0x99FEBC")]
		public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.All)]
	internal sealed class LocalizationRequiredAttribute : Attribute
	{
		[Token(Token = "0x17000052")]
		public bool Required
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x99FF60", Offset = "0x99FF60", VA = "0x99FF60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x99FF68", Offset = "0x99FF68", VA = "0x99FF68")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x99FF14", Offset = "0x99FF14", VA = "0x99FF14")]
		public LocalizationRequiredAttribute()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x99FF34", Offset = "0x99FF34", VA = "0x99FF34")]
		public LocalizationRequiredAttribute(bool required)
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	internal sealed class CannotApplyEqualityOperatorAttribute : Attribute
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x99FF74", Offset = "0x99FF74", VA = "0x99FF74")]
		public CannotApplyEqualityOperatorAttribute()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[BaseTypeRequired(typeof(Attribute))]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal sealed class BaseTypeRequiredAttribute : Attribute
	{
		[Token(Token = "0x17000053")]
		[NotNull]
		public Type BaseType
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x99FFA4", Offset = "0x99FFA4", VA = "0x99FFA4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x99FFAC", Offset = "0x99FFAC", VA = "0x99FFAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x99FF7C", Offset = "0x99FF7C", VA = "0x99FF7C")]
		public BaseTypeRequiredAttribute([NotNull] Type baseType)
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.All)]
	internal sealed class UsedImplicitlyAttribute : Attribute
	{
		[Token(Token = "0x17000054")]
		public ImplicitUseKindFlags UseKindFlags
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x9A005C", Offset = "0x9A005C", VA = "0x9A005C")]
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseKindFlags);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x9A0064", Offset = "0x9A0064", VA = "0x9A0064")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public ImplicitUseTargetFlags TargetFlags
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x9A006C", Offset = "0x9A006C", VA = "0x9A006C")]
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseTargetFlags);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x9A0074", Offset = "0x9A0074", VA = "0x9A0074")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x99FFB4", Offset = "0x99FFB4", VA = "0x99FFB4")]
		public UsedImplicitlyAttribute()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x9A0004", Offset = "0x9A0004", VA = "0x9A0004")]
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x9A0030", Offset = "0x9A0030", VA = "0x9A0030")]
		public UsedImplicitlyAttribute(ImplicitUseTargetFlags targetFlags)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x99FFD8", Offset = "0x99FFD8", VA = "0x99FFD8")]
		public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.GenericParameter)]
	internal sealed class MeansImplicitUseAttribute : Attribute
	{
		[Token(Token = "0x17000056")]
		[UsedImplicitly]
		public ImplicitUseKindFlags UseKindFlags
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x9A0124", Offset = "0x9A0124", VA = "0x9A0124")]
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseKindFlags);
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x9A012C", Offset = "0x9A012C", VA = "0x9A012C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000057")]
		[UsedImplicitly]
		public ImplicitUseTargetFlags TargetFlags
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x9A0134", Offset = "0x9A0134", VA = "0x9A0134")]
			[CompilerGenerated]
			get
			{
				return default(ImplicitUseTargetFlags);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x9A013C", Offset = "0x9A013C", VA = "0x9A013C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x9A007C", Offset = "0x9A007C", VA = "0x9A007C")]
		public MeansImplicitUseAttribute()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x9A00CC", Offset = "0x9A00CC", VA = "0x9A00CC")]
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x9A00F8", Offset = "0x9A00F8", VA = "0x9A00F8")]
		public MeansImplicitUseAttribute(ImplicitUseTargetFlags targetFlags)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x9A00A0", Offset = "0x9A00A0", VA = "0x9A00A0")]
		public MeansImplicitUseAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
		{
		}
	}
	[Token(Token = "0x200004D")]
	[Flags]
	internal enum ImplicitUseKindFlags
	{
		[Token(Token = "0x4000127")]
		Default = 7,
		[Token(Token = "0x4000128")]
		Access = 1,
		[Token(Token = "0x4000129")]
		Assign = 2,
		[Token(Token = "0x400012A")]
		InstantiatedWithFixedConstructorSignature = 4,
		[Token(Token = "0x400012B")]
		InstantiatedNoFixedConstructorSignature = 8
	}
	[Token(Token = "0x200004E")]
	[Flags]
	internal enum ImplicitUseTargetFlags
	{
		[Token(Token = "0x400012D")]
		Default = 1,
		[Token(Token = "0x400012E")]
		Itself = 1,
		[Token(Token = "0x400012F")]
		Members = 2,
		[Token(Token = "0x4000130")]
		WithMembers = 3
	}
	[Token(Token = "0x200004F")]
	[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
	internal sealed class PublicAPIAttribute : Attribute
	{
		[Token(Token = "0x17000058")]
		[CanBeNull]
		public string Comment
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x9A0174", Offset = "0x9A0174", VA = "0x9A0174")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x9A017C", Offset = "0x9A017C", VA = "0x9A017C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x9A0144", Offset = "0x9A0144", VA = "0x9A0144")]
		public PublicAPIAttribute()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x9A014C", Offset = "0x9A014C", VA = "0x9A014C")]
		public PublicAPIAttribute([NotNull] string comment)
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class InstantHandleAttribute : Attribute
	{
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x9A0184", Offset = "0x9A0184", VA = "0x9A0184")]
		public InstantHandleAttribute()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class PureAttribute : Attribute
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x9A018C", Offset = "0x9A018C", VA = "0x9A018C")]
		public PureAttribute()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class MustUseReturnValueAttribute : Attribute
	{
		[Token(Token = "0x17000059")]
		[CanBeNull]
		public string Justification
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x9A01C4", Offset = "0x9A01C4", VA = "0x9A01C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x9A01CC", Offset = "0x9A01CC", VA = "0x9A01CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x9A0194", Offset = "0x9A0194", VA = "0x9A0194")]
		public MustUseReturnValueAttribute()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x9A019C", Offset = "0x9A019C", VA = "0x9A019C")]
		public MustUseReturnValueAttribute([NotNull] string justification)
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.GenericParameter)]
	internal sealed class ProvidesContextAttribute : Attribute
	{
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x9A01D4", Offset = "0x9A01D4", VA = "0x9A01D4")]
		public ProvidesContextAttribute()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class PathReferenceAttribute : Attribute
	{
		[Token(Token = "0x1700005A")]
		[CanBeNull]
		public string BasePath
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0x9A020C", Offset = "0x9A020C", VA = "0x9A020C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0x9A0214", Offset = "0x9A0214", VA = "0x9A0214")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x9A01DC", Offset = "0x9A01DC", VA = "0x9A01DC")]
		public PathReferenceAttribute()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x9A01E4", Offset = "0x9A01E4", VA = "0x9A01E4")]
		public PathReferenceAttribute([NotNull][PathReference] string basePath)
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class SourceTemplateAttribute : Attribute
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x9A021C", Offset = "0x9A021C", VA = "0x9A021C")]
		public SourceTemplateAttribute()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = true)]
	internal sealed class MacroAttribute : Attribute
	{
		[Token(Token = "0x1700005B")]
		[CanBeNull]
		public string Expression
		{
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x9A0224", Offset = "0x9A0224", VA = "0x9A0224")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x9A022C", Offset = "0x9A022C", VA = "0x9A022C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public int Editable
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x9A0234", Offset = "0x9A0234", VA = "0x9A0234")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x9A023C", Offset = "0x9A023C", VA = "0x9A023C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		[CanBeNull]
		public string Target
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x9A0244", Offset = "0x9A0244", VA = "0x9A0244")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000280")]
			[Address(RVA = "0x9A024C", Offset = "0x9A024C", VA = "0x9A024C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x9A0254", Offset = "0x9A0254", VA = "0x9A0254")]
		public MacroAttribute()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcAreaMasterLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x1700005E")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x9A0284", Offset = "0x9A0284", VA = "0x9A0284")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x9A028C", Offset = "0x9A028C", VA = "0x9A028C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x9A025C", Offset = "0x9A025C", VA = "0x9A025C")]
		public AspMvcAreaMasterLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcAreaPartialViewLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x1700005F")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x9A02BC", Offset = "0x9A02BC", VA = "0x9A02BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x9A02C4", Offset = "0x9A02C4", VA = "0x9A02C4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x9A0294", Offset = "0x9A0294", VA = "0x9A0294")]
		public AspMvcAreaPartialViewLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcAreaViewLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x17000060")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x9A02F4", Offset = "0x9A02F4", VA = "0x9A02F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x9A02FC", Offset = "0x9A02FC", VA = "0x9A02FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x9A02CC", Offset = "0x9A02CC", VA = "0x9A02CC")]
		public AspMvcAreaViewLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcMasterLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x17000061")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x9A032C", Offset = "0x9A032C", VA = "0x9A032C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x9A0334", Offset = "0x9A0334", VA = "0x9A0334")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9A0304", Offset = "0x9A0304", VA = "0x9A0304")]
		public AspMvcMasterLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcPartialViewLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x17000062")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x9A0364", Offset = "0x9A0364", VA = "0x9A0364")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x9A036C", Offset = "0x9A036C", VA = "0x9A036C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x9A033C", Offset = "0x9A033C", VA = "0x9A033C")]
		public AspMvcPartialViewLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
	internal sealed class AspMvcViewLocationFormatAttribute : Attribute
	{
		[Token(Token = "0x17000063")]
		[NotNull]
		public string Format
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x9A039C", Offset = "0x9A039C", VA = "0x9A039C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x9A03A4", Offset = "0x9A03A4", VA = "0x9A03A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x9A0374", Offset = "0x9A0374", VA = "0x9A0374")]
		public AspMvcViewLocationFormatAttribute([NotNull] string format)
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class AspMvcActionAttribute : Attribute
	{
		[Token(Token = "0x17000064")]
		[CanBeNull]
		public string AnonymousProperty
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x9A03DC", Offset = "0x9A03DC", VA = "0x9A03DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x9A03E4", Offset = "0x9A03E4", VA = "0x9A03E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x9A03AC", Offset = "0x9A03AC", VA = "0x9A03AC")]
		public AspMvcActionAttribute()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x9A03B4", Offset = "0x9A03B4", VA = "0x9A03B4")]
		public AspMvcActionAttribute([NotNull] string anonymousProperty)
		{
		}
	}
	[Token(Token = "0x200005E")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcAreaAttribute : Attribute
	{
		[Token(Token = "0x17000065")]
		[CanBeNull]
		public string AnonymousProperty
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x9A041C", Offset = "0x9A041C", VA = "0x9A041C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x9A0424", Offset = "0x9A0424", VA = "0x9A0424")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x9A03EC", Offset = "0x9A03EC", VA = "0x9A03EC")]
		public AspMvcAreaAttribute()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9A03F4", Offset = "0x9A03F4", VA = "0x9A03F4")]
		public AspMvcAreaAttribute([NotNull] string anonymousProperty)
		{
		}
	}
	[Token(Token = "0x200005F")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class AspMvcControllerAttribute : Attribute
	{
		[Token(Token = "0x17000066")]
		[CanBeNull]
		public string AnonymousProperty
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x9A045C", Offset = "0x9A045C", VA = "0x9A045C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x9A0464", Offset = "0x9A0464", VA = "0x9A0464")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9A042C", Offset = "0x9A042C", VA = "0x9A042C")]
		public AspMvcControllerAttribute()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9A0434", Offset = "0x9A0434", VA = "0x9A0434")]
		public AspMvcControllerAttribute([NotNull] string anonymousProperty)
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcMasterAttribute : Attribute
	{
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9A046C", Offset = "0x9A046C", VA = "0x9A046C")]
		public AspMvcMasterAttribute()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcModelTypeAttribute : Attribute
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9A0474", Offset = "0x9A0474", VA = "0x9A0474")]
		public AspMvcModelTypeAttribute()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class AspMvcPartialViewAttribute : Attribute
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9A047C", Offset = "0x9A047C", VA = "0x9A047C")]
		public AspMvcPartialViewAttribute()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	internal sealed class AspMvcSuppressViewErrorAttribute : Attribute
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9A0484", Offset = "0x9A0484", VA = "0x9A0484")]
		public AspMvcSuppressViewErrorAttribute()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcDisplayTemplateAttribute : Attribute
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9A048C", Offset = "0x9A048C", VA = "0x9A048C")]
		public AspMvcDisplayTemplateAttribute()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcEditorTemplateAttribute : Attribute
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9A0494", Offset = "0x9A0494", VA = "0x9A0494")]
		public AspMvcEditorTemplateAttribute()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcTemplateAttribute : Attribute
	{
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9A049C", Offset = "0x9A049C", VA = "0x9A049C")]
		public AspMvcTemplateAttribute()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class AspMvcViewAttribute : Attribute
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9A04A4", Offset = "0x9A04A4", VA = "0x9A04A4")]
		public AspMvcViewAttribute()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AspMvcViewComponentAttribute : Attribute
	{
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9A04AC", Offset = "0x9A04AC", VA = "0x9A04AC")]
		public AspMvcViewComponentAttribute()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class AspMvcViewComponentViewAttribute : Attribute
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x9A04B4", Offset = "0x9A04B4", VA = "0x9A04B4")]
		public AspMvcViewComponentViewAttribute()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter)]
	internal sealed class AspMvcActionSelectorAttribute : Attribute
	{
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9A04BC", Offset = "0x9A04BC", VA = "0x9A04BC")]
		public AspMvcActionSelectorAttribute()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal sealed class HtmlElementAttributesAttribute : Attribute
	{
		[Token(Token = "0x17000067")]
		[CanBeNull]
		public string Name
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x9A04F4", Offset = "0x9A04F4", VA = "0x9A04F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x9A04FC", Offset = "0x9A04FC", VA = "0x9A04FC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x9A04C4", Offset = "0x9A04C4", VA = "0x9A04C4")]
		public HtmlElementAttributesAttribute()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x9A04CC", Offset = "0x9A04CC", VA = "0x9A04CC")]
		public HtmlElementAttributesAttribute([NotNull] string name)
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
	internal sealed class HtmlAttributeValueAttribute : Attribute
	{
		[Token(Token = "0x17000068")]
		[NotNull]
		public string Name
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x9A052C", Offset = "0x9A052C", VA = "0x9A052C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x9A0534", Offset = "0x9A0534", VA = "0x9A0534")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x9A0504", Offset = "0x9A0504", VA = "0x9A0504")]
		public HtmlAttributeValueAttribute([NotNull] string name)
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter)]
	internal sealed class RazorSectionAttribute : Attribute
	{
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x9A053C", Offset = "0x9A053C", VA = "0x9A053C")]
		public RazorSectionAttribute()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	internal sealed class CollectionAccessAttribute : Attribute
	{
		[Token(Token = "0x17000069")]
		public CollectionAccessType CollectionAccessType
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x9A056C", Offset = "0x9A056C", VA = "0x9A056C")]
			[CompilerGenerated]
			get
			{
				return default(CollectionAccessType);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x9A0574", Offset = "0x9A0574", VA = "0x9A0574")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x9A0544", Offset = "0x9A0544", VA = "0x9A0544")]
		public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		{
		}
	}
	[Token(Token = "0x200006F")]
	[Flags]
	internal enum CollectionAccessType
	{
		[Token(Token = "0x4000144")]
		None = 0,
		[Token(Token = "0x4000145")]
		Read = 1,
		[Token(Token = "0x4000146")]
		ModifyExistingContent = 2,
		[Token(Token = "0x4000147")]
		UpdatedContent = 6
	}
	[Token(Token = "0x2000070")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class AssertionMethodAttribute : Attribute
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9A057C", Offset = "0x9A057C", VA = "0x9A057C")]
		public AssertionMethodAttribute()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class AssertionConditionAttribute : Attribute
	{
		[Token(Token = "0x1700006A")]
		public AssertionConditionType ConditionType
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x9A05AC", Offset = "0x9A05AC", VA = "0x9A05AC")]
			[CompilerGenerated]
			get
			{
				return default(AssertionConditionType);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x9A05B4", Offset = "0x9A05B4", VA = "0x9A05B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x9A0584", Offset = "0x9A0584", VA = "0x9A0584")]
		public AssertionConditionAttribute(AssertionConditionType conditionType)
		{
		}
	}
	[Token(Token = "0x2000072")]
	internal enum AssertionConditionType
	{
		[Token(Token = "0x400014A")]
		IS_TRUE,
		[Token(Token = "0x400014B")]
		IS_FALSE,
		[Token(Token = "0x400014C")]
		IS_NULL,
		[Token(Token = "0x400014D")]
		IS_NOT_NULL
	}
	[Token(Token = "0x2000073")]
	[AttributeUsage(AttributeTargets.Method)]
	[Obsolete("Use [ContractAnnotation('=> halt')] instead")]
	internal sealed class TerminatesProgramAttribute : Attribute
	{
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x9A05BC", Offset = "0x9A05BC", VA = "0x9A05BC")]
		public TerminatesProgramAttribute()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class LinqTunnelAttribute : Attribute
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x9A05C4", Offset = "0x9A05C4", VA = "0x9A05C4")]
		public LinqTunnelAttribute()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class NoEnumerationAttribute : Attribute
	{
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x9A05CC", Offset = "0x9A05CC", VA = "0x9A05CC")]
		public NoEnumerationAttribute()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class RegexPatternAttribute : Attribute
	{
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x9A05D4", Offset = "0x9A05D4", VA = "0x9A05D4")]
		public RegexPatternAttribute()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	internal sealed class NoReorderAttribute : Attribute
	{
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x9A05DC", Offset = "0x9A05DC", VA = "0x9A05DC")]
		public NoReorderAttribute()
		{
		}
	}
	[Token(Token = "0x2000078")]
	[AttributeUsage(AttributeTargets.Class)]
	internal sealed class XamlItemsControlAttribute : Attribute
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x9A05E4", Offset = "0x9A05E4", VA = "0x9A05E4")]
		public XamlItemsControlAttribute()
		{
		}
	}
	[Token(Token = "0x2000079")]
	[AttributeUsage(AttributeTargets.Property)]
	internal sealed class XamlItemBindingOfItemsControlAttribute : Attribute
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x9A05EC", Offset = "0x9A05EC", VA = "0x9A05EC")]
		public XamlItemBindingOfItemsControlAttribute()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal sealed class AspChildControlTypeAttribute : Attribute
	{
		[Token(Token = "0x1700006B")]
		[NotNull]
		public string TagName
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x9A0620", Offset = "0x9A0620", VA = "0x9A0620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x9A0628", Offset = "0x9A0628", VA = "0x9A0628")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		[NotNull]
		public Type ControlType
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x9A0630", Offset = "0x9A0630", VA = "0x9A0630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x9A0638", Offset = "0x9A0638", VA = "0x9A0638")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x9A05F4", Offset = "0x9A05F4", VA = "0x9A05F4")]
		public AspChildControlTypeAttribute([NotNull] string tagName, [NotNull] Type controlType)
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	internal sealed class AspDataFieldAttribute : Attribute
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x9A0640", Offset = "0x9A0640", VA = "0x9A0640")]
		public AspDataFieldAttribute()
		{
		}
	}
	[Token(Token = "0x200007C")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	internal sealed class AspDataFieldsAttribute : Attribute
	{
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x9A0648", Offset = "0x9A0648", VA = "0x9A0648")]
		public AspDataFieldsAttribute()
		{
		}
	}
	[Token(Token = "0x200007D")]
	[AttributeUsage(AttributeTargets.Property)]
	internal sealed class AspMethodPropertyAttribute : Attribute
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x9A0650", Offset = "0x9A0650", VA = "0x9A0650")]
		public AspMethodPropertyAttribute()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	internal sealed class AspRequiredAttributeAttribute : Attribute
	{
		[Token(Token = "0x1700006D")]
		[NotNull]
		public string Attribute
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x9A0680", Offset = "0x9A0680", VA = "0x9A0680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x9A0688", Offset = "0x9A0688", VA = "0x9A0688")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9A0658", Offset = "0x9A0658", VA = "0x9A0658")]
		public AspRequiredAttributeAttribute([NotNull] string attribute)
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeUsage(AttributeTargets.Property)]
	internal sealed class AspTypePropertyAttribute : Attribute
	{
		[Token(Token = "0x1700006E")]
		public bool CreateConstructorReferences
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x9A0690", Offset = "0x9A0690", VA = "0x9A0690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x9A0698", Offset = "0x9A0698", VA = "0x9A0698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9A06A4", Offset = "0x9A06A4", VA = "0x9A06A4")]
		public AspTypePropertyAttribute(bool createConstructorReferences)
		{
		}
	}
	[Token(Token = "0x2000080")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal sealed class RazorImportNamespaceAttribute : Attribute
	{
		[Token(Token = "0x1700006F")]
		[NotNull]
		public string Name
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x9A06F8", Offset = "0x9A06F8", VA = "0x9A06F8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x9A0700", Offset = "0x9A0700", VA = "0x9A0700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x9A06D0", Offset = "0x9A06D0", VA = "0x9A06D0")]
		public RazorImportNamespaceAttribute([NotNull] string name)
		{
		}
	}
	[Token(Token = "0x2000081")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal sealed class RazorInjectionAttribute : Attribute
	{
		[Token(Token = "0x17000070")]
		[NotNull]
		public string Type
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x9A0734", Offset = "0x9A0734", VA = "0x9A0734")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x9A073C", Offset = "0x9A073C", VA = "0x9A073C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000071")]
		[NotNull]
		public string FieldName
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x9A0744", Offset = "0x9A0744", VA = "0x9A0744")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x9A074C", Offset = "0x9A074C", VA = "0x9A074C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x9A0708", Offset = "0x9A0708", VA = "0x9A0708")]
		public RazorInjectionAttribute([NotNull] string type, [NotNull] string fieldName)
		{
		}
	}
	[Token(Token = "0x2000082")]
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
	internal sealed class RazorDirectiveAttribute : Attribute
	{
		[Token(Token = "0x17000072")]
		[NotNull]
		public string Directive
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x9A077C", Offset = "0x9A077C", VA = "0x9A077C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D9")]
			[Address(RVA = "0x9A0784", Offset = "0x9A0784", VA = "0x9A0784")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x9A0754", Offset = "0x9A0754", VA = "0x9A0754")]
		public RazorDirectiveAttribute([NotNull] string directive)
		{
		}
	}
	[Token(Token = "0x2000083")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class RazorHelperCommonAttribute : Attribute
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x9A078C", Offset = "0x9A078C", VA = "0x9A078C")]
		public RazorHelperCommonAttribute()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeUsage(AttributeTargets.Property)]
	internal sealed class RazorLayoutAttribute : Attribute
	{
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x9A0794", Offset = "0x9A0794", VA = "0x9A0794")]
		public RazorLayoutAttribute()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class RazorWriteLiteralMethodAttribute : Attribute
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x9A079C", Offset = "0x9A079C", VA = "0x9A079C")]
		public RazorWriteLiteralMethodAttribute()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class RazorWriteMethodAttribute : Attribute
	{
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x9A07A4", Offset = "0x9A07A4", VA = "0x9A07A4")]
		public RazorWriteMethodAttribute()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeUsage(AttributeTargets.Parameter)]
	internal sealed class RazorWriteMethodParameterAttribute : Attribute
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x9A07AC", Offset = "0x9A07AC", VA = "0x9A07AC")]
		public RazorWriteMethodParameterAttribute()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public static class Logs
	{
		[Token(Token = "0x2000089")]
		private struct LogMessage
		{
			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LogLevel _level;

			[Token(Token = "0x400015A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly string _message;

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x9A0E00", Offset = "0x9A0E00", VA = "0x9A0E00")]
			public LogMessage(string message, LogLevel level)
			{
			}

			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x9A0CDC", Offset = "0x9A0CDC", VA = "0x9A0CDC")]
			public void Log()
			{
			}
		}

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action m_actionFailConnectMic;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly TransferBuffer<LogMessage> LogsFromOtherThreads;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Thread _main;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x99D3A0", Offset = "0x99D3A0", VA = "0x99D3A0")]
		[NotNull]
		public static Log Create(LogCategory category, string name)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x9A07B4", Offset = "0x9A07B4", VA = "0x9A07B4")]
		[NotNull]
		public static Log Create(int category, string name)
		{
			return null;
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x9A0A54", Offset = "0x9A0A54", VA = "0x9A0A54")]
		public static void SetLogLevel(LogCategory category, LogLevel level)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x9A0AB8", Offset = "0x9A0AB8", VA = "0x9A0AB8")]
		public static void SetLogLevel(int category, LogLevel level)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x9A0B30", Offset = "0x9A0B30", VA = "0x9A0B30")]
		public static LogLevel GetLogLevel(LogCategory category)
		{
			return default(LogLevel);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x9A0B84", Offset = "0x9A0B84", VA = "0x9A0B84")]
		public static LogLevel GetLogLevel(int category)
		{
			return default(LogLevel);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x9A0BEC", Offset = "0x9A0BEC", VA = "0x9A0BEC")]
		internal static void WriteMultithreadedLogs()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x9A0DDC", Offset = "0x9A0DDC", VA = "0x9A0DDC")]
		internal static void SendLogMessage(string message, LogLevel level)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class Log
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _traceFormat;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _debugFormat;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _basicFormat;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly int _category;

		[Token(Token = "0x17000073")]
		public bool IsTrace
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x9A0EA8", Offset = "0x9A0EA8", VA = "0x9A0EA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public bool IsDebug
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x9A0F20", Offset = "0x9A0F20", VA = "0x9A0F20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public bool IsInfo
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x9A0F28", Offset = "0x9A0F28", VA = "0x9A0F28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000076")]
		public bool IsWarn
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x9A0F30", Offset = "0x9A0F30", VA = "0x9A0F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000077")]
		public bool IsError
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x9A0F38", Offset = "0x9A0F38", VA = "0x9A0F38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x9A0824", Offset = "0x9A0824", VA = "0x9A0824")]
		internal Log(int category, string name)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x9A0EB0", Offset = "0x9A0EB0", VA = "0x9A0EB0")]
		[DebuggerHidden]
		private bool ShouldLog(LogLevel level)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x9A0F40", Offset = "0x9A0F40", VA = "0x9A0F40")]
		public void FailConnectMic()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x9A0FAC", Offset = "0x9A0FAC", VA = "0x9A0FAC")]
		[DebuggerHidden]
		private void WriteLog(LogLevel level, string message)
		{
		}

		[Token(Token = "0x60002F3")]
		[DebuggerHidden]
		private void WriteLogFormat<TA>(LogLevel level, string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x60002F4")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x60002F5")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2)
		{
		}

		[Token(Token = "0x60002F6")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC, TD>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3)
		{
		}

		[Token(Token = "0x60002F7")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC, TD, TE>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4)
		{
		}

		[Token(Token = "0x60002F8")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC, TD, TE, TF>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5)
		{
		}

		[Token(Token = "0x60002F9")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC, TD, TE, TF, TG>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5, [CanBeNull] TG p6)
		{
		}

		[Token(Token = "0x60002FA")]
		[DebuggerHidden]
		private void WriteLogFormat<TA, TB, TC, TD, TE, TF, TG, TH>(LogLevel level, string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5, [CanBeNull] TG p6, [CanBeNull] TH p7)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x9A1130", Offset = "0x9A1130", VA = "0x9A1130")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Trace(string message)
		{
		}

		[Token(Token = "0x60002FC")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Trace<TA>(string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x60002FD")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Trace<TA, TB>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x9A113C", Offset = "0x9A113C", VA = "0x9A113C")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Debug(string message)
		{
		}

		[Token(Token = "0x60002FF")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Debug<TA>(string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x6000300")]
		[Conditional("DEBUG")]
		[DebuggerHidden]
		public void Debug<TA, TB>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x6000301")]
		[Conditional("DEBUG")]
		[DebuggerHidden]
		public void Debug<TA, TB, TC>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2)
		{
		}

		[Token(Token = "0x6000302")]
		[Conditional("DEBUG")]
		[DebuggerHidden]
		public void Debug<TA, TB, TC, TD>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3)
		{
		}

		[Token(Token = "0x6000303")]
		[Conditional("DEBUG")]
		[DebuggerHidden]
		public void Debug<TA, TB, TC, TD, TE>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4)
		{
		}

		[Token(Token = "0x6000304")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Debug<TA, TB, TC, TD, TE, TF>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5)
		{
		}

		[Token(Token = "0x6000305")]
		[DebuggerHidden]
		[Conditional("DEBUG")]
		public void Debug<TA, TB, TC, TD, TE, TF, TG>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5, [CanBeNull] TG p6)
		{
		}

		[Token(Token = "0x6000306")]
		[Conditional("DEBUG")]
		[DebuggerHidden]
		public void Debug<TA, TB, TC, TD, TE, TF, TG, TH>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4, [CanBeNull] TF p5, [CanBeNull] TG p6, [CanBeNull] TH p7)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x9A1148", Offset = "0x9A1148", VA = "0x9A1148")]
		[DebuggerHidden]
		public void Info(string message)
		{
		}

		[Token(Token = "0x6000308")]
		[DebuggerHidden]
		public void Info<TA>(string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x6000309")]
		[DebuggerHidden]
		public void Info<TA, TB>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x600030A")]
		[DebuggerHidden]
		public void Info<TA, TB, TC>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2)
		{
		}

		[Token(Token = "0x600030B")]
		[DebuggerHidden]
		public void Info<TA, TB, TC, TD>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3)
		{
		}

		[Token(Token = "0x600030C")]
		[DebuggerHidden]
		public void Info<TA, TB, TC, TD, TE>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x9A1154", Offset = "0x9A1154", VA = "0x9A1154")]
		[DebuggerHidden]
		public void Warn(string message)
		{
		}

		[Token(Token = "0x600030E")]
		[DebuggerHidden]
		public void Warn<TA>(string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x600030F")]
		[DebuggerHidden]
		public void Warn<TA, TB>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x6000310")]
		[DebuggerHidden]
		public void Warn<TA, TB, TC>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2)
		{
		}

		[Token(Token = "0x6000311")]
		[DebuggerHidden]
		public void Warn<TA, TB, TC, TD>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3)
		{
		}

		[Token(Token = "0x6000312")]
		[DebuggerHidden]
		public void Warn<TA, TB, TC, TD, TE>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2, [CanBeNull] TD p3, [CanBeNull] TE p4)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x99E394", Offset = "0x99E394", VA = "0x99E394")]
		[DebuggerHidden]
		public void Error(string message)
		{
		}

		[Token(Token = "0x6000314")]
		[DebuggerHidden]
		public void Error<TA>(string format, [CanBeNull] TA p0)
		{
		}

		[Token(Token = "0x6000315")]
		[DebuggerHidden]
		public void Error<TA, TB>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1)
		{
		}

		[Token(Token = "0x6000316")]
		[DebuggerHidden]
		public void Error<TA, TB, TC>(string format, [CanBeNull] TA p0, [CanBeNull] TB p1, [CanBeNull] TC p2)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x99EEDC", Offset = "0x99EEDC", VA = "0x99EEDC")]
		[NotNull]
		[DebuggerHidden]
		public DissonanceException CreateUserErrorException(string problem, string likelyCause, string documentationLink, string guid)
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x99E1E4", Offset = "0x99E1E4", VA = "0x99E1E4")]
		[NotNull]
		[DebuggerHidden]
		public string UserErrorMessage(string problem, string likelyCause, string documentationLink, string guid)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x9A1160", Offset = "0x9A1160", VA = "0x9A1160")]
		[NotNull]
		[DebuggerHidden]
		public string PossibleBugMessage(string problem, string guid)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x99F72C", Offset = "0x99F72C", VA = "0x99F72C")]
		[DebuggerHidden]
		[NotNull]
		public DissonanceException CreatePossibleBugException(string problem, string guid)
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[DebuggerHidden]
		[NotNull]
		public Exception CreatePossibleBugException<T>([NotNull] Func<string, T> factory, string problem, string guid) where T : Exception
		{
			return null;
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x9A11BC", Offset = "0x9A11BC", VA = "0x9A11BC")]
		[ContractAnnotation("assertion:true => false; assertion:false => true")]
		public bool AssertAndLogWarn(bool assertion, string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[ContractAnnotation("assertion:true => false; assertion:false => true")]
		public bool AssertAndLogWarn<TA>(bool assertion, string format, TA arg0)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x9A11E0", Offset = "0x9A11E0", VA = "0x9A11E0")]
		[ContractAnnotation("assertion:true => false; assertion:false => true")]
		public bool AssertAndLogError(bool assertion, string guid, string msg)
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[ContractAnnotation("assertion:true => false; assertion:false => true")]
		public bool AssertAndLogError<TA>(bool assertion, string guid, string format, TA arg0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x9A1220", Offset = "0x9A1220", VA = "0x9A1220")]
		[ContractAnnotation("assertion:false => halt")]
		public void AssertAndThrowPossibleBug(bool assertion, string guid, string msg)
		{
		}

		[Token(Token = "0x6000321")]
		[ContractAnnotation("assertion:false => halt")]
		public void AssertAndThrowPossibleBug<TA>(bool assertion, string guid, string format, TA arg0)
		{
		}

		[Token(Token = "0x6000322")]
		[ContractAnnotation("assertion:false => halt")]
		public void AssertAndThrowPossibleBug<TA, TB>(bool assertion, string guid, string format, TA arg0, TB arg1)
		{
		}

		[Token(Token = "0x6000323")]
		[ContractAnnotation("assertion:false => halt")]
		public void AssertAndThrowPossibleBug<TA, TB, TC>(bool assertion, string guid, string format, TA arg0, TB arg1, TC arg2)
		{
		}
	}
	[Token(Token = "0x200008B")]
	public enum LogCategory
	{
		[Token(Token = "0x4000160")]
		Core,
		[Token(Token = "0x4000161")]
		Recording,
		[Token(Token = "0x4000162")]
		Network,
		[Token(Token = "0x4000163")]
		Playback
	}
	[Token(Token = "0x200008C")]
	public enum LogLevel
	{
		[Token(Token = "0x4000165")]
		Trace,
		[Token(Token = "0x4000166")]
		Debug,
		[Token(Token = "0x4000167")]
		Info,
		[Token(Token = "0x4000168")]
		Warn,
		[Token(Token = "0x4000169")]
		Error
	}
	[Token(Token = "0x200008D")]
	internal class PacketLossMonitor
	{
		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ReadOnlyCollection<VoicePlayerState> _players;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DateTime _lastUpdatedPacketLoss;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _lastUpdatedPlayerCount;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<float> _tmpLossValues;

		[Token(Token = "0x17000078")]
		public float PacketLoss
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x9A1250", Offset = "0x9A1250", VA = "0x9A1250")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x9A1258", Offset = "0x9A1258", VA = "0x9A1258")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x9A1260", Offset = "0x9A1260", VA = "0x9A1260")]
		public PacketLossMonitor(ReadOnlyCollection<VoicePlayerState> players)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x9A132C", Offset = "0x9A132C", VA = "0x9A132C")]
		public void Update([Optional] DateTime? utcNow)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x9A1440", Offset = "0x9A1440", VA = "0x9A1440")]
		private bool CheckTime(DateTime now)
		{
			return default(bool);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x9A14F4", Offset = "0x9A14F4", VA = "0x9A14F4")]
		private bool CheckCount()
		{
			return default(bool);
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x9A1554", Offset = "0x9A1554", VA = "0x9A1554")]
		private float? CalculatePacketLoss()
		{
			return null;
		}
	}
	[Token(Token = "0x200008E")]
	internal class PlaybackPool
	{
		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Pool<VoicePlayback> _pool;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NotNull]
		private readonly IPriorityManager _priority;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NotNull]
		private readonly IVolumeProvider _volume;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _prefab;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _parent;

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x9A1818", Offset = "0x9A1818", VA = "0x9A1818")]
		public PlaybackPool([NotNull] IPriorityManager priority, [NotNull] IVolumeProvider volume)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x9A1974", Offset = "0x9A1974", VA = "0x9A1974")]
		public void Start([NotNull] GameObject playbackPrefab, [NotNull] Transform transform)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x9A1A80", Offset = "0x9A1A80", VA = "0x9A1A80")]
		[NotNull]
		private VoicePlayback CreatePlayback()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x9A1CE0", Offset = "0x9A1CE0", VA = "0x9A1CE0")]
		[NotNull]
		public VoicePlayback Get([NotNull] string playerId)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x9A1DEC", Offset = "0x9A1DEC", VA = "0x9A1DEC")]
		public void Put([NotNull] VoicePlayback playback)
		{
		}
	}
	[Token(Token = "0x200008F")]
	internal class PlayerCollection
	{
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, VoicePlayerState> _playersLookup;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<VoicePlayerState> _players;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ReadOnlyCollection<VoicePlayerState> _playersReadOnly;

		[Token(Token = "0x17000079")]
		[NotNull]
		public ReadOnlyCollection<VoicePlayerState> Readonly
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x9A1F30", Offset = "0x9A1F30", VA = "0x9A1F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public LocalVoicePlayerState Local
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x9A1F38", Offset = "0x9A1F38", VA = "0x9A1F38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x9A1F40", Offset = "0x9A1F40", VA = "0x9A1F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x9A1F48", Offset = "0x9A1F48", VA = "0x9A1F48")]
		public PlayerCollection()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x9A2058", Offset = "0x9A2058", VA = "0x9A2058")]
		public void Start([NotNull] string name, [NotNull] IAmplitudeProvider micAmplitude, [NotNull] Rooms rooms, [NotNull] RoomChannels roomChannels, [NotNull] PlayerChannels playerChannels, [NotNull] ILossEstimator loss, [NotNull] ICommsNetwork net)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x9A24D8", Offset = "0x9A24D8", VA = "0x9A24D8")]
		public void Add([NotNull] VoicePlayerState state)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x9A2680", Offset = "0x9A2680", VA = "0x9A2680")]
		[CanBeNull]
		public VoicePlayerState Remove([NotNull] string playerId)
		{
			return null;
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9A27F0", Offset = "0x9A27F0", VA = "0x9A27F0")]
		public bool TryGet([NotNull] string playerId, [NotNull] out VoicePlayerState state)
		{
			return default(bool);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9A28A8", Offset = "0x9A28A8", VA = "0x9A28A8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000090")]
	internal class PlayerTrackerManager
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IDissonancePlayer> _unlinkedPlayerTrackers;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PlayerCollection _players;

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9A2A18", Offset = "0x9A2A18", VA = "0x9A2A18")]
		public PlayerTrackerManager([NotNull] PlayerCollection players)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9A2AF8", Offset = "0x9A2AF8", VA = "0x9A2AF8")]
		public void AddPlayer([NotNull] VoicePlayerState state)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9A2C0C", Offset = "0x9A2C0C", VA = "0x9A2C0C")]
		public void RemovePlayer([NotNull] VoicePlayerState state)
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9A2D70", Offset = "0x9A2D70", VA = "0x9A2D70")]
		public void AddTracker([NotNull] IDissonancePlayer player)
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9A2F44", Offset = "0x9A2F44", VA = "0x9A2F44")]
		public void RemoveTracker([NotNull] IDissonancePlayer player)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public static class RoomIdConversion
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x9A31F0", Offset = "0x9A31F0", VA = "0x9A31F0")]
		public static ushort ToRoomId([NotNull] this string name)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9A326C", Offset = "0x9A326C", VA = "0x9A326C")]
		private static ushort Hash16([NotNull] string str)
		{
			return default(ushort);
		}
	}
	[Token(Token = "0x2000092")]
	public sealed class Rooms
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly RoomMembershipComparer Comparer;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<RoomMembership> _rooms;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _roomNames;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ReadOnlyCollection<string> _roomNamesReadonly;

		[Token(Token = "0x1700007B")]
		internal ReadOnlyCollection<string> Memberships
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x9A3298", Offset = "0x9A3298", VA = "0x9A3298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public int Count
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x9A366C", Offset = "0x9A366C", VA = "0x9A366C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007D")]
		internal RoomMembership this[int i]
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x9A36B4", Offset = "0x9A36B4", VA = "0x9A36B4")]
			get
			{
				return default(RoomMembership);
			}
		}

		[Token(Token = "0x14000003")]
		public event Action<string> JoinedRoom
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x9A32A0", Offset = "0x9A32A0", VA = "0x9A32A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x9A3350", Offset = "0x9A3350", VA = "0x9A3350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<string> LeftRoom
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x9A3400", Offset = "0x9A3400", VA = "0x9A3400")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x9A34B0", Offset = "0x9A34B0", VA = "0x9A34B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9A3560", Offset = "0x9A3560", VA = "0x9A3560")]
		internal Rooms()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x9A370C", Offset = "0x9A370C", VA = "0x9A370C")]
		public bool Contains([NotNull] string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x9A38F0", Offset = "0x9A38F0", VA = "0x9A38F0")]
		public RoomMembership Join([NotNull] string roomName)
		{
			return default(RoomMembership);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x9A3C2C", Offset = "0x9A3C2C", VA = "0x9A3C2C")]
		public bool Leave(RoomMembership membership)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9A3B78", Offset = "0x9A3B78", VA = "0x9A3B78")]
		private void OnJoinedRoom(RoomMembership membership)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9A3DA0", Offset = "0x9A3DA0", VA = "0x9A3DA0")]
		private void OnLeftRoom(RoomMembership membership)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x9A3E4C", Offset = "0x9A3E4C", VA = "0x9A3E4C")]
		[CanBeNull]
		internal string Name(ushort roomId)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9A37E0", Offset = "0x9A37E0", VA = "0x9A37E0")]
		private int? FindById(ushort id)
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public struct RoomMembership
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _name;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly ushort _roomId;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int Count;

		[Token(Token = "0x1700007E")]
		[NotNull]
		public string RoomName
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x9A403C", Offset = "0x9A403C", VA = "0x9A403C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public ushort RoomId
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x9A4044", Offset = "0x9A4044", VA = "0x9A4044")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x9A3B48", Offset = "0x9A3B48", VA = "0x9A3B48")]
		internal RoomMembership([NotNull] string name, int count)
		{
		}
	}
	[Token(Token = "0x2000094")]
	internal class RoomMembershipComparer : IComparer<RoomMembership>
	{
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x9A404C", Offset = "0x9A404C", VA = "0x9A404C", Slot = "4")]
		public int Compare(RoomMembership x, RoomMembership y)
		{
			return default(int);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x9A4034", Offset = "0x9A4034", VA = "0x9A4034")]
		public RoomMembershipComparer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class SemanticVersion : IComparable<SemanticVersion>, IEquatable<SemanticVersion>
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _major;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _minor;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _patch;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _tag;

		[Token(Token = "0x17000080")]
		public int Major
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x9A406C", Offset = "0x9A406C", VA = "0x9A406C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000081")]
		public int Minor
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x9A4074", Offset = "0x9A4074", VA = "0x9A4074")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000082")]
		public int Patch
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x9A407C", Offset = "0x9A407C", VA = "0x9A407C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000083")]
		public string Tag
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x9A4084", Offset = "0x9A4084", VA = "0x9A4084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x9A408C", Offset = "0x9A408C", VA = "0x9A408C")]
		public SemanticVersion()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x9A4094", Offset = "0x9A4094", VA = "0x9A4094")]
		public SemanticVersion(int major, int minor, int patch, [Optional][CanBeNull] string tag)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x9A40D8", Offset = "0x9A40D8", VA = "0x9A40D8", Slot = "4")]
		public int CompareTo([CanBeNull] SemanticVersion other)
		{
			return default(int);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x9A41D8", Offset = "0x9A41D8", VA = "0x9A41D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x9A43F0", Offset = "0x9A43F0", VA = "0x9A43F0", Slot = "5")]
		public bool Equals(SemanticVersion other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x9A4424", Offset = "0x9A4424", VA = "0x9A4424", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x9A4538", Offset = "0x9A4538", VA = "0x9A4538", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000096")]
	public sealed class TextChat
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Func<ICommsNetwork> _getNetwork;

		[Token(Token = "0x14000005")]
		public event Action<TextMessage> MessageReceived
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x9A48F8", Offset = "0x9A48F8", VA = "0x9A48F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x9A49A8", Offset = "0x9A49A8", VA = "0x9A49A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x9A4578", Offset = "0x9A4578", VA = "0x9A4578")]
		internal TextChat([NotNull] Func<ICommsNetwork> getNetwork)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x9A45F0", Offset = "0x9A45F0", VA = "0x9A45F0")]
		public void Send([NotNull] string roomName, [NotNull] string message)
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x9A4774", Offset = "0x9A4774", VA = "0x9A4774")]
		public void Whisper([NotNull] string playerName, [NotNull] string message)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9A4A58", Offset = "0x9A4A58", VA = "0x9A4A58")]
		internal void OnMessageReceived(TextMessage obj)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class TokenSet : IEnumerable<string>, IEnumerable
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IComparer<string> SortOrder;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<string> _tokens;

		[Token(Token = "0x17000084")]
		public int Count
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x99DAA4", Offset = "0x99DAA4", VA = "0x99DAA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<string> TokenRemoved
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x99D574", Offset = "0x99D574", VA = "0x99D574")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x9A4A94", Offset = "0x9A4A94", VA = "0x9A4A94")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<string> TokenAdded
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x99D4C4", Offset = "0x99D4C4", VA = "0x99D4C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x9A4B44", Offset = "0x9A4B44", VA = "0x9A4B44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x9A4BF4", Offset = "0x9A4BF4", VA = "0x9A4BF4")]
		private int Find([NotNull] string item)
		{
			return default(int);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x99DBA0", Offset = "0x99DBA0", VA = "0x99DBA0")]
		public bool ContainsToken([CanBeNull] string token)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x99DBDC", Offset = "0x99DBDC", VA = "0x99DBDC")]
		public bool AddToken([NotNull] string token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x99DCF4", Offset = "0x99DCF4", VA = "0x99DCF4")]
		public bool RemoveToken([NotNull] string token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x9A4C88", Offset = "0x9A4C88", VA = "0x9A4C88")]
		public bool IntersectsWith([NotNull] TokenSet other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x9A4EA0", Offset = "0x9A4EA0", VA = "0x9A4EA0", Slot = "4")]
		public IEnumerator<string> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x9A4F30", Offset = "0x9A4F30", VA = "0x9A4F30", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x99D324", Offset = "0x99D324", VA = "0x99D324")]
		public TokenSet()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public interface IAccessTokenCollection
	{
		[Token(Token = "0x17000085")]
		IEnumerable<string> Tokens
		{
			[Token(Token = "0x6000376")]
			get;
		}

		[Token(Token = "0x6000377")]
		bool ContainsToken([CanBeNull] string token);

		[Token(Token = "0x6000378")]
		bool AddToken([NotNull] string token);

		[Token(Token = "0x6000379")]
		bool RemoveToken([NotNull] string token);
	}
	[Token(Token = "0x2000099")]
	public struct Unit
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Unit None;
	}
	[Token(Token = "0x200009A")]
	public abstract class VoicePlayerState
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _name;

		[Token(Token = "0x17000086")]
		[NotNull]
		public string Name
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x9A56E8", Offset = "0x9A56E8", VA = "0x9A56E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public abstract bool IsConnected
		{
			[Token(Token = "0x6000387")]
			get;
		}

		[Token(Token = "0x17000088")]
		public abstract bool IsSpeaking
		{
			[Token(Token = "0x6000388")]
			get;
		}

		[Token(Token = "0x17000089")]
		public abstract float Amplitude
		{
			[Token(Token = "0x6000389")]
			get;
		}

		[Token(Token = "0x1700008A")]
		public abstract ChannelPriority? SpeakerPriority
		{
			[Token(Token = "0x600038A")]
			get;
		}

		[Token(Token = "0x1700008B")]
		public abstract float Volume
		{
			[Token(Token = "0x600038B")]
			get;
			[Token(Token = "0x600038C")]
			set;
		}

		[Token(Token = "0x1700008C")]
		public abstract bool IsLocallyMuted
		{
			[Token(Token = "0x600038D")]
			get;
			[Token(Token = "0x600038E")]
			set;
		}

		[Token(Token = "0x1700008D")]
		[NotNull]
		public abstract ReadOnlyCollection<string> Rooms
		{
			[Token(Token = "0x600038F")]
			get;
		}

		[Token(Token = "0x1700008E")]
		[CanBeNull]
		public IVoicePlayback Playback
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x9A56F0", Offset = "0x9A56F0", VA = "0x9A56F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		[CanBeNull]
		internal abstract IVoicePlaybackInternal PlaybackInternal
		{
			[Token(Token = "0x6000391")]
			get;
		}

		[Token(Token = "0x17000090")]
		[CanBeNull]
		public abstract IDissonancePlayer Tracker
		{
			[Token(Token = "0x6000392")]
			get;
			[Token(Token = "0x6000393")]
			internal set;
		}

		[Token(Token = "0x17000091")]
		[CanBeNull]
		public abstract float? PacketLoss
		{
			[Token(Token = "0x6000394")]
			get;
		}

		[Token(Token = "0x14000008")]
		public event Action<VoicePlayerState> OnStartedSpeaking
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x9A4FE0", Offset = "0x9A4FE0", VA = "0x9A4FE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x9A5090", Offset = "0x9A5090", VA = "0x9A5090")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event Action<VoicePlayerState> OnStoppedSpeaking
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0x9A5140", Offset = "0x9A5140", VA = "0x9A5140")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600037E")]
			[Address(RVA = "0x9A51F0", Offset = "0x9A51F0", VA = "0x9A51F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event Action<VoicePlayerState, string> OnEnteredRoom
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x9A52A0", Offset = "0x9A52A0", VA = "0x9A52A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000380")]
			[Address(RVA = "0x9A5350", Offset = "0x9A5350", VA = "0x9A5350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event Action<VoicePlayerState, string> OnExitedRoom
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x9A5400", Offset = "0x9A5400", VA = "0x9A5400")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x9A54B0", Offset = "0x9A54B0", VA = "0x9A54B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<VoicePlayerState> OnLeftSession
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x9A5560", Offset = "0x9A5560", VA = "0x9A5560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x9A5610", Offset = "0x9A5610", VA = "0x9A5610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x9A56C0", Offset = "0x9A56C0", VA = "0x9A56C0")]
		internal VoicePlayerState(string name)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9A5700", Offset = "0x9A5700", VA = "0x9A5700")]
		internal void InvokeOnStoppedSpeaking()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x9A57F8", Offset = "0x9A57F8", VA = "0x9A57F8")]
		internal void InvokeOnStartedSpeaking()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x9A58F0", Offset = "0x9A58F0", VA = "0x9A58F0")]
		internal void InvokeOnLeftSession()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x9A5910", Offset = "0x9A5910", VA = "0x9A5910", Slot = "17")]
		internal virtual void InvokeOnEnteredRoom(RoomEvent evtData)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9A59E8", Offset = "0x9A59E8", VA = "0x9A59E8", Slot = "18")]
		internal virtual void InvokeOnExitedRoom(RoomEvent evtData)
		{
		}

		[Token(Token = "0x600039A")]
		public abstract void GetSpeakingChannels([NotNull] List<RemoteChannel> output);

		[Token(Token = "0x600039B")]
		internal abstract void Update();
	}
	[Token(Token = "0x200009B")]
	internal class LocalVoicePlayerState : VoicePlayerState
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[NotNull]
		private readonly IAmplitudeProvider _micAmplitude;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[NotNull]
		private readonly Rooms _rooms;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[NotNull]
		private readonly RoomChannels _roomChannels;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[NotNull]
		private readonly PlayerChannels _playerChannels;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[NotNull]
		private readonly ILossEstimator _loss;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[NotNull]
		private readonly ICommsNetwork _network;

		[Token(Token = "0x17000092")]
		public override bool IsConnected
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x9A5DD4", Offset = "0x9A5DD4", VA = "0x9A5DD4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		internal override IVoicePlaybackInternal PlaybackInternal
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x9A5E80", Offset = "0x9A5E80", VA = "0x9A5E80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public override bool IsLocallyMuted
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x9A5E88", Offset = "0x9A5E88", VA = "0x9A5E88", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x9A5E90", Offset = "0x9A5E90", VA = "0x9A5E90", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public override ReadOnlyCollection<string> Rooms
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x9A5F78", Offset = "0x9A5F78", VA = "0x9A5F78", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public override IDissonancePlayer Tracker
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x9A5F94", Offset = "0x9A5F94", VA = "0x9A5F94", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x9A5F9C", Offset = "0x9A5F9C", VA = "0x9A5F9C", Slot = "15")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public override float Amplitude
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x9A5FA4", Offset = "0x9A5FA4", VA = "0x9A5FA4", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public override ChannelPriority? SpeakerPriority
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x9A6044", Offset = "0x9A6044", VA = "0x9A6044", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public override float Volume
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x9A604C", Offset = "0x9A604C", VA = "0x9A604C", Slot = "8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x9A6054", Offset = "0x9A6054", VA = "0x9A6054", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public override bool IsSpeaking
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x9A6128", Offset = "0x9A6128", VA = "0x9A6128", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009B")]
		public override float? PacketLoss
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x9A61B8", Offset = "0x9A61B8", VA = "0x9A61B8", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9A2244", Offset = "0x9A2244", VA = "0x9A2244")]
		public LocalVoicePlayerState(string name, [NotNull] IAmplitudeProvider micAmplitude, [NotNull] Rooms rooms, [NotNull] RoomChannels roomChannels, [NotNull] PlayerChannels playerChannels, [NotNull] ILossEstimator loss, ICommsNetwork network)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9A5BA0", Offset = "0x9A5BA0", VA = "0x9A5BA0")]
		private void OnChannelOpened(string channel, ChannelProperties properties)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x9A5C3C", Offset = "0x9A5C3C", VA = "0x9A5C3C")]
		private void OnChannelClosed(string channel, ChannelProperties properties)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x9A5CD4", Offset = "0x9A5CD4", VA = "0x9A5CD4")]
		private void OnLocallyEnteredRoom([NotNull] string room)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x9A5D54", Offset = "0x9A5D54", VA = "0x9A5D54")]
		private void OnLocallyExitedRoom([NotNull] string room)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9A6284", Offset = "0x9A6284", VA = "0x9A6284", Slot = "19")]
		public override void GetSpeakingChannels(List<RemoteChannel> channels)
		{
		}

		[Token(Token = "0x60003B0")]
		private static RemoteChannel CreateRemoteChannel<T>([NotNull] T item, ChannelType type) where T : IChannel<string>
		{
			return default(RemoteChannel);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x9A6798", Offset = "0x9A6798", VA = "0x9A6798", Slot = "20")]
		internal override void Update()
		{
		}
	}
	[Token(Token = "0x200009C")]
	internal class RemoteVoicePlayerState : VoicePlayerState
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IVoicePlaybackInternal _playback;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IDissonancePlayer _player;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly ReadOnlyCollection<string> EmptyRoomsList;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ReadOnlyCollection<string> _rooms;

		[Token(Token = "0x1700009C")]
		public override bool IsConnected
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x9A69D0", Offset = "0x9A69D0", VA = "0x9A69D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public override bool IsSpeaking
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x9A6AF4", Offset = "0x9A6AF4", VA = "0x9A6AF4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public override float Amplitude
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x9A6BBC", Offset = "0x9A6BBC", VA = "0x9A6BBC", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009F")]
		public override float Volume
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x9A6C84", Offset = "0x9A6C84", VA = "0x9A6C84", Slot = "8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x9A6D48", Offset = "0x9A6D48", VA = "0x9A6D48", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public override ChannelPriority? SpeakerPriority
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x9A6E90", Offset = "0x9A6E90", VA = "0x9A6E90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		internal override IVoicePlaybackInternal PlaybackInternal
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x9A7050", Offset = "0x9A7050", VA = "0x9A7050", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		public override bool IsLocallyMuted
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x9A707C", Offset = "0x9A707C", VA = "0x9A707C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x9A7140", Offset = "0x9A7140", VA = "0x9A7140", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public override ReadOnlyCollection<string> Rooms
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x9A7288", Offset = "0x9A7288", VA = "0x9A7288", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public override IDissonancePlayer Tracker
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x9A72EC", Offset = "0x9A72EC", VA = "0x9A72EC", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x9A72F4", Offset = "0x9A72F4", VA = "0x9A72F4", Slot = "15")]
			internal set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public override float? PacketLoss
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x9A75CC", Offset = "0x9A75CC", VA = "0x9A75CC", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		internal float? Jitter
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x9A768C", Offset = "0x9A768C", VA = "0x9A768C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9A6878", Offset = "0x9A6878", VA = "0x9A6878")]
		internal RemoteVoicePlayerState([NotNull] IVoicePlaybackInternal playback)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x9A7774", Offset = "0x9A7774", VA = "0x9A7774", Slot = "20")]
		internal override void Update()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x9A7A44", Offset = "0x9A7A44", VA = "0x9A7A44", Slot = "19")]
		public override void GetSpeakingChannels(List<RemoteChannel> channels)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x9A7B8C", Offset = "0x9A7B8C", VA = "0x9A7B8C", Slot = "17")]
		internal override void InvokeOnEnteredRoom(RoomEvent evtData)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x9A7BB8", Offset = "0x9A7BB8", VA = "0x9A7BB8", Slot = "18")]
		internal override void InvokeOnExitedRoom(RoomEvent evtData)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class VolumeFaderSettings
	{
		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _volume;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private long _fadeInTicks;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private long _fadeOutTicks;

		[Token(Token = "0x170000A7")]
		public float Volume
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x9A7D54", Offset = "0x9A7D54", VA = "0x9A7D54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x9A7D5C", Offset = "0x9A7D5C", VA = "0x9A7D5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A8")]
		public TimeSpan FadeIn
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x9A7D64", Offset = "0x9A7D64", VA = "0x9A7D64")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x9A7D6C", Offset = "0x9A7D6C", VA = "0x9A7D6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000A9")]
		public TimeSpan FadeOut
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x9A7D74", Offset = "0x9A7D74", VA = "0x9A7D74")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x9A7D7C", Offset = "0x9A7D7C", VA = "0x9A7D7C")]
			set
			{
			}
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x9A7D84", Offset = "0x9A7D84", VA = "0x9A7D84")]
		public VolumeFaderSettings()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Dissonance-Comms/")]
	public sealed class DissonanceComms : MonoBehaviour, IPriorityManager, IAccessTokenCollection, IChannelPriorityProvider, IVolumeProvider
	{
		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _started;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Rooms _rooms;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly PlayerChannels _playerChannels;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly RoomChannels _roomChannels;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly TextChat _text;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly OpenChannelVolumeDuck _autoChannelDuck;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly PlayerTrackerManager _playerTrackers;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly PlaybackPool _playbackPool;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly PlayerCollection _players;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly CodecSettingsLoader _codecSettingsLoader;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly PriorityManager _playbackPriorityManager;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly CapturePipelineManager _capture;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ICommsNetwork _net;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _localPlayerName;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[UsedImplicitly]
		[SerializeField]
		private bool _isMuted;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		[SerializeField]
		[UsedImplicitly]
		private bool _isDeafened;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[UsedImplicitly]
		private float _oneMinusBaseRemoteVoiceVolume;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[UsedImplicitly]
		[SerializeField]
		private VoicePlayback _playbackPrefab;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[UsedImplicitly]
		[SerializeField]
		private GameObject _playbackPrefab2;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[UsedImplicitly]
		private string _micName;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[UsedImplicitly]
		private ChannelPriority _playerPriority;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[UsedImplicitly]
		[SerializeField]
		private TokenSet _tokens;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly SemanticVersion Version;

		[Token(Token = "0x170000AA")]
		internal bool IsStarted
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x9A7D8C", Offset = "0x9A7D8C", VA = "0x9A7D8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		internal float PacketLoss
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x9A8A58", Offset = "0x9A8A58", VA = "0x9A8A58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000AC")]
		public string LocalPlayerName
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x9A8A74", Offset = "0x9A8A74", VA = "0x9A8A74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x9A8A7C", Offset = "0x9A8A7C", VA = "0x9A8A7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool IsNetworkInitialized
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x9A8B80", Offset = "0x9A8B80", VA = "0x9A8B80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		[NotNull]
		public Rooms Rooms
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x9A8C30", Offset = "0x9A8C30", VA = "0x9A8C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		[NotNull]
		public PlayerChannels PlayerChannels
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x9A8C38", Offset = "0x9A8C38", VA = "0x9A8C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		[NotNull]
		public RoomChannels RoomChannels
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x9A8C40", Offset = "0x9A8C40", VA = "0x9A8C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		[NotNull]
		public TextChat Text
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x9A8C48", Offset = "0x9A8C48", VA = "0x9A8C48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		[NotNull]
		public ReadOnlyCollection<VoicePlayerState> Players
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x9A8A3C", Offset = "0x9A8A3C", VA = "0x9A8A3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B3")]
		public ChannelPriority TopPrioritySpeaker
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x9A8C50", Offset = "0x9A8C50", VA = "0x9A8C50")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x170000B4")]
		[NotNull]
		public IEnumerable<string> Tokens
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x9A8C6C", Offset = "0x9A8C6C", VA = "0x9A8C6C", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public ChannelPriority PlayerPriority
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x9A8C74", Offset = "0x9A8C74", VA = "0x9A8C74")]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x9A8C7C", Offset = "0x9A8C7C", VA = "0x9A8C7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		[CanBeNull]
		public string MicrophoneName
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x9A8C84", Offset = "0x9A8C84", VA = "0x9A8C84")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x9A8C8C", Offset = "0x9A8C8C", VA = "0x9A8C8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		[CanBeNull]
		public IMicrophoneCapture MicrophoneCapture
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x9A8CD4", Offset = "0x9A8CD4", VA = "0x9A8CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public GameObject PlaybackPrefab
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x9A8CF0", Offset = "0x9A8CF0", VA = "0x9A8CF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x9A8CF8", Offset = "0x9A8CF8", VA = "0x9A8CF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public bool IsMuted
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x9A8EA4", Offset = "0x9A8EA4", VA = "0x9A8EA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x9A8EAC", Offset = "0x9A8EAC", VA = "0x9A8EAC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BA")]
		public bool IsDeafened
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x9A8EC4", Offset = "0x9A8EC4", VA = "0x9A8EC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x9A8ECC", Offset = "0x9A8ECC", VA = "0x9A8ECC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public float RemoteVoiceVolume
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x9A8EE4", Offset = "0x9A8EE4", VA = "0x9A8EE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x9A8F04", Offset = "0x9A8F04", VA = "0x9A8F04")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		private ChannelPriority Dissonance.Audio.Playback.IPriorityManager.TopPriority
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x9AA854", Offset = "0x9AA854", VA = "0x9AA854", Slot = "4")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x170000BD")]
		private ChannelPriority Dissonance.Audio.Capture.IChannelPriorityProvider.DefaultChannelPriority
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x9AA870", Offset = "0x9AA870", VA = "0x9AA870", Slot = "9")]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x9AA878", Offset = "0x9AA878", VA = "0x9AA878", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		private float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x9AA880", Offset = "0x9AA880", VA = "0x9AA880", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1400000D")]
		public event Action<VoicePlayerState> OnPlayerJoinedSession
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x9A7D94", Offset = "0x9A7D94", VA = "0x9A7D94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x9A7E44", Offset = "0x9A7E44", VA = "0x9A7E44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event Action<VoicePlayerState> OnPlayerLeftSession
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x9A7EF4", Offset = "0x9A7EF4", VA = "0x9A7EF4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x9A7FA4", Offset = "0x9A7FA4", VA = "0x9A7FA4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<VoicePlayerState> OnPlayerStartedSpeaking
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x9A8054", Offset = "0x9A8054", VA = "0x9A8054")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x9A8104", Offset = "0x9A8104", VA = "0x9A8104")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<VoicePlayerState> OnPlayerStoppedSpeaking
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x9A81B4", Offset = "0x9A81B4", VA = "0x9A81B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x9A8264", Offset = "0x9A8264", VA = "0x9A8264")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<VoicePlayerState, string> OnPlayerEnteredRoom
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x9A8314", Offset = "0x9A8314", VA = "0x9A8314")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x9A83C4", Offset = "0x9A83C4", VA = "0x9A83C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<VoicePlayerState, string> OnPlayerExitedRoom
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x9A8474", Offset = "0x9A8474", VA = "0x9A8474")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x9A8524", Offset = "0x9A8524", VA = "0x9A8524")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<string> LocalPlayerNameChanged
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x9A85D4", Offset = "0x9A85D4", VA = "0x9A85D4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x9A8684", Offset = "0x9A8684", VA = "0x9A8684")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<string> TokenAdded
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x99D1EC", Offset = "0x99D1EC", VA = "0x99D1EC")]
			add
			{
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x99D1BC", Offset = "0x99D1BC", VA = "0x99D1BC")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event Action<string> TokenRemoved
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x99D204", Offset = "0x99D204", VA = "0x99D204")]
			add
			{
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x99D1D4", Offset = "0x99D1D4", VA = "0x99D1D4")]
			remove
			{
			}
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x9A8734", Offset = "0x9A8734", VA = "0x9A8734")]
		public DissonanceComms()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x9A8FC8", Offset = "0x9A8FC8", VA = "0x9A8FC8")]
		[UsedImplicitly]
		private void Start()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x9A9BE4", Offset = "0x9A9BE4", VA = "0x9A9BE4")]
		private IMicrophoneCapture GetOrAddMicrophone()
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x9A9C6C", Offset = "0x9A9C6C", VA = "0x9A9C6C")]
		[UsedImplicitly]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x9A9C70", Offset = "0x9A9C70", VA = "0x9A9C70")]
		[UsedImplicitly]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x9A9C74", Offset = "0x9A9C74", VA = "0x9A9C74")]
		public void ResetMicrophoneCapture()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x9A9C88", Offset = "0x9A9C88", VA = "0x9A9C88")]
		private void Net_PlayerStoppedSpeaking([NotNull] string player)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x9A9D88", Offset = "0x9A9D88", VA = "0x9A9D88")]
		private void Net_PlayerStartedSpeaking([NotNull] string player)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x9A9E7C", Offset = "0x9A9E7C", VA = "0x9A9E7C")]
		private void Net_PlayerRoomEvent(RoomEvent evt)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x9A9FDC", Offset = "0x9A9FDC", VA = "0x9A9FDC")]
		private void Net_VoicePacketReceived(VoicePacket packet)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x9AA1B0", Offset = "0x9AA1B0", VA = "0x9AA1B0")]
		private void Net_PlayerLeft([NotNull] string playerId)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x9AA33C", Offset = "0x9AA33C", VA = "0x9AA33C")]
		private void Net_PlayerJoined([NotNull] string playerId, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x9AA4CC", Offset = "0x9AA4CC", VA = "0x9AA4CC")]
		[CanBeNull]
		public VoicePlayerState FindPlayer([NotNull] string playerId)
		{
			return null;
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x9AA554", Offset = "0x9AA554", VA = "0x9AA554")]
		[UsedImplicitly]
		private void Update()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x9AA600", Offset = "0x9AA600", VA = "0x9AA600")]
		[UsedImplicitly]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x9AA61C", Offset = "0x9AA61C", VA = "0x9AA61C")]
		public void SubcribeToVoiceActivation([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x9AA638", Offset = "0x9AA638", VA = "0x9AA638")]
		public void UnsubscribeFromVoiceActivation([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x9AA654", Offset = "0x9AA654", VA = "0x9AA654")]
		public void SubcribeToRecordedAudio([NotNull] IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x9AA670", Offset = "0x9AA670", VA = "0x9AA670")]
		public void UnsubscribeFromRecordedAudio([NotNull] IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x9AA68C", Offset = "0x9AA68C", VA = "0x9AA68C")]
		public void TrackPlayerPosition([NotNull] IDissonancePlayer player)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x9AA6A4", Offset = "0x9AA6A4", VA = "0x9AA6A4")]
		public void StopTracking([NotNull] IDissonancePlayer player)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x9AA6BC", Offset = "0x9AA6BC", VA = "0x9AA6BC", Slot = "7")]
		public bool AddToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x9AA740", Offset = "0x9AA740", VA = "0x9AA740", Slot = "8")]
		public bool RemoveToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x9AA7C4", Offset = "0x9AA7C4", VA = "0x9AA7C4", Slot = "6")]
		public bool ContainsToken(string token)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x99DAEC", Offset = "0x99DAEC", VA = "0x99DAEC")]
		public bool HasAnyToken([NotNull] TokenSet tokens)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x9A9BCC", Offset = "0x9A9BCC", VA = "0x9A9BCC")]
		public static void TestDependencies()
		{
		}
	}
	[Token(Token = "0x200009F")]
	internal static class DissonanceRootPath
	{
		[Token(Token = "0x40001C7")]
		internal const string BasePath = "Assets/Plugins/Dissonance";

		[Token(Token = "0x40001C8")]
		internal const string BaseResourcePath = "Assets/Plugins/Dissonance/Resources";
	}
	[Token(Token = "0x20000A0")]
	[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Voice-Broadcast-Trigger/")]
	public class VoiceBroadcastTrigger : BaseCommsTrigger, IVoiceActivationListener
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PlayerChannel? _playerChannel;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RoomChannel? _roomChannel;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _isVadSpeaking;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private CommActivationMode? _previousMode;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IDissonancePlayer _self;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Fader _activationFader;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private VolumeFaderSettings _activationFaderSettings;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Fader _triggerFader;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private VolumeFaderSettings _triggerFaderSettings;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private bool _broadcastPosition;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private CommTriggerTarget _channelType;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private string _inputName;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CommActivationMode _mode;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool _muted;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private string _playerId;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool _useTrigger;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private string _roomName;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ChannelPriority _priority;

		[Token(Token = "0x170000BF")]
		[NotNull]
		public VolumeFaderSettings ActivationFader
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x9AAA0C", Offset = "0x9AAA0C", VA = "0x9AAA0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		[NotNull]
		public VolumeFaderSettings ColliderTriggerFader
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x9AAA14", Offset = "0x9AAA14", VA = "0x9AAA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public float CurrentFaderVolume
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x9AAA1C", Offset = "0x9AAA1C", VA = "0x9AAA1C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C2")]
		public bool BroadcastPosition
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x9AAA58", Offset = "0x9AAA58", VA = "0x9AAA58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x9AAA60", Offset = "0x9AAA60", VA = "0x9AAA60")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public CommTriggerTarget ChannelType
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x9AAB58", Offset = "0x9AAB58", VA = "0x9AAB58")]
			get
			{
				return default(CommTriggerTarget);
			}
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x9AAB60", Offset = "0x9AAB60", VA = "0x9AAB60")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public string InputName
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x9AAC64", Offset = "0x9AAC64", VA = "0x9AAC64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x9AAC6C", Offset = "0x9AAC6C", VA = "0x9AAC6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public CommActivationMode Mode
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x9AAC74", Offset = "0x9AAC74", VA = "0x9AAC74")]
			get
			{
				return default(CommActivationMode);
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x9AAC7C", Offset = "0x9AAC7C", VA = "0x9AAC7C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public bool IsMuted
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x9AAC84", Offset = "0x9AAC84", VA = "0x9AAC84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x9AAC8C", Offset = "0x9AAC8C", VA = "0x9AAC8C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public string PlayerId
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x9AACE8", Offset = "0x9AACE8", VA = "0x9AACE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x9AACF0", Offset = "0x9AACF0", VA = "0x9AACF0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public override bool UseColliderTrigger
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x9AAD3C", Offset = "0x9AAD3C", VA = "0x9AAD3C", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x9AAD44", Offset = "0x9AAD44", VA = "0x9AAD44", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public string RoomName
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x9AAD50", Offset = "0x9AAD50", VA = "0x9AAD50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x9AAD58", Offset = "0x9AAD58", VA = "0x9AAD58")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x9AADA0", Offset = "0x9AADA0", VA = "0x9AADA0")]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x9AADA8", Offset = "0x9AADA8", VA = "0x9AADA8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool IsTransmitting
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x9AAEA8", Offset = "0x9AAEA8", VA = "0x9AAEA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CC")]
		public override bool CanTrigger
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x9AAF08", Offset = "0x9AAF08", VA = "0x9AAF08", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x9AB044", Offset = "0x9AB044", VA = "0x9AB044", Slot = "12")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x9AB0C0", Offset = "0x9AB0C0", VA = "0x9AB0C0", Slot = "15")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x9AB0C4", Offset = "0x9AB0C4", VA = "0x9AB0C4", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x9AB15C", Offset = "0x9AB15C", VA = "0x9AB15C", Slot = "14")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x9AB9EC", Offset = "0x9AB9EC", VA = "0x9AB9EC", Slot = "18")]
		protected override void ColliderTriggerChanged()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x9AB394", Offset = "0x9AB394", VA = "0x9AB394")]
		private void SwitchMode()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x9AB578", Offset = "0x9AB578", VA = "0x9AB578")]
		private bool ShouldActivate(bool intent)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x9AB570", Offset = "0x9AB570", VA = "0x9AB570")]
		private bool IsUserActivated()
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x9AB48C", Offset = "0x9AB48C", VA = "0x9AB48C")]
		private void SetChannelVolume(float value)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x9AB658", Offset = "0x9AB658", VA = "0x9AB658")]
		private void OpenChannel()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x9AAB78", Offset = "0x9AAB78", VA = "0x9AAB78")]
		private void CloseChannel()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x9ABA5C", Offset = "0x9ABA5C", VA = "0x9ABA5C", Slot = "20")]
		private void Dissonance.VAD.IVoiceActivationListener.VoiceActivationStart()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x9ABA68", Offset = "0x9ABA68", VA = "0x9ABA68", Slot = "21")]
		private void Dissonance.VAD.IVoiceActivationListener.VoiceActivationStop()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x9ABA70", Offset = "0x9ABA70", VA = "0x9ABA70")]
		public VoiceBroadcastTrigger()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[HelpURL("https://placeholder-software.co.uk/dissonance/docs/Reference/Components/Voice-Receipt-Trigger/")]
	public class VoiceReceiptTrigger : BaseCommsTrigger
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RoomMembership? _membership;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _roomName;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _scriptDeactivated;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool _useTrigger;

		[Token(Token = "0x170000CD")]
		public string RoomName
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x9ABB88", Offset = "0x9ABB88", VA = "0x9ABB88")]
			get
			{
				return null;
			}
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x9ABB90", Offset = "0x9ABB90", VA = "0x9ABB90")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public override bool UseColliderTrigger
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x9ABC68", Offset = "0x9ABC68", VA = "0x9ABC68", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x9ABC70", Offset = "0x9ABC70", VA = "0x9ABC70", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public override bool CanTrigger
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x9ABC7C", Offset = "0x9ABC7C", VA = "0x9ABC7C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x9ABD14", Offset = "0x9ABD14", VA = "0x9ABD14")]
		[Obsolete("This is equivalent to enabling this component")]
		public void StartListening()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x9ABD1C", Offset = "0x9ABD1C", VA = "0x9ABD1C")]
		[Obsolete("This is equivalent to disabling this component")]
		public void StopListening()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x9ABD28", Offset = "0x9ABD28", VA = "0x9ABD28", Slot = "14")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x9ABD94", Offset = "0x9ABD94", VA = "0x9ABD94")]
		private void JoinRoom()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x9ABBD0", Offset = "0x9ABBD0", VA = "0x9ABBD0")]
		private void LeaveRoom()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x9ABE44", Offset = "0x9ABE44", VA = "0x9ABE44", Slot = "15")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x9ABEBC", Offset = "0x9ABEBC", VA = "0x9ABEBC")]
		public VoiceReceiptTrigger()
		{
		}
	}
}
namespace Dissonance.Demo
{
	[Token(Token = "0x20000A2")]
	public class ChatInputController : MonoBehaviour
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _isInputtingText;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _targetChannel;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DissonanceComms Comms;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Team1Channel;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Team2Channel;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private InputField _input;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ChatLogController _log;

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x9ABEC0", Offset = "0x9ABEC0", VA = "0x9ABEC0")]
		public void Start()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x9AC0F4", Offset = "0x9AC0F4", VA = "0x9AC0F4")]
		private void OnInputEndEdit([CanBeNull] string message)
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x9AC6A4", Offset = "0x9AC6A4", VA = "0x9AC6A4")]
		public void Update()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x9AC748", Offset = "0x9AC748", VA = "0x9AC748")]
		private void ShowTextInput(string channel)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x9AC804", Offset = "0x9AC804", VA = "0x9AC804")]
		public ChatInputController()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ChatLogController : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		private class ChatLogEntry
		{
			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Text _txt;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly RectTransform _transform;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float _transitionProgress;

			[Token(Token = "0x170000D1")]
			[NotNull]
			public RectTransform Transform
			{
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x9AD278", Offset = "0x9AD278", VA = "0x9AD278")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D2")]
			[NotNull]
			public GameObject Object
			{
				[Token(Token = "0x600045B")]
				[Address(RVA = "0x9AD110", Offset = "0x9AD110", VA = "0x9AD110")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			public bool IsTransitioningOut
			{
				[Token(Token = "0x600045C")]
				[Address(RVA = "0x9AD280", Offset = "0x9AD280", VA = "0x9AD280")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045D")]
				[Address(RVA = "0x9AD288", Offset = "0x9AD288", VA = "0x9AD288")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public bool IsTransitionComplete
			{
				[Token(Token = "0x600045E")]
				[Address(RVA = "0x9AD294", Offset = "0x9AD294", VA = "0x9AD294")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600045F")]
				[Address(RVA = "0x9AD29C", Offset = "0x9AD29C", VA = "0x9AD29C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000460")]
			[Address(RVA = "0x9ACCA4", Offset = "0x9ACCA4", VA = "0x9ACCA4")]
			public ChatLogEntry([NotNull] Text txt)
			{
			}

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x9ACCE4", Offset = "0x9ACCE4", VA = "0x9ACCE4")]
			public void FadeOut()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x9AD12C", Offset = "0x9AD12C", VA = "0x9AD12C")]
			public void Update()
			{
			}
		}

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DissonanceComms Comms;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _textPrototype;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CanvasGroup _canvas;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _heightLimit;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Queue<ChatLogEntry> _entries;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DateTime _fadeOutStartTime;

		[Token(Token = "0x170000D0")]
		public bool ForceShow
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x9AC940", Offset = "0x9AC940", VA = "0x9AC940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x9AC948", Offset = "0x9AC948", VA = "0x9AC948")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x9AC954", Offset = "0x9AC954", VA = "0x9AC954")]
		public void Start()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x9ACB30", Offset = "0x9ACB30", VA = "0x9ACB30")]
		private void OnMessageReceived(TextMessage message)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x9AC290", Offset = "0x9AC290", VA = "0x9AC290")]
		public void AddMessage(string message, Color color)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x9ACD64", Offset = "0x9ACD64", VA = "0x9ACD64")]
		public void Update()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x9ACCF0", Offset = "0x9ACCF0", VA = "0x9ACCF0")]
		public void ShowFor(TimeSpan time)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x9AD1FC", Offset = "0x9AD1FC", VA = "0x9AD1FC")]
		public ChatLogController()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Logo : MonoBehaviour
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Texture2D _logo;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x9AD2A8", Offset = "0x9AD2A8", VA = "0x9AD2A8")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x9AD314", Offset = "0x9AD314", VA = "0x9AD314")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x9AD414", Offset = "0x9AD414", VA = "0x9AD414")]
		public Logo()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class SpeakerIndicator : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class <FindPlayerState>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpeakerIndicator <>4__this;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000470")]
				[Address(RVA = "0x9ADA00", Offset = "0x9ADA00", VA = "0x9ADA00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000472")]
				[Address(RVA = "0x9ADA48", Offset = "0x9ADA48", VA = "0x9ADA48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600046D")]
			[Address(RVA = "0x9AD6F4", Offset = "0x9AD6F4", VA = "0x9AD6F4")]
			[DebuggerHidden]
			public <FindPlayerState>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600046E")]
			[Address(RVA = "0x9AD828", Offset = "0x9AD828", VA = "0x9AD828", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600046F")]
			[Address(RVA = "0x9AD82C", Offset = "0x9AD82C", VA = "0x9AD82C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000471")]
			[Address(RVA = "0x9ADA08", Offset = "0x9ADA08", VA = "0x9ADA08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject _indicator;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light _light;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _transform;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _intensity;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IDissonancePlayer _player;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VoicePlayerState _state;

		[Token(Token = "0x170000D5")]
		private bool IsSpeaking
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x9AD41C", Offset = "0x9AD41C", VA = "0x9AD41C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x9AD4EC", Offset = "0x9AD4EC", VA = "0x9AD4EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x9AD68C", Offset = "0x9AD68C", VA = "0x9AD68C")]
		[IteratorStateMachine(typeof(<FindPlayerState>d__9))]
		private IEnumerator FindPlayerState()
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x9AD71C", Offset = "0x9AD71C", VA = "0x9AD71C")]
		private void Update()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x9AD804", Offset = "0x9AD804", VA = "0x9AD804")]
		private static void UpdateChildTransform([NotNull] Transform transform, float intensity)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x9AD7F0", Offset = "0x9AD7F0", VA = "0x9AD7F0")]
		private static void UpdateLight([NotNull] Light light, float intensity)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x9AD820", Offset = "0x9AD820", VA = "0x9AD820")]
		public SpeakerIndicator()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class ToggleInvertMute : MonoBehaviour
	{
		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VoiceBroadcastTrigger Trigger;

		[Token(Token = "0x170000D8")]
		public bool IsUnmuted
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x9ADA50", Offset = "0x9ADA50", VA = "0x9ADA50")]
			set
			{
			}
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x9ADAE8", Offset = "0x9ADAE8", VA = "0x9ADAE8")]
		public ToggleInvertMute()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class TriggerVisualizer : MonoBehaviour
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject _visualisations;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BaseCommsTrigger[] _triggers;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _fillMaterial;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _outlineMaterial;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _alpha;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color Color;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x9ADAF0", Offset = "0x9ADAF0", VA = "0x9ADAF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x9AF53C", Offset = "0x9AF53C", VA = "0x9AF53C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x9ADE14", Offset = "0x9ADE14", VA = "0x9ADE14")]
		private void CreateCircle(SphereCollider sphere)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x9AE83C", Offset = "0x9AE83C", VA = "0x9AE83C")]
		private void CreateBox([NotNull] BoxCollider box)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x9AF7E8", Offset = "0x9AF7E8", VA = "0x9AF7E8")]
		public TriggerVisualizer()
		{
		}
	}
}
namespace Dissonance.VAD
{
	[Token(Token = "0x20000AC")]
	public interface IVoiceActivationListener
	{
		[Token(Token = "0x600047E")]
		void VoiceActivationStart();

		[Token(Token = "0x600047F")]
		void VoiceActivationStop();
	}
}
namespace Dissonance.Threading
{
	[Token(Token = "0x20000AD")]
	internal interface IThread
	{
		[Token(Token = "0x170000D9")]
		bool IsStarted
		{
			[Token(Token = "0x6000480")]
			get;
		}

		[Token(Token = "0x6000481")]
		void Start();

		[Token(Token = "0x6000482")]
		void Join();
	}
	[Token(Token = "0x20000AE")]
	internal class DThread : IThread
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Thread _thread;

		[Token(Token = "0x170000DA")]
		public bool IsStarted
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x9AF894", Offset = "0x9AF894", VA = "0x9AF894", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x9AF89C", Offset = "0x9AF89C", VA = "0x9AF89C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x9AF8A8", Offset = "0x9AF8A8", VA = "0x9AF8A8")]
		public DThread([NotNull] Action action)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x9AF96C", Offset = "0x9AF96C", VA = "0x9AF96C", Slot = "5")]
		public void Start()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x9AF998", Offset = "0x9AF998", VA = "0x9AF998", Slot = "6")]
		public void Join()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	internal class LockedValue<T>
	{
		[Token(Token = "0x20000B0")]
		public class Unlocker : IDisposable
		{
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly LockedValue<T> _parent;

			[Token(Token = "0x170000DB")]
			[CanBeNull]
			public T Value
			{
				[Token(Token = "0x600048B")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x600048C")]
				set
				{
				}
			}

			[Token(Token = "0x600048D")]
			public Unlocker(LockedValue<T> parent)
			{
			}

			[Token(Token = "0x600048E")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T _value;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly object _lockObject;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Unlocker _unlocker;

		[Token(Token = "0x6000488")]
		public LockedValue(T value)
		{
		}

		[Token(Token = "0x6000489")]
		public Unlocker Lock()
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		private void Unlock()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	internal class ReadonlyLockedValue<T>
	{
		[Token(Token = "0x20000B2")]
		public class Unlocker : IDisposable
		{
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ReadonlyLockedValue<T> _parent;

			[Token(Token = "0x170000DC")]
			public T Value
			{
				[Token(Token = "0x6000492")]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x6000493")]
			public Unlocker(ReadonlyLockedValue<T> parent)
			{
			}

			[Token(Token = "0x6000494")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T _value;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly object _lockObject;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Unlocker _unlocker;

		[Token(Token = "0x600048F")]
		public ReadonlyLockedValue(T value)
		{
		}

		[Token(Token = "0x6000490")]
		public Unlocker Lock()
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		private void Unlock()
		{
		}
	}
}
namespace Dissonance.Networking
{
	[Token(Token = "0x20000B3")]
	public abstract class BaseClient<TServer, TClient, TPeer> : IClient<TPeer> where TServer : BaseServer<TServer, TClient, TPeer> where TClient : BaseClient<TServer, TClient, TPeer> where TPeer : struct
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Log Log;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _disconnected;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _error;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EventQueue _events;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SlaveClientCollection<TPeer> _peers;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ConnectionNegotiator<TPeer> _serverNegotiator;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SendQueue<TPeer> _sendQueue;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PacketDelaySimulator _lossSimulator;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly VoiceReceiver<TPeer> _voiceReceiver;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly VoiceSender<TPeer> _voiceSender;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TextReceiver<TPeer> _textReceiver;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TextSender<TPeer> _textSender;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvRemoveClient;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvVoiceData;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvTextData;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvHandshakeResponse;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvHandshakeP2P;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvClientState;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _recvDeltaState;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TrafficCounter _sentServer;

		[Token(Token = "0x170000DD")]
		public bool IsConnected
		{
			[Token(Token = "0x6000495")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DE")]
		[NotNull]
		internal TrafficCounter RecvRemoveClient
		{
			[Token(Token = "0x60004A6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		[NotNull]
		internal TrafficCounter RecvVoiceData
		{
			[Token(Token = "0x60004A7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		[NotNull]
		internal TrafficCounter RecvTextData
		{
			[Token(Token = "0x60004A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		[NotNull]
		internal TrafficCounter RecvHandshakeResponse
		{
			[Token(Token = "0x60004A9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		[NotNull]
		internal TrafficCounter RecvHandshakeP2P
		{
			[Token(Token = "0x60004AA")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		[NotNull]
		internal TrafficCounter RecvClientState
		{
			[Token(Token = "0x60004AB")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		[NotNull]
		internal TrafficCounter RecvDeltaState
		{
			[Token(Token = "0x60004AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		[NotNull]
		internal TrafficCounter SentServerTraffic
		{
			[Token(Token = "0x60004AD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000016")]
		public event Action<string, CodecSettings> PlayerJoined
		{
			[Token(Token = "0x6000496")]
			add
			{
			}
			[Token(Token = "0x6000497")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event Action<string> PlayerLeft
		{
			[Token(Token = "0x6000498")]
			add
			{
			}
			[Token(Token = "0x6000499")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event Action<RoomEvent> PlayerEnteredRoom
		{
			[Token(Token = "0x600049A")]
			add
			{
			}
			[Token(Token = "0x600049B")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event Action<RoomEvent> PlayerExitedRoom
		{
			[Token(Token = "0x600049C")]
			add
			{
			}
			[Token(Token = "0x600049D")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event Action<VoicePacket> VoicePacketReceived
		{
			[Token(Token = "0x600049E")]
			add
			{
			}
			[Token(Token = "0x600049F")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event Action<TextMessage> TextMessageReceived
		{
			[Token(Token = "0x60004A0")]
			add
			{
			}
			[Token(Token = "0x60004A1")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event Action<string> PlayerStartedSpeaking
		{
			[Token(Token = "0x60004A2")]
			add
			{
			}
			[Token(Token = "0x60004A3")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event Action<string> PlayerStoppedSpeaking
		{
			[Token(Token = "0x60004A4")]
			add
			{
			}
			[Token(Token = "0x60004A5")]
			remove
			{
			}
		}

		[Token(Token = "0x60004AE")]
		protected BaseClient([NotNull] ICommsNetworkState network)
		{
		}

		[Token(Token = "0x60004AF")]
		public abstract void Connect();

		[Token(Token = "0x60004B0")]
		protected void Connected()
		{
		}

		[Token(Token = "0x60004B1")]
		public virtual void Disconnect()
		{
		}

		[Token(Token = "0x60004B2")]
		protected void FatalError(string reason)
		{
		}

		[Token(Token = "0x60004B3")]
		public virtual ClientStatus Update()
		{
			return default(ClientStatus);
		}

		[Token(Token = "0x60004B4")]
		private bool RunUpdate(DateTime utcNow)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		public void SendVoiceData(ArraySegment<byte> encodedAudio)
		{
		}

		[Token(Token = "0x60004B6")]
		public void SendTextData(string data, ChannelType type, string recipient)
		{
		}

		[Token(Token = "0x60004B7")]
		public ushort? NetworkReceivedPacket(ArraySegment<byte> data)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		private ushort? ProcessReceivedPacket(ArraySegment<byte> data)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		private bool CheckSessionId(ref PacketReader reader, MessageTypes type)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		protected abstract void ReadMessages();

		[Token(Token = "0x60004BB")]
		protected abstract void SendReliable(ArraySegment<byte> packet);

		[Token(Token = "0x60004BC")]
		protected abstract void SendUnreliable(ArraySegment<byte> packet);

		[Token(Token = "0x60004BD")]
		protected virtual void SendReliableP2P([NotNull] List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x60004BE")]
		protected virtual void SendUnreliableP2P([NotNull] List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x60004BF")]
		protected virtual void OnServerAssignedSessionId(uint session, ushort id)
		{
		}

		[Token(Token = "0x60004C0")]
		protected virtual void OnAddedClient([NotNull] ClientInfo<TPeer?> client)
		{
		}

		[Token(Token = "0x60004C1")]
		protected virtual void OnMetClient([NotNull] ClientInfo<TPeer?> client)
		{
		}

		[Token(Token = "0x60004C2")]
		protected void ReceiveHandshakeP2P(ushort id, TPeer connection)
		{
		}

		[Token(Token = "0x60004C3")]
		[NotNull]
		protected static byte[] WriteHandshakeP2P(uint sessionId, ushort clientId)
		{
			return null;
		}

		[Token(Token = "0x60004C4")]
		private void Dissonance.Networking.Client.IClient<TPeer>.SendReliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x60004C5")]
		private void Dissonance.Networking.Client.IClient<TPeer>.SendUnreliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x60004C6")]
		private void Dissonance.Networking.Client.IClient<TPeer>.SendReliableP2P([NotNull] List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x60004C7")]
		private void Dissonance.Networking.Client.IClient<TPeer>.SendUnreliableP2P([NotNull] List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}
	}
	[Token(Token = "0x20000B5")]
	internal class BaseClientCollection<TPeer> : IClientCollection<TPeer>
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Log Log;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly ClientIdCollection PlayerIds;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly RoomClientsCollection<TPeer> ClientsInRooms;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<ushort, ClientInfo<TPeer>> _clientsByPlayerId;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, ClientInfo<TPeer>> _clientsByName;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<string> _tmpRoomList;

		[Token(Token = "0x60004CC")]
		protected BaseClientCollection()
		{
		}

		[Token(Token = "0x60004CD")]
		public virtual void Stop()
		{
		}

		[Token(Token = "0x60004CE")]
		protected virtual void OnAddedClient([NotNull] ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x60004CF")]
		protected virtual void OnRemovedClient([NotNull] ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x60004D0")]
		[NotNull]
		protected ClientInfo<TPeer> GetOrCreateClientInfo(ushort id, [NotNull] string name, CodecSettings codecSettings, [CanBeNull] TPeer connection)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		protected void RemoveClient([NotNull] ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x60004D2")]
		public bool TryGetClientInfoById(ushort player, out ClientInfo<TPeer> info)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		public bool TryGetClientInfoByName([CanBeNull] string name, out ClientInfo<TPeer> info)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		public bool TryGetClientsInRoom(string room, out List<ClientInfo<TPeer>> clients)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		public bool TryGetClientsInRoom(ushort roomId, out List<ClientInfo<TPeer>> clients)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D6")]
		protected void GetClients(List<ClientInfo<TPeer>> output)
		{
		}

		[Token(Token = "0x60004D7")]
		[ContractAnnotation("=> true, info:notnull; => false, info:null")]
		protected bool TryFindClientByConnection(TPeer connection, [CanBeNull] out ClientInfo<TPeer> info)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		protected void ClearRooms()
		{
		}

		[Token(Token = "0x60004D9")]
		protected virtual void OnClientEnteredRoom([NotNull] ClientInfo<TPeer> client, string room)
		{
		}

		[Token(Token = "0x60004DA")]
		protected virtual void OnClientExitedRoom([NotNull] ClientInfo<TPeer> client, string room)
		{
		}

		[Token(Token = "0x60004DB")]
		protected void JoinRoom([NotNull] string room, [NotNull] ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x60004DC")]
		private void LeaveRoom([NotNull] string room, [NotNull] ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x60004DD")]
		public virtual void ProcessClientState([CanBeNull] TPeer source, ref PacketReader reader)
		{
		}

		[Token(Token = "0x60004DE")]
		public virtual void ProcessDeltaChannelState(ref PacketReader reader)
		{
		}
	}
	[Token(Token = "0x20000B6")]
	internal interface IClientCollection<TPeer>
	{
		[Token(Token = "0x60004DF")]
		[ContractAnnotation("=> true, info:notnull; => false, info:null")]
		bool TryGetClientInfoById(ushort clientId, out ClientInfo<TPeer> info);

		[Token(Token = "0x60004E0")]
		[ContractAnnotation("=> true, info:notnull; => false, info:null")]
		bool TryGetClientInfoByName([NotNull] string clientName, out ClientInfo<TPeer> info);

		[Token(Token = "0x60004E1")]
		[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
		bool TryGetClientsInRoom([NotNull] string room, out List<ClientInfo<TPeer>> clients);

		[Token(Token = "0x60004E2")]
		[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
		bool TryGetClientsInRoom(ushort roomId, out List<ClientInfo<TPeer>> clients);
	}
	[Token(Token = "0x20000B7")]
	public abstract class BaseCommsNetwork<TServer, TClient, TPeer, TClientParam, TServerParam> : MonoBehaviour, ICommsNetwork, ICommsNetworkState where TServer : BaseServer<TServer, TClient, TPeer> where TClient : BaseClient<TServer, TClient, TPeer> where TPeer : struct, IEquatable<TPeer>
	{
		[Token(Token = "0x20000B8")]
		private interface IState
		{
			[Token(Token = "0x170000F0")]
			ConnectionStatus Status
			{
				[Token(Token = "0x6000525")]
				get;
			}

			[Token(Token = "0x6000526")]
			void Enter();

			[Token(Token = "0x6000527")]
			void Update();

			[Token(Token = "0x6000528")]
			void Exit();
		}

		[Token(Token = "0x20000B9")]
		private class Idle : IState
		{
			[Token(Token = "0x4000244")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly BaseCommsNetwork<TServer, TClient, TPeer, TClientParam, TServerParam> _net;

			[Token(Token = "0x170000F1")]
			public ConnectionStatus Status
			{
				[Token(Token = "0x600052A")]
				get
				{
					return default(ConnectionStatus);
				}
			}

			[Token(Token = "0x6000529")]
			public Idle(BaseCommsNetwork<TServer, TClient, TPeer, TClientParam, TServerParam> net)
			{
			}

			[Token(Token = "0x600052B")]
			public void Enter()
			{
			}

			[Token(Token = "0x600052C")]
			public void Update()
			{
			}

			[Token(Token = "0x600052D")]
			public void Exit()
			{
			}
		}

		[Token(Token = "0x20000BA")]
		private class Session : IState
		{
			[Token(Token = "0x4000245")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[CanBeNull]
			private readonly TClientParam _clientParameter;

			[Token(Token = "0x4000246")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[CanBeNull]
			private readonly TServerParam _serverParameter;

			[Token(Token = "0x4000247")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly NetworkMode _mode;

			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly BaseCommsNetwork<TServer, TClient, TPeer, TClientParam, TServerParam> _net;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float _reconnectionAttemptInterval;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private DateTime _lastReconnectionAttempt;

			[Token(Token = "0x170000F2")]
			public ConnectionStatus Status
			{
				[Token(Token = "0x600052F")]
				get
				{
					return default(ConnectionStatus);
				}
			}

			[Token(Token = "0x600052E")]
			public Session([NotNull] BaseCommsNetwork<TServer, TClient, TPeer, TClientParam, TServerParam> net, NetworkMode mode, [CanBeNull] TServerParam serverParameter, [CanBeNull] TClientParam clientParameter)
			{
			}

			[Token(Token = "0x6000530")]
			public void Enter()
			{
			}

			[Token(Token = "0x6000531")]
			public void Update()
			{
			}

			[Token(Token = "0x6000532")]
			public void Exit()
			{
			}

			[Token(Token = "0x6000533")]
			private void StartServer()
			{
			}

			[Token(Token = "0x6000534")]
			private void StartClient()
			{
			}

			[Token(Token = "0x6000535")]
			private bool ShouldAttemptReconnect()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Queue<IState> _nextStates;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IState _state;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private NetworkMode _mode;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Log Log;

		[Token(Token = "0x170000E6")]
		protected TServer Server
		{
			[Token(Token = "0x60004E3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		protected TClient Client
		{
			[Token(Token = "0x60004E5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public string PlayerName
		{
			[Token(Token = "0x60004E7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Rooms Rooms
		{
			[Token(Token = "0x60004E9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public PlayerChannels PlayerChannels
		{
			[Token(Token = "0x60004EB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public RoomChannels RoomChannels
		{
			[Token(Token = "0x60004ED")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public CodecSettings CodecSettings
		{
			[Token(Token = "0x60004EF")]
			[CompilerGenerated]
			get
			{
				return default(CodecSettings);
			}
			[Token(Token = "0x60004F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000503")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000504")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public ConnectionStatus Status
		{
			[Token(Token = "0x6000505")]
			get
			{
				return default(ConnectionStatus);
			}
		}

		[Token(Token = "0x170000EF")]
		public NetworkMode Mode
		{
			[Token(Token = "0x6000506")]
			get
			{
				return default(NetworkMode);
			}
			[Token(Token = "0x6000507")]
			private set
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event Action<NetworkMode> ModeChanged
		{
			[Token(Token = "0x60004F1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event Action<string, CodecSettings> PlayerJoined
		{
			[Token(Token = "0x60004F3")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event Action<string> PlayerLeft
		{
			[Token(Token = "0x60004F5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event Action<VoicePacket> VoicePacketReceived
		{
			[Token(Token = "0x60004F7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event Action<TextMessage> TextPacketReceived
		{
			[Token(Token = "0x60004F9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event Action<string> PlayerStartedSpeaking
		{
			[Token(Token = "0x60004FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event Action<string> PlayerStoppedSpeaking
		{
			[Token(Token = "0x60004FD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60004FE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public event Action<RoomEvent> PlayerEnteredRoom
		{
			[Token(Token = "0x60004FF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public event Action<RoomEvent> PlayerExitedRoom
		{
			[Token(Token = "0x6000501")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000502")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000508")]
		protected BaseCommsNetwork()
		{
		}

		[Token(Token = "0x6000509")]
		[NotNull]
		protected abstract TServer CreateServer([CanBeNull] TServerParam connectionParameters);

		[Token(Token = "0x600050A")]
		[NotNull]
		protected abstract TClient CreateClient([CanBeNull] TClientParam connectionParameters);

		[Token(Token = "0x600050B")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600050C")]
		private void Dissonance.Networking.ICommsNetwork.Initialize([NotNull] string playerName, [NotNull] Rooms rooms, [NotNull] PlayerChannels playerChannels, [NotNull] RoomChannels roomChannels, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x600050D")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600050E")]
		private void LoadState()
		{
		}

		[Token(Token = "0x600050F")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000510")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000511")]
		protected void RunAsHost(TServerParam serverParameters, TClientParam clientParameters)
		{
		}

		[Token(Token = "0x6000512")]
		protected void RunAsClient(TClientParam clientParameters)
		{
		}

		[Token(Token = "0x6000513")]
		protected void RunAsDedicatedServer(TServerParam serverParameters)
		{
		}

		[Token(Token = "0x6000514")]
		private void ChangeState(IState newState)
		{
		}

		[Token(Token = "0x6000515")]
		private void StartServer([CanBeNull] TServerParam connectParams)
		{
		}

		[Token(Token = "0x6000516")]
		private void StopServer()
		{
		}

		[Token(Token = "0x6000517")]
		private void StartClient([CanBeNull] TClientParam connectParams)
		{
		}

		[Token(Token = "0x6000518")]
		private void StopClient()
		{
		}

		[Token(Token = "0x6000519")]
		public void SendVoice(ArraySegment<byte> data)
		{
		}

		[Token(Token = "0x600051A")]
		public void SendText(string data, ChannelType recipientType, string recipientId)
		{
		}

		[Token(Token = "0x600051B")]
		private void OnPlayerJoined(string obj, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x600051C")]
		private void OnPlayerLeft(string obj)
		{
		}

		[Token(Token = "0x600051D")]
		private void OnPlayerEnteredRoom(RoomEvent evt)
		{
		}

		[Token(Token = "0x600051E")]
		private void OnPlayerExitedRoom(RoomEvent evt)
		{
		}

		[Token(Token = "0x600051F")]
		private void OnVoicePacketReceived(VoicePacket obj)
		{
		}

		[Token(Token = "0x6000520")]
		private void OnTextPacketReceived(TextMessage obj)
		{
		}

		[Token(Token = "0x6000521")]
		private void OnPlayerStartedSpeaking(string obj)
		{
		}

		[Token(Token = "0x6000522")]
		private void OnPlayerStoppedSpeaking(string obj)
		{
		}

		[Token(Token = "0x6000523")]
		private void OnModeChanged(NetworkMode obj)
		{
		}

		[Token(Token = "0x6000524")]
		public void OnInspectorGui()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public abstract class BaseServer<TServer, TClient, TPeer> : IServer<TPeer> where TServer : BaseServer<TServer, TClient, TPeer> where TClient : BaseClient<TServer, TClient, TPeer> where TPeer : struct
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected readonly Log Log;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _disconnected;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _error;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ServerRelay<TPeer> _relay;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly BroadcastingClientCollection<TPeer> _clients;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly uint _sessionId;

		[Token(Token = "0x170000F3")]
		internal TrafficCounter RecvHandshakeRequest
		{
			[Token(Token = "0x6000536")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000537")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		internal TrafficCounter RecvClientState
		{
			[Token(Token = "0x6000538")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000539")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		internal TrafficCounter RecvPacketRelay
		{
			[Token(Token = "0x600053A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		internal TrafficCounter RecvDeltaChannelState
		{
			[Token(Token = "0x600053C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		internal TrafficCounter SentTraffic
		{
			[Token(Token = "0x600053E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600053F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public uint SessionId
		{
			[Token(Token = "0x6000540")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000541")]
		protected BaseServer()
		{
		}

		[Token(Token = "0x6000542")]
		public virtual void Connect()
		{
		}

		[Token(Token = "0x6000543")]
		public virtual void Disconnect()
		{
		}

		[Token(Token = "0x6000544")]
		protected void FatalError([NotNull] string reason)
		{
		}

		[Token(Token = "0x6000545")]
		protected void ClientDisconnected(TPeer connection)
		{
		}

		[Token(Token = "0x6000546")]
		public virtual ServerState Update()
		{
			return default(ServerState);
		}

		[Token(Token = "0x6000547")]
		private bool RunUpdate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000548")]
		protected abstract void SendReliable(TPeer connection, ArraySegment<byte> packet);

		[Token(Token = "0x6000549")]
		protected abstract void SendUnreliable(TPeer connection, ArraySegment<byte> packet);

		[Token(Token = "0x600054A")]
		public virtual void SendUnreliable([NotNull] List<TPeer> connections, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600054B")]
		public virtual void SendReliable([NotNull] List<TPeer> connections, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600054C")]
		private void Dissonance.Networking.Server.IServer<TPeer>.SendReliable(TPeer connection, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600054D")]
		private void Dissonance.Networking.Server.IServer<TPeer>.SendUnreliable(List<TPeer> connections, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600054E")]
		private void Dissonance.Networking.Server.IServer<TPeer>.SendReliable(List<TPeer> connections, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600054F")]
		protected abstract void ReadMessages();

		[Token(Token = "0x6000550")]
		public void NetworkReceivedPacket(TPeer source, ArraySegment<byte> data)
		{
		}

		[Token(Token = "0x6000551")]
		private bool CheckSessionId(ref PacketReader reader, TPeer source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000552")]
		protected virtual void AddClient(ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x6000553")]
		private void Dissonance.Networking.Server.IServer<TPeer>.AddClient(ClientInfo<TPeer> client)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	internal struct ChannelBitField
	{
		[Token(Token = "0x4000256")]
		private const ushort TypeMask = 1;

		[Token(Token = "0x4000257")]
		private const ushort PositionalMask = 2;

		[Token(Token = "0x4000258")]
		private const ushort ClosureMask = 4;

		[Token(Token = "0x4000259")]
		private const ushort PriorityOffset = 3;

		[Token(Token = "0x400025A")]
		private const ushort PriorityMask = 24;

		[Token(Token = "0x400025B")]
		private const ushort SessionIdOffset = 5;

		[Token(Token = "0x400025C")]
		private const ushort SessionIdMask = 97;

		[Token(Token = "0x400025D")]
		private const ushort AmplitudeOffset = 8;

		[Token(Token = "0x400025E")]
		private const ushort AmplitudeMask = 65280;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort _bitfield;

		[Token(Token = "0x170000F9")]
		public ushort Bitfield
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x9AF9D8", Offset = "0x9AF9D8", VA = "0x9AF9D8")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x170000FA")]
		public ChannelType Type
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x9AF9E0", Offset = "0x9AF9E0", VA = "0x9AF9E0")]
			get
			{
				return default(ChannelType);
			}
		}

		[Token(Token = "0x170000FB")]
		public bool IsClosing
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x9AF9F0", Offset = "0x9AF9F0", VA = "0x9AF9F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FC")]
		public bool IsPositional
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x9AF9FC", Offset = "0x9AF9FC", VA = "0x9AF9FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x9AFA08", Offset = "0x9AFA08", VA = "0x9AFA08")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x170000FE")]
		public float AmplitudeMultiplier
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x9AFA34", Offset = "0x9AFA34", VA = "0x9AFA34")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000FF")]
		public int SessionId
		{
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x9AFA50", Offset = "0x9AFA50", VA = "0x9AFA50")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x9AFA5C", Offset = "0x9AFA5C", VA = "0x9AFA5C")]
		public ChannelBitField(ushort bitfield)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x9AFA64", Offset = "0x9AFA64", VA = "0x9AFA64")]
		public ChannelBitField(ChannelType type, int sessionId, ChannelPriority priority, float amplitudeMult, bool positional, bool closing)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x9AFC04", Offset = "0x9AFC04", VA = "0x9AFC04")]
		private static ushort PackPriority(ChannelPriority priority)
		{
			return default(ushort);
		}
	}
	[Token(Token = "0x20000BD")]
	internal sealed class ClientIdCollection : IReadonlyClientIdCollection
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<string> _items;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<ushort> _freeIds;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IEnumerable<KeyValuePair<ushort, string>> _alive;

		[Token(Token = "0x17000100")]
		[NotNull]
		public IEnumerable<KeyValuePair<ushort, string>> Items
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x9AFC34", Offset = "0x9AFC34", VA = "0x9AFC34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x9AFC3C", Offset = "0x9AFC3C", VA = "0x9AFC3C")]
		public ClientIdCollection()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9AFE90", Offset = "0x9AFE90", VA = "0x9AFE90")]
		private ushort GetFreeId()
		{
			return default(ushort);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x9AFF80", Offset = "0x9AFF80", VA = "0x9AFF80")]
		private void AddFreeId(ushort id)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x9B0084", Offset = "0x9B0084", VA = "0x9B0084", Slot = "5")]
		public string GetName(ushort id)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9B0104", Offset = "0x9B0104", VA = "0x9B0104", Slot = "4")]
		public ushort? GetId(string name)
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9B01E4", Offset = "0x9B01E4", VA = "0x9B01E4")]
		public ushort Register([NotNull] string name)
		{
			return default(ushort);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x9B03B8", Offset = "0x9B03B8", VA = "0x9B03B8")]
		public bool Unregister([NotNull] string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x9B0534", Offset = "0x9B0534", VA = "0x9B0534")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x9B05BC", Offset = "0x9B05BC", VA = "0x9B05BC")]
		public void Load([NotNull] List<ClientInfo> clients)
		{
		}
	}
	[Token(Token = "0x20000BF")]
	internal interface IReadonlyClientIdCollection
	{
		[Token(Token = "0x600056D")]
		ushort? GetId([NotNull] string name);

		[Token(Token = "0x600056E")]
		[CanBeNull]
		string GetName(ushort id);
	}
	[Token(Token = "0x20000C0")]
	internal struct ClientInfo
	{
		[Token(Token = "0x17000101")]
		public string PlayerName
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x9B0A84", Offset = "0x9B0A84", VA = "0x9B0A84")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x9B0A8C", Offset = "0x9B0A8C", VA = "0x9B0A8C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public ushort PlayerId
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x9B0A94", Offset = "0x9B0A94", VA = "0x9B0A94")]
			[CompilerGenerated]
			readonly get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x9B0A9C", Offset = "0x9B0A9C", VA = "0x9B0A9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public CodecSettings CodecSettings
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x9B0AA4", Offset = "0x9B0AA4", VA = "0x9B0AA4")]
			[CompilerGenerated]
			readonly get
			{
				return default(CodecSettings);
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x9B0AB4", Offset = "0x9B0AB4", VA = "0x9B0AB4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x9B0AC0", Offset = "0x9B0AC0", VA = "0x9B0AC0")]
		public ClientInfo(string playerName, ushort playerId, CodecSettings codecSettings)
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class ClientInfo<TPeer> : IEquatable<ClientInfo<TPeer>>
	{
		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _playerName;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ushort _playerId;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CodecSettings _codecSettings;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<string> _rooms;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadOnlyCollection<string> _roomsReadonly;

		[Token(Token = "0x17000104")]
		[NotNull]
		public string PlayerName
		{
			[Token(Token = "0x6000576")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000105")]
		public ushort PlayerId
		{
			[Token(Token = "0x6000577")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000106")]
		public CodecSettings CodecSettings
		{
			[Token(Token = "0x6000578")]
			get
			{
				return default(CodecSettings);
			}
		}

		[Token(Token = "0x17000107")]
		[NotNull]
		internal ReadOnlyCollection<string> Rooms
		{
			[Token(Token = "0x6000579")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		[CanBeNull]
		public TPeer Connection
		{
			[Token(Token = "0x600057A")]
			[CompilerGenerated]
			get
			{
				return (TPeer)null;
			}
			[Token(Token = "0x600057B")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool IsConnected
		{
			[Token(Token = "0x600057C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057D")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		internal PeerVoiceReceiver VoiceReceiver
		{
			[Token(Token = "0x600057E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600057F")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000580")]
		public ClientInfo(string playerName, ushort playerId, CodecSettings codecSettings, [CanBeNull] TPeer connection)
		{
		}

		[Token(Token = "0x6000581")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		public bool Equals(ClientInfo<TPeer> other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000584")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000585")]
		public bool AddRoom([NotNull] string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000586")]
		public bool RemoveRoom([NotNull] string roomName)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C2")]
	public struct VoicePacket
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string SenderPlayerId;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly ArraySegment<byte> EncodedAudioFrame;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly uint SequenceNumber;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[CanBeNull]
		public readonly List<RemoteChannel> Channels;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly PlaybackOptions _options;

		[Token(Token = "0x1700010B")]
		[Obsolete("Use `PlaybackOptions.IsPositional` property")]
		public bool Positional
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x9B0AD8", Offset = "0x9B0AD8", VA = "0x9B0AD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		[Obsolete("Use `PlaybackOptions.Priority` property")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x9B0AE8", Offset = "0x9B0AE8", VA = "0x9B0AE8")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x1700010D")]
		[Obsolete("Use `PlaybackOptions.AmplitudeMultiplier` property")]
		public float AmplitudeMultiplier
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x9B0AF0", Offset = "0x9B0AF0", VA = "0x9B0AF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700010E")]
		public PlaybackOptions PlaybackOptions
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x9B0AF8", Offset = "0x9B0AF8", VA = "0x9B0AF8")]
			get
			{
				return default(PlaybackOptions);
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x9B0B08", Offset = "0x9B0B08", VA = "0x9B0B08")]
		public VoicePacket(string senderPlayerId, ChannelPriority priority, float ampMul, bool positional, ArraySegment<byte> encodedAudioFrame, uint sequence, [Optional][CanBeNull] List<RemoteChannel> channels)
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public struct TextMessage
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string Sender;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly ChannelType RecipientType;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Recipient;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Message;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x9B0B48", Offset = "0x9B0B48", VA = "0x9B0B48")]
		public TextMessage(string sender, ChannelType recipientType, string recipient, string message)
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public struct RoomEvent
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string PlayerName;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Room;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Joined;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ReadOnlyCollection<string> Rooms;

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x9B0B58", Offset = "0x9B0B58", VA = "0x9B0B58")]
		internal RoomEvent([NotNull] string name, [NotNull] string room, bool joined, [NotNull] ReadOnlyCollection<string> rooms)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public enum NetworkMode
	{
		[Token(Token = "0x4000281")]
		None,
		[Token(Token = "0x4000282")]
		Host,
		[Token(Token = "0x4000283")]
		Client,
		[Token(Token = "0x4000284")]
		DedicatedServer
	}
	[Token(Token = "0x20000C6")]
	public enum ConnectionStatus
	{
		[Token(Token = "0x4000286")]
		Disconnected,
		[Token(Token = "0x4000287")]
		Degraded,
		[Token(Token = "0x4000288")]
		Connected
	}
	[Token(Token = "0x20000C7")]
	public static class NetworkModeExtensions
	{
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x9B0B6C", Offset = "0x9B0B6C", VA = "0x9B0B6C")]
		public static bool IsServerEnabled(this NetworkMode mode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x9B0BF4", Offset = "0x9B0BF4", VA = "0x9B0BF4")]
		public static bool IsClientEnabled(this NetworkMode mode)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C8")]
	public interface ICommsNetwork
	{
		[Token(Token = "0x1700010F")]
		ConnectionStatus Status
		{
			[Token(Token = "0x6000591")]
			get;
		}

		[Token(Token = "0x17000110")]
		NetworkMode Mode
		{
			[Token(Token = "0x6000595")]
			get;
		}

		[Token(Token = "0x14000027")]
		event Action<NetworkMode> ModeChanged;

		[Token(Token = "0x14000028")]
		event Action<string, CodecSettings> PlayerJoined;

		[Token(Token = "0x14000029")]
		event Action<string> PlayerLeft;

		[Token(Token = "0x1400002A")]
		event Action<VoicePacket> VoicePacketReceived;

		[Token(Token = "0x1400002B")]
		event Action<TextMessage> TextPacketReceived;

		[Token(Token = "0x1400002C")]
		event Action<string> PlayerStartedSpeaking;

		[Token(Token = "0x1400002D")]
		event Action<string> PlayerStoppedSpeaking;

		[Token(Token = "0x1400002E")]
		event Action<RoomEvent> PlayerEnteredRoom;

		[Token(Token = "0x1400002F")]
		event Action<RoomEvent> PlayerExitedRoom;

		[Token(Token = "0x6000592")]
		void Initialize(string playerName, Rooms rooms, PlayerChannels playerChannels, RoomChannels roomChannels, CodecSettings codecSettings);

		[Token(Token = "0x60005A6")]
		void SendVoice(ArraySegment<byte> data);

		[Token(Token = "0x60005A7")]
		void SendText(string data, ChannelType recipientType, string recipientId);
	}
	[Token(Token = "0x20000C9")]
	public interface ICommsNetworkState
	{
		[Token(Token = "0x17000111")]
		string PlayerName
		{
			[Token(Token = "0x60005A8")]
			get;
		}

		[Token(Token = "0x17000112")]
		Rooms Rooms
		{
			[Token(Token = "0x60005A9")]
			get;
		}

		[Token(Token = "0x17000113")]
		PlayerChannels PlayerChannels
		{
			[Token(Token = "0x60005AA")]
			get;
		}

		[Token(Token = "0x17000114")]
		RoomChannels RoomChannels
		{
			[Token(Token = "0x60005AB")]
			get;
		}

		[Token(Token = "0x17000115")]
		CodecSettings CodecSettings
		{
			[Token(Token = "0x60005AC")]
			get;
		}
	}
	[Token(Token = "0x20000CA")]
	public struct PlayerInfo
	{
		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string Name;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly CodecSettings CodecSettings;

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x9B0C88", Offset = "0x9B0C88", VA = "0x9B0C88")]
		public PlayerInfo(string name, CodecSettings codecSettings)
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public interface IServerAdministration
	{
		[Token(Token = "0x60005AE")]
		void GetPlayers([NotNull] List<PlayerInfo> output);

		[Token(Token = "0x60005AF")]
		CodecSettings GetCodecSettings(string playerId);

		[Token(Token = "0x60005B0")]
		void GetChannels(string playerId, [NotNull] List<string> output);

		[Token(Token = "0x60005B1")]
		void AddEverntFilter([NotNull] IServerEventFilter filter);

		[Token(Token = "0x60005B2")]
		void Mute(string playerId, bool muted);

		[Token(Token = "0x60005B3")]
		void Deafen(string playerId, bool deafened);

		[Token(Token = "0x60005B4")]
		void Kick(string playerId, string channelId);

		[Token(Token = "0x60005B5")]
		void Kick(string playerId);
	}
	[Token(Token = "0x20000CC")]
	public enum FilterResult
	{
		[Token(Token = "0x400028C")]
		None,
		[Token(Token = "0x400028D")]
		SoftDeny,
		[Token(Token = "0x400028E")]
		SoftAllow,
		[Token(Token = "0x400028F")]
		Allow,
		[Token(Token = "0x4000290")]
		Deny
	}
	[Token(Token = "0x20000CD")]
	public interface IServerEventFilter
	{
		[Token(Token = "0x60005B6")]
		FilterResult AllowJoinSession(string playerId, CodecSettings settings);

		[Token(Token = "0x60005B7")]
		FilterResult AllowChannelListen(string playerId, ChannelType type, string channelId);

		[Token(Token = "0x60005B8")]
		FilterResult AllowChannelSendVoice(string playerId, ChannelType type, string channelId);

		[Token(Token = "0x60005B9")]
		FilterResult AllowChannelSendText(string playerId, ChannelType type, string channelId, string message);
	}
	[Token(Token = "0x20000CE")]
	internal enum MessageTypes : byte
	{
		[Token(Token = "0x4000292")]
		ClientState = 1,
		[Token(Token = "0x4000293")]
		VoiceData,
		[Token(Token = "0x4000294")]
		TextData,
		[Token(Token = "0x4000295")]
		HandshakeRequest,
		[Token(Token = "0x4000296")]
		HandshakeResponse,
		[Token(Token = "0x4000297")]
		ErrorWrongSession,
		[Token(Token = "0x4000298")]
		ServerRelayReliable,
		[Token(Token = "0x4000299")]
		ServerRelayUnreliable,
		[Token(Token = "0x400029A")]
		DeltaChannelState,
		[Token(Token = "0x400029B")]
		RemoveClient,
		[Token(Token = "0x400029C")]
		HandshakeP2P
	}
	[Token(Token = "0x20000CF")]
	internal struct PacketReader
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ArraySegment<byte> _array;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _count;

		[Token(Token = "0x17000116")]
		public ArraySegment<byte> Read
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x9B0C94", Offset = "0x9B0C94", VA = "0x9B0C94")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x17000117")]
		public ArraySegment<byte> Unread
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x9B0D14", Offset = "0x9B0D14", VA = "0x9B0D14")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x17000118")]
		public ArraySegment<byte> All
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x9B0DA8", Offset = "0x9B0DA8", VA = "0x9B0DA8")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x9B0DB4", Offset = "0x9B0DB4", VA = "0x9B0DB4")]
		public PacketReader(ArraySegment<byte> array)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x9B0E54", Offset = "0x9B0E54", VA = "0x9B0E54")]
		public PacketReader([NotNull] byte[] array)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x9B0EC8", Offset = "0x9B0EC8", VA = "0x9B0EC8")]
		private void Check(int count, string type)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x9B0FA4", Offset = "0x9B0FA4", VA = "0x9B0FA4")]
		private byte FastReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x9B1020", Offset = "0x9B1020", VA = "0x9B1020")]
		public byte ReadByte()
		{
			return default(byte);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x9B1074", Offset = "0x9B1074", VA = "0x9B1074")]
		public ushort ReadUInt16()
		{
			return default(ushort);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x9B11EC", Offset = "0x9B11EC", VA = "0x9B11EC")]
		public uint ReadUInt32()
		{
			return default(uint);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9B1330", Offset = "0x9B1330", VA = "0x9B1330")]
		public ArraySegment<byte> ReadByteSegment()
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x9B1404", Offset = "0x9B1404", VA = "0x9B1404")]
		[CanBeNull]
		public string ReadString()
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9B14DC", Offset = "0x9B14DC", VA = "0x9B14DC")]
		public CodecSettings ReadCodecSettings()
		{
			return default(CodecSettings);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9B1540", Offset = "0x9B1540", VA = "0x9B1540")]
		public ClientInfo ReadClientInfo()
		{
			return default(ClientInfo);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x9B1594", Offset = "0x9B1594", VA = "0x9B1594")]
		public bool ReadPacketHeader(out MessageTypes messageType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x9B15E0", Offset = "0x9B15E0", VA = "0x9B15E0")]
		public void ReadHandshakeRequest([CanBeNull] out string name, out CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x9B1618", Offset = "0x9B1618", VA = "0x9B1618")]
		public void ReadHandshakeResponseHeader(out uint session, out ushort clientId)
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x9B164C", Offset = "0x9B164C", VA = "0x9B164C")]
		public void ReadHandshakeResponseBody([NotNull] List<ClientInfo> clients, [NotNull] Dictionary<string, List<ushort>> outputRoomsToPeerId)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x9B1C1C", Offset = "0x9B1C1C", VA = "0x9B1C1C")]
		public void ReadhandshakeP2P(out ushort peerId)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x9B1C34", Offset = "0x9B1C34", VA = "0x9B1C34")]
		public ClientInfo ReadClientStateHeader()
		{
			return default(ClientInfo);
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x9B1CF4", Offset = "0x9B1CF4", VA = "0x9B1CF4")]
		public void ReadClientStateRooms([NotNull][ItemNotNull] List<string> rooms)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x9B1E3C", Offset = "0x9B1E3C", VA = "0x9B1E3C")]
		public void ReadRemoveClient(out ushort clientId)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x9B1E54", Offset = "0x9B1E54", VA = "0x9B1E54")]
		public void ReadVoicePacketHeader1(out ushort senderId)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x9B1E6C", Offset = "0x9B1E6C", VA = "0x9B1E6C")]
		public void ReadVoicePacketHeader2(out VoicePacketOptions options, out ushort sequenceNumber, out ushort numChannels)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x9B1EC0", Offset = "0x9B1EC0", VA = "0x9B1EC0")]
		public void ReadVoicePacketChannel(out ChannelBitField bitfield, out ushort recipient)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x9B1EF4", Offset = "0x9B1EF4", VA = "0x9B1EF4")]
		public TextPacket ReadTextPacket()
		{
			return default(TextPacket);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x9B1F6C", Offset = "0x9B1F6C", VA = "0x9B1F6C")]
		public uint ReadErrorWrongSession()
		{
			return default(uint);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x9B1F70", Offset = "0x9B1F70", VA = "0x9B1F70")]
		public void ReadRelay(List<ushort> destinations, out ArraySegment<byte> data)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x9B204C", Offset = "0x9B204C", VA = "0x9B204C")]
		public void ReadDeltaChannelState(out bool joined, out ushort peer, [NotNull] out string name)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	internal struct PacketWriter
	{
		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002A1")]
		internal const ushort Magic = 35783;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ArraySegment<byte> _array;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _count;

		[Token(Token = "0x17000119")]
		public ArraySegment<byte> Written
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x9B2218", Offset = "0x9B2218", VA = "0x9B2218")]
			get
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x9B2298", Offset = "0x9B2298", VA = "0x9B2298")]
		public PacketWriter([NotNull] byte[] array)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x9B230C", Offset = "0x9B230C", VA = "0x9B230C")]
		public PacketWriter(ArraySegment<byte> array)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9B23AC", Offset = "0x9B23AC", VA = "0x9B23AC")]
		private void Check(int count, string type)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x9B2488", Offset = "0x9B2488", VA = "0x9B2488")]
		public PacketWriter FastWriteByte(byte b)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x9B2528", Offset = "0x9B2528", VA = "0x9B2528")]
		public PacketWriter Write(byte b)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x9B25B0", Offset = "0x9B25B0", VA = "0x9B25B0")]
		public PacketWriter Write(ushort u)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x9B2724", Offset = "0x9B2724", VA = "0x9B2724")]
		public PacketWriter Write(uint u)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x9B28B8", Offset = "0x9B28B8", VA = "0x9B28B8")]
		public PacketWriter Write([CanBeNull] string s)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x9B2A70", Offset = "0x9B2A70", VA = "0x9B2A70")]
		public PacketWriter Write(ArraySegment<byte> data)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x9B2B68", Offset = "0x9B2B68", VA = "0x9B2B68")]
		public PacketWriter Write(CodecSettings codecSettings)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x9B2BD4", Offset = "0x9B2BD4", VA = "0x9B2BD4")]
		public PacketWriter Write(string playerName, ushort playerId, CodecSettings codecSettings)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x9B2C48", Offset = "0x9B2C48", VA = "0x9B2C48")]
		internal PacketWriter WriteMagic()
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9B2C7C", Offset = "0x9B2C7C", VA = "0x9B2C7C")]
		public PacketWriter WriteHandshakeRequest([NotNull] string name, CodecSettings codecSettings)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E6")]
		public PacketWriter WriteHandshakeResponse<TPeer>(uint session, ushort clientId, [NotNull] List<ClientInfo<TPeer>> clients, [NotNull] Dictionary<string, List<ClientInfo<TPeer>>> peersByRoom)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9B2D04", Offset = "0x9B2D04", VA = "0x9B2D04")]
		public PacketWriter WriteHandshakeP2P(uint session, ushort peerId)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9B2D84", Offset = "0x9B2D84", VA = "0x9B2D84")]
		public PacketWriter WriteClientState(uint session, [NotNull] string name, ushort clientId, CodecSettings codecSettings, [NotNull] Rooms rooms)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x9B2E60", Offset = "0x9B2E60", VA = "0x9B2E60")]
		public PacketWriter WriteClientState(uint session, [NotNull] string name, ushort clientId, CodecSettings codecSettings, [NotNull] ReadOnlyCollection<string> rooms)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x9B3058", Offset = "0x9B3058", VA = "0x9B3058")]
		public PacketWriter WriteRemoveClient(uint session, ushort clientId)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9B30D8", Offset = "0x9B30D8", VA = "0x9B30D8")]
		internal PacketWriter WriteVoiceData(uint session, ushort senderId, ushort sequenceNumber, byte channelSession, [NotNull] IList<OpenChannel> channels, ArraySegment<byte> encodedAudio)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9B345C", Offset = "0x9B345C", VA = "0x9B345C")]
		internal PacketWriter WriteTextPacket(uint session, ushort senderId, ChannelType recipient, ushort target, string data)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9B3520", Offset = "0x9B3520", VA = "0x9B3520")]
		public PacketWriter WriteErrorWrongSession(uint session)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005EE")]
		public PacketWriter WriteRelay<TPeer>(uint session, [NotNull] List<ClientInfo<TPeer>> destinations, ArraySegment<byte> segment, bool reliable)
		{
			return default(PacketWriter);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9B3584", Offset = "0x9B3584", VA = "0x9B3584")]
		public PacketWriter WriteDeltaChannelState(uint session, bool joined, ushort peer, [NotNull] string name)
		{
			return default(PacketWriter);
		}
	}
	[Token(Token = "0x20000D1")]
	internal class RoomClientsCollection<T>
	{
		[Token(Token = "0x20000D2")]
		private class ClientIdComparer : IComparer<ClientInfo<T>>
		{
			[Token(Token = "0x60005FA")]
			public int Compare(ClientInfo<T> x, ClientInfo<T> y)
			{
				return default(int);
			}

			[Token(Token = "0x60005FB")]
			public ClientIdComparer()
			{
			}
		}

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly IComparer<ClientInfo<T>> ClientComparer;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, List<ClientInfo<T>>> _clientByRoomName;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<ushort, List<ClientInfo<T>>> _clientByRoomId;

		[Token(Token = "0x1700011A")]
		public Dictionary<string, List<ClientInfo<T>>> ByName
		{
			[Token(Token = "0x60005F1")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F2")]
		public void Add([NotNull] string room, [NotNull] ClientInfo<T> client)
		{
		}

		[Token(Token = "0x60005F3")]
		public bool Remove([NotNull] string room, [NotNull] ClientInfo<T> client)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005F5")]
		[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
		public bool TryGetClientsInRoom([NotNull] string room, out List<ClientInfo<T>> clients)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[ContractAnnotation("=> true, clients:notnull; => false, clients:null")]
		public bool TryGetClientsInRoom(ushort roomId, out List<ClientInfo<T>> clients)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		public int ClientCount()
		{
			return default(int);
		}

		[Token(Token = "0x60005F8")]
		public RoomClientsCollection()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	internal struct TextPacket
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly ushort Sender;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public readonly ChannelType RecipientType;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly ushort Recipient;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[CanBeNull]
		public readonly string Text;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x9B1F58", Offset = "0x9B1F58", VA = "0x9B1F58")]
		public TextPacket(ushort sender, ChannelType recipientType, ushort recipient, [CanBeNull] string text)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	internal class TrafficCounter
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint _runningTotal;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Queue<KeyValuePair<DateTime, uint>> _updated;

		[Token(Token = "0x1700011B")]
		public uint Packets
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x9B3764", Offset = "0x9B3764", VA = "0x9B3764")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x9B376C", Offset = "0x9B376C", VA = "0x9B376C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public uint Bytes
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x9B3774", Offset = "0x9B3774", VA = "0x9B3774")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x9B377C", Offset = "0x9B377C", VA = "0x9B377C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public uint BytesPerSecond
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x9B3784", Offset = "0x9B3784", VA = "0x9B3784")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x9B378C", Offset = "0x9B378C", VA = "0x9B378C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x9B3794", Offset = "0x9B3794", VA = "0x9B3794")]
		public void Update(int bytes, [Optional] DateTime? now)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x9B39F0", Offset = "0x9B39F0", VA = "0x9B39F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x9B3AE4", Offset = "0x9B3AE4", VA = "0x9B3AE4")]
		public static void Combine(out uint packets, out uint bytes, out uint totalBytesPerSecond, [ItemNotNull][NotNull] params TrafficCounter[] counters)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x9B3A00", Offset = "0x9B3A00", VA = "0x9B3A00")]
		[NotNull]
		public static string Format(ulong packets, ulong bytes, ulong bytesPerSecond)
		{
			return null;
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x9B3B70", Offset = "0x9B3B70", VA = "0x9B3B70")]
		[NotNull]
		private static string FormatByteString(decimal bytes)
		{
			return null;
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9B3D98", Offset = "0x9B3D98", VA = "0x9B3D98")]
		public TrafficCounter()
		{
		}
	}
}
namespace Dissonance.Networking.Server
{
	[Token(Token = "0x20000D5")]
	internal interface IServer<TPeer>
	{
		[Token(Token = "0x1700011E")]
		uint SessionId
		{
			[Token(Token = "0x6000609")]
			get;
		}

		[Token(Token = "0x600060A")]
		void SendUnreliable([NotNull] List<TPeer> connections, ArraySegment<byte> packet);

		[Token(Token = "0x600060B")]
		void SendReliable(TPeer connection, ArraySegment<byte> packet);

		[Token(Token = "0x600060C")]
		void SendReliable([NotNull] List<TPeer> connections, ArraySegment<byte> packet);

		[Token(Token = "0x600060D")]
		void AddClient([NotNull] ClientInfo<TPeer> client);
	}
	[Token(Token = "0x20000D6")]
	internal class BroadcastingClientCollection<TPeer> : BaseClientCollection<TPeer>
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IServer<TPeer> _server;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly byte[] _tmpSendBuffer;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<TPeer> _tmpConnectionBuffer;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<ClientInfo<TPeer>> _tmpClientBuffer;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<ClientInfo<TPeer>> _tmpClientBufferHandshake;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Dictionary<string, List<ClientInfo<TPeer>>> _tmpClientByRoomsBufferHandshake;

		[Token(Token = "0x600060E")]
		public BroadcastingClientCollection(IServer<TPeer> server)
		{
		}

		[Token(Token = "0x600060F")]
		protected override void OnRemovedClient(ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x6000610")]
		protected override void OnAddedClient(ClientInfo<TPeer> client)
		{
		}

		[Token(Token = "0x6000611")]
		public void ProcessHandshakeRequest(TPeer source, ref PacketReader reader)
		{
		}

		[Token(Token = "0x6000612")]
		private void SendFakeClientState(TPeer destination, [NotNull] ClientInfo<TPeer> clientInfo)
		{
		}

		[Token(Token = "0x6000613")]
		public override void ProcessClientState(TPeer source, ref PacketReader reader)
		{
		}

		[Token(Token = "0x6000614")]
		public override void ProcessDeltaChannelState(ref PacketReader reader)
		{
		}

		[Token(Token = "0x6000615")]
		private void Broadcast(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x6000616")]
		public void RemoveClient(TPeer connection)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	internal class ServerRelay<TPeer>
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IServer<TPeer> _server;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly BaseClientCollection<TPeer> _peers;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<TPeer> _tmpPeerBuffer;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<ushort> _tmpIdBuffer;

		[Token(Token = "0x6000617")]
		public ServerRelay(IServer<TPeer> server, BaseClientCollection<TPeer> peers)
		{
		}

		[Token(Token = "0x6000618")]
		public void ProcessPacketRelay(ref PacketReader reader, bool reliable)
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public enum ServerState
	{
		[Token(Token = "0x40002BC")]
		Ok,
		[Token(Token = "0x40002BD")]
		Error
	}
}
namespace Dissonance.Networking.Client
{
	[Token(Token = "0x20000D9")]
	public enum ClientStatus
	{
		[Token(Token = "0x40002BF")]
		Ok,
		[Token(Token = "0x40002C0")]
		Error
	}
	[Token(Token = "0x20000DA")]
	internal enum ConnectionState
	{
		[Token(Token = "0x40002C2")]
		None,
		[Token(Token = "0x40002C3")]
		Negotiating,
		[Token(Token = "0x40002C4")]
		Connected,
		[Token(Token = "0x40002C5")]
		Disconnected
	}
	[Token(Token = "0x20000DB")]
	internal class ConnectionNegotiator<TPeer> : ISession where TPeer : struct
	{
		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TimeSpan HandshakeRequestInterval;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISendQueue<TPeer> _sender;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _playerName;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CodecSettings _codecSettings;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DateTime _lastHandshakeRequest;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _running;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _connectionStateValue;

		[Token(Token = "0x1700011F")]
		public ConnectionState State
		{
			[Token(Token = "0x600061A")]
			get
			{
				return default(ConnectionState);
			}
		}

		[Token(Token = "0x17000120")]
		public uint SessionId
		{
			[Token(Token = "0x600061B")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600061C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public ushort? LocalId
		{
			[Token(Token = "0x600061D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600061E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public string LocalName
		{
			[Token(Token = "0x600061F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000620")]
		public ConnectionNegotiator([NotNull] ISendQueue<TPeer> sender, string playerName, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x6000621")]
		public void ReceiveHandshakeResponseHeader(ref PacketReader reader)
		{
		}

		[Token(Token = "0x6000622")]
		public void Start()
		{
		}

		[Token(Token = "0x6000623")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000624")]
		public void Update(DateTime utcNow)
		{
		}

		[Token(Token = "0x6000625")]
		private void SendHandshake(DateTime utcNow)
		{
		}
	}
	[Token(Token = "0x20000DC")]
	internal interface ISession
	{
		[Token(Token = "0x17000123")]
		uint SessionId
		{
			[Token(Token = "0x6000627")]
			get;
		}

		[Token(Token = "0x17000124")]
		ushort? LocalId
		{
			[Token(Token = "0x6000628")]
			get;
		}

		[Token(Token = "0x17000125")]
		[NotNull]
		string LocalName
		{
			[Token(Token = "0x6000629")]
			get;
		}
	}
	[Token(Token = "0x20000DD")]
	internal class EventQueue
	{
		[Token(Token = "0x20000DE")]
		private enum EventType
		{
			[Token(Token = "0x40002E3")]
			PlayerJoined,
			[Token(Token = "0x40002E4")]
			PlayerLeft,
			[Token(Token = "0x40002E5")]
			PlayerEnteredRoom,
			[Token(Token = "0x40002E6")]
			PlayerExitedRoom,
			[Token(Token = "0x40002E7")]
			PlayerStartedSpeaking,
			[Token(Token = "0x40002E8")]
			PlayerStoppedSpeaking,
			[Token(Token = "0x40002E9")]
			VoiceData,
			[Token(Token = "0x40002EA")]
			TextMessage
		}

		[Token(Token = "0x20000DF")]
		private struct NetworkEvent
		{
			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly EventType Type;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private string _playerName;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private CodecSettings _codecSettings;

			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private string _room;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ReadOnlyCollection<string> _allRooms;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private readonly VoicePacket _voicePacket;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private readonly TextMessage _textMessage;

			[Token(Token = "0x17000126")]
			public string PlayerName
			{
				[Token(Token = "0x600064C")]
				[Address(RVA = "0x9B747C", Offset = "0x9B747C", VA = "0x9B747C")]
				get
				{
					return null;
				}
				[Token(Token = "0x600064D")]
				[Address(RVA = "0x9B7484", Offset = "0x9B7484", VA = "0x9B7484")]
				set
				{
				}
			}

			[Token(Token = "0x17000127")]
			public CodecSettings CodecSettings
			{
				[Token(Token = "0x600064E")]
				[Address(RVA = "0x9B5788", Offset = "0x9B5788", VA = "0x9B5788")]
				get
				{
					return default(CodecSettings);
				}
				[Token(Token = "0x600064F")]
				[Address(RVA = "0x9B5B00", Offset = "0x9B5B00", VA = "0x9B5B00")]
				set
				{
				}
			}

			[Token(Token = "0x17000128")]
			public string Room
			{
				[Token(Token = "0x6000650")]
				[Address(RVA = "0x9B57E8", Offset = "0x9B57E8", VA = "0x9B57E8")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000651")]
				[Address(RVA = "0x9B6150", Offset = "0x9B6150", VA = "0x9B6150")]
				set
				{
				}
			}

			[Token(Token = "0x17000129")]
			[NotNull]
			public ReadOnlyCollection<string> AllRooms
			{
				[Token(Token = "0x6000652")]
				[Address(RVA = "0x9B57F0", Offset = "0x9B57F0", VA = "0x9B57F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000653")]
				[Address(RVA = "0x9B6158", Offset = "0x9B6158", VA = "0x9B6158")]
				set
				{
				}
			}

			[Token(Token = "0x1700012A")]
			public VoicePacket VoicePacket
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x9B5798", Offset = "0x9B5798", VA = "0x9B5798")]
				get
				{
					return default(VoicePacket);
				}
			}

			[Token(Token = "0x1700012B")]
			public TextMessage TextMessage
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x9B57B4", Offset = "0x9B57B4", VA = "0x9B57B4")]
				get
				{
					return default(TextMessage);
				}
			}

			[Token(Token = "0x6000656")]
			[Address(RVA = "0x9B5ADC", Offset = "0x9B5ADC", VA = "0x9B5ADC")]
			public NetworkEvent(EventType type)
			{
			}

			[Token(Token = "0x6000657")]
			[Address(RVA = "0x9B6DF0", Offset = "0x9B6DF0", VA = "0x9B6DF0")]
			public NetworkEvent(VoicePacket voice)
			{
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x9B7144", Offset = "0x9B7144", VA = "0x9B7144")]
			public NetworkEvent(TextMessage text)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x9B748C", Offset = "0x9B748C", VA = "0x9B748C")]
			private void Check(EventType type)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x9B7490", Offset = "0x9B7490", VA = "0x9B7490")]
			private void Check(EventType typeA, EventType typeB)
			{
			}
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ReadonlyLockedValue<List<NetworkEvent>> _queuedEvents;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ReadonlyLockedValue<Pool<byte[]>> _byteArrayPool;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[NotNull]
		private readonly IRecycler<List<RemoteChannel>> _channelsListPool;

		[Token(Token = "0x40002DD")]
		private const int MinWarnPacketCountThreshold = 12;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan MinWarnDispatchTimeThreshold;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _voicePacketWarnThreshold;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int _pendingVoicePackets;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DateTime _previousFlush;

		[Token(Token = "0x14000030")]
		public event Action<string, CodecSettings> PlayerJoined
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x9B3E18", Offset = "0x9B3E18", VA = "0x9B3E18")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x9B3EC8", Offset = "0x9B3EC8", VA = "0x9B3EC8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000031")]
		public event Action<string> PlayerLeft
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x9B3F78", Offset = "0x9B3F78", VA = "0x9B3F78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x9B4028", Offset = "0x9B4028", VA = "0x9B4028")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public event Action<RoomEvent> PlayerEnteredRoom
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x9B40D8", Offset = "0x9B40D8", VA = "0x9B40D8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x9B4188", Offset = "0x9B4188", VA = "0x9B4188")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000033")]
		public event Action<RoomEvent> PlayerExitedRoom
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x9B4238", Offset = "0x9B4238", VA = "0x9B4238")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x9B42E8", Offset = "0x9B42E8", VA = "0x9B42E8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000034")]
		public event Action<VoicePacket> VoicePacketReceived
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x9B4398", Offset = "0x9B4398", VA = "0x9B4398")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x9B4448", Offset = "0x9B4448", VA = "0x9B4448")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public event Action<TextMessage> TextMessageReceived
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x9B44F8", Offset = "0x9B44F8", VA = "0x9B44F8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x9B45A8", Offset = "0x9B45A8", VA = "0x9B45A8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000036")]
		public event Action<string> PlayerStartedSpeaking
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x9B4658", Offset = "0x9B4658", VA = "0x9B4658")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x9B4708", Offset = "0x9B4708", VA = "0x9B4708")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000037")]
		public event Action<string> PlayerStoppedSpeaking
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x9B47B8", Offset = "0x9B47B8", VA = "0x9B47B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x9B4868", Offset = "0x9B4868", VA = "0x9B4868")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000038")]
		internal event Action<string> OnEnqueuePlayerLeft
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x9B4918", Offset = "0x9B4918", VA = "0x9B4918")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x9B49C8", Offset = "0x9B49C8", VA = "0x9B49C8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x9B4A78", Offset = "0x9B4A78", VA = "0x9B4A78")]
		public EventQueue([NotNull] ReadonlyLockedValue<Pool<byte[]>> byteArrayPool, [NotNull] IRecycler<List<RemoteChannel>> channelsListPool)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x9B4C0C", Offset = "0x9B4C0C", VA = "0x9B4C0C")]
		public bool DispatchEvents([Optional] DateTime? utcNow)
		{
			return default(bool);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x9B55B4", Offset = "0x9B55B4", VA = "0x9B55B4")]
		private void PreDispatchLog(DateTime utcNow)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x9B57C4", Offset = "0x9B57C4", VA = "0x9B57C4")]
		private static RoomEvent CreateRoomEvent(NetworkEvent @event, bool joined)
		{
			return default(RoomEvent);
		}

		[Token(Token = "0x6000640")]
		private static bool InvokeEvent<T>(T arg, [CanBeNull] Action<T> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		private static bool InvokeEvent<T1, T2>(T1 arg1, T2 arg2, [CanBeNull] Action<T1, T2> handler)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x9B57F8", Offset = "0x9B57F8", VA = "0x9B57F8")]
		public void EnqueuePlayerJoined(string playerName, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x9B5B0C", Offset = "0x9B5B0C", VA = "0x9B5B0C")]
		public void EnqueuePlayerLeft(string playerName)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x9B5E58", Offset = "0x9B5E58", VA = "0x9B5E58")]
		public void EnqueuePlayerEnteredRoom([NotNull] string playerName, [NotNull] string room, [ItemNotNull][NotNull] ReadOnlyCollection<string> allRooms)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x9B6160", Offset = "0x9B6160", VA = "0x9B6160")]
		public void EnqueuePlayerExitedRoom([NotNull] string playerName, [NotNull] string room, [NotNull][ItemNotNull] ReadOnlyCollection<string> allRooms)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x9B6458", Offset = "0x9B6458", VA = "0x9B6458")]
		public void EnqueueStartedSpeaking(string playerName)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x9B6788", Offset = "0x9B6788", VA = "0x9B6788")]
		public void EnqueueStoppedSpeaking(string playerName)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x9B6AB8", Offset = "0x9B6AB8", VA = "0x9B6AB8")]
		public void EnqueueVoiceData(VoicePacket data)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x9B6E30", Offset = "0x9B6E30", VA = "0x9B6E30")]
		public void EnqueueTextData(TextMessage data)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x9B7178", Offset = "0x9B7178", VA = "0x9B7178")]
		public byte[] GetEventBuffer()
		{
			return null;
		}
	}
	[Token(Token = "0x20000E0")]
	internal interface IClient<TPeer> where TPeer : struct
	{
		[Token(Token = "0x600065B")]
		void SendReliable(ArraySegment<byte> arraySegment);

		[Token(Token = "0x600065C")]
		void SendUnreliable(ArraySegment<byte> arraySegment);

		[Token(Token = "0x600065D")]
		void SendReliableP2P(List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet);

		[Token(Token = "0x600065E")]
		void SendUnreliableP2P(List<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet);
	}
	[Token(Token = "0x20000E1")]
	internal struct OpenChannel
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ChannelProperties _config;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly ChannelType _type;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly ushort _recipient;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _name;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly bool _isClosing;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private readonly ushort _sessionId;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private readonly bool _sent;

		[Token(Token = "0x1700012C")]
		[NotNull]
		public ChannelProperties Config
		{
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x9B7494", Offset = "0x9B7494", VA = "0x9B7494")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012D")]
		public ushort Bitfield
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x9B33F0", Offset = "0x9B33F0", VA = "0x9B33F0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x1700012E")]
		public ushort Recipient
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x9B74F0", Offset = "0x9B74F0", VA = "0x9B74F0")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x1700012F")]
		public ChannelType Type
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x9B74F8", Offset = "0x9B74F8", VA = "0x9B74F8")]
			get
			{
				return default(ChannelType);
			}
		}

		[Token(Token = "0x17000130")]
		public bool IsClosing
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x9B7500", Offset = "0x9B7500", VA = "0x9B7500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000131")]
		public bool IsPositional
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x9B74D4", Offset = "0x9B74D4", VA = "0x9B74D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000132")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x9B749C", Offset = "0x9B749C", VA = "0x9B749C")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x17000133")]
		public float AmplitudeMultiplier
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x9B74B8", Offset = "0x9B74B8", VA = "0x9B74B8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000134")]
		public ushort SessionId
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x9B7508", Offset = "0x9B7508", VA = "0x9B7508")]
			get
			{
				return default(ushort);
			}
		}

		[Token(Token = "0x17000135")]
		[NotNull]
		public string Name
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x9B7510", Offset = "0x9B7510", VA = "0x9B7510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x9B7518", Offset = "0x9B7518", VA = "0x9B7518")]
		public OpenChannel(ChannelType type, ushort sessionId, ChannelProperties config, bool closing, ushort recipient, string name, bool sent = false)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x9B7540", Offset = "0x9B7540", VA = "0x9B7540")]
		[Pure]
		public OpenChannel AsClosing()
		{
			return default(OpenChannel);
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x9B7610", Offset = "0x9B7610", VA = "0x9B7610")]
		[Pure]
		public OpenChannel AsOpen()
		{
			return default(OpenChannel);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x9B76E4", Offset = "0x9B76E4", VA = "0x9B76E4")]
		[Pure]
		public OpenChannel AsSent()
		{
			return default(OpenChannel);
		}
	}
	[Token(Token = "0x20000E2")]
	internal class PacketDelaySimulator
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly System.Random _rnd;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x9B7808", Offset = "0x9B7808", VA = "0x9B7808")]
		private static bool IsOrderedReliable(MessageTypes header)
		{
			return default(bool);
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x9B7818", Offset = "0x9B7818", VA = "0x9B7818")]
		public bool ShouldLose(ArraySegment<byte> packet)
		{
			return default(bool);
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x9B7820", Offset = "0x9B7820", VA = "0x9B7820")]
		public PacketDelaySimulator()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	internal class PeerVoiceReceiver
	{
		[Token(Token = "0x20000E4")]
		private struct ChannelsMetadata
		{
			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly bool IsPositional;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly float AmplitudeMultiplier;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly ChannelPriority Priority;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x9B8294", Offset = "0x9B8294", VA = "0x9B8294")]
			public ChannelsMetadata(bool isPositional, float amplitudeMultiplier, ChannelPriority priority)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x9B8400", Offset = "0x9B8400", VA = "0x9B8400")]
			public ChannelsMetadata CombineWith(ChannelsMetadata other)
			{
				return default(ChannelsMetadata);
			}
		}

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _name;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly EventQueue _events;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Rooms _localListeningRooms;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ConcurrentPool<List<RemoteChannel>> _channelListPool;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly ushort _localId;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string _localName;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DateTime _lastReceiptTime;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ushort _remoteSequenceNumber;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private uint _localSequenceNumber;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _currentChannelSession;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<int, int> _expectedPerChannelSessions;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly List<int> _tmpCompositeIdBuffer;

		[Token(Token = "0x17000136")]
		public string Name
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x9B7888", Offset = "0x9B7888", VA = "0x9B7888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public bool Open
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x9B7890", Offset = "0x9B7890", VA = "0x9B7890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x9B7898", Offset = "0x9B7898", VA = "0x9B7898")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x9B78A4", Offset = "0x9B78A4", VA = "0x9B78A4")]
		public PeerVoiceReceiver(string remoteName, ushort localId, string localName, EventQueue events, Rooms listeningRooms, ConcurrentPool<List<RemoteChannel>> channelListPool)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x9B79A8", Offset = "0x9B79A8", VA = "0x9B79A8")]
		public void CheckTimeout(DateTime utcNow, TimeSpan timeout)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x9B7A78", Offset = "0x9B7A78", VA = "0x9B7A78")]
		public void StopSpeaking()
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x9B7B28", Offset = "0x9B7B28", VA = "0x9B7B28")]
		private void StartSpeaking(ushort startSequenceNumber, int channelSession, DateTime utcNow)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x9B7C10", Offset = "0x9B7C10", VA = "0x9B7C10")]
		public void ReceivePacket(ref PacketReader reader, DateTime utcNow)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x9B7E40", Offset = "0x9B7E40", VA = "0x9B7E40")]
		private void ReadChannels(ref PacketReader reader, ushort numChannels, out bool allClosing, out bool forceReset, out ChannelsMetadata channelsMetadata, [NotNull] ICollection<RemoteChannel> channelsOut)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x9B84B8", Offset = "0x9B84B8", VA = "0x9B84B8")]
		private bool HasChannelSessionChanged(int compositeId, int expectedValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x9B82A8", Offset = "0x9B82A8", VA = "0x9B82A8")]
		private RemoteChannel? IsChannelToLocalPlayer(ChannelBitField channel, ushort recipient)
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x9B857C", Offset = "0x9B857C", VA = "0x9B857C")]
		private void RemoveChannelsExcept([NotNull] List<int> keys)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x9B81CC", Offset = "0x9B81CC", VA = "0x9B81CC")]
		private bool UpdateSpeakerState(bool allClosing, bool forceReset, int channelSession, ushort sequenceNumber, DateTime utcNow)
		{
			return default(bool);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x9B8874", Offset = "0x9B8874", VA = "0x9B8874")]
		private bool UpdateSequenceNumber(ushort sequenceNumber, DateTime utcNow)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x9B7E18", Offset = "0x9B7E18", VA = "0x9B7E18")]
		private static bool IsPacketFromPreviousSession(int currentChannelSession, int packetChannelSession)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E5")]
	internal class SendQueue<TPeer> : ISendQueue<TPeer> where TPeer : struct
	{
		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IClient<TPeer> _client;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<ArraySegment<byte>>> _serverReliableQueue;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<ArraySegment<byte>>> _serverUnreliableQueue;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<KeyValuePair<List<ClientInfo<TPeer?>>, ArraySegment<byte>>>> _reliableP2PQueue;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<KeyValuePair<List<ClientInfo<TPeer?>>, ArraySegment<byte>>>> _unreliableP2PQueue;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<Pool<byte[]>> _sendBufferPool;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ConcurrentPool<List<ClientInfo<TPeer?>>> _listPool;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<byte[]> _tmpRecycleQueue;

		[Token(Token = "0x6000683")]
		public SendQueue([NotNull] IClient<TPeer> client, [NotNull] ReadonlyLockedValue<Pool<byte[]>> bytePool)
		{
		}

		[Token(Token = "0x6000684")]
		public void Update()
		{
		}

		[Token(Token = "0x6000685")]
		private static int Drop<T>([NotNull] ReadonlyLockedValue<List<T>> l)
		{
			return default(int);
		}

		[Token(Token = "0x6000686")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000687")]
		public void EnqueueReliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x6000688")]
		public void EnqeueUnreliable(ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x6000689")]
		public void EnqueueReliableP2P(ushort localId, IList<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600068A")]
		public void EnqueueUnreliableP2P(ushort localId, IList<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet)
		{
		}

		[Token(Token = "0x600068B")]
		public byte[] GetSendBuffer()
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		public void RecycleSendBuffer([NotNull] byte[] buffer)
		{
		}

		[Token(Token = "0x600068D")]
		private void EnqueueP2P(ushort localId, [NotNull] ICollection<ClientInfo<TPeer?>> destinations, [NotNull] ICollection<KeyValuePair<List<ClientInfo<TPeer?>>, ArraySegment<byte>>> queue, ArraySegment<byte> packet)
		{
		}
	}
	[Token(Token = "0x20000E7")]
	internal interface ISendQueue<TPeer> where TPeer : struct
	{
		[Token(Token = "0x6000692")]
		void EnqueueReliable(ArraySegment<byte> packet);

		[Token(Token = "0x6000693")]
		void EnqeueUnreliable(ArraySegment<byte> packet);

		[Token(Token = "0x6000694")]
		void EnqueueReliableP2P(ushort localId, [NotNull] IList<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet);

		[Token(Token = "0x6000695")]
		void EnqueueUnreliableP2P(ushort localId, [NotNull] IList<ClientInfo<TPeer?>> destinations, ArraySegment<byte> packet);

		[Token(Token = "0x6000696")]
		byte[] GetSendBuffer();

		[Token(Token = "0x6000697")]
		void RecycleSendBuffer(byte[] buffer);
	}
	[Token(Token = "0x20000E8")]
	internal class SlaveClientCollection<TPeer> : BaseClientCollection<TPeer?> where TPeer : struct
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISendQueue<TPeer> _sender;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISession _session;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EventQueue _events;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Rooms _localRooms;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly string _playerName;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly CodecSettings _codecSettings;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<KeyValuePair<ushort, TPeer>> _pendingIntroductions;

		[Token(Token = "0x14000039")]
		public event Action<ClientInfo<TPeer?>> OnClientJoined
		{
			[Token(Token = "0x6000698")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000699")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400003A")]
		public event Action<ClientInfo<TPeer?>> OnClientIntroducedP2P
		{
			[Token(Token = "0x600069A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600069B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600069C")]
		public SlaveClientCollection([NotNull] ISendQueue<TPeer> sender, [NotNull] ISession session, [NotNull] EventQueue events, [NotNull] Rooms localRooms, [NotNull] string playerName, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x600069D")]
		protected override void OnAddedClient(ClientInfo<TPeer?> client)
		{
		}

		[Token(Token = "0x600069E")]
		protected override void OnRemovedClient(ClientInfo<TPeer?> client)
		{
		}

		[Token(Token = "0x600069F")]
		protected override void OnClientEnteredRoom(ClientInfo<TPeer?> client, [NotNull] string room)
		{
		}

		[Token(Token = "0x60006A0")]
		protected override void OnClientExitedRoom(ClientInfo<TPeer?> client, [NotNull] string room)
		{
		}

		[Token(Token = "0x60006A1")]
		public void ProcessRemoveClient(ref PacketReader reader)
		{
		}

		[Token(Token = "0x60006A2")]
		public void ReceiveHandshakeResponseBody(ref PacketReader reader)
		{
		}

		[Token(Token = "0x60006A3")]
		private void SendClientState()
		{
		}

		[Token(Token = "0x60006A4")]
		private void SendLeaveRoom(string room)
		{
		}

		[Token(Token = "0x60006A5")]
		private void SendJoinRoom(string room)
		{
		}

		[Token(Token = "0x60006A6")]
		public override void Stop()
		{
		}

		[Token(Token = "0x60006A7")]
		public void IntroduceP2P(ushort id, TPeer connection)
		{
		}

		[Token(Token = "0x60006A8")]
		private bool TryIntroduceP2P(ushort id, TPeer connection)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E9")]
	internal class TextReceiver<TPeer> where TPeer : struct
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EventQueue _events;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Rooms _rooms;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IClientCollection<TPeer?> _peers;

		[Token(Token = "0x60006A9")]
		public TextReceiver([NotNull] EventQueue events, [NotNull] Rooms rooms, [NotNull] IClientCollection<TPeer?> peers)
		{
		}

		[Token(Token = "0x60006AA")]
		public void ProcessTextMessage(ref PacketReader reader)
		{
		}

		[Token(Token = "0x60006AB")]
		[CanBeNull]
		private string GetTxtMessageRecipient(ChannelType txtRecipientType, ushort txtRecipient)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EA")]
	internal class TextSender<TPeer> where TPeer : struct
	{
		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISession _session;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISendQueue<TPeer> _sender;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IClientCollection<TPeer?> _peers;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<ClientInfo<TPeer?>> _tmpDests;

		[Token(Token = "0x60006AD")]
		public TextSender(ISendQueue<TPeer> sender, ISession session, IClientCollection<TPeer?> peers)
		{
		}

		[Token(Token = "0x60006AE")]
		public void Send(string data, ChannelType type, string recipient)
		{
		}
	}
	[Token(Token = "0x20000EB")]
	internal struct VoicePacketOptions
	{
		[Token(Token = "0x4000329")]
		public const int ChannelSessionRange = 4;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly byte _bitfield;

		[Token(Token = "0x17000138")]
		public byte ChannelSession
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x9B7E0C", Offset = "0x9B7E0C", VA = "0x9B7E0C")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000139")]
		public byte Bitfield
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x9B8A30", Offset = "0x9B8A30", VA = "0x9B8A30")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9B8A38", Offset = "0x9B8A38", VA = "0x9B8A38")]
		private VoicePacketOptions(byte bitfield)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9B1EB8", Offset = "0x9B1EB8", VA = "0x9B1EB8")]
		public static VoicePacketOptions Unpack(byte bitfield)
		{
			return default(VoicePacketOptions);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9B33E8", Offset = "0x9B33E8", VA = "0x9B33E8")]
		public static VoicePacketOptions Pack(byte channelSession)
		{
			return default(VoicePacketOptions);
		}
	}
	[Token(Token = "0x20000EC")]
	internal class VoiceReceiver<TPeer> where TPeer : struct
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly TimeSpan Timeout;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISession _session;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IClientCollection<TPeer?> _clients;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EventQueue _events;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Rooms _rooms;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ConcurrentPool<List<RemoteChannel>> _channelListPool;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<PeerVoiceReceiver> _receivers;

		[Token(Token = "0x60006B5")]
		public VoiceReceiver(ISession session, IClientCollection<TPeer?> clients, EventQueue events, Rooms rooms, ConcurrentPool<List<RemoteChannel>> channelListPool)
		{
		}

		[Token(Token = "0x60006B6")]
		private void OnPlayerLeft([NotNull] string name)
		{
		}

		[Token(Token = "0x60006B7")]
		public void Stop()
		{
		}

		[Token(Token = "0x60006B8")]
		public void Update(DateTime utcNow)
		{
		}

		[Token(Token = "0x60006B9")]
		private void CheckTimeouts(DateTime utcNow)
		{
		}

		[Token(Token = "0x60006BA")]
		public void ReceiveVoiceData(ref PacketReader reader, [Optional] DateTime? utcNow)
		{
		}
	}
	[Token(Token = "0x20000ED")]
	internal class VoiceSender<TPeer> where TPeer : struct
	{
		[Token(Token = "0x20000EE")]
		private struct ChannelDelta
		{
			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly bool Open;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly ChannelType Type;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly ChannelProperties Properties;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly ushort RecipientId;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly string RecipientName;

			[Token(Token = "0x60006CD")]
			public ChannelDelta(bool open, ChannelType type, ChannelProperties properties, ushort recipientId, string recipientName)
			{
			}
		}

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISendQueue<TPeer> _sender;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ISession _session;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IClientCollection<TPeer?> _peers;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly EventQueue _events;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly PlayerChannels _playerChannels;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly RoomChannels _roomChannels;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte _channelSessionId;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<OpenChannel>> _openChannels;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<List<ChannelDelta>> _deltas;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<KeyValuePair<string, ChannelProperties>> _pendingPlayerChannels;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _sequenceNumber;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly HashSet<ClientInfo<TPeer?>> _tmpDestsSet;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<ClientInfo<TPeer?>> _tmpDestsList;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _hadId;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _noIdSendCount;

		[Token(Token = "0x60006BC")]
		public VoiceSender([NotNull] ISendQueue<TPeer> sender, [NotNull] ISession session, [NotNull] IClientCollection<TPeer?> peers, [NotNull] EventQueue events, [NotNull] PlayerChannels playerChannels, [NotNull] RoomChannels roomChannels)
		{
		}

		[Token(Token = "0x60006BD")]
		public void Stop()
		{
		}

		[Token(Token = "0x60006BE")]
		private void OnPlayerJoined([NotNull] string name, CodecSettings codecSettings)
		{
		}

		[Token(Token = "0x60006BF")]
		private void OnPlayerLeft([NotNull] string name)
		{
		}

		[Token(Token = "0x60006C0")]
		private void OpenPlayerChannel([NotNull] string player, [NotNull] ChannelProperties config)
		{
		}

		[Token(Token = "0x60006C1")]
		private void ClosePlayerChannel([NotNull] string player, [NotNull] ChannelProperties config)
		{
		}

		[Token(Token = "0x60006C2")]
		private void OpenRoomChannel([NotNull] string room, [NotNull] ChannelProperties config)
		{
		}

		[Token(Token = "0x60006C3")]
		private void CloseRoomChannel([NotNull] string room, [NotNull] ChannelProperties config)
		{
		}

		[Token(Token = "0x60006C4")]
		private void OpenChannel(ChannelType type, [NotNull] ChannelProperties config, ushort recipient, [NotNull] string name)
		{
		}

		[Token(Token = "0x60006C5")]
		private void CloseChannel(ChannelType type, [NotNull] ChannelProperties properties, ushort id)
		{
		}

		[Token(Token = "0x60006C6")]
		private void ClearClosedChannels()
		{
		}

		[Token(Token = "0x60006C7")]
		public void Send(ArraySegment<byte> encodedAudio)
		{
		}

		[Token(Token = "0x60006C8")]
		[NotNull]
		private List<ClientInfo<TPeer?>> GetVoiceDestinations([NotNull] IList<OpenChannel> openChannels)
		{
			return null;
		}

		[Token(Token = "0x60006C9")]
		private void ApplyChannelDeltas([NotNull] ReadonlyLockedValue<List<OpenChannel>>.Unlocker openChannels)
		{
		}

		[Token(Token = "0x60006CA")]
		private static bool AreAllChannelsClosing([NotNull] ReadonlyLockedValue<List<OpenChannel>>.Unlocker openChannels)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		private void ApplyChannelDelta(ChannelDelta d, ReadonlyLockedValue<List<OpenChannel>>.Unlocker openChannels)
		{
		}
	}
}
namespace Dissonance.Extensions
{
	[Token(Token = "0x20000EF")]
	public static class ArraySegmentExtensions
	{
		[Token(Token = "0x20000F0")]
		internal struct DisposableHandle : IDisposable
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly IntPtr _ptr;

			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private GCHandle _handle;

			[Token(Token = "0x1700013A")]
			public IntPtr Ptr
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x9B8A40", Offset = "0x9B8A40", VA = "0x9B8A40")]
				get
				{
					return default(IntPtr);
				}
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x9B8AB0", Offset = "0x9B8AB0", VA = "0x9B8AB0")]
			internal DisposableHandle(IntPtr ptr, GCHandle handle)
			{
			}

			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x9B8AB8", Offset = "0x9B8AB8", VA = "0x9B8AB8", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x60006CE")]
		public static ArraySegment<T> CopyToSegment<T>(this ArraySegment<T> source, [NotNull] T[] destination, int destinationOffset = 0) where T : struct
		{
			return default(ArraySegment<T>);
		}

		[Token(Token = "0x60006CF")]
		internal static int CopyFrom<T>(this ArraySegment<T> destination, [NotNull] T[] source)
		{
			return default(int);
		}

		[Token(Token = "0x60006D0")]
		[NotNull]
		internal static T[] ToArray<T>(this ArraySegment<T> segment) where T : struct
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		internal static void Clear<T>(this ArraySegment<T> segment)
		{
		}

		[Token(Token = "0x60006D2")]
		internal static DisposableHandle Pin<T>(this ArraySegment<T> segment) where T : struct
		{
			return default(DisposableHandle);
		}
	}
	[Token(Token = "0x20000F1")]
	public static class IEnumerableExtensions
	{
		[Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private sealed class <ConcatUnsafe>d__1<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerable<T> enumerable;

			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IEnumerable<T> <>3__enumerable;

			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T tail;

			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T <>3__tail;

			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IEnumerator<T> <>7__wrap1;

			[Token(Token = "0x1700013B")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x60006DC")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700013C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006DE")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D8")]
			[DebuggerHidden]
			public <ConcatUnsafe>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60006D9")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006DA")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006DB")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60006DD")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60006DF")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60006E0")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x60006D6")]
		[NotNull]
		public static IEnumerable<T> Concat<T>([NotNull] this IEnumerable<T> enumerable, T tail)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[IteratorStateMachine(typeof(<ConcatUnsafe>d__1<>))]
		[NotNull]
		private static IEnumerable<T> ConcatUnsafe<T>([NotNull] this IEnumerable<T> enumerable, T tail)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F3")]
	internal static class Int32Extensions
	{
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x9B8AC4", Offset = "0x9B8AC4", VA = "0x9B8AC4")]
		internal static int WrappedDelta(this int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x9B8900", Offset = "0x9B8900", VA = "0x9B8900")]
		internal static int WrappedDelta(this int a, int b, int max)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F4")]
	internal static class StringExtensions
	{
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x9B8AEC", Offset = "0x9B8AEC", VA = "0x9B8AEC")]
		public static int GetFnvHashCode([CanBeNull] this string str)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000F5")]
	internal static class UShortExtensions
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x9B88C8", Offset = "0x9B88C8", VA = "0x9B88C8")]
		internal static int WrappedDelta(this ushort a, ushort b)
		{
			return default(int);
		}
	}
}
namespace Dissonance.Datastructures
{
	[Token(Token = "0x20000F6")]
	internal abstract class BaseWindowCalculator<T> where T : struct
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly RingBuffer<T> _buffer;

		[Token(Token = "0x1700013D")]
		protected int Count
		{
			[Token(Token = "0x60006E5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013E")]
		protected int Capacity
		{
			[Token(Token = "0x60006E6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006E7")]
		protected BaseWindowCalculator(uint size)
		{
		}

		[Token(Token = "0x60006E8")]
		public void Update(T added)
		{
		}

		[Token(Token = "0x60006E9")]
		protected abstract void Updated(T? removed, T added);

		[Token(Token = "0x60006EA")]
		public virtual void Clear()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ConcurrentPool<T> : IRecycler<T> where T : class
	{
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<T> _factory;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TransferBuffer<T> _items;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<int> _getter;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly ReadonlyLockedValue<int> _putter;

		[Token(Token = "0x60006EB")]
		public ConcurrentPool(int maxSize, Func<T> factory)
		{
		}

		[Token(Token = "0x60006EC")]
		[NotNull]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		public void Put([NotNull] T item)
		{
		}

		[Token(Token = "0x60006EE")]
		private void Dissonance.Datastructures.IRecycler<T>.Recycle([NotNull] T item)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	internal class PacketLossCalculator : BaseWindowCalculator<bool>
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private uint _lost;

		[Token(Token = "0x1700013F")]
		public float PacketLoss
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x9B8B74", Offset = "0x9B8B74", VA = "0x9B8B74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x9B8C44", Offset = "0x9B8C44", VA = "0x9B8C44")]
		public PacketLossCalculator(uint size)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x9B8C9C", Offset = "0x9B8C9C", VA = "0x9B8C9C", Slot = "4")]
		protected override void Updated(bool? removed, bool added)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x9B8D30", Offset = "0x9B8D30", VA = "0x9B8D30", Slot = "5")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	internal class Pool<T> : IRecycler<T> where T : class
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _maxSize;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Func<T> _factory;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly Stack<T> _items;

		[Token(Token = "0x17000140")]
		public int Count
		{
			[Token(Token = "0x60006F3")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000141")]
		public int Capacity
		{
			[Token(Token = "0x60006F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60006F5")]
		public Pool(int maxSize, Func<T> factory)
		{
		}

		[Token(Token = "0x60006F6")]
		public T Get()
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		public void Put([NotNull] T item)
		{
		}

		[Token(Token = "0x60006F8")]
		private void Dissonance.Datastructures.IRecycler<T>.Recycle([NotNull] T item)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public interface IRecycler<in T> where T : class
	{
		[Token(Token = "0x60006F9")]
		void Recycle(T item);
	}
	[Token(Token = "0x20000FB")]
	internal class POTBuffer
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<float[]> _buffers;

		[Token(Token = "0x17000142")]
		public uint MaxCount
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x9B8D80", Offset = "0x9B8D80", VA = "0x9B8D80")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x9B8D88", Offset = "0x9B8D88", VA = "0x9B8D88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public uint Pow2
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x9B8D90", Offset = "0x9B8D90", VA = "0x9B8D90")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000144")]
		public uint Count
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x9B8DD8", Offset = "0x9B8DD8", VA = "0x9B8DD8")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x9B8DE0", Offset = "0x9B8DE0", VA = "0x9B8DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x9B8DE8", Offset = "0x9B8DE8", VA = "0x9B8DE8")]
		public POTBuffer(byte initialMaxPow)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x9B8F50", Offset = "0x9B8F50", VA = "0x9B8F50")]
		public void Free()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x9B8F58", Offset = "0x9B8F58", VA = "0x9B8F58")]
		public void Alloc(uint count)
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x9B8FDC", Offset = "0x9B8FDC", VA = "0x9B8FDC")]
		public bool Expand(int limit = int.MaxValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x9B913C", Offset = "0x9B913C", VA = "0x9B913C")]
		[NotNull]
		public float[] GetBuffer(ref uint count, bool zeroed = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FC")]
	internal class RingBuffer<T> where T : struct
	{
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _items;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _end;

		[Token(Token = "0x17000145")]
		public int Count
		{
			[Token(Token = "0x6000704")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000705")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public int Capacity
		{
			[Token(Token = "0x6000706")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000707")]
		public RingBuffer(uint size)
		{
		}

		[Token(Token = "0x6000708")]
		public T? Add(T item)
		{
			return null;
		}

		[Token(Token = "0x6000709")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	internal class TransferBuffer<T>
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _buffer;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _readHead;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _unread;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _writeHead;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _singleReadItem;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _singleWriteItem;

		[Token(Token = "0x17000147")]
		public int EstimatedUnreadCount
		{
			[Token(Token = "0x600070A")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000148")]
		public int Capacity
		{
			[Token(Token = "0x600070B")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600070C")]
		public TransferBuffer(int capacity = 4096)
		{
		}

		[Token(Token = "0x600070D")]
		public bool TryWrite(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600070E")]
		public bool TryWriteAll(ArraySegment<T> data)
		{
			return default(bool);
		}

		[Token(Token = "0x600070F")]
		public int WriteSome(ArraySegment<T> data)
		{
			return default(int);
		}

		[Token(Token = "0x6000710")]
		public bool Read([CanBeNull] out T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000711")]
		public bool Read([NotNull] T[] data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000712")]
		public bool Read([NotNull] T[] data, int readCount)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		public bool Read(ArraySegment<T> data)
		{
			return default(bool);
		}

		[Token(Token = "0x6000714")]
		public void Clear()
		{
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000FE")]
	internal struct Union16
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ushort _ushort;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte _byte1;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte _byte2;

		[Token(Token = "0x17000149")]
		public ushort UInt16
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x9B9348", Offset = "0x9B9348", VA = "0x9B9348")]
			get
			{
				return default(ushort);
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x9B9350", Offset = "0x9B9350", VA = "0x9B9350")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public byte LSB
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x9B26BC", Offset = "0x9B26BC", VA = "0x9B26BC")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x9B1174", Offset = "0x9B1174", VA = "0x9B1174")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public byte MSB
		{
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x9B265C", Offset = "0x9B265C", VA = "0x9B265C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x9B10FC", Offset = "0x9B10FC", VA = "0x9B10FC")]
			set
			{
			}
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000FF")]
	internal struct Union32
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private uint _uint;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private byte _byte1;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private byte _byte2;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		private byte _byte3;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		private byte _byte4;

		[Token(Token = "0x1700014C")]
		public uint UInt32
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x9B9358", Offset = "0x9B9358", VA = "0x9B9358")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x9B9360", Offset = "0x9B9360", VA = "0x9B9360")]
			set
			{
			}
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x9B1290", Offset = "0x9B1290", VA = "0x9B1290")]
		public void SetBytesFromNetworkOrder(byte b1, byte b2, byte b3, byte b4)
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x9B2808", Offset = "0x9B2808", VA = "0x9B2808")]
		public void GetBytesInNetworkOrder(out byte b1, out byte b2, out byte b3, out byte b4)
		{
		}
	}
	[Token(Token = "0x2000100")]
	internal class WindowDeviationCalculator : BaseWindowCalculator<float>
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _sum;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _sumOfSquares;

		[Token(Token = "0x1700014D")]
		public float StdDev
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x9B9368", Offset = "0x9B9368", VA = "0x9B9368")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x9B9370", Offset = "0x9B9370", VA = "0x9B9370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public float Mean
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x9B9378", Offset = "0x9B9378", VA = "0x9B9378")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x9B9380", Offset = "0x9B9380", VA = "0x9B9380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public float Confidence
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x9B9388", Offset = "0x9B9388", VA = "0x9B9388")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x9B940C", Offset = "0x9B940C", VA = "0x9B940C")]
		public WindowDeviationCalculator(uint size)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x9B9464", Offset = "0x9B9464", VA = "0x9B9464", Slot = "4")]
		protected override void Updated(float? removed, float added)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x9B95A0", Offset = "0x9B95A0", VA = "0x9B95A0")]
		private float CalculateDeviation(float mean, float meanOfSquares)
		{
			return default(float);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x9B9620", Offset = "0x9B9620", VA = "0x9B9620", Slot = "5")]
		public override void Clear()
		{
		}
	}
}
namespace Dissonance.Config
{
	[Token(Token = "0x2000101")]
	public class ChatRoomSettings : ScriptableObject
	{
		[Token(Token = "0x4000374")]
		private const string SettingsFileResourceName = "ChatRoomSettings";

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string SettingsFilePath;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> DefaultRooms;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal List<string> Names;

		[NonSerialized]
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<ushort, string> _nameLookup;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static ChatRoomSettings _instance;

		[Token(Token = "0x17000150")]
		[NotNull]
		public static ChatRoomSettings Instance
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x9B9670", Offset = "0x9B9670", VA = "0x9B9670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x9B9774", Offset = "0x9B9774", VA = "0x9B9774")]
		public ChatRoomSettings()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x9B9828", Offset = "0x9B9828", VA = "0x9B9828")]
		[CanBeNull]
		public string FindRoomById(ushort id)
		{
			return null;
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x9B96F0", Offset = "0x9B96F0", VA = "0x9B96F0")]
		public static ChatRoomSettings Load()
		{
			return null;
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x9B9994", Offset = "0x9B9994", VA = "0x9B9994")]
		public static void Preload()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class DebugSettings : ScriptableObject
	{
		[Token(Token = "0x400037A")]
		private const string SettingsFileResourceName = "DebugSettings";

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string SettingsFilePath;

		[Token(Token = "0x400037C")]
		private const LogLevel DefaultLevel = LogLevel.Info;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<LogLevel> _levels;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool EnableRecordingDiagnostics;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool RecordMicrophoneRawAudio;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool RecordPreprocessorOutput;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool EnablePlaybackDiagnostics;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool RecordDecodedAudio;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool RecordFinalAudio;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool EnableNetworkSimulation;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PacketLoss;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DebugSettings _instance;

		[Token(Token = "0x17000151")]
		[NotNull]
		public static DebugSettings Instance
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x9B9D64", Offset = "0x9B9D64", VA = "0x9B9D64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x9B9E68", Offset = "0x9B9E68", VA = "0x9B9E68")]
		public DebugSettings()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x9BA0C4", Offset = "0x9BA0C4", VA = "0x9BA0C4")]
		public LogLevel GetLevel(int category)
		{
			return default(LogLevel);
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x9BA144", Offset = "0x9BA144", VA = "0x9BA144")]
		public void SetLevel(int category, LogLevel level)
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x9B9DE4", Offset = "0x9B9DE4", VA = "0x9B9DE4")]
		private static DebugSettings Load()
		{
			return null;
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x9BA250", Offset = "0x9BA250", VA = "0x9BA250")]
		public static void Preload()
		{
		}
	}
	[Token(Token = "0x2000104")]
	internal static class Preferences
	{
		[Token(Token = "0x6000739")]
		public static void Get<T>(string key, ref T output, Func<string, T, T> get, Log log)
		{
		}

		[Token(Token = "0x600073A")]
		public static void Set<T>(string key, ref T field, T value, Action<string, T> save, Log log, [Optional] IEqualityComparer<T> equality, bool setAtRuntime = true)
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0x9BA41C", Offset = "0x9BA41C", VA = "0x9BA41C")]
		internal static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x9BA490", Offset = "0x9BA490", VA = "0x9BA490")]
		internal static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000105")]
	public sealed class VoiceSettings : ScriptableObject, INotifyPropertyChanged
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400038A")]
		private const string PersistName_Quality = "Dissonance_Audio_Quality";

		[Token(Token = "0x400038B")]
		private const string PersistName_FrameSize = "Dissonance_Audio_FrameSize";

		[Token(Token = "0x400038C")]
		private const string PersistName_Fec = "Dissonance_Audio_DisableFEC";

		[Token(Token = "0x400038D")]
		private const string PersistName_DenoiseAmount = "Dissonance_Audio_Denoise_Amount";

		[Token(Token = "0x400038E")]
		private const string PersistName_PttDuckAmount = "Dissonance_Audio_Duck_Amount";

		[Token(Token = "0x400038F")]
		private const string PersistName_VadSensitivity = "Dissonance_Audio_Vad_Sensitivity";

		[Token(Token = "0x4000390")]
		private const string PersistName_AecSuppressionAmount = "Dissonance_Audio_Aec_Suppression_Amount";

		[Token(Token = "0x4000391")]
		private const string PersistName_AecDelayAgnostic = "Dissonance_Audio_Aec_Delay_Agnostic";

		[Token(Token = "0x4000392")]
		private const string PersistName_AecExtendedFilter = "Dissonance_Audio_Aec_Extended_Filter";

		[Token(Token = "0x4000393")]
		private const string PersistName_AecRefinedAdaptiveFilter = "Dissonance_Audio_Aec_Refined_Adaptive_Filter";

		[Token(Token = "0x4000394")]
		private const string PersistName_AecmRoutingMode = "Dissonance_Audio_Aecm_Routing_Mode";

		[Token(Token = "0x4000395")]
		private const string PersistName_AecmComfortNoise = "Dissonance_Audio_Aecm_Comfort_Noise";

		[Token(Token = "0x4000396")]
		private const string SettingsFileResourceName = "VoiceSettings";

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly string SettingsFilePath;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioQuality _quality;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FrameSize _frameSize;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int _forwardErrorCorrection;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int _denoiseAmount;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _vadSensitivity;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _aecAmount;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _aecDelayAgnostic;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _aecExtendedFilter;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _aecRefinedAdaptiveFilter;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int _aecmRoutingMode;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _aecmComfortNoise;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _voiceDuckLevel;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VoiceSettings _instance;

		[Token(Token = "0x17000152")]
		public AudioQuality Quality
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x9BA50C", Offset = "0x9BA50C", VA = "0x9BA50C")]
			get
			{
				return default(AudioQuality);
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x9BA514", Offset = "0x9BA514", VA = "0x9BA514")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public FrameSize FrameSize
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x9BA734", Offset = "0x9BA734", VA = "0x9BA734")]
			get
			{
				return default(FrameSize);
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x9BA73C", Offset = "0x9BA73C", VA = "0x9BA73C")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public bool ForwardErrorCorrection
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x9BA8C4", Offset = "0x9BA8C4", VA = "0x9BA8C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x9BA920", Offset = "0x9BA920", VA = "0x9BA920")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public NoiseSuppressionLevels DenoiseAmount
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x9BAA84", Offset = "0x9BAA84", VA = "0x9BAA84")]
			get
			{
				return default(NoiseSuppressionLevels);
			}
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x9BAA8C", Offset = "0x9BAA8C", VA = "0x9BAA8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public VadSensitivityLevels VadSensitivity
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x9BABB8", Offset = "0x9BABB8", VA = "0x9BABB8")]
			get
			{
				return default(VadSensitivityLevels);
			}
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x9BABC0", Offset = "0x9BABC0", VA = "0x9BABC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public AecSuppressionLevels AecSuppressionAmount
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x9BACEC", Offset = "0x9BACEC", VA = "0x9BACEC")]
			get
			{
				return default(AecSuppressionLevels);
			}
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x9BACF4", Offset = "0x9BACF4", VA = "0x9BACF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public bool AecDelayAgnostic
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x9BAE20", Offset = "0x9BAE20", VA = "0x9BAE20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x9BAE7C", Offset = "0x9BAE7C", VA = "0x9BAE7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public bool AecExtendedFilter
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x9BAFE0", Offset = "0x9BAFE0", VA = "0x9BAFE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x9BB03C", Offset = "0x9BB03C", VA = "0x9BB03C")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public bool AecRefinedAdaptiveFilter
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x9BB1A0", Offset = "0x9BB1A0", VA = "0x9BB1A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x9BB1FC", Offset = "0x9BB1FC", VA = "0x9BB1FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public AecmRoutingMode AecmRoutingMode
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x9BB360", Offset = "0x9BB360", VA = "0x9BB360")]
			get
			{
				return default(AecmRoutingMode);
			}
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x9BB368", Offset = "0x9BB368", VA = "0x9BB368")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public bool AecmComfortNoise
		{
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x9BB494", Offset = "0x9BB494", VA = "0x9BB494")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x9BB4F0", Offset = "0x9BB4F0", VA = "0x9BB4F0")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public float VoiceDuckLevel
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x9BB654", Offset = "0x9BB654", VA = "0x9BB654")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x9BB65C", Offset = "0x9BB65C", VA = "0x9BB65C")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		[NotNull]
		public static VoiceSettings Instance
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x9BB8C0", Offset = "0x9BB8C0", VA = "0x9BB8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400003B")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x9BB788", Offset = "0x9BB788", VA = "0x9BB788", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x9BB824", Offset = "0x9BB824", VA = "0x9BB824", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x9BA69C", Offset = "0x9BA69C", VA = "0x9BA69C")]
		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x9BBFCC", Offset = "0x9BBFCC", VA = "0x9BBFCC")]
		public VoiceSettings()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x9BC098", Offset = "0x9BC098", VA = "0x9BC098")]
		public static void Preload()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x9BB940", Offset = "0x9BB940", VA = "0x9BB940")]
		[NotNull]
		private static VoiceSettings Load()
		{
			return null;
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x9BC14C", Offset = "0x9BC14C", VA = "0x9BC14C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Dissonance.Audio
{
	[Token(Token = "0x2000107")]
	internal struct ArvCalculator
	{
		[Token(Token = "0x1700015F")]
		public float ARV
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x9BC5E4", Offset = "0x9BC5E4", VA = "0x9BC5E4")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x9BC5EC", Offset = "0x9BC5EC", VA = "0x9BC5EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x9BC5F4", Offset = "0x9BC5F4", VA = "0x9BC5F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x9BC5FC", Offset = "0x9BC5FC", VA = "0x9BC5FC")]
		public void Update(ArraySegment<float> samples)
		{
		}
	}
	[Token(Token = "0x2000108")]
	internal class AudioFileWriter : IDisposable
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly LockedValue<WaveFileWriter> _lock;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x9BC74C", Offset = "0x9BC74C", VA = "0x9BC74C")]
		public AudioFileWriter(string filename, [NotNull] WaveFormat format)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x9BC940", Offset = "0x9BC940", VA = "0x9BC940", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x9BCB28", Offset = "0x9BCB28", VA = "0x9BCB28")]
		public void Flush()
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x9BCCF0", Offset = "0x9BCCF0", VA = "0x9BCCF0")]
		public void WriteSamples(ArraySegment<float> samples)
		{
		}
	}
	[Token(Token = "0x2000109")]
	internal class AudioSettingsWatcher
	{
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly AudioSettingsWatcher Singleton;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly object _lock;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _started;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private AudioConfiguration _config;

		[Token(Token = "0x17000160")]
		public static AudioSettingsWatcher Instance
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x9BCEF0", Offset = "0x9BCEF0", VA = "0x9BCEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		public AudioConfiguration Configuration
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x9BCF48", Offset = "0x9BCF48", VA = "0x9BCF48")]
			get
			{
				return default(AudioConfiguration);
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x9BD030", Offset = "0x9BD030", VA = "0x9BD030")]
		internal void Start()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x9BD180", Offset = "0x9BD180", VA = "0x9BD180")]
		private void OnAudioConfigChanged(bool devicewaschanged)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x9BD25C", Offset = "0x9BD25C", VA = "0x9BD25C")]
		public AudioSettingsWatcher()
		{
		}
	}
	[Token(Token = "0x200010A")]
	internal struct Fader
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private float _fadeTime;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float _elapsedTime;

		[Token(Token = "0x17000162")]
		public float Volume
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x9BD324", Offset = "0x9BD324", VA = "0x9BD324")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x9BD32C", Offset = "0x9BD32C", VA = "0x9BD32C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public float EndVolume
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x9BD334", Offset = "0x9BD334", VA = "0x9BD334")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x9BD33C", Offset = "0x9BD33C", VA = "0x9BD33C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public float StartVolume
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x9BD344", Offset = "0x9BD344", VA = "0x9BD344")]
			[CompilerGenerated]
			readonly get
			{
				return default(float);
			}
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x9BD34C", Offset = "0x9BD34C", VA = "0x9BD34C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x9BD354", Offset = "0x9BD354", VA = "0x9BD354")]
		public void Update(float dt)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x9BD3AC", Offset = "0x9BD3AC", VA = "0x9BD3AC")]
		private float CalculateVolume()
		{
			return default(float);
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x9BD3F8", Offset = "0x9BD3F8", VA = "0x9BD3F8")]
		public void FadeTo(float target, float duration)
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class OpenChannelVolumeDuck : IVolumeProvider
	{
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly RoomChannels _rooms;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly PlayerChannels _players;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _targetVolume;

		[Token(Token = "0x17000165")]
		public float TargetVolume
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x9BD408", Offset = "0x9BD408", VA = "0x9BD408", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x9BD428", Offset = "0x9BD428", VA = "0x9BD428")]
		public OpenChannelVolumeDuck(RoomChannels rooms, PlayerChannels players)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x9BD464", Offset = "0x9BD464", VA = "0x9BD464")]
		public void Update(bool isMuted)
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x9BD46C", Offset = "0x9BD46C", VA = "0x9BD46C")]
		private void UpdateTargetVolume(bool isMuted)
		{
		}
	}
}
namespace Dissonance.Audio.Playback
{
	[Token(Token = "0x200010C")]
	internal class BufferedDecoder : IFrameSource, IRemoteChannelProvider
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly EncodedAudioBuffer _buffer;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IVoiceDecoder _decoder;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly uint _frameSize;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly WaveFormat _waveFormat;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Action<VoicePacket> _recycleFrame;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioFileWriter _diagnosticOutput;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly LockedValue<PlaybackOptions> _options;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _receivedFirstPacket;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _approxChannelCount;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly ReadonlyLockedValue<List<RemoteChannel>> _channels;

		[Token(Token = "0x17000166")]
		public int BufferCount
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x9BD548", Offset = "0x9BD548", VA = "0x9BD548")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000167")]
		public uint SequenceNumber
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x9BD564", Offset = "0x9BD564", VA = "0x9BD564")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x17000168")]
		public float PacketLoss
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x9BD580", Offset = "0x9BD580", VA = "0x9BD580")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000169")]
		public PlaybackOptions LatestPlaybackOptions
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x9BD5B8", Offset = "0x9BD5B8", VA = "0x9BD5B8")]
			get
			{
				return default(PlaybackOptions);
			}
		}

		[Token(Token = "0x1700016A")]
		public uint FrameSize
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x9BDAF0", Offset = "0x9BDAF0", VA = "0x9BDAF0", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x1700016B")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x9BDAF8", Offset = "0x9BDAF8", VA = "0x9BDAF8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x9BD780", Offset = "0x9BD780", VA = "0x9BD780")]
		public BufferedDecoder([NotNull] IVoiceDecoder decoder, uint frameSize, [NotNull] WaveFormat waveFormat, [NotNull] Action<VoicePacket> recycleFrame)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9BDB00", Offset = "0x9BDB00", VA = "0x9BDB00", Slot = "6")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x9BDCA8", Offset = "0x9BDCA8", VA = "0x9BDCA8", Slot = "7")]
		public bool Read(ArraySegment<float> frame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x9BE650", Offset = "0x9BE650", VA = "0x9BE650")]
		private void ExtractChannels(VoicePacket encoded)
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x9BE8C0", Offset = "0x9BE8C0", VA = "0x9BE8C0", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x9BEDC4", Offset = "0x9BEDC4", VA = "0x9BEDC4")]
		public void Push(VoicePacket frame)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x9BEFF8", Offset = "0x9BEFF8", VA = "0x9BEFF8")]
		public void Stop()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x9BF038", Offset = "0x9BF038", VA = "0x9BF038", Slot = "9")]
		public void GetRemoteChannels(List<RemoteChannel> output)
		{
		}
	}
	[Token(Token = "0x200010D")]
	internal class DecoderFactory
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Log Log;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x9BF290", Offset = "0x9BF290", VA = "0x9BF290")]
		[NotNull]
		public static IVoiceDecoder Create(FrameFormat format)
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x9BF52C", Offset = "0x9BF52C", VA = "0x9BF52C")]
		public DecoderFactory()
		{
		}
	}
	[Token(Token = "0x200010E")]
	internal class DecoderPipeline : IDecoderPipeline, IVolumeProvider, IRemoteChannelProvider
	{
		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Action<DecoderPipeline> _completionHandler;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TransferBuffer<VoicePacket> _inputBuffer;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ConcurrentPool<byte[]> _bytePool;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ConcurrentPool<List<RemoteChannel>> _channelListPool;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly BufferedDecoder _source;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly ISampleSource _output;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _prepared;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _complete;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _sourceClosed;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly TimeSpan _frameDuration;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DateTime? _firstFrameArrival;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private uint _firstFrameSeq;

		[Token(Token = "0x1700016C")]
		public int BufferCount
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x9BF614", Offset = "0x9BF614", VA = "0x9BF614", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016D")]
		public TimeSpan BufferTime
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x9BF680", Offset = "0x9BF680", VA = "0x9BF680", Slot = "5")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x1700016E")]
		public float PacketLoss
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x9BF6F0", Offset = "0x9BF6F0", VA = "0x9BF6F0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700016F")]
		public PlaybackOptions PlaybackOptions
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x9BF708", Offset = "0x9BF708", VA = "0x9BF708", Slot = "8")]
			get
			{
				return default(PlaybackOptions);
			}
		}

		[Token(Token = "0x17000170")]
		public WaveFormat OutputFormat
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x9BF728", Offset = "0x9BF728", VA = "0x9BF728", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		public TimeSpan InputFrameTime
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x9BF7C8", Offset = "0x9BF7C8", VA = "0x9BF7C8", Slot = "7")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000172")]
		public IVolumeProvider VolumeProvider
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0x9C0878", Offset = "0x9C0878", VA = "0x9C0878")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600079F")]
			[Address(RVA = "0x9C0880", Offset = "0x9C0880", VA = "0x9C0880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		private float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0x9C0888", Offset = "0x9C0888", VA = "0x9C0888", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x9BF7D0", Offset = "0x9BF7D0", VA = "0x9BF7D0")]
		public DecoderPipeline([NotNull] IVoiceDecoder decoder, uint inputFrameSize, [NotNull] Action<DecoderPipeline> completionHandler, bool softClip = true)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x9C00D4", Offset = "0x9C00D4", VA = "0x9C00D4")]
		private void RecycleFrame(VoicePacket packet)
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x9C01A4", Offset = "0x9C01A4", VA = "0x9C01A4", Slot = "10")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x9C0270", Offset = "0x9C0270", VA = "0x9C0270", Slot = "11")]
		public bool Read(ArraySegment<float> samples)
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x9C045C", Offset = "0x9C045C", VA = "0x9C045C")]
		public float Push(VoicePacket packet, DateTime now)
		{
			return default(float);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x9C079C", Offset = "0x9C079C", VA = "0x9C079C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x9C07B8", Offset = "0x9C07B8", VA = "0x9C07B8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x9C0364", Offset = "0x9C0364", VA = "0x9C0364")]
		public void FlushTransferBuffer()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x9C0950", Offset = "0x9C0950", VA = "0x9C0950", Slot = "13")]
		public void GetRemoteChannels(List<RemoteChannel> output)
		{
		}
	}
	[Token(Token = "0x2000111")]
	internal struct DesyncCalculator
	{
		[Token(Token = "0x40003D6")]
		private const int MaxAllowedDesyncMillis = 1000;

		[Token(Token = "0x40003D7")]
		private const float MaximumPlaybackAdjustment = 0.3f;

		[Token(Token = "0x17000174")]
		internal int DesyncMilliseconds
		{
			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x9C0C5C", Offset = "0x9C0C5C", VA = "0x9C0C5C")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x9C0C64", Offset = "0x9C0C64", VA = "0x9C0C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000175")]
		internal float CorrectedPlaybackSpeed
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x9C0C6C", Offset = "0x9C0C6C", VA = "0x9C0C6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x9C0CFC", Offset = "0x9C0CFC", VA = "0x9C0CFC")]
		internal void Update(TimeSpan ideal, TimeSpan actual)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x9C0E2C", Offset = "0x9C0E2C", VA = "0x9C0E2C")]
		internal void Skip(int deltaDesyncMilliseconds)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x9C0D1C", Offset = "0x9C0D1C", VA = "0x9C0D1C")]
		private static int CalculateDesync(TimeSpan idealPlaybackPosition, TimeSpan actualPlaybackPosition)
		{
			return default(int);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x9C0CB8", Offset = "0x9C0CB8", VA = "0x9C0CB8")]
		private static float CalculateCorrectionFactor(float desyncMilliseconds)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000112")]
	internal class EncodedAudioBuffer
	{
		[Token(Token = "0x2000113")]
		public class VoicePacketComparer : IComparer<VoicePacket>
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x9C0FAC", Offset = "0x9C0FAC", VA = "0x9C0FAC", Slot = "4")]
			public int Compare(VoicePacket x, VoicePacket y)
			{
				return default(int);
			}

			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x9C0E54", Offset = "0x9C0E54", VA = "0x9C0E54")]
			public VoicePacketComparer()
			{
			}
		}

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MinHeap<VoicePacket> _heap;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action<VoicePacket> _droppedFrameHandler;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _complete;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _count;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PacketLossCalculator _loss;

		[Token(Token = "0x17000176")]
		public int Count
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x9C0E3C", Offset = "0x9C0E3C", VA = "0x9C0E3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000177")]
		public uint SequenceNumber
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x9C0E44", Offset = "0x9C0E44", VA = "0x9C0E44")]
			[CompilerGenerated]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x9C0E4C", Offset = "0x9C0E4C", VA = "0x9C0E4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public float PacketLoss
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x9BD5A0", Offset = "0x9BD5A0", VA = "0x9BD5A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x9BD98C", Offset = "0x9BD98C", VA = "0x9BD98C")]
		public EncodedAudioBuffer([NotNull] Action<VoicePacket> droppedFrameHandler)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x9BEE60", Offset = "0x9BEE60", VA = "0x9BEE60")]
		public void Push(VoicePacket frame)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x9BF01C", Offset = "0x9BF01C", VA = "0x9BF01C")]
		public void Stop()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x9BE1D8", Offset = "0x9BE1D8", VA = "0x9BE1D8")]
		public bool Read(out VoicePacket? frame, out bool lostPacket)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x9BECA8", Offset = "0x9BECA8", VA = "0x9BECA8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x9C0E5C", Offset = "0x9C0E5C", VA = "0x9C0E5C")]
		private bool IsComplete()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000114")]
	internal struct FrameFormat : IEquatable<FrameFormat>
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly Codec Codec;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly WaveFormat WaveFormat;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly uint FrameSize;

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x9C0FC0", Offset = "0x9C0FC0", VA = "0x9C0FC0")]
		public FrameFormat(Codec codec, WaveFormat waveFormat, uint frameSize)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x9C0FD0", Offset = "0x9C0FD0", VA = "0x9C0FD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x9C102C", Offset = "0x9C102C", VA = "0x9C102C", Slot = "4")]
		public bool Equals(FrameFormat other)
		{
			return default(bool);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x9C1078", Offset = "0x9C1078", VA = "0x9C1078", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000115")]
	internal class FrameToSampleConverter : ISampleSource
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IFrameSource _source;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float[] _temp;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _upstreamComplete;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _firstSample;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int _lastSample;

		[Token(Token = "0x17000179")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x9C1108", Offset = "0x9C1108", VA = "0x9C1108", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x9BFD58", Offset = "0x9BFD58", VA = "0x9BFD58")]
		public FrameToSampleConverter([NotNull] IFrameSource source)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x9C11AC", Offset = "0x9C11AC", VA = "0x9C11AC", Slot = "5")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x9C1268", Offset = "0x9C1268", VA = "0x9C1268", Slot = "6")]
		public bool Read(ArraySegment<float> samples)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x9C156C", Offset = "0x9C156C", VA = "0x9C156C", Slot = "7")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000116")]
	internal interface IDecoderPipeline
	{
		[Token(Token = "0x1700017A")]
		int BufferCount
		{
			[Token(Token = "0x60007C6")]
			get;
		}

		[Token(Token = "0x1700017B")]
		TimeSpan BufferTime
		{
			[Token(Token = "0x60007C7")]
			get;
		}

		[Token(Token = "0x1700017C")]
		float PacketLoss
		{
			[Token(Token = "0x60007C8")]
			get;
		}

		[Token(Token = "0x1700017D")]
		TimeSpan InputFrameTime
		{
			[Token(Token = "0x60007C9")]
			get;
		}

		[Token(Token = "0x1700017E")]
		PlaybackOptions PlaybackOptions
		{
			[Token(Token = "0x60007CA")]
			get;
		}

		[Token(Token = "0x1700017F")]
		[NotNull]
		WaveFormat OutputFormat
		{
			[Token(Token = "0x60007CB")]
			get;
		}

		[Token(Token = "0x60007CC")]
		void Prepare(SessionContext context);

		[Token(Token = "0x60007CD")]
		bool Read(ArraySegment<float> samples);
	}
	[Token(Token = "0x2000117")]
	internal interface IFrameSource
	{
		[Token(Token = "0x17000180")]
		uint FrameSize
		{
			[Token(Token = "0x60007CE")]
			get;
		}

		[Token(Token = "0x17000181")]
		[NotNull]
		WaveFormat WaveFormat
		{
			[Token(Token = "0x60007CF")]
			get;
		}

		[Token(Token = "0x60007D0")]
		void Prepare(SessionContext context);

		[Token(Token = "0x60007D1")]
		bool Read(ArraySegment<float> frame);

		[Token(Token = "0x60007D2")]
		void Reset();
	}
	[Token(Token = "0x2000118")]
	public interface IPriorityManager
	{
		[Token(Token = "0x17000182")]
		ChannelPriority TopPriority
		{
			[Token(Token = "0x60007D3")]
			get;
		}
	}
	[Token(Token = "0x2000119")]
	internal class PriorityManager : IPriorityManager
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PlayerCollection _players;

		[Token(Token = "0x17000183")]
		public ChannelPriority TopPriority
		{
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x9C16F8", Offset = "0x9C16F8", VA = "0x9C16F8", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ChannelPriority);
			}
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x9C1700", Offset = "0x9C1700", VA = "0x9C1700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x9C1708", Offset = "0x9C1708", VA = "0x9C1708")]
		public PriorityManager(PlayerCollection players)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x9C1738", Offset = "0x9C1738", VA = "0x9C1738")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x200011A")]
	internal interface IRemoteChannelProvider
	{
		[Token(Token = "0x60007D9")]
		void GetRemoteChannels([NotNull] List<RemoteChannel> output);
	}
	[Token(Token = "0x200011B")]
	internal interface ISampleSource
	{
		[Token(Token = "0x17000184")]
		[NotNull]
		WaveFormat WaveFormat
		{
			[Token(Token = "0x60007DA")]
			get;
		}

		[Token(Token = "0x60007DB")]
		void Prepare(SessionContext context);

		[Token(Token = "0x60007DC")]
		bool Read(ArraySegment<float> samples);

		[Token(Token = "0x60007DD")]
		void Reset();
	}
	[Token(Token = "0x200011C")]
	internal interface IVoicePlaybackInternal : IRemoteChannelProvider, IVoicePlayback
	{
		[Token(Token = "0x17000185")]
		bool IsMuted
		{
			[Token(Token = "0x60007DE")]
			get;
			[Token(Token = "0x60007DF")]
			set;
		}

		[Token(Token = "0x17000186")]
		bool AllowPositionalPlayback
		{
			[Token(Token = "0x60007E3")]
			get;
			[Token(Token = "0x60007E4")]
			set;
		}

		[Token(Token = "0x17000187")]
		bool IsApplyingAudioSpatialization
		{
			[Token(Token = "0x60007E5")]
			get;
		}

		[Token(Token = "0x17000188")]
		float PlaybackVolume
		{
			[Token(Token = "0x60007E7")]
			get;
			[Token(Token = "0x60007E8")]
			set;
		}

		[Token(Token = "0x60007E0")]
		void Reset();

		[Token(Token = "0x60007E1")]
		void StartPlayback();

		[Token(Token = "0x60007E2")]
		void StopPlayback();

		[Token(Token = "0x60007E6")]
		void SetTransform(Vector3 position, Quaternion rotation);

		[Token(Token = "0x60007E9")]
		void ReceiveAudioPacket(VoicePacket packet);
	}
	[Token(Token = "0x200011D")]
	public interface IVoicePlayback
	{
		[Token(Token = "0x17000189")]
		string PlayerName
		{
			[Token(Token = "0x60007EA")]
			get;
		}

		[Token(Token = "0x1700018A")]
		bool IsActive
		{
			[Token(Token = "0x60007EB")]
			get;
		}

		[Token(Token = "0x1700018B")]
		bool IsSpeaking
		{
			[Token(Token = "0x60007EC")]
			get;
		}

		[Token(Token = "0x1700018C")]
		float Amplitude
		{
			[Token(Token = "0x60007ED")]
			get;
		}

		[Token(Token = "0x1700018D")]
		float? PacketLoss
		{
			[Token(Token = "0x60007EE")]
			get;
		}

		[Token(Token = "0x1700018E")]
		float Jitter
		{
			[Token(Token = "0x60007EF")]
			get;
		}

		[Token(Token = "0x1700018F")]
		ChannelPriority Priority
		{
			[Token(Token = "0x60007F0")]
			get;
		}
	}
	[Token(Token = "0x200011E")]
	public struct PlaybackOptions
	{
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly bool _isPositional;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private readonly float _amplitudeMultiplier;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly ChannelPriority _priority;

		[Token(Token = "0x17000190")]
		public bool IsPositional
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x9C195C", Offset = "0x9C195C", VA = "0x9C195C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000191")]
		public float AmplitudeMultiplier
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x9C1964", Offset = "0x9C1964", VA = "0x9C1964")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000192")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x9C196C", Offset = "0x9C196C", VA = "0x9C196C")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x9B0B34", Offset = "0x9B0B34", VA = "0x9B0B34")]
		public PlaybackOptions(bool isPositional, float amplitudeMultiplier, ChannelPriority priority)
		{
		}
	}
	[Token(Token = "0x200011F")]
	internal class Resampler : ISampleSource
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ISampleSource _source;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private WaveFormat _outputFormat;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WdlResampler _resampler;

		[Token(Token = "0x17000193")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x9C1A70", Offset = "0x9C1A70", VA = "0x9C1A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x9C002C", Offset = "0x9C002C", VA = "0x9C002C")]
		public Resampler(ISampleSource source)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x9C1A88", Offset = "0x9C1A88", VA = "0x9C1A88", Slot = "5")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x9C1B44", Offset = "0x9C1B44", VA = "0x9C1B44", Slot = "6")]
		public bool Read(ArraySegment<float> samples)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x9C1E9C", Offset = "0x9C1E9C", VA = "0x9C1E9C", Slot = "7")]
		public void Reset()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x9C1974", Offset = "0x9C1974", VA = "0x9C1974")]
		private void OnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class SamplePlaybackComponent : MonoBehaviour
	{
		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly TimeSpan ResetDesync;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly float[] DesyncFixBuffer;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DesyncCalculator _desync;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long _totalSamplesRead;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float[] _temp;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[CanBeNull]
		private AudioFileWriter _diagnosticOutput;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SessionContext _lastPlayedSessionContext;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly ReaderWriterLockSlim _sessionLock;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _arv;

		[Token(Token = "0x17000194")]
		internal bool MultiplyBySource
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x9C2034", Offset = "0x9C2034", VA = "0x9C2034")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x9C203C", Offset = "0x9C203C", VA = "0x9C203C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public bool HasActiveSession
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x9C2048", Offset = "0x9C2048", VA = "0x9C2048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000196")]
		public SpeechSession? Session
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x9C208C", Offset = "0x9C208C", VA = "0x9C208C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x9C209C", Offset = "0x9C209C", VA = "0x9C209C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public TimeSpan PlaybackPosition
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x9C20B4", Offset = "0x9C20B4", VA = "0x9C20B4")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000198")]
		public TimeSpan IdealPlaybackPosition
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x9C2278", Offset = "0x9C2278", VA = "0x9C2278")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x17000199")]
		public TimeSpan Desync
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x9C2404", Offset = "0x9C2404", VA = "0x9C2404")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x1700019A")]
		public float CorrectedPlaybackSpeed
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x9C2460", Offset = "0x9C2460", VA = "0x9C2460")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700019B")]
		public float ARV
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x9C24AC", Offset = "0x9C24AC", VA = "0x9C24AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x9C24CC", Offset = "0x9C24CC", VA = "0x9C24CC")]
		public void Play(SpeechSession session)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x9C2850", Offset = "0x9C2850", VA = "0x9C2850")]
		public void Start()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x9C28AC", Offset = "0x9C28AC", VA = "0x9C28AC")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x9C28F0", Offset = "0x9C28F0", VA = "0x9C28F0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x9C2934", Offset = "0x9C2934", VA = "0x9C2934")]
		public void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x9C2824", Offset = "0x9C2824", VA = "0x9C2824")]
		private void ApplyReset()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x9C2DB4", Offset = "0x9C2DB4", VA = "0x9C2DB4")]
		internal static bool Skip(SpeechSession session, int desyncMilliseconds, out int deltaSamples, out int deltaDesyncMilliseconds)
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x9C302C", Offset = "0x9C302C", VA = "0x9C302C")]
		internal static bool Filter(SpeechSession session, [NotNull] float[] output, int channels, [NotNull] float[] temp, [CanBeNull] AudioFileWriter diagnosticOutput, out float arv, out int samplesRead, bool multiply)
		{
			return default(bool);
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x9C328C", Offset = "0x9C328C", VA = "0x9C328C")]
		public SamplePlaybackComponent()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public struct SessionContext : IEquatable<SessionContext>
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly string PlayerName;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly uint Id;

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x9C3448", Offset = "0x9C3448", VA = "0x9C3448")]
		public SessionContext([NotNull] string playerName, uint id)
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x9C2D74", Offset = "0x9C2D74", VA = "0x9C2D74", Slot = "4")]
		public bool Equals(SessionContext other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x9C34C8", Offset = "0x9C34C8", VA = "0x9C34C8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x9C3550", Offset = "0x9C3550", VA = "0x9C3550", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000122")]
	internal class SoftClipSampleSource : ISampleSource
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ISampleSource _upstream;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly OpusNative.OpusSoftClip _clipper;

		[Token(Token = "0x1700019C")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x9C3578", Offset = "0x9C3578", VA = "0x9C3578", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x9BFEF0", Offset = "0x9BFEF0", VA = "0x9BFEF0")]
		public SoftClipSampleSource([NotNull] ISampleSource upstream)
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x9C3618", Offset = "0x9C3618", VA = "0x9C3618", Slot = "5")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x9C36D4", Offset = "0x9C36D4", VA = "0x9C36D4", Slot = "6")]
		public bool Read(ArraySegment<float> samples)
		{
			return default(bool);
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x9C37B8", Offset = "0x9C37B8", VA = "0x9C37B8", Slot = "7")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public struct SpeechSession
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] PreplayDesyncFixBuffer;

		[Token(Token = "0x4000405")]
		private const float MinimumDelayFactor = 1.25f;

		[Token(Token = "0x4000406")]
		private const float MaximumDelay = 0.75f;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int FixedDelayToleranceTicks;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly float InitialBufferDelay;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly float _minimumDelay;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IRemoteChannelProvider _channels;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDecoderPipeline _pipeline;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly SessionContext _context;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly DateTime _creationTime;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IJitterEstimator _jitter;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DateTime _startTime;

		[Token(Token = "0x1700019D")]
		public int BufferCount
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x9C386C", Offset = "0x9C386C", VA = "0x9C386C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700019E")]
		public SessionContext Context
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x9C390C", Offset = "0x9C390C", VA = "0x9C390C")]
			get
			{
				return default(SessionContext);
			}
		}

		[Token(Token = "0x1700019F")]
		public PlaybackOptions PlaybackOptions
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x9C3918", Offset = "0x9C3918", VA = "0x9C3918")]
			get
			{
				return default(PlaybackOptions);
			}
		}

		[Token(Token = "0x170001A0")]
		[NotNull]
		public WaveFormat OutputWaveFormat
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x9C21D4", Offset = "0x9C21D4", VA = "0x9C21D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A1")]
		internal float PacketLoss
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x9C39C4", Offset = "0x9C39C4", VA = "0x9C39C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001A2")]
		internal IRemoteChannelProvider Channels
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x9C3A68", Offset = "0x9C3A68", VA = "0x9C3A68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A3")]
		public DateTime TargetActivationTime
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x9C3A70", Offset = "0x9C3A70", VA = "0x9C3A70")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x170001A4")]
		public DateTime ActivationTime
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x9C2394", Offset = "0x9C2394", VA = "0x9C2394")]
			get
			{
				return default(DateTime);
			}
		}

		[Token(Token = "0x170001A5")]
		public TimeSpan Delay
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x9C3AE0", Offset = "0x9C3AE0", VA = "0x9C3AE0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x9C3C78", Offset = "0x9C3C78", VA = "0x9C3C78")]
		private SpeechSession(SessionContext context, IJitterEstimator jitter, IDecoderPipeline pipeline, IRemoteChannelProvider channels, DateTime now)
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x9C3D80", Offset = "0x9C3D80", VA = "0x9C3D80")]
		internal static SpeechSession Create(SessionContext context, IJitterEstimator jitter, IDecoderPipeline pipeline, IRemoteChannelProvider channels, DateTime now)
		{
			return default(SpeechSession);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x9C3DAC", Offset = "0x9C3DAC", VA = "0x9C3DAC")]
		public void Prepare(DateTime now, DateTime timeOfFirstDequeueAttempt)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x9C31D0", Offset = "0x9C31D0", VA = "0x9C31D0")]
		public bool Read(ArraySegment<float> samples)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000124")]
	internal interface IJitterEstimator
	{
		[Token(Token = "0x170001A6")]
		float Jitter
		{
			[Token(Token = "0x6000827")]
			get;
		}

		[Token(Token = "0x170001A7")]
		float Confidence
		{
			[Token(Token = "0x6000828")]
			get;
		}
	}
	[Token(Token = "0x2000125")]
	internal class SpeechSessionStream : IJitterEstimator
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Queue<SpeechSession> _awaitingActivation;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IVolumeProvider _volumeProvider;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DateTime? _queueHeadFirstDequeueAttempt;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DecoderPipeline _active;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private uint _currentId;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string _playerName;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly WindowDeviationCalculator _arrivalJitterMeter;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<FrameFormat, ConcurrentPool<DecoderPipeline>> FreePipelines;

		[Token(Token = "0x170001A8")]
		public string PlayerName
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x9C46C4", Offset = "0x9C46C4", VA = "0x9C46C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x9C46CC", Offset = "0x9C46CC", VA = "0x9C46CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		private float Dissonance.Audio.Playback.IJitterEstimator.Jitter
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x9C471C", Offset = "0x9C471C", VA = "0x9C471C", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001AA")]
		private float Dissonance.Audio.Playback.IJitterEstimator.Confidence
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x9C4738", Offset = "0x9C4738", VA = "0x9C4738", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x9C4750", Offset = "0x9C4750", VA = "0x9C4750")]
		public SpeechSessionStream(IVolumeProvider volumeProvider)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x9C4810", Offset = "0x9C4810", VA = "0x9C4810")]
		public void StartSession(FrameFormat format, [Optional] DateTime? now, [Optional][CanBeNull] IJitterEstimator jitter)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x9C4D00", Offset = "0x9C4D00", VA = "0x9C4D00")]
		public SpeechSession? TryDequeueSession([Optional] DateTime? now)
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x9C4F2C", Offset = "0x9C4F2C", VA = "0x9C4F2C")]
		public void ReceiveFrame(VoicePacket packet, [Optional] DateTime? now)
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x9C5158", Offset = "0x9C5158", VA = "0x9C5158")]
		public void StopSession(bool logNoSessionError = true)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x9C4A74", Offset = "0x9C4A74", VA = "0x9C4A74")]
		[NotNull]
		private static DecoderPipeline GetOrCreateDecoderPipeline(FrameFormat format, [NotNull] IVolumeProvider volume)
		{
			return null;
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x9C5238", Offset = "0x9C5238", VA = "0x9C5238")]
		private static void Recycle(FrameFormat format, DecoderPipeline pipeline)
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class VoicePlayback : MonoBehaviour, IVoicePlaybackInternal, IRemoteChannelProvider, IVoicePlayback, IVolumeProvider
	{
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly SpeechSessionStream _sessions;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PlaybackOptions _cachedPlaybackOptions;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private SamplePlaybackComponent _player;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CodecSettings _codecSettings;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private FrameFormat _frameFormat;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float? _savedSpatialBlend;

		[Token(Token = "0x170001AB")]
		public AudioSource AudioSource
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x9C567C", Offset = "0x9C567C", VA = "0x9C567C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x9C5684", Offset = "0x9C5684", VA = "0x9C5684")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		private bool Dissonance.Audio.Playback.IVoicePlaybackInternal.AllowPositionalPlayback
		{
			[Token(Token = "0x600083A")]
			[Address(RVA = "0x9C568C", Offset = "0x9C568C", VA = "0x9C568C", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600083B")]
			[Address(RVA = "0x9C5694", Offset = "0x9C5694", VA = "0x9C5694", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public bool IsActive
		{
			[Token(Token = "0x600083C")]
			[Address(RVA = "0x9C56A0", Offset = "0x9C56A0", VA = "0x9C56A0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001AE")]
		public string PlayerName
		{
			[Token(Token = "0x600083D")]
			[Address(RVA = "0x9C56A8", Offset = "0x9C56A8", VA = "0x9C56A8", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x600083E")]
			[Address(RVA = "0x9C56C4", Offset = "0x9C56C4", VA = "0x9C56C4")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public CodecSettings CodecSettings
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x9C56DC", Offset = "0x9C56DC", VA = "0x9C56DC")]
			get
			{
				return default(CodecSettings);
			}
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x9C56EC", Offset = "0x9C56EC", VA = "0x9C56EC")]
			internal set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public bool IsSpeaking
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x9C57B0", Offset = "0x9C57B0", VA = "0x9C57B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B1")]
		public float Amplitude
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x9C5858", Offset = "0x9C5858", VA = "0x9C5858", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001B2")]
		public ChannelPriority Priority
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x9C58E4", Offset = "0x9C58E4", VA = "0x9C58E4", Slot = "23")]
			get
			{
				return default(ChannelPriority);
			}
		}

		[Token(Token = "0x170001B3")]
		private bool Dissonance.Audio.Playback.IVoicePlaybackInternal.IsMuted
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x9C5978", Offset = "0x9C5978", VA = "0x9C5978", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x9C5980", Offset = "0x9C5980", VA = "0x9C5980", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		private float Dissonance.Audio.Playback.IVoicePlaybackInternal.PlaybackVolume
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x9C598C", Offset = "0x9C598C", VA = "0x9C598C", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x9C5994", Offset = "0x9C5994", VA = "0x9C5994", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		private bool IsApplyingAudioSpatialization
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x9C599C", Offset = "0x9C599C", VA = "0x9C599C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x9C59A4", Offset = "0x9C59A4", VA = "0x9C59A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		private bool Dissonance.Audio.Playback.IVoicePlaybackInternal.IsApplyingAudioSpatialization
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x9C59B0", Offset = "0x9C59B0", VA = "0x9C59B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B7")]
		internal IPriorityManager PriorityManager
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x9C59B8", Offset = "0x9C59B8", VA = "0x9C59B8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x9C59C0", Offset = "0x9C59C0", VA = "0x9C59C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		private float? Dissonance.Audio.Playback.IVoicePlayback.PacketLoss
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x9C59C8", Offset = "0x9C59C8", VA = "0x9C59C8", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B9")]
		private float Dissonance.Audio.Playback.IVoicePlayback.Jitter
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x9C5ABC", Offset = "0x9C5ABC", VA = "0x9C5ABC", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001BA")]
		[CanBeNull]
		internal IVolumeProvider VolumeProvider
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x9C6584", Offset = "0x9C6584", VA = "0x9C6584")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x9C658C", Offset = "0x9C658C", VA = "0x9C658C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		private float Dissonance.Audio.Playback.IVolumeProvider.TargetVolume
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x9C6594", Offset = "0x9C6594", VA = "0x9C6594", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x9C5B5C", Offset = "0x9C5B5C", VA = "0x9C5B5C")]
		public VoicePlayback()
		{
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x9C5C38", Offset = "0x9C5C38", VA = "0x9C5C38")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x9C5D20", Offset = "0x9C5D20", VA = "0x9C5D20", Slot = "6")]
		private void Dissonance.Audio.Playback.IVoicePlaybackInternal.Reset()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x9C5E1C", Offset = "0x9C5E1C", VA = "0x9C5E1C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x9C5FD0", Offset = "0x9C5FD0", VA = "0x9C5FD0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x9C5FEC", Offset = "0x9C5FEC", VA = "0x9C5FEC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x9C6238", Offset = "0x9C6238", VA = "0x9C6238")]
		private void UpdatePositionalPlayback()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x9C6428", Offset = "0x9C6428", VA = "0x9C6428", Slot = "12")]
		private void Dissonance.Audio.Playback.IVoicePlaybackInternal.SetTransform(Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x9C64B0", Offset = "0x9C64B0", VA = "0x9C64B0", Slot = "7")]
		private void Dissonance.Audio.Playback.IVoicePlaybackInternal.StartPlayback()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x9C6508", Offset = "0x9C6508", VA = "0x9C6508", Slot = "8")]
		private void Dissonance.Audio.Playback.IVoicePlaybackInternal.StopPlayback()
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x9C6524", Offset = "0x9C6524", VA = "0x9C6524", Slot = "15")]
		private void Dissonance.Audio.Playback.IVoicePlaybackInternal.ReceiveAudioPacket(VoicePacket packet)
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x9C67A8", Offset = "0x9C67A8", VA = "0x9C67A8", Slot = "16")]
		private void Dissonance.Audio.Playback.IRemoteChannelProvider.GetRemoteChannels(List<RemoteChannel> output)
		{
		}
	}
	[Token(Token = "0x2000129")]
	internal class VolumeRampedFrameSource : IFrameSource
	{
		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IFrameSource _source;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IVolumeProvider _volumeProvider;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _targetVolume;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _currentVolume;

		[Token(Token = "0x170001BC")]
		public uint FrameSize
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x9C6A78", Offset = "0x9C6A78", VA = "0x9C6A78", Slot = "4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170001BD")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x9C6B18", Offset = "0x9C6B18", VA = "0x9C6B18", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x9BFD2C", Offset = "0x9BFD2C", VA = "0x9BFD2C")]
		public VolumeRampedFrameSource(IFrameSource source, IVolumeProvider volumeProvider)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x9C6BBC", Offset = "0x9C6BBC", VA = "0x9C6BBC", Slot = "6")]
		public void Prepare(SessionContext context)
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x9C6C78", Offset = "0x9C6C78", VA = "0x9C6C78", Slot = "7")]
		public bool Read(ArraySegment<float> frame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x9C6DF0", Offset = "0x9C6DF0", VA = "0x9C6DF0")]
		private static void ApplyFlatAttenuation(ArraySegment<float> frame, float volume)
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x9C6F2C", Offset = "0x9C6F2C", VA = "0x9C6F2C")]
		private static void ApplyRampedAttenuation(ArraySegment<float> frame, float start, float end)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x9C704C", Offset = "0x9C704C", VA = "0x9C704C", Slot = "8")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200012A")]
	internal interface IVolumeProvider
	{
		[Token(Token = "0x170001BE")]
		float TargetVolume
		{
			[Token(Token = "0x600086A")]
			get;
		}
	}
}
namespace Dissonance.Audio.Codecs
{
	[Token(Token = "0x200012B")]
	public enum Codec : byte
	{
		[Token(Token = "0x4000430")]
		Identity,
		[Token(Token = "0x4000431")]
		Opus
	}
	[Token(Token = "0x200012C")]
	public struct EncodedBuffer
	{
		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly ArraySegment<byte>? Encoded;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool PacketLost;

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x9C80F8", Offset = "0x9C80F8", VA = "0x9C80F8")]
		public EncodedBuffer(ArraySegment<byte>? encoded, bool packetLost)
		{
		}
	}
	[Token(Token = "0x200012D")]
	internal interface IVoiceDecoder : IDisposable
	{
		[Token(Token = "0x170001BF")]
		[NotNull]
		WaveFormat Format
		{
			[Token(Token = "0x600086C")]
			get;
		}

		[Token(Token = "0x600086D")]
		void Reset();

		[Token(Token = "0x600086E")]
		int Decode(EncodedBuffer input, ArraySegment<float> output);
	}
	[Token(Token = "0x200012E")]
	internal interface IVoiceEncoder : IDisposable
	{
		[Token(Token = "0x170001C0")]
		float PacketLoss
		{
			[Token(Token = "0x600086F")]
			set;
		}

		[Token(Token = "0x170001C1")]
		int FrameSize
		{
			[Token(Token = "0x6000870")]
			get;
		}

		[Token(Token = "0x170001C2")]
		int SampleRate
		{
			[Token(Token = "0x6000871")]
			get;
		}

		[Token(Token = "0x6000872")]
		ArraySegment<byte> Encode(ArraySegment<float> samples, ArraySegment<byte> array);

		[Token(Token = "0x6000873")]
		void Reset();
	}
}
namespace Dissonance.Audio.Codecs.Silence
{
	[Token(Token = "0x200012F")]
	internal class SilenceDecoder : IVoiceDecoder, IDisposable
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int _frameSize;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly WaveFormat _format;

		[Token(Token = "0x170001C3")]
		public WaveFormat Format
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x9C8114", Offset = "0x9C8114", VA = "0x9C8114", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x9C811C", Offset = "0x9C811C", VA = "0x9C811C")]
		public SilenceDecoder(FrameFormat frameFormat)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x9C8150", Offset = "0x9C8150", VA = "0x9C8150", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x9C8154", Offset = "0x9C8154", VA = "0x9C8154", Slot = "5")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x9C8158", Offset = "0x9C8158", VA = "0x9C8158", Slot = "6")]
		public int Decode(EncodedBuffer input, ArraySegment<float> output)
		{
			return default(int);
		}
	}
}
namespace Dissonance.Audio.Codecs.Opus
{
	[Token(Token = "0x2000130")]
	internal static class BandwidthExtensions
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x9C81BC", Offset = "0x9C81BC", VA = "0x9C81BC")]
		public static int SampleRate(this OpusNative.Bandwidth bandwidth)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000131")]
	internal class OpusNative
	{
		[Token(Token = "0x2000132")]
		private static class OpusNativeMethods
		{
			[PreserveSig]
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x9C8404", Offset = "0x9C8404", VA = "0x9C8404")]
			internal static extern IntPtr opus_get_version_string();

			[PreserveSig]
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x9C8474", Offset = "0x9C8474", VA = "0x9C8474")]
			internal static extern IntPtr opus_encoder_create(int samplingRate, int channels, int application, out int error);

			[PreserveSig]
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x9C8510", Offset = "0x9C8510", VA = "0x9C8510")]
			internal static extern void opus_encoder_destroy(IntPtr encoder);

			[PreserveSig]
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x9C858C", Offset = "0x9C858C", VA = "0x9C858C")]
			internal static extern int opus_encode_float(IntPtr encoder, IntPtr floatPcm, int frameSize, IntPtr byteEncoded, int maxEncodedLength);

			[PreserveSig]
			[Token(Token = "0x6000881")]
			[Address(RVA = "0x9C8638", Offset = "0x9C8638", VA = "0x9C8638")]
			internal static extern IntPtr opus_decoder_create(int samplingRate, int channels, out int error);

			[PreserveSig]
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x9C86CC", Offset = "0x9C86CC", VA = "0x9C86CC")]
			internal static extern IntPtr opus_decoder_destroy(IntPtr decoder);

			[PreserveSig]
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x9C8748", Offset = "0x9C8748", VA = "0x9C8748")]
			internal static extern int opus_decode_float(IntPtr decoder, IntPtr byteData, int dataLength, IntPtr floatPcm, int frameSize, bool decodeFEC);

			[PreserveSig]
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x9C87FC", Offset = "0x9C87FC", VA = "0x9C87FC")]
			internal static extern int opus_decoder_ctl(IntPtr st, Ctl request, out int value);

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x9C8890", Offset = "0x9C8890", VA = "0x9C8890")]
			internal static int dissonance_opus_decoder_ctl_out(IntPtr st, Ctl request, out int value)
			{
				return default(int);
			}

			[PreserveSig]
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x9C8894", Offset = "0x9C8894", VA = "0x9C8894")]
			internal static extern int opus_decoder_ctl(IntPtr st, Ctl request, int value);

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x9C8924", Offset = "0x9C8924", VA = "0x9C8924")]
			internal static int dissonance_opus_decoder_ctl_in(IntPtr st, Ctl request, int value)
			{
				return default(int);
			}

			[PreserveSig]
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x9C8928", Offset = "0x9C8928", VA = "0x9C8928")]
			internal static extern int opus_encoder_ctl(IntPtr st, Ctl request, out int value);

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x9C89BC", Offset = "0x9C89BC", VA = "0x9C89BC")]
			internal static int dissonance_opus_encoder_ctl_out(IntPtr st, Ctl request, out int value)
			{
				return default(int);
			}

			[PreserveSig]
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x9C89C0", Offset = "0x9C89C0", VA = "0x9C89C0")]
			internal static extern int opus_encoder_ctl(IntPtr st, Ctl request, int value);

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x9C8A50", Offset = "0x9C8A50", VA = "0x9C8A50")]
			internal static int dissonance_opus_encoder_ctl_in(IntPtr st, Ctl request, int value)
			{
				return default(int);
			}

			[PreserveSig]
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x9C8A54", Offset = "0x9C8A54", VA = "0x9C8A54")]
			internal static extern void opus_pcm_soft_clip(IntPtr pcm, int frameSize, int channels, float[] softClipMem);
		}

		[Token(Token = "0x2000133")]
		private enum Ctl
		{
			[Token(Token = "0x4000438")]
			SetBitrateRequest = 4002,
			[Token(Token = "0x4000439")]
			GetBitrateRequest = 4003,
			[Token(Token = "0x400043A")]
			SetInbandFECRequest = 4012,
			[Token(Token = "0x400043B")]
			GetInbandFECRequest = 4013,
			[Token(Token = "0x400043C")]
			SetPacketLossPercRequest = 4014,
			[Token(Token = "0x400043D")]
			GetPacketLossPercRequest = 4015,
			[Token(Token = "0x400043E")]
			ResetState = 4028
		}

		[Token(Token = "0x2000134")]
		public enum Bandwidth
		{
			[Token(Token = "0x4000440")]
			Narrowband = 1101,
			[Token(Token = "0x4000441")]
			Mediumband,
			[Token(Token = "0x4000442")]
			Wideband,
			[Token(Token = "0x4000443")]
			SuperWideband,
			[Token(Token = "0x4000444")]
			Fullband
		}

		[Token(Token = "0x2000135")]
		private enum Application
		{
			[Token(Token = "0x4000446")]
			Voip = 2048,
			[Token(Token = "0x4000447")]
			Audio = 2049,
			[Token(Token = "0x4000448")]
			RestrictedLowLatency = 2051
		}

		[Token(Token = "0x2000136")]
		private enum OpusErrors
		{
			[Token(Token = "0x400044A")]
			Ok = 0,
			[Token(Token = "0x400044B")]
			BadArg = -1,
			[Token(Token = "0x400044C")]
			BufferToSmall = -2,
			[Token(Token = "0x400044D")]
			InternalError = -3,
			[Token(Token = "0x400044E")]
			InvalidPacket = -4,
			[Token(Token = "0x400044F")]
			Unimplemented = -5,
			[Token(Token = "0x4000450")]
			InvalidState = -6,
			[Token(Token = "0x4000451")]
			AllocFail = -7
		}

		[Token(Token = "0x2000137")]
		public class OpusException : Exception
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x9C8AF8", Offset = "0x9C8AF8", VA = "0x9C8AF8")]
			public OpusException(string message)
			{
			}
		}

		[Token(Token = "0x2000138")]
		public sealed class OpusEncoder : IDisposable
		{
			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Log Log;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly LockedValue<IntPtr> _encoder;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int _packetLoss;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private bool _disposed;

			[Token(Token = "0x170001C4")]
			public int Bitrate
			{
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x9C8B60", Offset = "0x9C8B60", VA = "0x9C8B60")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600088F")]
				[Address(RVA = "0x9C8F58", Offset = "0x9C8F58", VA = "0x9C8F58")]
				set
				{
				}
			}

			[Token(Token = "0x170001C5")]
			public bool EnableForwardErrorCorrection
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x9C933C", Offset = "0x9C933C", VA = "0x9C933C")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000891")]
				[Address(RVA = "0x9C9364", Offset = "0x9C9364", VA = "0x9C9364")]
				set
				{
				}
			}

			[Token(Token = "0x170001C6")]
			public float PacketLoss
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x9C93D8", Offset = "0x9C93D8", VA = "0x9C93D8")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000893")]
				[Address(RVA = "0x9C9408", Offset = "0x9C9408", VA = "0x9C9408")]
				set
				{
				}
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x9C9568", Offset = "0x9C9568", VA = "0x9C9568")]
			public OpusEncoder(int srcSamplingRate, int srcChannelCount)
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x9C9858", Offset = "0x9C9858", VA = "0x9C9858")]
			public int EncodeFloats(ArraySegment<float> sourcePcm, ArraySegment<byte> dstEncoded)
			{
				return default(int);
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x9C9EF8", Offset = "0x9C9EF8", VA = "0x9C9EF8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x9C8F64", Offset = "0x9C8F64", VA = "0x9C8F64")]
			private int OpusCtlIn(Ctl ctl, int value)
			{
				return default(int);
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x9C8B80", Offset = "0x9C8B80", VA = "0x9C8B80")]
			private int OpusCtlOut(Ctl ctl, out int value)
			{
				return default(int);
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x9CA174", Offset = "0x9CA174", VA = "0x9CA174", Slot = "1")]
			~OpusEncoder()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x9CA208", Offset = "0x9CA208", VA = "0x9CA208", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000139")]
		public sealed class OpusDecoder : IDisposable
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Log Log;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly LockedValue<IntPtr> _decoder;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			private bool _disposed;

			[Token(Token = "0x170001C7")]
			public bool EnableForwardErrorCorrection
			{
				[Token(Token = "0x600089C")]
				[Address(RVA = "0x9CA53C", Offset = "0x9CA53C", VA = "0x9CA53C")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600089D")]
				[Address(RVA = "0x9CA544", Offset = "0x9CA544", VA = "0x9CA544")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x9CA550", Offset = "0x9CA550", VA = "0x9CA550")]
			public OpusDecoder(int outputSampleRate, int outputChannelCount)
			{
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x9CA840", Offset = "0x9CA840", VA = "0x9CA840", Slot = "1")]
			~OpusDecoder()
			{
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x9CA8D4", Offset = "0x9CA8D4", VA = "0x9CA8D4", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x9CAB2C", Offset = "0x9CAB2C", VA = "0x9CAB2C")]
			public int DecodeFloats(EncodedBuffer srcEncodedBuffer, ArraySegment<float> dstBuffer)
			{
				return default(int);
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x9CB280", Offset = "0x9CB280", VA = "0x9CB280")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x200013A")]
		public sealed class OpusSoftClip
		{
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly bool _disabled;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float[] _memory;

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x9CB520", Offset = "0x9CB520", VA = "0x9CB520")]
			public OpusSoftClip(int channels = 1)
			{
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x9CB680", Offset = "0x9CB680", VA = "0x9CB680")]
			public void Clip(ArraySegment<float> samples)
			{
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x9CB7A4", Offset = "0x9CB7A4", VA = "0x9CB7A4")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x9C83A4", Offset = "0x9C83A4", VA = "0x9C83A4")]
		[NotNull]
		public static string OpusVersion()
		{
			return null;
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x9C846C", Offset = "0x9C846C", VA = "0x9C846C")]
		public OpusNative()
		{
		}
	}
	[Token(Token = "0x200013B")]
	internal class OpusDecoder : IVoiceDecoder, IDisposable
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WaveFormat _format;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private OpusNative.OpusDecoder _decoder;

		[Token(Token = "0x170001C8")]
		public WaveFormat Format
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x9CB7C8", Offset = "0x9CB7C8", VA = "0x9CB7C8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x9CB7D0", Offset = "0x9CB7D0", VA = "0x9CB7D0")]
		public OpusDecoder([NotNull] WaveFormat format, bool fec = true)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x9CB8B0", Offset = "0x9CB8B0", VA = "0x9CB8B0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x9CB8D0", Offset = "0x9CB8D0", VA = "0x9CB8D0", Slot = "5")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x9CB8E8", Offset = "0x9CB8E8", VA = "0x9CB8E8", Slot = "6")]
		public int Decode(EncodedBuffer input, ArraySegment<float> output)
		{
			return default(int);
		}
	}
	[Token(Token = "0x200013C")]
	internal class OpusEncoder : IVoiceEncoder, IDisposable
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly OpusNative.OpusEncoder _encoder;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int[] PermittedFrameSizesSamples;

		[Token(Token = "0x4000461")]
		public const int FixedSampleRate = 48000;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int _frameSize;

		[Token(Token = "0x170001C9")]
		public int SampleRate
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x9CB920", Offset = "0x9CB920", VA = "0x9CB920", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CA")]
		public float PacketLoss
		{
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x9CB928", Offset = "0x9CB928", VA = "0x9CB928", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public int FrameSize
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x9CB940", Offset = "0x9CB940", VA = "0x9CB940", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x9CB948", Offset = "0x9CB948", VA = "0x9CB948")]
		public OpusEncoder(AudioQuality quality, FrameSize frameSize, bool fec = true)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x9CBA28", Offset = "0x9CBA28", VA = "0x9CBA28")]
		private static int GetTargetBitrate(AudioQuality quality)
		{
			return default(int);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x9CBAB8", Offset = "0x9CBAB8", VA = "0x9CBAB8")]
		public static int GetFrameSize(FrameSize size)
		{
			return default(int);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x9CBC64", Offset = "0x9CBC64", VA = "0x9CBC64", Slot = "7")]
		public ArraySegment<byte> Encode(ArraySegment<float> samples, ArraySegment<byte> encodedBuffer)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x9CBE78", Offset = "0x9CBE78", VA = "0x9CBE78", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x9CBE90", Offset = "0x9CBE90", VA = "0x9CBE90", Slot = "9")]
		public void Dispose()
		{
		}
	}
}
namespace Dissonance.Audio.Codecs.Identity
{
	[Token(Token = "0x200013D")]
	internal class IdentityDecoder : IVoiceDecoder, IDisposable
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WaveFormat _format;

		[Token(Token = "0x170001CC")]
		public WaveFormat Format
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x9CBFE0", Offset = "0x9CBFE0", VA = "0x9CBFE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x9CBFE8", Offset = "0x9CBFE8", VA = "0x9CBFE8")]
		public IdentityDecoder(WaveFormat format)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x9CC010", Offset = "0x9CC010", VA = "0x9CC010", Slot = "5")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x9CC014", Offset = "0x9CC014", VA = "0x9CC014", Slot = "6")]
		public int Decode(EncodedBuffer input, ArraySegment<float> output)
		{
			return default(int);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x9CC20C", Offset = "0x9CC20C", VA = "0x9CC20C", Slot = "7")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200013E")]
	internal class IdentityEncoder : IVoiceEncoder, IDisposable
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly int _sampleRate;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly int _frameSize;

		[Token(Token = "0x170001CD")]
		public float PacketLoss
		{
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x9CC210", Offset = "0x9CC210", VA = "0x9CC210", Slot = "4")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public int FrameSize
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x9CC214", Offset = "0x9CC214", VA = "0x9CC214", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001CF")]
		public int SampleRate
		{
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x9CC21C", Offset = "0x9CC21C", VA = "0x9CC21C", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x9CC224", Offset = "0x9CC224", VA = "0x9CC224")]
		public IdentityEncoder(int sampleRate, int frameSize)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x9CC250", Offset = "0x9CC250", VA = "0x9CC250", Slot = "7")]
		public ArraySegment<byte> Encode(ArraySegment<float> samples, ArraySegment<byte> array)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x9CC3FC", Offset = "0x9CC3FC", VA = "0x9CC3FC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x9CC400", Offset = "0x9CC400", VA = "0x9CC400", Slot = "9")]
		public void Dispose()
		{
		}
	}
}
namespace Dissonance.Audio.Capture
{
	[Token(Token = "0x200013F")]
	public enum AecmRoutingMode
	{
		[Token(Token = "0x4000467")]
		Disabled = -1,
		[Token(Token = "0x4000468")]
		QuietEarpieceOrHeadset,
		[Token(Token = "0x4000469")]
		Earpiece,
		[Token(Token = "0x400046A")]
		LoudEarpiece,
		[Token(Token = "0x400046B")]
		Speakerphone,
		[Token(Token = "0x400046C")]
		LoudSpeakerphone
	}
	[Token(Token = "0x2000140")]
	public enum AecSuppressionLevels
	{
		[Token(Token = "0x400046E")]
		Disabled = -1,
		[Token(Token = "0x400046F")]
		Low,
		[Token(Token = "0x4000470")]
		Moderate,
		[Token(Token = "0x4000471")]
		High
	}
	[Token(Token = "0x2000141")]
	internal abstract class BasePreprocessingPipeline : IPreprocessingPipeline, IDisposable, IMicrophoneSubscriber
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ArvCalculator _arv;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int _droppedSamples;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object _inputWriteLock;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly BufferedSampleProvider _resamplerInput;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Resampler _resampler;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly SampleToFrameProvider _resampledOutput;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly float[] _intermediateFrame;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioFileWriter _diagnosticOutputRecorder;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int _outputFrameSize;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly WaveFormat _outputFormat;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _resetApplied;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _resetRequested;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _runThread;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly DThread _thread;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly AutoResetEvent _threadEvent;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly ReadonlyLockedValue<List<IMicrophoneSubscriber>> _micSubscriptions;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _micSubscriptionCount;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly ReadonlyLockedValue<List<IVoiceActivationListener>> _vadSubscriptions;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _vadSubscriptionCount;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _upstreamLatencyMs;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly int _estimatedPreprocessorLatencyMs;

		[Token(Token = "0x170001D0")]
		public float Amplitude
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x9CC404", Offset = "0x9CC404", VA = "0x9CC404", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001D1")]
		public int OutputFrameSize
		{
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x9CC40C", Offset = "0x9CC40C", VA = "0x9CC40C", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D2")]
		[NotNull]
		public WaveFormat OutputFormat
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x9CC414", Offset = "0x9CC414", VA = "0x9CC414", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		protected abstract bool VadIsSpeechDetected
		{
			[Token(Token = "0x60008C5")]
			get;
		}

		[Token(Token = "0x170001D4")]
		public TimeSpan UpstreamLatency
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x9CC41C", Offset = "0x9CC41C", VA = "0x9CC41C")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x9CC478", Offset = "0x9CC478", VA = "0x9CC478", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001D5")]
		protected int PreprocessorLatencyMs
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x9CC4BC", Offset = "0x9CC4BC", VA = "0x9CC4BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x9CC4C8", Offset = "0x9CC4C8", VA = "0x9CC4C8")]
		protected BasePreprocessingPipeline([NotNull] WaveFormat inputFormat, int intermediateFrameSize, int intermediateSampleRate, int outputFrameSize, int outputSampleRate)
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x9CCCE8", Offset = "0x9CCCE8", VA = "0x9CCCE8", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x9CD154", Offset = "0x9CD154", VA = "0x9CD154", Slot = "15")]
		public void Reset()
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x9CD184", Offset = "0x9CD184", VA = "0x9CD184", Slot = "18")]
		protected virtual void ApplyReset()
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x9CD71C", Offset = "0x9CD71C", VA = "0x9CD71C", Slot = "14")]
		private void Dissonance.Audio.Capture.IMicrophoneSubscriber.ReceiveMicrophoneData(ArraySegment<float> data, [NotNull] WaveFormat format)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x9CDBA8", Offset = "0x9CDBA8", VA = "0x9CDBA8", Slot = "7")]
		public void Start()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x9CDC10", Offset = "0x9CDC10", VA = "0x9CDC10")]
		private void ThreadEntry()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x9CE854", Offset = "0x9CE854", VA = "0x9CE854", Slot = "19")]
		protected virtual void ThreadStart()
		{
		}

		[Token(Token = "0x60008D1")]
		protected abstract void PreprocessAudioFrame([NotNull] float[] frame);

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x9CE858", Offset = "0x9CE858", VA = "0x9CE858")]
		protected void SendSamplesToSubscribers([NotNull] float[] buffer)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x9CD308", Offset = "0x9CD308", VA = "0x9CD308")]
		private void SendResetToSubscribers()
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x9CEE30", Offset = "0x9CEE30", VA = "0x9CEE30", Slot = "21")]
		public virtual void Subscribe([NotNull] IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x9CF0BC", Offset = "0x9CF0BC", VA = "0x9CF0BC", Slot = "22")]
		public virtual bool Unsubscribe([NotNull] IMicrophoneSubscriber listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x9CE3BC", Offset = "0x9CE3BC", VA = "0x9CE3BC")]
		private void SendStoppedTalking()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x9CF31C", Offset = "0x9CF31C", VA = "0x9CF31C")]
		private static void SendStoppedTalking([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x9CE608", Offset = "0x9CE608", VA = "0x9CE608")]
		private void SendStartedTalking()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x9CF4D0", Offset = "0x9CF4D0", VA = "0x9CF4D0")]
		private static void SendStartedTalking([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x9CF680", Offset = "0x9CF680", VA = "0x9CF680", Slot = "23")]
		public virtual void Subscribe([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x9CF958", Offset = "0x9CF958", VA = "0x9CF958", Slot = "24")]
		public virtual bool Unsubscribe([NotNull] IVoiceActivationListener listener)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000142")]
	public class BasicMicrophoneCapture : MonoBehaviour, IMicrophoneCapture
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private byte _maxReadBufferPower;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly POTBuffer _readBuffer;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BufferedSampleProvider _rawMicSamples;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IFrameProvider _rawMicFrames;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _frame;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaveFormat _format;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioClip _clip;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _readHead;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool _started;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _micName;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _audioDeviceChanged;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioFileWriter _microphoneDiagnosticOutput;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly List<IMicrophoneSubscriber> _subscribers;

		[Token(Token = "0x170001D6")]
		public TimeSpan Latency
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x9CFCE4", Offset = "0x9CFCE4", VA = "0x9CFCE4", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x9CFCEC", Offset = "0x9CFCEC", VA = "0x9CFCEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public bool IsRecording
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x9CFCF4", Offset = "0x9CFCF4", VA = "0x9CFCF4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x9CFD54", Offset = "0x9CFD54", VA = "0x9CFD54", Slot = "11")]
		public virtual WaveFormat StartCapture(string inputMicName)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x9D058C", Offset = "0x9D058C", VA = "0x9D058C")]
		[CanBeNull]
		private static string ChooseMicName([CanBeNull] string micName)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x9D0678", Offset = "0x9D0678", VA = "0x9D0678", Slot = "12")]
		public virtual void StopCapture()
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x9D085C", Offset = "0x9D085C", VA = "0x9D085C")]
		private void OnAudioDeviceChanged(bool deviceWasChanged)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x9D0870", Offset = "0x9D0870", VA = "0x9D0870", Slot = "10")]
		public bool UpdateSubscribers()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x9D0A78", Offset = "0x9D0A78", VA = "0x9D0A78")]
		private void DrainMicSamples()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x9D0D68", Offset = "0x9D0D68", VA = "0x9D0D68")]
		private void ConsumeSamples(ArraySegment<float> samples)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x9D0E88", Offset = "0x9D0E88", VA = "0x9D0E88")]
		private void SendFrame()
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x9D1264", Offset = "0x9D1264", VA = "0x9D1264", Slot = "8")]
		public void Subscribe(IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x9D135C", Offset = "0x9D135C", VA = "0x9D135C", Slot = "9")]
		public bool Unsubscribe(IMicrophoneSubscriber listener)
		{
			return default(bool);
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x9D1404", Offset = "0x9D1404", VA = "0x9D1404")]
		public BasicMicrophoneCapture()
		{
		}
	}
	[Token(Token = "0x2000143")]
	internal class BufferedSampleProvider : ISampleProvider
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WaveFormat _format;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly TransferBuffer<float> _samples;

		[Token(Token = "0x170001D8")]
		public int Count
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x9CE114", Offset = "0x9CE114", VA = "0x9CE114")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001D9")]
		public int Capacity
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x9CDB58", Offset = "0x9CDB58", VA = "0x9CDB58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DA")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x9D1594", Offset = "0x9D1594", VA = "0x9D1594", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x9CC96C", Offset = "0x9CC96C", VA = "0x9CC96C")]
		public BufferedSampleProvider(WaveFormat format, int bufferSize)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x9D159C", Offset = "0x9D159C", VA = "0x9D159C", Slot = "5")]
		public int Read(float[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x9CDA94", Offset = "0x9CDA94", VA = "0x9CDA94")]
		public int Write(ArraySegment<float> data)
		{
			return default(int);
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x9CD298", Offset = "0x9CD298", VA = "0x9CD298")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000144")]
	internal class CapturePipelineManager : IAmplitudeProvider, ILossEstimator
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _isMobilePlatform;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly CodecSettingsLoader _codecSettingsLoader;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly RoomChannels _roomChannels;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly PlayerChannels _playerChannels;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly PacketLossMonitor _receivingPacketLossMonitor;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[CanBeNull]
		private ICommsNetwork _network;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IMicrophoneCapture _microphone;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IPreprocessingPipeline _preprocessor;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private EncoderPipeline _encoder;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _encounteredFatalException;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool _netModeRequiresPipeline;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool _cannotStartMic;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool _encoderSubscribed;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _startupDelay;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FrameSkipDetector _skipDetector;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<IVoiceActivationListener> _activationListeners;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly List<IMicrophoneSubscriber> _audioListeners;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string _micName;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _pendingResetRequest;

		[Token(Token = "0x170001DB")]
		[CanBeNull]
		public IMicrophoneCapture Microphone
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x9D1654", Offset = "0x9D1654", VA = "0x9D1654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DC")]
		public string MicrophoneName
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x9D165C", Offset = "0x9D165C", VA = "0x9D165C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x9D1664", Offset = "0x9D1664", VA = "0x9D1664")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public float PacketLoss
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x9D2100", Offset = "0x9D2100", VA = "0x9D2100", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001DE")]
		public float Amplitude
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x9D211C", Offset = "0x9D211C", VA = "0x9D211C", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x9D21CC", Offset = "0x9D21CC", VA = "0x9D21CC")]
		public CapturePipelineManager([NotNull] CodecSettingsLoader codecSettingsLoader, [NotNull] RoomChannels roomChannels, [NotNull] PlayerChannels playerChannels, [NotNull] ReadOnlyCollection<VoicePlayerState> players, int startupDelay = 0)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x9D247C", Offset = "0x9D247C", VA = "0x9D247C")]
		public void Start([NotNull] ICommsNetwork network, [NotNull] IMicrophoneCapture microphone)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x9D2778", Offset = "0x9D2778", VA = "0x9D2778")]
		private void OnAudioDeviceChanged(bool devicewaschanged)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x9D2770", Offset = "0x9D2770", VA = "0x9D2770")]
		private static bool IsMobilePlatform()
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x9D2818", Offset = "0x9D2818", VA = "0x9D2818")]
		public void Destroy()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x9D274C", Offset = "0x9D274C", VA = "0x9D274C")]
		private void Net_ModeChanged(NetworkMode mode)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x9D2C00", Offset = "0x9D2C00", VA = "0x9D2C00")]
		public void Update(bool muted, float deltaTime)
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x9D296C", Offset = "0x9D296C", VA = "0x9D296C")]
		private void StopTransmissionPipeline()
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x9D17D4", Offset = "0x9D17D4", VA = "0x9D17D4")]
		private void RestartTransmissionPipeline(string reason)
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x9D3BA0", Offset = "0x9D3BA0", VA = "0x9D3BA0", Slot = "6")]
		[NotNull]
		protected virtual IPreprocessingPipeline CreatePreprocessor([NotNull] WaveFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x9D3C98", Offset = "0x9D3C98", VA = "0x9D3C98")]
		public void Subscribe([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x9D3E24", Offset = "0x9D3E24", VA = "0x9D3E24")]
		public void Unsubscribe([NotNull] IVoiceActivationListener listener)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x9D3F68", Offset = "0x9D3F68", VA = "0x9D3F68")]
		public void Subscribe([NotNull] IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x9D40F4", Offset = "0x9D40F4", VA = "0x9D40F4")]
		public void Unsubscribe([NotNull] IMicrophoneSubscriber listener)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x9D2784", Offset = "0x9D2784", VA = "0x9D2784")]
		public void ForceReset()
		{
		}
	}
	[Token(Token = "0x2000145")]
	internal class EmptyPreprocessingPipeline : BasePreprocessingPipeline
	{
		[Token(Token = "0x170001DF")]
		protected override bool VadIsSpeechDetected
		{
			[Token(Token = "0x6000909")]
			[Address(RVA = "0x9D438C", Offset = "0x9D438C", VA = "0x9D438C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x9D4318", Offset = "0x9D4318", VA = "0x9D4318")]
		public EmptyPreprocessingPipeline([NotNull] WaveFormat inputFormat)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x9D4394", Offset = "0x9D4394", VA = "0x9D4394", Slot = "20")]
		protected override void PreprocessAudioFrame(float[] frame)
		{
		}
	}
	[Token(Token = "0x2000146")]
	internal class EncoderPipeline : IMicrophoneSubscriber, IDisposable
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly byte[] _encodedBytes;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float[] _plainSamples;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ReadonlyLockedValue<IVoiceEncoder> _encoder;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly ICommsNetwork _net;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly BufferedSampleProvider _input;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Resampler _resampler;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly IFrameProvider _output;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly WaveFormat _inputFormat;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _stopped;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool _stopping;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool _disposed;

		[Token(Token = "0x170001E0")]
		public bool Stopped
		{
			[Token(Token = "0x600090B")]
			[Address(RVA = "0x9D3124", Offset = "0x9D3124", VA = "0x9D3124")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E1")]
		public bool Stopping
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x9D3390", Offset = "0x9D3390", VA = "0x9D3390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001E2")]
		public float TransmissionPacketLoss
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x9D4398", Offset = "0x9D4398", VA = "0x9D4398")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x9D43A0", Offset = "0x9D43A0", VA = "0x9D43A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x9D3770", Offset = "0x9D3770", VA = "0x9D3770")]
		public EncoderPipeline([NotNull] WaveFormat inputFormat, [NotNull] IVoiceEncoder encoder, [NotNull] ICommsNetwork net)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x9D43A8", Offset = "0x9D43A8", VA = "0x9D43A8", Slot = "4")]
		public void ReceiveMicrophoneData(ArraySegment<float> inputSamples, [NotNull] WaveFormat format)
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x9D4824", Offset = "0x9D4824", VA = "0x9D4824")]
		private int EncodeFrames([NotNull] IVoiceEncoder encoder, int maxCount)
		{
			return default(int);
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x9D313C", Offset = "0x9D313C", VA = "0x9D313C", Slot = "5")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x9D33A8", Offset = "0x9D33A8", VA = "0x9D33A8")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x9D3538", Offset = "0x9D3538", VA = "0x9D3538", Slot = "6")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000147")]
	internal interface IAmplitudeProvider
	{
		[Token(Token = "0x170001E3")]
		float Amplitude
		{
			[Token(Token = "0x6000916")]
			get;
		}
	}
	[Token(Token = "0x2000148")]
	internal interface IChannelPriorityProvider
	{
		[Token(Token = "0x170001E4")]
		ChannelPriority DefaultChannelPriority
		{
			[Token(Token = "0x6000917")]
			get;
			[Token(Token = "0x6000918")]
			set;
		}
	}
	[Token(Token = "0x2000149")]
	internal interface IFrameProvider
	{
		[Token(Token = "0x170001E5")]
		[NotNull]
		WaveFormat WaveFormat
		{
			[Token(Token = "0x6000919")]
			get;
		}

		[Token(Token = "0x170001E6")]
		uint FrameSize
		{
			[Token(Token = "0x600091A")]
			get;
		}

		[Token(Token = "0x600091B")]
		bool Read(ArraySegment<float> outBuffer);

		[Token(Token = "0x600091C")]
		void Reset();
	}
	[Token(Token = "0x200014A")]
	public interface IMicrophoneCapture
	{
		[Token(Token = "0x170001E7")]
		bool IsRecording
		{
			[Token(Token = "0x600091D")]
			get;
		}

		[Token(Token = "0x170001E8")]
		TimeSpan Latency
		{
			[Token(Token = "0x600091E")]
			get;
		}

		[Token(Token = "0x600091F")]
		[CanBeNull]
		WaveFormat StartCapture([CanBeNull] string name);

		[Token(Token = "0x6000920")]
		void StopCapture();

		[Token(Token = "0x6000921")]
		void Subscribe([NotNull] IMicrophoneSubscriber listener);

		[Token(Token = "0x6000922")]
		bool Unsubscribe([NotNull] IMicrophoneSubscriber listener);

		[Token(Token = "0x6000923")]
		bool UpdateSubscribers();
	}
	[Token(Token = "0x200014B")]
	public interface IMicrophoneSubscriber
	{
		[Token(Token = "0x6000924")]
		void ReceiveMicrophoneData(ArraySegment<float> buffer, WaveFormat format);

		[Token(Token = "0x6000925")]
		void Reset();
	}
	[Token(Token = "0x200014C")]
	internal interface IPreprocessingPipeline : IDisposable, IMicrophoneSubscriber
	{
		[Token(Token = "0x170001E9")]
		WaveFormat OutputFormat
		{
			[Token(Token = "0x6000926")]
			get;
		}

		[Token(Token = "0x170001EA")]
		float Amplitude
		{
			[Token(Token = "0x6000927")]
			get;
		}

		[Token(Token = "0x170001EB")]
		TimeSpan UpstreamLatency
		{
			[Token(Token = "0x6000928")]
			set;
		}

		[Token(Token = "0x170001EC")]
		int OutputFrameSize
		{
			[Token(Token = "0x600092A")]
			get;
		}

		[Token(Token = "0x6000929")]
		void Start();

		[Token(Token = "0x600092B")]
		void Subscribe(IMicrophoneSubscriber listener);

		[Token(Token = "0x600092C")]
		bool Unsubscribe(IMicrophoneSubscriber listener);

		[Token(Token = "0x600092D")]
		void Subscribe(IVoiceActivationListener listener);

		[Token(Token = "0x600092E")]
		bool Unsubscribe(IVoiceActivationListener listener);
	}
	[Token(Token = "0x200014D")]
	public enum NoiseSuppressionLevels
	{
		[Token(Token = "0x40004BB")]
		Disabled = -1,
		[Token(Token = "0x40004BC")]
		Low,
		[Token(Token = "0x40004BD")]
		Moderate,
		[Token(Token = "0x40004BE")]
		High,
		[Token(Token = "0x40004BF")]
		VeryHigh
	}
	[Token(Token = "0x200014E")]
	internal class Resampler : ISampleProvider
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WaveFormat _format;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[CanBeNull]
		private readonly WdlResampler _resampler;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ISampleProvider _source;

		[Token(Token = "0x170001ED")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x9D4BDC", Offset = "0x9D4BDC", VA = "0x9D4BDC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x9CCA04", Offset = "0x9CCA04", VA = "0x9CCA04")]
		public Resampler([NotNull] ISampleProvider source, int newSampleRate)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x9D4BE4", Offset = "0x9D4BE4", VA = "0x9D4BE4", Slot = "5")]
		public int Read(float[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x9CD2E8", Offset = "0x9CD2E8", VA = "0x9CD2E8")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x200014F")]
	internal class SampleToFrameProvider : IFrameProvider
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ISampleProvider _source;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly uint _frameSize;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _samplesInFrame;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly float[] _frame;

		[Token(Token = "0x170001EE")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x9D4E1C", Offset = "0x9D4E1C", VA = "0x9D4E1C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		public uint FrameSize
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x9D4EBC", Offset = "0x9D4EBC", VA = "0x9D4EBC", Slot = "5")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x9CCC74", Offset = "0x9CCC74", VA = "0x9CCC74")]
		public SampleToFrameProvider(ISampleProvider source, uint frameSize)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x9CE164", Offset = "0x9CE164", VA = "0x9CE164", Slot = "6")]
		public bool Read(ArraySegment<float> outBuffer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x9CD300", Offset = "0x9CD300", VA = "0x9CD300", Slot = "7")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000150")]
	internal class SineSampleProvider : ISampleProvider
	{
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly WaveFormat _format;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float _frequency;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly double _step;

		[Token(Token = "0x40004CA")]
		private const double TwoPi = Math.PI * 2.0;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double _index;

		[Token(Token = "0x170001F0")]
		public float Frequency
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x9D4EC4", Offset = "0x9D4EC4", VA = "0x9D4EC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F1")]
		public WaveFormat WaveFormat
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x9D4ECC", Offset = "0x9D4ECC", VA = "0x9D4ECC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x9D4ED4", Offset = "0x9D4ED4", VA = "0x9D4ED4")]
		public SineSampleProvider(WaveFormat format, float frequency)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x9D4F34", Offset = "0x9D4F34", VA = "0x9D4F34", Slot = "5")]
		public int Read(float[] buffer, int offset, int count)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000151")]
	public enum VadSensitivityLevels
	{
		[Token(Token = "0x40004CD")]
		LowSensitivity,
		[Token(Token = "0x40004CE")]
		MediumSensitivity,
		[Token(Token = "0x40004CF")]
		HighSensitivity,
		[Token(Token = "0x40004D0")]
		VeryHighSensitivity
	}
	[Token(Token = "0x2000152")]
	internal class WebRtcPreprocessingPipeline : BasePreprocessingPipeline
	{
		[Token(Token = "0x2000153")]
		internal sealed class WebRtcPreprocessor : IDisposable
		{
			[Token(Token = "0x2000154")]
			public enum SampleRates
			{
				[Token(Token = "0x40004DD")]
				SampleRate8KHz = 8000,
				[Token(Token = "0x40004DE")]
				SampleRate16KHz = 16000,
				[Token(Token = "0x40004DF")]
				SampleRate32KHz = 32000,
				[Token(Token = "0x40004E0")]
				SampleRate48KHz = 48000
			}

			[Token(Token = "0x2000155")]
			private enum ProcessorErrors
			{
				[Token(Token = "0x40004E2")]
				Ok = 0,
				[Token(Token = "0x40004E3")]
				Unspecified = -1,
				[Token(Token = "0x40004E4")]
				CreationFailed = -2,
				[Token(Token = "0x40004E5")]
				UnsupportedComponent = -3,
				[Token(Token = "0x40004E6")]
				UnsupportedFunction = -4,
				[Token(Token = "0x40004E7")]
				NullPointer = -5,
				[Token(Token = "0x40004E8")]
				BadParameter = -6,
				[Token(Token = "0x40004E9")]
				BadSampleRate = -7,
				[Token(Token = "0x40004EA")]
				BadDataLength = -8,
				[Token(Token = "0x40004EB")]
				BadNumberChannels = -9,
				[Token(Token = "0x40004EC")]
				FileError = -10,
				[Token(Token = "0x40004ED")]
				StreamParameterNotSet = -11,
				[Token(Token = "0x40004EE")]
				NotEnabled = -12
			}

			[Token(Token = "0x2000156")]
			internal enum FilterState
			{
				[Token(Token = "0x40004F0")]
				FilterNotRunning,
				[Token(Token = "0x40004F1")]
				FilterNoInstance,
				[Token(Token = "0x40004F2")]
				FilterNoSamplesSubmitted,
				[Token(Token = "0x40004F3")]
				FilterOk
			}

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly LockedValue<IntPtr> _handle;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly List<PropertyChangedEventHandler> _subscribed;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly bool _useMobileAec;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private NoiseSuppressionLevels _nsLevel;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private VadSensitivityLevels _vadlevel;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private AecSuppressionLevels _aecLevel;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AecmRoutingMode _aecmLevel;

			[Token(Token = "0x170001F3")]
			private NoiseSuppressionLevels NoiseSuppressionLevel
			{
				[Token(Token = "0x600094E")]
				[Address(RVA = "0x9D6004", Offset = "0x9D6004", VA = "0x9D6004")]
				get
				{
					return default(NoiseSuppressionLevels);
				}
				[Token(Token = "0x600094F")]
				[Address(RVA = "0x9D600C", Offset = "0x9D600C", VA = "0x9D600C")]
				set
				{
				}
			}

			[Token(Token = "0x170001F4")]
			private VadSensitivityLevels VadSensitivityLevel
			{
				[Token(Token = "0x6000950")]
				[Address(RVA = "0x9D6200", Offset = "0x9D6200", VA = "0x9D6200")]
				get
				{
					return default(VadSensitivityLevels);
				}
				[Token(Token = "0x6000951")]
				[Address(RVA = "0x9D6208", Offset = "0x9D6208", VA = "0x9D6208")]
				set
				{
				}
			}

			[Token(Token = "0x170001F5")]
			private AecSuppressionLevels AecSuppressionLevel
			{
				[Token(Token = "0x6000952")]
				[Address(RVA = "0x9D63FC", Offset = "0x9D63FC", VA = "0x9D63FC")]
				get
				{
					return default(AecSuppressionLevels);
				}
				[Token(Token = "0x6000953")]
				[Address(RVA = "0x9D6404", Offset = "0x9D6404", VA = "0x9D6404")]
				set
				{
				}
			}

			[Token(Token = "0x170001F6")]
			private AecmRoutingMode AecmSuppressionLevel
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0x9D660C", Offset = "0x9D660C", VA = "0x9D660C")]
				get
				{
					return default(AecmRoutingMode);
				}
				[Token(Token = "0x6000955")]
				[Address(RVA = "0x9D6614", Offset = "0x9D6614", VA = "0x9D6614")]
				set
				{
				}
			}

			[PreserveSig]
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x9D5AD8", Offset = "0x9D5AD8", VA = "0x9D5AD8")]
			private static extern IntPtr Dissonance_CreatePreprocessor(NoiseSuppressionLevels nsLevel, AecSuppressionLevels aecLevel, bool aecDelayAgnostic, bool aecExtended, bool aecRefined, AecmRoutingMode aecmRoutingMode, bool aecmComfortNoise);

			[PreserveSig]
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x9D5B9C", Offset = "0x9D5B9C", VA = "0x9D5B9C")]
			private static extern void Dissonance_DestroyPreprocessor(IntPtr handle);

			[PreserveSig]
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x9D5C18", Offset = "0x9D5C18", VA = "0x9D5C18")]
			private static extern void Dissonance_ConfigureNoiseSuppression(IntPtr handle, NoiseSuppressionLevels nsLevel);

			[PreserveSig]
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x9D5C9C", Offset = "0x9D5C9C", VA = "0x9D5C9C")]
			private static extern void Dissonance_ConfigureVadSensitivity(IntPtr handle, VadSensitivityLevels nsLevel);

			[PreserveSig]
			[Token(Token = "0x6000948")]
			[Address(RVA = "0x9D5D20", Offset = "0x9D5D20", VA = "0x9D5D20")]
			private static extern void Dissonance_ConfigureAecSuppression(IntPtr handle, AecSuppressionLevels aecLevel, AecmRoutingMode aecmRouting);

			[PreserveSig]
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x9D5DB4", Offset = "0x9D5DB4", VA = "0x9D5DB4")]
			private static extern bool Dissonance_GetVadSpeechState(IntPtr handle);

			[PreserveSig]
			[Token(Token = "0x600094A")]
			[Address(RVA = "0x9D5E38", Offset = "0x9D5E38", VA = "0x9D5E38")]
			private static extern ProcessorErrors Dissonance_PreprocessCaptureFrame(IntPtr handle, int sampleRate, float[] input, float[] output, int streamDelay);

			[PreserveSig]
			[Token(Token = "0x600094B")]
			[Address(RVA = "0x9D5EF4", Offset = "0x9D5EF4", VA = "0x9D5EF4")]
			private static extern bool Dissonance_PreprocessorExchangeInstance(IntPtr previous, IntPtr replacement);

			[PreserveSig]
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x9D5990", Offset = "0x9D5990", VA = "0x9D5990")]
			internal static extern int Dissonance_GetFilterState();

			[PreserveSig]
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x9D5F80", Offset = "0x9D5F80", VA = "0x9D5F80")]
			private static extern void Dissonance_GetAecMetrics(IntPtr floatBuffer, int bufferLength);

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x9D50A0", Offset = "0x9D50A0", VA = "0x9D50A0")]
			public WebRtcPreprocessor(bool useMobileAec)
			{
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x9D5604", Offset = "0x9D5604", VA = "0x9D5604")]
			public bool Process(SampleRates inputSampleRate, float[] input, float[] output, int estimatedStreamDelay)
			{
				return default(bool);
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x9D5294", Offset = "0x9D5294", VA = "0x9D5294")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x9D6CB8", Offset = "0x9D6CB8", VA = "0x9D6CB8")]
			private IntPtr CreatePreprocessor()
			{
				return default(IntPtr);
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x9D6D98", Offset = "0x9D6D98", VA = "0x9D6D98")]
			private void SetFilterPreprocessor(IntPtr preprocessor)
			{
			}

			[Token(Token = "0x600095B")]
			private void Bind<T>(Func<VoiceSettings, T> getValue, string propertyName, Action<T> setValue)
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x9D681C", Offset = "0x9D681C", VA = "0x9D681C")]
			private bool ClearFilterPreprocessor(bool throwOnError = true)
			{
				return default(bool);
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x9D7594", Offset = "0x9D7594", VA = "0x9D7594")]
			private void ReleaseUnmanagedResources()
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x9D5214", Offset = "0x9D5214", VA = "0x9D5214", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x9D77B8", Offset = "0x9D77B8", VA = "0x9D77B8", Slot = "1")]
			~WebRtcPreprocessor()
			{
			}
		}

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Log Log;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _isVadDetectingSpeech;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		private readonly bool _isMobilePlatform;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private WebRtcPreprocessor _preprocessor;

		[Token(Token = "0x170001F2")]
		protected override bool VadIsSpeechDetected
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x9D5030", Offset = "0x9D5030", VA = "0x9D5030", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x9D3C18", Offset = "0x9D3C18", VA = "0x9D3C18")]
		public WebRtcPreprocessingPipeline([NotNull] WaveFormat inputFormat, bool mobilePlatform)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x9D5038", Offset = "0x9D5038", VA = "0x9D5038", Slot = "19")]
		protected override void ThreadStart()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x9D51F0", Offset = "0x9D51F0", VA = "0x9D51F0", Slot = "17")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x9D5274", Offset = "0x9D5274", VA = "0x9D5274", Slot = "18")]
		protected override void ApplyReset()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x9D54E4", Offset = "0x9D54E4", VA = "0x9D54E4", Slot = "20")]
		protected override void PreprocessAudioFrame(float[] frame)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x9D598C", Offset = "0x9D598C", VA = "0x9D598C")]
		internal static WebRtcPreprocessor.FilterState GetAecFilterState()
		{
			return default(WebRtcPreprocessor.FilterState);
		}
	}
}
