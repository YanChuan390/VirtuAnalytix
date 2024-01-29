using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
internal class SparkInterop
{
	[PreserveSig]
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1754C54", Offset = "0x1754C54", VA = "0x1754C54")]
	public static extern void InitInternal();

	[PreserveSig]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1754CE4", Offset = "0x1754CE4", VA = "0x1754CE4")]
	public static extern void ShutdownInternal();

	[PreserveSig]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1754D74", Offset = "0x1754D74", VA = "0x1754D74")]
	public static extern bool IsInterfaceVersionValid([In] string targetInterfaceVersion);

	[PreserveSig]
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1754E2C", Offset = "0x1754E2C", VA = "0x1754E2C")]
	public static extern IntPtr GetInterfaceBindings([In] string targetInterfaceVersion);

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1754EE0", Offset = "0x1754EE0", VA = "0x1754EE0")]
	public SparkInterop()
	{
	}
}
[Token(Token = "0x2000003")]
public class SparkSDK
{
	[Token(Token = "0x200008C")]
	private class SparkSDKContext
	{
		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private RightsManager _rightsManager;

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1754FCC", Offset = "0x1754FCC", VA = "0x1754FCC")]
		public SparkSDKContext()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1755110", Offset = "0x1755110", VA = "0x1755110")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1755064", Offset = "0x1755064", VA = "0x1755064")]
		public RightsManager GetRightsManager()
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	public const string RIGHTS_MANAGER_VERSION = "IRightsManager_001";

	[Token(Token = "0x4000002")]
	private const string FN_TABLE_PREFIX = "FnTables:";

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SparkSDKContext _internalContext;

	[Token(Token = "0x17000001")]
	private static SparkSDKContext _context
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1754EF8", Offset = "0x1754EF8", VA = "0x1754EF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static RightsManager Rights
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1754FF4", Offset = "0x1754FF4", VA = "0x1754FF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1754EE8", Offset = "0x1754EE8", VA = "0x1754EE8")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1754EEC", Offset = "0x1754EEC", VA = "0x1754EEC")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1754EF0", Offset = "0x1754EF0", VA = "0x1754EF0")]
	public static bool IsInterfaceVersionValid(string targetInterfaceVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1754EF4", Offset = "0x1754EF4", VA = "0x1754EF4")]
	public static IntPtr GetInterfaceBindings(string targetInterfaceVersion)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1755104", Offset = "0x1755104", VA = "0x1755104")]
	public SparkSDK()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D8370", Offset = "0x9D8370")]
internal delegate void IntPtrCallback(IntPtr arg);
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D8384", Offset = "0x9D8384")]
internal delegate void StringCallback([In] string arg);
[Token(Token = "0x2000006")]
internal struct IRightsManager
{
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D9AEC", Offset = "0x9D9AEC")]
	public delegate void _CheckRights(string contentKey, IntPtrCallback handler);

	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D9B00", Offset = "0x9D9B00")]
	public delegate void _StartTrackingUsage(string contentKey);

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D9B14", Offset = "0x9D9B14")]
	public delegate void _StopTrackingUsage(string contentKey);

	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D9B28", Offset = "0x9D9B28")]
	public delegate void _GetTOS(string contentKey, StringCallback handler);

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x9D9B3C", Offset = "0x9D9B3C")]
	public delegate void _AcceptTOS(string contentKey);

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public _CheckRights CheckRights;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public _StartTrackingUsage StartTrackingUsage;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public _StopTrackingUsage StopTrackingUsage;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public _GetTOS GetTOS;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public _AcceptTOS AcceptTOS;
}
[Token(Token = "0x2000007")]
public struct RightsResponse
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isUserEntitled;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public bool hasUserAcceptedTOS;
}
[Token(Token = "0x2000008")]
public class RightsManager
{
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9B50", Offset = "0x9D9B50")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<RightsResponse> callback;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtrCallback response;

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x174E450", Offset = "0x174E450", VA = "0x174E450")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x174E6F4", Offset = "0x174E6F4", VA = "0x174E6F4")]
		internal void <CheckRights>b__0(IntPtr arg)
		{
		}
	}

	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9B60", Offset = "0x9D9B60")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<string> callback;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringCallback response;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x174E634", Offset = "0x174E634", VA = "0x174E634")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x174E8C0", Offset = "0x174E8C0", VA = "0x174E8C0")]
		internal void <GetTOS>b__0(string arg)
		{
		}
	}

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private IRightsManager FnTable;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<Delegate> _pendingDelegates;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x174E184", Offset = "0x174E184", VA = "0x174E184")]
	internal RightsManager(IntPtr interfacePtr)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x174E2DC", Offset = "0x174E2DC", VA = "0x174E2DC")]
	public void CheckRights(string contentKey, Action<RightsResponse> callback)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x174E458", Offset = "0x174E458", VA = "0x174E458")]
	public void StartTrackingUsage(string contentKey)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x174E48C", Offset = "0x174E48C", VA = "0x174E48C")]
	public void StopTrackingUsage(string contentKey)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x174E4C0", Offset = "0x174E4C0", VA = "0x174E4C0")]
	public void GetTOS(string contentKey, Action<string> callback)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x174E64C", Offset = "0x174E64C", VA = "0x174E64C")]
	public void AcceptTOS(string contentKey)
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000009")]
	public enum AAMode
	{
		[Token(Token = "0x400000E")]
		FXAA2,
		[Token(Token = "0x400000F")]
		FXAA3Console,
		[Token(Token = "0x4000010")]
		FXAA1PresetA,
		[Token(Token = "0x4000011")]
		FXAA1PresetB,
		[Token(Token = "0x4000012")]
		NFAA,
		[Token(Token = "0x4000013")]
		SSAA,
		[Token(Token = "0x4000014")]
		DLAA
	}
	[Token(Token = "0x200000A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8398", Offset = "0x9D8398")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8398", Offset = "0x9D8398")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1763F28", Offset = "0x1763F28", VA = "0x1763F28")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1763F8C", Offset = "0x1763F8C", VA = "0x1763F8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x176407C", Offset = "0x176407C", VA = "0x176407C")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x176467C", Offset = "0x176467C", VA = "0x176467C")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8430", Offset = "0x9D8430")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8430", Offset = "0x9D8430")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000094")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400036F")]
			Ghosting,
			[Token(Token = "0x4000370")]
			Anamorphic,
			[Token(Token = "0x4000371")]
			Combined
		}

		[Token(Token = "0x2000095")]
		public enum TweakMode
		{
			[Token(Token = "0x4000373")]
			Basic,
			[Token(Token = "0x4000374")]
			Complex
		}

		[Token(Token = "0x2000096")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000376")]
			Auto,
			[Token(Token = "0x4000377")]
			On,
			[Token(Token = "0x4000378")]
			Off
		}

		[Token(Token = "0x2000097")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400037A")]
			Screen,
			[Token(Token = "0x400037B")]
			Add
		}

		[Token(Token = "0x2000098")]
		public enum BloomQuality
		{
			[Token(Token = "0x400037D")]
			Cheap,
			[Token(Token = "0x400037E")]
			High
		}

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x17646A0", Offset = "0x17646A0", VA = "0x17646A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1764740", Offset = "0x1764740", VA = "0x1764740")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1765D70", Offset = "0x1765D70", VA = "0x1765D70")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1765AC4", Offset = "0x1765AC4", VA = "0x1765AC4")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17657B4", Offset = "0x17657B4", VA = "0x17657B4")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17656AC", Offset = "0x17656AC", VA = "0x17656AC")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17658A4", Offset = "0x17658A4", VA = "0x17658A4")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1765E48", Offset = "0x1765E48", VA = "0x1765E48")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x400004A")]
		Ghosting,
		[Token(Token = "0x400004B")]
		Anamorphic,
		[Token(Token = "0x400004C")]
		Combined
	}
	[Token(Token = "0x200000D")]
	public enum TweakMode34
	{
		[Token(Token = "0x400004E")]
		Basic,
		[Token(Token = "0x400004F")]
		Complex
	}
	[Token(Token = "0x200000E")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000051")]
		Auto,
		[Token(Token = "0x4000052")]
		On,
		[Token(Token = "0x4000053")]
		Off
	}
	[Token(Token = "0x200000F")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000055")]
		Screen,
		[Token(Token = "0x4000056")]
		Add
	}
	[Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D84C8", Offset = "0x9D84C8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D84C8", Offset = "0x9D84C8")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1BC5064", Offset = "0x1BC5064", VA = "0x1BC5064", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1BC573C", Offset = "0x1BC573C", VA = "0x1BC573C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1BC6934", Offset = "0x1BC6934", VA = "0x1BC6934")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1BC66A0", Offset = "0x1BC66A0", VA = "0x1BC66A0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1BC63F0", Offset = "0x1BC63F0", VA = "0x1BC63F0")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1BC6528", Offset = "0x1BC6528", VA = "0x1BC6528")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1BC69F0", Offset = "0x1BC69F0", VA = "0x1BC69F0")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000011")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8560", Offset = "0x9D8560")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8560", Offset = "0x9D8560")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000099")]
		public enum Resolution
		{
			[Token(Token = "0x4000380")]
			Low,
			[Token(Token = "0x4000381")]
			High
		}

		[Token(Token = "0x200009A")]
		public enum BlurType
		{
			[Token(Token = "0x4000383")]
			Standard,
			[Token(Token = "0x4000384")]
			Sgx
		}

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9C80", Offset = "0x9D9C80")]
		public float threshold;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9C98", Offset = "0x9D9C98")]
		public float intensity;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9CB0", Offset = "0x9D9CB0")]
		public float blurSize;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9CC8", Offset = "0x9D9CC8")]
		public int blurIterations;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1BC6BD4", Offset = "0x1BC6BD4", VA = "0x1BC6BD4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1BC6C2C", Offset = "0x1BC6C2C", VA = "0x1BC6C2C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1BC6CDC", Offset = "0x1BC6CDC", VA = "0x1BC6CDC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1BC7148", Offset = "0x1BC7148", VA = "0x1BC7148")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D85F8", Offset = "0x9D85F8")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9CE0", Offset = "0x9D9CE0")]
		public int iterations;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9CF8", Offset = "0x9D9CF8")]
		public float blurSpread;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000003")]
		protected Material material
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1BC7168", Offset = "0x1BC7168", VA = "0x1BC7168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1BC72A8", Offset = "0x1BC72A8", VA = "0x1BC72A8")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1BC73A4", Offset = "0x1BC73A4", VA = "0x1BC73A4")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1BC7478", Offset = "0x1BC7478", VA = "0x1BC7478")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1BC7654", Offset = "0x1BC7654", VA = "0x1BC7654")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1BC780C", Offset = "0x1BC780C", VA = "0x1BC780C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1BC7988", Offset = "0x1BC7988", VA = "0x1BC7988")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8644", Offset = "0x9D8644")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8644", Offset = "0x9D8644")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x200009B")]
		public enum BlurType
		{
			[Token(Token = "0x4000386")]
			StandardGauss,
			[Token(Token = "0x4000387")]
			SgxGauss
		}

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D10", Offset = "0x9D9D10")]
		public int downsample;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D28", Offset = "0x9D9D28")]
		public float blurSize;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D40", Offset = "0x9D9D40")]
		public int blurIterations;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1BC79A4", Offset = "0x1BC79A4", VA = "0x1BC79A4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1BC79FC", Offset = "0x1BC79FC", VA = "0x1BC79FC")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1BC7AAC", Offset = "0x1BC7AAC", VA = "0x1BC7AAC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1BC7EDC", Offset = "0x1BC7EDC", VA = "0x1BC7EDC")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D86DC", Offset = "0x9D86DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D86DC", Offset = "0x9D86DC")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x200009C")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x4000389")]
			CameraMotion,
			[Token(Token = "0x400038A")]
			LocalBlur,
			[Token(Token = "0x400038B")]
			Reconstruction,
			[Token(Token = "0x400038C")]
			ReconstructionDX11,
			[Token(Token = "0x400038D")]
			ReconstructionDisc
		}

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x1BC7EF4", Offset = "0x1BC7EF4", VA = "0x1BC7EF4")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1BC8204", Offset = "0x1BC8204", VA = "0x1BC8204")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1BC8524", Offset = "0x1BC8524", VA = "0x1BC8524")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1BC8604", Offset = "0x1BC8604", VA = "0x1BC8604")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1BC8768", Offset = "0x1BC8768", VA = "0x1BC8768", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1BC884C", Offset = "0x1BC884C", VA = "0x1BC884C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1BC830C", Offset = "0x1BC830C", VA = "0x1BC830C")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1BCA658", Offset = "0x1BCA658", VA = "0x1BCA658")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1BCA564", Offset = "0x1BCA564", VA = "0x1BCA564")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1BCA648", Offset = "0x1BCA648", VA = "0x1BCA648")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1BCAAFC", Offset = "0x1BCAAFC", VA = "0x1BCAAFC")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8774", Offset = "0x9D8774")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x200009D")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x400038F")]
			Simple,
			[Token(Token = "0x4000390")]
			Advanced
		}

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1BCAC48", Offset = "0x1BCAC48", VA = "0x1BCAC48")]
		private new void Start()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1BCAC84", Offset = "0x1BCAC84", VA = "0x1BCAC84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1BCAC88", Offset = "0x1BCAC88", VA = "0x1BCAC88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1BCAF2C", Offset = "0x1BCAF2C", VA = "0x1BCAF2C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1BCB3D0", Offset = "0x1BCB3D0", VA = "0x1BCB3D0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1BCB3D4", Offset = "0x1BCB3D4", VA = "0x1BCB3D4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1BCB7C0", Offset = "0x1BCB7C0", VA = "0x1BCB7C0")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D87C0", Offset = "0x9D87C0")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1BCBEF8", Offset = "0x1BCBEF8", VA = "0x1BCBEF8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1BCBF4C", Offset = "0x1BCBF4C", VA = "0x1BCBF4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1BCBFF4", Offset = "0x1BCBFF4", VA = "0x1BCBFF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1BCC09C", Offset = "0x1BCC09C", VA = "0x1BCC09C")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1BCC2E4", Offset = "0x1BCC2E4", VA = "0x1BCC2E4")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1BCC3E8", Offset = "0x1BCC3E8", VA = "0x1BCC3E8")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1BCC7E8", Offset = "0x1BCC7E8", VA = "0x1BCC7E8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1BCCA14", Offset = "0x1BCCA14", VA = "0x1BCCA14")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D880C", Offset = "0x9D880C")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1BCCA68", Offset = "0x1BCCA68", VA = "0x1BCCA68")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1BCCBFC", Offset = "0x1BCCBFC", VA = "0x1BCCBFC")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8858", Offset = "0x9D8858")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8858", Offset = "0x9D8858")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D58", Offset = "0x9D9D58")]
		public float intensity;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D70", Offset = "0x9D9D70")]
		public float threshold;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9D8C", Offset = "0x9D9D8C")]
		public float blurSpread;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1BCCC0C", Offset = "0x1BCCC0C", VA = "0x1BCCC0C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1BCCC7C", Offset = "0x1BCCC7C", VA = "0x1BCCC7C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1BCD038", Offset = "0x1BCD038", VA = "0x1BCD038")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x2000019")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D88F0", Offset = "0x9D88F0")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9DA4", Offset = "0x9D9DA4")]
		public float adaptationSpeed;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9DC0", Offset = "0x9D9DC0")]
		public float limitMinimum;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9DD8", Offset = "0x9D9DD8")]
		public float limitMaximum;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000004")]
		protected Material materialLum
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1BCD04C", Offset = "0x1BCD04C", VA = "0x1BCD04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialReduce
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1BCD114", Offset = "0x1BCD114", VA = "0x1BCD114")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		protected Material materialAdapt
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x1BCD1DC", Offset = "0x1BCD1DC", VA = "0x1BCD1DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		protected Material materialApply
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x1BCD2A4", Offset = "0x1BCD2A4", VA = "0x1BCD2A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1BCD36C", Offset = "0x1BCD36C", VA = "0x1BCD36C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1BCD42C", Offset = "0x1BCD42C", VA = "0x1BCD42C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1BCD5CC", Offset = "0x1BCD5CC", VA = "0x1BCD5CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1BCD81C", Offset = "0x1BCD81C", VA = "0x1BCD81C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1BCDAB0", Offset = "0x1BCDAB0", VA = "0x1BCDAB0")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1BCDD1C", Offset = "0x1BCDD1C", VA = "0x1BCDD1C")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D893C", Offset = "0x9D893C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D893C", Offset = "0x9D893C")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1BCDD9C", Offset = "0x1BCDD9C", VA = "0x1BCDD9C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1BCDE14", Offset = "0x1BCDE14", VA = "0x1BCDE14")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1BCE204", Offset = "0x1BCE204", VA = "0x1BCE204")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D89D4", Offset = "0x9D89D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D89D4", Offset = "0x9D89D4")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200009E")]
		public enum BlurType
		{
			[Token(Token = "0x4000392")]
			DiscBlur,
			[Token(Token = "0x4000393")]
			DX11
		}

		[Token(Token = "0x200009F")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x4000395")]
			Low,
			[Token(Token = "0x4000396")]
			Medium,
			[Token(Token = "0x4000397")]
			High
		}

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1BCE21C", Offset = "0x1BCE21C", VA = "0x1BCE21C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1BCE414", Offset = "0x1BCE414", VA = "0x1BCE414")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1BCE4B0", Offset = "0x1BCE4B0", VA = "0x1BCE4B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1BCE5B8", Offset = "0x1BCE5B8", VA = "0x1BCE5B8")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1BCE2A0", Offset = "0x1BCE2A0", VA = "0x1BCE2A0")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1BCE5FC", Offset = "0x1BCE5FC", VA = "0x1BCE5FC")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1BCE7D0", Offset = "0x1BCE7D0", VA = "0x1BCE7D0")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1BCEB64", Offset = "0x1BCEB64", VA = "0x1BCEB64")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1BD05C0", Offset = "0x1BD05C0", VA = "0x1BD05C0")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8A6C", Offset = "0x9D8A6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8A6C", Offset = "0x9D8A6C")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000A0")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000399")]
			OnlyBackground = 1,
			[Token(Token = "0x400039A")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000A1")]
		public enum DofResolution
		{
			[Token(Token = "0x400039C")]
			High = 2,
			[Token(Token = "0x400039D")]
			Medium,
			[Token(Token = "0x400039E")]
			Low
		}

		[Token(Token = "0x20000A2")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40003A0")]
			Low = 1,
			[Token(Token = "0x40003A1")]
			High = 2,
			[Token(Token = "0x40003A2")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000A3")]
		public enum BokehDestination
		{
			[Token(Token = "0x40003A4")]
			Background = 1,
			[Token(Token = "0x40003A5")]
			Foreground,
			[Token(Token = "0x40003A6")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1BD0620", Offset = "0x1BD0620", VA = "0x1BD0620")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1BD06F8", Offset = "0x1BD06F8", VA = "0x1BD06F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1BD0800", Offset = "0x1BD0800", VA = "0x1BD0800")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1BD0A7C", Offset = "0x1BD0A7C", VA = "0x1BD0A7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1BD0B18", Offset = "0x1BD0B18", VA = "0x1BD0B18")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1BD0CEC", Offset = "0x1BD0CEC", VA = "0x1BD0CEC")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1BD0D10", Offset = "0x1BD0D10", VA = "0x1BD0D10")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1BD0D34", Offset = "0x1BD0D34", VA = "0x1BD0D34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1BD1D0C", Offset = "0x1BD1D0C", VA = "0x1BD1D0C")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1BD2488", Offset = "0x1BD2488", VA = "0x1BD2488")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1BD292C", Offset = "0x1BD292C", VA = "0x1BD292C")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1BD1BA8", Offset = "0x1BD1BA8", VA = "0x1BD1BA8")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1BD1FD8", Offset = "0x1BD1FD8", VA = "0x1BD1FD8")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1BD2780", Offset = "0x1BD2780", VA = "0x1BD2780")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1BD17C8", Offset = "0x1BD17C8", VA = "0x1BD17C8")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1BD2E48", Offset = "0x1BD2E48", VA = "0x1BD2E48")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8B04", Offset = "0x9D8B04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8B04", Offset = "0x9D8B04")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000A4")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x40003A8")]
			TriangleDepthNormals,
			[Token(Token = "0x40003A9")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x40003AA")]
			SobelDepth,
			[Token(Token = "0x40003AB")]
			SobelDepthThin,
			[Token(Token = "0x40003AC")]
			TriangleLuminance
		}

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1BD2F24", Offset = "0x1BD2F24", VA = "0x1BD2F24", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1BD30A8", Offset = "0x1BD30A8", VA = "0x1BD30A8")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1BD2F9C", Offset = "0x1BD2F9C", VA = "0x1BD2F9C")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1BD30B4", Offset = "0x1BD30B4", VA = "0x1BD30B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1BD30B8", Offset = "0x1BD30B8", VA = "0x1BD30B8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1BD3320", Offset = "0x1BD3320", VA = "0x1BD3320")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8B9C", Offset = "0x9D8B9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8B9C", Offset = "0x9D8B9C")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9DF0", Offset = "0x9D9DF0")]
		public float strengthX;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9E08", Offset = "0x9D9E08")]
		public float strengthY;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1BD3370", Offset = "0x1BD3370", VA = "0x1BD3370", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1BD33C8", Offset = "0x1BD33C8", VA = "0x1BD33C8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1BD3550", Offset = "0x1BD3550", VA = "0x1BD3550")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8C34", Offset = "0x9D8C34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8C34", Offset = "0x9D8C34")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9E20", Offset = "0x9D9E20")]
		public bool distanceFog;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9E58", Offset = "0x9D9E58")]
		public bool excludeFarPixels;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9E90", Offset = "0x9D9E90")]
		public bool useRadialDistance;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9EC8", Offset = "0x9D9EC8")]
		public bool heightFog;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9F00", Offset = "0x9D9F00")]
		public float height;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9F38", Offset = "0x9D9F38")]
		public float heightDensity;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D9F54", Offset = "0x9D9F54")]
		public float startDistance;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1BD3568", Offset = "0x1BD3568", VA = "0x1BD3568", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1BD35C0", Offset = "0x1BD35C0", VA = "0x1BD35C0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1BD3F14", Offset = "0x1BD3F14", VA = "0x1BD3F14")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1BD40C0", Offset = "0x1BD40C0", VA = "0x1BD40C0")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8CCC", Offset = "0x9D8CCC")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9F8C", Offset = "0x9D9F8C")]
		public float rampOffset;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1BD40E0", Offset = "0x1BD40E0", VA = "0x1BD40E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1BD41E8", Offset = "0x1BD41E8", VA = "0x1BD41E8")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8D18", Offset = "0x9D8D18")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8D18", Offset = "0x9D8D18")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000008")]
		protected Material material
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1BCCB34", Offset = "0x1BCCB34", VA = "0x1BCCB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1BD41F0", Offset = "0x1BD41F0", VA = "0x1BD41F0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1BD42A8", Offset = "0x1BD42A8", VA = "0x1BD42A8", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1BCCC04", Offset = "0x1BCCC04", VA = "0x1BCCC04")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8DA0", Offset = "0x9D8DA0")]
	public class ImageEffects
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1BD4358", Offset = "0x1BD4358", VA = "0x1BD4358")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1BD45E8", Offset = "0x1BD45E8", VA = "0x1BD45E8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DD9F4", Offset = "0x9DD9F4")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1BD4660", Offset = "0x1BD4660", VA = "0x1BD4660")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9DDA2C", Offset = "0x9DDA2C")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1BD46E0", Offset = "0x1BD46E0", VA = "0x1BD46E0")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8DD8", Offset = "0x9D8DD8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8DD8", Offset = "0x9D8DD8")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9FA4", Offset = "0x9D9FA4")]
		public float blurAmount;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1BD46E8", Offset = "0x1BD46E8", VA = "0x1BD46E8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1BD472C", Offset = "0x1BD472C", VA = "0x1BD472C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1BD47A0", Offset = "0x1BD47A0", VA = "0x1BD47A0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1BD4B8C", Offset = "0x1BD4B8C", VA = "0x1BD4B8C")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8E70", Offset = "0x9D8E70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8E70", Offset = "0x9D8E70")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh mesh;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1BD4BA0", Offset = "0x1BD4BA0", VA = "0x1BD4BA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1BD4C00", Offset = "0x1BD4C00", VA = "0x1BD4C00", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1BD4C78", Offset = "0x1BD4C78", VA = "0x1BD4C78")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1BD5764", Offset = "0x1BD5764", VA = "0x1BD5764")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1BD5AA8", Offset = "0x1BD5AA8", VA = "0x1BD5AA8")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1BD61E4", Offset = "0x1BD61E4", VA = "0x1BD61E4")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1BD6468", Offset = "0x1BD6468", VA = "0x1BD6468")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8F08", Offset = "0x9D8F08")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D8F08", Offset = "0x9D8F08")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9FC0", Offset = "0x9D9FC0")]
		public float grainIntensityMin;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9FD8", Offset = "0x9D9FD8")]
		public float grainIntensityMax;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9D9FF0", Offset = "0x9D9FF0")]
		public float grainSize;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB010", Offset = "0x9DB010")]
		public float scratchIntensityMin;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB028", Offset = "0x9DB028")]
		public float scratchIntensityMax;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB040", Offset = "0x9DB040")]
		public float scratchFPS;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB058", Offset = "0x9DB058")]
		public float scratchJitter;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000009")]
		protected Material material
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x1BD66C4", Offset = "0x1BD66C4", VA = "0x1BD66C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1BD6570", Offset = "0x1BD6570", VA = "0x1BD6570")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1BD682C", Offset = "0x1BD682C", VA = "0x1BD682C")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1BD6930", Offset = "0x1BD6930", VA = "0x1BD6930")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1BD6A6C", Offset = "0x1BD6A6C", VA = "0x1BD6A6C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1BD6E10", Offset = "0x1BD6E10", VA = "0x1BD6E10")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D8FA0", Offset = "0x9D8FA0")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1BC5254", Offset = "0x1BC5254", VA = "0x1BC5254")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1BD6E70", Offset = "0x1BD6E70", VA = "0x1BD6E70")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1BD7070", Offset = "0x1BD7070", VA = "0x1BD7070")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1BD707C", Offset = "0x1BD707C", VA = "0x1BD707C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1BD7080", Offset = "0x1BD7080", VA = "0x1BD7080")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1BD7178", Offset = "0x1BD7178", VA = "0x1BD7178")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1BD7180", Offset = "0x1BD7180", VA = "0x1BD7180", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1BCAC78", Offset = "0x1BCAC78", VA = "0x1BCAC78")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1BC511C", Offset = "0x1BC511C", VA = "0x1BC511C")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1BC87F0", Offset = "0x1BC87F0", VA = "0x1BC87F0")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1BD7230", Offset = "0x1BD7230", VA = "0x1BD7230")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1BC5694", Offset = "0x1BC5694", VA = "0x1BC5694")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1BD7238", Offset = "0x1BD7238", VA = "0x1BD7238")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1BD6E44", Offset = "0x1BD6E44", VA = "0x1BD6E44")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1BD74C8", Offset = "0x1BD74C8", VA = "0x1BD74C8")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1BC6B58", Offset = "0x1BC6B58", VA = "0x1BC6B58")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9014", Offset = "0x9D9014")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1BD7870", Offset = "0x1BD7870", VA = "0x1BD7870")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1BD78DC", Offset = "0x1BD78DC", VA = "0x1BD78DC")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1BD7B74", Offset = "0x1BD7B74", VA = "0x1BD7B74")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1BD7F18", Offset = "0x1BD7F18", VA = "0x1BD7F18")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1BD80D0", Offset = "0x1BD80D0", VA = "0x1BD80D0")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000028")]
	internal class Quads
	{
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1BD80D8", Offset = "0x1BD80D8", VA = "0x1BD80D8")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1BD085C", Offset = "0x1BD085C", VA = "0x1BD085C")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1BD2B70", Offset = "0x1BD2B70", VA = "0x1BD2B70")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1BD81F0", Offset = "0x1BD81F0", VA = "0x1BD81F0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1BD8904", Offset = "0x1BD8904", VA = "0x1BD8904")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9088", Offset = "0x9D9088")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9088", Offset = "0x9D9088")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20000A5")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40003AE")]
			Additive,
			[Token(Token = "0x40003AF")]
			ScreenBlend,
			[Token(Token = "0x40003B0")]
			Multiply,
			[Token(Token = "0x40003B1")]
			Overlay,
			[Token(Token = "0x40003B2")]
			AlphaBlend
		}

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1BD8910", Offset = "0x1BD8910", VA = "0x1BD8910", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1BD8968", Offset = "0x1BD8968", VA = "0x1BD8968")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1BD8B20", Offset = "0x1BD8B20", VA = "0x1BD8B20")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9120", Offset = "0x9D9120")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9120", Offset = "0x9D9120")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB070", Offset = "0x9DB070")]
		public float intensity;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB088", Offset = "0x9DB088")]
		public float radius;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB0A4", Offset = "0x9DB0A4")]
		public int blurIterations;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB0BC", Offset = "0x9DB0BC")]
		public float blurFilterDistance;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB0D4", Offset = "0x9DB0D4")]
		public int downsample;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1BD8B30", Offset = "0x1BD8B30", VA = "0x1BD8B30", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1BD8B88", Offset = "0x1BD8B88", VA = "0x1BD8B88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1BD8C30", Offset = "0x1BD8C30", VA = "0x1BD8C30")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1BD9588", Offset = "0x1BD9588", VA = "0x1BD9588")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D91B8", Offset = "0x9D91B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D91B8", Offset = "0x9D91B8")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40003B4")]
			Low,
			[Token(Token = "0x40003B5")]
			Medium,
			[Token(Token = "0x40003B6")]
			High
		}

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB0EC", Offset = "0x9DB0EC")]
		public float m_Radius;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB108", Offset = "0x9DB108")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB120", Offset = "0x9DB120")]
		public int m_Blur;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB138", Offset = "0x9DB138")]
		public int m_Downsampling;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB150", Offset = "0x9DB150")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB16C", Offset = "0x9DB16C")]
		public float m_MinZ;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1BD95A4", Offset = "0x1BD95A4", VA = "0x1BD95A4")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1BD9658", Offset = "0x1BD9658", VA = "0x1BD9658")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1BD96F4", Offset = "0x1BD96F4", VA = "0x1BD96F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1BD96FC", Offset = "0x1BD96FC", VA = "0x1BD96FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1BD98BC", Offset = "0x1BD98BC", VA = "0x1BD98BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1BD97DC", Offset = "0x1BD97DC", VA = "0x1BD97DC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1BD9954", Offset = "0x1BD9954", VA = "0x1BD9954")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1BDA10C", Offset = "0x1BDA10C", VA = "0x1BDA10C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9250", Offset = "0x9D9250")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1BDA144", Offset = "0x1BDA144", VA = "0x1BDA144")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1BDA1D4", Offset = "0x1BDA1D4", VA = "0x1BDA1D4")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D929C", Offset = "0x9D929C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D929C", Offset = "0x9D929C")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20000A7")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40003B8")]
			Low,
			[Token(Token = "0x40003B9")]
			Normal,
			[Token(Token = "0x40003BA")]
			High
		}

		[Token(Token = "0x20000A8")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40003BC")]
			Screen,
			[Token(Token = "0x40003BD")]
			Add
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1BDA1DC", Offset = "0x1BDA1DC", VA = "0x1BDA1DC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1BDA244", Offset = "0x1BDA244", VA = "0x1BDA244")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1BDAB68", Offset = "0x1BDAB68", VA = "0x1BDAB68")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9334", Offset = "0x9D9334")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9334", Offset = "0x9D9334")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20000A9")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40003BF")]
			TiltShiftMode,
			[Token(Token = "0x40003C0")]
			IrisMode
		}

		[Token(Token = "0x20000AA")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40003C2")]
			Preview,
			[Token(Token = "0x40003C3")]
			Normal,
			[Token(Token = "0x40003C4")]
			High
		}

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB188", Offset = "0x9DB188")]
		public float blurArea;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB1A0", Offset = "0x9DB1A0")]
		public float maxBlurSize;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB1B8", Offset = "0x9DB1B8")]
		public int downsample;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1BDAC10", Offset = "0x1BDAC10", VA = "0x1BDAC10", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1BDAC68", Offset = "0x1BDAC68", VA = "0x1BDAC68")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1BDAF70", Offset = "0x1BDAF70", VA = "0x1BDAF70")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D93BC", Offset = "0x9D93BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D93BC", Offset = "0x9D93BC")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x20000AB")]
		public enum TonemapperType
		{
			[Token(Token = "0x40003C6")]
			SimpleReinhard,
			[Token(Token = "0x40003C7")]
			UserCurve,
			[Token(Token = "0x40003C8")]
			Hable,
			[Token(Token = "0x40003C9")]
			Photographic,
			[Token(Token = "0x40003CA")]
			OptimizedHejiDawson,
			[Token(Token = "0x40003CB")]
			AdaptiveReinhard,
			[Token(Token = "0x40003CC")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x20000AC")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x40003CE")]
			Square16 = 0x10,
			[Token(Token = "0x40003CF")]
			Square32 = 0x20,
			[Token(Token = "0x40003D0")]
			Square64 = 0x40,
			[Token(Token = "0x40003D1")]
			Square128 = 0x80,
			[Token(Token = "0x40003D2")]
			Square256 = 0x100,
			[Token(Token = "0x40003D3")]
			Square512 = 0x200,
			[Token(Token = "0x40003D4")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1BDAF88", Offset = "0x1BDAF88", VA = "0x1BDAF88", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1BDB0E0", Offset = "0x1BDB0E0", VA = "0x1BDB0E0")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1BDB400", Offset = "0x1BDB400", VA = "0x1BDB400")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1BDB558", Offset = "0x1BDB558", VA = "0x1BDB558")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1BDB64C", Offset = "0x1BDB64C", VA = "0x1BDB64C")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1BDBF9C", Offset = "0x1BDBF9C", VA = "0x1BDBF9C")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000030")]
	internal class Triangles
	{
		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1BDBFC8", Offset = "0x1BDBFC8", VA = "0x1BDBFC8")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1BDC124", Offset = "0x1BDC124", VA = "0x1BDC124")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1BDC344", Offset = "0x1BDC344", VA = "0x1BDC344")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1BDC61C", Offset = "0x1BDC61C", VA = "0x1BDC61C")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1BDCBA4", Offset = "0x1BDCBA4", VA = "0x1BDCBA4")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9464", Offset = "0x9D9464")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB1D0", Offset = "0x9DB1D0")]
		public float angle;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1BDCBB0", Offset = "0x1BDCBB0", VA = "0x1BDCBB0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1BDCBF4", Offset = "0x1BDCBF4", VA = "0x1BDCBF4")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D94B0", Offset = "0x9D94B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D94B0", Offset = "0x9D94B0")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x20000AD")]
		public enum AberrationMode
		{
			[Token(Token = "0x40003D6")]
			Simple,
			[Token(Token = "0x40003D7")]
			Advanced
		}

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1BDCC70", Offset = "0x1BDCC70", VA = "0x1BDCC70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1BDCCF4", Offset = "0x1BDCCF4", VA = "0x1BDCCF4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1BDD3EC", Offset = "0x1BDD3EC", VA = "0x1BDD3EC")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9548", Offset = "0x9D9548")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1BDD420", Offset = "0x1BDD420", VA = "0x1BDD420")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1BDD464", Offset = "0x1BDD464", VA = "0x1BDD464")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9594", Offset = "0x9D9594")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9594", Offset = "0x9D9594")]
	[ImageEffectAllowedInSceneView]
	public class AmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		private struct PropertyObserver
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _downsampling;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private OcclusionSource _occlusionSource;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private bool _ambientOnly;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			private bool _debug;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int _pixelWidth;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _pixelHeight;

			[Token(Token = "0x6000262")]
			[Address(RVA = "0xAA67B8", Offset = "0xAA67B8", VA = "0xAA67B8")]
			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return default(bool);
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0xAA67C0", Offset = "0xAA67C0", VA = "0xAA67C0")]
			public void Update(Settings setting, Camera camera)
			{
			}
		}

		[Token(Token = "0x20000AF")]
		public enum SampleCount
		{
			[Token(Token = "0x40003DF")]
			Lowest,
			[Token(Token = "0x40003E0")]
			Low,
			[Token(Token = "0x40003E1")]
			Medium,
			[Token(Token = "0x40003E2")]
			High,
			[Token(Token = "0x40003E3")]
			Variable
		}

		[Token(Token = "0x20000B0")]
		public enum OcclusionSource
		{
			[Token(Token = "0x40003E5")]
			DepthTexture,
			[Token(Token = "0x40003E6")]
			DepthNormalsTexture,
			[Token(Token = "0x40003E7")]
			GBuffer
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public class Settings
		{
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB5FC", Offset = "0x9DB5FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB5FC", Offset = "0x9DB5FC")]
			public float intensity;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB660", Offset = "0x9DB660")]
			public float radius;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB6AC", Offset = "0x9DB6AC")]
			public SampleCount sampleCount;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB6F8", Offset = "0x9DB6F8")]
			public int sampleCountValue;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB744", Offset = "0x9DB744")]
			public bool downsampling;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB790", Offset = "0x9DB790")]
			public bool ambientOnly;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB7DC", Offset = "0x9DB7DC")]
			public OcclusionSource occlusionSource;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB828", Offset = "0x9DB828")]
			public bool debug;

			[Token(Token = "0x17000060")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000264")]
				[Address(RVA = "0x17576B4", Offset = "0x17576B4", VA = "0x17576B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000265")]
			[Address(RVA = "0x17577AC", Offset = "0x17577AC", VA = "0x17577AC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader _aoShader;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _aoMaterial;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CommandBuffer _aoCommands;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB20C", Offset = "0x9DB20C")]
		private PropertyObserver <propertyObserver>k__BackingField;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Mesh _quadMesh;

		[Token(Token = "0x1700000A")]
		public bool isAmbientOnlySupported
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1755588", Offset = "0x1755588", VA = "0x1755588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x175568C", Offset = "0x175568C", VA = "0x175568C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private float intensity
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x17556C8", Offset = "0x17556C8", VA = "0x17556C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		private float radius
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x17556F4", Offset = "0x17556F4", VA = "0x17556F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		private SampleCount sampleCount
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1755780", Offset = "0x1755780", VA = "0x1755780")]
			get
			{
				return default(SampleCount);
			}
		}

		[Token(Token = "0x1700000F")]
		private int sampleCountValue
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x17557AC", Offset = "0x17557AC", VA = "0x17557AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x175562C", Offset = "0x175562C", VA = "0x175562C")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x17000011")]
		private bool downsampling
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1755864", Offset = "0x1755864", VA = "0x1755864")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		private bool ambientOnly
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1755890", Offset = "0x1755890", VA = "0x1755890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private RenderTextureFormat aoTextureFormat
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x17558F0", Offset = "0x17558F0", VA = "0x17558F0")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Token(Token = "0x17000014")]
		private Shader aoShader
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x1755924", Offset = "0x1755924", VA = "0x1755924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private Material aoMaterial
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x17559BC", Offset = "0x17559BC", VA = "0x17559BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private CommandBuffer aoCommands
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1755B24", Offset = "0x1755B24", VA = "0x1755B24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private Camera targetCamera
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x17555DC", Offset = "0x17555DC", VA = "0x17555DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private PropertyObserver propertyObserver
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1755BB4", Offset = "0x1755BB4", VA = "0x1755BB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDA94", Offset = "0x9DDA94")]
			get
			{
				return default(PropertyObserver);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x1755BC8", Offset = "0x1755BC8", VA = "0x1755BC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAA4", Offset = "0x9DDAA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		private Mesh quadMesh
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x1755BDC", Offset = "0x1755BDC", VA = "0x1755BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1755BE4", Offset = "0x1755BE4", VA = "0x1755BE4")]
		private void BuildAOCommands()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1756594", Offset = "0x1756594", VA = "0x1756594")]
		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1756C4C", Offset = "0x1756C4C", VA = "0x1756C4C")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1756D98", Offset = "0x1756D98", VA = "0x1756D98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1757240", Offset = "0x1757240", VA = "0x1757240")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1757324", Offset = "0x1757324", VA = "0x1757324")]
		private void Update()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17575DC", Offset = "0x17575DC", VA = "0x17575DC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1757688", Offset = "0x1757688", VA = "0x1757688")]
		public AmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D963C", Offset = "0x9D963C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D963C", Offset = "0x9D963C")]
	[ImageEffectAllowedInSceneView]
	public class AntiAliasing : MonoBehaviour
	{
		[Token(Token = "0x20000B2")]
		public enum Method
		{
			[Token(Token = "0x40003F1")]
			Smaa,
			[Token(Token = "0x40003F2")]
			Fxaa
		}

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SMAA m_SMAA;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FXAA m_FXAA;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private int m_Method;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Camera m_Camera;

		[Token(Token = "0x1700001A")]
		public int method
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x17577B4", Offset = "0x17577B4", VA = "0x17577B4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x17577BC", Offset = "0x17577BC", VA = "0x17577BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public IAntiAliasing current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x17577D0", Offset = "0x17577D0", VA = "0x17577D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public Camera cameraComponent
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x17577E8", Offset = "0x17577E8", VA = "0x17577E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1757880", Offset = "0x1757880", VA = "0x1757880")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1757980", Offset = "0x1757980", VA = "0x1757980")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1757B84", Offset = "0x1757B84", VA = "0x1757B84")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1757C5C", Offset = "0x1757C5C", VA = "0x1757C5C")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1757D34", Offset = "0x1757D34", VA = "0x1757D34")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1757E24", Offset = "0x1757E24", VA = "0x1757E24")]
		public AntiAliasing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		[Token(Token = "0x20000B3")]
		public struct QualitySettings
		{
			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB874", Offset = "0x9DB874")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB874", Offset = "0x9DB874")]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB8C8", Offset = "0x9DB8C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB8C8", Offset = "0x9DB8C8")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB924", Offset = "0x9DB924")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB924", Offset = "0x9DB924")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x20000B4")]
		public struct ConsoleSettings
		{
			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB97C", Offset = "0x9DB97C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB97C", Offset = "0x9DB97C")]
			public float subpixelSpreadAmount;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB9D4", Offset = "0x9DB9D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DB9D4", Offset = "0x9DB9D4")]
			public float edgeSharpnessAmount;

			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBA28", Offset = "0x9DBA28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBA28", Offset = "0x9DBA28")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBA7C", Offset = "0x9DBA7C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBA7C", Offset = "0x9DBA7C")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x20000B5")]
		public struct Preset
		{
			[Token(Token = "0x20000F0")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9C58", Offset = "0x9D9C58")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x175C5D8", Offset = "0x175C5D8", VA = "0x175C5D8")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Layout]
			public QualitySettings qualitySettings;

			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Layout]
			public ConsoleSettings consoleSettings;

			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Preset s_ExtremePerformance;

			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private static readonly Preset s_Performance;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static readonly Preset s_Default;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private static readonly Preset s_Quality;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static readonly Preset s_ExtremeQuality;

			[Token(Token = "0x17000061")]
			public static Preset extremePerformancePreset
			{
				[Token(Token = "0x6000266")]
				[Address(RVA = "0x175C2FC", Offset = "0x175C2FC", VA = "0x175C2FC")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000062")]
			public static Preset performancePreset
			{
				[Token(Token = "0x6000267")]
				[Address(RVA = "0x175C374", Offset = "0x175C374", VA = "0x175C374")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000063")]
			public static Preset defaultPreset
			{
				[Token(Token = "0x6000268")]
				[Address(RVA = "0x175C0D0", Offset = "0x175C0D0", VA = "0x175C0D0")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000064")]
			public static Preset qualityPreset
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x175C3EC", Offset = "0x175C3EC", VA = "0x175C3EC")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000065")]
			public static Preset extremeQualityPreset
			{
				[Token(Token = "0x600026A")]
				[Address(RVA = "0x175C464", Offset = "0x175C464", VA = "0x175C464")]
				get
				{
					return default(Preset);
				}
			}
		}

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Shader m_Shader;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material m_Material;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		public Preset preset;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Preset[] availablePresets;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB2BC", Offset = "0x9DB2BC")]
		private bool <validSourceFormat>k__BackingField;

		[Token(Token = "0x1700001D")]
		private Shader shader
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x175BDF0", Offset = "0x175BDF0", VA = "0x175BDF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public Material material
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x175BE88", Offset = "0x175BE88", VA = "0x175BE88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public bool validSourceFormat
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x175BF18", Offset = "0x175BF18", VA = "0x175BF18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAC4", Offset = "0x9DDAC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x175BF20", Offset = "0x175BF20", VA = "0x175BF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAD4", Offset = "0x9DDAD4")]
			private set
			{
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1757928", Offset = "0x1757928", VA = "0x1757928", Slot = "4")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1757AD0", Offset = "0x1757AD0", VA = "0x1757AD0", Slot = "5")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x175BF2C", Offset = "0x175BF2C", VA = "0x175BF2C", Slot = "6")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x175BF30", Offset = "0x175BF30", VA = "0x175BF30", Slot = "7")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x175BF34", Offset = "0x175BF34", VA = "0x175BF34", Slot = "8")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1757F84", Offset = "0x1757F84", VA = "0x1757F84")]
		public FXAA()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public interface IAntiAliasing
	{
		[Token(Token = "0x6000123")]
		void OnEnable(AntiAliasing owner);

		[Token(Token = "0x6000124")]
		void OnDisable();

		[Token(Token = "0x6000125")]
		void OnPreCull(Camera camera);

		[Token(Token = "0x6000126")]
		void OnPostRender(Camera camera);

		[Token(Token = "0x6000127")]
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class SMAA : IAntiAliasing
	{
		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9B70", Offset = "0x9D9B70")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x175E8E8", Offset = "0x175E8E8", VA = "0x175E8E8")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9B84", Offset = "0x9D9B84")]
		public class TopLevelSettings : Attribute
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x175E8F0", Offset = "0x175E8F0", VA = "0x175E8F0")]
			public TopLevelSettings()
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9B98", Offset = "0x9D9B98")]
		public class ExperimentalGroup : Attribute
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x175E738", Offset = "0x175E738", VA = "0x175E738")]
			public ExperimentalGroup()
			{
			}
		}

		[Token(Token = "0x20000B9")]
		public enum DebugPass
		{
			[Token(Token = "0x4000402")]
			Off,
			[Token(Token = "0x4000403")]
			Edges,
			[Token(Token = "0x4000404")]
			Weights,
			[Token(Token = "0x4000405")]
			Accumulation
		}

		[Token(Token = "0x20000BA")]
		public enum QualityPreset
		{
			[Token(Token = "0x4000407")]
			Low,
			[Token(Token = "0x4000408")]
			Medium,
			[Token(Token = "0x4000409")]
			High,
			[Token(Token = "0x400040A")]
			Ultra,
			[Token(Token = "0x400040B")]
			Custom
		}

		[Token(Token = "0x20000BB")]
		public enum EdgeDetectionMethod
		{
			[Token(Token = "0x400040D")]
			Luma = 1,
			[Token(Token = "0x400040E")]
			Color,
			[Token(Token = "0x400040F")]
			Depth
		}

		[Serializable]
		[Token(Token = "0x20000BC")]
		public struct GlobalSettings
		{
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBAF8", Offset = "0x9DBAF8")]
			public DebugPass debugPass;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBB30", Offset = "0x9DBB30")]
			public QualityPreset quality;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBB68", Offset = "0x9DBB68")]
			public EdgeDetectionMethod edgeDetectionMethod;

			[Token(Token = "0x17000066")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600026F")]
				[Address(RVA = "0x175E70C", Offset = "0x175E70C", VA = "0x175E70C")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public struct QualitySettings
		{
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBBA0", Offset = "0x9DBBA0")]
			public bool diagonalDetection;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBBD8", Offset = "0x9DBBD8")]
			public bool cornerDetection;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBC10", Offset = "0x9DBC10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBC10", Offset = "0x9DBC10")]
			public float threshold;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DBC64", Offset = "0x9DBC64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBC64", Offset = "0x9DBC64")]
			public float depthThreshold;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBCB8", Offset = "0x9DBCB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBCB8", Offset = "0x9DBCB8")]
			public int maxSearchSteps;

			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBD10", Offset = "0x9DBD10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBD10", Offset = "0x9DBD10")]
			public int maxDiagonalSearchSteps;

			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBD64", Offset = "0x9DBD64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBD64", Offset = "0x9DBD64")]
			public int cornerRounding;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DBDBC", Offset = "0x9DBDBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBDBC", Offset = "0x9DBDBC")]
			public float localContrastAdaptationFactor;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x20000BE")]
		public struct TemporalSettings
		{
			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE0C", Offset = "0x9DBE0C")]
			public bool enabled;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBE44", Offset = "0x9DBE44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE44", Offset = "0x9DBE44")]
			public float fuzzSize;

			[Token(Token = "0x17000067")]
			public static TemporalSettings defaultSettings
			{
				[Token(Token = "0x6000272")]
				[Address(RVA = "0x175E730", Offset = "0x175E730", VA = "0x175E730")]
				get
				{
					return default(TemporalSettings);
				}
			}

			[Token(Token = "0x6000271")]
			[Address(RVA = "0xAA6C4C", Offset = "0xAA6C4C", VA = "0xAA6C4C")]
			public bool UseTemporal()
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x20000BF")]
		public struct PredicationSettings
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBE98", Offset = "0x9DBE98")]
			public bool enabled;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DBED0", Offset = "0x9DBED0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBED0", Offset = "0x9DBED0")]
			public float threshold;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBF24", Offset = "0x9DBF24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBF24", Offset = "0x9DBF24")]
			public float scale;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DBF78", Offset = "0x9DBF78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBF78", Offset = "0x9DBF78")]
			public float strength;

			[Token(Token = "0x17000068")]
			public static PredicationSettings defaultSettings
			{
				[Token(Token = "0x6000273")]
				[Address(RVA = "0x175E718", Offset = "0x175E718", VA = "0x175E718")]
				get
				{
					return default(PredicationSettings);
				}
			}
		}

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[TopLevelSettings]
		public GlobalSettings settings;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SettingsGroup]
		public QualitySettings quality;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SettingsGroup]
		public PredicationSettings predication;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SettingsGroup]
		[ExperimentalGroup]
		public TemporalSettings temporal;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Matrix4x4 m_ProjectionMatrix;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_FlipFlop;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private RenderTexture m_Accumulation;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Shader m_Shader;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Texture2D m_AreaTexture;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Texture2D m_SearchTexture;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material m_Material;

		[Token(Token = "0x17000020")]
		public Shader shader
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x175D63C", Offset = "0x175D63C", VA = "0x175D63C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x175D6D4", Offset = "0x175D6D4", VA = "0x175D6D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x175D774", Offset = "0x175D774", VA = "0x175D774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private Material material
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x175D814", Offset = "0x175D814", VA = "0x175D814")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17578D0", Offset = "0x17578D0", VA = "0x17578D0", Slot = "4")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17579C8", Offset = "0x17579C8", VA = "0x17579C8", Slot = "5")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x175D8A4", Offset = "0x175D8A4", VA = "0x175D8A4", Slot = "6")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x175DAB0", Offset = "0x175DAB0", VA = "0x175DAB0", Slot = "7")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x175DAF4", Offset = "0x175DAF4", VA = "0x175DAF4", Slot = "8")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x175E6F4", Offset = "0x175E6F4", VA = "0x175E6F4")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1757EA4", Offset = "0x1757EA4", VA = "0x1757EA4")]
		public SMAA()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D96E4", Offset = "0x9D96E4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D96E4", Offset = "0x9D96E4")]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public struct Settings
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DBFCC", Offset = "0x9DBFCC")]
			public float threshold;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC018", Offset = "0x9DC018")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC018", Offset = "0x9DC018")]
			public float softKnee;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC07C", Offset = "0x9DC07C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC07C", Offset = "0x9DC07C")]
			public float radius;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC0E0", Offset = "0x9DC0E0")]
			public float intensity;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC12C", Offset = "0x9DC12C")]
			public bool highQuality;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC178", Offset = "0x9DC178")]
			public bool antiFlicker;

			[Token(Token = "0x17000069")]
			public float thresholdGamma
			{
				[Token(Token = "0x6000275")]
				[Address(RVA = "0xAA684C", Offset = "0xAA684C", VA = "0xAA684C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000274")]
				[Address(RVA = "0xAA6844", Offset = "0xAA6844", VA = "0xAA6844")]
				set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public float thresholdLinear
			{
				[Token(Token = "0x6000277")]
				[Address(RVA = "0xAA685C", Offset = "0xAA685C", VA = "0xAA685C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000276")]
				[Address(RVA = "0xAA6854", Offset = "0xAA6854", VA = "0xAA6854")]
				set
				{
				}
			}

			[Token(Token = "0x1700006B")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000278")]
				[Address(RVA = "0x1758CE0", Offset = "0x1758CE0", VA = "0x1758CE0")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material m_Material;

		[Token(Token = "0x40001E1")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture[] m_blurBuffer1;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture[] m_blurBuffer2;

		[Token(Token = "0x17000024")]
		public Shader shader
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x175800C", Offset = "0x175800C", VA = "0x175800C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public Material material
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x17580A4", Offset = "0x17580A4", VA = "0x17580A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1758134", Offset = "0x1758134", VA = "0x1758134")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1758180", Offset = "0x1758180", VA = "0x1758180")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x175822C", Offset = "0x175822C", VA = "0x175822C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1758C5C", Offset = "0x1758C5C", VA = "0x1758C5C")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x17000026")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x17593F4", Offset = "0x17593F4", VA = "0x17593F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1756EFC", Offset = "0x1756EFC", VA = "0x1756EFC")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1755A4C", Offset = "0x1755A4C", VA = "0x1755A4C")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x200003B")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x175D608", Offset = "0x175D608", VA = "0x175D608")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x175AED4", Offset = "0x175AED4", VA = "0x175AED4")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x175B0F0", Offset = "0x175B0F0", VA = "0x175B0F0")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x17599B4", Offset = "0x17599B4", VA = "0x17599B4")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x175BC98", Offset = "0x175BC98", VA = "0x175BC98")]
		public RenderTextureUtility()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D978C", Offset = "0x9D978C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D978C", Offset = "0x9D978C")]
	public class DepthOfField : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		private enum Passes
		{
			[Token(Token = "0x4000429")]
			BlurAlphaWeighted,
			[Token(Token = "0x400042A")]
			BoxBlur,
			[Token(Token = "0x400042B")]
			DilateFgCocFromColor,
			[Token(Token = "0x400042C")]
			DilateFgCoc,
			[Token(Token = "0x400042D")]
			CaptureCocExplicit,
			[Token(Token = "0x400042E")]
			VisualizeCocExplicit,
			[Token(Token = "0x400042F")]
			CocPrefilter,
			[Token(Token = "0x4000430")]
			CircleBlur,
			[Token(Token = "0x4000431")]
			CircleBlurWithDilatedFg,
			[Token(Token = "0x4000432")]
			CircleBlurLowQuality,
			[Token(Token = "0x4000433")]
			CircleBlowLowQualityWithDilatedFg,
			[Token(Token = "0x4000434")]
			MergeExplicit,
			[Token(Token = "0x4000435")]
			ShapeLowQuality,
			[Token(Token = "0x4000436")]
			ShapeLowQualityDilateFg,
			[Token(Token = "0x4000437")]
			ShapeLowQualityMerge,
			[Token(Token = "0x4000438")]
			ShapeLowQualityMergeDilateFg,
			[Token(Token = "0x4000439")]
			ShapeMediumQuality,
			[Token(Token = "0x400043A")]
			ShapeMediumQualityDilateFg,
			[Token(Token = "0x400043B")]
			ShapeMediumQualityMerge,
			[Token(Token = "0x400043C")]
			ShapeMediumQualityMergeDilateFg,
			[Token(Token = "0x400043D")]
			ShapeHighQuality,
			[Token(Token = "0x400043E")]
			ShapeHighQualityDilateFg,
			[Token(Token = "0x400043F")]
			ShapeHighQualityMerge,
			[Token(Token = "0x4000440")]
			ShapeHighQualityMergeDilateFg
		}

		[Token(Token = "0x20000C2")]
		private enum MedianPasses
		{
			[Token(Token = "0x4000442")]
			Median3,
			[Token(Token = "0x4000443")]
			Median3X3
		}

		[Token(Token = "0x20000C3")]
		private enum BokehTexturesPasses
		{
			[Token(Token = "0x4000445")]
			Apply,
			[Token(Token = "0x4000446")]
			Collect
		}

		[Token(Token = "0x20000C4")]
		public enum TweakMode
		{
			[Token(Token = "0x4000448")]
			Range,
			[Token(Token = "0x4000449")]
			Explicit
		}

		[Token(Token = "0x20000C5")]
		public enum ApertureShape
		{
			[Token(Token = "0x400044B")]
			Circular,
			[Token(Token = "0x400044C")]
			Hexagonal,
			[Token(Token = "0x400044D")]
			Octogonal
		}

		[Token(Token = "0x20000C6")]
		public enum QualityPreset
		{
			[Token(Token = "0x400044F")]
			Low,
			[Token(Token = "0x4000450")]
			Medium,
			[Token(Token = "0x4000451")]
			High
		}

		[Token(Token = "0x20000C7")]
		public enum FilterQuality
		{
			[Token(Token = "0x4000453")]
			None,
			[Token(Token = "0x4000454")]
			Normal,
			[Token(Token = "0x4000455")]
			High
		}

		[Serializable]
		[Token(Token = "0x20000C8")]
		public struct GlobalSettings
		{
			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC1C4", Offset = "0x9DC1C4")]
			public bool visualizeFocus;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC1FC", Offset = "0x9DC1FC")]
			public TweakMode tweakMode;

			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC234", Offset = "0x9DC234")]
			public QualityPreset filteringQuality;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC26C", Offset = "0x9DC26C")]
			public ApertureShape apertureShape;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC2A4", Offset = "0x9DC2A4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC2A4", Offset = "0x9DC2A4")]
			public float apertureOrientation;

			[Token(Token = "0x1700006C")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x6000279")]
				[Address(RVA = "0x175BC54", Offset = "0x175BC54", VA = "0x175BC54")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000C9")]
		public struct QualitySettings
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC2FC", Offset = "0x9DC2FC")]
			public bool prefilterBlur;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC334", Offset = "0x9DC334")]
			public FilterQuality medianFilter;

			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC36C", Offset = "0x9DC36C")]
			public bool dilateNearBlur;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x20000CA")]
		public struct FocusSettings
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC3A4", Offset = "0x9DC3A4")]
			public Transform transform;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC3DC", Offset = "0x9DC3DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC3DC", Offset = "0x9DC3DC")]
			public float focusPlane;

			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC42C", Offset = "0x9DC42C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC42C", Offset = "0x9DC42C")]
			public float range;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC480", Offset = "0x9DC480")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC480", Offset = "0x9DC480")]
			public float nearPlane;

			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC4D0", Offset = "0x9DC4D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC4D0", Offset = "0x9DC4D0")]
			public float nearFalloff;

			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC520", Offset = "0x9DC520")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC520", Offset = "0x9DC520")]
			public float farPlane;

			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DC570", Offset = "0x9DC570")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC570", Offset = "0x9DC570")]
			public float farFalloff;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC5C0", Offset = "0x9DC5C0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC5C0", Offset = "0x9DC5C0")]
			public float nearBlurRadius;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC618", Offset = "0x9DC618")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC618", Offset = "0x9DC618")]
			public float farBlurRadius;

			[Token(Token = "0x1700006D")]
			public static FocusSettings defaultSettings
			{
				[Token(Token = "0x600027B")]
				[Address(RVA = "0x175BC64", Offset = "0x175BC64", VA = "0x175BC64")]
				get
				{
					return default(FocusSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000CB")]
		public struct BokehTextureSettings
		{
			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC670", Offset = "0x9DC670")]
			public Texture2D texture;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC6A8", Offset = "0x9DC6A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC6A8", Offset = "0x9DC6A8")]
			public float scale;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC700", Offset = "0x9DC700")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC700", Offset = "0x9DC700")]
			public float intensity;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC75C", Offset = "0x9DC75C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC75C", Offset = "0x9DC75C")]
			public float threshold;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC7B4", Offset = "0x9DC7B4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC7B4", Offset = "0x9DC7B4")]
			public float spawnHeuristic;

			[Token(Token = "0x1700006E")]
			public static BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0x175BC84", Offset = "0x175BC84", VA = "0x175BC84")]
				get
				{
					return default(BokehTextureSettings);
				}
			}
		}

		[Token(Token = "0x40001E6")]
		private const float kMaxBlur = 40f;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GlobalSettings settings;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FocusSettings focus;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public BokehTextureSettings bokehTexture;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material m_FilmicDepthOfFieldMaterial;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material m_MedianFilterMaterial;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material m_TextureBokehMaterial;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_ComputeBufferPoints;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private QualitySettings m_CurrentQualitySettings;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float m_LastApertureOrientation;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector4 m_OctogonalBokehDirection1;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector4 m_OctogonalBokehDirection2;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector4 m_OctogonalBokehDirection3;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector4 m_OctogonalBokehDirection4;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector4 m_HexagonalBokehDirection1;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector4 m_HexagonalBokehDirection2;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Vector4 m_HexagonalBokehDirection3;

		[Token(Token = "0x17000027")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1758DF4", Offset = "0x1758DF4", VA = "0x1758DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1758E8C", Offset = "0x1758E8C", VA = "0x1758E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1758F24", Offset = "0x1758F24", VA = "0x1758F24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1758FBC", Offset = "0x1758FBC", VA = "0x1758FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x175904C", Offset = "0x175904C", VA = "0x175904C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x17590DC", Offset = "0x17590DC", VA = "0x17590DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x175916C", Offset = "0x175916C", VA = "0x175916C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x175924C", Offset = "0x175924C", VA = "0x175924C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x175AFFC", Offset = "0x175AFFC", VA = "0x175AFFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x17592C8", Offset = "0x17592C8", VA = "0x17592C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17597F0", Offset = "0x17597F0", VA = "0x17597F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1759A80", Offset = "0x1759A80", VA = "0x1759A80")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1759FDC", Offset = "0x1759FDC", VA = "0x1759FDC")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x175B3E4", Offset = "0x175B3E4", VA = "0x175B3E4")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x175B71C", Offset = "0x175B71C", VA = "0x175B71C")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x175B284", Offset = "0x175B284", VA = "0x175B284")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1759CC0", Offset = "0x1759CC0", VA = "0x1759CC0")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1759970", Offset = "0x1759970", VA = "0x1759970")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1759424", Offset = "0x1759424", VA = "0x1759424")]
		private void ComputeBlurDirections(bool force)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x175BB88", Offset = "0x175BB88", VA = "0x175BB88")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x175B0DC", Offset = "0x175B0DC", VA = "0x175B0DC")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x175BA90", Offset = "0x175BA90", VA = "0x175BA90")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x175BBAC", Offset = "0x175BBAC", VA = "0x175BBAC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9824", Offset = "0x9D9824")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9824", Offset = "0x9D9824")]
	public class LensAberrations : MonoBehaviour
	{
		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9BAC", Offset = "0x9D9BAC")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x175D600", Offset = "0x175D600", VA = "0x175D600")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9BC0", Offset = "0x9D9BC0")]
		public class AdvancedSetting : Attribute
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0x175D5F8", Offset = "0x175D5F8", VA = "0x175D5F8")]
			public AdvancedSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public struct DistortionSettings
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC80C", Offset = "0x9DC80C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC80C", Offset = "0x9DC80C")]
			public float amount;

			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC868", Offset = "0x9DC868")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC868", Offset = "0x9DC868")]
			public float centerX;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC8BC", Offset = "0x9DC8BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC8BC", Offset = "0x9DC8BC")]
			public float centerY;

			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC910", Offset = "0x9DC910")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC910", Offset = "0x9DC910")]
			public float amountX;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC964", Offset = "0x9DC964")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC964", Offset = "0x9DC964")]
			public float amountY;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DC9B8", Offset = "0x9DC9B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DC9B8", Offset = "0x9DC9B8")]
			public float scale;

			[Token(Token = "0x1700006F")]
			public static DistortionSettings defaultSettings
			{
				[Token(Token = "0x600027F")]
				[Address(RVA = "0x175D518", Offset = "0x175D518", VA = "0x175D518")]
				get
				{
					return default(DistortionSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000CF")]
		public struct VignetteSettings
		{
			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9DCA10", Offset = "0x9DCA10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCA10", Offset = "0x9DCA10")]
			public Color color;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCA60", Offset = "0x9DCA60")]
			public Vector2 center;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCA98", Offset = "0x9DCA98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCA98", Offset = "0x9DCA98")]
			public float intensity;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCAEC", Offset = "0x9DCAEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCAEC", Offset = "0x9DCAEC")]
			public float smoothness;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AdvancedSetting]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCB44", Offset = "0x9DCB44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCB44", Offset = "0x9DCB44")]
			public float roundness;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCBA8", Offset = "0x9DCBA8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCBA8", Offset = "0x9DCBA8")]
			public float blur;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCBFC", Offset = "0x9DCBFC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCBFC", Offset = "0x9DCBFC")]
			public float desaturate;

			[Token(Token = "0x17000070")]
			public static VignetteSettings defaultSettings
			{
				[Token(Token = "0x6000280")]
				[Address(RVA = "0x175D530", Offset = "0x175D530", VA = "0x175D530")]
				get
				{
					return default(VignetteSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000D0")]
		public struct ChromaticAberrationSettings
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9DCC50", Offset = "0x9DCC50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCC50", Offset = "0x9DCC50")]
			public Color color;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCCA0", Offset = "0x9DCCA0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCCA0", Offset = "0x9DCCA0")]
			public float amount;

			[Token(Token = "0x17000071")]
			public static ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x6000281")]
				[Address(RVA = "0x175D5C4", Offset = "0x175D5C4", VA = "0x175D5C4")]
				get
				{
					return default(ChromaticAberrationSettings);
				}
			}
		}

		[Token(Token = "0x20000D1")]
		private enum Pass
		{
			[Token(Token = "0x4000480")]
			BlurPrePass,
			[Token(Token = "0x4000481")]
			Chroma,
			[Token(Token = "0x4000482")]
			Distort,
			[Token(Token = "0x4000483")]
			Vignette,
			[Token(Token = "0x4000484")]
			ChromaDistort,
			[Token(Token = "0x4000485")]
			ChromaVignette,
			[Token(Token = "0x4000486")]
			DistortVignette,
			[Token(Token = "0x4000487")]
			ChromaDistortVignette
		}

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SettingsGroup]
		public DistortionSettings distortion;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SettingsGroup]
		public VignetteSettings vignette;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material m_Material;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x17000030")]
		public Shader shader
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x175C5E0", Offset = "0x175C5E0", VA = "0x175C5E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public Material material
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x175C678", Offset = "0x175C678", VA = "0x175C678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x175C708", Offset = "0x175C708", VA = "0x175C708")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x175C790", Offset = "0x175C790", VA = "0x175C790")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x175C850", Offset = "0x175C850", VA = "0x175C850")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x175D4A0", Offset = "0x175D4A0", VA = "0x175D4A0")]
		public LensAberrations()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D98BC", Offset = "0x9D98BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D98BC", Offset = "0x9D98BC")]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000489")]
			High = 0,
			[Token(Token = "0x400048A")]
			Low = 2
		}

		[Token(Token = "0x20000D3")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x400048C")]
			PhysicallyBased,
			[Token(Token = "0x400048D")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public struct SSRSettings
		{
			[Token(Token = "0x20000F1")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9C6C", Offset = "0x9D9C6C")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x1760918", Offset = "0x1760918", VA = "0x1760918")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Layout]
			public ReflectionSettings reflectionSettings;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Layout]
			public IntensitySettings intensitySettings;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Layout]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x17000072")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x6000282")]
				[Address(RVA = "0x17607FC", Offset = "0x17607FC", VA = "0x17607FC")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000D5")]
		public struct IntensitySettings
		{
			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCD2C", Offset = "0x9DCD2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCD2C", Offset = "0x9DCD2C")]
			public float reflectionMultiplier;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCD80", Offset = "0x9DCD80")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCD80", Offset = "0x9DCD80")]
			public float fadeDistance;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCDD8", Offset = "0x9DCDD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCDD8", Offset = "0x9DCDD8")]
			public float fresnelFade;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCE2C", Offset = "0x9DCE2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCE2C", Offset = "0x9DCE2C")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCE84", Offset = "0x9DCE84")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCEBC", Offset = "0x9DCEBC")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCEF4", Offset = "0x9DCEF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCEF4", Offset = "0x9DCEF4")]
			public float maxDistance;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCF50", Offset = "0x9DCF50")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCF50", Offset = "0x9DCF50")]
			public int iterationCount;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCFA8", Offset = "0x9DCFA8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCFA8", Offset = "0x9DCFA8")]
			public int stepSize;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DCFFC", Offset = "0x9DCFFC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DCFFC", Offset = "0x9DCFFC")]
			public float widthModifier;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD054", Offset = "0x9DD054")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD054", Offset = "0x9DD054")]
			public float reflectionBlur;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD0AC", Offset = "0x9DD0AC")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD0E4", Offset = "0x9DD0E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD0E4", Offset = "0x9DD0E4")]
			public float intensity;
		}

		[Token(Token = "0x20000D8")]
		private enum PassIndex
		{
			[Token(Token = "0x40004A0")]
			RayTraceStep,
			[Token(Token = "0x40004A1")]
			CompositeFinal,
			[Token(Token = "0x40004A2")]
			Blur,
			[Token(Token = "0x40004A3")]
			CompositeSSR,
			[Token(Token = "0x40004A4")]
			MinMipGeneration,
			[Token(Token = "0x40004A5")]
			HitPointToReflections,
			[Token(Token = "0x40004A6")]
			BilateralKeyPack,
			[Token(Token = "0x40004A7")]
			BlitDepthAsCSZ,
			[Token(Token = "0x40004A8")]
			PoissonBlur
		}

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB3FC", Offset = "0x9DB3FC")]
		private bool highlightSuppression;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB434", Offset = "0x9DB434")]
		private bool traceBehindObjects;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB46C", Offset = "0x9DB46C")]
		private bool treatBackfaceHitAsMiss;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DB4A4", Offset = "0x9DB4A4")]
		private bool bilateralUpsample;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_Material;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Camera m_Camera;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CommandBuffer m_CommandBuffer;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int kNormalAndRoughnessTexture;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int kHitPointTexture;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] kReflectionTextures;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int kFilteredReflections;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static int kBlurTexture;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int kFinalReflectionTexture;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static int kTempTexture;

		[Token(Token = "0x17000032")]
		public Shader shader
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x175E8F8", Offset = "0x175E8F8", VA = "0x175E8F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public Material material
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x175E990", Offset = "0x175E990", VA = "0x175E990")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Camera camera_
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x175EA20", Offset = "0x175EA20", VA = "0x175EA20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x175EAB8", Offset = "0x175EAB8", VA = "0x175EAB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x175EDFC", Offset = "0x175EDFC", VA = "0x175EDFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x175EF18", Offset = "0x175EF18", VA = "0x175EF18")]
		public void OnPreRender()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1760758", Offset = "0x1760758", VA = "0x1760758")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9D9964", Offset = "0x9D9964")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9D9964", Offset = "0x9D9964")]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9D9BD4", Offset = "0x9D9BD4")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1763F20", Offset = "0x1763F20", VA = "0x1763F20")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x20000DA")]
		public class IndentedGroup : PropertyAttribute
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1763F18", Offset = "0x1763F18", VA = "0x1763F18")]
			public IndentedGroup()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		public class ChannelMixer : PropertyAttribute
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1763A34", Offset = "0x1763A34", VA = "0x1763A34")]
			public ChannelMixer()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		public class ColorWheelGroup : PropertyAttribute
		{
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int minSizePerWheel;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int maxSizePerWheel;

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1763CA4", Offset = "0x1763CA4", VA = "0x1763CA4")]
			public ColorWheelGroup()
			{
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1763CB8", Offset = "0x1763CB8", VA = "0x1763CB8")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		public class Curve : PropertyAttribute
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color color;

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1763CFC", Offset = "0x1763CFC", VA = "0x1763CFC")]
			public Curve()
			{
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1763D30", Offset = "0x1763D30", VA = "0x1763D30")]
			public Curve(float r, float g, float b, float a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public struct EyeAdaptationSettings
		{
			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DD138", Offset = "0x9DD138")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD138", Offset = "0x9DD138")]
			public float middleGrey;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD188", Offset = "0x9DD188")]
			public float min;

			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD1C0", Offset = "0x9DD1C0")]
			public float max;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DD1F8", Offset = "0x9DD1F8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD1F8", Offset = "0x9DD1F8")]
			public float speed;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD248", Offset = "0x9DD248")]
			public bool showDebug;

			[Token(Token = "0x17000073")]
			public static EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x600028B")]
				[Address(RVA = "0x17638EC", Offset = "0x17638EC", VA = "0x17638EC")]
				get
				{
					return default(EyeAdaptationSettings);
				}
			}
		}

		[Token(Token = "0x20000DF")]
		public enum Tonemapper
		{
			[Token(Token = "0x40004B3")]
			ACES,
			[Token(Token = "0x40004B4")]
			Curve,
			[Token(Token = "0x40004B5")]
			Hable,
			[Token(Token = "0x40004B6")]
			HejlDawson,
			[Token(Token = "0x40004B7")]
			Photographic,
			[Token(Token = "0x40004B8")]
			Reinhard,
			[Token(Token = "0x40004B9")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD280", Offset = "0x9DD280")]
			public Tonemapper tonemapper;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x9DD2B8", Offset = "0x9DD2B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD2B8", Offset = "0x9DD2B8")]
			public float exposure;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD308", Offset = "0x9DD308")]
			public AnimationCurve curve;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD340", Offset = "0x9DD340")]
			public float neutralBlackIn;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD360", Offset = "0x9DD360")]
			public float neutralWhiteIn;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD378", Offset = "0x9DD378")]
			public float neutralBlackOut;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD398", Offset = "0x9DD398")]
			public float neutralWhiteOut;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD3B0", Offset = "0x9DD3B0")]
			public float neutralWhiteLevel;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD3CC", Offset = "0x9DD3CC")]
			public float neutralWhiteClip;

			[Token(Token = "0x17000074")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x600028C")]
				[Address(RVA = "0x176390C", Offset = "0x176390C", VA = "0x176390C")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public struct LUTSettings
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD3E4", Offset = "0x9DD3E4")]
			public Texture texture;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD41C", Offset = "0x9DD41C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD41C", Offset = "0x9DD41C")]
			public float contribution;

			[Token(Token = "0x17000075")]
			public static LUTSettings defaultSettings
			{
				[Token(Token = "0x600028D")]
				[Address(RVA = "0x1763A04", Offset = "0x1763A04", VA = "0x1763A04")]
				get
				{
					return default(LUTSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9DD470", Offset = "0x9DD470")]
			public Color shadows;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9DD484", Offset = "0x9DD484")]
			public Color midtones;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9DD498", Offset = "0x9DD498")]
			public Color highlights;

			[Token(Token = "0x17000076")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x600028E")]
				[Address(RVA = "0x1763B94", Offset = "0x1763B94", VA = "0x1763B94")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public struct BasicsSettings
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD4AC", Offset = "0x9DD4AC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD4AC", Offset = "0x9DD4AC")]
			public float temperatureShift;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD500", Offset = "0x9DD500")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD500", Offset = "0x9DD500")]
			public float tint;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD554", Offset = "0x9DD554")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD554", Offset = "0x9DD554")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD554", Offset = "0x9DD554")]
			public float hue;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD5B8", Offset = "0x9DD5B8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD5B8", Offset = "0x9DD5B8")]
			public float saturation;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD60C", Offset = "0x9DD60C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD60C", Offset = "0x9DD60C")]
			public float vibrance;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD660", Offset = "0x9DD660")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD660", Offset = "0x9DD660")]
			public float value;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD6B4", Offset = "0x9DD6B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD6B4", Offset = "0x9DD6B4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD6B4", Offset = "0x9DD6B4")]
			public float contrast;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD718", Offset = "0x9DD718")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD718", Offset = "0x9DD718")]
			public float gain;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9DD770", Offset = "0x9DD770")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD770", Offset = "0x9DD770")]
			public float gamma;

			[Token(Token = "0x17000077")]
			public static BasicsSettings defaultSettings
			{
				[Token(Token = "0x600028F")]
				[Address(RVA = "0x1763A14", Offset = "0x1763A14", VA = "0x1763A14")]
				get
				{
					return default(BasicsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int currentChannel;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3[] channels;

			[Token(Token = "0x17000078")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x6000290")]
				[Address(RVA = "0x1763A3C", Offset = "0x1763A3C", VA = "0x1763A3C")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public struct CurvesSettings
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "Curve", RVA = "0x9DD7C8", Offset = "0x9DD7C8")]
			public AnimationCurve master;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "Curve", RVA = "0x9DD7D8", Offset = "0x9DD7D8")]
			public AnimationCurve red;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "Curve", RVA = "0x9DD7F8", Offset = "0x9DD7F8")]
			public AnimationCurve green;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "Curve", RVA = "0x9DD818", Offset = "0x9DD818")]
			public AnimationCurve blue;

			[Token(Token = "0x17000079")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x6000291")]
				[Address(RVA = "0x1763C20", Offset = "0x1763C20", VA = "0x1763C20")]
				get
				{
					return default(CurvesSettings);
				}
			}

			[Token(Token = "0x1700007A")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x6000292")]
				[Address(RVA = "0x1763DC8", Offset = "0x1763DC8", VA = "0x1763DC8")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x20000E6")]
		public enum ColorGradingPrecision
		{
			[Token(Token = "0x40004DA")]
			Normal = 0x10,
			[Token(Token = "0x40004DB")]
			High = 0x20
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public struct ColorGradingSettings
		{
			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD838", Offset = "0x9DD838")]
			public ColorGradingPrecision precision;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD870", Offset = "0x9DD870")]
			[AttributeAttribute(Name = "ColorWheelGroup", RVA = "0x9DD870", Offset = "0x9DD870")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD8A8", Offset = "0x9DD8A8")]
			[IndentedGroup]
			public BasicsSettings basics;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD8E0", Offset = "0x9DD8E0")]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD918", Offset = "0x9DD918")]
			[IndentedGroup]
			public CurvesSettings curves;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x9DD950", Offset = "0x9DD950")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD950", Offset = "0x9DD950")]
			public bool useDithering;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9DD99C", Offset = "0x9DD99C")]
			public bool showDebug;

			[Token(Token = "0x1700007B")]
			public static ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x6000293")]
				[Address(RVA = "0x1763958", Offset = "0x1763958", VA = "0x1763958")]
				get
				{
					return default(ColorGradingSettings);
				}
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0xAA6E50", Offset = "0xAA6E50", VA = "0xAA6E50")]
			internal void Reset()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		private enum Pass
		{
			[Token(Token = "0x40004E5")]
			LutGen,
			[Token(Token = "0x40004E6")]
			AdaptationLog,
			[Token(Token = "0x40004E7")]
			AdaptationExpBlend,
			[Token(Token = "0x40004E8")]
			AdaptationExp,
			[Token(Token = "0x40004E9")]
			TonemappingOff,
			[Token(Token = "0x40004EA")]
			TonemappingACES,
			[Token(Token = "0x40004EB")]
			TonemappingCurve,
			[Token(Token = "0x40004EC")]
			TonemappingHable,
			[Token(Token = "0x40004ED")]
			TonemappingHejlDawson,
			[Token(Token = "0x40004EE")]
			TonemappingPhotographic,
			[Token(Token = "0x40004EF")]
			TonemappingReinhard,
			[Token(Token = "0x40004F0")]
			TonemappingNeutral,
			[Token(Token = "0x40004F1")]
			AdaptationDebug
		}

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Texture2D m_IdentityLut;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RenderTexture m_InternalLut;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Texture2D m_CurveTexture;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Texture2D m_TonemapperCurve;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float m_TonemapperCurveRange;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Material m_Material;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB5DC", Offset = "0x9DB5DC")]
		private bool <validRenderTextureFormat>k__BackingField;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DB5EC", Offset = "0x9DB5EC")]
		private bool <validUserLutSize>k__BackingField;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		private bool m_Dirty;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		private bool m_TonemapperDirty;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private RenderTexture m_SmallAdaptiveRt;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		[Token(Token = "0x17000035")]
		public EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x1760920", Offset = "0x1760920", VA = "0x1760920")]
			get
			{
				return default(EyeAdaptationSettings);
			}
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x1760934", Offset = "0x1760934", VA = "0x1760934")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public TonemappingSettings tonemapping
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x1760948", Offset = "0x1760948", VA = "0x1760948")]
			get
			{
				return default(TonemappingSettings);
			}
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x1760964", Offset = "0x1760964", VA = "0x1760964")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public ColorGradingSettings colorGrading
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x176098C", Offset = "0x176098C", VA = "0x176098C")]
			get
			{
				return default(ColorGradingSettings);
			}
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x176099C", Offset = "0x176099C", VA = "0x176099C")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public LUTSettings lut
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x17609D8", Offset = "0x17609D8", VA = "0x17609D8")]
			get
			{
				return default(LUTSettings);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x17609EC", Offset = "0x17609EC", VA = "0x17609EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		private Texture2D identityLut
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x1760A00", Offset = "0x1760A00", VA = "0x1760A00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1760DBC", Offset = "0x1760DBC", VA = "0x1760DBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x1760F9C", Offset = "0x1760F9C", VA = "0x1760F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x1761128", Offset = "0x1761128", VA = "0x1761128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public Shader shader
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x17612EC", Offset = "0x17612EC", VA = "0x17612EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Material material
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1761384", Offset = "0x1761384", VA = "0x1761384")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1761414", Offset = "0x1761414", VA = "0x1761414")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public int lutSize
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1760AE8", Offset = "0x1760AE8", VA = "0x1760AE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000041")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1761434", Offset = "0x1761434", VA = "0x1761434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAE4", Offset = "0x9DDAE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x176143C", Offset = "0x176143C", VA = "0x176143C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDAF4", Offset = "0x9DDAF4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool validUserLutSize
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1761448", Offset = "0x1761448", VA = "0x1761448")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDB04", Offset = "0x9DDB04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1761450", Offset = "0x1761450", VA = "0x1761450")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9DDB14", Offset = "0x9DDB14")]
			private set
			{
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x17609CC", Offset = "0x17609CC", VA = "0x17609CC")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1760980", Offset = "0x1760980", VA = "0x1760980")]
		public void SetTonemapperDirty()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x176145C", Offset = "0x176145C", VA = "0x176145C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x17614B0", Offset = "0x17614B0", VA = "0x17614B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1761730", Offset = "0x1761730", VA = "0x1761730")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1760AF0", Offset = "0x1760AF0", VA = "0x1760AF0")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x176173C", Offset = "0x176173C", VA = "0x176173C")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1761768", Offset = "0x1761768", VA = "0x1761768")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1761828", Offset = "0x1761828", VA = "0x1761828")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1761910", Offset = "0x1761910", VA = "0x1761910")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1761A00", Offset = "0x1761A00", VA = "0x1761A00")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1761C68", Offset = "0x1761C68", VA = "0x1761C68")]
		private void GenCurveTexture()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1761ED4", Offset = "0x1761ED4", VA = "0x1761ED4")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1761FB0", Offset = "0x1761FB0", VA = "0x1761FB0")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x17620B0", Offset = "0x17620B0", VA = "0x17620B0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x17622C4", Offset = "0x17622C4", VA = "0x17622C4")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x17636D0", Offset = "0x17636D0", VA = "0x17636D0")]
		public Texture2D BakeLUT()
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1763848", Offset = "0x1763848", VA = "0x1763848")]
		public TonemappingColorGrading()
		{
		}
	}
}
namespace wvr
{
	[Token(Token = "0x2000041")]
	public class Interop
	{
		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1BDD4E0", Offset = "0x1BDD4E0", VA = "0x1BDD4E0")]
		public static extern bool WVR_PollEventQueue(ref WVR_Event_t e);

