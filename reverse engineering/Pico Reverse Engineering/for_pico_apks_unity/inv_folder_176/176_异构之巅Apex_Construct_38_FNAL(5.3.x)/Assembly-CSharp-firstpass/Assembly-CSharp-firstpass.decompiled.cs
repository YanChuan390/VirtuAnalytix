using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Beebyte.Obfuscator
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F218", Offset = "0x44F218")]
	public class DoNotFakeAttribute : Attribute
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1D23B78", Offset = "0x1D23B78", VA = "0x1D23B78")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F22C", Offset = "0x44F22C")]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1D23B80", Offset = "0x1D23B80", VA = "0x1D23B80")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F240", Offset = "0x44F240")]
	public class RenameAttribute : Attribute
	{
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x8")]
		private readonly string target;

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1D23B88", Offset = "0x1D23B88", VA = "0x1D23B88")]
		private RenameAttribute()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1D23B90", Offset = "0x1D23B90", VA = "0x1D23B90")]
		public RenameAttribute(string target)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1D23BB0", Offset = "0x1D23BB0", VA = "0x1D23BB0")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F254", Offset = "0x44F254")]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1D23BB8", Offset = "0x1D23BB8", VA = "0x1D23BB8")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F268", Offset = "0x44F268")]
	public class SkipAttribute : Attribute
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1D23BC0", Offset = "0x1D23BC0", VA = "0x1D23BC0")]
		public SkipAttribute()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F27C", Offset = "0x44F27C")]
	public class SkipRenameAttribute : Attribute
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1D23BC8", Offset = "0x1D23BC8", VA = "0x1D23BC8")]
		public SkipRenameAttribute()
		{
		}
	}
}
namespace UnityStandardAssets.CinematicEffects
{
	[Token(Token = "0x2000008")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44F290", Offset = "0x44F290")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44F290", Offset = "0x44F290")]
	[ImageEffectAllowedInSceneView]
	public class AmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x2000009")]
		private class PropertyObserver
		{
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x8")]
			private bool _downsampling;

			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0xC")]
			private OcclusionSource _occlusionSource;

			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x10")]
			private bool _ambientOnly;

			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x11")]
			private bool _debug;

			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x14")]
			private int _pixelWidth;

			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x18")]
			private int _pixelHeight;

			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1D244E8", Offset = "0x1D244E8", VA = "0x1D244E8")]
			public PropertyObserver()
			{
			}

			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1D25F54", Offset = "0x1D25F54", VA = "0x1D25F54")]
			public bool CheckNeedsReset(Settings setting, Camera camera)
			{
				return default(bool);
			}

			[Token(Token = "0x6000024")]
			[Address(RVA = "0x1D26044", Offset = "0x1D26044", VA = "0x1D26044")]
			public void Update(Settings setting, Camera camera)
			{
			}
		}

		[Token(Token = "0x200000A")]
		public enum SampleCount
		{
			[Token(Token = "0x4000014")]
			Lowest,
			[Token(Token = "0x4000015")]
			Low,
			[Token(Token = "0x4000016")]
			Medium,
			[Token(Token = "0x4000017")]
			High,
			[Token(Token = "0x4000018")]
			Custom
		}

		[Token(Token = "0x200000B")]
		public enum OcclusionSource
		{
			[Token(Token = "0x400001A")]
			DepthTexture,
			[Token(Token = "0x400001B")]
			DepthNormalsTexture,
			[Token(Token = "0x400001C")]
			GBuffer
		}

		[Serializable]
		[Token(Token = "0x200000C")]
		public class Settings
		{
			[Token(Token = "0x400001D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F390", Offset = "0x44F390")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F390", Offset = "0x44F390")]
			public float intensity;

			[Token(Token = "0x400001E")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F3F4", Offset = "0x44F3F4")]
			public float radius;

			[Token(Token = "0x400001F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F43C", Offset = "0x44F43C")]
			public SampleCount sampleCount;

			[Token(Token = "0x4000020")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F484", Offset = "0x44F484")]
			public int sampleCountValue;

			[Token(Token = "0x4000021")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F4CC", Offset = "0x44F4CC")]
			public bool downsampling;

			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x19")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F514", Offset = "0x44F514")]
			public bool ambientOnly;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F55C", Offset = "0x44F55C")]
			public OcclusionSource occlusionSource;

			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F5A4", Offset = "0x44F5A4")]
			public bool debug;

			[Token(Token = "0x17000010")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x6000026")]
				[Address(RVA = "0x1D243EC", Offset = "0x1D243EC", VA = "0x1D243EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1D261C0", Offset = "0x1D261C0", VA = "0x1D261C0")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _aoShader;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x14")]
		private Material _aoMaterial;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		private CommandBuffer _aoCommands;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x1C")]
		private PropertyObserver _propertyObserver;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Mesh _quadMesh;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x24")]
		private int _OcclusionTexture;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		private int _Intensity;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x2C")]
		private int _Radius;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		private int _Downsample;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x34")]
		private int _SampleCount;

		[Token(Token = "0x17000001")]
		public bool isAmbientOnlySupported
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1D244F0", Offset = "0x1D244F0", VA = "0x1D244F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000002")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1D24600", Offset = "0x1D24600", VA = "0x1D24600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000003")]
		private float intensity
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1D2463C", Offset = "0x1D2463C", VA = "0x1D2463C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		private float radius
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1D2465C", Offset = "0x1D2465C", VA = "0x1D2465C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000005")]
		private SampleCount sampleCount
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1D24708", Offset = "0x1D24708", VA = "0x1D24708")]
			get
			{
				return default(SampleCount);
			}
		}

		[Token(Token = "0x17000006")]
		private int sampleCountValue
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1D24728", Offset = "0x1D24728", VA = "0x1D24728")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000007")]
		private OcclusionSource occlusionSource
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1D245A8", Offset = "0x1D245A8", VA = "0x1D245A8")]
			get
			{
				return default(OcclusionSource);
			}
		}

		[Token(Token = "0x17000008")]
		private bool downsampling
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1D24848", Offset = "0x1D24848", VA = "0x1D24848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		private bool ambientOnly
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x1D24868", Offset = "0x1D24868", VA = "0x1D24868")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private Shader aoShader
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x1D248C4", Offset = "0x1D248C4", VA = "0x1D248C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private Material aoMaterial
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x1D24980", Offset = "0x1D24980", VA = "0x1D24980")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private CommandBuffer aoCommands
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x1D24B30", Offset = "0x1D24B30", VA = "0x1D24B30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private Camera targetCamera
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x1D24544", Offset = "0x1D24544", VA = "0x1D24544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private PropertyObserver propertyObserver
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x1D24BD8", Offset = "0x1D24BD8", VA = "0x1D24BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private Mesh quadMesh
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1D24BE0", Offset = "0x1D24BE0", VA = "0x1D24BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1D24368", Offset = "0x1D24368", VA = "0x1D24368")]
		public AmbientOcclusion()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1D24BE8", Offset = "0x1D24BE8", VA = "0x1D24BE8")]
		private void BuildAOCommands()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1D252D0", Offset = "0x1D252D0", VA = "0x1D252D0")]
		private void ExecuteAOPass(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1D255F4", Offset = "0x1D255F4", VA = "0x1D255F4")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1D256FC", Offset = "0x1D256FC", VA = "0x1D256FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1D257E8", Offset = "0x1D257E8", VA = "0x1D257E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1D25D54", Offset = "0x1D25D54", VA = "0x1D25D54")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1D25DA0", Offset = "0x1D25DA0", VA = "0x1D25DA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1D25E7C", Offset = "0x1D25E7C", VA = "0x1D25E7C")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1D26100", Offset = "0x1D26100", VA = "0x1D26100")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x200000D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44F5EC", Offset = "0x44F5EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44F5EC", Offset = "0x44F5EC")]
	[ImageEffectAllowedInSceneView]
	public class AntiAliasing : MonoBehaviour
	{
		[Token(Token = "0x200000E")]
		public enum Method
		{
			[Token(Token = "0x400002A")]
			Smaa,
			[Token(Token = "0x400002B")]
			Fxaa
		}

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private SMAA m_SMAA;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private FXAA m_FXAA;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[HideInInspector]
		private int m_Method;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_Camera;

		[Token(Token = "0x17000011")]
		public int method
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x1D26448", Offset = "0x1D26448", VA = "0x1D26448")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1D26450", Offset = "0x1D26450", VA = "0x1D26450")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public IAntiAliasing current
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x1D26460", Offset = "0x1D26460", VA = "0x1D26460")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public Camera cameraComponent
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1D26474", Offset = "0x1D26474", VA = "0x1D26474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1D261C8", Offset = "0x1D261C8", VA = "0x1D261C8")]
		public AntiAliasing()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1D2652C", Offset = "0x1D2652C", VA = "0x1D2652C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1D26784", Offset = "0x1D26784", VA = "0x1D26784")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1D2687C", Offset = "0x1D2687C", VA = "0x1D2687C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1D26B04", Offset = "0x1D26B04", VA = "0x1D26B04")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1D26BF4", Offset = "0x1D26BF4", VA = "0x1D26BF4")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1D26CE4", Offset = "0x1D26CE4", VA = "0x1D26CE4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000F")]
	public class FXAA : IAntiAliasing
	{
		[Serializable]
		[Token(Token = "0x2000010")]
		public struct QualitySettings
		{
			[Token(Token = "0x4000033")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F780", Offset = "0x44F780")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F780", Offset = "0x44F780")]
			public float subpixelAliasingRemovalAmount;

			[Token(Token = "0x4000034")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F7D0", Offset = "0x44F7D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F7D0", Offset = "0x44F7D0")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000035")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F828", Offset = "0x44F828")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F828", Offset = "0x44F828")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x2000011")]
		public struct ConsoleSettings
		{
			[Token(Token = "0x4000036")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F87C", Offset = "0x44F87C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F87C", Offset = "0x44F87C")]
			public float subpixelSpreadAmount;

			[Token(Token = "0x4000037")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F8D0", Offset = "0x44F8D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F8D0", Offset = "0x44F8D0")]
			public float edgeSharpnessAmount;

			[Token(Token = "0x4000038")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F920", Offset = "0x44F920")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F920", Offset = "0x44F920")]
			public float edgeDetectionThreshold;

			[Token(Token = "0x4000039")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44F970", Offset = "0x44F970")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44F970", Offset = "0x44F970")]
			public float minimumRequiredLuminance;
		}

		[Serializable]
		[Token(Token = "0x2000012")]
		public struct Preset
		{
			[Token(Token = "0x2000013")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44F9E8", Offset = "0x44F9E8")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x6000044")]
				[Address(RVA = "0x1D2C6E4", Offset = "0x1D2C6E4", VA = "0x1D2C6E4")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x400003A")]
			[FieldOffset(Offset = "0x0")]
			[Layout]
			public QualitySettings qualitySettings;

			[Token(Token = "0x400003B")]
			[FieldOffset(Offset = "0xC")]
			[Layout]
			public ConsoleSettings consoleSettings;

			[Token(Token = "0x400003C")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Preset s_ExtremePerformance;

			[Token(Token = "0x400003D")]
			[FieldOffset(Offset = "0x1C")]
			private static readonly Preset s_Performance;

			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x38")]
			private static readonly Preset s_Default;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x54")]
			private static readonly Preset s_Quality;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x70")]
			private static readonly Preset s_ExtremeQuality;

			[Token(Token = "0x17000017")]
			public static Preset extremePerformancePreset
			{
				[Token(Token = "0x600003E")]
				[Address(RVA = "0x1D2C2F4", Offset = "0x1D2C2F4", VA = "0x1D2C2F4")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000018")]
			public static Preset performancePreset
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x1D2C390", Offset = "0x1D2C390", VA = "0x1D2C390")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x17000019")]
			public static Preset defaultPreset
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x1D2BD28", Offset = "0x1D2BD28", VA = "0x1D2BD28")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x1700001A")]
			public static Preset qualityPreset
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x1D2C430", Offset = "0x1D2C430", VA = "0x1D2C430")]
				get
				{
					return default(Preset);
				}
			}

			[Token(Token = "0x1700001B")]
			public static Preset extremeQualityPreset
			{
				[Token(Token = "0x6000042")]
				[Address(RVA = "0x1D2C4D0", Offset = "0x1D2C4D0", VA = "0x1D2C4D0")]
				get
				{
					return default(Preset);
				}
			}
		}

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x8")]
		private Shader m_Shader;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xC")]
		private Material m_Material;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[HideInInspector]
		public Preset preset;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		public static Preset[] availablePresets;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F72C", Offset = "0x44F72C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x44F72C", Offset = "0x44F72C")]
		private bool <validSourceFormat>k__BackingField;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x30")]
		private int m_QualitySettings;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x34")]
		private int m_ConsoleSettings;

		[Token(Token = "0x17000014")]
		private Shader shader
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1D2BDC8", Offset = "0x1D2BDC8", VA = "0x1D2BDC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Material material
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1D2BE84", Offset = "0x1D2BE84", VA = "0x1D2BE84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool validSourceFormat
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1D2BF34", Offset = "0x1D2BF34", VA = "0x1D2BF34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F760", Offset = "0x44F760")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1D2BF3C", Offset = "0x1D2BF3C", VA = "0x1D2BF3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F770", Offset = "0x44F770")]
			private set
			{
			}
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1D26390", Offset = "0x1D26390", VA = "0x1D26390")]
		public FXAA()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1D266F8", Offset = "0x1D266F8", VA = "0x1D266F8", Slot = "4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1D26824", Offset = "0x1D26824", VA = "0x1D26824", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1D26A2C", Offset = "0x1D26A2C", VA = "0x1D26A2C", Slot = "6")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1D2BF44", Offset = "0x1D2BF44", VA = "0x1D2BF44", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1D2BF48", Offset = "0x1D2BF48", VA = "0x1D2BF48", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1D2BF4C", Offset = "0x1D2BF4C", VA = "0x1D2BF4C", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x2000014")]
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
	[Token(Token = "0x2000015")]
	public class SMAA : IAntiAliasing
	{
		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44FA5C", Offset = "0x44FA5C")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x1D3506C", Offset = "0x1D3506C", VA = "0x1D3506C")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000017")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44FA70", Offset = "0x44FA70")]
		public class TopLevelSettings : Attribute
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1D350B0", Offset = "0x1D350B0", VA = "0x1D350B0")]
			public TopLevelSettings()
			{
			}
		}

		[Token(Token = "0x2000018")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44FA84", Offset = "0x44FA84")]
		public class ExperimentalGroup : Attribute
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x1D34D80", Offset = "0x1D34D80", VA = "0x1D34D80")]
			public ExperimentalGroup()
			{
			}
		}

		[Token(Token = "0x2000019")]
		public enum DebugPass
		{
			[Token(Token = "0x4000058")]
			Off,
			[Token(Token = "0x4000059")]
			Edges,
			[Token(Token = "0x400005A")]
			Weights,
			[Token(Token = "0x400005B")]
			Accumulation
		}

		[Token(Token = "0x200001A")]
		public enum QualityPreset
		{
			[Token(Token = "0x400005D")]
			Low,
			[Token(Token = "0x400005E")]
			Medium,
			[Token(Token = "0x400005F")]
			High,
			[Token(Token = "0x4000060")]
			Ultra,
			[Token(Token = "0x4000061")]
			Custom
		}

		[Token(Token = "0x200001B")]
		public enum EdgeDetectionMethod
		{
			[Token(Token = "0x4000063")]
			Luma = 1,
			[Token(Token = "0x4000064")]
			Color,
			[Token(Token = "0x4000065")]
			Depth
		}

		[Serializable]
		[Token(Token = "0x200001C")]
		public struct GlobalSettings
		{
			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FA98", Offset = "0x44FA98")]
			public DebugPass debugPass;

			[Token(Token = "0x4000067")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FACC", Offset = "0x44FACC")]
			public QualityPreset quality;

			[Token(Token = "0x4000068")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FB00", Offset = "0x44FB00")]
			public EdgeDetectionMethod edgeDetectionMethod;

			[Token(Token = "0x17000020")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600005A")]
				[Address(RVA = "0x1D33200", Offset = "0x1D33200", VA = "0x1D33200")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200001D")]
		public struct QualitySettings
		{
			[Token(Token = "0x4000069")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FB34", Offset = "0x44FB34")]
			public bool diagonalDetection;

			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x1")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FB68", Offset = "0x44FB68")]
			public bool cornerDetection;

			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FB9C", Offset = "0x44FB9C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FB9C", Offset = "0x44FB9C")]
			public float threshold;

			[Token(Token = "0x400006C")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x44FBEC", Offset = "0x44FBEC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FBEC", Offset = "0x44FBEC")]
			public float depthThreshold;

			[Token(Token = "0x400006D")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FC3C", Offset = "0x44FC3C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FC3C", Offset = "0x44FC3C")]
			public int maxSearchSteps;

			[Token(Token = "0x400006E")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FC90", Offset = "0x44FC90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FC90", Offset = "0x44FC90")]
			public int maxDiagonalSearchSteps;

			[Token(Token = "0x400006F")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FCE4", Offset = "0x44FCE4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FCE4", Offset = "0x44FCE4")]
			public int cornerRounding;

			[Token(Token = "0x4000070")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x44FD38", Offset = "0x44FD38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FD38", Offset = "0x44FD38")]
			public float localContrastAdaptationFactor;

			[Token(Token = "0x4000071")]
			[FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200001E")]
		public struct TemporalSettings
		{
			[Token(Token = "0x4000072")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FD84", Offset = "0x44FD84")]
			public bool enabled;

			[Token(Token = "0x4000073")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FDB8", Offset = "0x44FDB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FDB8", Offset = "0x44FDB8")]
			public float fuzzSize;

			[Token(Token = "0x17000021")]
			public static TemporalSettings defaultSettings
			{
				[Token(Token = "0x600005D")]
				[Address(RVA = "0x1D33258", Offset = "0x1D33258", VA = "0x1D33258")]
				get
				{
					return default(TemporalSettings);
				}
			}

			[Token(Token = "0x600005C")]
			[Address(RVA = "0x1D350A8", Offset = "0x1D350A8", VA = "0x1D350A8")]
			public bool UseTemporal()
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200001F")]
		public struct PredicationSettings
		{
			[Token(Token = "0x4000074")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FE0C", Offset = "0x44FE0C")]
			public bool enabled;

			[Token(Token = "0x4000075")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x44FE40", Offset = "0x44FE40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FE40", Offset = "0x44FE40")]
			public float threshold;

			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FE90", Offset = "0x44FE90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FE90", Offset = "0x44FE90")]
			public float scale;

			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44FEE4", Offset = "0x44FEE4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44FEE4", Offset = "0x44FEE4")]
			public float strength;

			[Token(Token = "0x17000022")]
			public static PredicationSettings defaultSettings
			{
				[Token(Token = "0x600005E")]
				[Address(RVA = "0x1D33214", Offset = "0x1D33214", VA = "0x1D33214")]
				get
				{
					return default(PredicationSettings);
				}
			}
		}

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x8")]
		[TopLevelSettings]
		public GlobalSettings settings;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x14")]
		[SettingsGroup]
		public QualitySettings quality;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x30")]
		[SettingsGroup]
		public PredicationSettings predication;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x40")]
		[SettingsGroup]
		[ExperimentalGroup]
		public TemporalSettings temporal;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x48")]
		private Matrix4x4 m_ProjectionMatrix;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x88")]
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xC8")]
		private float m_FlipFlop;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xCC")]
		private RenderTexture m_Accumulation;

		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0xD0")]
		private Shader m_Shader;

		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0xD4")]
		private Texture2D m_AreaTexture;

		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0xD8")]
		private Texture2D m_SearchTexture;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0xDC")]
		private Material m_Material;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0xE0")]
		private int m_AreaTex;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0xE4")]
		private int m_SearchTex;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0xE8")]
		private int m_Metrics;

		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0xEC")]
		private int m_Params1;

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0xF0")]
		private int m_Params2;

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0xF4")]
		private int m_Params3;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0xF8")]
		private int m_ReprojectionMatrix;

		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0xFC")]
		private int m_SubsampleIndices;

		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x100")]
		private int m_BlendTex;

		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x104")]
		private int m_AccumulationTex;

		[Token(Token = "0x1700001C")]
		public Shader shader
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1D33268", Offset = "0x1D33268", VA = "0x1D33268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private Texture2D areaTexture
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1D33324", Offset = "0x1D33324", VA = "0x1D33324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private Texture2D searchTexture
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1D333EC", Offset = "0x1D333EC", VA = "0x1D333EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private Material material
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1D334B4", Offset = "0x1D334B4", VA = "0x1D334B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1D26260", Offset = "0x1D26260", VA = "0x1D26260")]
		public SMAA()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x1D2656C", Offset = "0x1D2656C", VA = "0x1D2656C", Slot = "4")]
		public void Awake()
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1D267CC", Offset = "0x1D267CC", VA = "0x1D267CC", Slot = "5")]
		public void OnEnable(AntiAliasing owner)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1D268BC", Offset = "0x1D268BC", VA = "0x1D268BC", Slot = "6")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1D33564", Offset = "0x1D33564", VA = "0x1D33564", Slot = "7")]
		public void OnPreCull(Camera camera)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1D339A0", Offset = "0x1D339A0", VA = "0x1D339A0", Slot = "8")]
		public void OnPostRender(Camera camera)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1D339D4", Offset = "0x1D339D4", VA = "0x1D339D4", Slot = "9")]
		public void OnRenderImage(Camera camera, RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1D34D50", Offset = "0x1D34D50", VA = "0x1D34D50")]
		private RenderTexture TempRT(int width, int height, RenderTextureFormat format)
		{
			return null;
		}
	}
	[Token(Token = "0x2000020")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44FF34", Offset = "0x44FF34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44FF34", Offset = "0x44FF34")]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000021")]
		public struct Settings
		{
			[Token(Token = "0x4000086")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450034", Offset = "0x450034")]
			public float threshold;

			[Token(Token = "0x4000087")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x45007C", Offset = "0x45007C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45007C", Offset = "0x45007C")]
			public float softKnee;

			[Token(Token = "0x4000088")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4500DC", Offset = "0x4500DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4500DC", Offset = "0x4500DC")]
			public float radius;

			[Token(Token = "0x4000089")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450140", Offset = "0x450140")]
			public float intensity;

			[Token(Token = "0x400008A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450188", Offset = "0x450188")]
			public bool highQuality;

			[Token(Token = "0x400008B")]
			[FieldOffset(Offset = "0x11")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4501D0", Offset = "0x4501D0")]
			public bool antiFlicker;

			[Token(Token = "0x400008C")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450218", Offset = "0x450218")]
			public Texture dirtTexture;

			[Token(Token = "0x400008D")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x45024C", Offset = "0x45024C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45024C", Offset = "0x45024C")]
			public float dirtIntensity;

			[Token(Token = "0x17000025")]
			public float thresholdGamma
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x1D2800C", Offset = "0x1D2800C", VA = "0x1D2800C")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x1D27F6C", Offset = "0x1D27F6C", VA = "0x1D27F6C")]
				set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float thresholdLinear
			{
				[Token(Token = "0x6000069")]
				[Address(RVA = "0x1D280AC", Offset = "0x1D280AC", VA = "0x1D280AC")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x1D280A4", Offset = "0x1D280A4", VA = "0x1D280A4")]
				set
				{
				}
			}

			[Token(Token = "0x17000027")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x600006A")]
				[Address(RVA = "0x1D26ED0", Offset = "0x1D26ED0", VA = "0x1D26ED0")]
				get
				{
					return default(Settings);
				}
			}
		}

		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		public Settings settings;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x2C")]
		private Material m_Material;

		[Token(Token = "0x400007B")]
		private const int kMaxIterations = 16;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture[] m_blurBuffer1;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x34")]
		private RenderTexture[] m_blurBuffer2;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x38")]
		private int m_Threshold;

		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x3C")]
		private int m_Curve;

		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x40")]
		private int m_PrefilterOffs;

		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x44")]
		private int m_SampleScale;

		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x48")]
		private int m_Intensity;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x4C")]
		private int m_DirtTex;

		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x50")]
		private int m_DirtIntensity;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x54")]
		private int m_BaseTex;

		[Token(Token = "0x17000023")]
		public Shader shader
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x1D26F20", Offset = "0x1D26F20", VA = "0x1D26F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public Material material
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x1D26FDC", Offset = "0x1D26FDC", VA = "0x1D26FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1D26DF0", Offset = "0x1D26DF0", VA = "0x1D26DF0")]
		public Bloom()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1D2708C", Offset = "0x1D2708C", VA = "0x1D2708C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1D271D8", Offset = "0x1D271D8", VA = "0x1D271D8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1D27224", Offset = "0x1D27224", VA = "0x1D27224")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1D27304", Offset = "0x1D27304", VA = "0x1D27304")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x2000022")]
	public static class ImageEffectHelper
	{
		[Token(Token = "0x17000028")]
		public static bool supportsDX11
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x1D28BE4", Offset = "0x1D28BE4", VA = "0x1D28BE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D25944", Offset = "0x1D25944", VA = "0x1D25944")]
		public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect)
		{
			return default(bool);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1D24A30", Offset = "0x1D24A30", VA = "0x1D24A30")]
		public static Material CheckShaderAndCreateMaterial(Shader s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public sealed class MinAttribute : PropertyAttribute
	{
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x8")]
		public readonly float min;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1D2DE40", Offset = "0x1D2DE40", VA = "0x1D2DE40")]
		public MinAttribute(float min)
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class RenderTextureUtility
	{
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x8")]
		private List<RenderTexture> m_TemporaryRTs;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1D28278", Offset = "0x1D28278", VA = "0x1D28278")]
		public RenderTextureUtility()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1D2AB84", Offset = "0x1D2AB84", VA = "0x1D2AB84")]
		public RenderTexture GetTemporaryRenderTexture(int width, int height, int depthBuffer = 0, RenderTextureFormat format = RenderTextureFormat.ARGBHalf, FilterMode filterMode = FilterMode.Bilinear)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1D2ADC4", Offset = "0x1D2ADC4", VA = "0x1D2ADC4")]
		public void ReleaseTemporaryRenderTexture(RenderTexture rt)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1D29298", Offset = "0x1D29298", VA = "0x1D29298")]
		public void ReleaseAllTemporaryRenderTextures()
		{
		}
	}
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x450298", Offset = "0x450298")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x450298", Offset = "0x450298")]
	public class DepthOfField : MonoBehaviour
	{
		[Token(Token = "0x2000026")]
		private enum Passes
		{
			[Token(Token = "0x40000B2")]
			BlurAlphaWeighted,
			[Token(Token = "0x40000B3")]
			BoxBlur,
			[Token(Token = "0x40000B4")]
			DilateFgCocFromColor,
			[Token(Token = "0x40000B5")]
			DilateFgCoc,
			[Token(Token = "0x40000B6")]
			CaptureCocExplicit,
			[Token(Token = "0x40000B7")]
			VisualizeCocExplicit,
			[Token(Token = "0x40000B8")]
			CocPrefilter,
			[Token(Token = "0x40000B9")]
			CircleBlur,
			[Token(Token = "0x40000BA")]
			CircleBlurWithDilatedFg,
			[Token(Token = "0x40000BB")]
			CircleBlurLowQuality,
			[Token(Token = "0x40000BC")]
			CircleBlowLowQualityWithDilatedFg,
			[Token(Token = "0x40000BD")]
			MergeExplicit,
			[Token(Token = "0x40000BE")]
			ShapeLowQuality,
			[Token(Token = "0x40000BF")]
			ShapeLowQualityDilateFg,
			[Token(Token = "0x40000C0")]
			ShapeLowQualityMerge,
			[Token(Token = "0x40000C1")]
			ShapeLowQualityMergeDilateFg,
			[Token(Token = "0x40000C2")]
			ShapeMediumQuality,
			[Token(Token = "0x40000C3")]
			ShapeMediumQualityDilateFg,
			[Token(Token = "0x40000C4")]
			ShapeMediumQualityMerge,
			[Token(Token = "0x40000C5")]
			ShapeMediumQualityMergeDilateFg,
			[Token(Token = "0x40000C6")]
			ShapeHighQuality,
			[Token(Token = "0x40000C7")]
			ShapeHighQualityDilateFg,
			[Token(Token = "0x40000C8")]
			ShapeHighQualityMerge,
			[Token(Token = "0x40000C9")]
			ShapeHighQualityMergeDilateFg
		}

		[Token(Token = "0x2000027")]
		private enum MedianPasses
		{
			[Token(Token = "0x40000CB")]
			Median3,
			[Token(Token = "0x40000CC")]
			Median3X3
		}

		[Token(Token = "0x2000028")]
		private enum BokehTexturesPasses
		{
			[Token(Token = "0x40000CE")]
			Apply,
			[Token(Token = "0x40000CF")]
			Collect
		}

		[Token(Token = "0x2000029")]
		public enum TweakMode
		{
			[Token(Token = "0x40000D1")]
			Range,
			[Token(Token = "0x40000D2")]
			Explicit
		}

		[Token(Token = "0x200002A")]
		public enum ApertureShape
		{
			[Token(Token = "0x40000D4")]
			Circular,
			[Token(Token = "0x40000D5")]
			Hexagonal,
			[Token(Token = "0x40000D6")]
			Octogonal
		}

		[Token(Token = "0x200002B")]
		public enum QualityPreset
		{
			[Token(Token = "0x40000D8")]
			Low,
			[Token(Token = "0x40000D9")]
			Medium,
			[Token(Token = "0x40000DA")]
			High
		}

		[Token(Token = "0x200002C")]
		public enum FilterQuality
		{
			[Token(Token = "0x40000DC")]
			None,
			[Token(Token = "0x40000DD")]
			Normal,
			[Token(Token = "0x40000DE")]
			High
		}

		[Serializable]
		[Token(Token = "0x200002D")]
		public struct GlobalSettings
		{
			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450388", Offset = "0x450388")]
			public bool visualizeFocus;

			[Token(Token = "0x40000E0")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4503BC", Offset = "0x4503BC")]
			public TweakMode tweakMode;

			[Token(Token = "0x40000E1")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4503F0", Offset = "0x4503F0")]
			public QualityPreset filteringQuality;

			[Token(Token = "0x40000E2")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450424", Offset = "0x450424")]
			public ApertureShape apertureShape;

			[Token(Token = "0x40000E3")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450458", Offset = "0x450458")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450458", Offset = "0x450458")]
			public float apertureOrientation;

			[Token(Token = "0x17000032")]
			public static GlobalSettings defaultSettings
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x1D281C0", Offset = "0x1D281C0", VA = "0x1D281C0")]
				get
				{
					return default(GlobalSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200002E")]
		public struct QualitySettings
		{
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4504AC", Offset = "0x4504AC")]
			public bool prefilterBlur;

			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4504E0", Offset = "0x4504E0")]
			public FilterQuality medianFilter;

			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450514", Offset = "0x450514")]
			public bool dilateNearBlur;

			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x0")]
			public static QualitySettings[] presetQualitySettings;
		}

		[Serializable]
		[Token(Token = "0x200002F")]
		public struct FocusSettings
		{
			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450548", Offset = "0x450548")]
			public Transform transform;

			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x45057C", Offset = "0x45057C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45057C", Offset = "0x45057C")]
			public float focusPlane;

			[Token(Token = "0x40000EA")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x4505C8", Offset = "0x4505C8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4505C8", Offset = "0x4505C8")]
			public float range;

			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x450618", Offset = "0x450618")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450618", Offset = "0x450618")]
			public float nearPlane;

			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x450664", Offset = "0x450664")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450664", Offset = "0x450664")]
			public float nearFalloff;

			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x4506B0", Offset = "0x4506B0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4506B0", Offset = "0x4506B0")]
			public float farPlane;

			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x4506FC", Offset = "0x4506FC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4506FC", Offset = "0x4506FC")]
			public float farFalloff;

			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450748", Offset = "0x450748")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450748", Offset = "0x450748")]
			public float nearBlurRadius;

			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x45079C", Offset = "0x45079C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45079C", Offset = "0x45079C")]
			public float farBlurRadius;

			[Token(Token = "0x17000033")]
			public static FocusSettings defaultSettings
			{
				[Token(Token = "0x600008D")]
				[Address(RVA = "0x1D281FC", Offset = "0x1D281FC", VA = "0x1D281FC")]
				get
				{
					return default(FocusSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000030")]
		public struct BokehTextureSettings
		{
			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4507F0", Offset = "0x4507F0")]
			public Texture2D texture;

			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450824", Offset = "0x450824")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450824", Offset = "0x450824")]
			public float scale;

			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x45087C", Offset = "0x45087C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45087C", Offset = "0x45087C")]
			public float intensity;

			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4508D4", Offset = "0x4508D4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4508D4", Offset = "0x4508D4")]
			public float threshold;

			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x45092C", Offset = "0x45092C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45092C", Offset = "0x45092C")]
			public float spawnHeuristic;

			[Token(Token = "0x17000034")]
			public static BokehTextureSettings defaultSettings
			{
				[Token(Token = "0x600008E")]
				[Address(RVA = "0x1D28250", Offset = "0x1D28250", VA = "0x1D28250")]
				get
				{
					return default(BokehTextureSettings);
				}
			}
		}

		[Token(Token = "0x4000090")]
		private const float kMaxBlur = 40f;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xC")]
		public GlobalSettings settings;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		public FocusSettings focus;

		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x44")]
		public BokehTextureSettings bokehTexture;

		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Shader m_MedianFilterShader;

		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Shader m_TextureBokehShader;

		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x64")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x68")]
		private Material m_FilmicDepthOfFieldMaterial;

		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x6C")]
		private Material m_MedianFilterMaterial;

		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x70")]
		private Material m_TextureBokehMaterial;

		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x74")]
		private ComputeBuffer m_ComputeBufferDrawArgs;

		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x78")]
		private ComputeBuffer m_ComputeBufferPoints;

		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x7C")]
		private QualitySettings m_CurrentQualitySettings;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x88")]
		private float m_LastApertureOrientation;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x8C")]
		private Vector4 m_OctogonalBokehDirection1;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x9C")]
		private Vector4 m_OctogonalBokehDirection2;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xAC")]
		private Vector4 m_OctogonalBokehDirection3;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xBC")]
		private Vector4 m_OctogonalBokehDirection4;

		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xCC")]
		private Vector4 m_HexagonalBokehDirection1;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xDC")]
		private Vector4 m_HexagonalBokehDirection2;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xEC")]
		private Vector4 m_HexagonalBokehDirection3;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xFC")]
		private int m_BlurParams;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x100")]
		private int m_BlurCoe;

		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x104")]
		private int m_Offsets;

		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x108")]
		private int m_BlurredColor;

		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x10C")]
		private int m_SpawnHeuristic;

		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x110")]
		private int m_BokehParams;

		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x114")]
		private int m_Convolved_TexelSize;

		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x118")]
		private int m_SecondTex;

		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x11C")]
		private int m_ThirdTex;

		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x120")]
		private int m_MainTex;

		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x124")]
		private int m_Screen;

		[Token(Token = "0x17000029")]
		public Shader filmicDepthOfFieldShader
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x1D28304", Offset = "0x1D28304", VA = "0x1D28304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public Shader medianFilterShader
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0x1D283C0", Offset = "0x1D283C0", VA = "0x1D283C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public Shader textureBokehShader
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x1D2847C", Offset = "0x1D2847C", VA = "0x1D2847C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public Material filmicDepthOfFieldMaterial
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1D28538", Offset = "0x1D28538", VA = "0x1D28538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public Material medianFilterMaterial
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1D285E8", Offset = "0x1D285E8", VA = "0x1D285E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public Material textureBokehMaterial
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1D28698", Offset = "0x1D28698", VA = "0x1D28698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public ComputeBuffer computeBufferDrawArgs
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x1D28748", Offset = "0x1D28748", VA = "0x1D28748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public ComputeBuffer computeBufferPoints
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1D28848", Offset = "0x1D28848", VA = "0x1D28848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private bool shouldPerformBokeh
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1D2ACB4", Offset = "0x1D2ACB4", VA = "0x1D2ACB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1D280B4", Offset = "0x1D280B4", VA = "0x1D280B4")]
		public DepthOfField()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1D288E8", Offset = "0x1D288E8", VA = "0x1D288E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1D28A94", Offset = "0x1D28A94", VA = "0x1D28A94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1D29034", Offset = "0x1D29034", VA = "0x1D29034")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1D29378", Offset = "0x1D29378", VA = "0x1D29378")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1D29940", Offset = "0x1D29940", VA = "0x1D29940")]
		private void DoDepthOfField(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1D2B124", Offset = "0x1D2B124", VA = "0x1D2B124")]
		private void DoHexagonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1D2B4AC", Offset = "0x1D2B4AC", VA = "0x1D2B4AC")]
		private void DoOctogonalBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1D2AF98", Offset = "0x1D2AF98", VA = "0x1D2AF98")]
		private void DoCircularBlur(RenderTexture blurredFgCoc, ref RenderTexture src, ref RenderTexture dst, float maxRadius)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1D29628", Offset = "0x1D29628", VA = "0x1D29628")]
		private void ComputeCocParameters(out Vector4 blurParams, out Vector4 blurCoe)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1D29254", Offset = "0x1D29254", VA = "0x1D29254")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1D28C1C", Offset = "0x1D28C1C", VA = "0x1D28C1C")]
		private void ComputeBlurDirections(bool force)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1D2B9F4", Offset = "0x1D2B9F4", VA = "0x1D2B9F4")]
		private static void Rotate2D(ref Vector4 direction, float cosinus, float sinus)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1D2ADB0", Offset = "0x1D2ADB0", VA = "0x1D2ADB0")]
		private static void SwapRenderTexture(ref RenderTexture src, ref RenderTexture dst)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1D2B8A8", Offset = "0x1D2B8A8", VA = "0x1D2B8A8")]
		private static void GetDirectionalBlurPassesFromRadius(RenderTexture blurredFgCoc, float maxRadius, out int blurPass, out int blurAndMergePass)
		{
		}
	}
	[Token(Token = "0x2000031")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x450980", Offset = "0x450980")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x450980", Offset = "0x450980")]
	public class LensAberrations : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x450A70", Offset = "0x450A70")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1D2DD78", Offset = "0x1D2DD78", VA = "0x1D2DD78")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000033")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x450A84", Offset = "0x450A84")]
		public class AdvancedSetting : Attribute
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1D2DC8C", Offset = "0x1D2DC8C", VA = "0x1D2DC8C")]
			public AdvancedSetting()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000034")]
		public struct DistortionSettings
		{
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450A98", Offset = "0x450A98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450A98", Offset = "0x450A98")]
			public float amount;

			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450AF0", Offset = "0x450AF0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450AF0", Offset = "0x450AF0")]
			public float centerX;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450B44", Offset = "0x450B44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450B44", Offset = "0x450B44")]
			public float centerY;

			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450B98", Offset = "0x450B98")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450B98", Offset = "0x450B98")]
			public float amountX;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450BE8", Offset = "0x450BE8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450BE8", Offset = "0x450BE8")]
			public float amountY;

			[Token(Token = "0x400010C")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450C38", Offset = "0x450C38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450C38", Offset = "0x450C38")]
			public float scale;

			[Token(Token = "0x17000037")]
			public static DistortionSettings defaultSettings
			{
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x1D2C7B4", Offset = "0x1D2C7B4", VA = "0x1D2C7B4")]
				get
				{
					return default(DistortionSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000035")]
		public struct VignetteSettings
		{
			[Token(Token = "0x400010D")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x400010E")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x450C90", Offset = "0x450C90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450C90", Offset = "0x450C90")]
			public Color color;

			[Token(Token = "0x400010F")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450CDC", Offset = "0x450CDC")]
			public Vector2 center;

			[Token(Token = "0x4000110")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450D10", Offset = "0x450D10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450D10", Offset = "0x450D10")]
			public float intensity;

			[Token(Token = "0x4000111")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450D64", Offset = "0x450D64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450D64", Offset = "0x450D64")]
			public float smoothness;

			[Token(Token = "0x4000112")]
			[FieldOffset(Offset = "0x24")]
			[AdvancedSetting]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450DBC", Offset = "0x450DBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450DBC", Offset = "0x450DBC")]
			public float roundness;

			[Token(Token = "0x4000113")]
			[FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450E1C", Offset = "0x450E1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450E1C", Offset = "0x450E1C")]
			public float blur;

			[Token(Token = "0x4000114")]
			[FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450E6C", Offset = "0x450E6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450E6C", Offset = "0x450E6C")]
			public float desaturate;

			[Token(Token = "0x17000038")]
			public static VignetteSettings defaultSettings
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x1D2C7FC", Offset = "0x1D2C7FC", VA = "0x1D2C7FC")]
				get
				{
					return default(VignetteSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000036")]
		public struct ChromaticAberrationSettings
		{
			[Token(Token = "0x4000115")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x4000116")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x450EBC", Offset = "0x450EBC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450EBC", Offset = "0x450EBC")]
			public Color color;

			[Token(Token = "0x4000117")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x450F08", Offset = "0x450F08")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x450F08", Offset = "0x450F08")]
			public float amount;

			[Token(Token = "0x17000039")]
			public static ChromaticAberrationSettings defaultSettings
			{
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x1D2C8CC", Offset = "0x1D2C8CC", VA = "0x1D2C8CC")]
				get
				{
					return default(ChromaticAberrationSettings);
				}
			}
		}

		[Token(Token = "0x2000037")]
		private enum Pass
		{
			[Token(Token = "0x4000119")]
			BlurPrePass,
			[Token(Token = "0x400011A")]
			Chroma,
			[Token(Token = "0x400011B")]
			Distort,
			[Token(Token = "0x400011C")]
			Vignette,
			[Token(Token = "0x400011D")]
			ChromaDistort,
			[Token(Token = "0x400011E")]
			ChromaVignette,
			[Token(Token = "0x400011F")]
			DistortVignette,
			[Token(Token = "0x4000120")]
			ChromaDistortVignette
		}

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0xC")]
		[SettingsGroup]
		public DistortionSettings distortion;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x28")]
		[SettingsGroup]
		public VignetteSettings vignette;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x58")]
		[SettingsGroup]
		public ChromaticAberrationSettings chromaticAberration;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x74")]
		private Material m_Material;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x78")]
		private RenderTextureUtility m_RTU;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x7C")]
		private int m_DistCenterScale;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x80")]
		private int m_DistAmount;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x84")]
		private int m_ChromaticAberration;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x88")]
		private int m_VignetteColor;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x8C")]
		private int m_BlurPass;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x90")]
		private int m_BlurTex;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x94")]
		private int m_VignetteBlur;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x98")]
		private int m_VignetteDesat;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x9C")]
		private int m_VignetteCenter;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xA0")]
		private int m_VignetteSettings;

		[Token(Token = "0x17000035")]
		public Shader shader
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x1D2C91C", Offset = "0x1D2C91C", VA = "0x1D2C91C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public Material material
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x1D2C9D8", Offset = "0x1D2C9D8", VA = "0x1D2C9D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1D2C6EC", Offset = "0x1D2C6EC", VA = "0x1D2C6EC")]
		public LensAberrations()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1D2CA88", Offset = "0x1D2CA88", VA = "0x1D2CA88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1D2CC14", Offset = "0x1D2CC14", VA = "0x1D2CC14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1D2CCBC", Offset = "0x1D2CCBC", VA = "0x1D2CCBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1D2CDB4", Offset = "0x1D2CDB4", VA = "0x1D2CDB4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x450F60", Offset = "0x450F60")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x450F60", Offset = "0x450F60")]
	public class MotionBlur : MonoBehaviour
	{
		[Token(Token = "0x2000039")]
		private class FrameBlendingFilter
		{
			[Token(Token = "0x200003A")]
			private struct Frame
			{
				[Token(Token = "0x4000137")]
				[FieldOffset(Offset = "0x0")]
				public RenderTexture lumaTexture;

				[Token(Token = "0x4000138")]
				[FieldOffset(Offset = "0x4")]
				public RenderTexture chromaTexture;

				[Token(Token = "0x4000139")]
				[FieldOffset(Offset = "0x8")]
				public float time;

				[Token(Token = "0x400013A")]
				[FieldOffset(Offset = "0xC")]
				private RenderBuffer[] _mrt;

				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x1D2FD24", Offset = "0x1D2FD24", VA = "0x1D2FD24")]
				public float CalculateWeight(float strength, float currentTime)
				{
					return default(float);
				}

				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x1D2FD2C", Offset = "0x1D2FD2C", VA = "0x1D2FD2C")]
				public void Release()
				{
				}

				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x1D2FD34", Offset = "0x1D2FD34", VA = "0x1D2FD34")]
				public void MakeRecord(RenderTexture source, Material material)
				{
				}

				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x1D2FD3C", Offset = "0x1D2FD3C", VA = "0x1D2FD3C")]
				public void MakeRecordRaw(RenderTexture source, RenderTextureFormat format)
				{
				}
			}

			[Token(Token = "0x4000126")]
			[FieldOffset(Offset = "0x8")]
			private bool _useCompression;

			[Token(Token = "0x4000127")]
			[FieldOffset(Offset = "0xC")]
			private RenderTextureFormat _rawTextureFormat;

			[Token(Token = "0x4000128")]
			[FieldOffset(Offset = "0x10")]
			private Material _material;

			[Token(Token = "0x4000129")]
			[FieldOffset(Offset = "0x14")]
			private Frame[] _frameList;

			[Token(Token = "0x400012A")]
			[FieldOffset(Offset = "0x18")]
			private int _lastFrameCount;

			[Token(Token = "0x400012B")]
			[FieldOffset(Offset = "0x1C")]
			private int _History1LumaTex;

			[Token(Token = "0x400012C")]
			[FieldOffset(Offset = "0x20")]
			private int _History2LumaTex;

			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x24")]
			private int _History3LumaTex;

			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x28")]
			private int _History4LumaTex;

			[Token(Token = "0x400012F")]
			[FieldOffset(Offset = "0x2C")]
			private int _History1ChromaTex;

			[Token(Token = "0x4000130")]
			[FieldOffset(Offset = "0x30")]
			private int _History2ChromaTex;

			[Token(Token = "0x4000131")]
			[FieldOffset(Offset = "0x34")]
			private int _History3ChromaTex;

			[Token(Token = "0x4000132")]
			[FieldOffset(Offset = "0x38")]
			private int _History4ChromaTex;

			[Token(Token = "0x4000133")]
			[FieldOffset(Offset = "0x3C")]
			private int _History1Weight;

			[Token(Token = "0x4000134")]
			[FieldOffset(Offset = "0x40")]
			private int _History2Weight;

			[Token(Token = "0x4000135")]
			[FieldOffset(Offset = "0x44")]
			private int _History3Weight;

			[Token(Token = "0x4000136")]
			[FieldOffset(Offset = "0x48")]
			private int _History4Weight;

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x1D2E11C", Offset = "0x1D2E11C", VA = "0x1D2E11C")]
			public FrameBlendingFilter()
			{
			}

			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x1D2E344", Offset = "0x1D2E344", VA = "0x1D2E344")]
			public void Release()
			{
			}

			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x1D2F20C", Offset = "0x1D2F20C", VA = "0x1D2F20C")]
			public void PushFrame(RenderTexture source)
			{
			}

			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1D2EE6C", Offset = "0x1D2EE6C", VA = "0x1D2EE6C")]
			public void BlendFrames(float strength, RenderTexture source, RenderTexture destination)
			{
			}

			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x1D2F2EC", Offset = "0x1D2F2EC", VA = "0x1D2F2EC")]
			private static bool CheckSupportCompression()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x1D2F348", Offset = "0x1D2F348", VA = "0x1D2F348")]
			private static RenderTextureFormat GetPreferredRenderTextureFormat()
			{
				return default(RenderTextureFormat);
			}

			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x1D2FB48", Offset = "0x1D2FB48", VA = "0x1D2FB48")]
			private Frame GetFrameRelative(int offset)
			{
				return default(Frame);
			}

			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x1D2F434", Offset = "0x1D2F434", VA = "0x1D2F434")]
			private void FetchUniformLocations()
			{
			}
		}

		[Token(Token = "0x200003B")]
		private class ReconstructionFilter
		{
			[Token(Token = "0x400013B")]
			private const float kMaxBlurRadius = 5f;

			[Token(Token = "0x400013C")]
			[FieldOffset(Offset = "0x8")]
			private Material _material;

			[Token(Token = "0x400013D")]
			[FieldOffset(Offset = "0xC")]
			private bool _unroll;

			[Token(Token = "0x400013E")]
			[FieldOffset(Offset = "0x10")]
			private RenderTextureFormat _vectorRTFormat;

			[Token(Token = "0x400013F")]
			[FieldOffset(Offset = "0x14")]
			private RenderTextureFormat _packedRTFormat;

			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x18")]
			private int _VelocityScale;

			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x1C")]
			private int _MaxBlurRadius;

			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x20")]
			private int _TileMaxOffs;

			[Token(Token = "0x4000143")]
			[FieldOffset(Offset = "0x24")]
			private int _TileMaxLoop;

			[Token(Token = "0x4000144")]
			[FieldOffset(Offset = "0x28")]
			private int _LoopCount;

			[Token(Token = "0x4000145")]
			[FieldOffset(Offset = "0x2C")]
			private int _NeighborMaxTex;

			[Token(Token = "0x4000146")]
			[FieldOffset(Offset = "0x30")]
			private int _VelocityTex;

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x1D2DFDC", Offset = "0x1D2DFDC", VA = "0x1D2DFDC")]
			public ReconstructionFilter()
			{
			}

			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x1D2E264", Offset = "0x1D2E264", VA = "0x1D2E264")]
			public void Release()
			{
			}

			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x1D2E85C", Offset = "0x1D2E85C", VA = "0x1D2E85C")]
			public void ProcessImage(float shutterAngle, int sampleCount, RenderTexture source, RenderTexture destination)
			{
			}

			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x1D2FD44", Offset = "0x1D2FD44", VA = "0x1D2FD44")]
			private bool CheckTextureFormatSupport()
			{
				return default(bool);
			}

			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x1D2FEC0", Offset = "0x1D2FEC0", VA = "0x1D2FEC0")]
			private RenderTexture GetTemporaryRT(Texture source, int divider, RenderTextureFormat format)
			{
				return null;
			}

			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x1D2FF78", Offset = "0x1D2FF78", VA = "0x1D2FF78")]
			private void ReleaseTemporaryRT(RenderTexture rt)
			{
			}

			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x1D2FD94", Offset = "0x1D2FD94", VA = "0x1D2FD94")]
			private void FetchUniformLocations()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200003C")]
		public class Settings
		{
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451030", Offset = "0x451030")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451030", Offset = "0x451030")]
			public float shutterAngle;

			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451094", Offset = "0x451094")]
			public int sampleCount;

			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4510DC", Offset = "0x4510DC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4510DC", Offset = "0x4510DC")]
			public float frameBlending;

			[Token(Token = "0x1700003B")]
			public static Settings defaultSettings
			{
				[Token(Token = "0x60000B6")]
				[Address(RVA = "0x1D2DE84", Offset = "0x1D2DE84", VA = "0x1D2DE84")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x1D2FF84", Offset = "0x1D2FF84", VA = "0x1D2FF84")]
			public Settings()
			{
			}
		}

		[Token(Token = "0x4000121")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private Settings _settings;

		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Shader _reconstructionShader;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Shader _frameBlendingShader;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x18")]
		private ReconstructionFilter _reconstructionFilter;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x1C")]
		private FrameBlendingFilter _frameBlendingFilter;

		[Token(Token = "0x1700003A")]
		public Settings settings
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x1D2DF40", Offset = "0x1D2DF40", VA = "0x1D2DF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x1D2DF48", Offset = "0x1D2DF48", VA = "0x1D2DF48")]
			set
			{
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1D2DE60", Offset = "0x1D2DE60", VA = "0x1D2DE60")]
		public MotionBlur()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1D2DF50", Offset = "0x1D2DF50", VA = "0x1D2DF50")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1D2E218", Offset = "0x1D2E218", VA = "0x1D2E218")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1D2E458", Offset = "0x1D2E458", VA = "0x1D2E458")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1D2E524", Offset = "0x1D2E524", VA = "0x1D2E524")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x45113C", Offset = "0x45113C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x45113C", Offset = "0x45113C")]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		[Token(Token = "0x200003E")]
		public enum SSRResolution
		{
			[Token(Token = "0x4000178")]
			High = 0,
			[Token(Token = "0x4000179")]
			Low = 2
		}

		[Token(Token = "0x200003F")]
		public enum SSRReflectionBlendType
		{
			[Token(Token = "0x400017B")]
			PhysicallyBased,
			[Token(Token = "0x400017C")]
			Additive
		}

		[Serializable]
		[Token(Token = "0x2000040")]
		public struct SSRSettings
		{
			[Token(Token = "0x2000041")]
			[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x45131C", Offset = "0x45131C")]
			public class LayoutAttribute : PropertyAttribute
			{
				[Token(Token = "0x60000C1")]
				[Address(RVA = "0x1D331F8", Offset = "0x1D331F8", VA = "0x1D331F8")]
				public LayoutAttribute()
				{
				}
			}

			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x0")]
			[Layout]
			public ReflectionSettings reflectionSettings;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x20")]
			[Layout]
			public IntensitySettings intensitySettings;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x30")]
			[Layout]
			public ScreenEdgeMask screenEdgeMask;

			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x0")]
			private static readonly SSRSettings s_Default;

			[Token(Token = "0x1700003F")]
			public static SSRSettings defaultSettings
			{
				[Token(Token = "0x60000BF")]
				[Address(RVA = "0x1D3008C", Offset = "0x1D3008C", VA = "0x1D3008C")]
				get
				{
					return default(SSRSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000042")]
		public struct IntensitySettings
		{
			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451330", Offset = "0x451330")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451330", Offset = "0x451330")]
			public float reflectionMultiplier;

			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451380", Offset = "0x451380")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451380", Offset = "0x451380")]
			public float fadeDistance;

			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4513D4", Offset = "0x4513D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4513D4", Offset = "0x4513D4")]
			public float fresnelFade;

			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451424", Offset = "0x451424")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451424", Offset = "0x451424")]
			public float fresnelFadePower;
		}

		[Serializable]
		[Token(Token = "0x2000043")]
		public struct ReflectionSettings
		{
			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45147C", Offset = "0x45147C")]
			public SSRReflectionBlendType blendType;

			[Token(Token = "0x4000186")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4514B0", Offset = "0x4514B0")]
			public SSRResolution reflectionQuality;

			[Token(Token = "0x4000187")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4514E4", Offset = "0x4514E4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4514E4", Offset = "0x4514E4")]
			public float maxDistance;

			[Token(Token = "0x4000188")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45153C", Offset = "0x45153C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x45153C", Offset = "0x45153C")]
			public int iterationCount;

			[Token(Token = "0x4000189")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451594", Offset = "0x451594")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451594", Offset = "0x451594")]
			public int stepSize;

			[Token(Token = "0x400018A")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4515E8", Offset = "0x4515E8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4515E8", Offset = "0x4515E8")]
			public float widthModifier;

			[Token(Token = "0x400018B")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451640", Offset = "0x451640")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451640", Offset = "0x451640")]
			public float reflectionBlur;

			[Token(Token = "0x400018C")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451694", Offset = "0x451694")]
			public bool reflectBackfaces;
		}

		[Serializable]
		[Token(Token = "0x2000044")]
		public struct ScreenEdgeMask
		{
			[Token(Token = "0x400018D")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4516C8", Offset = "0x4516C8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4516C8", Offset = "0x4516C8")]
			public float intensity;
		}

		[Token(Token = "0x2000045")]
		private enum PassIndex
		{
			[Token(Token = "0x400018F")]
			RayTraceStep,
			[Token(Token = "0x4000190")]
			CompositeFinal,
			[Token(Token = "0x4000191")]
			Blur,
			[Token(Token = "0x4000192")]
			CompositeSSR,
			[Token(Token = "0x4000193")]
			MinMipGeneration,
			[Token(Token = "0x4000194")]
			HitPointToReflections,
			[Token(Token = "0x4000195")]
			BilateralKeyPack,
			[Token(Token = "0x4000196")]
			BlitDepthAsCSZ,
			[Token(Token = "0x4000197")]
			PoissonBlur
		}

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		public SSRSettings settings;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45120C", Offset = "0x45120C")]
		private bool highlightSuppression;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x41")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451240", Offset = "0x451240")]
		private bool traceBehindObjects;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x42")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451274", Offset = "0x451274")]
		private bool treatBackfaceHitAsMiss;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x43")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4512A8", Offset = "0x4512A8")]
		private bool bilateralUpsample;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x48")]
		private Material m_Material;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x4C")]
		private Camera m_Camera;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x50")]
		private CommandBuffer m_CommandBuffer;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x0")]
		private static int kNormalAndRoughnessTexture;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x4")]
		private static int kHitPointTexture;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x8")]
		private static int[] kReflectionTextures;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0xC")]
		private static int kFilteredReflections;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x10")]
		private static int kBlurTexture;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x14")]
		private static int kFinalReflectionTexture;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x18")]
		private static int kTempTexture;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x1C")]
		private static int kRayStepSize;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x20")]
		private static int kAdditiveReflection;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x24")]
		private static int kBilateralUpsampling;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x28")]
		private static int kTreatBackfaceHitAsMiss;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x2C")]
		private static int kAllowBackwardsRays;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x30")]
		private static int kTraceBehindObjects;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x34")]
		private static int kMaxSteps;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x38")]
		private static int kFullResolutionFiltering;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x3C")]
		private static int kHalfResolution;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x40")]
		private static int kHighlightSuppression;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x44")]
		private static int kPixelsPerMeterAtOneMeter;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x48")]
		private static int kScreenEdgeFading;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x4C")]
		private static int kReflectionBlur;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x50")]
		private static int kMaxRayTraceDistance;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x54")]
		private static int kFadeDistance;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x58")]
		private static int kLayerThickness;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x5C")]
		private static int kSSRMultiplier;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x60")]
		private static int kFresnelFade;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x64")]
		private static int kFresnelFadePower;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x68")]
		private static int kReflectionBufferSize;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x6C")]
		private static int kScreenSize;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x70")]
		private static int kInvScreenSize;

		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x74")]
		private static int kProjInfo;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x78")]
		private static int kCameraClipInfo;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x7C")]
		private static int kProjectToPixelMatrix;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x80")]
		private static int kWorldToCameraMatrix;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x84")]
		private static int kCameraToWorldMatrix;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x88")]
		private static int kAxis;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x8C")]
		private static int kCurrentMipLevel;

		[Token(Token = "0x1700003C")]
		public Shader shader
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1D30130", Offset = "0x1D30130", VA = "0x1D30130")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public Material material
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1D301EC", Offset = "0x1D301EC", VA = "0x1D301EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public Camera camera_
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1D3029C", Offset = "0x1D3029C", VA = "0x1D3029C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1D2FF8C", Offset = "0x1D2FF8C", VA = "0x1D2FF8C")]
		public ScreenSpaceReflection()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1D30354", Offset = "0x1D30354", VA = "0x1D30354")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1D30B30", Offset = "0x1D30B30", VA = "0x1D30B30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1D30BD0", Offset = "0x1D30BD0", VA = "0x1D30BD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1D30D48", Offset = "0x1D30D48", VA = "0x1D30D48")]
		public void OnPreRender()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x451718", Offset = "0x451718")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x451718", Offset = "0x451718")]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x451960", Offset = "0x451960")]
		public class SettingsGroup : Attribute
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1D399F4", Offset = "0x1D399F4", VA = "0x1D399F4")]
			public SettingsGroup()
			{
			}
		}

		[Token(Token = "0x2000048")]
		public class IndentedGroup : PropertyAttribute
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1D39998", Offset = "0x1D39998", VA = "0x1D39998")]
			public IndentedGroup()
			{
			}
		}

		[Token(Token = "0x2000049")]
		public class ChannelMixer : PropertyAttribute
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1D38EF8", Offset = "0x1D38EF8", VA = "0x1D38EF8")]
			public ChannelMixer()
			{
			}
		}

		[Token(Token = "0x200004A")]
		public class ColorWheelGroup : PropertyAttribute
		{
			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x8")]
			public int minSizePerWheel;

			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0xC")]
			public int maxSizePerWheel;

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1D39698", Offset = "0x1D39698", VA = "0x1D39698")]
			public ColorWheelGroup()
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1D396B0", Offset = "0x1D396B0", VA = "0x1D396B0")]
			public ColorWheelGroup(int minSizePerWheel, int maxSizePerWheel)
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class Curve : PropertyAttribute
		{
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x8")]
			public Color color;

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1D396EC", Offset = "0x1D396EC", VA = "0x1D396EC")]
			public Curve()
			{
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1D3972C", Offset = "0x1D3972C", VA = "0x1D3972C")]
			public Curve(float r, float g, float b, float a)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200004C")]
		public struct EyeAdaptationSettings
		{
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x451974", Offset = "0x451974")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451974", Offset = "0x451974")]
			public float middleGrey;

			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4519C0", Offset = "0x4519C0")]
			public float min;

			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4519F4", Offset = "0x4519F4")]
			public float max;

			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x451A28", Offset = "0x451A28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451A28", Offset = "0x451A28")]
			public float speed;

			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451A74", Offset = "0x451A74")]
			public bool showDebug;

			[Token(Token = "0x1700004E")]
			public static EyeAdaptationSettings defaultSettings
			{
				[Token(Token = "0x60000F0")]
				[Address(RVA = "0x1D35180", Offset = "0x1D35180", VA = "0x1D35180")]
				get
				{
					return default(EyeAdaptationSettings);
				}
			}
		}

		[Token(Token = "0x200004D")]
		public enum Tonemapper
		{
			[Token(Token = "0x40001CD")]
			ACES,
			[Token(Token = "0x40001CE")]
			Curve,
			[Token(Token = "0x40001CF")]
			Hable,
			[Token(Token = "0x40001D0")]
			HejlDawson,
			[Token(Token = "0x40001D1")]
			Photographic,
			[Token(Token = "0x40001D2")]
			Reinhard,
			[Token(Token = "0x40001D3")]
			Neutral
		}

		[Serializable]
		[Token(Token = "0x200004E")]
		public struct TonemappingSettings
		{
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451AA8", Offset = "0x451AA8")]
			public Tonemapper tonemapper;

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "MinAttribute", RVA = "0x451ADC", Offset = "0x451ADC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451ADC", Offset = "0x451ADC")]
			public float exposure;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451B28", Offset = "0x451B28")]
			public AnimationCurve curve;

			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451B5C", Offset = "0x451B5C")]
			public float neutralBlackIn;

			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451B7C", Offset = "0x451B7C")]
			public float neutralWhiteIn;

			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451B98", Offset = "0x451B98")]
			public float neutralBlackOut;

			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451BB8", Offset = "0x451BB8")]
			public float neutralWhiteOut;

			[Token(Token = "0x40001DC")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451BD4", Offset = "0x451BD4")]
			public float neutralWhiteLevel;

			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451BF4", Offset = "0x451BF4")]
			public float neutralWhiteClip;

			[Token(Token = "0x1700004F")]
			public static TonemappingSettings defaultSettings
			{
				[Token(Token = "0x60000F1")]
				[Address(RVA = "0x1D351B4", Offset = "0x1D351B4", VA = "0x1D351B4")]
				get
				{
					return default(TonemappingSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x200004F")]
		public struct LUTSettings
		{
			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001DF")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451C10", Offset = "0x451C10")]
			public Texture texture;

			[Token(Token = "0x40001E0")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451C44", Offset = "0x451C44")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451C44", Offset = "0x451C44")]
			public float contribution;

			[Token(Token = "0x17000050")]
			public static LUTSettings defaultSettings
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x1D35378", Offset = "0x1D35378", VA = "0x1D35378")]
				get
				{
					return default(LUTSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000050")]
		public struct ColorWheelsSettings
		{
			[Token(Token = "0x40001E1")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x451C94", Offset = "0x451C94")]
			public Color shadows;

			[Token(Token = "0x40001E2")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x451CA8", Offset = "0x451CA8")]
			public Color midtones;

			[Token(Token = "0x40001E3")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x451CBC", Offset = "0x451CBC")]
			public Color highlights;

			[Token(Token = "0x17000051")]
			public static ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x60000F3")]
				[Address(RVA = "0x1D3959C", Offset = "0x1D3959C", VA = "0x1D3959C")]
				get
				{
					return default(ColorWheelsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000051")]
		public struct BasicsSettings
		{
			[Token(Token = "0x40001E4")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451CD0", Offset = "0x451CD0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451CD0", Offset = "0x451CD0")]
			public float temperatureShift;

			[Token(Token = "0x40001E5")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451D20", Offset = "0x451D20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451D20", Offset = "0x451D20")]
			public float tint;

			[Token(Token = "0x40001E6")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x451D70", Offset = "0x451D70")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451D70", Offset = "0x451D70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451D70", Offset = "0x451D70")]
			public float hue;

			[Token(Token = "0x40001E7")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451DD0", Offset = "0x451DD0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451DD0", Offset = "0x451DD0")]
			public float saturation;

			[Token(Token = "0x40001E8")]
			[FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451E20", Offset = "0x451E20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451E20", Offset = "0x451E20")]
			public float vibrance;

			[Token(Token = "0x40001E9")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451E74", Offset = "0x451E74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451E74", Offset = "0x451E74")]
			public float value;

			[Token(Token = "0x40001EA")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x451EC8", Offset = "0x451EC8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451EC8", Offset = "0x451EC8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451EC8", Offset = "0x451EC8")]
			public float contrast;

			[Token(Token = "0x40001EB")]
			[FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451F28", Offset = "0x451F28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451F28", Offset = "0x451F28")]
			public float gain;

			[Token(Token = "0x40001EC")]
			[FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x451F80", Offset = "0x451F80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x451F80", Offset = "0x451F80")]
			public float gamma;

			[Token(Token = "0x17000052")]
			public static BasicsSettings defaultSettings
			{
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x1D38EC8", Offset = "0x1D38EC8", VA = "0x1D38EC8")]
				get
				{
					return default(BasicsSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000052")]
		public struct ChannelMixerSettings
		{
			[Token(Token = "0x40001ED")]
			[FieldOffset(Offset = "0x0")]
			public int currentChannel;

			[Token(Token = "0x40001EE")]
			[FieldOffset(Offset = "0x4")]
			public Vector3[] channels;

			[Token(Token = "0x17000053")]
			public static ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0x1D390C0", Offset = "0x1D390C0", VA = "0x1D390C0")]
				get
				{
					return default(ChannelMixerSettings);
				}
			}
		}

		[Serializable]
		[Token(Token = "0x2000053")]
		public struct CurvesSettings
		{
			[Token(Token = "0x40001EF")]
			[FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "Curve", RVA = "0x451FD8", Offset = "0x451FD8")]
			public AnimationCurve master;

			[Token(Token = "0x40001F0")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "Curve", RVA = "0x451FE8", Offset = "0x451FE8")]
			public AnimationCurve red;

			[Token(Token = "0x40001F1")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "Curve", RVA = "0x452024", Offset = "0x452024")]
			public AnimationCurve green;

			[Token(Token = "0x40001F2")]
			[FieldOffset(Offset = "0xC")]
			[AttributeAttribute(Name = "Curve", RVA = "0x452060", Offset = "0x452060")]
			public AnimationCurve blue;

			[Token(Token = "0x17000054")]
			public static CurvesSettings defaultSettings
			{
				[Token(Token = "0x60000F6")]
				[Address(RVA = "0x1D39638", Offset = "0x1D39638", VA = "0x1D39638")]
				get
				{
					return default(CurvesSettings);
				}
			}

			[Token(Token = "0x17000055")]
			public static AnimationCurve defaultCurve
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x1D397C0", Offset = "0x1D397C0", VA = "0x1D397C0")]
				get
				{
					return null;
				}
			}
		}

		[Token(Token = "0x2000054")]
		public enum ColorGradingPrecision
		{
			[Token(Token = "0x40001F4")]
			Normal = 0x10,
			[Token(Token = "0x40001F5")]
			High = 0x20
		}

		[Serializable]
		[Token(Token = "0x2000055")]
		public struct ColorGradingSettings
		{
			[Token(Token = "0x40001F6")]
			[FieldOffset(Offset = "0x0")]
			public bool enabled;

			[Token(Token = "0x40001F7")]
			[FieldOffset(Offset = "0x4")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x45209C", Offset = "0x45209C")]
			public ColorGradingPrecision precision;

			[Token(Token = "0x40001F8")]
			[FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x4520D0", Offset = "0x4520D0")]
			[AttributeAttribute(Name = "ColorWheelGroup", RVA = "0x4520D0", Offset = "0x4520D0")]
			public ColorWheelsSettings colorWheels;

			[Token(Token = "0x40001F9")]
			[FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x452100", Offset = "0x452100")]
			[IndentedGroup]
			public BasicsSettings basics;

			[Token(Token = "0x40001FA")]
			[FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x452130", Offset = "0x452130")]
			[ChannelMixer]
			public ChannelMixerSettings channelMixer;

			[Token(Token = "0x40001FB")]
			[FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x452160", Offset = "0x452160")]
			[IndentedGroup]
			public CurvesSettings curves;

			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x452190", Offset = "0x452190")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x452190", Offset = "0x452190")]
			public bool useDithering;

			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x75")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x4521D8", Offset = "0x4521D8")]
			public bool showDebug;

			[Token(Token = "0x17000056")]
			public static ColorGradingSettings defaultSettings
			{
				[Token(Token = "0x60000F8")]
				[Address(RVA = "0x1D35230", Offset = "0x1D35230", VA = "0x1D35230")]
				get
				{
					return default(ColorGradingSettings);
				}
			}

			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1D3966C", Offset = "0x1D3966C", VA = "0x1D3966C")]
			internal void Reset()
			{
			}
		}

		[Token(Token = "0x2000056")]
		private enum Pass
		{
			[Token(Token = "0x40001FF")]
			LutGen,
			[Token(Token = "0x4000200")]
			AdaptationLog,
			[Token(Token = "0x4000201")]
			AdaptationExpBlend,
			[Token(Token = "0x4000202")]
			AdaptationExp,
			[Token(Token = "0x4000203")]
			TonemappingOff,
			[Token(Token = "0x4000204")]
			TonemappingACES,
			[Token(Token = "0x4000205")]
			TonemappingCurve,
			[Token(Token = "0x4000206")]
			TonemappingHable,
			[Token(Token = "0x4000207")]
			TonemappingHejlDawson,
			[Token(Token = "0x4000208")]
			TonemappingPhotographic,
			[Token(Token = "0x4000209")]
			TonemappingReinhard,
			[Token(Token = "0x400020A")]
			TonemappingNeutral,
			[Token(Token = "0x400020B")]
			AdaptationDebug
		}

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		[SettingsGroup]
		private EyeAdaptationSettings m_EyeAdaptation;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[SettingsGroup]
		private TonemappingSettings m_Tonemapping;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[SettingsGroup]
		private ColorGradingSettings m_ColorGrading;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[SettingsGroup]
		private LUTSettings m_Lut;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xD0")]
		private Texture2D m_IdentityLut;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xD4")]
		private RenderTexture m_InternalLut;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xD8")]
		private Texture2D m_CurveTexture;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xDC")]
		private Texture2D m_TonemapperCurve;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xE0")]
		private float m_TonemapperCurveRange;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private Shader m_Shader;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xE8")]
		private Material m_Material;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4518A8", Offset = "0x4518A8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4518A8", Offset = "0x4518A8")]
		private bool <validRenderTextureFormat>k__BackingField;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4518DC", Offset = "0x4518DC")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x4518DC", Offset = "0x4518DC")]
		private bool <validUserLutSize>k__BackingField;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xEE")]
		private bool m_Dirty;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xEF")]
		private bool m_TonemapperDirty;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture m_SmallAdaptiveRt;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xF4")]
		private RenderTextureFormat m_AdaptiveRtFormat;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xF8")]
		private int m_AdaptationSpeed;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xFC")]
		private int m_MiddleGrey;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x100")]
		private int m_AdaptationMin;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x104")]
		private int m_AdaptationMax;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x108")]
		private int m_LumTex;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x10C")]
		private int m_ToneCurveRange;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x110")]
		private int m_ToneCurve;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x114")]
		private int m_Exposure;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x118")]
		private int m_NeutralTonemapperParams1;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x11C")]
		private int m_NeutralTonemapperParams2;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x120")]
		private int m_WhiteBalance;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x124")]
		private int m_Lift;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x128")]
		private int m_Gamma;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x12C")]
		private int m_Gain;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x130")]
		private int m_ContrastGainGamma;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x134")]
		private int m_Vibrance;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x138")]
		private int m_HSV;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x13C")]
		private int m_ChannelMixerRed;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x140")]
		private int m_ChannelMixerGreen;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x144")]
		private int m_ChannelMixerBlue;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x148")]
		private int m_CurveTex;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x14C")]
		private int m_InternalLutTex;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x150")]
		private int m_InternalLutParams;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x154")]
		private int m_UserLutTex;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x158")]
		private int m_UserLutParams;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x15C")]
		private RenderTexture[] m_AdaptRts;

		[Token(Token = "0x17000040")]
		public EyeAdaptationSettings eyeAdaptation
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x1D353AC", Offset = "0x1D353AC", VA = "0x1D353AC")]
			get
			{
				return default(EyeAdaptationSettings);
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x1D353C0", Offset = "0x1D353C0", VA = "0x1D353C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public TonemappingSettings tonemapping
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x1D353D8", Offset = "0x1D353D8", VA = "0x1D353D8")]
			get
			{
				return default(TonemappingSettings);
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x1D353F4", Offset = "0x1D353F4", VA = "0x1D353F4")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public ColorGradingSettings colorGrading
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x1D35448", Offset = "0x1D35448", VA = "0x1D35448")]
			get
			{
				return default(ColorGradingSettings);
			}
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x1D35460", Offset = "0x1D35460", VA = "0x1D35460")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public LUTSettings lut
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x1D354B0", Offset = "0x1D354B0", VA = "0x1D354B0")]
			get
			{
				return default(LUTSettings);
			}
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x1D354C0", Offset = "0x1D354C0", VA = "0x1D354C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		private Texture2D identityLut
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x1D354CC", Offset = "0x1D354CC", VA = "0x1D354CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private RenderTexture internalLutRt
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1D35928", Offset = "0x1D35928", VA = "0x1D35928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private Texture2D curveTexture
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1D35B4C", Offset = "0x1D35B4C", VA = "0x1D35B4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private Texture2D tonemapperCurve
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1D35D08", Offset = "0x1D35D08", VA = "0x1D35D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public Shader shader
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1D35EFC", Offset = "0x1D35EFC", VA = "0x1D35EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public Material material
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1D35FB8", Offset = "0x1D35FB8", VA = "0x1D35FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public bool isGammaColorSpace
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1D36068", Offset = "0x1D36068", VA = "0x1D36068")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public int lutSize
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1D355E4", Offset = "0x1D355E4", VA = "0x1D355E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool validRenderTextureFormat
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1D36090", Offset = "0x1D36090", VA = "0x1D36090")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x451910", Offset = "0x451910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1D36098", Offset = "0x1D36098", VA = "0x1D36098")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x451920", Offset = "0x451920")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public bool validUserLutSize
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1D360A0", Offset = "0x1D360A0", VA = "0x1D360A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x451930", Offset = "0x451930")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1D360A8", Offset = "0x1D360A8", VA = "0x1D360A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x451940", Offset = "0x451940")]
			private set
			{
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1D350B8", Offset = "0x1D350B8", VA = "0x1D350B8")]
		public TonemappingColorGrading()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1D354A4", Offset = "0x1D354A4", VA = "0x1D354A4")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1D3543C", Offset = "0x1D3543C", VA = "0x1D3543C")]
		public void SetTonemapperDirty()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1D360B0", Offset = "0x1D360B0", VA = "0x1D360B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1D3641C", Offset = "0x1D3641C", VA = "0x1D3641C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1D36474", Offset = "0x1D36474", VA = "0x1D36474")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1D36830", Offset = "0x1D36830", VA = "0x1D36830")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1D355EC", Offset = "0x1D355EC", VA = "0x1D355EC")]
		private static Texture2D GenerateIdentityLut(int dim)
		{
			return null;
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1D3683C", Offset = "0x1D3683C", VA = "0x1D3683C")]
		private float StandardIlluminantY(float x)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1D36874", Offset = "0x1D36874", VA = "0x1D36874")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1D36944", Offset = "0x1D36944", VA = "0x1D36944")]
		private Vector3 GetWhiteBalance()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1D36A60", Offset = "0x1D36A60", VA = "0x1D36A60")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1D36B84", Offset = "0x1D36B84", VA = "0x1D36B84")]
		private void GenerateLiftGammaGain(out Color lift, out Color gamma, out Color gain)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1D36E1C", Offset = "0x1D36E1C", VA = "0x1D36E1C")]
		private void GenCurveTexture()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1D37108", Offset = "0x1D37108", VA = "0x1D37108")]
		private bool CheckUserLut()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1D3720C", Offset = "0x1D3720C", VA = "0x1D3720C")]
		private bool CheckSmallAdaptiveRt()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1D37338", Offset = "0x1D37338", VA = "0x1D37338")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1D375D0", Offset = "0x1D375D0", VA = "0x1D375D0")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1D38CFC", Offset = "0x1D38CFC", VA = "0x1D38CFC")]
		public Texture2D BakeLUT()
		{
			return null;
		}
	}
}
[Token(Token = "0x2000057")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x45220C", Offset = "0x45220C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x45220C", Offset = "0x45220C")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0xC")]
	public Shader shader;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x10")]
	private Material m_Material;

	[Token(Token = "0x17000057")]
	protected Material material
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1D23CB4", Offset = "0x1D23CB4", VA = "0x1D23CB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1D23BD0", Offset = "0x1D23BD0", VA = "0x1D23BD0")]
	public ImageEffectBase()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1D23BD8", Offset = "0x1D23BD8", VA = "0x1D23BD8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1D23D98", Offset = "0x1D23D98", VA = "0x1D23D98", Slot = "5")]
	protected virtual void OnDisable()
	{
	}
}
[Token(Token = "0x2000058")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x4522AC", Offset = "0x4522AC")]
public class ImageEffects
{
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1D23E6C", Offset = "0x1D23E6C", VA = "0x1D23E6C")]
	public ImageEffects()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1D23E74", Offset = "0x1D23E74", VA = "0x1D23E74")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1D24234", Offset = "0x1D24234", VA = "0x1D24234")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x4522E0", Offset = "0x4522E0")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1D242C4", Offset = "0x1D242C4", VA = "0x1D242C4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x452314", Offset = "0x452314")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}
}
