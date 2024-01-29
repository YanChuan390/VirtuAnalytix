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
	[Address(RVA = "0x1648FB8", Offset = "0x1648FB8", VA = "0x1648FB8")]
	public static extern void InitInternal();

	[PreserveSig]
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1649050", Offset = "0x1649050", VA = "0x1649050")]
	public static extern void ShutdownInternal();

	[PreserveSig]
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x16490E8", Offset = "0x16490E8", VA = "0x16490E8")]
	public static extern bool IsInterfaceVersionValid([In] string targetInterfaceVersion);

	[PreserveSig]
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x16491B8", Offset = "0x16491B8", VA = "0x16491B8")]
	public static extern IntPtr GetInterfaceBindings([In] string targetInterfaceVersion);

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x164927C", Offset = "0x164927C", VA = "0x164927C")]
	public SparkInterop()
	{
	}
}
[Token(Token = "0x2000003")]
public class SparkSDK
{
	[Token(Token = "0x2000004")]
	private class SparkSDKContext
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private RightsManager _rightsManager;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x16493B4", Offset = "0x16493B4", VA = "0x16493B4")]
		public SparkSDKContext()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1654C34", Offset = "0x1654C34", VA = "0x1654C34")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1649464", Offset = "0x1649464", VA = "0x1649464")]
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
		[Address(RVA = "0x1649294", Offset = "0x1649294", VA = "0x1649294")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public static RightsManager Rights
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x16493E0", Offset = "0x16493E0", VA = "0x16493E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1649284", Offset = "0x1649284", VA = "0x1649284")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1649288", Offset = "0x1649288", VA = "0x1649288")]
	public static void Cleanup()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x164928C", Offset = "0x164928C", VA = "0x164928C")]
	public static bool IsInterfaceVersionValid(string targetInterfaceVersion)
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1649290", Offset = "0x1649290", VA = "0x1649290")]
	public static IntPtr GetInterfaceBindings(string targetInterfaceVersion)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1649534", Offset = "0x1649534", VA = "0x1649534")]
	public SparkSDK()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x28552C", Offset = "0x28552C")]
