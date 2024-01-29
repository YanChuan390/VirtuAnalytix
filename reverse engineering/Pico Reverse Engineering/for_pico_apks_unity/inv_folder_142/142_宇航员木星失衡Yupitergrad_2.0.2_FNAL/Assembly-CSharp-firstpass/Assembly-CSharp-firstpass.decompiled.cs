using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering.Universal.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class ConsoleProDebug
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x27B2AFC", Offset = "0x27B2AFC", VA = "0x27B2AFC")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x27B2B00", Offset = "0x27B2B00", VA = "0x27B2B00")]
	public static void LogToFilter(string inLog, string inFilterName)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x27B2BA4", Offset = "0x27B2BA4", VA = "0x27B2BA4")]
	public static void Watch(string inName, string inValue)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x27B2DC8", Offset = "0x27B2DC8", VA = "0x27B2DC8")]
	public static void Search(string inText)
	{
	}
}
namespace Rendering
{
	[Token(Token = "0x2000003")]
	internal class CustomCapturePass : ScriptableRenderPass
	{
		[Token(Token = "0x4000001")]
		private const string m_ProfilerTag = "Capture Pass";

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x64")]
		private RenderTargetHandle m_CameraColorHandle;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x27B2EE8", Offset = "0x27B2EE8", VA = "0x27B2EE8")]
		public CustomCapturePass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x27B2F14", Offset = "0x27B2F14", VA = "0x27B2F14")]
		public void Setup(RenderTargetHandle colorHandle)
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x27B2F1C", Offset = "0x27B2F1C", VA = "0x27B2F1C", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000004")]
	public sealed class CustomForwardRenderer : ScriptableRenderer
	{
		[Serializable]
		[Token(Token = "0x200000C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0C7C0", Offset = "0xF0C7C0")]
		private sealed class <>c
		{
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<ScriptableRenderPass> <>9__33_0;

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x27B4CCC", Offset = "0x27B4CCC", VA = "0x27B4CCC")]
			public <>c()
			{
			}

			[Token(Token = "0x600002E")]
			[Address(RVA = "0x27B4CD4", Offset = "0x27B4CD4", VA = "0x27B4CD4")]
			internal bool <Setup>b__33_0(ScriptableRenderPass x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000003")]
		private const int k_DepthStencilBufferBits = 32;

		[Token(Token = "0x4000004")]
		private const string k_CreateCameraTextures = "Create Camera Texture";

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x80")]
		private ColorGradingLutPass m_ColorGradingLutPass;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x88")]
		private DepthOnlyPass m_DepthPrepass;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x90")]
		private MainLightShadowCasterPass m_MainLightShadowCasterPass;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x98")]
		private AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0xA0")]
		private DrawObjectsPass m_RenderOpaqueForwardPass;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0xA8")]
		private DrawSkyboxPass m_DrawSkyboxPass;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xB0")]
		private CopyDepthPass m_CopyDepthPass;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0xB8")]
		private CopyColorPass m_CopyColorPass;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0xC0")]
		private CustomTransparentSettingsPass m_TransparentSettingsPass;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0xC8")]
		private DrawObjectsPass m_RenderTransparentForwardPass;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0xD0")]
		private CustomInvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0xD8")]
		private PostProcessPass m_PostProcessPass;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0xE0")]
		private PostProcessPass m_FinalPostProcessPass;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0xE8")]
		private FinalBlitPass m_FinalBlitPass;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0xF0")]
		private CustomCapturePass m_CapturePass;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTargetHandle m_ActiveCameraColorAttachment;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0xFC")]
		private RenderTargetHandle m_ActiveCameraDepthAttachment;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x100")]
		private RenderTargetHandle m_CameraColorAttachment;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x104")]
		private RenderTargetHandle m_CameraDepthAttachment;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x108")]
		private RenderTargetHandle m_DepthTexture;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10C")]
		private RenderTargetHandle m_OpaqueColor;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x110")]
		private RenderTargetHandle m_AfterPostProcessColor;

		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x114")]
		private RenderTargetHandle m_ColorGradingLut;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x118")]
		private ForwardLights m_ForwardLights;

		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x120")]
		private StencilState m_DefaultStencilState;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x130")]
		private Material m_BlitMaterial;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x138")]
		private Material m_CopyDepthMaterial;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x140")]
		private Material m_SamplingMaterial;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x148")]
		private Material m_ScreenspaceShadowsMaterial;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x27B3198", Offset = "0x27B3198", VA = "0x27B3198")]
		public CustomForwardRenderer(CustomForwardRendererData data)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x27B38A0", Offset = "0x27B38A0", VA = "0x27B38A0", Slot = "5")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x27B3944", Offset = "0x27B3944", VA = "0x27B3944", Slot = "6")]
		public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x27B4978", Offset = "0x27B4978", VA = "0x27B4978", Slot = "7")]
		public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x27B4994", Offset = "0x27B4994", VA = "0x27B4994", Slot = "8")]
		public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x27B4AEC", Offset = "0x27B4AEC", VA = "0x27B4AEC", Slot = "9")]
		public override void FinishRendering(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x27B4690", Offset = "0x27B4690", VA = "0x27B4690")]
		private void CreateCameraRenderTarget(ScriptableRenderContext context, ref CameraData cameraData)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x27B4974", Offset = "0x27B4974", VA = "0x27B4974")]
		private void SetupBackbufferFormat(int msaaSamples, bool stereo)
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x27B4C30", Offset = "0x27B4C30", VA = "0x27B4C30")]
		private bool PlatformRequiresExplicitMsaaResolve()
		{
			return default(bool);
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x27B4498", Offset = "0x27B4498", VA = "0x27B4498")]
		private bool RequiresIntermediateColorTexture(ref CameraData cameraData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x27B4400", Offset = "0x27B4400", VA = "0x27B4400")]
		private bool CanCopyDepth(ref CameraData cameraData)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	[ReloadGroup]
	[ExcludeFromPreset]
	[AttributeAttribute(Name = "MovedFromAttribute", RVA = "0xF0C764", Offset = "0xF0C764")]
	public class CustomForwardRendererData : ScriptableRendererData
	{
		[Serializable]
		[Token(Token = "0x200000D")]
		[ReloadGroup]
		public sealed class ShaderResources
		{
			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C89C", Offset = "0xF0C89C")]
			public Shader blitPS;

			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C8D8", Offset = "0xF0C8D8")]
			public Shader copyDepthPS;

			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C914", Offset = "0xF0C914")]
			public Shader screenSpaceShadowPS;

			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C950", Offset = "0xF0C950")]
			public Shader samplingPS;

			[Token(Token = "0x4000039")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C98C", Offset = "0xF0C98C")]
			public Shader fallbackErrorPS;

			[Token(Token = "0x600002F")]
			[Address(RVA = "0x27B4ED4", Offset = "0x27B4ED4", VA = "0x27B4ED4")]
			public ShaderResources()
			{
			}
		}

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ReloadAttribute", RVA = "0xF0C7E0", Offset = "0xF0C7E0")]
		public PostProcessData postProcessData;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x38")]
		public ShaderResources shaders;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LayerMask m_OpaqueLayerMask;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LayerMask m_TransparentLayerMask;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private StencilStateData m_DefaultStencilState;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_ShadowTransparentReceive;

		[Token(Token = "0x17000001")]
		public LayerMask opaqueLayerMask
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x27B4CF4", Offset = "0x27B4CF4", VA = "0x27B4CF4")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x27B4CFC", Offset = "0x27B4CFC", VA = "0x27B4CFC")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public LayerMask transparentLayerMask
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x27B4D28", Offset = "0x27B4D28", VA = "0x27B4D28")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x27B4D30", Offset = "0x27B4D30", VA = "0x27B4D30")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public StencilStateData defaultStencilState
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x27B4D5C", Offset = "0x27B4D5C", VA = "0x27B4D5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x27B4D64", Offset = "0x27B4D64", VA = "0x27B4D64")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public bool shadowTransparentReceive
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x27B4D98", Offset = "0x27B4D98", VA = "0x27B4D98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x27B4DA0", Offset = "0x27B4DA0", VA = "0x27B4DA0")]
			set
			{
			}
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x27B4DD0", Offset = "0x27B4DD0", VA = "0x27B4DD0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x27B4DD8", Offset = "0x27B4DD8", VA = "0x27B4DD8", Slot = "4")]
		protected override ScriptableRenderer Create()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x27B4E38", Offset = "0x27B4E38", VA = "0x27B4E38")]
		public CustomForwardRendererData()
		{
		}
	}
	[Token(Token = "0x2000006")]
	internal class CustomInvokeOnRenderObjectCallbackPass : ScriptableRenderPass
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x27B3874", Offset = "0x27B3874", VA = "0x27B3874")]
		public CustomInvokeOnRenderObjectCallbackPass(RenderPassEvent evt)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x27B4EDC", Offset = "0x27B4EDC", VA = "0x27B4EDC", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000007")]
	internal class CustomSceneViewDepthCopyPass : ScriptableRenderPass
	{
		[Token(Token = "0x4000028")]
		private const string m_ProfilerTag = "Copy Depth for Scene View";

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0C85C", Offset = "0xF0C85C")]
		private RenderTargetHandle <source>k__BackingField;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x68")]
		private Material m_CopyDepthMaterial;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x70")]
		private int m_ScaleBiasId;

		[Token(Token = "0x17000005")]
		private RenderTargetHandle source
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x27B4F04", Offset = "0x27B4F04", VA = "0x27B4F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0C9C8", Offset = "0xF0C9C8")]
			get
			{
				return default(RenderTargetHandle);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x27B4F0C", Offset = "0x27B4F0C", VA = "0x27B4F0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF0C9D8", Offset = "0xF0C9D8")]
			set
			{
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x27B4F14", Offset = "0x27B4F14", VA = "0x27B4F14")]
		public CustomSceneViewDepthCopyPass(RenderPassEvent evt, Material copyDepthMaterial)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x27B4F9C", Offset = "0x27B4F9C", VA = "0x27B4F9C")]
		public void Setup(RenderTargetHandle source)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x27B4FA4", Offset = "0x27B4FA4", VA = "0x27B4FA4", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
	[Token(Token = "0x2000008")]
	internal class CustomTransparentSettingsPass : ScriptableRenderPass
	{
		[Token(Token = "0x400002C")]
		private const string m_ProfilerTag = "Transparent Settings Pass";

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x64")]
		private bool m_shouldReceiveShadows;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x27B3834", Offset = "0x27B3834", VA = "0x27B3834")]
		public CustomTransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x27B43F0", Offset = "0x27B43F0", VA = "0x27B43F0")]
		public bool Setup(ref RenderingData renderingData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x27B53C4", Offset = "0x27B53C4", VA = "0x27B53C4", Slot = "7")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}
}
namespace PS4
{
	[Token(Token = "0x2000009")]
	public class PSVRManager : MonoBehaviour
	{
		[Token(Token = "0x200000E")]
		public enum EPlayStationSDeviceType
		{
			[Token(Token = "0x400003B")]
			None,
			[Token(Token = "0x400003C")]
			StandardPS4,
			[Token(Token = "0x400003D")]
			PS4Pro,
			[Token(Token = "0x400003E")]
			PS5
		}

		[Serializable]
		[Token(Token = "0x200000F")]
		public struct PSVRInitializationData
		{
			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x0")]
			public EPlayStationSDeviceType DeviceType;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x4")]
			public float RenderScale;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x8")]
			public int FrameRate;

			[Token(Token = "0x4000042")]
			[FieldOffset(Offset = "0xC")]
			public Color MinOutputColor;
		}

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PSVRInitializationData m_defaultDeviceProperties;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<PSVRInitializationData> m_playStationDeviceProperties;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x27B2ED8", Offset = "0x27B2ED8", VA = "0x27B2ED8")]
		public PSVRManager()
		{
		}
	}
}
namespace PSVR
{
	[Token(Token = "0x200000A")]
	public class PSVREnabler : MonoBehaviour
	{
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssetReference m_psVrManagerReference;

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x27B2EE0", Offset = "0x27B2EE0", VA = "0x27B2EE0")]
		public PSVREnabler()
		{
		}
	}
}
namespace FlyingWormConsole3
{
	[Token(Token = "0x200000B")]
	public class ConsoleProRemoteServer : MonoBehaviour
	{
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x18")]
		public bool useNATPunch;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x1C")]
		public int port;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x27B2E5C", Offset = "0x27B2E5C", VA = "0x27B2E5C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x27B2EC8", Offset = "0x27B2EC8", VA = "0x27B2EC8")]
		public ConsoleProRemoteServer()
		{
		}
	}
}
