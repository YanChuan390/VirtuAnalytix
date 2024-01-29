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
using NatMic.Recorders;
using NatSuite.Devices;
using NatSuite.Examples.Components;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class SmoothRandom
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static FractalNoise s_Noise;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE38D0C", Offset = "0xE38D0C", VA = "0xE38D0C")]
	public static Vector3 GetVector3(float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE38ED4", Offset = "0xE38ED4", VA = "0xE38ED4")]
	public static float Get(float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE38E14", Offset = "0xE38E14", VA = "0xE38E14")]
	private static FractalNoise Get()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xE38F48", Offset = "0xE38F48", VA = "0xE38F48")]
	public SmoothRandom()
	{
	}
}
[Token(Token = "0x2000003")]
public class Perlin
{
	[Token(Token = "0x4000002")]
	private const int B = 256;

	[Token(Token = "0x4000003")]
	private const int BM = 255;

	[Token(Token = "0x4000004")]
	private const int N = 4096;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private int[] p;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float[,] g3;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private float[,] g2;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float[] g1;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE34964", Offset = "0xE34964", VA = "0xE34964")]
	private float s_curve(float t)
	{
		return default(float);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE34984", Offset = "0xE34984", VA = "0xE34984")]
	private float lerp(float t, float a, float b)
	{
		return default(float);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xE349A0", Offset = "0xE349A0", VA = "0xE349A0")]
	private void setup(float value, out int b0, out int b1, out float r0, out float r1)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE34A14", Offset = "0xE34A14", VA = "0xE34A14")]
	private float at2(float rx, float ry, float x, float y)
	{
		return default(float);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE34A34", Offset = "0xE34A34", VA = "0xE34A34")]
	private float at3(float rx, float ry, float rz, float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE34A60", Offset = "0xE34A60", VA = "0xE34A60")]
	public float Noise(float arg)
	{
		return default(float);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xE2D2F0", Offset = "0xE2D2F0", VA = "0xE2D2F0")]
	public float Noise(float x, float y)
	{
		return default(float);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE34BB0", Offset = "0xE34BB0", VA = "0xE34BB0")]
	public float Noise(float x, float y, float z)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE35790", Offset = "0xE35790", VA = "0xE35790")]
	private void normalize2(ref float x, ref float y)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE35850", Offset = "0xE35850", VA = "0xE35850")]
	private void normalize3(ref float x, ref float y, ref float z)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE2C974", Offset = "0xE2C974", VA = "0xE2C974")]
	public Perlin()
	{
	}
}
[Token(Token = "0x2000004")]
public class FractalNoise
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private Perlin m_Noise;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private float[] m_Exponent;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int m_IntOctaves;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private float m_Octaves;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float m_Lacunarity;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xE2C790", Offset = "0xE2C790", VA = "0xE2C790")]
	public FractalNoise(float inH, float inLacunarity, float inOctaves)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE2C7B0", Offset = "0xE2C7B0", VA = "0xE2C7B0")]
	public FractalNoise(float inH, float inLacunarity, float inOctaves, Perlin noise)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE2D130", Offset = "0xE2D130", VA = "0xE2D130")]
	public float HybridMultifractal(float x, float y, float offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE2D80C", Offset = "0xE2D80C", VA = "0xE2D80C")]
	public float RidgedMultifractal(float x, float y, float offset, float gain)
	{
		return default(float);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE2D9B8", Offset = "0xE2D9B8", VA = "0xE2D9B8")]
	public float BrownianMotion(float x, float y)
	{
		return default(float);
	}
}
namespace SleekRender
{
	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x222698", Offset = "0x222698")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x222698", Offset = "0x222698")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class SleekRenderPostProcess : MonoBehaviour
	{
		[Token(Token = "0x200001C")]
		public static class Uniforms
		{
			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly int _LuminanceConst;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static readonly int _BloomIntencity;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static readonly int _BloomTint;

			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public static readonly int _MainTex;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static readonly int _BloomTex;

			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public static readonly int _PreComposeTex;

			[Token(Token = "0x400008B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static readonly int _TexelSize;

			[Token(Token = "0x400008C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public static readonly int _Colorize;

			[Token(Token = "0x400008D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static readonly int _VignetteShape;

			[Token(Token = "0x400008E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public static readonly int _VignetteColor;

			[Token(Token = "0x400008F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static readonly int _BrightnessContrast;
		}

		[Token(Token = "0x200001D")]
		private static class Keywords
		{
			[Token(Token = "0x4000090")]
			public const string COLORIZE_ON = "COLORIZE_ON";

			[Token(Token = "0x4000091")]
			public const string BLOOM_ON = "BLOOM_ON";

			[Token(Token = "0x4000092")]
			public const string VIGNETTE_ON = "VIGNETTE_ON";

			[Token(Token = "0x4000093")]
			public const string BRIGHTNESS_CONTRAST_ON = "BRIGHTNESS_CONTRAST_ON";
		}

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public SleekRenderSettings settings;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float androidFirstDownscaleFactor;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int androidPyramidIteration;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float androidMultiplier;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float firstDownscaleFactor;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int pyramidIteration;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float bloomMultiplier;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _jellyDownsampleMaterial;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Material _downsampleMaterial;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _horizontalBlurMaterial;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Material _verticalBlurMaterial;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material _preComposeMaterial;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Material _composeMaterial;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture _downsampledBrightpassTexture;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private List<RenderTexture> _jellyBloomPyramid;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture _brightPassBlurTexture;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private RenderTexture _horizontalBlurTexture;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture _verticalBlurTexture;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private RenderTexture _preComposeTexture;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _lastUseJelly;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _lastJellyIter;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _lastJellyDownsampleSize;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Camera _mainCamera;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh _fullscreenQuadMesh;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int _currentCameraPixelWidth;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _currentCameraPixelHeight;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private bool _isColorizeAlreadyEnabled;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
		private bool _isBloomAlreadyEnabled;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x76")]
		private bool _isVignetteAlreadyEnabled;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x77")]
		private bool _isAlreadyPreservingAspectRatio;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool _isContrastAndBrightnessAlreadyEnabled;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Texture2D dbTexture;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float dbTextureProgress;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 jellyfishPositionLeft;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 jellyfishPositionRight;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Texture2D noise3DTex;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RenderTexture _rt;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private RenderTexture _rtTarget;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Texture2D dbTextureSent;

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xE35928", Offset = "0xE35928", VA = "0xE35928")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xE36604", Offset = "0xE36604", VA = "0xE36604")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xE36734", Offset = "0xE36734", VA = "0xE36734")]
		private void OnRenderImage(RenderTexture source, RenderTexture target)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xE36760", Offset = "0xE36760", VA = "0xE36760")]
		private void ApplyPostProcess(RenderTexture source)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE36E8C", Offset = "0xE36E8C", VA = "0xE36E8C")]
		private void JellyDownsamplePyramid(RenderTexture source)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE374F8", Offset = "0xE374F8", VA = "0xE374F8")]
		private void Downsample(RenderTexture source)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE37244", Offset = "0xE37244", VA = "0xE37244")]
		private void JellyBloomUpsample()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xE37684", Offset = "0xE37684", VA = "0xE37684")]
		private void Bloom(bool isBloomEnabled)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE37734", Offset = "0xE37734", VA = "0xE37734")]
		private void Precompose(bool isBloomEnabled)
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xE367E4", Offset = "0xE367E4", VA = "0xE367E4")]
		private void Compose(RenderTexture source, RenderTexture target)
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xE35A48", Offset = "0xE35A48", VA = "0xE35A48")]
		private void CreateResources()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xE37BC8", Offset = "0xE37BC8", VA = "0xE37BC8")]
		private RenderTexture CreateTransientRenderTexture(string textureName, int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xE38224", Offset = "0xE38224", VA = "0xE38224")]
		private RenderTexture CreateMainRenderTexture(int width, int height)
		{
			return null;
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xE36608", Offset = "0xE36608", VA = "0xE36608")]
		private void ReleaseResources()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xE38348", Offset = "0xE38348", VA = "0xE38348")]
		private void DestroyImmediateIfNotNull(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xE376F4", Offset = "0xE376F4", VA = "0xE376F4")]
		public void Blit(Texture source, RenderTexture destination, Material material, bool clear = true, int materialPass = 0)
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xE383FC", Offset = "0xE383FC", VA = "0xE383FC")]
		private static void SetActiveRenderTextureAndClear(RenderTexture destination, bool clear = true)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xE38478", Offset = "0xE38478", VA = "0xE38478")]
		private void DrawFullscreenQuad(Texture source, Material material, int materialPass = 0)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xE38648", Offset = "0xE38648", VA = "0xE38648")]
		private void CheckScreenSizeAndRecreateTexturesIfNeeded(Camera mainCamera)
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xE389BC", Offset = "0xE389BC", VA = "0xE389BC")]
		public void ReloadResources()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xE37B8C", Offset = "0xE37B8C", VA = "0xE37B8C")]
		private float GetCurrentAspect(Camera mainCamera)
		{
			return default(float);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xE35978", Offset = "0xE35978", VA = "0xE35978")]
		private void CreateDefaultSettingsIfNoneLinked()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xE37CC4", Offset = "0xE37CC4", VA = "0xE37CC4")]
		private Mesh CreateScreenSpaceQuadMesh()
		{
			return null;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xE389D8", Offset = "0xE389D8", VA = "0xE389D8")]
		public SleekRenderPostProcess()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x222750", Offset = "0x222750")]
	public class SleekRenderSettings : ScriptableObject
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x222968", Offset = "0x222968")]
		public bool bloomExpanded;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
		public bool bloomEnabled;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float bloomThreshold;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float bloomIntensity;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color bloomTint;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool preserveAspectRatio;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int bloomTextureWidth;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int bloomTextureHeight;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useJellyBloom;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int jellyBloomPyramidIteration;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float jellyBloomPyramidIterationDownsampling;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float jellyBloomPyramidFirstDownsampling;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LumaVectorType bloomLumaCalculationType;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 bloomLumaVector;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x22299C", Offset = "0x22299C")]
		public bool colorizeExpanded;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool colorizeEnabled;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Color32 colorize;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x2229D0", Offset = "0x2229D0")]
		public bool vignetteExpanded;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool vignetteEnabled;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float vignetteBeginRadius;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float vignetteExpandRadius;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color vignetteColor;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x222A04", Offset = "0x222A04")]
		public bool brightnessContrastExpanded;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool brightnessContrastEnabled;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float contrast;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float brightness;

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xE38BE4", Offset = "0xE38BE4", VA = "0xE38BE4")]
		public SleekRenderSettings()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public enum LumaVectorType
	{
		[Token(Token = "0x4000050")]
		Uniform,
		[Token(Token = "0x4000051")]
		sRGB,
		[Token(Token = "0x4000052")]
		Custom
	}
}
namespace NatSuite.Examples
{
	[Token(Token = "0x2000008")]
	public class HotMic : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222918", Offset = "0x222918")]
		private struct <Start>d__2 : IAsyncStateMachine
		{
			[Token(Token = "0x4000094")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000095")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x4000096")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public HotMic <>4__this;

			[Token(Token = "0x4000097")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE328C0", Offset = "0xE328C0", VA = "0xE328C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600008F")]
			[Address(RVA = "0xE32C38", Offset = "0xE32C38", VA = "0xE32C38", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private AudioDevice device;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private NatSuite.Examples.Components.ClipRecorder recorder;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xE3251C", Offset = "0xE3251C", VA = "0xE3251C")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x222AD4", Offset = "0x222AD4")]
		private void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xE325E0", Offset = "0xE325E0", VA = "0xE325E0")]
		public void StartRecording()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xE327E0", Offset = "0xE327E0", VA = "0xE327E0")]
		public void StopRecording()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE328B8", Offset = "0xE328B8", VA = "0xE328B8")]
		public HotMic()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class MiniCam : MonoBehaviour
	{
		[StructLayout(3)]
		[Token(Token = "0x200001F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222928", Offset = "0x222928")]
		private struct <Start>d__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MiniCam <>4__this;

			[Token(Token = "0x400009B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private CameraDevice <device>5__2;

			[Token(Token = "0x400009C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<bool> <>u__1;

			[Token(Token = "0x400009D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter<Texture2D> <>u__2;

			[Token(Token = "0x6000090")]
			[Address(RVA = "0xE33C98", Offset = "0xE33C98", VA = "0xE33C98", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000091")]
			[Address(RVA = "0xE34474", Offset = "0xE34474", VA = "0xE34474", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000020")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222938", Offset = "0x222938")]
		private struct <CapturePhoto>d__8 : IAsyncStateMachine
		{
			[Token(Token = "0x400009E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MiniCam <>4__this;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Texture2D <photoTexture>5__2;

			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private TaskAwaiter <>u__2;

			[Token(Token = "0x6000092")]
			[Address(RVA = "0xE33588", Offset = "0xE33588", VA = "0xE33588", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0xE33C8C", Offset = "0xE33C8C", VA = "0xE33C8C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222948", Offset = "0x222948")]
		private struct <SwitchCamera>d__9 : IAsyncStateMachine
		{
			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public MiniCam <>4__this;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Token(Token = "0x6000094")]
			[Address(RVA = "0xE34480", Offset = "0xE34480", VA = "0xE34480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000095")]
			[Address(RVA = "0xE34958", Offset = "0xE34958", VA = "0xE34958", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x222A38", Offset = "0x222A38")]
		public RawImage rawImage;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AspectRatioFitter aspectFitter;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x222A6C", Offset = "0x222A6C")]
		public CanvasGroup buttons;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Image flashIcon;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Image switchIcon;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MediaDeviceQuery query;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Texture2D previewTexture;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE32C44", Offset = "0xE32C44", VA = "0xE32C44")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x222B44", Offset = "0x222B44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE32D10", Offset = "0xE32D10", VA = "0xE32D10")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x222BB4", Offset = "0x222BB4")]
		public void CapturePhoto()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE32DDC", Offset = "0xE32DDC", VA = "0xE32DDC")]
		[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x222C24", Offset = "0x222C24")]
		public void SwitchCamera()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE32EA0", Offset = "0xE32EA0", VA = "0xE32EA0")]
		public void FocusCamera(BaseEventData e)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE33284", Offset = "0xE33284", VA = "0xE33284")]
		public void ToggleFlashMode()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE333F4", Offset = "0xE333F4", VA = "0xE333F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE33580", Offset = "0xE33580", VA = "0xE33580")]
		public MiniCam()
		{
		}
	}
}
namespace NatSuite.Examples.Components
{
	[Token(Token = "0x200000A")]
	public sealed class ClipRecorder
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly int sampleRate;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly int channelCount;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly MemoryStream audioBuffer;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE31DA8", Offset = "0xE31DA8", VA = "0xE31DA8")]
		public ClipRecorder(int sampleRate, int channelCount)
		{
		}

		[MethodImpl(32)]
		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE31E2C", Offset = "0xE31E2C", VA = "0xE31E2C")]
		public void CommitSamples(float[] sampleBuffer, long timestamp = 0L)
		{
		}

		[MethodImpl(32)]
		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE31F10", Offset = "0xE31F10", VA = "0xE31F10")]
		public AudioClip FinishWriting()
		{
			return null;
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x222784", Offset = "0x222784")]
	public class MicrophoneButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x222958", Offset = "0x222958")]
		private sealed class <Countdown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int <>1__state;

			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private object <>2__current;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MicrophoneButton <>4__this;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <startTime>5__2;

			[Token(Token = "0x17000013")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0xE32494", Offset = "0xE32494", VA = "0xE32494", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000014")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0xE32514", Offset = "0xE32514", VA = "0xE32514", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0xE32298", Offset = "0xE32298", VA = "0xE32298")]
			[DebuggerHidden]
			public <Countdown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000097")]
			[Address(RVA = "0xE322C0", Offset = "0xE322C0", VA = "0xE322C0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0xE322C4", Offset = "0xE322C4", VA = "0xE322C4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0xE3249C", Offset = "0xE3249C", VA = "0xE3249C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Image button;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image countdown;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UnityEvent onTouchDown;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent onTouchUp;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool pressed;

		[Token(Token = "0x4000064")]
		private const float MaxRecordingTime = 10f;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE320E0", Offset = "0xE320E0", VA = "0xE320E0")]
		private void Start()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xE320E4", Offset = "0xE320E4", VA = "0xE320E4")]
		private void Reset()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xE321E8", Offset = "0xE321E8", VA = "0xE321E8", Slot = "4")]
		private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xE3228C", Offset = "0xE3228C", VA = "0xE3228C", Slot = "5")]
		private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xE3220C", Offset = "0xE3220C", VA = "0xE3220C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x222C94", Offset = "0x222C94")]
		private IEnumerator Countdown()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xE322B8", Offset = "0xE322B8", VA = "0xE322B8")]
		public MicrophoneButton()
		{
		}
	}
}
namespace NatMic
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "DocAttribute", RVA = "0x2227F4", Offset = "0x2227F4")]
	public abstract class AudioDevice : IAudioDevice, IEquatable<AudioDevice>
	{
		[Token(Token = "0x17000001")]
		public static long CurrentTimestamp
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xE2E09C", Offset = "0xE2E09C", VA = "0xE2E09C")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x17000002")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x2231B8", Offset = "0x2231B8")]
		public abstract string Name
		{
			[Token(Token = "0x6000044")]
			get;
		}

		[Token(Token = "0x17000003")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x2231EC", Offset = "0x2231EC")]
		public abstract string UniqueID
		{
			[Token(Token = "0x6000045")]
			get;
		}

		[Token(Token = "0x17000004")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x223220", Offset = "0x223220")]
		public abstract bool EchoCancellation
		{
			[Token(Token = "0x6000046")]
			get;
		}

		[Token(Token = "0x17000005")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x223254", Offset = "0x223254")]
		public abstract bool IsRecording
		{
			[Token(Token = "0x6000047")]
			get;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xE2DB5C", Offset = "0xE2DB5C", VA = "0xE2DB5C")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222D04", Offset = "0x222D04")]
		public static AudioDevice[] GetDevices()
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222D38", Offset = "0x222D38")]
		public abstract void StartRecording(int requestedSampleRate, int requestedChannelCount, IAudioProcessor processor);

		[Token(Token = "0x6000049")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222D6C", Offset = "0x222D6C")]
		public abstract void StopRecording();

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE2E20C", Offset = "0xE2E20C", VA = "0xE2E20C", Slot = "7")]
		public bool Equals(AudioDevice other)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xE2E268", Offset = "0xE2E268", VA = "0xE2E268", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE2E314", Offset = "0xE2E314", VA = "0xE2E314")]
		protected AudioDevice()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public interface IAudioDevice
	{
		[Token(Token = "0x17000006")]
		bool IsRecording
		{
			[Token(Token = "0x600004D")]
			get;
		}

		[Token(Token = "0x600004E")]
		void StartRecording(int requestedSampleRate, int requestedChannelCount, IAudioProcessor processor);

		[Token(Token = "0x600004F")]
		void StopRecording();
	}
	[Token(Token = "0x200000E")]
	public interface IAudioProcessor
	{
		[Token(Token = "0x6000050")]
		void OnSampleBuffer(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp);
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "DocAttribute", RVA = "0x222828", Offset = "0x222828")]
	public sealed class MixerDevice : IAudioDevice
	{
		[Token(Token = "0x2000023")]
		private class PassThroughProcessor : IAudioProcessor
		{
			[Token(Token = "0x40000AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly Action<float[], int, int, long> handler;

			[Token(Token = "0x600009C")]
			[Address(RVA = "0xE302EC", Offset = "0xE302EC", VA = "0xE302EC")]
			public PassThroughProcessor(Action<float[], int, int, long> handler)
			{
			}

			[Token(Token = "0x600009D")]
			[Address(RVA = "0xE30CE0", Offset = "0xE30CE0", VA = "0xE30CE0", Slot = "4")]
			private void NatMic.IAudioProcessor.OnSampleBuffer(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp)
			{
			}
		}

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IAudioDevice sourceA;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly IAudioDevice sourceB;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IAudioProcessor processor;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private List<float> sampleBufferA;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<float> sampleBufferB;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private long initialTimestampA;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private long initialTimestampB;

		[Token(Token = "0x17000007")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x223288", Offset = "0x223288")]
		public bool IsRecording
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0xE30028", Offset = "0xE30028", VA = "0xE30028", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xE30000", Offset = "0xE30000", VA = "0xE30000")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222DA0", Offset = "0x222DA0")]
		public MixerDevice(IAudioDevice sourceA, IAudioDevice sourceB)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE30048", Offset = "0xE30048", VA = "0xE30048", Slot = "5")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222DD4", Offset = "0x222DD4")]
		public void StartRecording(int requestedSampleRate, int requestedChannelCount, IAudioProcessor processor)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE3030C", Offset = "0xE3030C", VA = "0xE3030C", Slot = "6")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222E20", Offset = "0x222E20")]
		public void StopRecording()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE30480", Offset = "0xE30480", VA = "0xE30480")]
		private void OnSampleBufferA(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE30B2C", Offset = "0xE30B2C", VA = "0xE30B2C")]
		private void OnSampleBufferB(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE309D0", Offset = "0xE309D0", VA = "0xE309D0")]
		private static void Mix(float[] srcA, float[] srcB, float[] dst)
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "DocAttribute", RVA = "0x22285C", Offset = "0x22285C")]
	public sealed class VirtualDevice : IAudioDevice, IDisposable
	{
		[Token(Token = "0x2000024")]
		private class VirtualDeviceAttachment : MonoBehaviour
		{
			[Token(Token = "0x40000AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Action<float[], int> handler;

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xE31D24", Offset = "0xE31D24", VA = "0xE31D24")]
			private void OnAudioFilterRead(float[] data, int channels)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE31DA0", Offset = "0xE31DA0", VA = "0xE31DA0")]
			public VirtualDeviceAttachment()
			{
			}
		}

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly VirtualDeviceAttachment attachment;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private readonly int sampleRate;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IAudioProcessor processor;

		[Token(Token = "0x17000008")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x2232BC", Offset = "0x2232BC")]
		public bool IsRecording
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xE31A18", Offset = "0xE31A18", VA = "0xE31A18", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE31894", Offset = "0xE31894", VA = "0xE31894")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222E54", Offset = "0x222E54")]
		public VirtualDevice(AudioSource audioSource)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE31994", Offset = "0xE31994", VA = "0xE31994")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222E88", Offset = "0x222E88")]
		public VirtualDevice(AudioListener audioListener)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE31998", Offset = "0xE31998", VA = "0xE31998", Slot = "7")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222EBC", Offset = "0x222EBC")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xE31A38", Offset = "0xE31A38", VA = "0xE31A38", Slot = "5")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222EF0", Offset = "0x222EF0")]
		public void StartRecording(int requestedSampleRate, int requestedChannelCount, IAudioProcessor processor)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE31A54", Offset = "0xE31A54", VA = "0xE31A54", Slot = "6")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222F24", Offset = "0x222F24")]
		public void StopRecording()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE31898", Offset = "0xE31898", VA = "0xE31898")]
		private VirtualDevice(Component component)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE31A70", Offset = "0xE31A70", VA = "0xE31A70")]
		private void OnSampleBuffer(float[] data, int channels)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE31C88", Offset = "0xE31C88", VA = "0xE31C88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace NatMic.Recorders
{
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "DocAttribute", RVA = "0x222890", Offset = "0x222890")]
	public sealed class ClipRecorder : IAudioRecorder, IAudioProcessor, IDisposable
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly Action<AudioClip> callback;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private MemoryStream audioBuffer;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int sampleRate;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int channelCount;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE30D80", Offset = "0xE30D80", VA = "0xE30D80")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222F58", Offset = "0x222F58")]
		public ClipRecorder(Action<AudioClip> callback)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE30DFC", Offset = "0xE30DFC", VA = "0xE30DFC", Slot = "5")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222F8C", Offset = "0x222F8C")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE3103C", Offset = "0xE3103C", VA = "0xE3103C", Slot = "4")]
		private void NatMic.IAudioProcessor.OnSampleBuffer(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp)
		{
		}
	}
	[Token(Token = "0x2000012")]
	public interface IAudioRecorder : IAudioProcessor, IDisposable
	{
	}
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "DocAttribute", RVA = "0x2228C4", Offset = "0x2228C4")]
	public sealed class WAVRecorder : IAudioRecorder, IAudioProcessor, IDisposable
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222AA0", Offset = "0x222AA0")]
		public readonly string FilePath;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private int sampleRate;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int channelCount;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private FileStream outputStream;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int totalSamples;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE2E758", Offset = "0xE2E758", VA = "0xE2E758")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222FC0", Offset = "0x222FC0")]
		public WAVRecorder(string filePath)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE2E778", Offset = "0xE2E778", VA = "0xE2E778", Slot = "5")]
		[AttributeAttribute(Name = "DocAttribute", RVA = "0x222FF4", Offset = "0x222FF4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE31644", Offset = "0xE31644", VA = "0xE31644", Slot = "4")]
		private void NatMic.IAudioProcessor.OnSampleBuffer(float[] sampleBuffer, int sampleRate, int channelCount, long timestamp)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE31130", Offset = "0xE31130", VA = "0xE31130")]
		private void WriteHeader()
		{
		}
	}
}
namespace NatMic.Internal
{
	[Token(Token = "0x2000014")]
	public sealed class AudioDeviceAndroid : AudioDevice
	{
		[Token(Token = "0x2000025")]
		private class SampleBufferDelegate : AndroidJavaProxy
		{
			[Token(Token = "0x40000AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly AudioDeviceAndroid device;

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xE2EE68", Offset = "0xE2EE68", VA = "0xE2EE68")]
			public SampleBufferDelegate(AudioDeviceAndroid device)
			{
			}

			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xE2F09C", Offset = "0xE2F09C", VA = "0xE2F09C")]
			[Preserve]
			private void onSampleBuffer(AndroidJavaObject frame)
			{
			}
		}

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly AndroidJavaObject device;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private IAudioProcessor processor;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass AudioDevice;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static AndroidJavaClass System;

		[Token(Token = "0x17000009")]
		public new static long CurrentTimestamp
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xE2E0C8", Offset = "0xE2E0C8", VA = "0xE2E0C8")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000A")]
		public override string Name
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xE2E7E4", Offset = "0xE2E7E4", VA = "0xE2E7E4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		public override string UniqueID
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xE2E90C", Offset = "0xE2E90C", VA = "0xE2E90C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		public override bool EchoCancellation
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xE2EA34", Offset = "0xE2EA34", VA = "0xE2EA34", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public override bool IsRecording
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xE2EB5C", Offset = "0xE2EB5C", VA = "0xE2EB5C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE2DBF0", Offset = "0xE2DBF0", VA = "0xE2DBF0")]
		public new static AudioDeviceAndroid[] GetDevices()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE2EC84", Offset = "0xE2EC84", VA = "0xE2EC84", Slot = "12")]
		public override void StartRecording(int sampleRate, int channelCount, IAudioProcessor processor)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE2EEFC", Offset = "0xE2EEFC", VA = "0xE2EEFC", Slot = "13")]
		public override void StopRecording()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE2E7C4", Offset = "0xE2E7C4", VA = "0xE2E7C4")]
		private AudioDeviceAndroid(AndroidJavaObject device)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE2F024", Offset = "0xE2F024", VA = "0xE2F024", Slot = "1")]
		~AudioDeviceAndroid()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class AudioDeviceBridge
	{
		[Token(Token = "0x2000026")]
		public delegate void SampleBufferCallback(IntPtr context, IntPtr sampleBuffer, int sampleCount, int sampleRate, int channelCount, long timestamp);

		[Token(Token = "0x400007C")]
		private const string Assembly = "NatMic";

		[Token(Token = "0x400007D")]
		private const UnmanagedType StringType = UnmanagedType.LPStr;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE2F590", Offset = "0xE2F590", VA = "0xE2F590")]
		public static void Devices(out IntPtr outDevicesArray, out int outDevicesArrayCount)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE2F5E4", Offset = "0xE2F5E4", VA = "0xE2F5E4")]
		public static void FreeDevice(this IntPtr device)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE2F5E8", Offset = "0xE2F5E8", VA = "0xE2F5E8")]
		public static void DeviceName(this IntPtr device, StringBuilder dest)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE2F5EC", Offset = "0xE2F5EC", VA = "0xE2F5EC")]
		public static void DeviceUniqueID(this IntPtr device, StringBuilder dest)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE2F5F0", Offset = "0xE2F5F0", VA = "0xE2F5F0")]
		public static bool DeviceEchoCancellation(this IntPtr device)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE2F5F8", Offset = "0xE2F5F8", VA = "0xE2F5F8")]
		public static bool IsRecording(this IntPtr device)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE2F600", Offset = "0xE2F600", VA = "0xE2F600")]
		public static void StartRecording(this IntPtr device, int sampleRate, int channelCount, SampleBufferCallback callback, IntPtr context)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE2F604", Offset = "0xE2F604", VA = "0xE2F604")]
		public static void StopRecording(this IntPtr device)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE2F608", Offset = "0xE2F608", VA = "0xE2F608")]
		public static long CurrentTimestamp()
		{
			return default(long);
		}
	}
	[Token(Token = "0x2000016")]
	public sealed class DocAttribute : Attribute
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE2FFE8", Offset = "0xE2FFE8", VA = "0xE2FFE8")]
		public DocAttribute(string descriptionKey)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE2FFF0", Offset = "0xE2FFF0", VA = "0xE2FFF0")]
		public DocAttribute(string summaryKey, string descriptionKey)
		{
		}
	}
	[Token(Token = "0x2000017")]
	public sealed class CodeAttribute : Attribute
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE2FFE0", Offset = "0xE2FFE0", VA = "0xE2FFE0")]
		public CodeAttribute(string key)
		{
		}
	}
	[Token(Token = "0x2000018")]
	public sealed class RefAttribute : Attribute
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE2FFF8", Offset = "0xE2FFF8", VA = "0xE2FFF8")]
		public RefAttribute(params string[] keys)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public sealed class AudioDeviceiOS : AudioDevice
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly IntPtr device;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private GCHandle self;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IAudioProcessor processor;

		[Token(Token = "0x1700000E")]
		public new static long CurrentTimestamp
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xE2E200", Offset = "0xE2E200", VA = "0xE2E200")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x1700000F")]
		public override string Name
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE2FDEC", Offset = "0xE2FDEC", VA = "0xE2FDEC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		public override string UniqueID
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE2FE70", Offset = "0xE2FE70", VA = "0xE2FE70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public override bool EchoCancellation
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE2FEF4", Offset = "0xE2FEF4", VA = "0xE2FEF4", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public override bool IsRecording
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE2FEFC", Offset = "0xE2FEFC", VA = "0xE2FEFC", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE2DFD0", Offset = "0xE2DFD0", VA = "0xE2DFD0")]
		public new static AudioDeviceiOS[] GetDevices()
		{
			return null;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE2FF04", Offset = "0xE2FF04", VA = "0xE2FF04", Slot = "12")]
		public override void StartRecording(int sampleRate, int channelCount, IAudioProcessor processor)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE2FFAC", Offset = "0xE2FFAC", VA = "0xE2FFAC", Slot = "13")]
		public override void StopRecording()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE2FDCC", Offset = "0xE2FDCC", VA = "0xE2FDCC")]
		private AudioDeviceiOS(IntPtr device)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE2FFD8", Offset = "0xE2FFD8", VA = "0xE2FFD8", Slot = "1")]
		~AudioDeviceiOS()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE2FB34", Offset = "0xE2FB34", VA = "0xE2FB34")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x223098", Offset = "0x223098")]
		private static void OnSampleBuffer(IntPtr context, IntPtr sampleBuffer, int sampleCount, int sampleRate, int channelCount, long timestamp)
		{
		}
	}
}
namespace NatMic.Examples
{
	[Token(Token = "0x200001A")]
	public class VoiceRecorder : MonoBehaviour
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public AudioSource audioSource;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IAudioDevice audioDevice;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private WAVRecorder audioRecorder;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE2E31C", Offset = "0xE2E31C", VA = "0xE2E31C")]
		private void Start()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE2E3E8", Offset = "0xE2E3E8", VA = "0xE2E3E8")]
		public void ToggleRecording(Text buttonText)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE2E7BC", Offset = "0xE2E7BC", VA = "0xE2E7BC")]
		public VoiceRecorder()
		{
		}
	}
}