internal delegate void IntPtrCallback(IntPtr arg);
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x285540", Offset = "0x285540")]
internal delegate void StringCallback([In] string arg);
[Token(Token = "0x2000007")]
internal struct IRightsManager
{
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x285554", Offset = "0x285554")]
	public delegate void _CheckRights(string contentKey, IntPtrCallback handler);

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x285568", Offset = "0x285568")]
	public delegate void _StartTrackingUsage(string contentKey);

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x28557C", Offset = "0x28557C")]
	public delegate void _StopTrackingUsage(string contentKey);

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x285590", Offset = "0x285590")]
	public delegate void _GetTOS(string contentKey, StringCallback handler);

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x2855A4", Offset = "0x2855A4")]
	public delegate void _AcceptTOS(string contentKey);

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public _CheckRights CheckRights;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public _StartTrackingUsage StartTrackingUsage;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public _StopTrackingUsage StopTrackingUsage;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public _GetTOS GetTOS;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public _AcceptTOS AcceptTOS;
}
[Token(Token = "0x200000D")]
public struct RightsResponse
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public bool isUserEntitled;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public bool hasUserAcceptedTOS;
}
[Token(Token = "0x200000E")]
public class RightsManager
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2855B8", Offset = "0x2855B8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action<RightsResponse> callback;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public IntPtrCallback response;

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1654588", Offset = "0x1654588", VA = "0x1654588")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1654590", Offset = "0x1654590", VA = "0x1654590")]
		internal void <CheckRights>b__0(IntPtr arg)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2855C8", Offset = "0x2855C8")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Action<string> callback;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public StringCallback response;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x16547C4", Offset = "0x16547C4", VA = "0x16547C4")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x16547CC", Offset = "0x16547CC", VA = "0x16547CC")]
		internal void <GetTOS>b__0(string arg)
		{
		}
	}

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private IRightsManager FnTable;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<Delegate> _pendingDelegates;

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1341578", Offset = "0x1341578", VA = "0x1341578")]
	internal RightsManager(IntPtr interfacePtr)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x13416E4", Offset = "0x13416E4", VA = "0x13416E4")]
	public void CheckRights(string contentKey, Action<RightsResponse> callback)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x13418E8", Offset = "0x13418E8", VA = "0x13418E8")]
	public void StartTrackingUsage(string contentKey)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1341918", Offset = "0x1341918", VA = "0x1341918")]
	public void StopTrackingUsage(string contentKey)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1341948", Offset = "0x1341948", VA = "0x1341948")]
	public void GetTOS(string contentKey, Action<string> callback)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1341B40", Offset = "0x1341B40", VA = "0x1341B40")]
	public void AcceptTOS(string contentKey)
	{
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000011")]
	public enum AAMode
	{
		[Token(Token = "0x4000013")]
		FXAA2,
		[Token(Token = "0x4000014")]
		FXAA3Console,
		[Token(Token = "0x4000015")]
		FXAA1PresetA,
		[Token(Token = "0x4000016")]
		FXAA1PresetB,
		[Token(Token = "0x4000017")]
		NFAA,
		[Token(Token = "0x4000018")]
		SSAA,
		[Token(Token = "0x4000019")]
		DLAA
	}
	[Token(Token = "0x2000012")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2855D8", Offset = "0x2855D8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2855D8", Offset = "0x2855D8")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AAMode mode;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool showGeneratedNormals;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float offsetScale;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float blurRadius;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float edgeThresholdMin;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float edgeThreshold;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgeSharpness;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool dlaaSharp;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Shader ssaaShader;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material ssaa;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Shader dlaaShader;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material dlaa;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Shader nfaaShader;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material nfaa;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Shader shaderFXAAII;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material materialFXAAII;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x15B2848", Offset = "0x15B2848", VA = "0x15B2848")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x15B28BC", Offset = "0x15B28BC", VA = "0x15B28BC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x15B2A30", Offset = "0x15B2A30", VA = "0x15B2A30")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x15B3170", Offset = "0x15B3170", VA = "0x15B3170")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x28567C", Offset = "0x28567C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x28567C", Offset = "0x28567C")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000014")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x400004F")]
			Ghosting,
			[Token(Token = "0x4000050")]
			Anamorphic,
			[Token(Token = "0x4000051")]
			Combined
		}

		[Token(Token = "0x2000015")]
		public enum TweakMode
		{
			[Token(Token = "0x4000053")]
			Basic,
			[Token(Token = "0x4000054")]
			Complex
		}

		[Token(Token = "0x2000016")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x4000056")]
			Auto,
			[Token(Token = "0x4000057")]
			On,
			[Token(Token = "0x4000058")]
			Off
		}

		[Token(Token = "0x2000017")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x400005A")]
			Screen,
			[Token(Token = "0x400005B")]
			Add
		}

		[Token(Token = "0x2000018")]
		public enum BloomQuality
		{
			[Token(Token = "0x400005D")]
			Cheap,
			[Token(Token = "0x400005E")]
			High
		}

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TweakMode tweakMode;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool doHdr;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sepBlurSpread;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BloomQuality quality;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float bloomIntensity;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float bloomThreshold;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color bloomThresholdColor;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int bloomBlurIterations;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float flareRotation;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float hollyStretchWidth;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float lensflareIntensity;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareThreshold;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensFlareSaturation;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Material screenBlend;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x15B3F60", Offset = "0x15B3F60", VA = "0x15B3F60", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x15B4044", Offset = "0x15B4044", VA = "0x15B4044")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x15B5BF4", Offset = "0x15B5BF4", VA = "0x15B5BF4")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x15B57EC", Offset = "0x15B57EC", VA = "0x15B57EC")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x15B5448", Offset = "0x15B5448", VA = "0x15B5448")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x15B533C", Offset = "0x15B533C", VA = "0x15B533C")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x15B556C", Offset = "0x15B556C", VA = "0x15B556C")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x15B5CEC", Offset = "0x15B5CEC", VA = "0x15B5CEC")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000060")]
		Ghosting,
		[Token(Token = "0x4000061")]
		Anamorphic,
		[Token(Token = "0x4000062")]
		Combined
	}
	[Token(Token = "0x200001A")]
	public enum TweakMode34
	{
		[Token(Token = "0x4000064")]
		Basic,
		[Token(Token = "0x4000065")]
		Complex
	}
	[Token(Token = "0x200001B")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x4000067")]
		Auto,
		[Token(Token = "0x4000068")]
		On,
		[Token(Token = "0x4000069")]
		Off
	}
	[Token(Token = "0x200001C")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x400006B")]
		Screen,
		[Token(Token = "0x400006C")]
		Add
	}
	[Token(Token = "0x200001D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285720", Offset = "0x285720")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285720", Offset = "0x285720")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool doHdr;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sepBlurSpread;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float bloomIntensity;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float bloomThreshold;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int bloomBlurIterations;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool lensflares;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float hollyStretchWidth;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lensflareIntensity;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lensflareThreshold;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color flareColorA;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color flareColorB;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Color flareColorC;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Color flareColorD;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Shader vignetteShader;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material vignetteMaterial;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public Shader screenBlendShader;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material screenBlend;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x15B5E74", Offset = "0x15B5E74", VA = "0x15B5E74", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x15B5FD0", Offset = "0x15B5FD0", VA = "0x15B5FD0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x15B7678", Offset = "0x15B7678", VA = "0x15B7678")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x15B7294", Offset = "0x15B7294", VA = "0x15B7294")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x15B6F40", Offset = "0x15B6F40", VA = "0x15B6F40")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x15B70D0", Offset = "0x15B70D0", VA = "0x15B70D0")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x15B7748", Offset = "0x15B7748", VA = "0x15B7748")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2857C4", Offset = "0x2857C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2857C4", Offset = "0x2857C4")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x200001F")]
		public enum Resolution
		{
			[Token(Token = "0x4000098")]
			Low,
			[Token(Token = "0x4000099")]
			High
		}

		[Token(Token = "0x2000020")]
		public enum BlurType
		{
			[Token(Token = "0x400009B")]
			Standard,
			[Token(Token = "0x400009C")]
			Sgx
		}

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x286F88", Offset = "0x286F88")]
		public float threshold;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x286FA0", Offset = "0x286FA0")]
		public float intensity;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x286FBC", Offset = "0x286FBC")]
		public float blurSize;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Resolution resolution;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x286FD8", Offset = "0x286FD8")]
		public int blurIterations;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BlurType blurType;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Shader fastBloomShader;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material fastBloomMaterial;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x15B78B8", Offset = "0x15B78B8", VA = "0x15B78B8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x15B7924", Offset = "0x15B7924", VA = "0x15B7924")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x15B79DC", Offset = "0x15B79DC", VA = "0x15B79DC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x15B7F38", Offset = "0x15B7F38", VA = "0x15B7F38")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285868", Offset = "0x285868")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x286FF4", Offset = "0x286FF4")]
		public int iterations;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287010", Offset = "0x287010")]
		public float blurSpread;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Shader blurShader;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x17000003")]
		protected Material material
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x15B7F60", Offset = "0x15B7F60", VA = "0x15B7F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x15B80F0", Offset = "0x15B80F0", VA = "0x15B80F0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x15B8218", Offset = "0x15B8218", VA = "0x15B8218")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x15B8304", Offset = "0x15B8304", VA = "0x15B8304")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x15B8484", Offset = "0x15B8484", VA = "0x15B8484")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x15B85F0", Offset = "0x15B85F0", VA = "0x15B85F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x15B876C", Offset = "0x15B876C", VA = "0x15B876C")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2858B0", Offset = "0x2858B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2858B0", Offset = "0x2858B0")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x2000023")]
		public enum BlurType
		{
			[Token(Token = "0x40000A8")]
			StandardGauss,
			[Token(Token = "0x40000A9")]
			SgxGauss
		}

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287028", Offset = "0x287028")]
		public int downsample;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287040", Offset = "0x287040")]
		public float blurSize;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28705C", Offset = "0x28705C")]
		public int blurIterations;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BlurType blurType;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Shader blurShader;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material blurMaterial;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x15B878C", Offset = "0x15B878C", VA = "0x15B878C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x15B87F8", Offset = "0x15B87F8", VA = "0x15B87F8")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x15B88B0", Offset = "0x15B88B0", VA = "0x15B88B0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x15B8D78", Offset = "0x15B8D78", VA = "0x15B8D78")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285954", Offset = "0x285954")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285954", Offset = "0x285954")]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x2000025")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40000CB")]
			CameraMotion,
			[Token(Token = "0x40000CC")]
			LocalBlur,
			[Token(Token = "0x40000CD")]
			Reconstruction,
			[Token(Token = "0x40000CE")]
			ReconstructionDX11,
			[Token(Token = "0x40000CF")]
			ReconstructionDisc
		}

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool preview;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 previewScale;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float movementScale;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float rotationScale;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxVelocity;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minVelocity;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float velocityScale;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float softZDistance;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int velocityDownsample;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask excludeLayers;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GameObject tmpCam;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Shader shader;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Shader replacementClear;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material motionBlurMaterial;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture2D noiseTexture;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float jitter;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showVelocity;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float showVelocityScale;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int prevFrameCount;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool wasActive;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 prevFramePos;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Camera _camera;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x15B8D9C", Offset = "0x15B8D9C", VA = "0x15B8D9C")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x15B93D8", Offset = "0x15B93D8", VA = "0x15B93D8")]
		private new void Start()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x15B9770", Offset = "0x15B9770", VA = "0x15B9770")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x15B987C", Offset = "0x15B987C", VA = "0x15B987C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x15B9A54", Offset = "0x15B9A54", VA = "0x15B9A54", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x15B9B08", Offset = "0x15B9B08", VA = "0x15B9B08")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x15B9548", Offset = "0x15B9548", VA = "0x15B9548")]
		private void Remember()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x15BC7A0", Offset = "0x15BC7A0", VA = "0x15BC7A0")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x15BC710", Offset = "0x15BC710", VA = "0x15BC710")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x15BC794", Offset = "0x15BC794", VA = "0x15BC794")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x15BCD38", Offset = "0x15BCD38", VA = "0x15BCD38")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2859F8", Offset = "0x2859F8")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x2000027")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40000E9")]
			Simple,
			[Token(Token = "0x40000EA")]
			Advanced
		}

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AnimationCurve redChannel;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useDepthCorrection;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public AnimationCurve zCurve;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Material ccMaterial;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material ccDepthMaterial;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Texture2D zCurveTex;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float saturation;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool selectiveCc;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Color selectiveFromColor;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color selectiveToColor;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool updateTextures;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x15BCE7C", Offset = "0x15BCE7C", VA = "0x15BCE7C")]
		private new void Start()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x15BCE9C", Offset = "0x15BCE9C", VA = "0x15BCE9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x15BCEA0", Offset = "0x15BCEA0", VA = "0x15BCEA0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x15BD21C", Offset = "0x15BD21C", VA = "0x15BD21C")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x15BD6D4", Offset = "0x15BD6D4", VA = "0x15BD6D4")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x15BD6D8", Offset = "0x15BD6D8", VA = "0x15BD6D8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x15BDB9C", Offset = "0x15BDB9C", VA = "0x15BDB9C")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285A40", Offset = "0x285A40")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Shader shader;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Material material;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Texture3D converted3DLut;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string basedOnTempTex;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x15BE474", Offset = "0x15BE474", VA = "0x15BE474", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x15BE4E4", Offset = "0x15BE4E4", VA = "0x15BE4E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x15BE5B0", Offset = "0x15BE5B0", VA = "0x15BE5B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x15BE678", Offset = "0x15BE678", VA = "0x15BE678")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15BE940", Offset = "0x15BE940", VA = "0x15BE940")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15BEA48", Offset = "0x15BEA48", VA = "0x15BEA48")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15BEF74", Offset = "0x15BEF74", VA = "0x15BEF74")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x15BF230", Offset = "0x15BF230", VA = "0x15BF230")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285A88", Offset = "0x285A88")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Texture textureRamp;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x15BF298", Offset = "0x15BF298", VA = "0x15BF298")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x15BF380", Offset = "0x15BF380", VA = "0x15BF380")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285AD0", Offset = "0x285AD0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285AD0", Offset = "0x285AD0")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287078", Offset = "0x287078")]
		public float intensity;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287090", Offset = "0x287090")]
		public float threshold;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Material separableBlurMaterial;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2870AC", Offset = "0x2870AC")]
		public float blurSpread;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader separableBlurShader;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x15BF388", Offset = "0x15BF388", VA = "0x15BF388", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x15BF41C", Offset = "0x15BF41C", VA = "0x15BF41C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x15BF868", Offset = "0x15BF868", VA = "0x15BF868")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285B74", Offset = "0x285B74")]
	[ExecuteInEditMode]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2870C4", Offset = "0x2870C4")]
		public float adaptationSpeed;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2870E0", Offset = "0x2870E0")]
		public float limitMinimum;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2870F8", Offset = "0x2870F8")]
		public float limitMaximum;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int curAdaptIndex;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader shaderLum;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_materialLum;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shaderReduce;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Material m_materialReduce;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderApply;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Material m_materialApply;

		[Token(Token = "0x17000004")]
		protected Material materialLum
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x15BF880", Offset = "0x15BF880", VA = "0x15BF880")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		protected Material materialReduce
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x15BF978", Offset = "0x15BF978", VA = "0x15BF978")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		protected Material materialAdapt
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x15BFA70", Offset = "0x15BFA70", VA = "0x15BFA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		protected Material materialApply
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x15BFB68", Offset = "0x15BFB68", VA = "0x15BFB68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x15BFC60", Offset = "0x15BFC60", VA = "0x15BFC60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x15BFD20", Offset = "0x15BFD20", VA = "0x15BFD20")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x15BFEE8", Offset = "0x15BFEE8", VA = "0x15BFEE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x15C0190", Offset = "0x15C0190", VA = "0x15C0190")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x15C0444", Offset = "0x15C0444", VA = "0x15C0444")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x15C06E8", Offset = "0x15C06E8", VA = "0x15C06E8")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x200002C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285BBC", Offset = "0x285BBC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285BBC", Offset = "0x285BBC")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float intensity;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int softness;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float spread;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material blurMaterial;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader depthFetchShader;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Material depthFetchMaterial;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader creaseApplyShader;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x15C0780", Offset = "0x15C0780", VA = "0x15C0780", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x15C0840", Offset = "0x15C0840", VA = "0x15C0840")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x15C0CE0", Offset = "0x15C0CE0", VA = "0x15C0CE0")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285C60", Offset = "0x285C60")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285C60", Offset = "0x285C60")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x200002E")]
		public enum BlurType
		{
			[Token(Token = "0x4000127")]
			DiscBlur,
			[Token(Token = "0x4000128")]
			DX11
		}

		[Token(Token = "0x200002F")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x400012A")]
			Low,
			[Token(Token = "0x400012B")]
			Medium,
			[Token(Token = "0x400012C")]
			High
		}

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool visualizeFocus;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float focalLength;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float focalSize;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float aperture;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Transform focalTransform;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float maxBlurSize;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool highResolution;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BlurType blurType;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool nearBlur;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float foregroundOverlap;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader dofHdrShader;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material dofHdrMaterial;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader dx11BokehShader;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float dx11BokehThreshold;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float dx11BokehScale;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float dx11BokehIntensity;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float focalDistance01;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float internalBlurWidth;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Camera cachedCamera;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x15C3F98", Offset = "0x15C3F98", VA = "0x15C3F98", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x15C421C", Offset = "0x15C421C", VA = "0x15C421C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x15C42CC", Offset = "0x15C42CC", VA = "0x15C42CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x15C441C", Offset = "0x15C441C", VA = "0x15C441C")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x15C4050", Offset = "0x15C4050", VA = "0x15C4050")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x15C447C", Offset = "0x15C447C", VA = "0x15C447C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x15C45F8", Offset = "0x15C45F8", VA = "0x15C45F8")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x15C49F0", Offset = "0x15C49F0", VA = "0x15C49F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x15C69FC", Offset = "0x15C69FC", VA = "0x15C69FC")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285D04", Offset = "0x285D04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285D04", Offset = "0x285D04")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x2000031")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x4000159")]
			OnlyBackground = 1,
			[Token(Token = "0x400015A")]
			BackgroundAndForeground
		}

		[Token(Token = "0x2000032")]
		public enum DofResolution
		{
			[Token(Token = "0x400015C")]
			High = 2,
			[Token(Token = "0x400015D")]
			Medium,
			[Token(Token = "0x400015E")]
			Low
		}

		[Token(Token = "0x2000033")]
		public enum DofBlurriness
		{
			[Token(Token = "0x4000160")]
			Low = 1,
			[Token(Token = "0x4000161")]
			High = 2,
			[Token(Token = "0x4000162")]
			VeryHigh = 4
		}

		[Token(Token = "0x2000034")]
		public enum BokehDestination
		{
			[Token(Token = "0x4000164")]
			Background = 1,
			[Token(Token = "0x4000165")]
			Foreground,
			[Token(Token = "0x4000166")]
			BackgroundAndForeground
		}

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DofResolution resolution;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool simpleTweakMode;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float focalPoint;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float smoothness;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float focalZDistance;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalZStartCurve;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalZEndCurve;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float focalStartCurve;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float focalEndCurve;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float focalDistance01;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform objectFocus;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalSize;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DofBlurriness bluriness;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxBlurSpread;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Shader dofBlurShader;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material dofBlurMaterial;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Shader dofShader;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofMaterial;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool visualize;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float widthOverHeight;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float oneOverBaseSize;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool bokeh;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		public bool bokehSupport;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader bokehShader;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Texture2D bokehTexture;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float bokehScale;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float bokehIntensity;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float bokehThresholdContrast;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int bokehDownsample;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Material bokehMaterial;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Camera _camera;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private RenderTexture bokehSource;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x132CA68", Offset = "0x132CA68", VA = "0x132CA68")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x132D0F0", Offset = "0x132D0F0", VA = "0x132D0F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x132D468", Offset = "0x132D468", VA = "0x132D468")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x132D75C", Offset = "0x132D75C", VA = "0x132D75C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x132D80C", Offset = "0x132D80C", VA = "0x132D80C")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x132D988", Offset = "0x132D988", VA = "0x132D988")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x132D9A8", Offset = "0x132D9A8", VA = "0x132D9A8")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x132D9CC", Offset = "0x132D9CC", VA = "0x132D9CC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x132EE50", Offset = "0x132EE50", VA = "0x132EE50")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x132F85C", Offset = "0x132F85C", VA = "0x132F85C")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x132FE30", Offset = "0x132FE30", VA = "0x132FE30")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x132EC90", Offset = "0x132EC90", VA = "0x132EC90")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x132F1E8", Offset = "0x132F1E8", VA = "0x132F1E8")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x132FC48", Offset = "0x132FC48", VA = "0x132FC48")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x132E730", Offset = "0x132E730", VA = "0x132E730")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1330400", Offset = "0x1330400", VA = "0x1330400")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285DA8", Offset = "0x285DA8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285DA8", Offset = "0x285DA8")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x2000036")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000173")]
			TriangleDepthNormals,
			[Token(Token = "0x4000174")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000175")]
			SobelDepth,
			[Token(Token = "0x4000176")]
			SobelDepthThin,
			[Token(Token = "0x4000177")]
			TriangleLuminance
		}

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public EdgeDetectMode mode;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float sensitivityDepth;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float sensitivityNormals;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float lumThreshold;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float edgeExp;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float sampleDist;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float edgesOnly;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader edgeDetectShader;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x13305C8", Offset = "0x13305C8", VA = "0x13305C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1330760", Offset = "0x1330760", VA = "0x1330760")]
		private new void Start()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x133064C", Offset = "0x133064C", VA = "0x133064C")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x133076C", Offset = "0x133076C", VA = "0x133076C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1330770", Offset = "0x1330770", VA = "0x1330770")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1330A90", Offset = "0x1330A90", VA = "0x1330A90")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285E4C", Offset = "0x285E4C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285E4C", Offset = "0x285E4C")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287110", Offset = "0x287110")]
		public float strengthX;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287128", Offset = "0x287128")]
		public float strengthY;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Shader fishEyeShader;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1331950", Offset = "0x1331950", VA = "0x1331950", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x13319B0", Offset = "0x13319B0", VA = "0x13319B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1331B88", Offset = "0x1331B88", VA = "0x1331B88")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285EF0", Offset = "0x285EF0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285EF0", Offset = "0x285EF0")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287140", Offset = "0x287140")]
		public bool distanceFog;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287174", Offset = "0x287174")]
		public bool excludeFarPixels;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2871A8", Offset = "0x2871A8")]
		public bool useRadialDistance;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2871DC", Offset = "0x2871DC")]
		public bool heightFog;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287210", Offset = "0x287210")]
		public float height;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287244", Offset = "0x287244")]
		public float heightDensity;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287264", Offset = "0x287264")]
		public float startDistance;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Shader fogShader;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material fogMaterial;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1331B9C", Offset = "0x1331B9C", VA = "0x1331B9C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1331C00", Offset = "0x1331C00", VA = "0x1331C00")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x13326B8", Offset = "0x13326B8", VA = "0x13326B8")]
		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1332854", Offset = "0x1332854", VA = "0x1332854")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285F94", Offset = "0x285F94")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Texture textureRamp;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287298", Offset = "0x287298")]
		public float rampOffset;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1332878", Offset = "0x1332878", VA = "0x1332878")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1332AA4", Offset = "0x1332AA4", VA = "0x1332AA4")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x285FDC", Offset = "0x285FDC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x285FDC", Offset = "0x285FDC")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Shader shader;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Material m_Material;

		[Token(Token = "0x17000008")]
		protected Material material
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x13329AC", Offset = "0x13329AC", VA = "0x13329AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1332AB4", Offset = "0x1332AB4", VA = "0x1332AB4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1332B7C", Offset = "0x1332B7C", VA = "0x1332B7C", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1332AAC", Offset = "0x1332AAC", VA = "0x1332AAC")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286070", Offset = "0x286070")]
	public class ImageEffects
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1332C5C", Offset = "0x1332C5C", VA = "0x1332C5C")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1332F98", Offset = "0x1332F98", VA = "0x1332F98")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x289BC8", Offset = "0x289BC8")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1333018", Offset = "0x1333018", VA = "0x1333018")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x289BFC", Offset = "0x289BFC")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x13330A0", Offset = "0x13330A0", VA = "0x13330A0")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2860A4", Offset = "0x2860A4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2860A4", Offset = "0x2860A4")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2872B4", Offset = "0x2872B4")]
		public float blurAmount;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool extraBlur;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private RenderTexture accumTexture;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x133CE68", Offset = "0x133CE68", VA = "0x133CE68", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x133CEA4", Offset = "0x133CEA4", VA = "0x133CEA4", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x133CF28", Offset = "0x133CF28", VA = "0x133CF28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x133D3B4", Offset = "0x133D3B4", VA = "0x133D3B4")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286148", Offset = "0x286148")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286148", Offset = "0x286148")]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float intensityMultiplier;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float generalIntensity;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blackIntensity;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float whiteIntensity;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float midGrey;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool dx11Grain;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float softness;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool monochrome;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 intensities;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 tiling;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float monochromeTiling;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FilterMode filterMode;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader noiseShader;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Material noiseMaterial;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh mesh;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x133D3C8", Offset = "0x133D3C8", VA = "0x133D3C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x133D438", Offset = "0x133D438", VA = "0x133D438", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x133D4D0", Offset = "0x133D4D0", VA = "0x133D4D0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x133E060", Offset = "0x133E060", VA = "0x133E060")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, Mesh mesh, int passNr)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x133E43C", Offset = "0x133E43C", VA = "0x133E43C")]
		private static void BuildMesh(Mesh mesh, RenderTexture source, Texture2D noise)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x133EA84", Offset = "0x133EA84", VA = "0x133EA84")]
		private static void BuildMeshUV0(Mesh mesh, int width, int height, float noiseSize, int noiseWidth)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x133EC38", Offset = "0x133EC38", VA = "0x133EC38")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2861EC", Offset = "0x2861EC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2861EC", Offset = "0x2861EC")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool monochrome;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		private bool rgbFallback;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2872D0", Offset = "0x2872D0")]
		public float grainIntensityMin;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2872EC", Offset = "0x2872EC")]
		public float grainIntensityMax;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287308", Offset = "0x287308")]
		public float grainSize;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287328", Offset = "0x287328")]
		public float scratchIntensityMin;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287344", Offset = "0x287344")]
		public float scratchIntensityMax;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287360", Offset = "0x287360")]
		public float scratchFPS;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28737C", Offset = "0x28737C")]
		public float scratchJitter;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Texture grainTexture;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture scratchTexture;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Shader shaderRGB;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderYUV;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Material m_MaterialRGB;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_MaterialYUV;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float scratchTimeLeft;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float scratchX;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float scratchY;

		[Token(Token = "0x17000009")]
		protected Material material
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x133EE9C", Offset = "0x133EE9C", VA = "0x133EE9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x133ED04", Offset = "0x133ED04", VA = "0x133ED04")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x133F050", Offset = "0x133F050", VA = "0x133F050")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x133F170", Offset = "0x133F170", VA = "0x133F170")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x133F254", Offset = "0x133F254", VA = "0x133F254")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x133F6E0", Offset = "0x133F6E0", VA = "0x133F6E0")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286290", Offset = "0x286290")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		protected bool supportDX11;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
		protected bool isSupported;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Material> createdMaterials;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x132CB8C", Offset = "0x132CB8C", VA = "0x132CB8C")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x133F754", Offset = "0x133F754", VA = "0x133F754")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x133F9CC", Offset = "0x133F9CC", VA = "0x133F9CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x133F9D8", Offset = "0x133F9D8", VA = "0x133F9D8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x133F9DC", Offset = "0x133F9DC", VA = "0x133F9DC")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x133FAFC", Offset = "0x133FAFC", VA = "0x133FAFC")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x133FB04", Offset = "0x133FB04", VA = "0x133FB04", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x133FBE4", Offset = "0x133FBE4", VA = "0x133FBE4")]
		protected void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x132D244", Offset = "0x132D244", VA = "0x132D244")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x133FBF4", Offset = "0x133FBF4", VA = "0x133FBF4")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x133FC4C", Offset = "0x133FC4C", VA = "0x133FC4C")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x132D38C", Offset = "0x132D38C", VA = "0x132D38C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x133FC54", Offset = "0x133FC54", VA = "0x133FC54")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x133F730", Offset = "0x133F730", VA = "0x133F730")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x133FF88", Offset = "0x133FF88", VA = "0x133FF88")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x13304B8", Offset = "0x13304B8", VA = "0x13304B8")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x28630C", Offset = "0x28630C")]
	[ExecuteInEditMode]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1340358", Offset = "0x1340358", VA = "0x1340358")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x13403E8", Offset = "0x13403E8", VA = "0x13403E8")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x13406EC", Offset = "0x13406EC", VA = "0x13406EC")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1340AB8", Offset = "0x1340AB8", VA = "0x1340AB8")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1340C60", Offset = "0x1340C60", VA = "0x1340C60")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000041")]
	internal class Quads
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int currentQuads;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1340C68", Offset = "0x1340C68", VA = "0x1340C68")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x132D4D4", Offset = "0x132D4D4", VA = "0x132D4D4")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1330118", Offset = "0x1330118", VA = "0x1330118")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1340DB4", Offset = "0x1340DB4", VA = "0x1340DB4")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x134135C", Offset = "0x134135C", VA = "0x134135C")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286388", Offset = "0x286388")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286388", Offset = "0x286388")]
	[ExecuteInEditMode]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x2000043")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40001BD")]
			Additive,
			[Token(Token = "0x40001BE")]
			ScreenBlend,
			[Token(Token = "0x40001BF")]
			Multiply,
			[Token(Token = "0x40001C0")]
			Overlay,
			[Token(Token = "0x40001C1")]
			AlphaBlend
		}

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float intensity;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Texture2D texture;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader overlayShader;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material overlayMaterial;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x13438F8", Offset = "0x13438F8", VA = "0x13438F8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1343958", Offset = "0x1343958", VA = "0x1343958")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1343B70", Offset = "0x1343B70", VA = "0x1343B70")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x28642C", Offset = "0x28642C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x28642C", Offset = "0x28642C")]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287394", Offset = "0x287394")]
		public float intensity;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2873B0", Offset = "0x2873B0")]
		public float radius;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2873D0", Offset = "0x2873D0")]
		public int blurIterations;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2873EC", Offset = "0x2873EC")]
		public float blurFilterDistance;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287408", Offset = "0x287408")]
		public int downsample;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D rand;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Shader aoShader;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material aoMaterial;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1343B84", Offset = "0x1343B84", VA = "0x1343B84", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1343BE8", Offset = "0x1343BE8", VA = "0x1343BE8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1343CB0", Offset = "0x1343CB0", VA = "0x1343CB0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1344940", Offset = "0x1344940", VA = "0x1344940")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2864D0", Offset = "0x2864D0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2864D0", Offset = "0x2864D0")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000046")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40001D6")]
			Low,
			[Token(Token = "0x40001D7")]
			Medium,
			[Token(Token = "0x40001D8")]
			High
		}

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287420", Offset = "0x287420")]
		public float m_Radius;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28743C", Offset = "0x28743C")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287458", Offset = "0x287458")]
		public int m_Blur;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287474", Offset = "0x287474")]
		public int m_Downsampling;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287490", Offset = "0x287490")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2874AC", Offset = "0x2874AC")]
		public float m_MinZ;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_Supported;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x134496C", Offset = "0x134496C", VA = "0x134496C")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1344A44", Offset = "0x1344A44", VA = "0x1344A44")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1344AF0", Offset = "0x1344AF0", VA = "0x1344AF0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1344AF8", Offset = "0x1344AF8", VA = "0x1344AF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1344D08", Offset = "0x1344D08", VA = "0x1344D08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1344BFC", Offset = "0x1344BFC", VA = "0x1344BFC")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1344DA8", Offset = "0x1344DA8", VA = "0x1344DA8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x134569C", Offset = "0x134569C", VA = "0x134569C")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286574", Offset = "0x286574")]
	[ExecuteInEditMode]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1648F18", Offset = "0x1648F18", VA = "0x1648F18")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1648FB0", Offset = "0x1648FB0", VA = "0x1648FB0")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2865BC", Offset = "0x2865BC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2865BC", Offset = "0x2865BC")]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x2000049")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x40001E8")]
			Low,
			[Token(Token = "0x40001E9")]
			Normal,
			[Token(Token = "0x40001EA")]
			High
		}

		[Token(Token = "0x200004A")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x40001EC")]
			Screen,
			[Token(Token = "0x40001ED")]
			Add
		}

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform sunTransform;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int radialBlurIterations;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color sunColor;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color sunThreshold;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float sunShaftIntensity;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float maxRadius;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDepthTexture;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Shader sunShaftsShader;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Shader simpleClearShader;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material simpleClearMaterial;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x16497E4", Offset = "0x16497E4", VA = "0x16497E4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1649878", Offset = "0x1649878", VA = "0x1649878")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x164A38C", Offset = "0x164A38C", VA = "0x164A38C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286660", Offset = "0x286660")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286660", Offset = "0x286660")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x200004C")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x40001F6")]
			TiltShiftMode,
			[Token(Token = "0x40001F7")]
			IrisMode
		}

		[Token(Token = "0x200004D")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x40001F9")]
			Preview,
			[Token(Token = "0x40001FA")]
			Normal,
			[Token(Token = "0x40001FB")]
			High
		}

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TiltShiftMode mode;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TiltShiftQuality quality;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2874C8", Offset = "0x2874C8")]
		public float blurArea;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2874E4", Offset = "0x2874E4")]
		public float maxBlurSize;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287500", Offset = "0x287500")]
		public int downsample;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader tiltShiftShader;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x164A43C", Offset = "0x164A43C", VA = "0x164A43C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x164A4AC", Offset = "0x164A4AC", VA = "0x164A4AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x164A84C", Offset = "0x164A84C", VA = "0x164A84C")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2866F4", Offset = "0x2866F4")]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2866F4", Offset = "0x2866F4")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x200004F")]
		public enum TonemapperType
		{
			[Token(Token = "0x400020A")]
			SimpleReinhard,
			[Token(Token = "0x400020B")]
			UserCurve,
			[Token(Token = "0x400020C")]
			Hable,
			[Token(Token = "0x400020D")]
			Photographic,
			[Token(Token = "0x400020E")]
			OptimizedHejiDawson,
			[Token(Token = "0x400020F")]
			AdaptiveReinhard,
			[Token(Token = "0x4000210")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000050")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x4000212")]
			Square16 = 0x10,
			[Token(Token = "0x4000213")]
			Square32 = 0x20,
			[Token(Token = "0x4000214")]
			Square64 = 0x40,
			[Token(Token = "0x4000215")]
			Square128 = 0x80,
			[Token(Token = "0x4000216")]
			Square256 = 0x100,
			[Token(Token = "0x4000217")]
			Square512 = 0x200,
			[Token(Token = "0x4000218")]
			Square1024 = 0x400
		}

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public TonemapperType type;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Texture2D curveTex;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float exposureAdjustment;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float middleGrey;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float white;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float adaptionSpeed;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Shader tonemapper;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture rt;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x164A870", Offset = "0x164A870", VA = "0x164A870", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x164AA2C", Offset = "0x164AA2C", VA = "0x164AA2C")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x164ADBC", Offset = "0x164ADBC", VA = "0x164ADBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x164AF88", Offset = "0x164AF88", VA = "0x164AF88")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x164B0B0", Offset = "0x164B0B0", VA = "0x164B0B0")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x164BC40", Offset = "0x164BC40", VA = "0x164BC40")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000051")]
	internal class Triangles
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int currentTris;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x164F5A4", Offset = "0x164F5A4", VA = "0x164F5A4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x164F730", Offset = "0x164F730", VA = "0x164F730")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x164F9B8", Offset = "0x164F9B8", VA = "0x164F9B8")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x164FCA0", Offset = "0x164FCA0", VA = "0x164FCA0")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1650140", Offset = "0x1650140", VA = "0x1650140")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2867A8", Offset = "0x2867A8")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 radius;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287518", Offset = "0x287518")]
		public float angle;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 center;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x165014C", Offset = "0x165014C", VA = "0x165014C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x16501A0", Offset = "0x16501A0", VA = "0x16501A0")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2867F0", Offset = "0x2867F0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2867F0", Offset = "0x2867F0")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000054")]
		public enum AberrationMode
		{
			[Token(Token = "0x400022D")]
			Simple,
			[Token(Token = "0x400022E")]
			Advanced
		}

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public AberrationMode mode;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float intensity;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float chromaticAberration;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axialAberration;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float blur;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float blurSpread;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float luminanceDependency;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blurDistance;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Shader vignetteShader;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Shader chromAberrationShader;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x16501CC", Offset = "0x16501CC", VA = "0x16501CC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1650288", Offset = "0x1650288", VA = "0x1650288")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1650A24", Offset = "0x1650A24", VA = "0x1650A24")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286894", Offset = "0x286894")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector2 radius;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float angle;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 center;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1650A64", Offset = "0x1650A64", VA = "0x1650A64")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1650AB8", Offset = "0x1650AB8", VA = "0x1650AB8")]
		public Vortex()
		{
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x2000056")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x2868DC", Offset = "0x2868DC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x2868DC", Offset = "0x2868DC")]
	public class AmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000057")]
		private struct PropertyObserver
		{
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _downsampling;

			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private OcclusionSource _occlusionSource;

			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private bool _ambientOnly;

			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			private bool _debug;

			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private int _pixelWidth;

			[Token(Token = "0x400023D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _pixelHeight;

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1650E58", Offset = "0x1650E58", VA = "0x1650E58")]
			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return default(bool);
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1650F3C", Offset = "0x1650F3C", VA = "0x1650F3C")]
			public void Update(Settings setting, Camera camera)
			{
			}
		}

		[Token(Token = "0x2000058")]
		public enum SampleCount
		{
			[Token(Token = "0x400023F")]
			Lowest,
			[Token(Token = "0x4000240")]
			Low,
			[Token(Token = "0x4000241")]
			Medium,
			[Token(Token = "0x4000242")]
			High,
			[Token(Token = "0x4000243")]
			Variable
		}

		[Token(Token = "0x2000059")]
		public enum OcclusionSource
		{
			[Token(Token = "0x4000245")]
			DepthTexture,
			[Token(Token = "0x4000246")]
			DepthNormalsTexture,
			[Token(Token = "0x4000247")]
			GBuffer
		}

		[Serializable]
		[Token(Token = "0x200005A")]
		public class Settings
		{
			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287574", Offset = "0x287574")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287574", Offset = "0x287574")]
			public float intensity;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2875D8", Offset = "0x2875D8")]
			public float radius;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287620", Offset = "0x287620")]
			public SampleCount sampleCount;

			[Token(Token = "0x400024B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287668", Offset = "0x287668")]
			public int sampleCountValue;

			[Token(Token = "0x400024C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2876B0", Offset = "0x2876B0")]
			public bool downsampling;

			[Token(Token = "0x400024D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2876F8", Offset = "0x2876F8")]
			public bool ambientOnly;

			[Token(Token = "0x400024E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287740", Offset = "0x287740")]
			[SerializeField]
			public OcclusionSource occlusionSource;

			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287788", Offset = "0x287788")]
			[SerializeField]
			public bool debug;

			[Token(Token = "0x1700001A")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x1650FF8", Offset = "0x1650FF8", VA = "0x1650FF8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x16510EC", Offset = "0x16510EC", VA = "0x16510EC")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _aoShader;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private Material _aoMaterial;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CommandBuffer _aoCommands;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x287554", Offset = "0x287554")]
		private PropertyObserver <propertyObserver>k__BackingField;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Mesh _quadMesh;

		[Token(Token = "0x1700000A")]
		public bool isAmbientOnlySupported
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x15B0598", Offset = "0x15B0598", VA = "0x15B0598")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x15B069C", Offset = "0x15B069C", VA = "0x15B069C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000C")]
		private float intensity
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x15B06D4", Offset = "0x15B06D4", VA = "0x15B06D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000D")]
		private float radius
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x15B06F4", Offset = "0x15B06F4", VA = "0x15B06F4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		private SampleCount sampleCount
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x15B0724", Offset = "0x15B0724", VA = "0x15B0724")]
			get
			{
				return default(SampleCount);
			}
		}

		[Token(Token = "0x1700000F")]
		private int sampleCountValue
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x15B0744", Offset = "0x15B0744", VA = "0x15B0744")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000010")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x15B0644", Offset = "0x15B0644", VA = "0x15B0644")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x17000011")]
		private bool downsampling
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x15B07A8", Offset = "0x15B07A8", VA = "0x15B07A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		private bool ambientOnly
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x15B07C8", Offset = "0x15B07C8", VA = "0x15B07C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private RenderTextureFormat aoTextureFormat
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0x15B0820", Offset = "0x15B0820", VA = "0x15B0820")]
			get
			{
				return default(RenderTextureFormat);
			}
		}

		[Token(Token = "0x17000014")]
		private Shader aoShader
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0x15B0848", Offset = "0x15B0848", VA = "0x15B0848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private Material aoMaterial
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x15B090C", Offset = "0x15B090C", VA = "0x15B090C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private CommandBuffer aoCommands
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x15B09BC", Offset = "0x15B09BC", VA = "0x15B09BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private Camera targetCamera
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x15B05EC", Offset = "0x15B05EC", VA = "0x15B05EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private PropertyObserver propertyObserver
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x15B0A78", Offset = "0x15B0A78", VA = "0x15B0A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289C60", Offset = "0x289C60")]
			get
			{
				return default(PropertyObserver);
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x15B0A90", Offset = "0x15B0A90", VA = "0x15B0A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289C70", Offset = "0x289C70")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		private Mesh quadMesh
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x15B0AB8", Offset = "0x15B0AB8", VA = "0x15B0AB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x15B0AC0", Offset = "0x15B0AC0", VA = "0x15B0AC0")]
		private void BuildAOCommands()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15B16E8", Offset = "0x15B16E8", VA = "0x15B16E8")]
		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15B1D54", Offset = "0x15B1D54", VA = "0x15B1D54")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15B1EDC", Offset = "0x15B1EDC", VA = "0x15B1EDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15B2040", Offset = "0x15B2040", VA = "0x15B2040")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15B2164", Offset = "0x15B2164", VA = "0x15B2164")]
		private void Update()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15B2254", Offset = "0x15B2254", VA = "0x15B2254")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15B2304", Offset = "0x15B2304", VA = "0x15B2304")]
		public AmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286990", Offset = "0x286990")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286990", Offset = "0x286990")]
	[ExecuteInEditMode]
	public class AntiAliasing : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum Method
		{
			[Token(Token = "0x4000255")]
			Smaa,
			[Token(Token = "0x4000256")]
			Fxaa
		}

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		private SMAA m_SMAA;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FXAA m_FXAA;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		[SerializeField]
		private int m_Method;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera m_Camera;

		[Token(Token = "0x1700001B")]
		public int method
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x15B2338", Offset = "0x15B2338", VA = "0x15B2338")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x15B2340", Offset = "0x15B2340", VA = "0x15B2340")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public IAntiAliasing current
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x15B2350", Offset = "0x15B2350", VA = "0x15B2350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public Camera cameraComponent
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x15B2364", Offset = "0x15B2364", VA = "0x15B2364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x15B242C", Offset = "0x15B242C", VA = "0x15B242C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x15B247C", Offset = "0x15B247C", VA = "0x15B247C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x15B24C4", Offset = "0x15B24C4", VA = "0x15B24C4")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15B25A8", Offset = "0x15B25A8", VA = "0x15B25A8")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15B268C", Offset = "0x15B268C", VA = "0x15B268C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15B278C", Offset = "0x15B278C", VA = "0x15B278C")]
		public AntiAliasing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		[Token(Token = "0x200005E")]
		public struct QualitySettings
		{
			[Token(Token = "0x400025C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287860", Offset = "0x287860")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287860", Offset = "0x287860")]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x400025D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2878B0", Offset = "0x2878B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2878B0", Offset = "0x2878B0")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x400025E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287908", Offset = "0x287908")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287908", Offset = "0x287908")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		public struct ConsoleSettings
		{
			[Token(Token = "0x400025F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28795C", Offset = "0x28795C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28795C", Offset = "0x28795C")]
			public float subpixelSpreadAmount;

			[Token(Token = "0x4000260")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2879B0", Offset = "0x2879B0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2879B0", Offset = "0x2879B0")]
			public float edgeSharpnessAmount;

			[Token(Token = "0x4000261")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287A00", Offset = "0x287A00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287A00", Offset = "0x287A00")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000262")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287A50", Offset = "0x287A50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287A50", Offset = "0x287A50")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x2000060")]
		public struct Preset
		{
			[Token(Token = "0x2000061")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286A44", Offset = "0x286A44")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x16551B0", Offset = "0x16551B0", VA = "0x16551B0")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x4000263")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Layout]
			public QualitySettings qualitySettings;

			[Token(Token = "0x4000264")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[Layout]
			public ConsoleSettings consoleSettings;

			[Token(Token = "0x4000265")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly Preset s_ExtremePerformance;

			[Token(Token = "0x4000266")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private static readonly Preset s_Performance;

			[Token(Token = "0x4000267")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static readonly Preset s_Default;

			[Token(Token = "0x4000268")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private static readonly Preset s_Quality;

			[Token(Token = "0x4000269")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private static readonly Preset s_ExtremeQuality;

			[Token(Token = "0x17000021")]
			public static Preset extremePerformancePreset
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0x16513A8", Offset = "0x16513A8", VA = "0x16513A8")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000022")]
			public static Preset performancePreset
			{
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x1651430", Offset = "0x1651430", VA = "0x1651430")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000023")]
			public static Preset defaultPreset
			{
				[Token(Token = "0x6000144")]
				[Address(RVA = "0x16514C0", Offset = "0x16514C0", VA = "0x16514C0")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000024")]
			public static Preset qualityPreset
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0x1651550", Offset = "0x1651550", VA = "0x1651550")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000025")]
			public static Preset extremeQualityPreset
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x16515E0", Offset = "0x16515E0", VA = "0x16515E0")]
				get
				{
					return default(Preset);
				}
			}
		}

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Shader m_Shader;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private Material m_Material;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		public Preset preset;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Preset[] availablePresets;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x287850", Offset = "0x287850")]
		private bool <validSourceFormat>k__BackingField;

		[Token(Token = "0x1700001E")]
		private Shader shader
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1330B08", Offset = "0x1330B08", VA = "0x1330B08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public Material material
		{
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x1330BCC", Offset = "0x1330BCC", VA = "0x1330BCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public bool validSourceFormat
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1330D78", Offset = "0x1330D78", VA = "0x1330D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289C90", Offset = "0x289C90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1330D80", Offset = "0x1330D80", VA = "0x1330D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289CA0", Offset = "0x289CA0")]
			private set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1330D88", Offset = "0x1330D88", VA = "0x1330D88", Slot = "4")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1331240", Offset = "0x1331240", VA = "0x1331240", Slot = "5")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x13312FC", Offset = "0x13312FC", VA = "0x13312FC", Slot = "6")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1331300", Offset = "0x1331300", VA = "0x1331300", Slot = "7")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1331304", Offset = "0x1331304", VA = "0x1331304", Slot = "8")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x13314A4", Offset = "0x13314A4", VA = "0x13314A4")]
		public FXAA()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public interface IAntiAliasing
	{
		[Token(Token = "0x6000149")]
		void OnEnable(AntiAliasing owner);

		[Token(Token = "0x600014A")]
		void OnDisable();

		[Token(Token = "0x600014B")]
		void OnPreCull(Camera camera);

		[Token(Token = "0x600014C")]
		void OnPostRender(Camera camera);

		[Token(Token = "0x600014D")]
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class SMAA : IAntiAliasing
	{
		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286A58", Offset = "0x286A58")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x1654ABC", Offset = "0x1654ABC", VA = "0x1654ABC")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000065")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286A6C", Offset = "0x286A6C")]
		public class TopLevelSettings : Attribute
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x1654AE0", Offset = "0x1654AE0", VA = "0x1654AE0")]
			public TopLevelSettings()
			{
			}
		}

		[Token(Token = "0x2000066")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286A80", Offset = "0x286A80")]
		public class ExperimentalGroup : Attribute
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x16548C0", Offset = "0x16548C0", VA = "0x16548C0")]
			public ExperimentalGroup()
			{
			}
		}

		[Token(Token = "0x2000067")]
		public enum DebugPass
		{
			[Token(Token = "0x4000277")]
			Off,
			[Token(Token = "0x4000278")]
			Edges,
			[Token(Token = "0x4000279")]
			Weights,
			[Token(Token = "0x400027A")]
			Accumulation
		}

		[Token(Token = "0x2000068")]
		public enum QualityPreset
		{
			[Token(Token = "0x400027C")]
			Low,
			[Token(Token = "0x400027D")]
			Medium,
			[Token(Token = "0x400027E")]
			High,
			[Token(Token = "0x400027F")]
			Ultra,
			[Token(Token = "0x4000280")]
			Custom
		}

		[Token(Token = "0x2000069")]
		public enum EdgeDetectionMethod
		{
			[Token(Token = "0x4000282")]
			Luma = 1,
			[Token(Token = "0x4000283")]
			Color,
			[Token(Token = "0x4000284")]
			Depth
		}

		[Serializable]
		[Token(Token = "0x200006A")]
		public struct GlobalSettings
		{
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287B28", Offset = "0x287B28")]
			public DebugPass debugPass;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287B5C", Offset = "0x287B5C")]
			public QualityPreset quality;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287B90", Offset = "0x287B90")]
			public EdgeDetectionMethod edgeDetectionMethod;

			[Token(Token = "0x1700002A")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x16548C8", Offset = "0x16548C8", VA = "0x16548C8")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200006B")]
		public struct QualitySettings
		{
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287BC4", Offset = "0x287BC4")]
			public bool diagonalDetection;

			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287BF8", Offset = "0x287BF8")]
			public bool cornerDetection;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287C2C", Offset = "0x287C2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287C2C", Offset = "0x287C2C")]
			public float threshold;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x287C7C", Offset = "0x287C7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287C7C", Offset = "0x287C7C")]
			public float depthThreshold;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287CCC", Offset = "0x287CCC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287CCC", Offset = "0x287CCC")]
			public int maxSearchSteps;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287D20", Offset = "0x287D20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287D20", Offset = "0x287D20")]
			public int maxDiagonalSearchSteps;

			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287D74", Offset = "0x287D74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287D74", Offset = "0x287D74")]
			public int cornerRounding;

			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x287DC8", Offset = "0x287DC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287DC8", Offset = "0x287DC8")]
			public float localContrastAdaptationFactor;

			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200006C")]
		public struct TemporalSettings
		{
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287E14", Offset = "0x287E14")]
			public bool enabled;

			[Token(Token = "0x4000292")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287E48", Offset = "0x287E48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287E48", Offset = "0x287E48")]
			public float fuzzSize;

			[Token(Token = "0x1700002B")]
			public static TemporalSettings defaultSettings
			{
				[Token(Token = "0x600015F")]
				[Address(RVA = "0x1654ACC", Offset = "0x1654ACC", VA = "0x1654ACC")]
				get
				{
					return default(TemporalSettings);
				}
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x1654AC4", Offset = "0x1654AC4", VA = "0x1654AC4")]
			public bool UseTemporal()
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200006D")]
		public struct PredicationSettings
		{
			[Token(Token = "0x4000293")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287E9C", Offset = "0x287E9C")]
			public bool enabled;

			[Token(Token = "0x4000294")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287ED0", Offset = "0x287ED0")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x287ED0", Offset = "0x287ED0")]
			public float threshold;

			[Token(Token = "0x4000295")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287F20", Offset = "0x287F20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287F20", Offset = "0x287F20")]
			public float scale;

			[Token(Token = "0x4000296")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x287F74", Offset = "0x287F74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x287F74", Offset = "0x287F74")]
			public float strength;

			[Token(Token = "0x1700002C")]
			public static PredicationSettings defaultSettings
			{
				[Token(Token = "0x6000160")]
				[Address(RVA = "0x16548E0", Offset = "0x16548E0", VA = "0x16548E0")]
				get
				{
					return default(PredicationSettings);
				}
			}
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[TopLevelSettings]
		public GlobalSettings settings;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SettingsGroup]
		public QualitySettings quality;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SettingsGroup]
		public PredicationSettings predication;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[ExperimentalGroup]
		[SettingsGroup]
		public TemporalSettings temporal;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Matrix4x4 m_ProjectionMatrix;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float m_FlipFlop;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private RenderTexture m_Accumulation;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Shader m_Shader;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Texture2D m_AreaTexture;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Texture2D m_SearchTexture;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Material m_Material;

		[Token(Token = "0x17000026")]
		public Shader shader
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x1341C1C", Offset = "0x1341C1C", VA = "0x1341C1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x1341CE0", Offset = "0x1341CE0", VA = "0x1341CE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x1341DC0", Offset = "0x1341DC0", VA = "0x1341DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private Material material
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x1341EA0", Offset = "0x1341EA0", VA = "0x1341EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1341F4C", Offset = "0x1341F4C", VA = "0x1341F4C", Slot = "4")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1341FA4", Offset = "0x1341FA4", VA = "0x1341FA4", Slot = "5")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x13420F0", Offset = "0x13420F0", VA = "0x13420F0", Slot = "6")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x134249C", Offset = "0x134249C", VA = "0x134249C", Slot = "7")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x13424D0", Offset = "0x13424D0", VA = "0x13424D0", Slot = "8")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x13437A0", Offset = "0x13437A0", VA = "0x13437A0")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x13437D0", Offset = "0x13437D0", VA = "0x13437D0")]
		public SMAA()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286A94", Offset = "0x286A94")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286A94", Offset = "0x286A94")]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006F")]
		public struct Settings
		{
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288004", Offset = "0x288004")]
			[SerializeField]
			public float threshold;

			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28804C", Offset = "0x28804C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28804C", Offset = "0x28804C")]
			public float softKnee;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2880AC", Offset = "0x2880AC")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2880AC", Offset = "0x2880AC")]
			public float radius;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288110", Offset = "0x288110")]
			public float intensity;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288158", Offset = "0x288158")]
			public bool highQuality;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2881A0", Offset = "0x2881A0")]
			public bool antiFlicker;

			[Token(Token = "0x1700002F")]
			public float thresholdGamma
			{
				[Token(Token = "0x6000168")]
				[Address(RVA = "0x16510FC", Offset = "0x16510FC", VA = "0x16510FC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000167")]
				[Address(RVA = "0x16510F4", Offset = "0x16510F4", VA = "0x16510F4")]
				set
				{
				}
			}

			[Token(Token = "0x17000030")]
			public float thresholdLinear
			{
				[Token(Token = "0x600016A")]
				[Address(RVA = "0x165112C", Offset = "0x165112C", VA = "0x165112C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000169")]
				[Address(RVA = "0x165110C", Offset = "0x165110C", VA = "0x165110C")]
				set
				{
				}
			}

			[Token(Token = "0x17000031")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600016B")]
				[Address(RVA = "0x1651150", Offset = "0x1651150", VA = "0x1651150")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Material m_Material;

		[Token(Token = "0x400029A")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] m_blurBuffer1;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private RenderTexture[] m_blurBuffer2;

		[Token(Token = "0x1700002D")]
		public Shader shader
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x15B31B0", Offset = "0x15B31B0", VA = "0x15B31B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public Material material
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x15B3274", Offset = "0x15B3274", VA = "0x15B3274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x15B3324", Offset = "0x15B3324", VA = "0x15B3324")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x15B3378", Offset = "0x15B3378", VA = "0x15B3378")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x15B3444", Offset = "0x15B3444", VA = "0x15B3444")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x15B3EA4", Offset = "0x15B3EA4", VA = "0x15B3EA4")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x17000032")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x1332C34", Offset = "0x1332C34", VA = "0x1332C34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1330DE0", Offset = "0x1330DE0", VA = "0x1330DE0")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1330C78", Offset = "0x1330C78", VA = "0x1330C78")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000071")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly float min;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x133CE48", Offset = "0x133CE48", VA = "0x133CE48")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x133CC58", Offset = "0x133CC58", VA = "0x133CC58")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1341368", Offset = "0x1341368", VA = "0x1341368")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x133BDE4", Offset = "0x133BDE4", VA = "0x133BDE4")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x133BC60", Offset = "0x133BC60", VA = "0x133BC60")]
		public RenderTextureUtility()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286B48", Offset = "0x286B48")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286B48", Offset = "0x286B48")]
	[ExecuteInEditMode]
	public class DepthOfField : MonoBehaviour
	{
		[Token(Token = "0x2000074")]
		private enum Passes
		{
			[Token(Token = "0x40002BC")]
			BlurAlphaWeighted,
			[Token(Token = "0x40002BD")]
			BoxBlur,
			[Token(Token = "0x40002BE")]
			DilateFgCocFromColor,
			[Token(Token = "0x40002BF")]
			DilateFgCoc,
			[Token(Token = "0x40002C0")]
			CaptureCocExplicit,
			[Token(Token = "0x40002C1")]
			VisualizeCocExplicit,
			[Token(Token = "0x40002C2")]
			CocPrefilter,
			[Token(Token = "0x40002C3")]
			CircleBlur,
			[Token(Token = "0x40002C4")]
			CircleBlurWithDilatedFg,
			[Token(Token = "0x40002C5")]
			CircleBlurLowQuality,
			[Token(Token = "0x40002C6")]
			CircleBlowLowQualityWithDilatedFg,
			[Token(Token = "0x40002C7")]
			MergeExplicit,
			[Token(Token = "0x40002C8")]
			ShapeLowQuality,
			[Token(Token = "0x40002C9")]
			ShapeLowQualityDilateFg,
			[Token(Token = "0x40002CA")]
			ShapeLowQualityMerge,
			[Token(Token = "0x40002CB")]
			ShapeLowQualityMergeDilateFg,
			[Token(Token = "0x40002CC")]
			ShapeMediumQuality,
			[Token(Token = "0x40002CD")]
			ShapeMediumQualityDilateFg,
			[Token(Token = "0x40002CE")]
			ShapeMediumQualityMerge,
			[Token(Token = "0x40002CF")]
			ShapeMediumQualityMergeDilateFg,
			[Token(Token = "0x40002D0")]
			ShapeHighQuality,
			[Token(Token = "0x40002D1")]
			ShapeHighQualityDilateFg,
			[Token(Token = "0x40002D2")]
			ShapeHighQualityMerge,
			[Token(Token = "0x40002D3")]
			ShapeHighQualityMergeDilateFg
		}

		[Token(Token = "0x2000075")]
		private enum MedianPasses
		{
			[Token(Token = "0x40002D5")]
			Median3,
			[Token(Token = "0x40002D6")]
			Median3X3
		}

		[Token(Token = "0x2000076")]
		private enum BokehTexturesPasses
		{
			[Token(Token = "0x40002D8")]
			Apply,
			[Token(Token = "0x40002D9")]
			Collect
		}

		[Token(Token = "0x2000077")]
		public enum TweakMode
		{
			[Token(Token = "0x40002DB")]
			Range,
			[Token(Token = "0x40002DC")]
			Explicit
		}

		[Token(Token = "0x2000078")]
		public enum ApertureShape
		{
			[Token(Token = "0x40002DE")]
			Circular,
			[Token(Token = "0x40002DF")]
			Hexagonal,
			[Token(Token = "0x40002E0")]
			Octogonal
		}

		[Token(Token = "0x2000079")]
		public enum QualityPreset
		{
			[Token(Token = "0x40002E2")]
			Low,
			[Token(Token = "0x40002E3")]
			Medium,
			[Token(Token = "0x40002E4")]
			High
		}

		[Token(Token = "0x200007A")]
		public enum FilterQuality
		{
			[Token(Token = "0x40002E6")]
			None,
			[Token(Token = "0x40002E7")]
			Normal,
			[Token(Token = "0x40002E8")]
			High
		}

		[Serializable]
		[Token(Token = "0x200007B")]
		public struct GlobalSettings
		{
			[Token(Token = "0x40002E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288218", Offset = "0x288218")]
			public bool visualizeFocus;

			[Token(Token = "0x40002EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28824C", Offset = "0x28824C")]
			public TweakMode tweakMode;

			[Token(Token = "0x40002EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288280", Offset = "0x288280")]
			public QualityPreset filteringQuality;

			[Token(Token = "0x40002EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2882B4", Offset = "0x2882B4")]
			public ApertureShape apertureShape;

			[Token(Token = "0x40002ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2882E8", Offset = "0x2882E8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2882E8", Offset = "0x2882E8")]
			public float apertureOrientation;

			[Token(Token = "0x1700003C")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600018B")]
				[Address(RVA = "0x1651280", Offset = "0x1651280", VA = "0x1651280")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200007C")]
		public struct QualitySettings
		{
			[Token(Token = "0x40002EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28833C", Offset = "0x28833C")]
			public bool prefilterBlur;

			[Token(Token = "0x40002EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288370", Offset = "0x288370")]
			public FilterQuality medianFilter;

			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2883A4", Offset = "0x2883A4")]
			public bool dilateNearBlur;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200007D")]
		public struct FocusSettings
		{
			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2883D8", Offset = "0x2883D8")]
			public Transform transform;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28840C", Offset = "0x28840C")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x28840C", Offset = "0x28840C")]
			public float focusPlane;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288458", Offset = "0x288458")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x288458", Offset = "0x288458")]
			public float range;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x2884A8", Offset = "0x2884A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2884A8", Offset = "0x2884A8")]
			public float nearPlane;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x2884F4", Offset = "0x2884F4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2884F4", Offset = "0x2884F4")]
			public float nearFalloff;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x288540", Offset = "0x288540")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288540", Offset = "0x288540")]
			public float farPlane;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x28858C", Offset = "0x28858C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28858C", Offset = "0x28858C")]
			public float farFalloff;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2885D8", Offset = "0x2885D8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2885D8", Offset = "0x2885D8")]
			public float nearBlurRadius;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28862C", Offset = "0x28862C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28862C", Offset = "0x28862C")]
			public float farBlurRadius;

			[Token(Token = "0x1700003D")]
			public static FocusSettings defaultSettings
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x16511E8", Offset = "0x16511E8", VA = "0x16511E8")]
				get
				{
					return default(FocusSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public struct BokehTextureSettings
		{
			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288680", Offset = "0x288680")]
			public Texture2D texture;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2886B4", Offset = "0x2886B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2886B4", Offset = "0x2886B4")]
			public float scale;

			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28870C", Offset = "0x28870C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28870C", Offset = "0x28870C")]
			public float intensity;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288764", Offset = "0x288764")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288764", Offset = "0x288764")]
			public float threshold;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2887BC", Offset = "0x2887BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2887BC", Offset = "0x2887BC")]
			public float spawnHeuristic;

			[Token(Token = "0x1700003E")]
			public static BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x1651178", Offset = "0x1651178", VA = "0x1651178")]
				get
				{
					return default(BokehTextureSettings);
				}
			}
		}

		[Token(Token = "0x40002A5")]
		private const float kMaxBlur = 40f;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public GlobalSettings settings;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FocusSettings focus;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BokehTextureSettings bokehTexture;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_FilmicDepthOfFieldMaterial;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Material m_MedianFilterMaterial;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_TextureBokehMaterial;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ComputeBuffer m_ComputeBufferPoints;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private QualitySettings m_CurrentQualitySettings;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_LastApertureOrientation;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector4 m_OctogonalBokehDirection1;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector4 m_OctogonalBokehDirection2;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector4 m_OctogonalBokehDirection3;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector4 m_OctogonalBokehDirection4;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Vector4 m_HexagonalBokehDirection1;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector4 m_HexagonalBokehDirection2;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private Vector4 m_HexagonalBokehDirection3;

		[Token(Token = "0x17000033")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x15C0D00", Offset = "0x15C0D00", VA = "0x15C0D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x15C0DC4", Offset = "0x15C0DC4", VA = "0x15C0DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x15C0E88", Offset = "0x15C0E88", VA = "0x15C0E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x15C0F4C", Offset = "0x15C0F4C", VA = "0x15C0F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x15C0FFC", Offset = "0x15C0FFC", VA = "0x15C0FFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x15C10AC", Offset = "0x15C10AC", VA = "0x15C10AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x15C115C", Offset = "0x15C115C", VA = "0x15C115C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x15C1270", Offset = "0x15C1270", VA = "0x15C1270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x15C3278", Offset = "0x15C3278", VA = "0x15C3278")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x15C1310", Offset = "0x15C1310", VA = "0x15C1310")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x15C17B0", Offset = "0x15C17B0", VA = "0x15C17B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x15C1A0C", Offset = "0x15C1A0C", VA = "0x15C1A0C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x15C1FFC", Offset = "0x15C1FFC", VA = "0x15C1FFC")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x15C3538", Offset = "0x15C3538", VA = "0x15C3538")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x15C391C", Offset = "0x15C391C", VA = "0x15C391C")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x15C3388", Offset = "0x15C3388", VA = "0x15C3388")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x15C1CBC", Offset = "0x15C1CBC", VA = "0x15C1CBC")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x15C19AC", Offset = "0x15C19AC", VA = "0x15C19AC")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x15C1460", Offset = "0x15C1460", VA = "0x15C1460")]
		private void ComputeBlurDirections(bool force)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x15C3E60", Offset = "0x15C3E60", VA = "0x15C3E60")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x15C3350", Offset = "0x15C3350", VA = "0x15C3350")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x15C3D50", Offset = "0x15C3D50", VA = "0x15C3D50")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x15C3E8C", Offset = "0x15C3E8C", VA = "0x15C3E8C")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286BEC", Offset = "0x286BEC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286BEC", Offset = "0x286BEC")]
	public class LensAberrations : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286C90", Offset = "0x286C90")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x16544F8", Offset = "0x16544F8", VA = "0x16544F8")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000081")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286CA4", Offset = "0x286CA4")]
		public class AdvancedSetting : Attribute
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x165448C", Offset = "0x165448C", VA = "0x165448C")]
			public AdvancedSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public struct DistortionSettings
		{
			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288850", Offset = "0x288850")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288850", Offset = "0x288850")]
			public float amount;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2888A8", Offset = "0x2888A8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2888A8", Offset = "0x2888A8")]
			public float centerX;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2888FC", Offset = "0x2888FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2888FC", Offset = "0x2888FC")]
			public float centerY;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288950", Offset = "0x288950")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288950", Offset = "0x288950")]
			public float amountX;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2889A0", Offset = "0x2889A0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2889A0", Offset = "0x2889A0")]
			public float amountY;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2889F0", Offset = "0x2889F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2889F0", Offset = "0x2889F0")]
			public float scale;

			[Token(Token = "0x17000041")]
			public static DistortionSettings defaultSettings
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0x16544D8", Offset = "0x16544D8", VA = "0x16544D8")]
				get
				{
					return default(DistortionSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000083")]
		public struct VignetteSettings
		{
			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288A48", Offset = "0x288A48")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x288A48", Offset = "0x288A48")]
			public Color color;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288A94", Offset = "0x288A94")]
			public Vector2 center;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288AC8", Offset = "0x288AC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288AC8", Offset = "0x288AC8")]
			public float intensity;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288B1C", Offset = "0x288B1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288B1C", Offset = "0x288B1C")]
			public float smoothness;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AdvancedSetting]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288B74", Offset = "0x288B74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288B74", Offset = "0x288B74")]
			public float roundness;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288BD4", Offset = "0x288BD4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288BD4", Offset = "0x288BD4")]
			public float blur;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288C24", Offset = "0x288C24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288C24", Offset = "0x288C24")]
			public float desaturate;

			[Token(Token = "0x17000042")]
			public static VignetteSettings defaultSettings
			{
				[Token(Token = "0x6000198")]
				[Address(RVA = "0x1654500", Offset = "0x1654500", VA = "0x1654500")]
				get
				{
					return default(VignetteSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public struct ChromaticAberrationSettings
		{
			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x288C74", Offset = "0x288C74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288C74", Offset = "0x288C74")]
			public Color color;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288CC0", Offset = "0x288CC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288CC0", Offset = "0x288CC0")]
			public float amount;

			[Token(Token = "0x17000043")]
			public static ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0x1654494", Offset = "0x1654494", VA = "0x1654494")]
				get
				{
					return default(ChromaticAberrationSettings);
				}
			}
		}

		[Token(Token = "0x2000085")]
		private enum Pass
		{
			[Token(Token = "0x4000319")]
			BlurPrePass,
			[Token(Token = "0x400031A")]
			Chroma,
			[Token(Token = "0x400031B")]
			Distort,
			[Token(Token = "0x400031C")]
			Vignette,
			[Token(Token = "0x400031D")]
			ChromaDistort,
			[Token(Token = "0x400031E")]
			ChromaVignette,
			[Token(Token = "0x400031F")]
			DistortVignette,
			[Token(Token = "0x4000320")]
			ChromaDistortVignette
		}

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SettingsGroup]
		public DistortionSettings distortion;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SettingsGroup]
		public VignetteSettings vignette;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Material m_Material;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x1700003F")]
		public Shader shader
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x133BA4C", Offset = "0x133BA4C", VA = "0x133BA4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public Material material
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x133BB10", Offset = "0x133BB10", VA = "0x133BB10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x133BBBC", Offset = "0x133BBBC", VA = "0x133BBBC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x133BCFC", Offset = "0x133BCFC", VA = "0x133BCFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x133BECC", Offset = "0x133BECC", VA = "0x133BECC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x133CD88", Offset = "0x133CD88", VA = "0x133CD88")]
		public LensAberrations()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286CB8", Offset = "0x286CB8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286CB8", Offset = "0x286CB8")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		[Token(Token = "0x2000087")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000332")]
			High = 0,
			[Token(Token = "0x4000333")]
			Low = 2
		}

		[Token(Token = "0x2000088")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x4000335")]
			PhysicallyBased,
			[Token(Token = "0x4000336")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public struct SSRSettings
		{
			[Token(Token = "0x200008A")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286D6C", Offset = "0x286D6C")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x60001A3")]
				[Address(RVA = "0x16551B8", Offset = "0x16551B8", VA = "0x16551B8")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Layout]
			public ReflectionSettings reflectionSettings;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Layout]
			public IntensitySettings intensitySettings;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Layout]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x17000047")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x60001A1")]
				[Address(RVA = "0x1654AE8", Offset = "0x1654AE8", VA = "0x1654AE8")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public struct IntensitySettings
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288E38", Offset = "0x288E38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288E38", Offset = "0x288E38")]
			public float reflectionMultiplier;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288E88", Offset = "0x288E88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288E88", Offset = "0x288E88")]
			public float fadeDistance;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288EDC", Offset = "0x288EDC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288EDC", Offset = "0x288EDC")]
			public float fresnelFade;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288F2C", Offset = "0x288F2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288F2C", Offset = "0x288F2C")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288F84", Offset = "0x288F84")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288FB8", Offset = "0x288FB8")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288FEC", Offset = "0x288FEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x288FEC", Offset = "0x288FEC")]
			public float maxDistance;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289044", Offset = "0x289044")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289044", Offset = "0x289044")]
			public int iterationCount;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28909C", Offset = "0x28909C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28909C", Offset = "0x28909C")]
			public int stepSize;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2890F0", Offset = "0x2890F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2890F0", Offset = "0x2890F0")]
			public float widthModifier;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289148", Offset = "0x289148")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289148", Offset = "0x289148")]
			public float reflectionBlur;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28919C", Offset = "0x28919C")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2891D0", Offset = "0x2891D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2891D0", Offset = "0x2891D0")]
			public float intensity;
		}

		[Token(Token = "0x200008E")]
		private enum PassIndex
		{
			[Token(Token = "0x4000349")]
			RayTraceStep,
			[Token(Token = "0x400034A")]
			CompositeFinal,
			[Token(Token = "0x400034B")]
			Blur,
			[Token(Token = "0x400034C")]
			CompositeSSR,
			[Token(Token = "0x400034D")]
			MinMipGeneration,
			[Token(Token = "0x400034E")]
			HitPointToReflections,
			[Token(Token = "0x400034F")]
			BilateralKeyPack,
			[Token(Token = "0x4000350")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000351")]
			PoissonBlur
		}

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288D28", Offset = "0x288D28")]
		private bool highlightSuppression;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288D5C", Offset = "0x288D5C")]
		private bool traceBehindObjects;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288D90", Offset = "0x288D90")]
		private bool treatBackfaceHitAsMiss;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x288DC4", Offset = "0x288DC4")]
		private bool bilateralUpsample;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_Material;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Camera m_Camera;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CommandBuffer m_CommandBuffer;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int kNormalAndRoughnessTexture;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int kHitPointTexture;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] kReflectionTextures;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static int kFilteredReflections;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int kBlurTexture;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static int kFinalReflectionTexture;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int kTempTexture;

		[Token(Token = "0x17000044")]
		public Shader shader
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x13456EC", Offset = "0x13456EC", VA = "0x13456EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public Material material
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x13457B0", Offset = "0x13457B0", VA = "0x13457B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public Camera camera_
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x134585C", Offset = "0x134585C", VA = "0x134585C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1345924", Offset = "0x1345924", VA = "0x1345924")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1345D50", Offset = "0x1345D50", VA = "0x1345D50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1345EB8", Offset = "0x1345EB8", VA = "0x1345EB8")]
		public void OnPreRender()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x13482D8", Offset = "0x13482D8", VA = "0x13482D8")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x200008F")]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x286D80", Offset = "0x286D80")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x286D80", Offset = "0x286D80")]
	[ExecuteInEditMode]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x286E34", Offset = "0x286E34")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x16551A8", Offset = "0x16551A8", VA = "0x16551A8")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000091")]
		public class IndentedGroup : PropertyAttribute
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x16551A0", Offset = "0x16551A0", VA = "0x16551A0")]
			public IndentedGroup()
			{
			}
		}

		[Token(Token = "0x2000092")]
		public class ChannelMixer : PropertyAttribute
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1654C98", Offset = "0x1654C98", VA = "0x1654C98")]
			public ChannelMixer()
			{
			}
		}

		[Token(Token = "0x2000093")]
		public class ColorWheelGroup : PropertyAttribute
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int minSizePerWheel;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int maxSizePerWheel;

			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1654EE0", Offset = "0x1654EE0", VA = "0x1654EE0")]
			public ColorWheelGroup()
			{
			}

			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x1654EF8", Offset = "0x1654EF8", VA = "0x1654EF8")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}
		}

		[Token(Token = "0x2000094")]
		public class Curve : PropertyAttribute
		{
			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Color color;

			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x1654F34", Offset = "0x1654F34", VA = "0x1654F34")]
			public Curve()
			{
			}

			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x1654F78", Offset = "0x1654F78", VA = "0x1654F78")]
			public Curve(float r, float g, float b, float a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public struct EyeAdaptationSettings
		{
			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289310", Offset = "0x289310")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x289310", Offset = "0x289310")]
			public float middleGrey;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28935C", Offset = "0x28935C")]
			public float min;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289390", Offset = "0x289390")]
			public float max;

			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x2893C4", Offset = "0x2893C4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2893C4", Offset = "0x2893C4")]
			public float speed;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289410", Offset = "0x289410")]
			public bool showDebug;

			[Token(Token = "0x17000056")]
			public static EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x60001D1")]
				[Address(RVA = "0x164F380", Offset = "0x164F380", VA = "0x164F380")]
				get
				{
					return default(EyeAdaptationSettings);
				}
			}
		}

		[Token(Token = "0x2000096")]
		public enum Tonemapper
		{
			[Token(Token = "0x400036D")]
			ACES,
			[Token(Token = "0x400036E")]
			Curve,
			[Token(Token = "0x400036F")]
			Hable,
			[Token(Token = "0x4000370")]
			HejlDawson,
			[Token(Token = "0x4000371")]
			Photographic,
			[Token(Token = "0x4000372")]
			Reinhard,
			[Token(Token = "0x4000373")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289444", Offset = "0x289444")]
			public Tonemapper tonemapper;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x289478", Offset = "0x289478")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289478", Offset = "0x289478")]
			public float exposure;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2894C4", Offset = "0x2894C4")]
			public AnimationCurve curve;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2894F8", Offset = "0x2894F8")]
			public float neutralBlackIn;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289518", Offset = "0x289518")]
			public float neutralWhiteIn;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289534", Offset = "0x289534")]
			public float neutralBlackOut;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289554", Offset = "0x289554")]
			public float neutralWhiteOut;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289570", Offset = "0x289570")]
			public float neutralWhiteLevel;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289590", Offset = "0x289590")]
			public float neutralWhiteClip;

			[Token(Token = "0x17000057")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60001D2")]
				[Address(RVA = "0x164F3B8", Offset = "0x164F3B8", VA = "0x164F3B8")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public struct LUTSettings
		{
			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2895AC", Offset = "0x2895AC")]
			public Texture texture;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2895E0", Offset = "0x2895E0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2895E0", Offset = "0x2895E0")]
			public float contribution;

			[Token(Token = "0x17000058")]
			public static LUTSettings defaultSettings
			{
				[Token(Token = "0x60001D3")]
				[Address(RVA = "0x164F558", Offset = "0x164F558", VA = "0x164F558")]
				get
				{
					return default(LUTSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x289630", Offset = "0x289630")]
			public Color shadows;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x289644", Offset = "0x289644")]
			public Color midtones;

			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x289658", Offset = "0x289658")]
			public Color highlights;

			[Token(Token = "0x17000059")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60001D4")]
				[Address(RVA = "0x1654DB4", Offset = "0x1654DB4", VA = "0x1654DB4")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200009A")]
		public struct BasicsSettings
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28966C", Offset = "0x28966C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28966C", Offset = "0x28966C")]
			public float temperatureShift;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2896BC", Offset = "0x2896BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2896BC", Offset = "0x2896BC")]
			public float tint;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x28970C", Offset = "0x28970C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28970C", Offset = "0x28970C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28970C", Offset = "0x28970C")]
			public float hue;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28976C", Offset = "0x28976C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28976C", Offset = "0x28976C")]
			public float saturation;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2897BC", Offset = "0x2897BC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2897BC", Offset = "0x2897BC")]
			public float vibrance;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289810", Offset = "0x289810")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289810", Offset = "0x289810")]
			public float value;

			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289864", Offset = "0x289864")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x289864", Offset = "0x289864")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289864", Offset = "0x289864")]
			public float contrast;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x2898C4", Offset = "0x2898C4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x2898C4", Offset = "0x2898C4")]
			public float gain;

			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x28991C", Offset = "0x28991C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x28991C", Offset = "0x28991C")]
			public float gamma;

			[Token(Token = "0x1700005A")]
			public static BasicsSettings defaultSettings
			{
				[Token(Token = "0x60001D5")]
				[Address(RVA = "0x1654C48", Offset = "0x1654C48", VA = "0x1654C48")]
				get
				{
					return default(BasicsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200009B")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int currentChannel;

			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3[] channels;

			[Token(Token = "0x1700005B")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0x1654CA0", Offset = "0x1654CA0", VA = "0x1654CA0")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200009C")]
		public struct CurvesSettings
		{
			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "Curve", RVA = "0x289974", Offset = "0x289974")]
			public AnimationCurve master;

			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "Curve", RVA = "0x289984", Offset = "0x289984")]
			public AnimationCurve red;

			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "Curve", RVA = "0x2899C0", Offset = "0x2899C0")]
			public AnimationCurve green;

			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "Curve", RVA = "0x2899FC", Offset = "0x2899FC")]
			public AnimationCurve blue;

			[Token(Token = "0x1700005C")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x60001D7")]
				[Address(RVA = "0x1654E20", Offset = "0x1654E20", VA = "0x1654E20")]
				get
				{
					return default(CurvesSettings);
				}
			}

			[Token(Token = "0x1700005D")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0x1654FFC", Offset = "0x1654FFC", VA = "0x1654FFC")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x200009D")]
		public enum ColorGradingPrecision
		{
			[Token(Token = "0x4000394")]
			Normal = 0x10,
			[Token(Token = "0x4000395")]
			High = 0x20
		}

		[Serializable]
		[Token(Token = "0x200009E")]
		public struct ColorGradingSettings
		{
			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289A38", Offset = "0x289A38")]
			public ColorGradingPrecision precision;

			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289A6C", Offset = "0x289A6C")]
			[AttributeAttribute(Name = "ColorWheelGroup", RVA = "0x289A6C", Offset = "0x289A6C")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289A9C", Offset = "0x289A9C")]
			[IndentedGroup]
			public BasicsSettings basics;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289ACC", Offset = "0x289ACC")]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289AFC", Offset = "0x289AFC")]
			[IndentedGroup]
			public CurvesSettings curves;

			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x289B2C", Offset = "0x289B2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289B2C", Offset = "0x289B2C")]
			public bool useDithering;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x289B74", Offset = "0x289B74")]
			public bool showDebug;

			[Token(Token = "0x1700005E")]
			public static ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x60001D9")]
				[Address(RVA = "0x164F460", Offset = "0x164F460", VA = "0x164F460")]
				get
				{
					return default(ColorGradingSettings);
				}
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1654EA4", Offset = "0x1654EA4", VA = "0x1654EA4")]
			internal void Reset()
			{
			}
		}

		[Token(Token = "0x200009F")]
		private enum Pass
		{
			[Token(Token = "0x400039F")]
			LutGen,
			[Token(Token = "0x40003A0")]
			AdaptationLog,
			[Token(Token = "0x40003A1")]
			AdaptationExpBlend,
			[Token(Token = "0x40003A2")]
			AdaptationExp,
			[Token(Token = "0x40003A3")]
			TonemappingOff,
			[Token(Token = "0x40003A4")]
			TonemappingACES,
			[Token(Token = "0x40003A5")]
			TonemappingCurve,
			[Token(Token = "0x40003A6")]
			TonemappingHable,
			[Token(Token = "0x40003A7")]
			TonemappingHejlDawson,
			[Token(Token = "0x40003A8")]
			TonemappingPhotographic,
			[Token(Token = "0x40003A9")]
			TonemappingReinhard,
			[Token(Token = "0x40003AA")]
			TonemappingNeutral,
			[Token(Token = "0x40003AB")]
			AdaptationDebug
		}

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SettingsGroup]
		[SerializeField]
		private LUTSettings m_Lut;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Texture2D m_IdentityLut;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private RenderTexture m_InternalLut;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Texture2D m_CurveTexture;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Texture2D m_TonemapperCurve;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float m_TonemapperCurveRange;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material m_Material;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2892F0", Offset = "0x2892F0")]
		private bool <validRenderTextureFormat>k__BackingField;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289300", Offset = "0x289300")]
		private bool <validUserLutSize>k__BackingField;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEE")]
		private bool m_Dirty;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEF")]
		private bool m_TonemapperDirty;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture m_SmallAdaptiveRt;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		[Token(Token = "0x17000048")]
		public EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x164BC88", Offset = "0x164BC88", VA = "0x164BC88")]
			get
			{
				return default(EyeAdaptationSettings);
			}
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x164BCA0", Offset = "0x164BCA0", VA = "0x164BCA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public TonemappingSettings tonemapping
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x164BCBC", Offset = "0x164BCBC", VA = "0x164BCBC")]
			get
			{
				return default(TonemappingSettings);
			}
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x164BCDC", Offset = "0x164BCDC", VA = "0x164BCDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public ColorGradingSettings colorGrading
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x164BD30", Offset = "0x164BD30", VA = "0x164BD30")]
			get
			{
				return default(ColorGradingSettings);
			}
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x164BD48", Offset = "0x164BD48", VA = "0x164BD48")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public LUTSettings lut
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x164BDA4", Offset = "0x164BDA4", VA = "0x164BDA4")]
			get
			{
				return default(LUTSettings);
			}
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x164BDB8", Offset = "0x164BDB8", VA = "0x164BDB8")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		private Texture2D identityLut
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x164BDCC", Offset = "0x164BDCC", VA = "0x164BDCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x164C1D8", Offset = "0x164C1D8", VA = "0x164C1D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x164C404", Offset = "0x164C404", VA = "0x164C404")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x164C5D4", Offset = "0x164C5D4", VA = "0x164C5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public Shader shader
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x164C7D4", Offset = "0x164C7D4", VA = "0x164C7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Material material
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x164C898", Offset = "0x164C898", VA = "0x164C898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x164C948", Offset = "0x164C948", VA = "0x164C948")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public int lutSize
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x164BED4", Offset = "0x164BED4", VA = "0x164BED4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000054")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x164C964", Offset = "0x164C964", VA = "0x164C964")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289CB0", Offset = "0x289CB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x164C96C", Offset = "0x164C96C", VA = "0x164C96C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289CC0", Offset = "0x289CC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool validUserLutSize
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x164C974", Offset = "0x164C974", VA = "0x164C974")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289CD0", Offset = "0x289CD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x164C97C", Offset = "0x164C97C", VA = "0x164C97C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x289CE0", Offset = "0x289CE0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x164BD98", Offset = "0x164BD98", VA = "0x164BD98")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x164BD24", Offset = "0x164BD24", VA = "0x164BD24")]
		public void SetTonemapperDirty()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x164C984", Offset = "0x164C984", VA = "0x164C984")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x164C9E0", Offset = "0x164C9E0", VA = "0x164C9E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x164CD4C", Offset = "0x164CD4C", VA = "0x164CD4C")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x164BEDC", Offset = "0x164BEDC", VA = "0x164BEDC")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x164CD58", Offset = "0x164CD58", VA = "0x164CD58")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x164CD88", Offset = "0x164CD88", VA = "0x164CD88")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x164CE14", Offset = "0x164CE14", VA = "0x164CE14")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x164CF1C", Offset = "0x164CF1C", VA = "0x164CF1C")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x164CFBC", Offset = "0x164CFBC", VA = "0x164CFBC")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x164D1F4", Offset = "0x164D1F4", VA = "0x164D1F4")]
		private void GenCurveTexture()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x164D474", Offset = "0x164D474", VA = "0x164D474")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x164D528", Offset = "0x164D528", VA = "0x164D528")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x164D664", Offset = "0x164D664", VA = "0x164D664")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x164D8D8", Offset = "0x164D8D8", VA = "0x164D8D8")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x164F0C4", Offset = "0x164F0C4", VA = "0x164F0C4")]
		public Texture2D BakeLUT()
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x164F270", Offset = "0x164F270", VA = "0x164F270")]
		public TonemappingColorGrading()
		{
		}
	}
}
namespace wvr
{
	[Token(Token = "0x20000A0")]
	public class Interop
	{
		[PreserveSig]
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x13333B0", Offset = "0x13333B0", VA = "0x13333B0")]
		public static extern bool WVR_PollEventQueue(ref WVR_Event_t e);