		[PreserveSig]
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1BDD588", Offset = "0x1BDD588", VA = "0x1BDD588")]
		public static extern int WVR_GetInputDeviceCapability(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1BDD638", Offset = "0x1BDD638", VA = "0x1BDD638")]
		public static extern WVR_AnalogType WVR_GetInputDeviceAnalogType(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1BDD6E8", Offset = "0x1BDD6E8", VA = "0x1BDD6E8")]
		public static extern bool WVR_GetInputDeviceState(WVR_DeviceType type, uint inputMask, ref uint buttons, ref uint touches, [In][Out] WVR_AnalogState_t[] analogArray, uint analogArrayCount);

		[PreserveSig]
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1BDD7D8", Offset = "0x1BDD7D8", VA = "0x1BDD7D8")]
		public static extern int WVR_GetInputTypeCount(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1BDD888", Offset = "0x1BDD888", VA = "0x1BDD888")]
		public static extern bool WVR_GetInputButtonState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1BDD940", Offset = "0x1BDD940", VA = "0x1BDD940")]
		public static extern bool WVR_GetInputTouchState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1BDD9F8", Offset = "0x1BDD9F8", VA = "0x1BDD9F8")]
		public static extern WVR_Axis_t WVR_GetInputAnalogAxis(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1BDDAA8", Offset = "0x1BDDAA8", VA = "0x1BDDAA8")]
		public static extern void WVR_GetPoseState(WVR_DeviceType type, WVR_PoseOriginModel originModel, uint predictedMilliSec, ref WVR_PoseState_t poseState);

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1BDDCD0", Offset = "0x1BDDCD0", VA = "0x1BDDCD0")]
		public static extern void WVR_GetSyncPose(WVR_PoseOriginModel originModel, [In][Out] WVR_DevicePosePair_t[] poseArray, uint pairArrayCount);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1BDDE70", Offset = "0x1BDDE70", VA = "0x1BDDE70")]
		public static extern bool WVR_IsDeviceConnected(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1BDDF18", Offset = "0x1BDDF18", VA = "0x1BDDF18")]
		public static extern void WVR_TriggerVibrator(WVR_DeviceType type, WVR_InputId id, ushort durationMicroSec);

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1BDDFD0", Offset = "0x1BDDFD0", VA = "0x1BDDFD0")]
		public static extern void WVR_InAppRecenter(WVR_RecenterType recenterType);

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1BDE070", Offset = "0x1BDE070", VA = "0x1BDE070")]
		public static extern void WVR_SetNeckModelEnabled(bool enabled);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1BDE110", Offset = "0x1BDE110", VA = "0x1BDE110")]
		public static extern void WVR_SetNeckModel(WVR_SimulationType simulationType);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1BDE1B0", Offset = "0x1BDE1B0", VA = "0x1BDE1B0")]
		public static extern void WVR_SetArmModel(WVR_SimulationType simulationType);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1BDE250", Offset = "0x1BDE250", VA = "0x1BDE250")]
		public static extern void WVR_SetArmSticky(bool stickyArm);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1BDE2F0", Offset = "0x1BDE2F0", VA = "0x1BDE2F0")]
		public static extern bool WVR_SetInputRequest(WVR_DeviceType type, WVR_InputAttribute_t[] request, uint size);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1BDE3B8", Offset = "0x1BDE3B8", VA = "0x1BDE3B8")]
		public static extern bool WVR_GetInputMappingPair(WVR_DeviceType type, WVR_InputId destination, ref WVR_InputMappingPair_t pair);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1BDE478", Offset = "0x1BDE478", VA = "0x1BDE478")]
		public static extern uint WVR_GetInputMappingTable(WVR_DeviceType type, [In][Out] WVR_InputMappingPair_t[] table, uint size);

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1BDE538", Offset = "0x1BDE538", VA = "0x1BDE538")]
		public static extern WVR_Arena_t WVR_GetArena();

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1BDE5CC", Offset = "0x1BDE5CC", VA = "0x1BDE5CC")]
		public static extern bool WVR_SetArena(ref WVR_Arena_t arena);

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1BDE674", Offset = "0x1BDE674", VA = "0x1BDE674")]
		public static extern WVR_ArenaVisible WVR_GetArenaVisible();

		[PreserveSig]
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x1BDE704", Offset = "0x1BDE704", VA = "0x1BDE704")]
		public static extern void WVR_SetArenaVisible(WVR_ArenaVisible config);

		[PreserveSig]
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1BDE7A4", Offset = "0x1BDE7A4", VA = "0x1BDE7A4")]
		public static extern bool WVR_IsOverArenaRange();

		[PreserveSig]
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1BDE83C", Offset = "0x1BDE83C", VA = "0x1BDE83C")]
		public static extern float WVR_GetDeviceBatteryPercentage(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1BDE8DC", Offset = "0x1BDE8DC", VA = "0x1BDE8DC")]
		public static extern WVR_BatteryStatus WVR_GetBatteryStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1BDE97C", Offset = "0x1BDE97C", VA = "0x1BDE97C")]
		public static extern WVR_ChargeStatus WVR_GetChargeStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1BDEA1C", Offset = "0x1BDEA1C", VA = "0x1BDEA1C")]
		public static extern WVR_BatteryTemperatureStatus WVR_GetBatteryTemperatureStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1BDEABC", Offset = "0x1BDEABC", VA = "0x1BDEABC")]
		public static extern float WVR_GetBatteryTemperature(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1BDEB5C", Offset = "0x1BDEB5C", VA = "0x1BDEB5C")]
		public static extern WVR_InitError WVR_Init(WVR_AppType eType);

		[PreserveSig]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1BDEBFC", Offset = "0x1BDEBFC", VA = "0x1BDEBFC")]
		public static extern void WVR_Quit();

		[PreserveSig]
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x1BDEC8C", Offset = "0x1BDEC8C", VA = "0x1BDEC8C")]
		public static extern IntPtr WVR_GetInitErrorString(WVR_InitError error);

		[PreserveSig]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1BDED2C", Offset = "0x1BDED2C", VA = "0x1BDED2C")]
		public static extern uint WVR_GetWaveRuntimeVersion();

		[PreserveSig]
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1BDEDBC", Offset = "0x1BDEDBC", VA = "0x1BDEDBC")]
		public static extern uint WVR_GetWaveSDKVersion();

		[PreserveSig]
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1BDEE4C", Offset = "0x1BDEE4C", VA = "0x1BDEE4C")]
		public static extern bool WVR_IsInputFocusCapturedBySystem();

		[PreserveSig]
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1BDEEE4", Offset = "0x1BDEEE4", VA = "0x1BDEEE4")]
		internal static extern WVR_RenderError WVR_RenderInit(ref WVR_RenderInitParams_t param);

		[PreserveSig]
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1BDEF84", Offset = "0x1BDEF84", VA = "0x1BDEF84")]
		internal static extern bool WVR_SetPerformanceLevels(WVR_PerfLevel cpuLevel, WVR_PerfLevel gpuLevel);

		[PreserveSig]
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1BDF03C", Offset = "0x1BDF03C", VA = "0x1BDF03C")]
		public static extern bool WVR_StartCamera(ref WVR_CameraInfo_t info);

		[PreserveSig]
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1BDF0E4", Offset = "0x1BDF0E4", VA = "0x1BDF0E4")]
		public static extern void WVR_StopCamera();

		[PreserveSig]
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x1BDF174", Offset = "0x1BDF174", VA = "0x1BDF174")]
		public static extern bool WVR_UpdateTexture(uint textureid);

		[PreserveSig]
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1BDF21C", Offset = "0x1BDF21C", VA = "0x1BDF21C")]
		public static extern bool WVR_GetCameraIntrinsic(WVR_CameraPosition position, ref WVR_CameraIntrinsic_t intrinsic);

		[PreserveSig]
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1BDF2D4", Offset = "0x1BDF2D4", VA = "0x1BDF2D4")]
		public static extern bool WVR_IsDeviceSuspend(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1BDF37C", Offset = "0x1BDF37C", VA = "0x1BDF37C")]
		public static extern void WVR_ConvertMatrixQuaternion(ref WVR_Matrix4f_t mat, ref WVR_Quatf_t quat, bool m2q);

		[PreserveSig]
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1BDF434", Offset = "0x1BDF434", VA = "0x1BDF434")]
		public static extern WVR_NumDoF WVR_GetDegreeOfFreedom(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1BDF4D4", Offset = "0x1BDF4D4", VA = "0x1BDF4D4")]
		public static extern void WVR_SetParameters(WVR_DeviceType type, IntPtr pchValue);

		[PreserveSig]
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1BDF584", Offset = "0x1BDF584", VA = "0x1BDF584")]
		public static extern uint WVR_GetParameters(WVR_DeviceType type, IntPtr pchValue, IntPtr retValue, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1BDF64C", Offset = "0x1BDF64C", VA = "0x1BDF64C")]
		public static extern WVR_DeviceType WVR_GetDefaultControllerRole();

		[PreserveSig]
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1BDF6DC", Offset = "0x1BDF6DC", VA = "0x1BDF6DC")]
		public static extern bool WVR_SetInteractionMode(WVR_InteractionMode mode);

		[PreserveSig]
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1BDF784", Offset = "0x1BDF784", VA = "0x1BDF784")]
		public static extern WVR_InteractionMode WVR_GetInteractionMode();

		[PreserveSig]
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1BDF814", Offset = "0x1BDF814", VA = "0x1BDF814")]
		public static extern bool WVR_SetGazeTriggerType(WVR_GazeTriggerType type);

		[PreserveSig]
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1BDF8BC", Offset = "0x1BDF8BC", VA = "0x1BDF8BC")]
		public static extern WVR_GazeTriggerType WVR_GetGazeTriggerType();

		[PreserveSig]
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1BDF94C", Offset = "0x1BDF94C", VA = "0x1BDF94C")]
		public static extern bool WVR_GetDeviceErrorState(WVR_DeviceType dev_type, WVR_DeviceErrorState error_state);

		[PreserveSig]
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1BDFA04", Offset = "0x1BDFA04", VA = "0x1BDFA04")]
		public static extern void WVR_GetRenderTargetSize(ref uint width, ref uint height);

		[PreserveSig]
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1BDFAB4", Offset = "0x1BDFAB4", VA = "0x1BDFAB4")]
		public static extern WVR_Matrix4f_t WVR_GetProjection(WVR_Eye eye, float near, float far);

		[PreserveSig]
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1BDFB7C", Offset = "0x1BDFB7C", VA = "0x1BDFB7C")]
		public static extern void WVR_GetClippingPlaneBoundary(WVR_Eye eye, ref float left, ref float right, ref float top, ref float bottom);

		[PreserveSig]
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1BDFC4C", Offset = "0x1BDFC4C", VA = "0x1BDFC4C")]
		public static extern void WVR_SetOverfillRatio(float ratioX, float ratioY);

		[PreserveSig]
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1BDFCF8", Offset = "0x1BDFCF8", VA = "0x1BDFCF8")]
		public static extern WVR_Matrix4f_t WVR_GetTransformFromEyeToHead(WVR_Eye eye, WVR_NumDoF dof);

		[PreserveSig]
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1BDFDB0", Offset = "0x1BDFDB0", VA = "0x1BDFDB0")]
		public static extern WVR_SubmitError WVR_SubmitFrame(WVR_Eye eye, ref WVR_TextureParams_t param, ref WVR_PoseState_t pose, WVR_SubmitExtend extendMethod);

		[PreserveSig]
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1BDFFE0", Offset = "0x1BDFFE0", VA = "0x1BDFFE0")]
		public static extern bool WVR_RequestScreenshot(uint width, uint height, WVR_ScreenshotMode mode, IntPtr filename);

		[PreserveSig]
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1BE00B0", Offset = "0x1BE00B0", VA = "0x1BE00B0")]
		public static extern void WVR_RenderMask(WVR_Eye eye);

		[PreserveSig]
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1BE0150", Offset = "0x1BE0150", VA = "0x1BE0150")]
		public static extern bool WVR_GetRenderProps(ref WVR_RenderProps_t props);

		[PreserveSig]
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1BE0234", Offset = "0x1BE0234", VA = "0x1BE0234")]
		public static extern IntPtr WVR_ObtainTextureQueue(WVR_TextureTarget target, WVR_TextureFormat format, WVR_TextureType type, uint width, uint height, int level);

		[PreserveSig]
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1BE0314", Offset = "0x1BE0314", VA = "0x1BE0314")]
		public static extern uint WVR_GetTextureQueueLength(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1BE03B4", Offset = "0x1BE03B4", VA = "0x1BE03B4")]
		public static extern WVR_TextureParams_t WVR_GetTexture(IntPtr handle, int index);

		[PreserveSig]
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1BE0464", Offset = "0x1BE0464", VA = "0x1BE0464")]
		public static extern int WVR_GetAvailableTextureIndex(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1BE0504", Offset = "0x1BE0504", VA = "0x1BE0504")]
		public static extern void WVR_ReleaseTextureQueue(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1BE05A4", Offset = "0x1BE05A4", VA = "0x1BE05A4")]
		public static extern bool WVR_IsRenderFoveationSupport();

		[PreserveSig]
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1BE063C", Offset = "0x1BE063C", VA = "0x1BE063C")]
		public static extern void WVR_RenderFoveation(bool enable);

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1BE06DC", Offset = "0x1BE06DC", VA = "0x1BE06DC")]
		public Interop()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public enum WVR_AppType
	{
		[Token(Token = "0x4000224")]
		WVR_AppType_VRContent = 1,
		[Token(Token = "0x4000225")]
		WVR_AppType_NonVRContent
	}
	[Token(Token = "0x2000043")]
	public enum WVR_InitError
	{
		[Token(Token = "0x4000227")]
		WVR_InitError_None,
		[Token(Token = "0x4000228")]
		WVR_InitError_Unknown,
		[Token(Token = "0x4000229")]
		WVR_InitError_NotInitialized
	}
	[Token(Token = "0x2000044")]
	public enum WVR_EventType
	{
		[Token(Token = "0x400022B")]
		WVR_EventType_Quit = 1000,
		[Token(Token = "0x400022C")]
		WVR_EventType_SystemInteractionModeChanged = 1001,
		[Token(Token = "0x400022D")]
		WVR_EventType_SystemGazeTriggerTypeChanged = 1002,
		[Token(Token = "0x400022E")]
		WVR_EventType_TrackingModeChanged = 1003,
		[Token(Token = "0x400022F")]
		WVR_EventType_DeviceConnected = 2000,
		[Token(Token = "0x4000230")]
		WVR_EventType_DeviceDisconnected = 2001,
		[Token(Token = "0x4000231")]
		WVR_EventType_DeviceStatusUpdate = 2002,
		[Token(Token = "0x4000232")]
		WVR_EventType_DeviceSuspend = 2003,
		[Token(Token = "0x4000233")]
		WVR_EventType_DeviceResume = 2004,
		[Token(Token = "0x4000234")]
		WVR_EventType_IpdChanged = 2005,
		[Token(Token = "0x4000235")]
		WVR_EventType_DeviceRoleChanged = 2006,
		[Token(Token = "0x4000236")]
		WVR_EventType_BatteryStatusUpdate = 2007,
		[Token(Token = "0x4000237")]
		WVR_EventType_ChargeStatusUpdate = 2008,
		[Token(Token = "0x4000238")]
		WVR_EventType_DeviceErrorStatusUpdate = 2009,
		[Token(Token = "0x4000239")]
		WVR_EventType_BatteryTemperatureStatusUpdate = 2010,
		[Token(Token = "0x400023A")]
		WVR_EventType_RecenterSuccess = 2011,
		[Token(Token = "0x400023B")]
		WVR_EventType_RecenterFail = 2012,
		[Token(Token = "0x400023C")]
		WVR_EventType_RecenterSuccess3DoF = 2013,
		[Token(Token = "0x400023D")]
		WVR_EventType_RecenterFail3DoF = 2014,
		[Token(Token = "0x400023E")]
		WVR_EventType_ButtonPressed = 3000,
		[Token(Token = "0x400023F")]
		WVR_EventType_ButtonUnpressed = 3001,
		[Token(Token = "0x4000240")]
		WVR_EventType_TouchTapped = 3002,
		[Token(Token = "0x4000241")]
		WVR_EventType_TouchUntapped = 3003,
		[Token(Token = "0x4000242")]
		WVR_EventType_LeftToRightSwipe = 3004,
		[Token(Token = "0x4000243")]
		WVR_EventType_RightToLeftSwipe = 3005,
		[Token(Token = "0x4000244")]
		WVR_EventType_DownToUpSwipe = 3006,
		[Token(Token = "0x4000245")]
		WVR_EventType_UpToDownSwipe = 3007
	}
	[Token(Token = "0x2000045")]
	public enum WVR_PeripheralQuality
	{
		[Token(Token = "0x4000247")]
		Low,
		[Token(Token = "0x4000248")]
		Middle,
		[Token(Token = "0x4000249")]
		High
	}
	[Token(Token = "0x2000046")]
	public enum WVR_DeviceType
	{
		[Token(Token = "0x400024B")]
		WVR_DeviceType_Invalid,
		[Token(Token = "0x400024C")]
		WVR_DeviceType_HMD,
		[Token(Token = "0x400024D")]
		WVR_DeviceType_Controller_Right,
		[Token(Token = "0x400024E")]
		WVR_DeviceType_Controller_Left
	}
	[Token(Token = "0x2000047")]
	public enum WVR_RecenterType
	{
		[Token(Token = "0x4000250")]
		WVR_RecenterType_Disabled,
		[Token(Token = "0x4000251")]
		WVR_RecenterType_YawOnly,
		[Token(Token = "0x4000252")]
		WVR_RecenterType_YawAndPosition,
		[Token(Token = "0x4000253")]
		WVR_RecenterType_RotationAndPosition
	}
	[Token(Token = "0x2000048")]
	public enum WVR_InputType
	{
		[Token(Token = "0x4000255")]
		WVR_InputType_Button = 1,
		[Token(Token = "0x4000256")]
		WVR_InputType_Touch = 2,
		[Token(Token = "0x4000257")]
		WVR_InputType_Analog = 4
	}
	[Token(Token = "0x2000049")]
	public enum WVR_BatteryStatus
	{
		[Token(Token = "0x4000259")]
		WVR_BatteryStatus_Unknown,
		[Token(Token = "0x400025A")]
		WVR_BatteryStatus_Normal,
		[Token(Token = "0x400025B")]
		WVR_BatteryStatus_Low,
		[Token(Token = "0x400025C")]
		WVR_BatteryStatus_UltraLow
	}
	[Token(Token = "0x200004A")]
	public enum WVR_ChargeStatus
	{
		[Token(Token = "0x400025E")]
		WVR_ChargeStatus_Unknown,
		[Token(Token = "0x400025F")]
		WVR_ChargeStatus_Discharging,
		[Token(Token = "0x4000260")]
		WVR_ChargeStatus_Charging,
		[Token(Token = "0x4000261")]
		WVR_ChargeStatus_Full
	}
	[Token(Token = "0x200004B")]
	public enum WVR_BatteryTemperatureStatus
	{
		[Token(Token = "0x4000263")]
		WVR_BatteryTemperature_Unknown,
		[Token(Token = "0x4000264")]
		WVR_BatteryTemperature_Normal,
		[Token(Token = "0x4000265")]
		WVR_BatteryTemperature_Overheat,
		[Token(Token = "0x4000266")]
		WVR_BatteryTemperature_UltraOverheat
	}
	[Token(Token = "0x200004C")]
	public enum WVR_DeviceErrorStatus
	{
		[Token(Token = "0x4000268")]
		WVR_DeviceErrorStatus_None = 0,
		[Token(Token = "0x4000269")]
		WVR_DeviceErrorStatus_BatteryOverheat = 1,
		[Token(Token = "0x400026A")]
		WVR_DeviceErrorStatus_BatteryOverheatRestore = 2,
		[Token(Token = "0x400026B")]
		WVR_DeviceErrorStatus_BatteryOvervoltage = 4,
		[Token(Token = "0x400026C")]
		WVR_DeviceErrorStatus_BatteryOvervoltageRestore = 8,
		[Token(Token = "0x400026D")]
		WVR_DeviceErrorStatus_DeviceConnectFail = 0x10,
		[Token(Token = "0x400026E")]
		WVR_DeviceErrorStatus_DeviceConnectRestore = 0x20,
		[Token(Token = "0x400026F")]
		WVR_DeviceErrorStatus_DeviceLostTracking = 0x40,
		[Token(Token = "0x4000270")]
		WVR_DeviceErrorStatus_DeviceLostTrackingRestore = 0x80,
		[Token(Token = "0x4000271")]
		WVR_DeviceErrorStatus_ChargeFail = 0x100,
		[Token(Token = "0x4000272")]
		WVR_DeviceErrorStatus_ChargeRestore = 0x200
	}
	[Token(Token = "0x200004D")]
	public enum WVR_DeviceErrorState
	{
		[Token(Token = "0x4000274")]
		WVR_DeviceErrorState_None,
		[Token(Token = "0x4000275")]
		WVR_DeviceErrorState_BatteryOverheat,
		[Token(Token = "0x4000276")]
		WVR_DeviceErrorState_BatteryOvervoltage,
		[Token(Token = "0x4000277")]
		WVR_DeviceErrorState_DeviceConnectFail,
		[Token(Token = "0x4000278")]
		WVR_DeviceErrorState_DeviceLostTracking,
		[Token(Token = "0x4000279")]
		WVR_DeviceErrorState_ChargeFail
	}
	[Token(Token = "0x200004E")]
	public enum WVR_InputId
	{
		[Token(Token = "0x400027B")]
		WVR_InputId_0 = 0,
		[Token(Token = "0x400027C")]
		WVR_InputId_1 = 1,
		[Token(Token = "0x400027D")]
		WVR_InputId_2 = 2,
		[Token(Token = "0x400027E")]
		WVR_InputId_3 = 3,
		[Token(Token = "0x400027F")]
		WVR_InputId_4 = 4,
		[Token(Token = "0x4000280")]
		WVR_InputId_5 = 5,
		[Token(Token = "0x4000281")]
		WVR_InputId_6 = 6,
		[Token(Token = "0x4000282")]
		WVR_InputId_7 = 7,
		[Token(Token = "0x4000283")]
		WVR_InputId_8 = 8,
		[Token(Token = "0x4000284")]
		WVR_InputId_9 = 9,
		[Token(Token = "0x4000285")]
		WVR_InputId_15 = 15,
		[Token(Token = "0x4000286")]
		WVR_InputId_16 = 16,
		[Token(Token = "0x4000287")]
		WVR_InputId_17 = 17,
		[Token(Token = "0x4000288")]
		WVR_InputId_18 = 18,
		[Token(Token = "0x4000289")]
		WVR_InputId_Alias1_System = 0,
		[Token(Token = "0x400028A")]
		WVR_InputId_Alias1_Menu = 1,
		[Token(Token = "0x400028B")]
		WVR_InputId_Alias1_Grip = 2,
		[Token(Token = "0x400028C")]
		WVR_InputId_Alias1_DPad_Left = 3,
		[Token(Token = "0x400028D")]
		WVR_InputId_Alias1_DPad_Up = 4,
		[Token(Token = "0x400028E")]
		WVR_InputId_Alias1_DPad_Right = 5,
		[Token(Token = "0x400028F")]
		WVR_InputId_Alias1_DPad_Down = 6,
		[Token(Token = "0x4000290")]
		WVR_InputId_Alias1_Volume_Up = 7,
		[Token(Token = "0x4000291")]
		WVR_InputId_Alias1_Volume_Down = 8,
		[Token(Token = "0x4000292")]
		WVR_InputId_Alias1_Digital_Trigger = 9,
		[Token(Token = "0x4000293")]
		WVR_InputId_Alias1_Enter = 15,
		[Token(Token = "0x4000294")]
		WVR_InputId_Alias1_Touchpad = 16,
		[Token(Token = "0x4000295")]
		WVR_InputId_Alias1_Trigger = 17,
		[Token(Token = "0x4000296")]
		WVR_InputId_Alias1_Thumbstick = 18,
		[Token(Token = "0x4000297")]
		WVR_InputId_Max = 32
	}
	[Token(Token = "0x200004F")]
	public enum WVR_AnalogType
	{
		[Token(Token = "0x4000299")]
		WVR_AnalogType_None,
		[Token(Token = "0x400029A")]
		WVR_AnalogType_2D,
		[Token(Token = "0x400029B")]
		WVR_AnalogType_1D
	}
	[Token(Token = "0x2000050")]
	public enum WVR_PoseOriginModel
	{
		[Token(Token = "0x400029D")]
		WVR_PoseOriginModel_OriginOnHead,
		[Token(Token = "0x400029E")]
		WVR_PoseOriginModel_OriginOnGround,
		[Token(Token = "0x400029F")]
		WVR_PoseOriginModel_OriginOnTrackingObserver,
		[Token(Token = "0x40002A0")]
		WVR_PoseOriginModel_OriginOnHead_3DoF
	}
	[Token(Token = "0x2000051")]
	public enum WVR_ArenaVisible
	{
		[Token(Token = "0x40002A2")]
		WVR_ArenaVisible_Auto,
		[Token(Token = "0x40002A3")]
		WVR_ArenaVisible_ForceOn,
		[Token(Token = "0x40002A4")]
		WVR_ArenaVisible_ForceOff
	}
	[Token(Token = "0x2000052")]
	public enum WVR_GraphicsApiType
	{
		[Token(Token = "0x40002A6")]
		WVR_GraphicsApiType_OpenGL = 1
	}
	[Token(Token = "0x2000053")]
	public enum WVR_ScreenshotMode
	{
		[Token(Token = "0x40002A8")]
		WVR_ScreenshotMode_Default,
		[Token(Token = "0x40002A9")]
		WVR_ScreenshotMode_Raw,
		[Token(Token = "0x40002AA")]
		WVR_ScreenshotMode_Distorted
	}
	[Token(Token = "0x2000054")]
	public enum WVR_SubmitError
	{
		[Token(Token = "0x40002AC")]
		WVR_SubmitError_None = 0,
		[Token(Token = "0x40002AD")]
		WVR_SubmitError_InvalidTexture = 400,
		[Token(Token = "0x40002AE")]
		WVR_SubmitError_ThreadStop = 401,
		[Token(Token = "0x40002AF")]
		WVR_SubmitError_BufferSubmitFailed = 402,
		[Token(Token = "0x40002B0")]
		WVR_SubmitError_Max = 65535
	}
	[Token(Token = "0x2000055")]
	public enum WVR_SubmitExtend
	{
		[Token(Token = "0x40002B2")]
		WVR_SubmitExtend_Default,
		[Token(Token = "0x40002B3")]
		WVR_SubmitExtend_DisableDistortion
	}
	[Token(Token = "0x2000056")]
	public enum WVR_Eye
	{
		[Token(Token = "0x40002B5")]
		WVR_Eye_Left,
		[Token(Token = "0x40002B6")]
		WVR_Eye_Right,
		[Token(Token = "0x40002B7")]
		WVR_Eye_Both,
		[Token(Token = "0x40002B8")]
		WVR_Eye_None
	}
	[Token(Token = "0x2000057")]
	public enum WVR_TextureTarget
	{
		[Token(Token = "0x40002BA")]
		WVR_TextureTarget_2D,
		[Token(Token = "0x40002BB")]
		WVR_TextureTarget_2D_ARRAY
	}
	[Token(Token = "0x2000058")]
	public enum WVR_TextureFormat
	{
		[Token(Token = "0x40002BD")]
		WVR_TextureFormat_RGBA
	}
	[Token(Token = "0x2000059")]
	public enum WVR_TextureType
	{
		[Token(Token = "0x40002BF")]
		WVR_TextureType_UnsignedByte
	}
	[Token(Token = "0x200005A")]
	public enum WVR_RenderError
	{
		[Token(Token = "0x40002C1")]
		WVR_RenderError_None = 0,
		[Token(Token = "0x40002C2")]
		WVR_RenderError_RuntimeInitFailed = 410,
		[Token(Token = "0x40002C3")]
		WVR_RenderError_ContextSetupFailed = 411,
		[Token(Token = "0x40002C4")]
		WVR_RenderError_DisplaySetupFailed = 412,
		[Token(Token = "0x40002C5")]
		WVR_RenderError_LibNotSupported = 413,
		[Token(Token = "0x40002C6")]
		WVR_RenderError_NullPtr = 414,
		[Token(Token = "0x40002C7")]
		WVR_RenderError_Max = 65535
	}
	[Token(Token = "0x200005B")]
	public enum WVR_RenderConfig
	{
		[Token(Token = "0x40002C9")]
		WVR_RenderConfig_Default = 0,
		[Token(Token = "0x40002CA")]
		WVR_RenderConfig_Direct_Mode = 1,
		[Token(Token = "0x40002CB")]
		WVR_RenderConfig_MSAA = 2,
		[Token(Token = "0x40002CC")]
		WVR_RenderConfig_sRGB = 4,
		[Token(Token = "0x40002CD")]
		WVR_RenderConfig_Vertical_Sync = 16,
		[Token(Token = "0x40002CE")]
		WVR_RenderConfig_Timewarp = 256,
		[Token(Token = "0x40002CF")]
		WVR_RenderConfig_Timewarp_Asynchronous = 768
	}
	[Token(Token = "0x200005C")]
	public enum WVR_CameraImageType
	{
		[Token(Token = "0x40002D1")]
		WVR_CameraImageType_Invalid,
		[Token(Token = "0x40002D2")]
		WVR_CameraImageType_SingleEye,
		[Token(Token = "0x40002D3")]
		WVR_CameraImageType_DualEye
	}
	[Token(Token = "0x200005D")]
	public enum WVR_CameraImageFormat
	{
		[Token(Token = "0x40002D5")]
		WVR_CameraImageFormat_Invalid,
		[Token(Token = "0x40002D6")]
		WVR_CameraImageFormat_YUV_420,
		[Token(Token = "0x40002D7")]
		WVR_CameraImageFormat_Grayscale
	}
	[Token(Token = "0x200005E")]
	public enum WVR_CameraPosition
	{
		[Token(Token = "0x40002D9")]
		WVR_CameraPosition_Invalid,
		[Token(Token = "0x40002DA")]
		WVR_CameraPosition_left,
		[Token(Token = "0x40002DB")]
		WVR_CameraPosition_Right
	}
	[Token(Token = "0x200005F")]
	public enum WVR_OverlayError
	{
		[Token(Token = "0x40002DD")]
		WVR_OverlayError_None = 0,
		[Token(Token = "0x40002DE")]
		WVR_OverlayError_UnknownOverlay = 10,
		[Token(Token = "0x40002DF")]
		WVR_OverlayError_OverlayUnavailable = 11,
		[Token(Token = "0x40002E0")]
		WVR_OverlayError_InvalidParameter = 20
	}
	[Token(Token = "0x2000060")]
	public enum WVR_OverlayTransformType
	{
		[Token(Token = "0x40002E2")]
		WVR_OverlayTransformType_None,
		[Token(Token = "0x40002E3")]
		WVR_OverlayTransformType_Absolute,
		[Token(Token = "0x40002E4")]
		WVR_OverlayTransformType_Fixed
	}
	[Token(Token = "0x2000061")]
	public enum WVR_NumDoF
	{
		[Token(Token = "0x40002E6")]
		WVR_NumDoF_3DoF,
		[Token(Token = "0x40002E7")]
		WVR_NumDoF_6DoF
	}
	[Token(Token = "0x2000062")]
	public enum WVR_ArenaShape
	{
		[Token(Token = "0x40002E9")]
		WVR_ArenaShape_None,
		[Token(Token = "0x40002EA")]
		WVR_ArenaShape_Rectangle,
		[Token(Token = "0x40002EB")]
		WVR_ArenaShape_Round
	}
	[Token(Token = "0x2000063")]
	public enum WVR_InteractionMode
	{
		[Token(Token = "0x40002ED")]
		WVR_InteractionMode_SystemDefault = 1,
		[Token(Token = "0x40002EE")]
		WVR_InteractionMode_Gaze,
		[Token(Token = "0x40002EF")]
		WVR_InteractionMode_Controller
	}
	[Token(Token = "0x2000064")]
	public enum WVR_GazeTriggerType
	{
		[Token(Token = "0x40002F1")]
		WVR_GazeTriggerType_Timeout = 1,
		[Token(Token = "0x40002F2")]
		WVR_GazeTriggerType_Button,
		[Token(Token = "0x40002F3")]
		WVR_GazeTriggerType_TimeoutButton
	}
	[Token(Token = "0x2000065")]
	public enum WVR_PerfLevel
	{
		[Token(Token = "0x40002F5")]
		WVR_PerfLevel_System,
		[Token(Token = "0x40002F6")]
		WVR_PerfLevel_Minimum,
		[Token(Token = "0x40002F7")]
		WVR_PerfLevel_Medium,
		[Token(Token = "0x40002F8")]
		WVR_PerfLevel_Maximum,
		[Token(Token = "0x40002F9")]
		WVR_PerfLevel_NumPerfLevels
	}
	[Token(Token = "0x2000066")]
	public enum WVR_SimulationType
	{
		[Token(Token = "0x40002FB")]
		WVR_SimulationType_Auto,
		[Token(Token = "0x40002FC")]
		WVR_SimulationType_ForceOn,
		[Token(Token = "0x40002FD")]
		WVR_SimulationType_ForceOff
	}
	[Token(Token = "0x2000067")]
	public struct WVR_RenderInitParams_t
	{
		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_GraphicsApiType graphicsApi;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong renderConfig;
	}
	[Token(Token = "0x2000068")]
	public struct WVR_Matrix4f_t
	{
		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m12;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m13;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m14;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m15;
	}
	[Token(Token = "0x2000069")]
	public struct WVR_Vector2f_t
	{
		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;
	}
	[Token(Token = "0x200006A")]
	public struct WVR_Vector3f_t
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;
	}
	[Token(Token = "0x200006B")]
	public struct WVR_CameraIntrinsic_t
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector2f_t focalLength;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Vector2f_t principalPoint;
	}
	[Token(Token = "0x200006C")]
	public struct WVR_CameraInfo_t
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CameraImageType imgType;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_CameraImageFormat imgFormat;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint width;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint height;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint size;
	}
	[Token(Token = "0x200006D")]
	public struct WVR_Quatf_t
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float w;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float x;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float y;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float z;
	}
	[StructLayout(2)]
	[Token(Token = "0x200006E")]
	public struct WVR_PoseState_t
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool IsValidPose;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_Matrix4f_t PoseMatrix;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public WVR_Vector3f_t Velocity;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public WVR_Vector3f_t AngularVelocity;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool Is6DoFPose;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long PoseTimestamp_ns;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public WVR_Vector3f_t Acceleration;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public WVR_Vector3f_t AngularAcceleration;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float PredictedMilliSec;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public WVR_PoseOriginModel OriginModel;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public WVR_Pose_t RawPose;
	}
	[StructLayout(2)]
	[Token(Token = "0x200006F")]
	public struct WVR_DevicePosePair_t
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceType type;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_PoseState_t pose;
	}
	[Token(Token = "0x2000070")]
	public struct WVR_TextureParams_t
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr id;
	}
	[Token(Token = "0x2000071")]
	public struct WVR_RenderProps_t
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float refreshRate;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool hasExternal;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float ipdMeter;
	}
	[Token(Token = "0x2000072")]
	public struct WVR_CommonEvent_t
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_EventType type;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long timestamp;
	}
	[Token(Token = "0x2000073")]
	public struct WVR_DeviceEvent_t
	{
		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WVR_DeviceType type;
	}
	[Token(Token = "0x2000074")]
	public struct WVR_InputEvent_t
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WVR_InputId inputId;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000075")]
	public struct WVR_Event_t
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputEvent_t input;
	}
	[Token(Token = "0x2000076")]
	public struct WVR_Axis_t
	{
		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000077")]
	public struct WVR_AnalogState_t
	{
		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputId id;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_AnalogType type;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Axis_t axis;
	}
	[Token(Token = "0x2000078")]
	public struct WVR_InputAttribute_t
	{
		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputId id;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint capability;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_AnalogType axis_type;
	}
	[Token(Token = "0x2000079")]
	public struct WVR_InputMappingPair_t
	{
		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputAttribute_t destination;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_InputAttribute_t source;
	}
	[StructLayout(2)]
	[Token(Token = "0x200007A")]
	public struct WVR_Pose_t
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector3f_t position;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_Quatf_t rotation;
	}
	[Token(Token = "0x200007B")]
	public struct WVR_OverlayPosition_t
	{
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x200007C")]
	public struct WVR_OverlayBlendColor_t
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float b;
	}
	[Token(Token = "0x200007D")]
	public struct WVR_OverlayTexture_t
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint textureId;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint width;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint height;
	}
	[Token(Token = "0x200007E")]
	public struct WVR_ArenaRectangle_t
	{
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float width;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float length;
	}
	[Token(Token = "0x200007F")]
	public struct WVR_ArenaRound_t
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float diameter;
	}
	[StructLayout(2)]
	[Token(Token = "0x2000080")]
	public struct WVR_ArenaArea_t
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRectangle_t rectangle;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRound_t round;
	}
	[Token(Token = "0x2000081")]
	public struct WVR_Arena_t
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaShape shape;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_ArenaArea_t area;
	}
	[Token(Token = "0x2000082")]
	public delegate void WVR_OverlayInputEventCallback(int overlayId, WVR_EventType type, WVR_InputId inputId);
	[Token(Token = "0x2000083")]
	public struct WVR_OverlayInputEvent_t
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int overlayId;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr callback;
	}
	[Token(Token = "0x2000084")]
	public struct WVR_RenderFoveationParams
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float focalX;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float focalY;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fovealFov;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_PeripheralQuality periQuality;
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x2000085")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x400035D")]
		Array = 1,
		[Token(Token = "0x400035E")]
		Class,
		[Token(Token = "0x400035F")]
		Value,
		[Token(Token = "0x4000360")]
		IntValue,
		[Token(Token = "0x4000361")]
		DoubleValue,
		[Token(Token = "0x4000362")]
		BoolValue,
		[Token(Token = "0x4000363")]
		FloatValue
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D9A0C", Offset = "0x9D9A0C")]
	public class JSONNode
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9BE8", Offset = "0x9D9BE8")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x1700007C")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000298")]
				[Address(RVA = "0x17543E0", Offset = "0x17543E0", VA = "0x17543E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029A")]
				[Address(RVA = "0x1754450", Offset = "0x1754450", VA = "0x1754450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x1752FBC", Offset = "0x1752FBC", VA = "0x1752FBC")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x17543C4", Offset = "0x17543C4", VA = "0x17543C4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x17543C8", Offset = "0x17543C8", VA = "0x17543C8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x17543E8", Offset = "0x17543E8", VA = "0x17543E8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x1754458", Offset = "0x1754458", VA = "0x1754458", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x17544F0", Offset = "0x17544F0", VA = "0x17544F0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9BF8", Offset = "0x9D9BF8")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x1700007E")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002A2")]
				[Address(RVA = "0x1754B28", Offset = "0x1754B28", VA = "0x1754B28", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x1754B98", Offset = "0x1754B98", VA = "0x1754B98", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029D")]
			[Address(RVA = "0x1753078", Offset = "0x1753078", VA = "0x1753078")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x17544F4", Offset = "0x17544F4", VA = "0x17544F4", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x17546EC", Offset = "0x17546EC", VA = "0x17546EC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x175462C", Offset = "0x175462C", VA = "0x175462C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x175456C", Offset = "0x175456C", VA = "0x175456C")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1754B30", Offset = "0x1754B30", VA = "0x1754B30", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x1754BA0", Offset = "0x1754BA0", VA = "0x1754BA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1754C50", Offset = "0x1754C50", VA = "0x1754C50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1752E60", Offset = "0x1752E60", VA = "0x1752E60", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1752E68", Offset = "0x1752E68", VA = "0x1752E68", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1752E6C", Offset = "0x1752E6C", VA = "0x1752E6C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1752E74", Offset = "0x1752E74", VA = "0x1752E74", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public virtual string Value
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1752E78", Offset = "0x1752E78", VA = "0x1752E78", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1752EC0", Offset = "0x1752EC0", VA = "0x1752EC0", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public virtual int Count
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1752EC4", Offset = "0x1752EC4", VA = "0x1752EC4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x1752F4C", Offset = "0x1752F4C", VA = "0x1752F4C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDB34", Offset = "0x9DDB34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1752FF4", Offset = "0x1752FF4", VA = "0x1752FF4")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDB98", Offset = "0x9DDB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public virtual int AsInt
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1753140", Offset = "0x1753140", VA = "0x1753140", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1753180", Offset = "0x1753180", VA = "0x1753180", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public virtual float AsFloat
		{
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x17531C0", Offset = "0x17531C0", VA = "0x17531C0", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x1753278", Offset = "0x1753278", VA = "0x1753278", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public virtual double AsDouble
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x17532B8", Offset = "0x17532B8", VA = "0x17532B8", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x175335C", Offset = "0x175335C", VA = "0x175335C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual bool AsBool
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x175339C", Offset = "0x175339C", VA = "0x175339C", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x1753464", Offset = "0x1753464", VA = "0x1753464", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x17534E8", Offset = "0x17534E8", VA = "0x17534E8", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x1753568", Offset = "0x1753568", VA = "0x1753568", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1752E5C", Offset = "0x1752E5C", VA = "0x1752E5C", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1752ECC", Offset = "0x1752ECC", VA = "0x1752ECC", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1752F34", Offset = "0x1752F34", VA = "0x1752F34", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1752F3C", Offset = "0x1752F3C", VA = "0x1752F3C", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1752F44", Offset = "0x1752F44", VA = "0x1752F44", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x17530B0", Offset = "0x17530B0", VA = "0x17530B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x17530F8", Offset = "0x17530F8", VA = "0x17530F8", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x17535E8", Offset = "0x17535E8", VA = "0x17535E8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x175364C", Offset = "0x175364C", VA = "0x175364C")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1751934", Offset = "0x1751934", VA = "0x1751934")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x175369C", Offset = "0x175369C", VA = "0x175369C")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x17536B8", Offset = "0x17536B8", VA = "0x17536B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x17528C4", Offset = "0x17528C4", VA = "0x17528C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1751048", Offset = "0x1751048", VA = "0x1751048")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x174E988", Offset = "0x174E988", VA = "0x174E988")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x17536C4", Offset = "0x17536C4", VA = "0x17536C4", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x17536C8", Offset = "0x17536C8", VA = "0x17536C8")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1753748", Offset = "0x1753748", VA = "0x1753748")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x17537BC", Offset = "0x17537BC", VA = "0x17537BC")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1753830", Offset = "0x1753830", VA = "0x1753830")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x17538A4", Offset = "0x17538A4", VA = "0x17538A4")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1753A28", Offset = "0x1753A28", VA = "0x1753A28")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1753BC4", Offset = "0x1753BC4", VA = "0x1753BC4")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1753F64", Offset = "0x1753F64", VA = "0x1753F64")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1753FD8", Offset = "0x1753FD8", VA = "0x1753FD8")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x175404C", Offset = "0x175404C", VA = "0x175404C")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x17540C0", Offset = "0x17540C0", VA = "0x17540C0")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x17541F0", Offset = "0x17541F0", VA = "0x17541F0")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x175430C", Offset = "0x175430C", VA = "0x175430C")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x174FCC4", Offset = "0x174FCC4", VA = "0x174FCC4")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D9A44", Offset = "0x9D9A44")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9C08", Offset = "0x9D9C08")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000080")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002AB")]
				[Address(RVA = "0x1750114", Offset = "0x1750114", VA = "0x1750114", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002AD")]
				[Address(RVA = "0x1750184", Offset = "0x1750184", VA = "0x1750184", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x174F658", Offset = "0x174F658", VA = "0x174F658")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x174FF2C", Offset = "0x174FF2C", VA = "0x174FF2C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x174FFA0", Offset = "0x174FFA0", VA = "0x174FFA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x174FF48", Offset = "0x174FF48", VA = "0x174FF48")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x175011C", Offset = "0x175011C", VA = "0x175011C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x175018C", Offset = "0x175018C", VA = "0x175018C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x175023C", Offset = "0x175023C", VA = "0x175023C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9C18", Offset = "0x9D9C18")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002B4")]
				[Address(RVA = "0x174FEB4", Offset = "0x174FEB4", VA = "0x174FEB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002B6")]
				[Address(RVA = "0x174FF24", Offset = "0x174FF24", VA = "0x174FF24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x174F704", Offset = "0x174F704", VA = "0x174F704")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x174FCCC", Offset = "0x174FCCC", VA = "0x174FCCC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x174FD40", Offset = "0x174FD40", VA = "0x174FD40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x174FCE8", Offset = "0x174FCE8", VA = "0x174FCE8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x174FEBC", Offset = "0x174FEBC", VA = "0x174FEBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x1700004F")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x174F104", Offset = "0x174F104", VA = "0x174F104", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x174F200", Offset = "0x174F200", VA = "0x174F200", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x174F2DC", Offset = "0x174F2DC", VA = "0x174F2DC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x174F340", Offset = "0x174F340", VA = "0x174F340", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public override int Count
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x174F3B0", Offset = "0x174F3B0", VA = "0x174F3B0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000052")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x174F5D4", Offset = "0x174F5D4", VA = "0x174F5D4", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDBFC", Offset = "0x9DDBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x174F410", Offset = "0x174F410", VA = "0x174F410", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x174F480", Offset = "0x174F480", VA = "0x174F480", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x174F55C", Offset = "0x174F55C", VA = "0x174F55C", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x174F690", Offset = "0x174F690", VA = "0x174F690", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDC60", Offset = "0x9DDC60")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x174F730", Offset = "0x174F730", VA = "0x174F730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x174F8FC", Offset = "0x174F8FC", VA = "0x174F8FC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x174FB28", Offset = "0x174FB28", VA = "0x174FB28", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x174FC54", Offset = "0x174FC54", VA = "0x174FC54")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D9A7C", Offset = "0x9D9A7C")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9C28", Offset = "0x9D9C28")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1750AF4", Offset = "0x1750AF4", VA = "0x1750AF4")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x17518C8", Offset = "0x17518C8", VA = "0x17518C8")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9C38", Offset = "0x9D9C38")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000084")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x60002BD")]
				[Address(RVA = "0x1751E70", Offset = "0x1751E70", VA = "0x1751E70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000085")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002BF")]
				[Address(RVA = "0x1751EE0", Offset = "0x1751EE0", VA = "0x1751EE0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x1750B80", Offset = "0x1750B80", VA = "0x1750B80")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1751C58", Offset = "0x1751C58", VA = "0x1751C58", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x1751CCC", Offset = "0x1751CCC", VA = "0x1751CCC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x1751C74", Offset = "0x1751C74", VA = "0x1751C74")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x1751E78", Offset = "0x1751E78", VA = "0x1751E78", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1751EE8", Offset = "0x1751EE8", VA = "0x1751EE8", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1751F98", Offset = "0x1751F98", VA = "0x1751F98", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D9C48", Offset = "0x9D9C48")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002C6")]
				[Address(RVA = "0x1751BE0", Offset = "0x1751BE0", VA = "0x1751BE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002C8")]
				[Address(RVA = "0x1751C50", Offset = "0x1751C50", VA = "0x1751C50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1750C2C", Offset = "0x1750C2C", VA = "0x1750C2C")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x17519CC", Offset = "0x17519CC", VA = "0x17519CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1751A40", Offset = "0x1751A40", VA = "0x1751A40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x17519E8", Offset = "0x17519E8", VA = "0x17519E8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1751BE8", Offset = "0x1751BE8", VA = "0x1751BE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000053")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1750240", Offset = "0x1750240", VA = "0x1750240", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1750348", Offset = "0x1750348", VA = "0x1750348", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x175041C", Offset = "0x175041C", VA = "0x175041C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x17504E0", Offset = "0x17504E0", VA = "0x17504E0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public override int Count
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x17505D0", Offset = "0x17505D0", VA = "0x17505D0", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000056")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x1750AFC", Offset = "0x1750AFC", VA = "0x1750AFC", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDCC4", Offset = "0x9DDCC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1750630", Offset = "0x1750630", VA = "0x1750630", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1750768", Offset = "0x1750768", VA = "0x1750768", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1750840", Offset = "0x1750840", VA = "0x1750840", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1750940", Offset = "0x1750940", VA = "0x1750940", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1750BB8", Offset = "0x1750BB8", VA = "0x1750BB8", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9DDD28", Offset = "0x9DDD28")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1750C58", Offset = "0x1750C58", VA = "0x1750C58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x17511D4", Offset = "0x17511D4", VA = "0x17511D4", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1751648", Offset = "0x1751648", VA = "0x1751648", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1751858", Offset = "0x1751858", VA = "0x1751858")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x17000057")]
		public override string Value
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1751F9C", Offset = "0x1751F9C", VA = "0x1751F9C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x1751FA4", Offset = "0x1751FA4", VA = "0x1751FA4", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1751FAC", Offset = "0x1751FAC", VA = "0x1751FAC")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1751FD8", Offset = "0x1751FD8", VA = "0x1751FD8")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x175201C", Offset = "0x175201C", VA = "0x175201C")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1752060", Offset = "0x1752060", VA = "0x1752060")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x175209C", Offset = "0x175209C", VA = "0x175209C")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x17520D8", Offset = "0x17520D8", VA = "0x17520D8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x175213C", Offset = "0x175213C", VA = "0x175213C", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x17521A0", Offset = "0x17521A0", VA = "0x17521A0", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9D9AB4", Offset = "0x9D9AB4")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x17000058")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x1752560", Offset = "0x1752560", VA = "0x1752560", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x17525C4", Offset = "0x17525C4", VA = "0x17525C4", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1752650", Offset = "0x1752650", VA = "0x1752650", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x17526C0", Offset = "0x17526C0", VA = "0x17526C0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public override int AsInt
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x175295C", Offset = "0x175295C", VA = "0x175295C", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x17529E0", Offset = "0x17529E0", VA = "0x17529E0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public override float AsFloat
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x1752A68", Offset = "0x1752A68", VA = "0x1752A68", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x1752AEC", Offset = "0x1752AEC", VA = "0x1752AEC", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public override double AsDouble
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x1752B74", Offset = "0x1752B74", VA = "0x1752B74", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x1752BF8", Offset = "0x1752BF8", VA = "0x1752BF8", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public override bool AsBool
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x1752C80", Offset = "0x1752C80", VA = "0x1752C80", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1752D04", Offset = "0x1752D04", VA = "0x1752D04", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x1752D8C", Offset = "0x1752D8C", VA = "0x1752D8C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x1752DF4", Offset = "0x1752DF4", VA = "0x1752DF4", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x174F1D4", Offset = "0x174F1D4", VA = "0x174F1D4")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1750310", Offset = "0x1750310", VA = "0x1750310")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x17524E4", Offset = "0x17524E4", VA = "0x17524E4")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1752754", Offset = "0x1752754", VA = "0x1752754", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x17527E0", Offset = "0x17527E0", VA = "0x17527E0", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1752874", Offset = "0x1752874", VA = "0x1752874")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x175288C", Offset = "0x175288C", VA = "0x175288C")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x17528A4", Offset = "0x17528A4", VA = "0x17528A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x17528BC", Offset = "0x17528BC", VA = "0x17528BC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x17528CC", Offset = "0x17528CC", VA = "0x17528CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x1752914", Offset = "0x1752914", VA = "0x1752914", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x200008B")]
	public static class JSON
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x174E984", Offset = "0x174E984", VA = "0x174E984")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
