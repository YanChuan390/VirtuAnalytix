using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A4A0", Offset = "0x59A4A0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A4A0", Offset = "0x59A4A0")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000001")]
	protected Material material
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x101B17C", Offset = "0x101B17C", VA = "0x101B17C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x101B0D0", Offset = "0x101B0D0", VA = "0x101B0D0", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x101B248", Offset = "0x101B248", VA = "0x101B248", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x101B2F4", Offset = "0x101B2F4", VA = "0x101B2F4")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A524", Offset = "0x59A524")]
public class ImageEffects
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x101B2FC", Offset = "0x101B2FC", VA = "0x101B2FC")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x101B548", Offset = "0x101B548", VA = "0x101B548")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x59D50C", Offset = "0x59D50C")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x101B5BC", Offset = "0x101B5BC", VA = "0x101B5BC")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x59D544", Offset = "0x59D544")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x101B638", Offset = "0x101B638", VA = "0x101B638")]
	public ImageEffects()
	{
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x2000004")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A55C", Offset = "0x59A55C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A55C", Offset = "0x59A55C")]
	[ImageEffectAllowedInSceneView]
	public class AmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000005")]
		private class PropertyObserver
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			private bool _downsampling;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x14")]
			private OcclusionSource _occlusionSource;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x18")]
			private bool _ambientOnly;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x19")]
			private bool _debug;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x1C")]
			private int _pixelWidth;

			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x20")]
			private int _pixelHeight;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1016788", Offset = "0x1016788", VA = "0x1016788")]
			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return default(bool);
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1016864", Offset = "0x1016864", VA = "0x1016864")]
			public void Update(Settings setting, Camera camera)
			{
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1016A64", Offset = "0x1016A64", VA = "0x1016A64")]
			public PropertyObserver()
			{
			}
		}

		[Token(Token = "0x2000006")]
		public enum SampleCount
		{
			[Token(Token = "0x4000015")]
			Lowest,
			[Token(Token = "0x4000016")]
			Low,
			[Token(Token = "0x4000017")]
			Medium,
			[Token(Token = "0x4000018")]
			High,
			[Token(Token = "0x4000019")]
			Custom
		}

		[Token(Token = "0x2000007")]
		public enum OcclusionSource
		{
			[Token(Token = "0x400001B")]
			DepthTexture,
			[Token(Token = "0x400001C")]
			DepthNormalsTexture,
			[Token(Token = "0x400001D")]
			GBuffer
		}

		[Serializable]
		[Token(Token = "0x2000008")]
		public class Settings
		{
			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59AB94", Offset = "0x59AB94")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AB94", Offset = "0x59AB94")]
			public float intensity;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59ABF8", Offset = "0x59ABF8")]
			public float radius;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AC44", Offset = "0x59AC44")]
			[SerializeField]
			public SampleCount sampleCount;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AC90", Offset = "0x59AC90")]
			public int sampleCountValue;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59ACDC", Offset = "0x59ACDC")]
			[SerializeField]
			public bool downsampling;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x21")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AD28", Offset = "0x59AD28")]
			[SerializeField]
			public bool ambientOnly;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AD74", Offset = "0x59AD74")]
			[SerializeField]
			public OcclusionSource occlusionSource;

			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59ADC0", Offset = "0x59ADC0")]
			[SerializeField]
			public bool debug;

			[Token(Token = "0x17000011")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000025")]
				[Address(RVA = "0x10169E4", Offset = "0x10169E4", VA = "0x10169E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1022D7C", Offset = "0x1022D7C", VA = "0x1022D7C")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader _aoShader;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x28")]
		private Material _aoMaterial;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x30")]
		private CommandBuffer _aoCommands;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		private PropertyObserver _propertyObserver;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Mesh _quadMesh;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x48")]
		private int _OcclusionTexture;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x4C")]
		private int _Intensity;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x50")]
		private int _Radius;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x54")]
		private int _Downsample;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x58")]
		private int _SampleCount;

		[Token(Token = "0x17000002")]
		public bool isAmbientOnlySupported
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x10154F4", Offset = "0x10154F4", VA = "0x10154F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x10155DC", Offset = "0x10155DC", VA = "0x10155DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000004")]
		private float intensity
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1015608", Offset = "0x1015608", VA = "0x1015608")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000005")]
		private float radius
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1015624", Offset = "0x1015624", VA = "0x1015624")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000006")]
		private SampleCount sampleCount
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x101564C", Offset = "0x101564C", VA = "0x101564C")]
			get
			{
				return default(SampleCount);
			}
		}

		[Token(Token = "0x17000007")]
		private int sampleCountValue
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1015668", Offset = "0x1015668", VA = "0x1015668")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000008")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x101558C", Offset = "0x101558C", VA = "0x101558C")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x17000009")]
		private bool downsampling
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x10156AC", Offset = "0x10156AC", VA = "0x10156AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool ambientOnly
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x10156C8", Offset = "0x10156C8", VA = "0x10156C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private Shader aoShader
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x10156F8", Offset = "0x10156F8", VA = "0x10156F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private Material aoMaterial
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1015798", Offset = "0x1015798", VA = "0x1015798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private CommandBuffer aoCommands
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x10158F8", Offset = "0x10158F8", VA = "0x10158F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private Camera targetCamera
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1015540", Offset = "0x1015540", VA = "0x1015540")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private PropertyObserver propertyObserver
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x101598C", Offset = "0x101598C", VA = "0x101598C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private Mesh quadMesh
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1015994", Offset = "0x1015994", VA = "0x1015994")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x101599C", Offset = "0x101599C", VA = "0x101599C")]
		private void BuildAOCommands()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1015DEC", Offset = "0x1015DEC", VA = "0x1015DEC")]
		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1016044", Offset = "0x1016044", VA = "0x1016044")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x10160F8", Offset = "0x10160F8", VA = "0x10160F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x10161DC", Offset = "0x10161DC", VA = "0x10161DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x10165D8", Offset = "0x10165D8", VA = "0x10165D8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1016620", Offset = "0x1016620", VA = "0x1016620")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x10166C0", Offset = "0x10166C0", VA = "0x10166C0")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x10168D0", Offset = "0x10168D0", VA = "0x10168D0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1016978", Offset = "0x1016978", VA = "0x1016978")]
		public AmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A600", Offset = "0x59A600")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A600", Offset = "0x59A600")]
	[ExecuteInEditMode]
	public class AntiAliasing : MonoBehaviour
	{
		[Token(Token = "0x200000A")]
		public enum Method
		{
			[Token(Token = "0x400002B")]
			Smaa,
			[Token(Token = "0x400002C")]
			Fxaa
		}

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SMAA m_SMAA;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FXAA m_FXAA;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private int m_Method;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_Camera;

		[Token(Token = "0x17000012")]
		public int method
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1016A6C", Offset = "0x1016A6C", VA = "0x1016A6C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1016A74", Offset = "0x1016A74", VA = "0x1016A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public IAntiAliasing current
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1016A88", Offset = "0x1016A88", VA = "0x1016A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Camera cameraComponent
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1016AA0", Offset = "0x1016AA0", VA = "0x1016AA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1016B40", Offset = "0x1016B40", VA = "0x1016B40")]
		private void Awake()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1016D84", Offset = "0x1016D84", VA = "0x1016D84")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1016E68", Offset = "0x1016E68", VA = "0x1016E68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1017050", Offset = "0x1017050", VA = "0x1017050")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1017120", Offset = "0x1017120", VA = "0x1017120")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10171F0", Offset = "0x10171F0", VA = "0x10171F0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10172D8", Offset = "0x10172D8", VA = "0x10172D8")]
		public AntiAliasing()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000B")]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		[Token(Token = "0x200000C")]
		public struct QualitySettings
		{
			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AEAC", Offset = "0x59AEAC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59AEAC", Offset = "0x59AEAC")]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59AF00", Offset = "0x59AF00")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AF00", Offset = "0x59AF00")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59AF5C", Offset = "0x59AF5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AF5C", Offset = "0x59AF5C")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x200000D")]
		public struct ConsoleSettings
		{
			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59AFB4", Offset = "0x59AFB4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59AFB4", Offset = "0x59AFB4")]
			public float subpixelSpreadAmount;

			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B00C", Offset = "0x59B00C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B00C", Offset = "0x59B00C")]
			public float edgeSharpnessAmount;

			[Token(Token = "0x4000039")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B060", Offset = "0x59B060")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B060", Offset = "0x59B060")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B0B4", Offset = "0x59B0B4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B0B4", Offset = "0x59B0B4")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		public struct Preset
		{
			[Token(Token = "0x200000F")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A6A4", Offset = "0x59A6A4")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x1024210", Offset = "0x1024210", VA = "0x1024210")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0x0")]
			[Layout]
			public QualitySettings qualitySettings;

			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0xC")]
			[Layout]
			public ConsoleSettings consoleSettings;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Preset s_ExtremePerformance;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x1C")]
			private static readonly Preset s_Performance;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x38")]
			private static readonly Preset s_Default;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x54")]
			private static readonly Preset s_Quality;

			[Token(Token = "0x4000041")]
			[FieldOffset(Offset = "0x70")]
			private static readonly Preset s_ExtremeQuality;

			[Token(Token = "0x17000018")]
			public static Preset extremePerformancePreset
			{
				[Token(Token = "0x600003E")]
				[Address(RVA = "0x1022E84", Offset = "0x1022E84", VA = "0x1022E84")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000019")]
			public static Preset performancePreset
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x1022EF8", Offset = "0x1022EF8", VA = "0x1022EF8")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x1700001A")]
			public static Preset defaultPreset
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x1022F6C", Offset = "0x1022F6C", VA = "0x1022F6C")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x1700001B")]
			public static Preset qualityPreset
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x1022FE0", Offset = "0x1022FE0", VA = "0x1022FE0")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x1700001C")]
			public static Preset extremeQualityPreset
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x1023054", Offset = "0x1023054", VA = "0x1023054")]
				get
				{
					return default(Preset);
				}
			}
		}

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x10")]
		private Shader m_Shader;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x18")]
		private Material m_Material;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		public Preset preset;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		public static Preset[] availablePresets;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59AE9C", Offset = "0x59AE9C")]
		private bool <validSourceFormat>k__BackingField;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x40")]
		private int m_QualitySettings;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x44")]
		private int m_ConsoleSettings;

		[Token(Token = "0x17000015")]
		private Shader shader
		{
			[Token(Token = "0x6000032")]
			[Address(RVA = "0x101AB78", Offset = "0x101AB78", VA = "0x101AB78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public Material material
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x101AC18", Offset = "0x101AC18", VA = "0x101AC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public bool validSourceFormat
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x101ACA4", Offset = "0x101ACA4", VA = "0x101ACA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D58C", Offset = "0x59D58C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x101ACAC", Offset = "0x101ACAC", VA = "0x101ACAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D59C", Offset = "0x59D59C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1016D0C", Offset = "0x1016D0C", VA = "0x1016D0C", Slot = "4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1016E14", Offset = "0x1016E14", VA = "0x1016E14", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1016FA0", Offset = "0x1016FA0", VA = "0x1016FA0", Slot = "6")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x101ACB8", Offset = "0x101ACB8", VA = "0x101ACB8", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x101ACBC", Offset = "0x101ACBC", VA = "0x101ACBC", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x101ACC0", Offset = "0x101ACC0", VA = "0x101ACC0", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1017434", Offset = "0x1017434", VA = "0x1017434")]
		public FXAA()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public interface IAntiAliasing
	{
		[Token(Token = "0x6000045")]
		void Awake();

		[Token(Token = "0x6000046")]
		void OnEnable(AntiAliasing owner);

		[Token(Token = "0x6000047")]
		void OnDisable();

		[Token(Token = "0x6000048")]
		void OnPreCull(Camera camera);

		[Token(Token = "0x6000049")]
		void OnPostRender(Camera camera);

		[Token(Token = "0x600004A")]
		void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination);
	}
	[Serializable]
	[Token(Token = "0x2000011")]
	public class SMAA : IAntiAliasing
	{
		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A6B8", Offset = "0x59A6B8")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1023CA8", Offset = "0x1023CA8", VA = "0x1023CA8")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000013")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A6CC", Offset = "0x59A6CC")]
		public class TopLevelSettings : Attribute
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1023CB8", Offset = "0x1023CB8", VA = "0x1023CB8")]
			public TopLevelSettings()
			{
			}
		}

		[Token(Token = "0x2000014")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A6E0", Offset = "0x59A6E0")]
		public class ExperimentalGroup : Attribute
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1023B80", Offset = "0x1023B80", VA = "0x1023B80")]
			public ExperimentalGroup()
			{
			}
		}

		[Token(Token = "0x2000015")]
		public enum DebugPass
		{
			[Token(Token = "0x4000059")]
			Off,
			[Token(Token = "0x400005A")]
			Edges,
			[Token(Token = "0x400005B")]
			Weights,
			[Token(Token = "0x400005C")]
			Accumulation
		}

		[Token(Token = "0x2000016")]
		public enum QualityPreset
		{
			[Token(Token = "0x400005E")]
			Low,
			[Token(Token = "0x400005F")]
			Medium,
			[Token(Token = "0x4000060")]
			High,
			[Token(Token = "0x4000061")]
			Ultra,
			[Token(Token = "0x4000062")]
			Custom
		}

		[Token(Token = "0x2000017")]
		public enum EdgeDetectionMethod
		{
			[Token(Token = "0x4000064")]
			Luma = 1,
			[Token(Token = "0x4000065")]
			Color,
			[Token(Token = "0x4000066")]
			Depth
		}

		[Serializable]
		[Token(Token = "0x2000018")]
		public struct GlobalSettings
		{
			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B198", Offset = "0x59B198")]
			public DebugPass debugPass;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B1D0", Offset = "0x59B1D0")]
			public QualityPreset quality;

			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B208", Offset = "0x59B208")]
			public EdgeDetectionMethod edgeDetectionMethod;

			[Token(Token = "0x17000021")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x101E198", Offset = "0x101E198", VA = "0x101E198")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000019")]
		public struct QualitySettings
		{
			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B240", Offset = "0x59B240")]
			public bool diagonalDetection;

			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x1")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B278", Offset = "0x59B278")]
			public bool cornerDetection;

			[Token(Token = "0x400006C")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B2B0", Offset = "0x59B2B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B2B0", Offset = "0x59B2B0")]
			public float threshold;

			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59B304", Offset = "0x59B304")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B304", Offset = "0x59B304")]
			public float depthThreshold;

			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B358", Offset = "0x59B358")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B358", Offset = "0x59B358")]
			public int maxSearchSteps;

			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B3B0", Offset = "0x59B3B0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B3B0", Offset = "0x59B3B0")]
			public int maxDiagonalSearchSteps;

			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B404", Offset = "0x59B404")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B404", Offset = "0x59B404")]
			public int cornerRounding;

			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59B45C", Offset = "0x59B45C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B45C", Offset = "0x59B45C")]
			public float localContrastAdaptationFactor;

			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200001A")]
		public struct TemporalSettings
		{
			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B4AC", Offset = "0x59B4AC")]
			public bool enabled;

			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B4E4", Offset = "0x59B4E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B4E4", Offset = "0x59B4E4")]
			public float fuzzSize;

			[Token(Token = "0x17000022")]
			public static TemporalSettings defaultSettings
			{
				[Token(Token = "0x600005D")]
				[Address(RVA = "0x101E1BC", Offset = "0x101E1BC", VA = "0x101E1BC")]
				get
				{
					return default(TemporalSettings);
				}
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1023CB0", Offset = "0x1023CB0", VA = "0x1023CB0")]
			public bool UseTemporal()
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200001B")]
		public struct PredicationSettings
		{
			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B538", Offset = "0x59B538")]
			public bool enabled;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B570", Offset = "0x59B570")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59B570", Offset = "0x59B570")]
			public float threshold;

			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B5C4", Offset = "0x59B5C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B5C4", Offset = "0x59B5C4")]
			public float scale;

			[Token(Token = "0x4000078")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B618", Offset = "0x59B618")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B618", Offset = "0x59B618")]
			public float strength;

			[Token(Token = "0x17000023")]
			public static PredicationSettings defaultSettings
			{
				[Token(Token = "0x600005E")]
				[Address(RVA = "0x101E1A4", Offset = "0x101E1A4", VA = "0x101E1A4")]
				get
				{
					return default(PredicationSettings);
				}
			}
		}

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x10")]
		[TopLevelSettings]
		public GlobalSettings settings;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x1C")]
		[SettingsGroup]
		public QualitySettings quality;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x38")]
		[SettingsGroup]
		public PredicationSettings predication;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x48")]
		[ExperimentalGroup]
		[SettingsGroup]
		public TemporalSettings temporal;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x50")]
		private Matrix4x4 m_ProjectionMatrix;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x90")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xD0")]
		private float m_FlipFlop;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xD8")]
		private RenderTexture m_Accumulation;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xE0")]
		private Shader m_Shader;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xE8")]
		private Texture2D m_AreaTexture;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xF0")]
		private Texture2D m_SearchTexture;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xF8")]
		private Material m_Material;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x100")]
		private int m_AreaTex;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x104")]
		private int m_SearchTex;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x108")]
		private int m_Metrics;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10C")]
		private int m_Params1;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x110")]
		private int m_Params2;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x114")]
		private int m_Params3;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x118")]
		private int m_ReprojectionMatrix;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x11C")]
		private int m_SubsampleIndices;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x120")]
		private int m_BlendTex;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x124")]
		private int m_AccumulationTex;

		[Token(Token = "0x1700001D")]
		public Shader shader
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x101D35C", Offset = "0x101D35C", VA = "0x101D35C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x101D3FC", Offset = "0x101D3FC", VA = "0x101D3FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x101D4B0", Offset = "0x101D4B0", VA = "0x101D4B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private Material material
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x101D564", Offset = "0x101D564", VA = "0x101D564")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1016B74", Offset = "0x1016B74", VA = "0x1016B74", Slot = "4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1016DC0", Offset = "0x1016DC0", VA = "0x1016DC0", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1016E9C", Offset = "0x1016E9C", VA = "0x1016E9C", Slot = "6")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x101D5F0", Offset = "0x101D5F0", VA = "0x101D5F0", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x101D768", Offset = "0x101D768", VA = "0x101D768", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x101D790", Offset = "0x101D790", VA = "0x101D790", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x101E180", Offset = "0x101E180", VA = "0x101E180")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1017360", Offset = "0x1017360", VA = "0x1017360")]
		public SMAA()
		{
		}
	}
	[Token(Token = "0x200001C")]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A6F4", Offset = "0x59A6F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A6F4", Offset = "0x59A6F4")]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200001D")]
		public struct Settings
		{
			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B6B4", Offset = "0x59B6B4")]
			[SerializeField]
			public float threshold;

			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B700", Offset = "0x59B700")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B700", Offset = "0x59B700")]
			[SerializeField]
			public float softKnee;

			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B764", Offset = "0x59B764")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59B764", Offset = "0x59B764")]
			[SerializeField]
			public float radius;

			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B7C8", Offset = "0x59B7C8")]
			[SerializeField]
			public float intensity;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B814", Offset = "0x59B814")]
			[SerializeField]
			public bool highQuality;

			[Token(Token = "0x400008C")]
			[FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B860", Offset = "0x59B860")]
			[SerializeField]
			public bool antiFlicker;

			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B8AC", Offset = "0x59B8AC")]
			public Texture dirtTexture;

			[Token(Token = "0x400008E")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59B8E4", Offset = "0x59B8E4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B8E4", Offset = "0x59B8E4")]
			public float dirtIntensity;

			[Token(Token = "0x17000026")]
			public float thresholdGamma
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x1022D8C", Offset = "0x1022D8C", VA = "0x1022D8C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x1022D84", Offset = "0x1022D84", VA = "0x1022D84")]
				set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public float thresholdLinear
			{
				[Token(Token = "0x6000069")]
				[Address(RVA = "0x1018000", Offset = "0x1018000", VA = "0x1018000")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x1022D9C", Offset = "0x1022D9C", VA = "0x1022D9C")]
				set
				{
				}
			}

			[Token(Token = "0x17000028")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x10180B4", Offset = "0x10180B4", VA = "0x10180B4")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x48")]
		private Material m_Material;

		[Token(Token = "0x400007C")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x50")]
		private RenderTexture[] m_blurBuffer1;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x58")]
		private RenderTexture[] m_blurBuffer2;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x60")]
		private int m_Threshold;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x64")]
		private int m_Curve;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x68")]
		private int m_PrefilterOffs;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x6C")]
		private int m_SampleScale;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x70")]
		private int m_Intensity;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x74")]
		private int m_DirtTex;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x78")]
		private int m_DirtIntensity;

		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x7C")]
		private int m_BaseTex;

		[Token(Token = "0x17000024")]
		public Shader shader
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x10174F8", Offset = "0x10174F8", VA = "0x10174F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public Material material
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1017598", Offset = "0x1017598", VA = "0x1017598")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1017624", Offset = "0x1017624", VA = "0x1017624")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1017774", Offset = "0x1017774", VA = "0x1017774")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x10177C0", Offset = "0x10177C0", VA = "0x10177C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1017868", Offset = "0x1017868", VA = "0x1017868")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1018024", Offset = "0x1018024", VA = "0x1018024")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x17000029")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1018868", Offset = "0x1018868", VA = "0x1018868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x10162D8", Offset = "0x10162D8", VA = "0x10162D8")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1015824", Offset = "0x1015824", VA = "0x1015824")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x200001F")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x101C41C", Offset = "0x101C41C", VA = "0x101C41C")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x10")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1019F04", Offset = "0x1019F04", VA = "0x1019F04")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x101A0E0", Offset = "0x101A0E0", VA = "0x101A0E0")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1018D6C", Offset = "0x1018D6C", VA = "0x1018D6C")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x101AAF8", Offset = "0x101AAF8", VA = "0x101AAF8")]
		public RenderTextureUtility()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A798", Offset = "0x59A798")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A798", Offset = "0x59A798")]
	public class DepthOfField : MonoBehaviour
	{
		[Token(Token = "0x2000022")]
		private enum Passes
		{
			[Token(Token = "0x40000B3")]
			BlurAlphaWeighted,
			[Token(Token = "0x40000B4")]
			BoxBlur,
			[Token(Token = "0x40000B5")]
			DilateFgCocFromColor,
			[Token(Token = "0x40000B6")]
			DilateFgCoc,
			[Token(Token = "0x40000B7")]
			CaptureCocExplicit,
			[Token(Token = "0x40000B8")]
			VisualizeCocExplicit,
			[Token(Token = "0x40000B9")]
			CocPrefilter,
			[Token(Token = "0x40000BA")]
			CircleBlur,
			[Token(Token = "0x40000BB")]
			CircleBlurWithDilatedFg,
			[Token(Token = "0x40000BC")]
			CircleBlurLowQuality,
			[Token(Token = "0x40000BD")]
			CircleBlowLowQualityWithDilatedFg,
			[Token(Token = "0x40000BE")]
			MergeExplicit,
			[Token(Token = "0x40000BF")]
			ShapeLowQuality,
			[Token(Token = "0x40000C0")]
			ShapeLowQualityDilateFg,
			[Token(Token = "0x40000C1")]
			ShapeLowQualityMerge,
			[Token(Token = "0x40000C2")]
			ShapeLowQualityMergeDilateFg,
			[Token(Token = "0x40000C3")]
			ShapeMediumQuality,
			[Token(Token = "0x40000C4")]
			ShapeMediumQualityDilateFg,
			[Token(Token = "0x40000C5")]
			ShapeMediumQualityMerge,
			[Token(Token = "0x40000C6")]
			ShapeMediumQualityMergeDilateFg,
			[Token(Token = "0x40000C7")]
			ShapeHighQuality,
			[Token(Token = "0x40000C8")]
			ShapeHighQualityDilateFg,
			[Token(Token = "0x40000C9")]
			ShapeHighQualityMerge,
			[Token(Token = "0x40000CA")]
			ShapeHighQualityMergeDilateFg
		}

		[Token(Token = "0x2000023")]
		private enum MedianPasses
		{
			[Token(Token = "0x40000CC")]
			Median3,
			[Token(Token = "0x40000CD")]
			Median3X3
		}

		[Token(Token = "0x2000024")]
		private enum BokehTexturesPasses
		{
			[Token(Token = "0x40000CF")]
			Apply,
			[Token(Token = "0x40000D0")]
			Collect
		}

		[Token(Token = "0x2000025")]
		public enum TweakMode
		{
			[Token(Token = "0x40000D2")]
			Range,
			[Token(Token = "0x40000D3")]
			Explicit
		}

		[Token(Token = "0x2000026")]
		public enum ApertureShape
		{
			[Token(Token = "0x40000D5")]
			Circular,
			[Token(Token = "0x40000D6")]
			Hexagonal,
			[Token(Token = "0x40000D7")]
			Octogonal
		}

		[Token(Token = "0x2000027")]
		public enum QualityPreset
		{
			[Token(Token = "0x40000D9")]
			Low,
			[Token(Token = "0x40000DA")]
			Medium,
			[Token(Token = "0x40000DB")]
			High
		}

		[Token(Token = "0x2000028")]
		public enum FilterQuality
		{
			[Token(Token = "0x40000DD")]
			None,
			[Token(Token = "0x40000DE")]
			Normal,
			[Token(Token = "0x40000DF")]
			High
		}

		[Serializable]
		[Token(Token = "0x2000029")]
		public struct GlobalSettings
		{
			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B964", Offset = "0x59B964")]
			public bool visualizeFocus;

			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B99C", Offset = "0x59B99C")]
			public TweakMode tweakMode;

			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59B9D4", Offset = "0x59B9D4")]
			public QualityPreset filteringQuality;

			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BA0C", Offset = "0x59BA0C")]
			public ApertureShape apertureShape;

			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BA44", Offset = "0x59BA44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BA44", Offset = "0x59BA44")]
			public float apertureOrientation;

			[Token(Token = "0x17000033")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x101AAAC", Offset = "0x101AAAC", VA = "0x101AAAC")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200002A")]
		public struct QualitySettings
		{
			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BA9C", Offset = "0x59BA9C")]
			public bool prefilterBlur;

			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BAD4", Offset = "0x59BAD4")]
			public FilterQuality medianFilter;

			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BB0C", Offset = "0x59BB0C")]
			public bool dilateNearBlur;

			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200002B")]
		public struct FocusSettings
		{
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BB44", Offset = "0x59BB44")]
			public Transform transform;

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BB7C", Offset = "0x59BB7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BB7C", Offset = "0x59BB7C")]
			public float focusPlane;

			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BBCC", Offset = "0x59BBCC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BBCC", Offset = "0x59BBCC")]
			public float range;

			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BC20", Offset = "0x59BC20")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BC20", Offset = "0x59BC20")]
			public float nearPlane;

			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BC70", Offset = "0x59BC70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BC70", Offset = "0x59BC70")]
			public float nearFalloff;

			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BCC0", Offset = "0x59BCC0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BCC0", Offset = "0x59BCC0")]
			public float farPlane;

			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59BD10", Offset = "0x59BD10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BD10", Offset = "0x59BD10")]
			public float farFalloff;

			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BD60", Offset = "0x59BD60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BD60", Offset = "0x59BD60")]
			public float nearBlurRadius;

			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BDB8", Offset = "0x59BDB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BDB8", Offset = "0x59BDB8")]
			public float farBlurRadius;

			[Token(Token = "0x17000034")]
			public static FocusSettings defaultSettings
			{
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x101AAC4", Offset = "0x101AAC4", VA = "0x101AAC4")]
				get
				{
					return default(FocusSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200002C")]
		public struct BokehTextureSettings
		{
			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BE10", Offset = "0x59BE10")]
			public Texture2D texture;

			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BE48", Offset = "0x59BE48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BE48", Offset = "0x59BE48")]
			public float scale;

			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BEA0", Offset = "0x59BEA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BEA0", Offset = "0x59BEA0")]
			public float intensity;

			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BEFC", Offset = "0x59BEFC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BEFC", Offset = "0x59BEFC")]
			public float threshold;

			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BF54", Offset = "0x59BF54")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BF54", Offset = "0x59BF54")]
			public float spawnHeuristic;

			[Token(Token = "0x17000035")]
			public static BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x101AAE4", Offset = "0x101AAE4", VA = "0x101AAE4")]
				get
				{
					return default(BokehTextureSettings);
				}
			}
		}

		[Token(Token = "0x4000091")]
		private const float kMaxBlur = 40f;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x18")]
		public GlobalSettings settings;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		public FocusSettings focus;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		public BokehTextureSettings bokehTexture;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x88")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x90")]
		private Material m_FilmicDepthOfFieldMaterial;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x98")]
		private Material m_MedianFilterMaterial;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xA0")]
		private Material m_TextureBokehMaterial;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xA8")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xB0")]
		private ComputeBuffer m_ComputeBufferPoints;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xB8")]
		private QualitySettings m_CurrentQualitySettings;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xC4")]
		private float m_LastApertureOrientation;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xC8")]
		private Vector4 m_OctogonalBokehDirection1;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xD8")]
		private Vector4 m_OctogonalBokehDirection2;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xE8")]
		private Vector4 m_OctogonalBokehDirection3;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xF8")]
		private Vector4 m_OctogonalBokehDirection4;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x108")]
		private Vector4 m_HexagonalBokehDirection1;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x118")]
		private Vector4 m_HexagonalBokehDirection2;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x128")]
		private Vector4 m_HexagonalBokehDirection3;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x138")]
		private int m_BlurParams;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x13C")]
		private int m_BlurCoe;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x140")]
		private int m_Offsets;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x144")]
		private int m_BlurredColor;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x148")]
		private int m_SpawnHeuristic;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x14C")]
		private int m_BokehParams;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x150")]
		private int m_Convolved_TexelSize;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x154")]
		private int m_SecondTex;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x158")]
		private int m_ThirdTex;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x15C")]
		private int m_MainTex;

		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x160")]
		private int m_Screen;

		[Token(Token = "0x1700002A")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x10180DC", Offset = "0x10180DC", VA = "0x10180DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x101817C", Offset = "0x101817C", VA = "0x101817C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x101821C", Offset = "0x101821C", VA = "0x101821C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x10182BC", Offset = "0x10182BC", VA = "0x10182BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1018348", Offset = "0x1018348", VA = "0x1018348")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x10183D4", Offset = "0x10183D4", VA = "0x10183D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1018460", Offset = "0x1018460", VA = "0x1018460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1018530", Offset = "0x1018530", VA = "0x1018530")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x1019FF0", Offset = "0x1019FF0", VA = "0x1019FF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x10185A8", Offset = "0x10185A8", VA = "0x10185A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1018764", Offset = "0x1018764", VA = "0x1018764")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1018BB4", Offset = "0x1018BB4", VA = "0x1018BB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1018E28", Offset = "0x1018E28", VA = "0x1018E28")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x10192BC", Offset = "0x10192BC", VA = "0x10192BC")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x101A3E4", Offset = "0x101A3E4", VA = "0x101A3E4")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x101A658", Offset = "0x101A658", VA = "0x101A658")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x101A28C", Offset = "0x101A28C", VA = "0x101A28C")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1019010", Offset = "0x1019010", VA = "0x1019010")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1018D28", Offset = "0x1018D28", VA = "0x1018D28")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1018898", Offset = "0x1018898", VA = "0x1018898")]
		private void ComputeBlurDirections(bool force)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x101A9E0", Offset = "0x101A9E0", VA = "0x101A9E0")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x101A0CC", Offset = "0x101A0CC", VA = "0x101A0CC")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x101A8EC", Offset = "0x101A8EC", VA = "0x101A8EC")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x101AA04", Offset = "0x101AA04", VA = "0x101AA04")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A82C", Offset = "0x59A82C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A82C", Offset = "0x59A82C")]
	[ExecuteInEditMode]
	public class LensAberrations : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A8C0", Offset = "0x59A8C0")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x10231C8", Offset = "0x10231C8", VA = "0x10231C8")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59A8D4", Offset = "0x59A8D4")]
		public class AdvancedSetting : Attribute
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x10231C0", Offset = "0x10231C0", VA = "0x10231C0")]
			public AdvancedSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000030")]
		public struct DistortionSettings
		{
			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59BFEC", Offset = "0x59BFEC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59BFEC", Offset = "0x59BFEC")]
			public float amount;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C048", Offset = "0x59C048")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C048", Offset = "0x59C048")]
			public float centerX;

			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C09C", Offset = "0x59C09C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C09C", Offset = "0x59C09C")]
			public float centerY;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C0F0", Offset = "0x59C0F0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C0F0", Offset = "0x59C0F0")]
			public float amountX;

			[Token(Token = "0x400010C")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C144", Offset = "0x59C144")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C144", Offset = "0x59C144")]
			public float amountY;

			[Token(Token = "0x400010D")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C198", Offset = "0x59C198")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C198", Offset = "0x59C198")]
			public float scale;

			[Token(Token = "0x17000038")]
			public static DistortionSettings defaultSettings
			{
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x101C368", Offset = "0x101C368", VA = "0x101C368")]
				get
				{
					return default(DistortionSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000031")]
		public struct VignetteSettings
		{
			[Token(Token = "0x400010E")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59C1F0", Offset = "0x59C1F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C1F0", Offset = "0x59C1F0")]
			public Color color;

			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C240", Offset = "0x59C240")]
			public Vector2 center;

			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C278", Offset = "0x59C278")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C278", Offset = "0x59C278")]
			public float intensity;

			[Token(Token = "0x4000112")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C2CC", Offset = "0x59C2CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C2CC", Offset = "0x59C2CC")]
			public float smoothness;

			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C324", Offset = "0x59C324")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C324", Offset = "0x59C324")]
			[AdvancedSetting]
			public float roundness;

			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C388", Offset = "0x59C388")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C388", Offset = "0x59C388")]
			public float blur;

			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C3DC", Offset = "0x59C3DC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C3DC", Offset = "0x59C3DC")]
			public float desaturate;

			[Token(Token = "0x17000039")]
			public static VignetteSettings defaultSettings
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x101C380", Offset = "0x101C380", VA = "0x101C380")]
				get
				{
					return default(VignetteSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000032")]
		public struct ChromaticAberrationSettings
		{
			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000117")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59C430", Offset = "0x59C430")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C430", Offset = "0x59C430")]
			public Color color;

			[Token(Token = "0x4000118")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C480", Offset = "0x59C480")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C480", Offset = "0x59C480")]
			public float amount;

			[Token(Token = "0x1700003A")]
			public static ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x101C3E8", Offset = "0x101C3E8", VA = "0x101C3E8")]
				get
				{
					return default(ChromaticAberrationSettings);
				}
			}
		}

		[Token(Token = "0x2000033")]
		private enum Pass
		{
			[Token(Token = "0x400011A")]
			BlurPrePass,
			[Token(Token = "0x400011B")]
			Chroma,
			[Token(Token = "0x400011C")]
			Distort,
			[Token(Token = "0x400011D")]
			Vignette,
			[Token(Token = "0x400011E")]
			ChromaDistort,
			[Token(Token = "0x400011F")]
			ChromaVignette,
			[Token(Token = "0x4000120")]
			DistortVignette,
			[Token(Token = "0x4000121")]
			ChromaDistortVignette
		}

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x18")]
		[SettingsGroup]
		public DistortionSettings distortion;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x34")]
		[SettingsGroup]
		public VignetteSettings vignette;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x64")]
		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x88")]
		private Material m_Material;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x90")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x98")]
		private int m_DistCenterScale;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x9C")]
		private int m_DistAmount;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xA0")]
		private int m_ChromaticAberration;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xA4")]
		private int m_VignetteColor;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xA8")]
		private int m_BlurPass;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xAC")]
		private int m_BlurTex;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xB0")]
		private int m_VignetteBlur;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xB4")]
		private int m_VignetteDesat;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xB8")]
		private int m_VignetteCenter;

		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xBC")]
		private int m_VignetteSettings;

		[Token(Token = "0x17000036")]
		public Shader shader
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x101B640", Offset = "0x101B640", VA = "0x101B640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Material material
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x101B6E0", Offset = "0x101B6E0", VA = "0x101B6E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x101B76C", Offset = "0x101B76C", VA = "0x101B76C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x101B904", Offset = "0x101B904", VA = "0x101B904")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x101B988", Offset = "0x101B988", VA = "0x101B988")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x101BA3C", Offset = "0x101BA3C", VA = "0x101BA3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x101C2CC", Offset = "0x101C2CC", VA = "0x101C2CC")]
		public LensAberrations()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A8E8", Offset = "0x59A8E8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A8E8", Offset = "0x59A8E8")]
	public class MotionBlur : MonoBehaviour
	{
		[Token(Token = "0x2000035")]
		private class FrameBlendingFilter
		{
			[Token(Token = "0x2000036")]
			private struct Frame
			{
				[Token(Token = "0x4000138")]
				[FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				[Token(Token = "0x4000139")]
				[FieldOffset(Offset = "0x8")]
				public RenderTexture chromaTexture;

				[Token(Token = "0x400013A")]
				[FieldOffset(Offset = "0x10")]
				public float time;

				[Token(Token = "0x400013B")]
				[FieldOffset(Offset = "0x18")]
				private RenderBuffer[] _mrt;

				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x1023900", Offset = "0x1023900", VA = "0x1023900")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return default(float);
				}

				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x10234D0", Offset = "0x10234D0", VA = "0x10234D0")]
				public void Release()
				{
				}

				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x1023598", Offset = "0x1023598", VA = "0x1023598")]
				public void MakeRecord(RenderTexture source, Material material)
				{
				}

				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x102379C", Offset = "0x102379C", VA = "0x102379C")]
				public void MakeRecordRaw(RenderTexture source, RenderTextureFormat format)
				{
				}
			}

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0x10")]
			private bool _useCompression;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat _rawTextureFormat;

			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x18")]
			private Material _material;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x20")]
			private Frame[] _frameList;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x28")]
			private int _lastFrameCount;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x2C")]
			private int _History1LumaTex;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x30")]
			private int _History2LumaTex;

			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x34")]
			private int _History3LumaTex;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x38")]
			private int _History4LumaTex;

			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x3C")]
			private int _History1ChromaTex;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x40")]
			private int _History2ChromaTex;

			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x44")]
			private int _History3ChromaTex;

			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x48")]
			private int _History4ChromaTex;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x4C")]
			private int _History1Weight;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x50")]
			private int _History2Weight;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x54")]
			private int _History3Weight;

			[Token(Token = "0x4000137")]
			[FieldOffset(Offset = "0x58")]
			private int _History4Weight;

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x101C5F0", Offset = "0x101C5F0", VA = "0x101C5F0")]
			public FrameBlendingFilter()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x101C7C8", Offset = "0x101C7C8", VA = "0x101C7C8")]
			public void Release()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x101D1C4", Offset = "0x101D1C4", VA = "0x101D1C4")]
			public void PushFrame(RenderTexture source)
			{
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x101CF3C", Offset = "0x101CF3C", VA = "0x101CF3C")]
			public void BlendFrames(float strength, RenderTexture source, RenderTexture destination)
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x10231D0", Offset = "0x10231D0", VA = "0x10231D0")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1023218", Offset = "0x1023218", VA = "0x1023218")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return default(RenderTextureFormat);
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1023888", Offset = "0x1023888", VA = "0x1023888")]
			private Frame GetFrameRelative(int offset)
			{
				return default(Frame);
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x10232F0", Offset = "0x10232F0", VA = "0x10232F0")]
			private void FetchUniformLocations()
			{
			}
		}

		[Token(Token = "0x2000037")]
		private class ReconstructionFilter
		{
			[Token(Token = "0x400013C")]
			private const float kMaxBlurRadius = 5f;

			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0x10")]
			private Material _material;

			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x18")]
			private bool _unroll;

			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x1C")]
			private RenderTextureFormat _vectorRTFormat;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x20")]
			private RenderTextureFormat _packedRTFormat;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x24")]
			private int _VelocityScale;

			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x28")]
			private int _MaxBlurRadius;

			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x2C")]
			private int _TileMaxOffs;

			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x30")]
			private int _TileMaxLoop;

			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x34")]
			private int _LoopCount;

			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x38")]
			private int _NeighborMaxTex;

			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x3C")]
			private int _VelocityTex;

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x101C4E0", Offset = "0x101C4E0", VA = "0x101C4E0")]
			public ReconstructionFilter()
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x101C720", Offset = "0x101C720", VA = "0x101C720")]
			public void Release()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x101CB10", Offset = "0x101CB10", VA = "0x101CB10")]
			public void ProcessImage(float shutterAngle, int sampleCount, RenderTexture source, RenderTexture destination)
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x102396C", Offset = "0x102396C", VA = "0x102396C")]
			private bool CheckTextureFormatSupport()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1023AE4", Offset = "0x1023AE4", VA = "0x1023AE4")]
			private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format)
			{
				return null;
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1023B6C", Offset = "0x1023B6C", VA = "0x1023B6C")]
			private void ReleaseTemporaryRT(RenderTexture rt)
			{
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x10239B8", Offset = "0x10239B8", VA = "0x10239B8")]
			private void FetchUniformLocations()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public class Settings
		{
			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C50C", Offset = "0x59C50C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C50C", Offset = "0x59C50C")]
			public float shutterAngle;

			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C574", Offset = "0x59C574")]
			public int sampleCount;

			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C5C0", Offset = "0x59C5C0")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C5C0", Offset = "0x59C5C0")]
			public float frameBlending;

			[Token(Token = "0x1700003C")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0x101D2A0", Offset = "0x101D2A0", VA = "0x101D2A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x1023B78", Offset = "0x1023B78", VA = "0x1023B78")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Shader _reconstructionShader;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Shader _frameBlendingShader;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x30")]
		private ReconstructionFilter _reconstructionFilter;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x38")]
		private FrameBlendingFilter _frameBlendingFilter;

		[Token(Token = "0x1700003B")]
		public Settings settings
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x101C450", Offset = "0x101C450", VA = "0x101C450")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x101C458", Offset = "0x101C458", VA = "0x101C458")]
			set
			{
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x101C460", Offset = "0x101C460", VA = "0x101C460")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x101C6E0", Offset = "0x101C6E0", VA = "0x101C6E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x101C8AC", Offset = "0x101C8AC", VA = "0x101C8AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x101C940", Offset = "0x101C940", VA = "0x101C940")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x101D274", Offset = "0x101D274", VA = "0x101D274")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59A96C", Offset = "0x59A96C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59A96C", Offset = "0x59A96C")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		[Token(Token = "0x200003A")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000179")]
			High = 0,
			[Token(Token = "0x400017A")]
			Low = 2
		}

		[Token(Token = "0x200003B")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x400017C")]
			PhysicallyBased,
			[Token(Token = "0x400017D")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x200003C")]
		public struct SSRSettings
		{
			[Token(Token = "0x200003D")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AA10", Offset = "0x59AA10")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0x1024218", Offset = "0x1024218", VA = "0x1024218")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x0")]
			[Layout]
			public ReflectionSettings reflectionSettings;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x20")]
			[Layout]
			public IntensitySettings intensitySettings;

			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x30")]
			[Layout]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x17000040")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0x1023CC0", Offset = "0x1023CC0", VA = "0x1023CC0")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200003E")]
		public struct IntensitySettings
		{
			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C754", Offset = "0x59C754")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C754", Offset = "0x59C754")]
			public float reflectionMultiplier;

			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C7A8", Offset = "0x59C7A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C7A8", Offset = "0x59C7A8")]
			public float fadeDistance;

			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C800", Offset = "0x59C800")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C800", Offset = "0x59C800")]
			public float fresnelFade;

			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C854", Offset = "0x59C854")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C854", Offset = "0x59C854")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x200003F")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C8AC", Offset = "0x59C8AC")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C8E4", Offset = "0x59C8E4")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C91C", Offset = "0x59C91C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C91C", Offset = "0x59C91C")]
			public float maxDistance;

			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C978", Offset = "0x59C978")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C978", Offset = "0x59C978")]
			public int iterationCount;

			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59C9D0", Offset = "0x59C9D0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C9D0", Offset = "0x59C9D0")]
			public int stepSize;

			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CA24", Offset = "0x59CA24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CA24", Offset = "0x59CA24")]
			public float widthModifier;

			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CA7C", Offset = "0x59CA7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CA7C", Offset = "0x59CA7C")]
			public float reflectionBlur;

			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CAD4", Offset = "0x59CAD4")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x400018E")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CB0C", Offset = "0x59CB0C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CB0C", Offset = "0x59CB0C")]
			public float intensity;
		}

		[Token(Token = "0x2000041")]
		private enum PassIndex
		{
			[Token(Token = "0x4000190")]
			RayTraceStep,
			[Token(Token = "0x4000191")]
			CompositeFinal,
			[Token(Token = "0x4000192")]
			Blur,
			[Token(Token = "0x4000193")]
			CompositeSSR,
			[Token(Token = "0x4000194")]
			MinMipGeneration,
			[Token(Token = "0x4000195")]
			HitPointToReflections,
			[Token(Token = "0x4000196")]
			BilateralKeyPack,
			[Token(Token = "0x4000197")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000198")]
			PoissonBlur
		}

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C634", Offset = "0x59C634")]
		private bool highlightSuppression;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x4D")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C66C", Offset = "0x59C66C")]
		private bool traceBehindObjects;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x4E")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C6A4", Offset = "0x59C6A4")]
		private bool treatBackfaceHitAsMiss;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x4F")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59C6DC", Offset = "0x59C6DC")]
		private bool bilateralUpsample;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x58")]
		private Material m_Material;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_Camera;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x68")]
		private CommandBuffer m_CommandBuffer;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x0")]
		private static int kNormalAndRoughnessTexture;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x4")]
		private static int kHitPointTexture;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x8")]
		private static int[] kReflectionTextures;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		private static int kFilteredReflections;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x14")]
		private static int kBlurTexture;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x18")]
		private static int kFinalReflectionTexture;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x1C")]
		private static int kTempTexture;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		private static int kRayStepSize;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x24")]
		private static int kAdditiveReflection;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x28")]
		private static int kBilateralUpsampling;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x2C")]
		private static int kTreatBackfaceHitAsMiss;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x30")]
		private static int kAllowBackwardsRays;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x34")]
		private static int kTraceBehindObjects;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x38")]
		private static int kMaxSteps;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x3C")]
		private static int kFullResolutionFiltering;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x40")]
		private static int kHalfResolution;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x44")]
		private static int kHighlightSuppression;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x48")]
		private static int kPixelsPerMeterAtOneMeter;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x4C")]
		private static int kScreenEdgeFading;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x50")]
		private static int kReflectionBlur;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x54")]
		private static int kMaxRayTraceDistance;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x58")]
		private static int kFadeDistance;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x5C")]
		private static int kLayerThickness;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x60")]
		private static int kSSRMultiplier;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x64")]
		private static int kFresnelFade;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x68")]
		private static int kFresnelFadePower;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x6C")]
		private static int kReflectionBufferSize;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x70")]
		private static int kScreenSize;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x74")]
		private static int kInvScreenSize;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x78")]
		private static int kProjInfo;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x7C")]
		private static int kCameraClipInfo;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x80")]
		private static int kProjectToPixelMatrix;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x84")]
		private static int kWorldToCameraMatrix;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x88")]
		private static int kCameraToWorldMatrix;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x8C")]
		private static int kAxis;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x90")]
		private static int kCurrentMipLevel;

		[Token(Token = "0x1700003D")]
		public Shader shader
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x101E1C4", Offset = "0x101E1C4", VA = "0x101E1C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Material material
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x101E264", Offset = "0x101E264", VA = "0x101E264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public Camera camera_
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x101E2F0", Offset = "0x101E2F0", VA = "0x101E2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x101E390", Offset = "0x101E390", VA = "0x101E390")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x101EB4C", Offset = "0x101EB4C", VA = "0x101EB4C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x101EBC0", Offset = "0x101EBC0", VA = "0x101EBC0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x101ECCC", Offset = "0x101ECCC", VA = "0x101ECCC")]
		public void OnPreRender()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1020148", Offset = "0x1020148", VA = "0x1020148")]
		public ScreenSpaceReflection()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x59AA24", Offset = "0x59AA24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x59AA24", Offset = "0x59AA24")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[Token(Token = "0x2000043")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AAC8", Offset = "0x59AAC8")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1024208", Offset = "0x1024208", VA = "0x1024208")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000044")]
		public class IndentedGroup : PropertyAttribute
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1024200", Offset = "0x1024200", VA = "0x1024200")]
			public IndentedGroup()
			{
			}
		}

		[Token(Token = "0x2000045")]
		public class ChannelMixer : PropertyAttribute
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1023DF0", Offset = "0x1023DF0", VA = "0x1023DF0")]
			public ChannelMixer()
			{
			}
		}

		[Token(Token = "0x2000046")]
		public class ColorWheelGroup : PropertyAttribute
		{
			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x10")]
			public int minSizePerWheel;

			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x14")]
			public int maxSizePerWheel;

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1023FAC", Offset = "0x1023FAC", VA = "0x1023FAC")]
			public ColorWheelGroup()
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1023FC0", Offset = "0x1023FC0", VA = "0x1023FC0")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}
		}

		[Token(Token = "0x2000047")]
		public class Curve : PropertyAttribute
		{
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x10")]
			public Color color;

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1024004", Offset = "0x1024004", VA = "0x1024004")]
			public Curve()
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1024038", Offset = "0x1024038", VA = "0x1024038")]
			public Curve(float r, float g, float b, float a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000048")]
		public struct EyeAdaptationSettings
		{
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CC70", Offset = "0x59CC70")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59CC70", Offset = "0x59CC70")]
			public float middleGrey;

			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CCC0", Offset = "0x59CCC0")]
			public float min;

			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CCF8", Offset = "0x59CCF8")]
			public float max;

			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CD30", Offset = "0x59CD30")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59CD30", Offset = "0x59CD30")]
			public float speed;

			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CD80", Offset = "0x59CD80")]
			public bool showDebug;

			[Token(Token = "0x1700004F")]
			public static EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x60000F0")]
				[Address(RVA = "0x1022C48", Offset = "0x1022C48", VA = "0x1022C48")]
				get
				{
					return default(EyeAdaptationSettings);
				}
			}
		}

		[Token(Token = "0x2000049")]
		public enum Tonemapper
		{
			[Token(Token = "0x40001CE")]
			ACES,
			[Token(Token = "0x40001CF")]
			Curve,
			[Token(Token = "0x40001D0")]
			Hable,
			[Token(Token = "0x40001D1")]
			HejlDawson,
			[Token(Token = "0x40001D2")]
			Photographic,
			[Token(Token = "0x40001D3")]
			Reinhard,
			[Token(Token = "0x40001D4")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x200004A")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CDB8", Offset = "0x59CDB8")]
			public Tonemapper tonemapper;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CDF0", Offset = "0x59CDF0")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x59CDF0", Offset = "0x59CDF0")]
			public float exposure;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CE40", Offset = "0x59CE40")]
			public AnimationCurve curve;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CE78", Offset = "0x59CE78")]
			public float neutralBlackIn;

			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CE98", Offset = "0x59CE98")]
			public float neutralWhiteIn;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CEB0", Offset = "0x59CEB0")]
			public float neutralBlackOut;

			[Token(Token = "0x40001DC")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CED0", Offset = "0x59CED0")]
			public float neutralWhiteOut;

			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CEE8", Offset = "0x59CEE8")]
			public float neutralWhiteLevel;

			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CF04", Offset = "0x59CF04")]
			public float neutralWhiteClip;

			[Token(Token = "0x17000050")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60000F1")]
				[Address(RVA = "0x1022C68", Offset = "0x1022C68", VA = "0x1022C68")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004B")]
		public struct LUTSettings
		{
			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CF1C", Offset = "0x59CF1C")]
			public Texture texture;

			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CF54", Offset = "0x59CF54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CF54", Offset = "0x59CF54")]
			public float contribution;

			[Token(Token = "0x17000051")]
			public static LUTSettings defaultSettings
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x1022D6C", Offset = "0x1022D6C", VA = "0x1022D6C")]
				get
				{
					return default(LUTSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004C")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x40001E2")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59CFA8", Offset = "0x59CFA8")]
			public Color shadows;

			[Token(Token = "0x40001E3")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59CFBC", Offset = "0x59CFBC")]
			public Color midtones;

			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x59CFD0", Offset = "0x59CFD0")]
			public Color highlights;

			[Token(Token = "0x17000052")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60000F3")]
				[Address(RVA = "0x1023EA4", Offset = "0x1023EA4", VA = "0x1023EA4")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004D")]
		public struct BasicsSettings
		{
			[Token(Token = "0x40001E5")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59CFE4", Offset = "0x59CFE4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59CFE4", Offset = "0x59CFE4")]
			public float temperatureShift;

			[Token(Token = "0x40001E6")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D038", Offset = "0x59D038")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D038", Offset = "0x59D038")]
			public float tint;

			[Token(Token = "0x40001E7")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D08C", Offset = "0x59D08C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D08C", Offset = "0x59D08C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D08C", Offset = "0x59D08C")]
			public float hue;

			[Token(Token = "0x40001E8")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D0F0", Offset = "0x59D0F0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D0F0", Offset = "0x59D0F0")]
			public float saturation;

			[Token(Token = "0x40001E9")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D144", Offset = "0x59D144")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D144", Offset = "0x59D144")]
			public float vibrance;

			[Token(Token = "0x40001EA")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D198", Offset = "0x59D198")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D198", Offset = "0x59D198")]
			public float value;

			[Token(Token = "0x40001EB")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D1EC", Offset = "0x59D1EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D1EC", Offset = "0x59D1EC")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D1EC", Offset = "0x59D1EC")]
			public float contrast;

			[Token(Token = "0x40001EC")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D250", Offset = "0x59D250")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D250", Offset = "0x59D250")]
			public float gain;

			[Token(Token = "0x40001ED")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x59D2A8", Offset = "0x59D2A8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D2A8", Offset = "0x59D2A8")]
			public float gamma;

			[Token(Token = "0x17000053")]
			public static BasicsSettings defaultSettings
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x1023DD0", Offset = "0x1023DD0", VA = "0x1023DD0")]
				get
				{
					return default(BasicsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004E")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x40001EE")]
			[FieldOffset(Offset = "0x0")]
			public int currentChannel;

			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x8")]
			public Vector3[] channels;

			[Token(Token = "0x17000054")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0x1023DF8", Offset = "0x1023DF8", VA = "0x1023DF8")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004F")]
		public struct CurvesSettings
		{
			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "Curve", RVA = "0x59D300", Offset = "0x59D300")]
			public AnimationCurve master;

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "Curve", RVA = "0x59D310", Offset = "0x59D310")]
			public AnimationCurve red;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "Curve", RVA = "0x59D330", Offset = "0x59D330")]
			public AnimationCurve green;

			[Token(Token = "0x40001F3")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "Curve", RVA = "0x59D350", Offset = "0x59D350")]
			public AnimationCurve blue;

			[Token(Token = "0x17000055")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x60000F6")]
				[Address(RVA = "0x1023F30", Offset = "0x1023F30", VA = "0x1023F30")]
				get
				{
					return default(CurvesSettings);
				}
			}

			[Token(Token = "0x17000056")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x10240C0", Offset = "0x10240C0", VA = "0x10240C0")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x2000050")]
		public enum ColorGradingPrecision
		{
			[Token(Token = "0x40001F5")]
			Normal = 0x10,
			[Token(Token = "0x40001F6")]
			High = 0x20
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public struct ColorGradingSettings
		{
			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D370", Offset = "0x59D370")]
			public ColorGradingPrecision precision;

			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "ColorWheelGroup", RVA = "0x59D3A8", Offset = "0x59D3A8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D3A8", Offset = "0x59D3A8")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x38")]
			[IndentedGroup]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D3E0", Offset = "0x59D3E0")]
			public BasicsSettings basics;

			[Token(Token = "0x40001FB")]
			[FieldOffset(Offset = "0x60")]
			[ChannelMixer]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D418", Offset = "0x59D418")]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D450", Offset = "0x59D450")]
			[IndentedGroup]
			public CurvesSettings curves;

			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x59D488", Offset = "0x59D488")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D488", Offset = "0x59D488")]
			public bool useDithering;

			[Token(Token = "0x40001FE")]
			[FieldOffset(Offset = "0x91")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x59D4D4", Offset = "0x59D4D4")]
			public bool showDebug;

			[Token(Token = "0x17000057")]
			public static ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x60000F8")]
				[Address(RVA = "0x1022CB8", Offset = "0x1022CB8", VA = "0x1022CB8")]
				get
				{
					return default(ColorGradingSettings);
				}
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1023F78", Offset = "0x1023F78", VA = "0x1023F78")]
			internal void Reset()
			{
			}
		}

		[Token(Token = "0x2000052")]
		private enum Pass
		{
			[Token(Token = "0x4000200")]
			LutGen,
			[Token(Token = "0x4000201")]
			AdaptationLog,
			[Token(Token = "0x4000202")]
			AdaptationExpBlend,
			[Token(Token = "0x4000203")]
			AdaptationExp,
			[Token(Token = "0x4000204")]
			TonemappingOff,
			[Token(Token = "0x4000205")]
			TonemappingACES,
			[Token(Token = "0x4000206")]
			TonemappingCurve,
			[Token(Token = "0x4000207")]
			TonemappingHable,
			[Token(Token = "0x4000208")]
			TonemappingHejlDawson,
			[Token(Token = "0x4000209")]
			TonemappingPhotographic,
			[Token(Token = "0x400020A")]
			TonemappingReinhard,
			[Token(Token = "0x400020B")]
			TonemappingNeutral,
			[Token(Token = "0x400020C")]
			AdaptationDebug
		}

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x60")]
		[SettingsGroup]
		[SerializeField]
		private ColorGradingSettings m_ColorGrading;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xF8")]
		[SettingsGroup]
		[SerializeField]
		private LUTSettings m_Lut;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x110")]
		private Texture2D m_IdentityLut;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x118")]
		private RenderTexture m_InternalLut;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x120")]
		private Texture2D m_CurveTexture;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x128")]
		private Texture2D m_TonemapperCurve;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x130")]
		private float m_TonemapperCurveRange;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x140")]
		private Material m_Material;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CC50", Offset = "0x59CC50")]
		private bool <validRenderTextureFormat>k__BackingField;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59CC60", Offset = "0x59CC60")]
		private bool <validUserLutSize>k__BackingField;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x14A")]
		private bool m_Dirty;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x14B")]
		private bool m_TonemapperDirty;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x150")]
		private RenderTexture m_SmallAdaptiveRt;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x158")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x15C")]
		private int m_AdaptationSpeed;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x160")]
		private int m_MiddleGrey;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x164")]
		private int m_AdaptationMin;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x168")]
		private int m_AdaptationMax;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x16C")]
		private int m_LumTex;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x170")]
		private int m_ToneCurveRange;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x174")]
		private int m_ToneCurve;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x178")]
		private int m_Exposure;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x17C")]
		private int m_NeutralTonemapperParams1;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x180")]
		private int m_NeutralTonemapperParams2;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x184")]
		private int m_WhiteBalance;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x188")]
		private int m_Lift;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x18C")]
		private int m_Gamma;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x190")]
		private int m_Gain;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x194")]
		private int m_ContrastGainGamma;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x198")]
		private int m_Vibrance;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x19C")]
		private int m_HSV;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x1A0")]
		private int m_ChannelMixerRed;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x1A4")]
		private int m_ChannelMixerGreen;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_ChannelMixerBlue;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x1AC")]
		private int m_CurveTex;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x1B0")]
		private int m_InternalLutTex;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x1B4")]
		private int m_InternalLutParams;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x1B8")]
		private int m_UserLutTex;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x1BC")]
		private int m_UserLutParams;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x1C0")]
		private RenderTexture[] m_AdaptRts;

		[Token(Token = "0x17000041")]
		public EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x102022C", Offset = "0x102022C", VA = "0x102022C")]
			get
			{
				return default(EyeAdaptationSettings);
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1020240", Offset = "0x1020240", VA = "0x1020240")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public TonemappingSettings tonemapping
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1020254", Offset = "0x1020254", VA = "0x1020254")]
			get
			{
				return default(TonemappingSettings);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1020268", Offset = "0x1020268", VA = "0x1020268")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public ColorGradingSettings colorGrading
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1020290", Offset = "0x1020290", VA = "0x1020290")]
			get
			{
				return default(ColorGradingSettings);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x10202A0", Offset = "0x10202A0", VA = "0x10202A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public LUTSettings lut
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x10202DC", Offset = "0x10202DC", VA = "0x10202DC")]
			get
			{
				return default(LUTSettings);
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x10202F0", Offset = "0x10202F0", VA = "0x10202F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		private Texture2D identityLut
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1020304", Offset = "0x1020304", VA = "0x1020304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x10205F4", Offset = "0x10205F4", VA = "0x10205F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1020774", Offset = "0x1020774", VA = "0x1020774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x10208A0", Offset = "0x10208A0", VA = "0x10208A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public Shader shader
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1020A04", Offset = "0x1020A04", VA = "0x1020A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public Material material
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1020AA4", Offset = "0x1020AA4", VA = "0x1020AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1020B30", Offset = "0x1020B30", VA = "0x1020B30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public int lutSize
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x10203E0", Offset = "0x10203E0", VA = "0x10203E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1020B50", Offset = "0x1020B50", VA = "0x1020B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D5BC", Offset = "0x59D5BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1020B58", Offset = "0x1020B58", VA = "0x1020B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D5CC", Offset = "0x59D5CC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool validUserLutSize
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1020B64", Offset = "0x1020B64", VA = "0x1020B64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D5DC", Offset = "0x59D5DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1020B6C", Offset = "0x1020B6C", VA = "0x1020B6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x59D5EC", Offset = "0x59D5EC")]
			private set
			{
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x10202D0", Offset = "0x10202D0", VA = "0x10202D0")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1020284", Offset = "0x1020284", VA = "0x1020284")]
		public void SetTonemapperDirty()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1020B78", Offset = "0x1020B78", VA = "0x1020B78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1020F2C", Offset = "0x1020F2C", VA = "0x1020F2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1020F80", Offset = "0x1020F80", VA = "0x1020F80")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x10211FC", Offset = "0x10211FC", VA = "0x10211FC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x10203E8", Offset = "0x10203E8", VA = "0x10203E8")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1021208", Offset = "0x1021208", VA = "0x1021208")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1021234", Offset = "0x1021234", VA = "0x1021234")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x10212C4", Offset = "0x10212C4", VA = "0x10212C4")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x10213D8", Offset = "0x10213D8", VA = "0x10213D8")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x102147C", Offset = "0x102147C", VA = "0x102147C")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1021690", Offset = "0x1021690", VA = "0x1021690")]
		private void GenCurveTexture()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1021880", Offset = "0x1021880", VA = "0x1021880")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1021910", Offset = "0x1021910", VA = "0x1021910")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1021A14", Offset = "0x1021A14", VA = "0x1021A14")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1021C0C", Offset = "0x1021C0C", VA = "0x1021C0C")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1022A64", Offset = "0x1022A64", VA = "0x1022A64")]
		public Texture2D BakeLUT()
		{
			return null;
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1022BA4", Offset = "0x1022BA4", VA = "0x1022BA4")]
		public TonemappingColorGrading()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AADC", Offset = "0x59AADC")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x101AB70", Offset = "0x101AB70", VA = "0x101AB70")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AAF0", Offset = "0x59AAF0")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x101D310", Offset = "0x101D310", VA = "0x101D310")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AB04", Offset = "0x59AB04")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x10")]
		private readonly string target;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x101D318", Offset = "0x101D318", VA = "0x101D318")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x101D320", Offset = "0x101D320", VA = "0x101D320")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x101D34C", Offset = "0x101D34C", VA = "0x101D34C")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AB18", Offset = "0x59AB18")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x101D354", Offset = "0x101D354", VA = "0x101D354")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AB2C", Offset = "0x59AB2C")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x102021C", Offset = "0x102021C", VA = "0x102021C")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x59AB40", Offset = "0x59AB40")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1020224", Offset = "0x1020224", VA = "0x1020224")]
		public SkipRenameAttribute()
		{
		}
	}
}