		[PreserveSig]
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1333458", Offset = "0x1333458", VA = "0x1333458")]
		public static extern int WVR_GetInputDeviceCapability(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1333500", Offset = "0x1333500", VA = "0x1333500")]
		public static extern WVR_AnalogType WVR_GetInputDeviceAnalogType(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x13335A8", Offset = "0x13335A8", VA = "0x13335A8")]
		public static extern bool WVR_GetInputDeviceState(WVR_DeviceType type, uint inputMask, ref uint buttons, ref uint touches, [In][Out] WVR_AnalogState_t[] analogArray, uint analogArrayCount);

		[PreserveSig]
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1333680", Offset = "0x1333680", VA = "0x1333680")]
		public static extern int WVR_GetInputTypeCount(WVR_DeviceType type, WVR_InputType inputType);

		[PreserveSig]
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1333728", Offset = "0x1333728", VA = "0x1333728")]
		public static extern bool WVR_GetInputButtonState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x13337D8", Offset = "0x13337D8", VA = "0x13337D8")]
		public static extern bool WVR_GetInputTouchState(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1333888", Offset = "0x1333888", VA = "0x1333888")]
		public static extern WVR_Axis_t WVR_GetInputAnalogAxis(WVR_DeviceType type, WVR_InputId id);

		[PreserveSig]
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1333938", Offset = "0x1333938", VA = "0x1333938")]
		public static extern void WVR_GetPoseState(WVR_DeviceType type, WVR_PoseOriginModel originModel, uint predictedMilliSec, ref WVR_PoseState_t poseState);

		[PreserveSig]
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1333A50", Offset = "0x1333A50", VA = "0x1333A50")]
		public static extern void WVR_GetSyncPose(WVR_PoseOriginModel originModel, [In][Out] WVR_DevicePosePair_t[] poseArray, uint pairArrayCount);

		[PreserveSig]
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1333C08", Offset = "0x1333C08", VA = "0x1333C08")]
		public static extern bool WVR_IsDeviceConnected(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1333CB0", Offset = "0x1333CB0", VA = "0x1333CB0")]
		public static extern void WVR_TriggerVibrator(WVR_DeviceType type, WVR_InputId id, ushort durationMicroSec);

		[PreserveSig]
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1333D60", Offset = "0x1333D60", VA = "0x1333D60")]
		public static extern void WVR_InAppRecenter(WVR_RecenterType recenterType);

		[PreserveSig]
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1333E00", Offset = "0x1333E00", VA = "0x1333E00")]
		public static extern void WVR_SetNeckModelEnabled(bool enabled);

		[PreserveSig]
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1333EA0", Offset = "0x1333EA0", VA = "0x1333EA0")]
		public static extern void WVR_SetNeckModel(WVR_SimulationType simulationType);

		[PreserveSig]
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1333F40", Offset = "0x1333F40", VA = "0x1333F40")]
		public static extern void WVR_SetArmModel(WVR_SimulationType simulationType);

		[PreserveSig]
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1333FE0", Offset = "0x1333FE0", VA = "0x1333FE0")]
		public static extern void WVR_SetArmSticky(bool stickyArm);

		[PreserveSig]
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1334080", Offset = "0x1334080", VA = "0x1334080")]
		public static extern bool WVR_SetInputRequest(WVR_DeviceType type, WVR_InputAttribute_t[] request, uint size);

		[PreserveSig]
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1334140", Offset = "0x1334140", VA = "0x1334140")]
		public static extern bool WVR_GetInputMappingPair(WVR_DeviceType type, WVR_InputId destination, ref WVR_InputMappingPair_t pair);

		[PreserveSig]
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x13341F8", Offset = "0x13341F8", VA = "0x13341F8")]
		public static extern uint WVR_GetInputMappingTable(WVR_DeviceType type, [In][Out] WVR_InputMappingPair_t[] table, uint size);

		[PreserveSig]
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x13342B0", Offset = "0x13342B0", VA = "0x13342B0")]
		public static extern WVR_Arena_t WVR_GetArena();

		[PreserveSig]
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1334350", Offset = "0x1334350", VA = "0x1334350")]
		public static extern bool WVR_SetArena(ref WVR_Arena_t arena);

		[PreserveSig]
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x13343F8", Offset = "0x13343F8", VA = "0x13343F8")]
		public static extern WVR_ArenaVisible WVR_GetArenaVisible();

		[PreserveSig]
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1334490", Offset = "0x1334490", VA = "0x1334490")]
		public static extern void WVR_SetArenaVisible(WVR_ArenaVisible config);

		[PreserveSig]
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1334530", Offset = "0x1334530", VA = "0x1334530")]
		public static extern bool WVR_IsOverArenaRange();

		[PreserveSig]
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x13345D0", Offset = "0x13345D0", VA = "0x13345D0")]
		public static extern float WVR_GetDeviceBatteryPercentage(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1334670", Offset = "0x1334670", VA = "0x1334670")]
		public static extern WVR_BatteryStatus WVR_GetBatteryStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1334710", Offset = "0x1334710", VA = "0x1334710")]
		public static extern WVR_ChargeStatus WVR_GetChargeStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x13347B0", Offset = "0x13347B0", VA = "0x13347B0")]
		public static extern WVR_BatteryTemperatureStatus WVR_GetBatteryTemperatureStatus(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1334850", Offset = "0x1334850", VA = "0x1334850")]
		public static extern float WVR_GetBatteryTemperature(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x13348F0", Offset = "0x13348F0", VA = "0x13348F0")]
		public static extern WVR_InitError WVR_Init(WVR_AppType eType);

		[PreserveSig]
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1334990", Offset = "0x1334990", VA = "0x1334990")]
		public static extern void WVR_Quit();

		[PreserveSig]
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1334A28", Offset = "0x1334A28", VA = "0x1334A28")]
		public static extern IntPtr WVR_GetInitErrorString(WVR_InitError error);

		[PreserveSig]
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1334AC8", Offset = "0x1334AC8", VA = "0x1334AC8")]
		public static extern uint WVR_GetWaveRuntimeVersion();

		[PreserveSig]
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1334B60", Offset = "0x1334B60", VA = "0x1334B60")]
		public static extern uint WVR_GetWaveSDKVersion();

		[PreserveSig]
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x1334BF8", Offset = "0x1334BF8", VA = "0x1334BF8")]
		public static extern bool WVR_IsInputFocusCapturedBySystem();

		[PreserveSig]
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1334C98", Offset = "0x1334C98", VA = "0x1334C98")]
		internal static extern WVR_RenderError WVR_RenderInit(ref WVR_RenderInitParams_t param);

		[PreserveSig]
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1334D38", Offset = "0x1334D38", VA = "0x1334D38")]
		internal static extern bool WVR_SetPerformanceLevels(WVR_PerfLevel cpuLevel, WVR_PerfLevel gpuLevel);

		[PreserveSig]
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1334DE8", Offset = "0x1334DE8", VA = "0x1334DE8")]
		public static extern bool WVR_StartCamera(ref WVR_CameraInfo_t info);

		[PreserveSig]
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1334E90", Offset = "0x1334E90", VA = "0x1334E90")]
		public static extern void WVR_StopCamera();

		[PreserveSig]
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1334F28", Offset = "0x1334F28", VA = "0x1334F28")]
		public static extern bool WVR_UpdateTexture(uint textureid);

		[PreserveSig]
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1334FD0", Offset = "0x1334FD0", VA = "0x1334FD0")]
		public static extern bool WVR_GetCameraIntrinsic(WVR_CameraPosition position, ref WVR_CameraIntrinsic_t intrinsic);

		[PreserveSig]
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1335080", Offset = "0x1335080", VA = "0x1335080")]
		public static extern bool WVR_IsDeviceSuspend(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1335128", Offset = "0x1335128", VA = "0x1335128")]
		public static extern void WVR_ConvertMatrixQuaternion(ref WVR_Matrix4f_t mat, ref WVR_Quatf_t quat, bool m2q);

		[PreserveSig]
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x13351D8", Offset = "0x13351D8", VA = "0x13351D8")]
		public static extern WVR_NumDoF WVR_GetDegreeOfFreedom(WVR_DeviceType type);

		[PreserveSig]
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1335278", Offset = "0x1335278", VA = "0x1335278")]
		public static extern void WVR_SetParameters(WVR_DeviceType type, IntPtr pchValue);

		[PreserveSig]
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1335320", Offset = "0x1335320", VA = "0x1335320")]
		public static extern uint WVR_GetParameters(WVR_DeviceType type, IntPtr pchValue, IntPtr retValue, uint unBufferSize);

		[PreserveSig]
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x13353D8", Offset = "0x13353D8", VA = "0x13353D8")]
		public static extern WVR_DeviceType WVR_GetDefaultControllerRole();

		[PreserveSig]
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1335470", Offset = "0x1335470", VA = "0x1335470")]
		public static extern bool WVR_SetInteractionMode(WVR_InteractionMode mode);

		[PreserveSig]
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1335518", Offset = "0x1335518", VA = "0x1335518")]
		public static extern WVR_InteractionMode WVR_GetInteractionMode();

		[PreserveSig]
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x13355B0", Offset = "0x13355B0", VA = "0x13355B0")]
		public static extern bool WVR_SetGazeTriggerType(WVR_GazeTriggerType type);

		[PreserveSig]
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1335658", Offset = "0x1335658", VA = "0x1335658")]
		public static extern WVR_GazeTriggerType WVR_GetGazeTriggerType();

		[PreserveSig]
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x13356F0", Offset = "0x13356F0", VA = "0x13356F0")]
		public static extern bool WVR_GetDeviceErrorState(WVR_DeviceType dev_type, WVR_DeviceErrorState error_state);

		[PreserveSig]
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x13357A0", Offset = "0x13357A0", VA = "0x13357A0")]
		public static extern void WVR_GetRenderTargetSize(ref uint width, ref uint height);

		[PreserveSig]
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1335848", Offset = "0x1335848", VA = "0x1335848")]
		public static extern WVR_Matrix4f_t WVR_GetProjection(WVR_Eye eye, float near, float far);

		[PreserveSig]
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1335900", Offset = "0x1335900", VA = "0x1335900")]
		public static extern void WVR_GetClippingPlaneBoundary(WVR_Eye eye, ref float left, ref float right, ref float top, ref float bottom);

		[PreserveSig]
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x13359C0", Offset = "0x13359C0", VA = "0x13359C0")]
		public static extern void WVR_SetOverfillRatio(float ratioX, float ratioY);

		[PreserveSig]
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1335A68", Offset = "0x1335A68", VA = "0x1335A68")]
		public static extern WVR_Matrix4f_t WVR_GetTransformFromEyeToHead(WVR_Eye eye, WVR_NumDoF dof);

		[PreserveSig]
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1335B18", Offset = "0x1335B18", VA = "0x1335B18")]
		public static extern WVR_SubmitError WVR_SubmitFrame(WVR_Eye eye, ref WVR_TextureParams_t param, ref WVR_PoseState_t pose, WVR_SubmitExtend extendMethod);

		[PreserveSig]
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1335C38", Offset = "0x1335C38", VA = "0x1335C38")]
		public static extern bool WVR_RequestScreenshot(uint width, uint height, WVR_ScreenshotMode mode, IntPtr filename);

		[PreserveSig]
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1335CF8", Offset = "0x1335CF8", VA = "0x1335CF8")]
		public static extern void WVR_RenderMask(WVR_Eye eye);

		[PreserveSig]
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1335D98", Offset = "0x1335D98", VA = "0x1335D98")]
		public static extern bool WVR_GetRenderProps(ref WVR_RenderProps_t props);

		[PreserveSig]
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1335EA8", Offset = "0x1335EA8", VA = "0x1335EA8")]
		public static extern IntPtr WVR_ObtainTextureQueue(WVR_TextureTarget target, WVR_TextureFormat format, WVR_TextureType type, uint width, uint height, int level);

		[PreserveSig]
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1335F70", Offset = "0x1335F70", VA = "0x1335F70")]
		public static extern uint WVR_GetTextureQueueLength(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1336010", Offset = "0x1336010", VA = "0x1336010")]
		public static extern WVR_TextureParams_t WVR_GetTexture(IntPtr handle, int index);

		[PreserveSig]
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x13360B8", Offset = "0x13360B8", VA = "0x13360B8")]
		public static extern int WVR_GetAvailableTextureIndex(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1336158", Offset = "0x1336158", VA = "0x1336158")]
		public static extern void WVR_ReleaseTextureQueue(IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x13361F8", Offset = "0x13361F8", VA = "0x13361F8")]
		public static extern bool WVR_IsRenderFoveationSupport();

		[PreserveSig]
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1336298", Offset = "0x1336298", VA = "0x1336298")]
		public static extern void WVR_RenderFoveation(bool enable);

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1336338", Offset = "0x1336338", VA = "0x1336338")]
		public Interop()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public enum WVR_AppType
	{
		[Token(Token = "0x40003AD")]
		WVR_AppType_VRContent = 1,
		[Token(Token = "0x40003AE")]
		WVR_AppType_NonVRContent
	}
	[Token(Token = "0x20000A2")]
	public enum WVR_InitError
	{
		[Token(Token = "0x40003B0")]
		WVR_InitError_None,
		[Token(Token = "0x40003B1")]
		WVR_InitError_Unknown,
		[Token(Token = "0x40003B2")]
		WVR_InitError_NotInitialized
	}
	[Token(Token = "0x20000A3")]
	public enum WVR_EventType
	{
		[Token(Token = "0x40003B4")]
		WVR_EventType_Quit = 1000,
		[Token(Token = "0x40003B5")]
		WVR_EventType_SystemInteractionModeChanged = 1001,
		[Token(Token = "0x40003B6")]
		WVR_EventType_SystemGazeTriggerTypeChanged = 1002,
		[Token(Token = "0x40003B7")]
		WVR_EventType_TrackingModeChanged = 1003,
		[Token(Token = "0x40003B8")]
		WVR_EventType_DeviceConnected = 2000,
		[Token(Token = "0x40003B9")]
		WVR_EventType_DeviceDisconnected = 2001,
		[Token(Token = "0x40003BA")]
		WVR_EventType_DeviceStatusUpdate = 2002,
		[Token(Token = "0x40003BB")]
		WVR_EventType_DeviceSuspend = 2003,
		[Token(Token = "0x40003BC")]
		WVR_EventType_DeviceResume = 2004,
		[Token(Token = "0x40003BD")]
		WVR_EventType_IpdChanged = 2005,
		[Token(Token = "0x40003BE")]
		WVR_EventType_DeviceRoleChanged = 2006,
		[Token(Token = "0x40003BF")]
		WVR_EventType_BatteryStatusUpdate = 2007,
		[Token(Token = "0x40003C0")]
		WVR_EventType_ChargeStatusUpdate = 2008,
		[Token(Token = "0x40003C1")]
		WVR_EventType_DeviceErrorStatusUpdate = 2009,
		[Token(Token = "0x40003C2")]
		WVR_EventType_BatteryTemperatureStatusUpdate = 2010,
		[Token(Token = "0x40003C3")]
		WVR_EventType_RecenterSuccess = 2011,
		[Token(Token = "0x40003C4")]
		WVR_EventType_RecenterFail = 2012,
		[Token(Token = "0x40003C5")]
		WVR_EventType_RecenterSuccess3DoF = 2013,
		[Token(Token = "0x40003C6")]
		WVR_EventType_RecenterFail3DoF = 2014,
		[Token(Token = "0x40003C7")]
		WVR_EventType_ButtonPressed = 3000,
		[Token(Token = "0x40003C8")]
		WVR_EventType_ButtonUnpressed = 3001,
		[Token(Token = "0x40003C9")]
		WVR_EventType_TouchTapped = 3002,
		[Token(Token = "0x40003CA")]
		WVR_EventType_TouchUntapped = 3003,
		[Token(Token = "0x40003CB")]
		WVR_EventType_LeftToRightSwipe = 3004,
		[Token(Token = "0x40003CC")]
		WVR_EventType_RightToLeftSwipe = 3005,
		[Token(Token = "0x40003CD")]
		WVR_EventType_DownToUpSwipe = 3006,
		[Token(Token = "0x40003CE")]
		WVR_EventType_UpToDownSwipe = 3007
	}
	[Token(Token = "0x20000A4")]
	public enum WVR_PeripheralQuality
	{
		[Token(Token = "0x40003D0")]
		Low,
		[Token(Token = "0x40003D1")]
		Middle,
		[Token(Token = "0x40003D2")]
		High
	}
	[Token(Token = "0x20000A5")]
	public enum WVR_DeviceType
	{
		[Token(Token = "0x40003D4")]
		WVR_DeviceType_Invalid,
		[Token(Token = "0x40003D5")]
		WVR_DeviceType_HMD,
		[Token(Token = "0x40003D6")]
		WVR_DeviceType_Controller_Right,
		[Token(Token = "0x40003D7")]
		WVR_DeviceType_Controller_Left
	}
	[Token(Token = "0x20000A6")]
	public enum WVR_RecenterType
	{
		[Token(Token = "0x40003D9")]
		WVR_RecenterType_Disabled,
		[Token(Token = "0x40003DA")]
		WVR_RecenterType_YawOnly,
		[Token(Token = "0x40003DB")]
		WVR_RecenterType_YawAndPosition,
		[Token(Token = "0x40003DC")]
		WVR_RecenterType_RotationAndPosition
	}
	[Token(Token = "0x20000A7")]
	public enum WVR_InputType
	{
		[Token(Token = "0x40003DE")]
		WVR_InputType_Button = 1,
		[Token(Token = "0x40003DF")]
		WVR_InputType_Touch = 2,
		[Token(Token = "0x40003E0")]
		WVR_InputType_Analog = 4
	}
	[Token(Token = "0x20000A8")]
	public enum WVR_BatteryStatus
	{
		[Token(Token = "0x40003E2")]
		WVR_BatteryStatus_Unknown,
		[Token(Token = "0x40003E3")]
		WVR_BatteryStatus_Normal,
		[Token(Token = "0x40003E4")]
		WVR_BatteryStatus_Low,
		[Token(Token = "0x40003E5")]
		WVR_BatteryStatus_UltraLow
	}
	[Token(Token = "0x20000A9")]
	public enum WVR_ChargeStatus
	{
		[Token(Token = "0x40003E7")]
		WVR_ChargeStatus_Unknown,
		[Token(Token = "0x40003E8")]
		WVR_ChargeStatus_Discharging,
		[Token(Token = "0x40003E9")]
		WVR_ChargeStatus_Charging,
		[Token(Token = "0x40003EA")]
		WVR_ChargeStatus_Full
	}
	[Token(Token = "0x20000AA")]
	public enum WVR_BatteryTemperatureStatus
	{
		[Token(Token = "0x40003EC")]
		WVR_BatteryTemperature_Unknown,
		[Token(Token = "0x40003ED")]
		WVR_BatteryTemperature_Normal,
		[Token(Token = "0x40003EE")]
		WVR_BatteryTemperature_Overheat,
		[Token(Token = "0x40003EF")]
		WVR_BatteryTemperature_UltraOverheat
	}
	[Token(Token = "0x20000AB")]
	public enum WVR_DeviceErrorStatus
	{
		[Token(Token = "0x40003F1")]
		WVR_DeviceErrorStatus_None = 0,
		[Token(Token = "0x40003F2")]
		WVR_DeviceErrorStatus_BatteryOverheat = 1,
		[Token(Token = "0x40003F3")]
		WVR_DeviceErrorStatus_BatteryOverheatRestore = 2,
		[Token(Token = "0x40003F4")]
		WVR_DeviceErrorStatus_BatteryOvervoltage = 4,
		[Token(Token = "0x40003F5")]
		WVR_DeviceErrorStatus_BatteryOvervoltageRestore = 8,
		[Token(Token = "0x40003F6")]
		WVR_DeviceErrorStatus_DeviceConnectFail = 0x10,
		[Token(Token = "0x40003F7")]
		WVR_DeviceErrorStatus_DeviceConnectRestore = 0x20,
		[Token(Token = "0x40003F8")]
		WVR_DeviceErrorStatus_DeviceLostTracking = 0x40,
		[Token(Token = "0x40003F9")]
		WVR_DeviceErrorStatus_DeviceLostTrackingRestore = 0x80,
		[Token(Token = "0x40003FA")]
		WVR_DeviceErrorStatus_ChargeFail = 0x100,
		[Token(Token = "0x40003FB")]
		WVR_DeviceErrorStatus_ChargeRestore = 0x200
	}
	[Token(Token = "0x20000AC")]
	public enum WVR_DeviceErrorState
	{
		[Token(Token = "0x40003FD")]
		WVR_DeviceErrorState_None,
		[Token(Token = "0x40003FE")]
		WVR_DeviceErrorState_BatteryOverheat,
		[Token(Token = "0x40003FF")]
		WVR_DeviceErrorState_BatteryOvervoltage,
		[Token(Token = "0x4000400")]
		WVR_DeviceErrorState_DeviceConnectFail,
		[Token(Token = "0x4000401")]
		WVR_DeviceErrorState_DeviceLostTracking,
		[Token(Token = "0x4000402")]
		WVR_DeviceErrorState_ChargeFail
	}
	[Token(Token = "0x20000AD")]
	public enum WVR_InputId
	{
		[Token(Token = "0x4000404")]
		WVR_InputId_0 = 0,
		[Token(Token = "0x4000405")]
		WVR_InputId_1 = 1,
		[Token(Token = "0x4000406")]
		WVR_InputId_2 = 2,
		[Token(Token = "0x4000407")]
		WVR_InputId_3 = 3,
		[Token(Token = "0x4000408")]
		WVR_InputId_4 = 4,
		[Token(Token = "0x4000409")]
		WVR_InputId_5 = 5,
		[Token(Token = "0x400040A")]
		WVR_InputId_6 = 6,
		[Token(Token = "0x400040B")]
		WVR_InputId_7 = 7,
		[Token(Token = "0x400040C")]
		WVR_InputId_8 = 8,
		[Token(Token = "0x400040D")]
		WVR_InputId_9 = 9,
		[Token(Token = "0x400040E")]
		WVR_InputId_15 = 15,
		[Token(Token = "0x400040F")]
		WVR_InputId_16 = 16,
		[Token(Token = "0x4000410")]
		WVR_InputId_17 = 17,
		[Token(Token = "0x4000411")]
		WVR_InputId_18 = 18,
		[Token(Token = "0x4000412")]
		WVR_InputId_Alias1_System = 0,
		[Token(Token = "0x4000413")]
		WVR_InputId_Alias1_Menu = 1,
		[Token(Token = "0x4000414")]
		WVR_InputId_Alias1_Grip = 2,
		[Token(Token = "0x4000415")]
		WVR_InputId_Alias1_DPad_Left = 3,
		[Token(Token = "0x4000416")]
		WVR_InputId_Alias1_DPad_Up = 4,
		[Token(Token = "0x4000417")]
		WVR_InputId_Alias1_DPad_Right = 5,
		[Token(Token = "0x4000418")]
		WVR_InputId_Alias1_DPad_Down = 6,
		[Token(Token = "0x4000419")]
		WVR_InputId_Alias1_Volume_Up = 7,
		[Token(Token = "0x400041A")]
		WVR_InputId_Alias1_Volume_Down = 8,
		[Token(Token = "0x400041B")]
		WVR_InputId_Alias1_Digital_Trigger = 9,
		[Token(Token = "0x400041C")]
		WVR_InputId_Alias1_Enter = 15,
		[Token(Token = "0x400041D")]
		WVR_InputId_Alias1_Touchpad = 16,
		[Token(Token = "0x400041E")]
		WVR_InputId_Alias1_Trigger = 17,
		[Token(Token = "0x400041F")]
		WVR_InputId_Alias1_Thumbstick = 18,
		[Token(Token = "0x4000420")]
		WVR_InputId_Max = 32
	}
	[Token(Token = "0x20000AE")]
	public enum WVR_AnalogType
	{
		[Token(Token = "0x4000422")]
		WVR_AnalogType_None,
		[Token(Token = "0x4000423")]
		WVR_AnalogType_2D,
		[Token(Token = "0x4000424")]
		WVR_AnalogType_1D
	}
	[Token(Token = "0x20000AF")]
	public enum WVR_PoseOriginModel
	{
		[Token(Token = "0x4000426")]
		WVR_PoseOriginModel_OriginOnHead,
		[Token(Token = "0x4000427")]
		WVR_PoseOriginModel_OriginOnGround,
		[Token(Token = "0x4000428")]
		WVR_PoseOriginModel_OriginOnTrackingObserver,
		[Token(Token = "0x4000429")]
		WVR_PoseOriginModel_OriginOnHead_3DoF
	}
	[Token(Token = "0x20000B0")]
	public enum WVR_ArenaVisible
	{
		[Token(Token = "0x400042B")]
		WVR_ArenaVisible_Auto,
		[Token(Token = "0x400042C")]
		WVR_ArenaVisible_ForceOn,
		[Token(Token = "0x400042D")]
		WVR_ArenaVisible_ForceOff
	}
	[Token(Token = "0x20000B1")]
	public enum WVR_GraphicsApiType
	{
		[Token(Token = "0x400042F")]
		WVR_GraphicsApiType_OpenGL = 1
	}
	[Token(Token = "0x20000B2")]
	public enum WVR_ScreenshotMode
	{
		[Token(Token = "0x4000431")]
		WVR_ScreenshotMode_Default,
		[Token(Token = "0x4000432")]
		WVR_ScreenshotMode_Raw,
		[Token(Token = "0x4000433")]
		WVR_ScreenshotMode_Distorted
	}
	[Token(Token = "0x20000B3")]
	public enum WVR_SubmitError
	{
		[Token(Token = "0x4000435")]
		WVR_SubmitError_None = 0,
		[Token(Token = "0x4000436")]
		WVR_SubmitError_InvalidTexture = 400,
		[Token(Token = "0x4000437")]
		WVR_SubmitError_ThreadStop = 401,
		[Token(Token = "0x4000438")]
		WVR_SubmitError_BufferSubmitFailed = 402,
		[Token(Token = "0x4000439")]
		WVR_SubmitError_Max = 65535
	}
	[Token(Token = "0x20000B4")]
	public enum WVR_SubmitExtend
	{
		[Token(Token = "0x400043B")]
		WVR_SubmitExtend_Default,
		[Token(Token = "0x400043C")]
		WVR_SubmitExtend_DisableDistortion
	}
	[Token(Token = "0x20000B5")]
	public enum WVR_Eye
	{
		[Token(Token = "0x400043E")]
		WVR_Eye_Left,
		[Token(Token = "0x400043F")]
		WVR_Eye_Right,
		[Token(Token = "0x4000440")]
		WVR_Eye_Both,
		[Token(Token = "0x4000441")]
		WVR_Eye_None
	}
	[Token(Token = "0x20000B6")]
	public enum WVR_TextureTarget
	{
		[Token(Token = "0x4000443")]
		WVR_TextureTarget_2D,
		[Token(Token = "0x4000444")]
		WVR_TextureTarget_2D_ARRAY
	}
	[Token(Token = "0x20000B7")]
	public enum WVR_TextureFormat
	{
		[Token(Token = "0x4000446")]
		WVR_TextureFormat_RGBA
	}
	[Token(Token = "0x20000B8")]
	public enum WVR_TextureType
	{
		[Token(Token = "0x4000448")]
		WVR_TextureType_UnsignedByte
	}
	[Token(Token = "0x20000B9")]
	public enum WVR_RenderError
	{
		[Token(Token = "0x400044A")]
		WVR_RenderError_None = 0,
		[Token(Token = "0x400044B")]
		WVR_RenderError_RuntimeInitFailed = 410,
		[Token(Token = "0x400044C")]
		WVR_RenderError_ContextSetupFailed = 411,
		[Token(Token = "0x400044D")]
		WVR_RenderError_DisplaySetupFailed = 412,
		[Token(Token = "0x400044E")]
		WVR_RenderError_LibNotSupported = 413,
		[Token(Token = "0x400044F")]
		WVR_RenderError_NullPtr = 414,
		[Token(Token = "0x4000450")]
		WVR_RenderError_Max = 65535
	}
	[Token(Token = "0x20000BA")]
	public enum WVR_RenderConfig
	{
		[Token(Token = "0x4000452")]
		WVR_RenderConfig_Default = 0,
		[Token(Token = "0x4000453")]
		WVR_RenderConfig_Direct_Mode = 1,
		[Token(Token = "0x4000454")]
		WVR_RenderConfig_MSAA = 2,
		[Token(Token = "0x4000455")]
		WVR_RenderConfig_sRGB = 4,
		[Token(Token = "0x4000456")]
		WVR_RenderConfig_Vertical_Sync = 16,
		[Token(Token = "0x4000457")]
		WVR_RenderConfig_Timewarp = 256,
		[Token(Token = "0x4000458")]
		WVR_RenderConfig_Timewarp_Asynchronous = 768
	}
	[Token(Token = "0x20000BB")]
	public enum WVR_CameraImageType
	{
		[Token(Token = "0x400045A")]
		WVR_CameraImageType_Invalid,
		[Token(Token = "0x400045B")]
		WVR_CameraImageType_SingleEye,
		[Token(Token = "0x400045C")]
		WVR_CameraImageType_DualEye
	}
	[Token(Token = "0x20000BC")]
	public enum WVR_CameraImageFormat
	{
		[Token(Token = "0x400045E")]
		WVR_CameraImageFormat_Invalid,
		[Token(Token = "0x400045F")]
		WVR_CameraImageFormat_YUV_420,
		[Token(Token = "0x4000460")]
		WVR_CameraImageFormat_Grayscale
	}
	[Token(Token = "0x20000BD")]
	public enum WVR_CameraPosition
	{
		[Token(Token = "0x4000462")]
		WVR_CameraPosition_Invalid,
		[Token(Token = "0x4000463")]
		WVR_CameraPosition_left,
		[Token(Token = "0x4000464")]
		WVR_CameraPosition_Right
	}
	[Token(Token = "0x20000BE")]
	public enum WVR_OverlayError
	{
		[Token(Token = "0x4000466")]
		WVR_OverlayError_None = 0,
		[Token(Token = "0x4000467")]
		WVR_OverlayError_UnknownOverlay = 10,
		[Token(Token = "0x4000468")]
		WVR_OverlayError_OverlayUnavailable = 11,
		[Token(Token = "0x4000469")]
		WVR_OverlayError_InvalidParameter = 20
	}
	[Token(Token = "0x20000BF")]
	public enum WVR_OverlayTransformType
	{
		[Token(Token = "0x400046B")]
		WVR_OverlayTransformType_None,
		[Token(Token = "0x400046C")]
		WVR_OverlayTransformType_Absolute,
		[Token(Token = "0x400046D")]
		WVR_OverlayTransformType_Fixed
	}
	[Token(Token = "0x20000C0")]
	public enum WVR_NumDoF
	{
		[Token(Token = "0x400046F")]
		WVR_NumDoF_3DoF,
		[Token(Token = "0x4000470")]
		WVR_NumDoF_6DoF
	}
	[Token(Token = "0x20000C1")]
	public enum WVR_ArenaShape
	{
		[Token(Token = "0x4000472")]
		WVR_ArenaShape_None,
		[Token(Token = "0x4000473")]
		WVR_ArenaShape_Rectangle,
		[Token(Token = "0x4000474")]
		WVR_ArenaShape_Round
	}
	[Token(Token = "0x20000C2")]
	public enum WVR_InteractionMode
	{
		[Token(Token = "0x4000476")]
		WVR_InteractionMode_SystemDefault = 1,
		[Token(Token = "0x4000477")]
		WVR_InteractionMode_Gaze,
		[Token(Token = "0x4000478")]
		WVR_InteractionMode_Controller
	}
	[Token(Token = "0x20000C3")]
	public enum WVR_GazeTriggerType
	{
		[Token(Token = "0x400047A")]
		WVR_GazeTriggerType_Timeout = 1,
		[Token(Token = "0x400047B")]
		WVR_GazeTriggerType_Button,
		[Token(Token = "0x400047C")]
		WVR_GazeTriggerType_TimeoutButton
	}
	[Token(Token = "0x20000C4")]
	public enum WVR_PerfLevel
	{
		[Token(Token = "0x400047E")]
		WVR_PerfLevel_System,
		[Token(Token = "0x400047F")]
		WVR_PerfLevel_Minimum,
		[Token(Token = "0x4000480")]
		WVR_PerfLevel_Medium,
		[Token(Token = "0x4000481")]
		WVR_PerfLevel_Maximum,
		[Token(Token = "0x4000482")]
		WVR_PerfLevel_NumPerfLevels
	}
	[Token(Token = "0x20000C5")]
	public enum WVR_SimulationType
	{
		[Token(Token = "0x4000484")]
		WVR_SimulationType_Auto,
		[Token(Token = "0x4000485")]
		WVR_SimulationType_ForceOn,
		[Token(Token = "0x4000486")]
		WVR_SimulationType_ForceOff
	}
	[Token(Token = "0x20000C6")]
	public struct WVR_RenderInitParams_t
	{
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_GraphicsApiType graphicsApi;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ulong renderConfig;
	}
	[Token(Token = "0x20000C7")]
	public struct WVR_Matrix4f_t
	{
		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float m0;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float m1;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float m2;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float m3;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float m4;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float m5;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m6;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m7;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m8;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m9;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m10;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m11;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m12;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float m13;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float m14;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float m15;
	}
	[Token(Token = "0x20000C8")]
	public struct WVR_Vector2f_t
	{
		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;
	}
	[Token(Token = "0x20000C9")]
	public struct WVR_Vector3f_t
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float v0;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float v1;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float v2;
	}
	[Token(Token = "0x20000CA")]
	public struct WVR_CameraIntrinsic_t
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector2f_t focalLength;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Vector2f_t principalPoint;
	}
	[Token(Token = "0x20000CB")]
	public struct WVR_CameraInfo_t
	{
		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CameraImageType imgType;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_CameraImageFormat imgFormat;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint width;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint height;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint size;
	}
	[Token(Token = "0x20000CC")]
	public struct WVR_Quatf_t
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float w;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float x;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float y;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float z;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000CD")]
	public struct WVR_PoseState_t
	{
		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool IsValidPose;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_Matrix4f_t PoseMatrix;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public WVR_Vector3f_t Velocity;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public WVR_Vector3f_t AngularVelocity;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool Is6DoFPose;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long PoseTimestamp_ns;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public WVR_Vector3f_t Acceleration;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public WVR_Vector3f_t AngularAcceleration;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float PredictedMilliSec;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public WVR_PoseOriginModel OriginModel;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public WVR_Pose_t RawPose;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000CE")]
	public struct WVR_DevicePosePair_t
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceType type;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_PoseState_t pose;
	}
	[Token(Token = "0x20000CF")]
	public struct WVR_TextureParams_t
	{
		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr id;
	}
	[Token(Token = "0x20000D0")]
	public struct WVR_RenderProps_t
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float refreshRate;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool hasExternal;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float ipdMeter;
	}
	[Token(Token = "0x20000D1")]
	public struct WVR_CommonEvent_t
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_EventType type;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public long timestamp;
	}
	[Token(Token = "0x20000D2")]
	public struct WVR_DeviceEvent_t
	{
		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WVR_DeviceType type;
	}
	[Token(Token = "0x20000D3")]
	public struct WVR_InputEvent_t
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WVR_InputId inputId;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000D4")]
	public struct WVR_Event_t
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_CommonEvent_t common;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_DeviceEvent_t device;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputEvent_t input;
	}
	[Token(Token = "0x20000D5")]
	public struct WVR_Axis_t
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000D6")]
	public struct WVR_AnalogState_t
	{
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputId id;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_AnalogType type;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_Axis_t axis;
	}
	[Token(Token = "0x20000D7")]
	public struct WVR_InputAttribute_t
	{
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputId id;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint capability;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WVR_AnalogType axis_type;
	}
	[Token(Token = "0x20000D8")]
	public struct WVR_InputMappingPair_t
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_InputAttribute_t destination;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_InputAttribute_t source;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000D9")]
	public struct WVR_Pose_t
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_Vector3f_t position;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_Quatf_t rotation;
	}
	[Token(Token = "0x20000DA")]
	public struct WVR_OverlayPosition_t
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x20000DB")]
	public struct WVR_OverlayBlendColor_t
	{
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float r;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float g;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float b;
	}
	[Token(Token = "0x20000DC")]
	public struct WVR_OverlayTexture_t
	{
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint textureId;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint width;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint height;
	}
	[Token(Token = "0x20000DD")]
	public struct WVR_ArenaRectangle_t
	{
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float width;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float length;
	}
	[Token(Token = "0x20000DE")]
	public struct WVR_ArenaRound_t
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float diameter;
	}
	[StructLayout(2)]
	[Token(Token = "0x20000DF")]
	public struct WVR_ArenaArea_t
	{
		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRectangle_t rectangle;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaRound_t round;
	}
	[Token(Token = "0x20000E0")]
	public struct WVR_Arena_t
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WVR_ArenaShape shape;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public WVR_ArenaArea_t area;
	}
	[Token(Token = "0x20000E1")]
	public delegate void WVR_OverlayInputEventCallback(int overlayId, WVR_EventType type, WVR_InputId inputId);
	[Token(Token = "0x20000E2")]
	public struct WVR_OverlayInputEvent_t
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int overlayId;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public IntPtr callback;
	}
	[Token(Token = "0x20000E3")]
	public struct WVR_RenderFoveationParams
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float focalX;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float focalY;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float fovealFov;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public WVR_PeripheralQuality periQuality;
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x20000E4")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x40004E6")]
		Array = 1,
		[Token(Token = "0x40004E7")]
		Class,
		[Token(Token = "0x40004E8")]
		Value,
		[Token(Token = "0x40004E9")]
		IntValue,
		[Token(Token = "0x40004EA")]
		DoubleValue,
		[Token(Token = "0x40004EB")]
		BoolValue,
		[Token(Token = "0x40004EC")]
		FloatValue
	}
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x286E48", Offset = "0x286E48")]
	public class JSONNode
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286E7C", Offset = "0x286E7C")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			[Token(Token = "0x1700006B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x1653AF8", Offset = "0x1653AF8", VA = "0x1653AF8", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600025B")]
				[Address(RVA = "0x1653B48", Offset = "0x1653B48", VA = "0x1653B48", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000256")]
			[Address(RVA = "0x1653AB0", Offset = "0x1653AB0", VA = "0x1653AB0")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000257")]
			[Address(RVA = "0x1653ADC", Offset = "0x1653ADC", VA = "0x1653ADC", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000258")]
			[Address(RVA = "0x1653AE0", Offset = "0x1653AE0", VA = "0x1653AE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600025A")]
			[Address(RVA = "0x1653B00", Offset = "0x1653B00", VA = "0x1653B00", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600025C")]
			[Address(RVA = "0x1653B50", Offset = "0x1653B50", VA = "0x1653B50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600025D")]
			[Address(RVA = "0x1653BF4", Offset = "0x1653BF4", VA = "0x1653BF4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286E8C", Offset = "0x286E8C")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public JSONNode <>4__this;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x1700006D")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000263")]
				[Address(RVA = "0x1654368", Offset = "0x1654368", VA = "0x1654368", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000265")]
				[Address(RVA = "0x16543B8", Offset = "0x16543B8", VA = "0x16543B8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600025E")]
			[Address(RVA = "0x1653BF8", Offset = "0x1653BF8", VA = "0x1653BF8")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1653C24", Offset = "0x1653C24", VA = "0x1653C24", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x1653E48", Offset = "0x1653E48", VA = "0x1653E48", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1653D78", Offset = "0x1653D78", VA = "0x1653D78")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1653CA8", Offset = "0x1653CA8", VA = "0x1653CA8")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1654370", Offset = "0x1654370", VA = "0x1654370", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000266")]
			[Address(RVA = "0x16543C0", Offset = "0x16543C0", VA = "0x16543C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1654488", Offset = "0x1654488", VA = "0x1654488", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x133A2C0", Offset = "0x133A2C0", VA = "0x133A2C0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x133A2C8", Offset = "0x133A2C8", VA = "0x133A2C8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x133A2CC", Offset = "0x133A2CC", VA = "0x133A2CC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x133A2D4", Offset = "0x133A2D4", VA = "0x133A2D4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public virtual string Value
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x133A2D8", Offset = "0x133A2D8", VA = "0x133A2D8", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x133A324", Offset = "0x133A324", VA = "0x133A324", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public virtual int Count
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x133A328", Offset = "0x133A328", VA = "0x133A328", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x133A3B4", Offset = "0x133A3B4", VA = "0x133A3B4", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x289D00", Offset = "0x289D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x133A418", Offset = "0x133A418", VA = "0x133A418")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x289D6C", Offset = "0x289D6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x133A534", Offset = "0x133A534", VA = "0x133A534", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x133A578", Offset = "0x133A578", VA = "0x133A578", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000066")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x133A5B8", Offset = "0x133A5B8", VA = "0x133A5B8", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x133A6A0", Offset = "0x133A6A0", VA = "0x133A6A0", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x133A6E0", Offset = "0x133A6E0", VA = "0x133A6E0", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x133A79C", Offset = "0x133A79C", VA = "0x133A79C", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public virtual bool AsBool
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x133A7DC", Offset = "0x133A7DC", VA = "0x133A7DC", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x133A8B8", Offset = "0x133A8B8", VA = "0x133A8B8", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x133A954", Offset = "0x133A954", VA = "0x133A954", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x133A9DC", Offset = "0x133A9DC", VA = "0x133A9DC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x133A2BC", Offset = "0x133A2BC", VA = "0x133A2BC", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x133A330", Offset = "0x133A330", VA = "0x133A330", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x133A39C", Offset = "0x133A39C", VA = "0x133A39C", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x133A3A4", Offset = "0x133A3A4", VA = "0x133A3A4", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x133A3AC", Offset = "0x133A3AC", VA = "0x133A3AC", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x133A49C", Offset = "0x133A49C", VA = "0x133A49C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x133A4E8", Offset = "0x133A4E8", VA = "0x133A4E8", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x133AA64", Offset = "0x133AA64", VA = "0x133AA64")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x133AAD8", Offset = "0x133AAD8", VA = "0x133AAD8")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x133AB20", Offset = "0x133AB20", VA = "0x133AB20")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x133ABC0", Offset = "0x133ABC0", VA = "0x133ABC0")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x133ABD4", Offset = "0x133ABD4", VA = "0x133ABD4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x1339CD4", Offset = "0x1339CD4", VA = "0x1339CD4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1338910", Offset = "0x1338910", VA = "0x1338910")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1336344", Offset = "0x1336344", VA = "0x1336344")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x133ABE4", Offset = "0x133ABE4", VA = "0x133ABE4", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x133ABE8", Offset = "0x133ABE8", VA = "0x133ABE8")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x133AC68", Offset = "0x133AC68", VA = "0x133AC68")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x133ACC8", Offset = "0x133ACC8", VA = "0x133ACC8")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x133AD28", Offset = "0x133AD28", VA = "0x133AD28")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x133AD88", Offset = "0x133AD88", VA = "0x133AD88")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x133AF54", Offset = "0x133AF54", VA = "0x133AF54")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x133B168", Offset = "0x133B168", VA = "0x133B168")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x133B578", Offset = "0x133B578", VA = "0x133B578")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x133B5D8", Offset = "0x133B5D8", VA = "0x133B5D8")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x133B638", Offset = "0x133B638", VA = "0x133B638")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x133B698", Offset = "0x133B698", VA = "0x133B698")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x133B810", Offset = "0x133B810", VA = "0x133B810")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x133B960", Offset = "0x133B960", VA = "0x133B960")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x13378CC", Offset = "0x13378CC", VA = "0x13378CC")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x286E9C", Offset = "0x286E9C")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286ED0", Offset = "0x286ED0")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private JSONNode <>2__current;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public JSONArray <>4__this;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000073")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600027A")]
				[Address(RVA = "0x16532AC", Offset = "0x16532AC", VA = "0x16532AC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000074")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600027C")]
				[Address(RVA = "0x16532FC", Offset = "0x16532FC", VA = "0x16532FC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000276")]
			[Address(RVA = "0x1653060", Offset = "0x1653060", VA = "0x1653060")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000277")]
			[Address(RVA = "0x165308C", Offset = "0x165308C", VA = "0x165308C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000278")]
			[Address(RVA = "0x1653104", Offset = "0x1653104", VA = "0x1653104", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000279")]
			[Address(RVA = "0x16530A4", Offset = "0x16530A4", VA = "0x16530A4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600027B")]
			[Address(RVA = "0x16532B4", Offset = "0x16532B4", VA = "0x16532B4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600027D")]
			[Address(RVA = "0x1653304", Offset = "0x1653304", VA = "0x1653304", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600027E")]
			[Address(RVA = "0x16533CC", Offset = "0x16533CC", VA = "0x16533CC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286EE0", Offset = "0x286EE0")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONArray <>4__this;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000283")]
				[Address(RVA = "0x1653008", Offset = "0x1653008", VA = "0x1653008", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000285")]
				[Address(RVA = "0x1653058", Offset = "0x1653058", VA = "0x1653058", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x1652DC8", Offset = "0x1652DC8", VA = "0x1652DC8")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000280")]
			[Address(RVA = "0x1652DE8", Offset = "0x1652DE8", VA = "0x1652DE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000281")]
			[Address(RVA = "0x1652E60", Offset = "0x1652E60", VA = "0x1652E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000282")]
			[Address(RVA = "0x1652E00", Offset = "0x1652E00", VA = "0x1652E00")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000284")]
			[Address(RVA = "0x1653010", Offset = "0x1653010", VA = "0x1653010", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private List<JSONNode> m_List;

		[Token(Token = "0x1700006F")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x1336C20", Offset = "0x1336C20", VA = "0x1336C20", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1336D40", Offset = "0x1336D40", VA = "0x1336D40", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public override JSONNode Item
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x1336E2C", Offset = "0x1336E2C", VA = "0x1336E2C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1336E90", Offset = "0x1336E90", VA = "0x1336E90", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public override int Count
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1336F00", Offset = "0x1336F00", VA = "0x1336F00", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000072")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1337124", Offset = "0x1337124", VA = "0x1337124", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x289EB8", Offset = "0x289EB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1336F54", Offset = "0x1336F54", VA = "0x1336F54", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1336FC4", Offset = "0x1336FC4", VA = "0x1336FC4", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x13370B0", Offset = "0x13370B0", VA = "0x13370B0", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x13371A8", Offset = "0x13371A8", VA = "0x13371A8", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x289F24", Offset = "0x289F24")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x133722C", Offset = "0x133722C", VA = "0x133722C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1337454", Offset = "0x1337454", VA = "0x1337454", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1337714", Offset = "0x1337714", VA = "0x1337714", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1337830", Offset = "0x1337830", VA = "0x1337830")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x286EF0", Offset = "0x286EF0")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286F24", Offset = "0x286F24")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public JSONNode aNode;

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x16533D0", Offset = "0x16533D0", VA = "0x16533D0")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x16533D8", Offset = "0x16533D8", VA = "0x16533D8")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286F34", Offset = "0x286F34")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public JSONClass <>4__this;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700007B")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600029B")]
				[Address(RVA = "0x165398C", Offset = "0x165398C", VA = "0x165398C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x16539DC", Offset = "0x16539DC", VA = "0x16539DC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000297")]
			[Address(RVA = "0x1653714", Offset = "0x1653714", VA = "0x1653714")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x1653740", Offset = "0x1653740", VA = "0x1653740", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000299")]
			[Address(RVA = "0x16537B8", Offset = "0x16537B8", VA = "0x16537B8", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x1653758", Offset = "0x1653758", VA = "0x1653758")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1653994", Offset = "0x1653994", VA = "0x1653994", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x16539E4", Offset = "0x16539E4", VA = "0x16539E4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1653AAC", Offset = "0x1653AAC", VA = "0x1653AAC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x286F44", Offset = "0x286F44")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONClass <>4__this;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002A4")]
				[Address(RVA = "0x16536BC", Offset = "0x16536BC", VA = "0x16536BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002A6")]
				[Address(RVA = "0x165370C", Offset = "0x165370C", VA = "0x165370C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x165342C", Offset = "0x165342C", VA = "0x165342C")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x165344C", Offset = "0x165344C", VA = "0x165344C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x16534C4", Offset = "0x16534C4", VA = "0x16534C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1653464", Offset = "0x1653464", VA = "0x1653464")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x16536C4", Offset = "0x16536C4", VA = "0x16536C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000077")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x13378D4", Offset = "0x13378D4", VA = "0x13378D4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1337A04", Offset = "0x1337A04", VA = "0x1337A04", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1337AF8", Offset = "0x1337AF8", VA = "0x1337AF8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1337BC8", Offset = "0x1337BC8", VA = "0x1337BC8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public override int Count
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1337CD4", Offset = "0x1337CD4", VA = "0x1337CD4", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007A")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x133833C", Offset = "0x133833C", VA = "0x133833C", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x28A050", Offset = "0x28A050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1337D3C", Offset = "0x1337D3C", VA = "0x1337D3C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1337EE4", Offset = "0x1337EE4", VA = "0x1337EE4", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1337FE0", Offset = "0x1337FE0", VA = "0x1337FE0", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x13380FC", Offset = "0x13380FC", VA = "0x13380FC", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x13383C0", Offset = "0x13383C0", VA = "0x13383C0", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x28A0BC", Offset = "0x28A0BC")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1338444", Offset = "0x1338444", VA = "0x1338444", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1338AFC", Offset = "0x1338AFC", VA = "0x1338AFC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x133905C", Offset = "0x133905C", VA = "0x133905C", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x13392D4", Offset = "0x13392D4", VA = "0x13392D4")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private string m_Data;

		[Token(Token = "0x1700007F")]
		public override string Value
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1339370", Offset = "0x1339370", VA = "0x1339370", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x1339378", Offset = "0x1339378", VA = "0x1339378", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x1339380", Offset = "0x1339380", VA = "0x1339380")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x13393AC", Offset = "0x13393AC", VA = "0x13393AC")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x13393E0", Offset = "0x13393E0", VA = "0x13393E0")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1339428", Offset = "0x1339428", VA = "0x1339428")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x133945C", Offset = "0x133945C", VA = "0x133945C")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1339490", Offset = "0x1339490", VA = "0x1339490", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x13394F8", Offset = "0x13394F8", VA = "0x13394F8", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1339560", Offset = "0x1339560", VA = "0x1339560", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x286F54", Offset = "0x286F54")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private JSONNode m_Node;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private string m_Key;

		[Token(Token = "0x17000080")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x133995C", Offset = "0x133995C", VA = "0x133995C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x13399C0", Offset = "0x13399C0", VA = "0x13399C0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public override JSONNode Item
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x1339A50", Offset = "0x1339A50", VA = "0x1339A50", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x1339ABC", Offset = "0x1339ABC", VA = "0x1339ABC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override int AsInt
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x1339D74", Offset = "0x1339D74", VA = "0x1339D74", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x1339DFC", Offset = "0x1339DFC", VA = "0x1339DFC", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public override float AsFloat
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1339E84", Offset = "0x1339E84", VA = "0x1339E84", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1339F0C", Offset = "0x1339F0C", VA = "0x1339F0C", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public override double AsDouble
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x1339F94", Offset = "0x1339F94", VA = "0x1339F94", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x133A038", Offset = "0x133A038", VA = "0x133A038", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public override bool AsBool
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x133A0D4", Offset = "0x133A0D4", VA = "0x133A0D4", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x133A15C", Offset = "0x133A15C", VA = "0x133A15C", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x133A1E4", Offset = "0x133A1E4", VA = "0x133A1E4", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x133A250", Offset = "0x133A250", VA = "0x133A250", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x1336D00", Offset = "0x1336D00", VA = "0x1336D00")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x13379C4", Offset = "0x13379C4", VA = "0x13379C4")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x13398D4", Offset = "0x13398D4", VA = "0x13398D4")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1339B54", Offset = "0x1339B54", VA = "0x1339B54", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x1339BE4", Offset = "0x1339BE4", VA = "0x1339BE4", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x1339C7C", Offset = "0x1339C7C", VA = "0x1339C7C")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1339C98", Offset = "0x1339C98", VA = "0x1339C98")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x1339CB0", Offset = "0x1339CB0", VA = "0x1339CB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1339CCC", Offset = "0x1339CCC", VA = "0x1339CCC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x1339CDC", Offset = "0x1339CDC", VA = "0x1339CDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x1339D28", Offset = "0x1339D28", VA = "0x1339D28", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F1")]
	public static class JSON
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1336340", Offset = "0x1336340", VA = "0x1336340")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
