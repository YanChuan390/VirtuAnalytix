using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.CrossPlatformInput.PlatformSpecific;
using UnityStandardAssets.Utility;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Edge Detection (Color)")]
public class EdgeDetectEffect : ImageEffectBase
{
	public float threshold = 0.2f;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetFloat("_Treshold", threshold * threshold);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Blur")]
public class BlurEffect : MonoBehaviour
{
	public int iterations = 3;

	public float blurSpread = 0.6f;

	public Shader blurShader;

	private static Material m_Material;

	protected Material material
	{
		get
		{
			if (m_Material == null)
			{
				m_Material = new Material(blurShader);
				m_Material.hideFlags = HideFlags.DontSave;
			}
			return m_Material;
		}
	}

	protected void OnDisable()
	{
		if ((bool)m_Material)
		{
			UnityEngine.Object.DestroyImmediate(m_Material);
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!blurShader || !material.shader.isSupported)
		{
			base.enabled = false;
		}
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
		float num = 0.5f + (float)iteration * blurSpread;
		Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
	}

	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
		float num = 1f;
		Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		DownSample4x(source, temporary);
		bool flag = true;
		for (int i = 0; i < iterations; i++)
		{
			if (flag)
			{
				FourTapCone(temporary, temporary2, i);
			}
			else
			{
				FourTapCone(temporary2, temporary, i);
			}
			flag = !flag;
		}
		if (flag)
		{
			Graphics.Blit(temporary, destination);
		}
		else
		{
			Graphics.Blit(temporary2, destination);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Color Correction (Ramp)")]
public class ColorCorrectionEffect : ImageEffectBase
{
	public Texture textureRamp;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetTexture("_RampTex", textureRamp);
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Contrast Stretch")]
public class ContrastStretchEffect : MonoBehaviour
{
	public float adaptationSpeed = 0.02f;

	public float limitMinimum = 0.2f;

	public float limitMaximum = 0.6f;

	private RenderTexture[] adaptRenderTex = new RenderTexture[2];

	private int curAdaptIndex;

	public Shader shaderLum;

	private Material m_materialLum;

	public Shader shaderReduce;

	private Material m_materialReduce;

	public Shader shaderAdapt;

	private Material m_materialAdapt;

	public Shader shaderApply;

	private Material m_materialApply;

	protected Material materialLum
	{
		get
		{
			if (m_materialLum == null)
			{
				m_materialLum = new Material(shaderLum);
				m_materialLum.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_materialLum;
		}
	}

	protected Material materialReduce
	{
		get
		{
			if (m_materialReduce == null)
			{
				m_materialReduce = new Material(shaderReduce);
				m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_materialReduce;
		}
	}

	protected Material materialAdapt
	{
		get
		{
			if (m_materialAdapt == null)
			{
				m_materialAdapt = new Material(shaderAdapt);
				m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_materialAdapt;
		}
	}

	protected Material materialApply
	{
		get
		{
			if (m_materialApply == null)
			{
				m_materialApply = new Material(shaderApply);
				m_materialApply.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_materialApply;
		}
	}

	private void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
		{
			base.enabled = false;
		}
	}

	private void OnEnable()
	{
		for (int i = 0; i < 2; i++)
		{
			if (!adaptRenderTex[i])
			{
				adaptRenderTex[i] = new RenderTexture(1, 1, 32);
				adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
			}
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < 2; i++)
		{
			UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
			adaptRenderTex[i] = null;
		}
		if ((bool)m_materialLum)
		{
			UnityEngine.Object.DestroyImmediate(m_materialLum);
		}
		if ((bool)m_materialReduce)
		{
			UnityEngine.Object.DestroyImmediate(m_materialReduce);
		}
		if ((bool)m_materialAdapt)
		{
			UnityEngine.Object.DestroyImmediate(m_materialAdapt);
		}
		if ((bool)m_materialApply)
		{
			UnityEngine.Object.DestroyImmediate(m_materialApply);
		}
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / 1, source.height / 1);
		Graphics.Blit(source, renderTexture, materialLum);
		while (renderTexture.width > 1 || renderTexture.height > 1)
		{
			int num = renderTexture.width / 2;
			if (num < 1)
			{
				num = 1;
			}
			int num2 = renderTexture.height / 2;
			if (num2 < 1)
			{
				num2 = 1;
			}
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
			Graphics.Blit(renderTexture, temporary, materialReduce);
			RenderTexture.ReleaseTemporary(renderTexture);
			renderTexture = temporary;
		}
		CalculateAdaptation(renderTexture);
		materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
		Graphics.Blit(source, destination, materialApply);
		RenderTexture.ReleaseTemporary(renderTexture);
	}

	private void CalculateAdaptation(Texture curTexture)
	{
		int num = curAdaptIndex;
		curAdaptIndex = (curAdaptIndex + 1) % 2;
		float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
		value = Mathf.Clamp(value, 0.01f, 1f);
		materialAdapt.SetTexture("_CurTex", curTexture);
		materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
		Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Grayscale")]
public class GrayscaleEffect : ImageEffectBase
{
	public Texture textureRamp;

	public float rampOffset;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		base.material.SetTexture("_RampTex", textureRamp);
		base.material.SetFloat("_RampOffset", rampOffset);
		Graphics.Blit(source, destination, base.material);
	}
}
[RequireComponent(typeof(Camera))]
[AddComponentMenu("")]
public class ImageEffectBase : MonoBehaviour
{
	public Shader shader;

	private Material m_Material;

	protected Material material
	{
		get
		{
			if (m_Material == null)
			{
				m_Material = new Material(shader);
				m_Material.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_Material;
		}
	}

	protected virtual void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = false;
		}
	}

	protected virtual void OnDisable()
	{
		if ((bool)m_Material)
		{
			UnityEngine.Object.DestroyImmediate(m_Material);
		}
	}
}
[AddComponentMenu("")]
public class ImageEffects
{
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
		if (source.texelSize.y < 0f)
		{
			center.y = 1f - center.y;
			angle = 0f - angle;
		}
		Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
		material.SetMatrix("_RotationMatrix", value);
		material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
		material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
		Graphics.Blit(source, destination, material);
	}

	[Obsolete("Use Graphics.Blit(source,dest) instead")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
		Graphics.Blit(source, dest);
	}

	[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
		Graphics.Blit(source, dest, material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Motion Blur (Color Accumulation)")]
[RequireComponent(typeof(Camera))]
public class MotionBlur : ImageEffectBase
{
	public float blurAmount = 0.8f;

	public bool extraBlur;

	private RenderTexture accumTexture;

	protected override void Start()
	{
		if (!SystemInfo.supportsRenderTextures)
		{
			base.enabled = false;
		}
		else
		{
			base.Start();
		}
	}

	protected override void OnDisable()
	{
		base.OnDisable();
		UnityEngine.Object.DestroyImmediate(accumTexture);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
		{
			UnityEngine.Object.DestroyImmediate(accumTexture);
			accumTexture = new RenderTexture(source.width, source.height, 0);
			accumTexture.hideFlags = HideFlags.HideAndDontSave;
			Graphics.Blit(source, accumTexture);
		}
		if (extraBlur)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
			Graphics.Blit(accumTexture, temporary);
			Graphics.Blit(temporary, accumTexture);
			RenderTexture.ReleaseTemporary(temporary);
		}
		blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
		base.material.SetTexture("_MainTex", accumTexture);
		base.material.SetFloat("_AccumOrig", 1f - blurAmount);
		Graphics.Blit(source, accumTexture, base.material);
		Graphics.Blit(accumTexture, destination);
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Noise")]
public class NoiseEffect : MonoBehaviour
{
	public bool monochrome = true;

	private bool rgbFallback;

	public float grainIntensityMin = 0.1f;

	public float grainIntensityMax = 0.2f;

	public float grainSize = 2f;

	public float scratchIntensityMin = 0.05f;

	public float scratchIntensityMax = 0.25f;

	public float scratchFPS = 10f;

	public float scratchJitter = 0.01f;

	public Texture grainTexture;

	public Texture scratchTexture;

	public Shader shaderRGB;

	public Shader shaderYUV;

	private Material m_MaterialRGB;

	private Material m_MaterialYUV;

	private float scratchTimeLeft;

	private float scratchX;

	private float scratchY;

	protected Material material
	{
		get
		{
			if (m_MaterialRGB == null)
			{
				m_MaterialRGB = new Material(shaderRGB);
				m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
			}
			if (m_MaterialYUV == null && !rgbFallback)
			{
				m_MaterialYUV = new Material(shaderYUV);
				m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
			}
			if (rgbFallback || monochrome)
			{
				return m_MaterialRGB;
			}
			return m_MaterialYUV;
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (shaderRGB == null || shaderYUV == null)
		{
			UnityEngine.Debug.Log("Noise shaders are not set up! Disabling noise effect.");
			base.enabled = false;
		}
		else if (!shaderRGB.isSupported)
		{
			base.enabled = false;
		}
		else if (!shaderYUV.isSupported)
		{
			rgbFallback = true;
		}
	}

	protected void OnDisable()
	{
		if ((bool)m_MaterialRGB)
		{
			UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
		}
		if ((bool)m_MaterialYUV)
		{
			UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
		}
	}

	private void SanitizeParameters()
	{
		grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
		grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
		scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
		scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
		scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
		scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
		grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		SanitizeParameters();
		if (scratchTimeLeft <= 0f)
		{
			scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
			scratchX = UnityEngine.Random.value;
			scratchY = UnityEngine.Random.value;
		}
		scratchTimeLeft -= Time.deltaTime;
		Material material = this.material;
		material.SetTexture("_GrainTex", grainTexture);
		material.SetTexture("_ScratchTex", scratchTexture);
		float num = 1f / grainSize;
		material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
		material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
		material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
		Graphics.Blit(source, destination, material);
	}
}
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Screen Space Ambient Occlusion")]
public class SSAOEffect : MonoBehaviour
{
	public enum SSAOSamples
	{
		Low,
		Medium,
		High
	}

	public float m_Radius = 0.4f;

	public SSAOSamples m_SampleCount = SSAOSamples.Medium;

	public float m_OcclusionIntensity = 1.5f;

	public int m_Blur = 2;

	public int m_Downsampling = 2;

	public float m_OcclusionAttenuation = 1f;

	public float m_MinZ = 0.01f;

	public Shader m_SSAOShader;

	private Material m_SSAOMaterial;

	public Texture2D m_RandomTexture;

	private bool m_Supported;

	private static Material CreateMaterial(Shader shader)
	{
		if (!shader)
		{
			return null;
		}
		return new Material(shader)
		{
			hideFlags = HideFlags.HideAndDontSave
		};
	}

	private static void DestroyMaterial(Material mat)
	{
		if ((bool)mat)
		{
			UnityEngine.Object.DestroyImmediate(mat);
			mat = null;
		}
	}

	private void OnDisable()
	{
		DestroyMaterial(m_SSAOMaterial);
	}

	private void Start()
	{
		if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			m_Supported = false;
			base.enabled = false;
			return;
		}
		CreateMaterials();
		if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
		{
			m_Supported = false;
			base.enabled = false;
		}
		else
		{
			m_Supported = true;
		}
	}

	private void OnEnable()
	{
		GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
	}

	private void CreateMaterials()
	{
		if (!m_SSAOMaterial && m_SSAOShader.isSupported)
		{
			m_SSAOMaterial = CreateMaterial(m_SSAOShader);
			m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
		}
	}

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		if (!m_Supported || !m_SSAOShader.isSupported)
		{
			base.enabled = false;
			return;
		}
		CreateMaterials();
		m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
		m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
		m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
		m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
		m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
		m_Blur = Mathf.Clamp(m_Blur, 0, 4);
		RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
		float fieldOfView = GetComponent<Camera>().fieldOfView;
		float farClipPlane = GetComponent<Camera>().farClipPlane;
		float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
		float x = num * GetComponent<Camera>().aspect;
		m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
		int num2;
		int num3;
		if ((bool)m_RandomTexture)
		{
			num2 = m_RandomTexture.width;
			num3 = m_RandomTexture.height;
		}
		else
		{
			num2 = 1;
			num3 = 1;
		}
		m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
		m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
		bool num4 = m_Blur > 0;
		Graphics.Blit(num4 ? null : source, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
		if (num4)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
			m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
			m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
			m_SSAOMaterial.SetTexture("_SSAO", temporary);
			Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
			RenderTexture.ReleaseTemporary(temporary);
			renderTexture = temporary2;
		}
		m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
		Graphics.Blit(source, destination, m_SSAOMaterial, 4);
		RenderTexture.ReleaseTemporary(renderTexture);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Sepia Tone")]
public class SepiaToneEffect : ImageEffectBase
{
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit(source, destination, base.material);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Twirl")]
public class TwirlEffect : ImageEffectBase
{
	public Vector2 radius = new Vector2(0.3f, 0.3f);

	public float angle = 50f;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
	}
}
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Vortex")]
public class VortexEffect : ImageEffectBase
{
	public Vector2 radius = new Vector2(0.4f, 0.4f);

	public float angle = 50f;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
	}
}
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	protected Image _image;

	public void Start()
	{
		_image = GetComponent<Image>();
		Texture2D texture = _image.sprite.texture;
		bool flag = false;
		if (texture != null)
		{
			try
			{
				texture.GetPixels32();
			}
			catch (UnityException ex)
			{
				UnityEngine.Debug.LogError(ex.Message);
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			UnityEngine.Debug.LogError("This script need an Image with a readbale Texture2D to work.");
		}
	}

	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		RectTransformUtility.ScreenPointToLocalPointInRectangle(_image.rectTransform, sp, eventCamera, out var localPoint);
		Vector2 vector = new Vector2(1f + localPoint.x / _image.rectTransform.rect.width, 1f + localPoint.y / _image.rectTransform.rect.height);
		Vector2 vector2 = new Vector2(_image.sprite.rect.x + vector.x * _image.sprite.rect.width, _image.sprite.rect.y + vector.y * _image.sprite.rect.height);
		vector2.x /= _image.sprite.texture.width;
		vector2.y /= _image.sprite.texture.height;
		return _image.sprite.texture.GetPixelBilinear(vector2.x, vector2.y).a > 0.1f;
	}
}
public class EventSystemChecker : MonoBehaviour
{
	private void Awake()
	{
		if (!UnityEngine.Object.FindObjectOfType<EventSystem>())
		{
			GameObject obj = new GameObject("EventSystem");
			obj.AddComponent<EventSystem>();
			obj.AddComponent<StandaloneInputModule>().forceModuleActive = true;
		}
	}
}
[RequireComponent(typeof(Image))]
public class ForcedReset : MonoBehaviour
{
	private void Update()
	{
		if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
		{
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}
	}
}
namespace UnityStandardAssets.Utility
{
	public class ActivateTrigger : MonoBehaviour
	{
		public enum Mode
		{
			Trigger,
			Replace,
			Activate,
			Enable,
			Animate,
			Deactivate
		}

		public Mode action = Mode.Activate;

		public UnityEngine.Object target;

		public GameObject source;

		public int triggerCount = 1;

		public bool repeatTrigger;

		private void DoActivateTrigger()
		{
			triggerCount--;
			if (triggerCount != 0 && !repeatTrigger)
			{
				return;
			}
			UnityEngine.Object obj = target ?? base.gameObject;
			Behaviour behaviour = obj as Behaviour;
			GameObject gameObject = obj as GameObject;
			if (behaviour != null)
			{
				gameObject = behaviour.gameObject;
			}
			switch (action)
			{
			case Mode.Trigger:
				if (gameObject != null)
				{
					gameObject.BroadcastMessage("DoActivateTrigger");
				}
				break;
			case Mode.Replace:
				if (source != null && gameObject != null)
				{
					UnityEngine.Object.Instantiate(source, gameObject.transform.position, gameObject.transform.rotation);
					UnityEngine.Object.DestroyObject(gameObject);
				}
				break;
			case Mode.Activate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: true);
				}
				break;
			case Mode.Enable:
				if (behaviour != null)
				{
					behaviour.enabled = true;
				}
				break;
			case Mode.Animate:
				if (gameObject != null)
				{
					gameObject.GetComponent<Animation>().Play();
				}
				break;
			case Mode.Deactivate:
				if (gameObject != null)
				{
					gameObject.SetActive(value: false);
				}
				break;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			DoActivateTrigger();
		}
	}
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		public class ReplacementDefinition
		{
			public Shader original;

			public Shader replacement;
		}

		[Serializable]
		public class ReplacementList
		{
			public ReplacementDefinition[] items = new ReplacementDefinition[0];
		}

		[SerializeField]
		private ReplacementList m_ReplacementList;

		private void OnEnable()
		{
			Renderer[] array = UnityEngine.Object.FindObjectsOfType<Renderer>();
			UnityEngine.Debug.Log(array.Length + " renderers");
			List<Material> list = new List<Material>();
			List<Material> list2 = new List<Material>();
			int num = 0;
			int num2 = 0;
			ReplacementDefinition[] items = m_ReplacementList.items;
			foreach (ReplacementDefinition replacementDefinition in items)
			{
				Renderer[] array2 = array;
				foreach (Renderer renderer in array2)
				{
					Material[] array3 = null;
					for (int k = 0; k < renderer.sharedMaterials.Length; k++)
					{
						Material material = renderer.sharedMaterials[k];
						if (material.shader == replacementDefinition.original)
						{
							if (array3 == null)
							{
								array3 = renderer.materials;
							}
							if (!list.Contains(material))
							{
								list.Add(material);
								Material material2 = UnityEngine.Object.Instantiate(material);
								material2.shader = replacementDefinition.replacement;
								list2.Add(material2);
								num++;
							}
							UnityEngine.Debug.Log("replacing " + renderer.gameObject.name + " renderer " + k + " with " + list2[list.IndexOf(material)].name);
							array3[k] = list2[list.IndexOf(material)];
							num2++;
						}
					}
					if (array3 != null)
					{
						renderer.materials = array3;
					}
				}
			}
			UnityEngine.Debug.Log(num2 + " material instances replaced");
			UnityEngine.Debug.Log(num + " materials replaced");
			for (int l = 0; l < list.Count; l++)
			{
				UnityEngine.Debug.Log(list[l].name + " (" + list[l].shader.name + ") replaced with " + list2[l].name + " (" + list2[l].shader.name + ")");
			}
		}
	}
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		public class Vector3andSpace
		{
			public Vector3 value;

			public Space space = Space.Self;
		}

		public Vector3andSpace moveUnitsPerSecond;

		public Vector3andSpace rotateDegreesPerSecond;

		public bool ignoreTimescale;

		private float m_LastRealTime;

		private void Start()
		{
			m_LastRealTime = Time.realtimeSinceStartup;
		}

		private void Update()
		{
			float num = Time.deltaTime;
			if (ignoreTimescale)
			{
				num = Time.realtimeSinceStartup - m_LastRealTime;
				m_LastRealTime = Time.realtimeSinceStartup;
			}
			base.transform.Translate(moveUnitsPerSecond.value * num, moveUnitsPerSecond.space);
			base.transform.Rotate(rotateDegreesPerSecond.value * num, moveUnitsPerSecond.space);
		}
	}
	public class CameraRefocus
	{
		public Camera Camera;

		public Vector3 Lookatpoint;

		public Transform Parent;

		private Vector3 m_OrigCameraPos;

		private bool m_Refocus;

		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
			m_OrigCameraPos = origCameraPos;
			Camera = camera;
			Parent = parent;
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public void ChangeParent(Transform parent)
		{
			Parent = parent;
		}

		public void GetFocusPoint()
		{
			if (Physics.Raycast(Parent.transform.position + m_OrigCameraPos, Parent.transform.forward, out var hitInfo, 100f))
			{
				Lookatpoint = hitInfo.point;
				m_Refocus = true;
			}
			else
			{
				m_Refocus = false;
			}
		}

		public void SetFocusPoint()
		{
			if (m_Refocus)
			{
				Camera.transform.LookAt(Lookatpoint);
			}
		}
	}
	[Serializable]
	public class CurveControlledBob
	{
		public float HorizontalBobRange = 0.33f;

		public float VerticalBobRange = 0.33f;

		public AnimationCurve Bobcurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.5f, 1f), new Keyframe(1f, 0f), new Keyframe(1.5f, -1f), new Keyframe(2f, 0f));

		public float VerticaltoHorizontalRatio = 1f;

		private float m_CyclePositionX;

		private float m_CyclePositionY;

		private float m_BobBaseInterval;

		private Vector3 m_OriginalCameraPosition;

		private float m_Time;

		public void Setup(Camera camera, float bobBaseInterval)
		{
			m_BobBaseInterval = bobBaseInterval;
			m_OriginalCameraPosition = camera.transform.localPosition;
			m_Time = Bobcurve[Bobcurve.length - 1].time;
		}

		public Vector3 DoHeadBob(float speed)
		{
			float x = m_OriginalCameraPosition.x + Bobcurve.Evaluate(m_CyclePositionX) * HorizontalBobRange;
			float y = m_OriginalCameraPosition.y + Bobcurve.Evaluate(m_CyclePositionY) * VerticalBobRange;
			m_CyclePositionX += speed * Time.deltaTime / m_BobBaseInterval;
			m_CyclePositionY += speed * Time.deltaTime / m_BobBaseInterval * VerticaltoHorizontalRatio;
			if (m_CyclePositionX > m_Time)
			{
				m_CyclePositionX -= m_Time;
			}
			if (m_CyclePositionY > m_Time)
			{
				m_CyclePositionY -= m_Time;
			}
			return new Vector3(x, y, 0f);
		}
	}
	public class DragRigidbody : MonoBehaviour
	{
		private const float k_Spring = 50f;

		private const float k_Damper = 5f;

		private const float k_Drag = 10f;

		private const float k_AngularDrag = 5f;

		private const float k_Distance = 0.2f;

		private const bool k_AttachToCenterOfMass = false;

		private SpringJoint m_SpringJoint;

		private void Update()
		{
			if (!Input.GetMouseButtonDown(0))
			{
				return;
			}
			Camera camera = FindCamera();
			RaycastHit hitInfo = default(RaycastHit);
			if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition).origin, camera.ScreenPointToRay(Input.mousePosition).direction, out hitInfo, 100f, -5) && (bool)hitInfo.rigidbody && !hitInfo.rigidbody.isKinematic)
			{
				if (!m_SpringJoint)
				{
					GameObject gameObject = new GameObject("Rigidbody dragger");
					Rigidbody rigidbody = gameObject.AddComponent<Rigidbody>();
					m_SpringJoint = gameObject.AddComponent<SpringJoint>();
					rigidbody.isKinematic = true;
				}
				m_SpringJoint.transform.position = hitInfo.point;
				m_SpringJoint.anchor = Vector3.zero;
				m_SpringJoint.spring = 50f;
				m_SpringJoint.damper = 5f;
				m_SpringJoint.maxDistance = 0.2f;
				m_SpringJoint.connectedBody = hitInfo.rigidbody;
				StartCoroutine("DragObject", hitInfo.distance);
			}
		}

		private IEnumerator DragObject(float distance)
		{
			float oldDrag = m_SpringJoint.connectedBody.drag;
			float oldAngularDrag = m_SpringJoint.connectedBody.angularDrag;
			m_SpringJoint.connectedBody.drag = 10f;
			m_SpringJoint.connectedBody.angularDrag = 5f;
			Camera mainCamera = FindCamera();
			while (Input.GetMouseButton(0))
			{
				Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
				m_SpringJoint.transform.position = ray.GetPoint(distance);
				yield return null;
			}
			if ((bool)m_SpringJoint.connectedBody)
			{
				m_SpringJoint.connectedBody.drag = oldDrag;
				m_SpringJoint.connectedBody.angularDrag = oldAngularDrag;
				m_SpringJoint.connectedBody = null;
			}
		}

		private Camera FindCamera()
		{
			if ((bool)GetComponent<Camera>())
			{
				return GetComponent<Camera>();
			}
			return Camera.main;
		}
	}
	public class DynamicShadowSettings : MonoBehaviour
	{
		public Light sunLight;

		public float minHeight = 10f;

		public float minShadowDistance = 80f;

		public float minShadowBias = 1f;

		public float maxHeight = 1000f;

		public float maxShadowDistance = 10000f;

		public float maxShadowBias = 0.1f;

		public float adaptTime = 1f;

		private float m_SmoothHeight;

		private float m_ChangeSpeed;

		private float m_OriginalStrength = 1f;

		private void Start()
		{
			m_OriginalStrength = sunLight.shadowStrength;
		}

		private void Update()
		{
			Ray ray = new Ray(Camera.main.transform.position, -Vector3.up);
			float num = base.transform.position.y;
			if (Physics.Raycast(ray, out var hitInfo))
			{
				num = hitInfo.distance;
			}
			if (Mathf.Abs(num - m_SmoothHeight) > 1f)
			{
				m_SmoothHeight = Mathf.SmoothDamp(m_SmoothHeight, num, ref m_ChangeSpeed, adaptTime);
			}
			float num2 = Mathf.InverseLerp(minHeight, maxHeight, m_SmoothHeight);
			QualitySettings.shadowDistance = Mathf.Lerp(minShadowDistance, maxShadowDistance, num2);
			sunLight.shadowBias = Mathf.Lerp(minShadowBias, maxShadowBias, 1f - (1f - num2) * (1f - num2));
			sunLight.shadowStrength = Mathf.Lerp(m_OriginalStrength, 0f, num2);
		}
	}
	[Serializable]
	public class FOVKick
	{
		public Camera Camera;

		[HideInInspector]
		public float originalFov;

		public float FOVIncrease = 3f;

		public float TimeToIncrease = 1f;

		public float TimeToDecrease = 1f;

		public AnimationCurve IncreaseCurve;

		public void Setup(Camera camera)
		{
			CheckStatus(camera);
			Camera = camera;
			originalFov = camera.fieldOfView;
		}

		private void CheckStatus(Camera camera)
		{
			if (camera == null)
			{
				throw new Exception("FOVKick camera is null, please supply the camera to the constructor");
			}
			if (IncreaseCurve == null)
			{
				throw new Exception("FOVKick Increase curve is null, please define the curve for the field of view kicks");
			}
		}

		public void ChangeCamera(Camera camera)
		{
			Camera = camera;
		}

		public IEnumerator FOVKickUp()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t < TimeToIncrease)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToIncrease) * FOVIncrease;
				t += Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
		}

		public IEnumerator FOVKickDown()
		{
			float t = Mathf.Abs((Camera.fieldOfView - originalFov) / FOVIncrease);
			while (t > 0f)
			{
				Camera.fieldOfView = originalFov + IncreaseCurve.Evaluate(t / TimeToDecrease) * FOVIncrease;
				t -= Time.deltaTime;
				yield return new WaitForEndOfFrame();
			}
			Camera.fieldOfView = originalFov;
		}
	}
	[RequireComponent(typeof(Text))]
	public class FPSCounter : MonoBehaviour
	{
		private const float fpsMeasurePeriod = 0.5f;

		private int m_FpsAccumulator;

		private float m_FpsNextPeriod;

		private int m_CurrentFps;

		private const string display = "{0} FPS";

		private Text m_Text;

		private void Start()
		{
			m_FpsNextPeriod = Time.realtimeSinceStartup + 0.5f;
			m_Text = GetComponent<Text>();
		}

		private void Update()
		{
			m_FpsAccumulator++;
			if (Time.realtimeSinceStartup > m_FpsNextPeriod)
			{
				m_CurrentFps = (int)((float)m_FpsAccumulator / 0.5f);
				m_FpsAccumulator = 0;
				m_FpsNextPeriod += 0.5f;
				m_Text.text = $"{m_CurrentFps} FPS";
			}
		}
	}
	public class FollowTarget : MonoBehaviour
	{
		public Transform target;

		public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		private void LateUpdate()
		{
			base.transform.position = target.position + offset;
		}
	}
	[Serializable]
	public class LerpControlledBob
	{
		public float BobDuration;

		public float BobAmount;

		private float m_Offset;

		public float Offset()
		{
			return m_Offset;
		}

		public IEnumerator DoBobCycle()
		{
			float t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(0f, BobAmount, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			t2 = 0f;
			while (t2 < BobDuration)
			{
				m_Offset = Mathf.Lerp(BobAmount, 0f, t2 / BobDuration);
				t2 += Time.deltaTime;
				yield return new WaitForFixedUpdate();
			}
			m_Offset = 0f;
		}
	}
	public class ObjectResetter : MonoBehaviour
	{
		private Vector3 originalPosition;

		private Quaternion originalRotation;

		private List<Transform> originalStructure;

		private Rigidbody Rigidbody;

		private void Start()
		{
			originalStructure = new List<Transform>(GetComponentsInChildren<Transform>());
			originalPosition = base.transform.position;
			originalRotation = base.transform.rotation;
			Rigidbody = GetComponent<Rigidbody>();
		}

		public void DelayedReset(float delay)
		{
			StartCoroutine(ResetCoroutine(delay));
		}

		public IEnumerator ResetCoroutine(float delay)
		{
			yield return new WaitForSeconds(delay);
			Transform[] componentsInChildren = GetComponentsInChildren<Transform>();
			foreach (Transform transform in componentsInChildren)
			{
				if (!originalStructure.Contains(transform))
				{
					transform.parent = null;
				}
			}
			base.transform.position = originalPosition;
			base.transform.rotation = originalRotation;
			if ((bool)Rigidbody)
			{
				Rigidbody.velocity = Vector3.zero;
				Rigidbody.angularVelocity = Vector3.zero;
			}
			SendMessage("Reset");
		}
	}
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		public float minDuration = 8f;

		public float maxDuration = 10f;

		private float m_MaxLifetime;

		private bool m_EarlyStop;

		private IEnumerator Start()
		{
			ParticleSystem[] systems = GetComponentsInChildren<ParticleSystem>();
			ParticleSystem[] array = systems;
			foreach (ParticleSystem particleSystem in array)
			{
				m_MaxLifetime = Mathf.Max(particleSystem.startLifetime, m_MaxLifetime);
			}
			float stopTime = Time.time + UnityEngine.Random.Range(minDuration, maxDuration);
			while (Time.time < stopTime || m_EarlyStop)
			{
				yield return null;
			}
			UnityEngine.Debug.Log("stopping " + base.name);
			array = systems;
			for (int i = 0; i < array.Length; i++)
			{
				ParticleSystem.EmissionModule emission = array[i].emission;
				emission.enabled = false;
			}
			BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(m_MaxLifetime);
			UnityEngine.Object.Destroy(base.gameObject);
		}

		public void Stop()
		{
			m_EarlyStop = true;
		}
	}
	public class PlatformSpecificContent : MonoBehaviour
	{
		private enum BuildTargetGroup
		{
			Standalone,
			Mobile
		}

		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[SerializeField]
		private GameObject[] m_Content = new GameObject[0];

		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours = new MonoBehaviour[0];

		[SerializeField]
		private bool m_ChildrenOfThisObject;

		private void OnEnable()
		{
			CheckEnableContent();
		}

		private void CheckEnableContent()
		{
			if (m_BuildTargetGroup == BuildTargetGroup.Mobile)
			{
				EnableContent(enabled: true);
			}
			else
			{
				EnableContent(enabled: false);
			}
		}

		private void EnableContent(bool enabled)
		{
			if (m_Content.Length != 0)
			{
				GameObject[] content = m_Content;
				foreach (GameObject gameObject in content)
				{
					if (gameObject != null)
					{
						gameObject.SetActive(enabled);
					}
				}
			}
			if (m_ChildrenOfThisObject)
			{
				foreach (Transform item in base.transform)
				{
					item.gameObject.SetActive(enabled);
				}
			}
			if (m_MonoBehaviours.Length != 0)
			{
				MonoBehaviour[] monoBehaviours = m_MonoBehaviours;
				for (int i = 0; i < monoBehaviours.Length; i++)
				{
					monoBehaviours[i].enabled = enabled;
				}
			}
		}
	}
	public class SimpleActivatorMenu : MonoBehaviour
	{
		public Text camSwitchButton;

		public GameObject[] objects;

		private int m_CurrentActiveObject;

		private void OnEnable()
		{
			m_CurrentActiveObject = 0;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}

		public void NextCamera()
		{
			int num = ((m_CurrentActiveObject + 1 < objects.Length) ? (m_CurrentActiveObject + 1) : 0);
			for (int i = 0; i < objects.Length; i++)
			{
				objects[i].SetActive(i == num);
			}
			m_CurrentActiveObject = num;
			camSwitchButton.text = objects[m_CurrentActiveObject].name;
		}
	}
	public class SimpleMouseRotator : MonoBehaviour
	{
		public Vector2 rotationRange = new Vector3(70f, 70f);

		public float rotationSpeed = 10f;

		public float dampingTime = 0.2f;

		public bool autoZeroVerticalOnMobile = true;

		public bool autoZeroHorizontalOnMobile;

		public bool relative = true;

		private Vector3 m_TargetAngles;

		private Vector3 m_FollowAngles;

		private Vector3 m_FollowVelocity;

		private Quaternion m_OriginalRotation;

		private void Start()
		{
			m_OriginalRotation = base.transform.localRotation;
		}

		private void Update()
		{
			base.transform.localRotation = m_OriginalRotation;
			if (relative)
			{
				float axis = CrossPlatformInputManager.GetAxis("Mouse X");
				float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
				if (m_TargetAngles.y > 180f)
				{
					m_TargetAngles.y -= 360f;
					m_FollowAngles.y -= 360f;
				}
				if (m_TargetAngles.x > 180f)
				{
					m_TargetAngles.x -= 360f;
					m_FollowAngles.x -= 360f;
				}
				if (m_TargetAngles.y < -180f)
				{
					m_TargetAngles.y += 360f;
					m_FollowAngles.y += 360f;
				}
				if (m_TargetAngles.x < -180f)
				{
					m_TargetAngles.x += 360f;
					m_FollowAngles.x += 360f;
				}
				m_TargetAngles.y += axis * rotationSpeed;
				m_TargetAngles.x += axis2 * rotationSpeed;
				m_TargetAngles.y = Mathf.Clamp(m_TargetAngles.y, (0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f);
				m_TargetAngles.x = Mathf.Clamp(m_TargetAngles.x, (0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f);
			}
			else
			{
				float axis = Input.mousePosition.x;
				float axis2 = Input.mousePosition.y;
				m_TargetAngles.y = Mathf.Lerp((0f - rotationRange.y) * 0.5f, rotationRange.y * 0.5f, axis / (float)Screen.width);
				m_TargetAngles.x = Mathf.Lerp((0f - rotationRange.x) * 0.5f, rotationRange.x * 0.5f, axis2 / (float)Screen.height);
			}
			m_FollowAngles = Vector3.SmoothDamp(m_FollowAngles, m_TargetAngles, ref m_FollowVelocity, dampingTime);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f - m_FollowAngles.x, m_FollowAngles.y, 0f);
		}
	}
	public class SmoothFollow : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float distance = 10f;

		[SerializeField]
		private float height = 5f;

		[SerializeField]
		private float rotationDamping;

		[SerializeField]
		private float heightDamping;

		private void Start()
		{
		}

		private void LateUpdate()
		{
			if ((bool)target)
			{
				float y = target.eulerAngles.y;
				float b = target.position.y + height;
				float y2 = base.transform.eulerAngles.y;
				float y3 = base.transform.position.y;
				y2 = Mathf.LerpAngle(y2, y, rotationDamping * Time.deltaTime);
				y3 = Mathf.Lerp(y3, b, heightDamping * Time.deltaTime);
				Quaternion quaternion = Quaternion.Euler(0f, y2, 0f);
				base.transform.position = target.position;
				base.transform.position -= quaternion * Vector3.forward * distance;
				base.transform.position = new Vector3(base.transform.position.x, y3, base.transform.position.z);
				base.transform.LookAt(target);
			}
		}
	}
	public class TimedObjectActivator : MonoBehaviour
	{
		public enum Action
		{
			Activate,
			Deactivate,
			Destroy,
			ReloadLevel,
			Call
		}

		[Serializable]
		public class Entry
		{
			public GameObject target;

			public Action action;

			public float delay;
		}

		[Serializable]
		public class Entries
		{
			public Entry[] entries;
		}

		public Entries entries = new Entries();

		private void Awake()
		{
			Entry[] array = entries.entries;
			foreach (Entry entry in array)
			{
				switch (entry.action)
				{
				case Action.Activate:
					StartCoroutine(Activate(entry));
					break;
				case Action.Deactivate:
					StartCoroutine(Deactivate(entry));
					break;
				case Action.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case Action.ReloadLevel:
					StartCoroutine(ReloadLevel(entry));
					break;
				}
			}
		}

		private IEnumerator Activate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: true);
		}

		private IEnumerator Deactivate(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			entry.target.SetActive(value: false);
		}

		private IEnumerator ReloadLevel(Entry entry)
		{
			yield return new WaitForSeconds(entry.delay);
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
		}
	}
	public class TimedObjectDestructor : MonoBehaviour
	{
		[SerializeField]
		private float m_TimeOut = 1f;

		[SerializeField]
		private bool m_DetachChildren;

		private void Awake()
		{
			Invoke("DestroyNow", m_TimeOut);
		}

		private void DestroyNow()
		{
			if (m_DetachChildren)
			{
				base.transform.DetachChildren();
			}
			UnityEngine.Object.DestroyObject(base.gameObject);
		}
	}
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		public class WaypointList
		{
			public WaypointCircuit circuit;

			public Transform[] items = new Transform[0];
		}

		public struct RoutePoint
		{
			public Vector3 position;

			public Vector3 direction;

			public RoutePoint(Vector3 position, Vector3 direction)
			{
				this.position = position;
				this.direction = direction;
			}
		}

		public WaypointList waypointList = new WaypointList();

		[SerializeField]
		private bool smoothRoute = true;

		private int numPoints;

		private Vector3[] points;

		private float[] distances;

		public float editorVisualisationSubsteps = 100f;

		private int p0n;

		private int p1n;

		private int p2n;

		private int p3n;

		private float i;

		private Vector3 P0;

		private Vector3 P1;

		private Vector3 P2;

		private Vector3 P3;

		public float Length { get; private set; }

		public Transform[] Waypoints => waypointList.items;

		private void Awake()
		{
			if (Waypoints.Length > 1)
			{
				CachePositionsAndDistances();
			}
			numPoints = Waypoints.Length;
		}

		public RoutePoint GetRoutePoint(float dist)
		{
			Vector3 routePosition = GetRoutePosition(dist);
			return new RoutePoint(routePosition, (GetRoutePosition(dist + 0.1f) - routePosition).normalized);
		}

		public Vector3 GetRoutePosition(float dist)
		{
			int i = 0;
			if (Length == 0f)
			{
				Length = distances[distances.Length - 1];
			}
			for (dist = Mathf.Repeat(dist, Length); distances[i] < dist; i++)
			{
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			this.i = Mathf.InverseLerp(distances[p1n], distances[p2n], dist);
			if (smoothRoute)
			{
				p0n = (i - 2 + numPoints) % numPoints;
				p3n = (i + 1) % numPoints;
				p2n %= numPoints;
				P0 = points[p0n];
				P1 = points[p1n];
				P2 = points[p2n];
				P3 = points[p3n];
				return CatmullRom(P0, P1, P2, P3, this.i);
			}
			p1n = (i - 1 + numPoints) % numPoints;
			p2n = i;
			return Vector3.Lerp(points[p1n], points[p2n], this.i);
		}

		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return 0.5f * (2f * p1 + (-p0 + p2) * i + (2f * p0 - 5f * p1 + 4f * p2 - p3) * i * i + (-p0 + 3f * p1 - 3f * p2 + p3) * i * i * i);
		}

		private void CachePositionsAndDistances()
		{
			points = new Vector3[Waypoints.Length + 1];
			distances = new float[Waypoints.Length + 1];
			float num = 0f;
			for (int i = 0; i < points.Length; i++)
			{
				Transform transform = Waypoints[i % Waypoints.Length];
				Transform transform2 = Waypoints[(i + 1) % Waypoints.Length];
				if (transform != null && transform2 != null)
				{
					Vector3 position = transform.position;
					Vector3 position2 = transform2.position;
					points[i] = Waypoints[i % Waypoints.Length].position;
					distances[i] = num;
					num += (position - position2).magnitude;
				}
			}
		}

		private void OnDrawGizmos()
		{
			DrawGizmos(selected: false);
		}

		private void OnDrawGizmosSelected()
		{
			DrawGizmos(selected: true);
		}

		private void DrawGizmos(bool selected)
		{
			waypointList.circuit = this;
			if (Waypoints.Length <= 1)
			{
				return;
			}
			numPoints = Waypoints.Length;
			CachePositionsAndDistances();
			Length = distances[distances.Length - 1];
			Gizmos.color = (selected ? Color.yellow : new Color(1f, 1f, 0f, 0.5f));
			Vector3 from = Waypoints[0].position;
			if (smoothRoute)
			{
				for (float num = 0f; num < Length; num += Length / editorVisualisationSubsteps)
				{
					Vector3 routePosition = GetRoutePosition(num + 1f);
					Gizmos.DrawLine(from, routePosition);
					from = routePosition;
				}
				Gizmos.DrawLine(from, Waypoints[0].position);
			}
			else
			{
				for (int i = 0; i < Waypoints.Length; i++)
				{
					Vector3 position = Waypoints[(i + 1) % Waypoints.Length].position;
					Gizmos.DrawLine(from, position);
					from = position;
				}
			}
		}
	}
	public class WaypointProgressTracker : MonoBehaviour
	{
		public enum ProgressStyle
		{
			SmoothAlongRoute,
			PointToPoint
		}

		[SerializeField]
		private WaypointCircuit circuit;

		[SerializeField]
		private float lookAheadForTargetOffset = 5f;

		[SerializeField]
		private float lookAheadForTargetFactor = 0.1f;

		[SerializeField]
		private float lookAheadForSpeedOffset = 10f;

		[SerializeField]
		private float lookAheadForSpeedFactor = 0.2f;

		[SerializeField]
		private ProgressStyle progressStyle;

		[SerializeField]
		private float pointToPointThreshold = 4f;

		public Transform target;

		private float progressDistance;

		private int progressNum;

		private Vector3 lastPosition;

		private float speed;

		public WaypointCircuit.RoutePoint targetPoint { get; private set; }

		public WaypointCircuit.RoutePoint speedPoint { get; private set; }

		public WaypointCircuit.RoutePoint progressPoint { get; private set; }

		private void Start()
		{
			if (target == null)
			{
				target = new GameObject(base.name + " Waypoint Target").transform;
			}
			Reset();
		}

		public void Reset()
		{
			progressDistance = 0f;
			progressNum = 0;
			if (progressStyle == ProgressStyle.PointToPoint)
			{
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
			}
		}

		private void Update()
		{
			if (progressStyle == ProgressStyle.SmoothAlongRoute)
			{
				if (Time.deltaTime > 0f)
				{
					speed = Mathf.Lerp(speed, (lastPosition - base.transform.position).magnitude / Time.deltaTime, Time.deltaTime);
				}
				target.position = circuit.GetRoutePoint(progressDistance + lookAheadForTargetOffset + lookAheadForTargetFactor * speed).position;
				target.rotation = Quaternion.LookRotation(circuit.GetRoutePoint(progressDistance + lookAheadForSpeedOffset + lookAheadForSpeedFactor * speed).direction);
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs, progressPoint.direction) < 0f)
				{
					progressDistance += lhs.magnitude * 0.5f;
				}
				lastPosition = base.transform.position;
			}
			else
			{
				if ((target.position - base.transform.position).magnitude < pointToPointThreshold)
				{
					progressNum = (progressNum + 1) % circuit.Waypoints.Length;
				}
				target.position = circuit.Waypoints[progressNum].position;
				target.rotation = circuit.Waypoints[progressNum].rotation;
				progressPoint = circuit.GetRoutePoint(progressDistance);
				Vector3 lhs2 = progressPoint.position - base.transform.position;
				if (Vector3.Dot(lhs2, progressPoint.direction) < 0f)
				{
					progressDistance += lhs2.magnitude;
				}
				lastPosition = base.transform.position;
			}
		}

		private void OnDrawGizmos()
		{
			if (Application.isPlaying)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawLine(base.transform.position, target.position);
				Gizmos.DrawWireSphere(circuit.GetRoutePosition(progressDistance), 1f);
				Gizmos.color = Color.yellow;
				Gizmos.DrawLine(target.position, target.position + target.forward);
			}
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[RequireComponent(typeof(SphereCollider))]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		public float effectAngle = 15f;

		public float effectWidth = 1f;

		public float effectDistance = 10f;

		public float force = 10f;

		private Collider[] m_Cols;

		private SphereCollider m_Sphere;

		private void OnEnable()
		{
			m_Sphere = GetComponent<Collider>() as SphereCollider;
		}

		private void FixedUpdate()
		{
			m_Cols = Physics.OverlapSphere(base.transform.position + m_Sphere.center, m_Sphere.radius);
			for (int i = 0; i < m_Cols.Length; i++)
			{
				if (m_Cols[i].attachedRigidbody != null)
				{
					Vector3 current = base.transform.InverseTransformPoint(m_Cols[i].transform.position);
					current = Vector3.MoveTowards(current, new Vector3(0f, 0f, current.z), effectWidth * 0.5f);
					float value = Mathf.Abs(Mathf.Atan2(current.x, current.z) * 57.29578f);
					float num = Mathf.InverseLerp(effectDistance, 0f, current.magnitude);
					num *= Mathf.InverseLerp(effectAngle, 0f, value);
					Vector3 vector = m_Cols[i].transform.position - base.transform.position;
					m_Cols[i].attachedRigidbody.AddForceAtPosition(vector.normalized * force * num, Vector3.Lerp(m_Cols[i].transform.position, base.transform.TransformPoint(0f, 0f, current.z), 0.1f));
				}
			}
		}

		private void OnDrawGizmosSelected()
		{
			if (m_Sphere == null)
			{
				m_Sphere = GetComponent<Collider>() as SphereCollider;
			}
			m_Sphere.radius = effectDistance * 0.5f;
			m_Sphere.center = new Vector3(0f, 0f, effectDistance * 0.5f);
			Vector3[] array = new Vector3[4]
			{
				Vector3.up,
				-Vector3.up,
				Vector3.right,
				-Vector3.right
			};
			Vector3[] array2 = new Vector3[4]
			{
				-Vector3.right,
				Vector3.right,
				Vector3.up,
				-Vector3.up
			};
			Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
			for (int i = 0; i < 4; i++)
			{
				Vector3 vector = base.transform.position + base.transform.rotation * array[i] * effectWidth * 0.5f;
				Vector3 vector2 = base.transform.TransformDirection(Quaternion.AngleAxis(effectAngle, array2[i]) * Vector3.forward);
				Gizmos.DrawLine(vector, vector + vector2 * m_Sphere.radius * 2f);
			}
		}
	}
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		public Transform[] debrisPrefabs;

		public Transform firePrefab;

		public int numDebrisPieces;

		public int numFires;

		private IEnumerator Start()
		{
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			for (int i = 0; (float)i < (float)numDebrisPieces * multiplier; i++)
			{
				Transform original = debrisPrefabs[UnityEngine.Random.Range(0, debrisPrefabs.Length)];
				Vector3 position = base.transform.position + UnityEngine.Random.insideUnitSphere * 3f * multiplier;
				Quaternion rotation = UnityEngine.Random.rotation;
				UnityEngine.Object.Instantiate(original, position, rotation);
			}
			yield return null;
			float num = 10f * multiplier;
			Collider[] array = Physics.OverlapSphere(base.transform.position, num);
			foreach (Collider collider in array)
			{
				if (numFires > 0)
				{
					Ray ray = new Ray(base.transform.position, collider.transform.position - base.transform.position);
					if (collider.Raycast(ray, out var hitInfo, num))
					{
						AddFire(collider.transform, hitInfo.point, hitInfo.normal);
						numFires--;
					}
				}
			}
			float num2 = 0f;
			while (numFires > 0 && num2 < num)
			{
				if (Physics.Raycast(new Ray(base.transform.position + Vector3.up, UnityEngine.Random.onUnitSphere), out var hitInfo2, num2))
				{
					AddFire(null, hitInfo2.point, hitInfo2.normal);
					numFires--;
				}
				num2 += num * 0.1f;
			}
		}

		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
			pos += normal * 0.5f;
			UnityEngine.Object.Instantiate(firePrefab, pos, Quaternion.identity).parent = t;
		}
	}
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		public float explosionForce = 4f;

		private IEnumerator Start()
		{
			yield return null;
			float multiplier = GetComponent<ParticleSystemMultiplier>().multiplier;
			float num = 10f * multiplier;
			Collider[] array = Physics.OverlapSphere(base.transform.position, num);
			List<Rigidbody> list = new List<Rigidbody>();
			Collider[] array2 = array;
			foreach (Collider collider in array2)
			{
				if (collider.attachedRigidbody != null && !list.Contains(collider.attachedRigidbody))
				{
					list.Add(collider.attachedRigidbody);
				}
			}
			foreach (Rigidbody item in list)
			{
				item.AddExplosionForce(explosionForce * multiplier, base.transform.position, num, 1f * multiplier, ForceMode.Impulse);
			}
		}
	}
	public class Explosive : MonoBehaviour
	{
		public Transform explosionPrefab;

		public float detonationImpactVelocity = 10f;

		public float sizeMultiplier = 1f;

		public bool reset = true;

		public float resetTimeDelay = 10f;

		private bool m_Exploded;

		private ObjectResetter m_ObjectResetter;

		private void Start()
		{
			m_ObjectResetter = GetComponent<ObjectResetter>();
		}

		private IEnumerator OnCollisionEnter(Collision col)
		{
			if (base.enabled && col.contacts.Length != 0 && (Vector3.Project(col.relativeVelocity, col.contacts[0].normal).magnitude > detonationImpactVelocity || m_Exploded) && !m_Exploded)
			{
				UnityEngine.Object.Instantiate(explosionPrefab, col.contacts[0].point, Quaternion.LookRotation(col.contacts[0].normal));
				m_Exploded = true;
				SendMessage("Immobilize");
				if (reset)
				{
					m_ObjectResetter.DelayedReset(resetTimeDelay);
				}
			}
			yield return null;
		}

		public void Reset()
		{
			m_Exploded = false;
		}
	}
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		public float multiplier = 1f;

		private ParticleSystem[] m_Systems;

		private void Start()
		{
			m_Systems = GetComponentsInChildren<ParticleSystem>();
		}

		public void Extinguish()
		{
			ParticleSystem[] systems = m_Systems;
			for (int i = 0; i < systems.Length; i++)
			{
				ParticleSystem.EmissionModule emission = systems[i].emission;
				emission.enabled = false;
			}
		}
	}
	public class FireLight : MonoBehaviour
	{
		private float m_Rnd;

		private bool m_Burning = true;

		private Light m_Light;

		private void Start()
		{
			m_Rnd = UnityEngine.Random.value * 100f;
			m_Light = GetComponent<Light>();
		}

		private void Update()
		{
			if (m_Burning)
			{
				m_Light.intensity = 2f * Mathf.PerlinNoise(m_Rnd + Time.time, m_Rnd + 1f + Time.time * 1f);
				float x = Mathf.PerlinNoise(m_Rnd + 0f + Time.time * 2f, m_Rnd + 1f + Time.time * 2f) - 0.5f;
				float y = Mathf.PerlinNoise(m_Rnd + 2f + Time.time * 2f, m_Rnd + 3f + Time.time * 2f) - 0.5f;
				float z = Mathf.PerlinNoise(m_Rnd + 4f + Time.time * 2f, m_Rnd + 5f + Time.time * 2f) - 0.5f;
				base.transform.localPosition = Vector3.up + new Vector3(x, y, z) * 1f;
			}
		}

		public void Extinguish()
		{
			m_Burning = false;
			m_Light.enabled = false;
		}
	}
	public class Hose : MonoBehaviour
	{
		public float maxPower = 20f;

		public float minPower = 5f;

		public float changeSpeed = 5f;

		public ParticleSystem[] hoseWaterSystems;

		public Renderer systemRenderer;

		private float m_Power;

		private void Update()
		{
			m_Power = Mathf.Lerp(m_Power, Input.GetMouseButton(0) ? maxPower : minPower, Time.deltaTime * changeSpeed);
			if (Input.GetKeyDown(KeyCode.Alpha1))
			{
				systemRenderer.enabled = !systemRenderer.enabled;
			}
			ParticleSystem[] array = hoseWaterSystems;
			foreach (ParticleSystem obj in array)
			{
				obj.startSpeed = m_Power;
				ParticleSystem.EmissionModule emission = obj.emission;
				emission.enabled = m_Power > minPower * 1.1f;
			}
		}
	}
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		public float multiplier = 1f;

		private void Start()
		{
			ParticleSystem[] componentsInChildren = GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem obj in componentsInChildren)
			{
				obj.startSize *= multiplier;
				obj.startSpeed *= multiplier;
				obj.startLifetime *= Mathf.Lerp(multiplier, 1f, 0.5f);
				obj.Clear();
				obj.Play();
			}
		}
	}
	public class SmokeParticles : MonoBehaviour
	{
		public AudioClip[] extinguishSounds;

		private void Start()
		{
			GetComponent<AudioSource>().clip = extinguishSounds[UnityEngine.Random.Range(0, extinguishSounds.Length)];
			GetComponent<AudioSource>().Play();
		}
	}
	public class WaterHoseParticles : MonoBehaviour
	{
		public static float lastSoundTime;

		public float force = 1f;

		private List<ParticleCollisionEvent> m_CollisionEvents = new List<ParticleCollisionEvent>();

		private ParticleSystem m_ParticleSystem;

		private void Start()
		{
			m_ParticleSystem = GetComponent<ParticleSystem>();
		}

		private void OnParticleCollision(GameObject other)
		{
			int collisionEvents = m_ParticleSystem.GetCollisionEvents(other, m_CollisionEvents);
			for (int i = 0; i < collisionEvents; i++)
			{
				if (Time.time > lastSoundTime + 0.2f)
				{
					lastSoundTime = Time.time;
				}
				Rigidbody component = m_CollisionEvents[i].colliderComponent.GetComponent<Rigidbody>();
				if (component != null)
				{
					Vector3 velocity = m_CollisionEvents[i].velocity;
					component.AddForce(velocity * force, ForceMode.Impulse);
				}
				other.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public Color bloomThresholdColor = Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((from == to) ? null : from, to, screenBlend, (from == to) ? 7 : 3);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture obj = ((i == 0) ? temporary3 : temporary2);
				Graphics.Blit(obj, temporary4, separableBlurMaterial);
				obj.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution == Resolution.Low) ? 4 : 2);
			float num2 = ((resolution == Resolution.Low) ? 0.5f : 1f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, "");
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public Color selectiveFromColor = Color.white;

		public Color selectiveToColor = Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = "";

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = "";
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			if (tex2d.height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					UnityEngine.Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = "";
					return;
				}
				Color[] pixels = temp2DTex.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				UnityEngine.Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		[Range(0f, 0.999f)]
		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		[Range(0f, 1f)]
		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 0.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		private Camera cachedCamera;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			cachedCamera = GetComponent<Camera>();
			cachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return cachedCamera.WorldToViewportPoint((worldDist - cachedCamera.nearClipPlane) * cachedCamera.transform.forward + cachedCamera.transform.position).z / (cachedCamera.farClipPlane - cachedCamera.nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = (focalTransform ? (cachedCamera.WorldToViewportPoint(focalTransform.position).z / cachedCamera.farClipPlane) : FocalDistance01(focalLength));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, 1f / (1f - aperture) - 1f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((internalBlurWidth < 0.1f) ? 0.1f : internalBlurWidth);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", nearBlur ? renderTexture4 : null);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirectNow(MeshTopology.Points, cbDrawArgs);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirectNow(MeshTopology.Points, cbDrawArgs);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount == BlurSampleCount.High || blurSampleCount == BlurSampleCount.Medium) ? 17 : 11);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount == BlurSampleCount.High) ? 18 : 12);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = (bokeh ? BOKEH_EXTRA_BLUR : 1f);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = (objectFocus ? (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane) : FocalDistance01(focalPoint));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4(simpleTweakMode ? (1f / focalStartCurve) : focalStartCurve, simpleTweakMode ? (1f / focalEndCurve) : focalEndCurve, num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, flag ? foregroundTexture : destination, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public Color edgesOnlyBgColor = Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 0.5f;
			Vector3 vector = transform.right * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f)) * aspect;
			Vector3 vector2 = transform.up * nearClipPlane * Mathf.Tan(num * ((float)Math.PI / 180f));
			Vector3 vector3 = transform.forward * nearClipPlane - vector + vector2;
			float num2 = vector3.magnitude * farClipPlane / nearClipPlane;
			vector3.Normalize();
			vector3 *= num2;
			Vector3 vector4 = transform.forward * nearClipPlane + vector + vector2;
			vector4.Normalize();
			vector4 *= num2;
			Vector3 vector5 = transform.forward * nearClipPlane + vector - vector2;
			vector5.Normalize();
			vector5 *= num2;
			Vector3 vector6 = transform.forward * nearClipPlane - vector - vector2;
			vector6.Normalize();
			vector6 *= num2;
			identity.SetRow(0, vector3);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector5);
			identity.SetRow(3, vector6);
			Vector3 position = transform.position;
			float num3 = position.y - height;
			float z = ((num3 <= 0f) ? 1f : 0f);
			float y = (excludeFarPixels ? 1f : 2f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num3, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num4 = (flag ? (fogEndDistance - fogStartDistance) : 0f);
			float num5 = ((Mathf.Abs(num4) > 0.0001f) ? (1f / num4) : 0f);
			Vector4 value = default(Vector4);
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = (flag ? (0f - num5) : 0f);
			value.w = (flag ? (fogEndDistance * num5) : 0f);
			fogMaterial.SetVector("_SceneFogParams", value);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num6 = 0;
			CustomGraphicsBlit(passNr: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, fxMaterial: fogMaterial);
		}

		private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
		{
			RenderTexture.active = dest;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			GL.MultiTexCoord2(0, 0f, 0f);
			GL.Vertex3(0f, 0f, 3f);
			GL.MultiTexCoord2(0, 1f, 0f);
			GL.Vertex3(1f, 0f, 2f);
			GL.MultiTexCoord2(0, 1f, 1f);
			GL.Vertex3(1f, 1f, 1f);
			GL.MultiTexCoord2(0, 0f, 1f);
			GL.Vertex3(0f, 1f, 0f);
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					UnityEngine.Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, monochrome ? 3 : 2);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", monochrome ? (Vector3.one * monochromeTiling) : tiling);
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if ((bool)m2Create)
			{
				return m2Create;
			}
			return null;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				UnityEngine.Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			m2Create.hideFlags = HideFlags.DontSave;
			if ((bool)m2Create)
			{
				return m2Create;
			}
			return null;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			UnityEngine.Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			UnityEngine.Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			UnityEngine.Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			UnityEngine.Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				array[num + 3] = (array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f))));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array2[num + 3] = new Vector2(1f, 1f);
				array3[num] = new Vector2(num4, num5);
				array3[num + 1] = new Vector2(num4, num5);
				array3[num + 2] = new Vector2(num4, num5);
				array3[num + 3] = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", value);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Matrix4x4 projectionMatrix = GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / ((float)Screen.width * projectionMatrix[0]), -2f / ((float)Screen.height * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			aoMaterial.SetVector("_ProjInfo", value);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public Color sunColor = Color.white;

		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = (GetComponent<Camera>().allowHDR ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (maxBlurSize < 0f) ? 0f : maxBlurSize);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode == TiltShiftMode.TiltShiftMode) ? num : (num + 1));
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 6);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((exposureAdjustment < 0.001f) ? 0.001f : exposureAdjustment);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((adaptionSpeed < 0.001f) ? 0.001f : adaptionSpeed);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, flag ? 3 : 2);
			middleGrey = ((middleGrey < 0.001f) ? 0.001f : middleGrey);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				UnityEngine.Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f)));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array3[num] = new Vector2(num3, num4);
				array3[num + 1] = new Vector2(num3, num4);
				array3[num + 2] = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.036f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - intensity) - 1f);
				m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - blur) - 1f);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : source, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public string axisName = "Horizontal";

		public float axisValue = 1f;

		public float responseSpeed = 3f;

		public float returnToCentreSpeed = 3f;

		private AxisTouchButton m_PairedWith;

		private CrossPlatformInputManager.VirtualAxis m_Axis;

		private void OnEnable()
		{
			if (!CrossPlatformInputManager.AxisExists(axisName))
			{
				m_Axis = new CrossPlatformInputManager.VirtualAxis(axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_Axis);
			}
			else
			{
				m_Axis = CrossPlatformInputManager.VirtualAxisReference(axisName);
			}
			FindPairedButton();
		}

		private void FindPairedButton()
		{
			if (!(UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) is AxisTouchButton[] array))
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].axisName == axisName && array[i] != this)
				{
					m_PairedWith = array[i];
				}
			}
		}

		private void OnDisable()
		{
			m_Axis.Remove();
		}

		public void OnPointerDown(PointerEventData data)
		{
			if (m_PairedWith == null)
			{
				FindPairedButton();
			}
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, axisValue, responseSpeed * Time.deltaTime));
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Axis.Update(Mathf.MoveTowards(m_Axis.GetValue, 0f, responseSpeed * Time.deltaTime));
		}
	}
	public class ButtonHandler : MonoBehaviour
	{
		public string Name;

		private void OnEnable()
		{
		}

		public void SetDownState()
		{
			CrossPlatformInputManager.SetButtonDown(Name);
		}

		public void SetUpState()
		{
			CrossPlatformInputManager.SetButtonUp(Name);
		}

		public void SetAxisPositiveState()
		{
			CrossPlatformInputManager.SetAxisPositive(Name);
		}

		public void SetAxisNeutralState()
		{
			CrossPlatformInputManager.SetAxisZero(Name);
		}

		public void SetAxisNegativeState()
		{
			CrossPlatformInputManager.SetAxisNegative(Name);
		}

		public void Update()
		{
		}
	}
	public static class CrossPlatformInputManager
	{
		public enum ActiveInputMethod
		{
			Hardware,
			Touch
		}

		public class VirtualAxis
		{
			private float m_Value;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public float GetValue => m_Value;

			public float GetValueRaw => m_Value;

			public VirtualAxis(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualAxis(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Remove()
			{
				UnRegisterVirtualAxis(name);
			}

			public void Update(float value)
			{
				m_Value = value;
			}
		}

		public class VirtualButton
		{
			private int m_LastPressedFrame = -5;

			private int m_ReleasedFrame = -5;

			private bool m_Pressed;

			public string name { get; private set; }

			public bool matchWithInputManager { get; private set; }

			public bool GetButton => m_Pressed;

			public bool GetButtonDown => m_LastPressedFrame - Time.frameCount == -1;

			public bool GetButtonUp => m_ReleasedFrame == Time.frameCount - 1;

			public VirtualButton(string name)
				: this(name, matchToInputSettings: true)
			{
			}

			public VirtualButton(string name, bool matchToInputSettings)
			{
				this.name = name;
				matchWithInputManager = matchToInputSettings;
			}

			public void Pressed()
			{
				if (!m_Pressed)
				{
					m_Pressed = true;
					m_LastPressedFrame = Time.frameCount;
				}
			}

			public void Released()
			{
				m_Pressed = false;
				m_ReleasedFrame = Time.frameCount;
			}

			public void Remove()
			{
				UnRegisterVirtualButton(name);
			}
		}

		private static VirtualInput activeInput;

		private static VirtualInput s_TouchInput;

		private static VirtualInput s_HardwareInput;

		public static Vector3 mousePosition => activeInput.MousePosition();

		static CrossPlatformInputManager()
		{
			s_TouchInput = new MobileInput();
			s_HardwareInput = new StandaloneInput();
			activeInput = s_HardwareInput;
		}

		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
			switch (activeInputMethod)
			{
			case ActiveInputMethod.Hardware:
				activeInput = s_HardwareInput;
				break;
			case ActiveInputMethod.Touch:
				activeInput = s_TouchInput;
				break;
			}
		}

		public static bool AxisExists(string name)
		{
			return activeInput.AxisExists(name);
		}

		public static bool ButtonExists(string name)
		{
			return activeInput.ButtonExists(name);
		}

		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
			activeInput.RegisterVirtualAxis(axis);
		}

		public static void RegisterVirtualButton(VirtualButton button)
		{
			activeInput.RegisterVirtualButton(button);
		}

		public static void UnRegisterVirtualAxis(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			activeInput.UnRegisterVirtualAxis(name);
		}

		public static void UnRegisterVirtualButton(string name)
		{
			activeInput.UnRegisterVirtualButton(name);
		}

		public static VirtualAxis VirtualAxisReference(string name)
		{
			return activeInput.VirtualAxisReference(name);
		}

		public static float GetAxis(string name)
		{
			return GetAxis(name, raw: false);
		}

		public static float GetAxisRaw(string name)
		{
			return GetAxis(name, raw: true);
		}

		private static float GetAxis(string name, bool raw)
		{
			return activeInput.GetAxis(name, raw);
		}

		public static bool GetButton(string name)
		{
			return activeInput.GetButton(name);
		}

		public static bool GetButtonDown(string name)
		{
			return activeInput.GetButtonDown(name);
		}

		public static bool GetButtonUp(string name)
		{
			return activeInput.GetButtonUp(name);
		}

		public static void SetButtonDown(string name)
		{
			activeInput.SetButtonDown(name);
		}

		public static void SetButtonUp(string name)
		{
			activeInput.SetButtonUp(name);
		}

		public static void SetAxisPositive(string name)
		{
			activeInput.SetAxisPositive(name);
		}

		public static void SetAxisNegative(string name)
		{
			activeInput.SetAxisNegative(name);
		}

		public static void SetAxisZero(string name)
		{
			activeInput.SetAxisZero(name);
		}

		public static void SetAxis(string name, float value)
		{
			activeInput.SetAxis(name, value);
		}

		public static void SetVirtualMousePositionX(float f)
		{
			activeInput.SetVirtualMousePositionX(f);
		}

		public static void SetVirtualMousePositionY(float f)
		{
			activeInput.SetVirtualMousePositionY(f);
		}

		public static void SetVirtualMousePositionZ(float f)
		{
			activeInput.SetVirtualMousePositionZ(f);
		}
	}
	public class InputAxisScrollbar : MonoBehaviour
	{
		public string axis;

		private void Update()
		{
		}

		public void HandleInput(float value)
		{
			CrossPlatformInputManager.SetAxis(axis, value * 2f - 1f);
		}
	}
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public int MovementRange = 100;

		public AxisOption axesToUse;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		private Vector3 m_StartPos;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_StartPos = base.transform.position;
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			Vector3 vector = m_StartPos - value;
			vector.y = 0f - vector.y;
			vector /= (float)MovementRange;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(0f - vector.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(vector.y);
			}
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		public void OnDrag(PointerEventData data)
		{
			Vector3 zero = Vector3.zero;
			if (m_UseX)
			{
				int value = (int)(data.position.x - m_StartPos.x);
				value = Mathf.Clamp(value, -MovementRange, MovementRange);
				zero.x = value;
			}
			if (m_UseY)
			{
				int value2 = (int)(data.position.y - m_StartPos.y);
				value2 = Mathf.Clamp(value2, -MovementRange, MovementRange);
				zero.y = value2;
			}
			base.transform.position = new Vector3(m_StartPos.x + zero.x, m_StartPos.y + zero.y, m_StartPos.z + zero.z);
			UpdateVirtualAxes(base.transform.position);
		}

		public void OnPointerUp(PointerEventData data)
		{
			base.transform.position = m_StartPos;
			UpdateVirtualAxes(m_StartPos);
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		private void OnDisable()
		{
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Remove();
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Remove();
			}
		}
	}
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		private void OnEnable()
		{
			CheckEnableControlRig();
		}

		private void Start()
		{
			if (UnityEngine.Object.FindObjectOfType<EventSystem>() == null)
			{
				GameObject obj = new GameObject("EventSystem");
				obj.AddComponent<EventSystem>();
				obj.AddComponent<StandaloneInputModule>();
			}
		}

		private void CheckEnableControlRig()
		{
			EnableControlRig(enabled: false);
		}

		private void EnableControlRig(bool enabled)
		{
			foreach (Transform item in base.transform)
			{
				item.gameObject.SetActive(enabled);
			}
		}
	}
	public class TiltInput : MonoBehaviour
	{
		public enum AxisOptions
		{
			ForwardAxis,
			SidewaysAxis
		}

		[Serializable]
		public class AxisMapping
		{
			public enum MappingType
			{
				NamedAxis,
				MousePositionX,
				MousePositionY,
				MousePositionZ
			}

			public MappingType type;

			public string axisName;
		}

		public AxisMapping mapping;

		public AxisOptions tiltAroundAxis;

		public float fullTiltAngle = 25f;

		public float centreAngleOffset;

		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		private void OnEnable()
		{
			if (mapping.type == AxisMapping.MappingType.NamedAxis)
			{
				m_SteerAxis = new CrossPlatformInputManager.VirtualAxis(mapping.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_SteerAxis);
			}
		}

		private void Update()
		{
			float value = 0f;
			if (Input.acceleration != Vector3.zero)
			{
				switch (tiltAroundAxis)
				{
				case AxisOptions.ForwardAxis:
					value = Mathf.Atan2(Input.acceleration.x, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				case AxisOptions.SidewaysAxis:
					value = Mathf.Atan2(Input.acceleration.z, 0f - Input.acceleration.y) * 57.29578f + centreAngleOffset;
					break;
				}
			}
			float num = Mathf.InverseLerp(0f - fullTiltAngle, fullTiltAngle, value) * 2f - 1f;
			switch (mapping.type)
			{
			case AxisMapping.MappingType.NamedAxis:
				m_SteerAxis.Update(num);
				break;
			case AxisMapping.MappingType.MousePositionX:
				CrossPlatformInputManager.SetVirtualMousePositionX(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionY:
				CrossPlatformInputManager.SetVirtualMousePositionY(num * (float)Screen.width);
				break;
			case AxisMapping.MappingType.MousePositionZ:
				CrossPlatformInputManager.SetVirtualMousePositionZ(num * (float)Screen.width);
				break;
			}
		}

		private void OnDisable()
		{
			m_SteerAxis.Remove();
		}
	}
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		public enum AxisOption
		{
			Both,
			OnlyHorizontal,
			OnlyVertical
		}

		public enum ControlStyle
		{
			Absolute,
			Relative,
			Swipe
		}

		public AxisOption axesToUse;

		public ControlStyle controlStyle;

		public string horizontalAxisName = "Horizontal";

		public string verticalAxisName = "Vertical";

		public float Xsensitivity = 1f;

		public float Ysensitivity = 1f;

		private Vector3 m_StartPos;

		private Vector2 m_PreviousDelta;

		private Vector3 m_JoytickOutput;

		private bool m_UseX;

		private bool m_UseY;

		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		private bool m_Dragging;

		private int m_Id = -1;

		private Vector2 m_PreviousTouchPos;

		private Vector3 m_Center;

		private Image m_Image;

		private void OnEnable()
		{
			CreateVirtualAxes();
		}

		private void Start()
		{
			m_Image = GetComponent<Image>();
			m_Center = m_Image.transform.position;
		}

		private void CreateVirtualAxes()
		{
			m_UseX = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyHorizontal;
			m_UseY = axesToUse == AxisOption.Both || axesToUse == AxisOption.OnlyVertical;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(m_VerticalVirtualAxis);
			}
		}

		private void UpdateVirtualAxes(Vector3 value)
		{
			value = value.normalized;
			if (m_UseX)
			{
				m_HorizontalVirtualAxis.Update(value.x);
			}
			if (m_UseY)
			{
				m_VerticalVirtualAxis.Update(value.y);
			}
		}

		public void OnPointerDown(PointerEventData data)
		{
			m_Dragging = true;
			m_Id = data.pointerId;
			if (controlStyle != 0)
			{
				m_Center = data.position;
			}
		}

		private void Update()
		{
			if (m_Dragging && Input.touchCount >= m_Id + 1 && m_Id != -1)
			{
				if (controlStyle == ControlStyle.Swipe)
				{
					m_Center = m_PreviousTouchPos;
					m_PreviousTouchPos = Input.touches[m_Id].position;
				}
				Vector2 normalized = new Vector2(Input.touches[m_Id].position.x - m_Center.x, Input.touches[m_Id].position.y - m_Center.y).normalized;
				normalized.x *= Xsensitivity;
				normalized.y *= Ysensitivity;
				UpdateVirtualAxes(new Vector3(normalized.x, normalized.y, 0f));
			}
		}

		public void OnPointerUp(PointerEventData data)
		{
			m_Dragging = false;
			m_Id = -1;
			UpdateVirtualAxes(Vector3.zero);
		}

		private void OnDisable()
		{
			if (CrossPlatformInputManager.AxisExists(horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(verticalAxisName);
			}
		}
	}
	public abstract class VirtualInput
	{
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes = new Dictionary<string, CrossPlatformInputManager.VirtualAxis>();

		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons = new Dictionary<string, CrossPlatformInputManager.VirtualButton>();

		protected List<string> m_AlwaysUseVirtual = new List<string>();

		public Vector3 virtualMousePosition { get; private set; }

		public bool AxisExists(string name)
		{
			return m_VirtualAxes.ContainsKey(name);
		}

		public bool ButtonExists(string name)
		{
			return m_VirtualButtons.ContainsKey(name);
		}

		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
			if (m_VirtualAxes.ContainsKey(axis.name))
			{
				UnityEngine.Debug.LogError("There is already a virtual axis named " + axis.name + " registered.");
				return;
			}
			m_VirtualAxes.Add(axis.name, axis);
			if (!axis.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(axis.name);
			}
		}

		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
			if (m_VirtualButtons.ContainsKey(button.name))
			{
				UnityEngine.Debug.LogError("There is already a virtual button named " + button.name + " registered.");
				return;
			}
			m_VirtualButtons.Add(button.name, button);
			if (!button.matchWithInputManager)
			{
				m_AlwaysUseVirtual.Add(button.name);
			}
		}

		public void UnRegisterVirtualAxis(string name)
		{
			if (m_VirtualAxes.ContainsKey(name))
			{
				m_VirtualAxes.Remove(name);
			}
		}

		public void UnRegisterVirtualButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				m_VirtualButtons.Remove(name);
			}
		}

		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				return null;
			}
			return m_VirtualAxes[name];
		}

		public void SetVirtualMousePositionX(float f)
		{
			virtualMousePosition = new Vector3(f, virtualMousePosition.y, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionY(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, f, virtualMousePosition.z);
		}

		public void SetVirtualMousePositionZ(float f)
		{
			virtualMousePosition = new Vector3(virtualMousePosition.x, virtualMousePosition.y, f);
		}

		public abstract float GetAxis(string name, bool raw);

		public abstract bool GetButton(string name);

		public abstract bool GetButtonDown(string name);

		public abstract bool GetButtonUp(string name);

		public abstract void SetButtonDown(string name);

		public abstract void SetButtonUp(string name);

		public abstract void SetAxisPositive(string name);

		public abstract void SetAxisNegative(string name);

		public abstract void SetAxisZero(string name);

		public abstract void SetAxis(string name, float value);

		public abstract Vector3 MousePosition();
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	public class MobileInput : VirtualInput
	{
		private void AddButton(string name)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(name));
		}

		private void AddAxes(string name)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(name));
		}

		public override float GetAxis(string name, bool raw)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			return m_VirtualAxes[name].GetValue;
		}

		public override void SetButtonDown(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Pressed();
		}

		public override void SetButtonUp(string name)
		{
			if (!m_VirtualButtons.ContainsKey(name))
			{
				AddButton(name);
			}
			m_VirtualButtons[name].Released();
		}

		public override void SetAxisPositive(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(1f);
		}

		public override void SetAxisNegative(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(-1f);
		}

		public override void SetAxisZero(string name)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(0f);
		}

		public override void SetAxis(string name, float value)
		{
			if (!m_VirtualAxes.ContainsKey(name))
			{
				AddAxes(name);
			}
			m_VirtualAxes[name].Update(value);
		}

		public override bool GetButtonDown(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonDown;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonDown;
		}

		public override bool GetButtonUp(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButtonUp;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButtonUp;
		}

		public override bool GetButton(string name)
		{
			if (m_VirtualButtons.ContainsKey(name))
			{
				return m_VirtualButtons[name].GetButton;
			}
			AddButton(name);
			return m_VirtualButtons[name].GetButton;
		}

		public override Vector3 MousePosition()
		{
			return base.virtualMousePosition;
		}
	}
	public class StandaloneInput : VirtualInput
	{
		public override float GetAxis(string name, bool raw)
		{
			if (!raw)
			{
				return Input.GetAxis(name);
			}
			return Input.GetAxisRaw(name);
		}

		public override bool GetButton(string name)
		{
			return Input.GetButton(name);
		}

		public override bool GetButtonDown(string name)
		{
			return Input.GetButtonDown(name);
		}

		public override bool GetButtonUp(string name)
		{
			return Input.GetButtonUp(name);
		}

		public override void SetButtonDown(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetButtonUp(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisPositive(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisNegative(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxisZero(string name)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override void SetAxis(string name, float value)
		{
			throw new Exception(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		}

		public override Vector3 MousePosition()
		{
			return Input.mousePosition;
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	public class Ball : MonoBehaviour
	{
		[SerializeField]
		private float m_MovePower = 5f;

		[SerializeField]
		private bool m_UseTorque = true;

		[SerializeField]
		private float m_MaxAngularVelocity = 25f;

		[SerializeField]
		private float m_JumpPower = 2f;

		private const float k_GroundRayLength = 1f;

		private Rigidbody m_Rigidbody;

		private void Start()
		{
			m_Rigidbody = GetComponent<Rigidbody>();
			GetComponent<Rigidbody>().maxAngularVelocity = m_MaxAngularVelocity;
		}

		public void Move(Vector3 moveDirection, bool jump)
		{
			if (m_UseTorque)
			{
				m_Rigidbody.AddTorque(new Vector3(moveDirection.z, 0f, 0f - moveDirection.x) * m_MovePower);
			}
			else
			{
				m_Rigidbody.AddForce(moveDirection * m_MovePower);
			}
			if (Physics.Raycast(base.transform.position, -Vector3.up, 1f) && jump)
			{
				m_Rigidbody.AddForce(Vector3.up * m_JumpPower, ForceMode.Impulse);
			}
		}
	}
	public class BallUserControl : MonoBehaviour
	{
		private Ball ball;

		private Vector3 move;

		private Transform cam;

		private Vector3 camForward;

		private bool jump;

		private void Awake()
		{
			ball = GetComponent<Ball>();
			if (Camera.main != null)
			{
				cam = Camera.main.transform;
			}
			else
			{
				UnityEngine.Debug.LogWarning("Warning: no main camera found. Ball needs a Camera tagged \"MainCamera\", for camera-relative controls.");
			}
		}

		private void Update()
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			jump = CrossPlatformInputManager.GetButton("Jump");
			if (cam != null)
			{
				camForward = Vector3.Scale(cam.forward, new Vector3(1f, 0f, 1f)).normalized;
				move = (axis2 * camForward + axis * cam.right).normalized;
			}
			else
			{
				move = (axis2 * Vector3.forward + axis * Vector3.right).normalized;
			}
		}

		private void FixedUpdate()
		{
			ball.Move(move, jump);
			jump = false;
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class AICharacterControl : MonoBehaviour
	{
		public Transform target;

		public NavMeshAgent agent { get; private set; }

		public ThirdPersonCharacter character { get; private set; }

		private void Start()
		{
			agent = GetComponentInChildren<NavMeshAgent>();
			character = GetComponent<ThirdPersonCharacter>();
			agent.updateRotation = false;
			agent.updatePosition = true;
		}

		private void Update()
		{
			if (target != null)
			{
				agent.SetDestination(target.position);
			}
			if (agent.remainingDistance > agent.stoppingDistance)
			{
				character.Move(agent.desiredVelocity, crouch: false, jump: false);
			}
			else
			{
				character.Move(Vector3.zero, crouch: false, jump: false);
			}
		}

		public void SetTarget(Transform target)
		{
			this.target = target;
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Animator))]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[SerializeField]
		private float m_MovingTurnSpeed = 360f;

		[SerializeField]
		private float m_StationaryTurnSpeed = 180f;

		[SerializeField]
		private float m_JumpPower = 12f;

		[Range(1f, 4f)]
		[SerializeField]
		private float m_GravityMultiplier = 2f;

		[SerializeField]
		private float m_RunCycleLegOffset = 0.2f;

		[SerializeField]
		private float m_MoveSpeedMultiplier = 1f;

		[SerializeField]
		private float m_AnimSpeedMultiplier = 1f;

		[SerializeField]
		private float m_GroundCheckDistance = 0.1f;

		private Rigidbody m_Rigidbody;

		private Animator m_Animator;

		private bool m_IsGrounded;

		private float m_OrigGroundCheckDistance;

		private const float k_Half = 0.5f;

		private float m_TurnAmount;

		private float m_ForwardAmount;

		private Vector3 m_GroundNormal;

		private float m_CapsuleHeight;

		private Vector3 m_CapsuleCenter;

		private CapsuleCollider m_Capsule;

		private bool m_Crouching;

		private void Start()
		{
			m_Animator = GetComponent<Animator>();
			m_Rigidbody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			m_CapsuleHeight = m_Capsule.height;
			m_CapsuleCenter = m_Capsule.center;
			m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
			m_OrigGroundCheckDistance = m_GroundCheckDistance;
		}

		public void Move(Vector3 move, bool crouch, bool jump)
		{
			if (move.magnitude > 1f)
			{
				move.Normalize();
			}
			move = base.transform.InverseTransformDirection(move);
			CheckGroundStatus();
			move = Vector3.ProjectOnPlane(move, m_GroundNormal);
			m_TurnAmount = Mathf.Atan2(move.x, move.z);
			m_ForwardAmount = move.z;
			ApplyExtraTurnRotation();
			if (m_IsGrounded)
			{
				HandleGroundedMovement(crouch, jump);
			}
			else
			{
				HandleAirborneMovement();
			}
			ScaleCapsuleForCrouching(crouch);
			PreventStandingInLowHeadroom();
			UpdateAnimator(move);
		}

		private void ScaleCapsuleForCrouching(bool crouch)
		{
			if (m_IsGrounded && crouch)
			{
				if (!m_Crouching)
				{
					m_Capsule.height /= 2f;
					m_Capsule.center /= 2f;
					m_Crouching = true;
				}
			}
			else if (Physics.SphereCast(new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up), maxDistance: m_CapsuleHeight - m_Capsule.radius * 0.5f, radius: m_Capsule.radius * 0.5f, layerMask: -1, queryTriggerInteraction: QueryTriggerInteraction.Ignore))
			{
				m_Crouching = true;
			}
			else
			{
				m_Capsule.height = m_CapsuleHeight;
				m_Capsule.center = m_CapsuleCenter;
				m_Crouching = false;
			}
		}

		private void PreventStandingInLowHeadroom()
		{
			if (!m_Crouching && Physics.SphereCast(new Ray(m_Rigidbody.position + Vector3.up * m_Capsule.radius * 0.5f, Vector3.up), maxDistance: m_CapsuleHeight - m_Capsule.radius * 0.5f, radius: m_Capsule.radius * 0.5f, layerMask: -1, queryTriggerInteraction: QueryTriggerInteraction.Ignore))
			{
				m_Crouching = true;
			}
		}

		private void UpdateAnimator(Vector3 move)
		{
			m_Animator.SetFloat("Forward", m_ForwardAmount, 0.1f, Time.deltaTime);
			m_Animator.SetFloat("Turn", m_TurnAmount, 0.1f, Time.deltaTime);
			m_Animator.SetBool("Crouch", m_Crouching);
			m_Animator.SetBool("OnGround", m_IsGrounded);
			if (!m_IsGrounded)
			{
				m_Animator.SetFloat("Jump", m_Rigidbody.velocity.y);
			}
			float value = (float)((Mathf.Repeat(m_Animator.GetCurrentAnimatorStateInfo(0).normalizedTime + m_RunCycleLegOffset, 1f) < 0.5f) ? 1 : (-1)) * m_ForwardAmount;
			if (m_IsGrounded)
			{
				m_Animator.SetFloat("JumpLeg", value);
			}
			if (m_IsGrounded && move.magnitude > 0f)
			{
				m_Animator.speed = m_AnimSpeedMultiplier;
			}
			else
			{
				m_Animator.speed = 1f;
			}
		}

		private void HandleAirborneMovement()
		{
			Vector3 force = Physics.gravity * m_GravityMultiplier - Physics.gravity;
			m_Rigidbody.AddForce(force);
			m_GroundCheckDistance = ((m_Rigidbody.velocity.y < 0f) ? m_OrigGroundCheckDistance : 0.01f);
		}

		private void HandleGroundedMovement(bool crouch, bool jump)
		{
			if (jump && !crouch && m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
			{
				m_Rigidbody.velocity = new Vector3(m_Rigidbody.velocity.x, m_JumpPower, m_Rigidbody.velocity.z);
				m_IsGrounded = false;
				m_Animator.applyRootMotion = false;
				m_GroundCheckDistance = 0.1f;
			}
		}

		private void ApplyExtraTurnRotation()
		{
			float num = Mathf.Lerp(m_StationaryTurnSpeed, m_MovingTurnSpeed, m_ForwardAmount);
			base.transform.Rotate(0f, m_TurnAmount * num * Time.deltaTime, 0f);
		}

		public void OnAnimatorMove()
		{
			if (m_IsGrounded && Time.deltaTime > 0f)
			{
				Vector3 velocity = m_Animator.deltaPosition * m_MoveSpeedMultiplier / Time.deltaTime;
				velocity.y = m_Rigidbody.velocity.y;
				m_Rigidbody.velocity = velocity;
			}
		}

		private void CheckGroundStatus()
		{
			if (Physics.Raycast(base.transform.position + Vector3.up * 0.1f, Vector3.down, out var hitInfo, m_GroundCheckDistance))
			{
				m_GroundNormal = hitInfo.normal;
				m_IsGrounded = true;
				m_Animator.applyRootMotion = true;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundNormal = Vector3.up;
				m_Animator.applyRootMotion = false;
			}
		}
	}
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		private ThirdPersonCharacter m_Character;

		private Transform m_Cam;

		private Vector3 m_CamForward;

		private Vector3 m_Move;

		private bool m_Jump;

		private void Start()
		{
			if (Camera.main != null)
			{
				m_Cam = Camera.main.transform;
			}
			else
			{
				UnityEngine.Debug.LogWarning("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", base.gameObject);
			}
			m_Character = GetComponent<ThirdPersonCharacter>();
		}

		private void Update()
		{
			if (!m_Jump)
			{
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
		}

		private void FixedUpdate()
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			bool key = Input.GetKey(KeyCode.C);
			if (m_Cam != null)
			{
				m_CamForward = Vector3.Scale(m_Cam.forward, new Vector3(1f, 0f, 1f)).normalized;
				m_Move = axis2 * m_CamForward + axis * m_Cam.right;
			}
			else
			{
				m_Move = axis2 * Vector3.forward + axis * Vector3.right;
			}
			if (Input.GetKey(KeyCode.LeftShift))
			{
				m_Move *= 0.5f;
			}
			m_Character.Move(m_Move, key, m_Jump);
			m_Jump = false;
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[RequireComponent(typeof(CharacterController))]
	[RequireComponent(typeof(AudioSource))]
	public class FirstPersonController : MonoBehaviour
	{
		[SerializeField]
		private bool m_IsWalking;

		[SerializeField]
		private float m_WalkSpeed;

		[SerializeField]
		private float m_RunSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_RunstepLenghten;

		[SerializeField]
		private float m_JumpSpeed;

		[SerializeField]
		private float m_StickToGroundForce;

		[SerializeField]
		private float m_GravityMultiplier;

		[SerializeField]
		private MouseLook m_MouseLook;

		[SerializeField]
		private bool m_UseFovKick;

		[SerializeField]
		private FOVKick m_FovKick = new FOVKick();

		[SerializeField]
		private bool m_UseHeadBob;

		[SerializeField]
		private CurveControlledBob m_HeadBob = new CurveControlledBob();

		[SerializeField]
		private LerpControlledBob m_JumpBob = new LerpControlledBob();

		[SerializeField]
		private float m_StepInterval;

		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[SerializeField]
		private AudioClip m_JumpSound;

		[SerializeField]
		private AudioClip m_LandSound;

		private Camera m_Camera;

		private bool m_Jump;

		private float m_YRotation;

		private Vector2 m_Input;

		private Vector3 m_MoveDir = Vector3.zero;

		private CharacterController m_CharacterController;

		private CollisionFlags m_CollisionFlags;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private float m_StepCycle;

		private float m_NextStep;

		private bool m_Jumping;

		private AudioSource m_AudioSource;

		private void Start()
		{
			m_CharacterController = GetComponent<CharacterController>();
			m_Camera = Camera.main;
			m_OriginalCameraPosition = m_Camera.transform.localPosition;
			m_FovKick.Setup(m_Camera);
			m_HeadBob.Setup(m_Camera, m_StepInterval);
			m_StepCycle = 0f;
			m_NextStep = m_StepCycle / 2f;
			m_Jumping = false;
			m_AudioSource = GetComponent<AudioSource>();
			m_MouseLook.Init(base.transform, m_Camera.transform);
		}

		private void Update()
		{
			RotateView();
			if (!m_Jump)
			{
				m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			}
			if (!m_PreviouslyGrounded && m_CharacterController.isGrounded)
			{
				StartCoroutine(m_JumpBob.DoBobCycle());
				PlayLandingSound();
				m_MoveDir.y = 0f;
				m_Jumping = false;
			}
			if (!m_CharacterController.isGrounded && !m_Jumping && m_PreviouslyGrounded)
			{
				m_MoveDir.y = 0f;
			}
			m_PreviouslyGrounded = m_CharacterController.isGrounded;
		}

		private void PlayLandingSound()
		{
			m_AudioSource.clip = m_LandSound;
			m_AudioSource.Play();
			m_NextStep = m_StepCycle + 0.5f;
		}

		private void FixedUpdate()
		{
			GetInput(out var speed);
			Vector3 vector = base.transform.forward * m_Input.y + base.transform.right * m_Input.x;
			Physics.SphereCast(base.transform.position, m_CharacterController.radius, Vector3.down, out var hitInfo, m_CharacterController.height / 2f, -1, QueryTriggerInteraction.Ignore);
			vector = Vector3.ProjectOnPlane(vector, hitInfo.normal).normalized;
			m_MoveDir.x = vector.x * speed;
			m_MoveDir.z = vector.z * speed;
			if (m_CharacterController.isGrounded)
			{
				m_MoveDir.y = 0f - m_StickToGroundForce;
				if (m_Jump)
				{
					m_MoveDir.y = m_JumpSpeed;
					PlayJumpSound();
					m_Jump = false;
					m_Jumping = true;
				}
			}
			else
			{
				m_MoveDir += Physics.gravity * m_GravityMultiplier * Time.fixedDeltaTime;
			}
			m_CollisionFlags = m_CharacterController.Move(m_MoveDir * Time.fixedDeltaTime);
			ProgressStepCycle(speed);
			UpdateCameraPosition(speed);
			m_MouseLook.UpdateCursorLock();
		}

		private void PlayJumpSound()
		{
			m_AudioSource.clip = m_JumpSound;
			m_AudioSource.Play();
		}

		private void ProgressStepCycle(float speed)
		{
			if (m_CharacterController.velocity.sqrMagnitude > 0f && (m_Input.x != 0f || m_Input.y != 0f))
			{
				m_StepCycle += (m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten)) * Time.fixedDeltaTime;
			}
			if (m_StepCycle > m_NextStep)
			{
				m_NextStep = m_StepCycle + m_StepInterval;
				PlayFootStepAudio();
			}
		}

		private void PlayFootStepAudio()
		{
			if (m_CharacterController.isGrounded)
			{
				int num = UnityEngine.Random.Range(1, m_FootstepSounds.Length);
				m_AudioSource.clip = m_FootstepSounds[num];
				m_AudioSource.PlayOneShot(m_AudioSource.clip);
				m_FootstepSounds[num] = m_FootstepSounds[0];
				m_FootstepSounds[0] = m_AudioSource.clip;
			}
		}

		private void UpdateCameraPosition(float speed)
		{
			if (m_UseHeadBob)
			{
				Vector3 localPosition;
				if (m_CharacterController.velocity.magnitude > 0f && m_CharacterController.isGrounded)
				{
					m_Camera.transform.localPosition = m_HeadBob.DoHeadBob(m_CharacterController.velocity.magnitude + speed * (m_IsWalking ? 1f : m_RunstepLenghten));
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_Camera.transform.localPosition.y - m_JumpBob.Offset();
				}
				else
				{
					localPosition = m_Camera.transform.localPosition;
					localPosition.y = m_OriginalCameraPosition.y - m_JumpBob.Offset();
				}
				m_Camera.transform.localPosition = localPosition;
			}
		}

		private void GetInput(out float speed)
		{
			float axis = CrossPlatformInputManager.GetAxis("Horizontal");
			float axis2 = CrossPlatformInputManager.GetAxis("Vertical");
			bool isWalking = m_IsWalking;
			m_IsWalking = !Input.GetKey(KeyCode.LeftShift);
			speed = (m_IsWalking ? m_WalkSpeed : m_RunSpeed);
			m_Input = new Vector2(axis, axis2);
			if (m_Input.sqrMagnitude > 1f)
			{
				m_Input.Normalize();
			}
			if (m_IsWalking != isWalking && m_UseFovKick && m_CharacterController.velocity.sqrMagnitude > 0f)
			{
				StopAllCoroutines();
				StartCoroutine((!m_IsWalking) ? m_FovKick.FOVKickUp() : m_FovKick.FOVKickDown());
			}
		}

		private void RotateView()
		{
			m_MouseLook.LookRotation(base.transform, m_Camera.transform);
		}

		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
			Rigidbody attachedRigidbody = hit.collider.attachedRigidbody;
			if (m_CollisionFlags != CollisionFlags.Below && !(attachedRigidbody == null) && !attachedRigidbody.isKinematic)
			{
				attachedRigidbody.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
			}
		}
	}
	public class HeadBob : MonoBehaviour
	{
		public Camera Camera;

		public CurveControlledBob motionBob = new CurveControlledBob();

		public LerpControlledBob jumpAndLandingBob = new LerpControlledBob();

		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		public float StrideInterval;

		[Range(0f, 1f)]
		public float RunningStrideLengthen;

		private bool m_PreviouslyGrounded;

		private Vector3 m_OriginalCameraPosition;

		private void Start()
		{
			motionBob.Setup(Camera, StrideInterval);
			m_OriginalCameraPosition = Camera.transform.localPosition;
		}

		private void Update()
		{
			Vector3 localPosition;
			if (rigidbodyFirstPersonController.Velocity.magnitude > 0f && rigidbodyFirstPersonController.Grounded)
			{
				Camera.transform.localPosition = motionBob.DoHeadBob(rigidbodyFirstPersonController.Velocity.magnitude * (rigidbodyFirstPersonController.Running ? RunningStrideLengthen : 1f));
				localPosition = Camera.transform.localPosition;
				localPosition.y = Camera.transform.localPosition.y - jumpAndLandingBob.Offset();
			}
			else
			{
				localPosition = Camera.transform.localPosition;
				localPosition.y = m_OriginalCameraPosition.y - jumpAndLandingBob.Offset();
			}
			Camera.transform.localPosition = localPosition;
			if (!m_PreviouslyGrounded && rigidbodyFirstPersonController.Grounded)
			{
				StartCoroutine(jumpAndLandingBob.DoBobCycle());
			}
			m_PreviouslyGrounded = rigidbodyFirstPersonController.Grounded;
		}
	}
	[Serializable]
	public class MouseLook
	{
		public float XSensitivity = 2f;

		public float YSensitivity = 2f;

		public bool clampVerticalRotation = true;

		public float MinimumX = -90f;

		public float MaximumX = 90f;

		public bool smooth;

		public float smoothTime = 5f;

		public bool lockCursor = true;

		private Quaternion m_CharacterTargetRot;

		private Quaternion m_CameraTargetRot;

		private bool m_cursorIsLocked = true;

		public void Init(Transform character, Transform camera)
		{
			m_CharacterTargetRot = character.localRotation;
			m_CameraTargetRot = camera.localRotation;
		}

		public void LookRotation(Transform character, Transform camera)
		{
			float y = CrossPlatformInputManager.GetAxis("Mouse X") * XSensitivity;
			float num = CrossPlatformInputManager.GetAxis("Mouse Y") * YSensitivity;
			m_CharacterTargetRot *= Quaternion.Euler(0f, y, 0f);
			m_CameraTargetRot *= Quaternion.Euler(0f - num, 0f, 0f);
			if (clampVerticalRotation)
			{
				m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);
			}
			if (smooth)
			{
				character.localRotation = Quaternion.Slerp(character.localRotation, m_CharacterTargetRot, smoothTime * Time.deltaTime);
				camera.localRotation = Quaternion.Slerp(camera.localRotation, m_CameraTargetRot, smoothTime * Time.deltaTime);
			}
			else
			{
				character.localRotation = m_CharacterTargetRot;
				camera.localRotation = m_CameraTargetRot;
			}
			UpdateCursorLock();
		}

		public void SetCursorLock(bool value)
		{
			lockCursor = value;
			if (!lockCursor)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		public void UpdateCursorLock()
		{
			if (lockCursor)
			{
				InternalLockUpdate();
			}
		}

		private void InternalLockUpdate()
		{
			if (Input.GetKeyUp(KeyCode.Escape))
			{
				m_cursorIsLocked = false;
			}
			else if (Input.GetMouseButtonUp(0))
			{
				m_cursorIsLocked = true;
			}
			if (m_cursorIsLocked)
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
			else if (!m_cursorIsLocked)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}

		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			q.x /= q.w;
			q.y /= q.w;
			q.z /= q.w;
			q.w = 1f;
			float value = 114.59156f * Mathf.Atan(q.x);
			value = Mathf.Clamp(value, MinimumX, MaximumX);
			q.x = Mathf.Tan((float)Math.PI / 360f * value);
			return q;
		}
	}
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(CapsuleCollider))]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		public class MovementSettings
		{
			public float ForwardSpeed = 8f;

			public float BackwardSpeed = 4f;

			public float StrafeSpeed = 4f;

			public float RunMultiplier = 2f;

			public KeyCode RunKey = KeyCode.LeftShift;

			public float JumpForce = 30f;

			public AnimationCurve SlopeCurveModifier = new AnimationCurve(new Keyframe(-90f, 1f), new Keyframe(0f, 1f), new Keyframe(90f, 0f));

			[HideInInspector]
			public float CurrentTargetSpeed = 8f;

			private bool m_Running;

			public bool Running => m_Running;

			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
				if (!(input == Vector2.zero))
				{
					if (input.x > 0f || input.x < 0f)
					{
						CurrentTargetSpeed = StrafeSpeed;
					}
					if (input.y < 0f)
					{
						CurrentTargetSpeed = BackwardSpeed;
					}
					if (input.y > 0f)
					{
						CurrentTargetSpeed = ForwardSpeed;
					}
					if (Input.GetKey(RunKey))
					{
						CurrentTargetSpeed *= RunMultiplier;
						m_Running = true;
					}
					else
					{
						m_Running = false;
					}
				}
			}
		}

		[Serializable]
		public class AdvancedSettings
		{
			public float groundCheckDistance = 0.01f;

			public float stickToGroundHelperDistance = 0.5f;

			public float slowDownRate = 20f;

			public bool airControl;

			[Tooltip("set it to 0.1 or more if you get stuck in wall")]
			public float shellOffset;
		}

		public Camera cam;

		public MovementSettings movementSettings = new MovementSettings();

		public MouseLook mouseLook = new MouseLook();

		public AdvancedSettings advancedSettings = new AdvancedSettings();

		private Rigidbody m_RigidBody;

		private CapsuleCollider m_Capsule;

		private float m_YRotation;

		private Vector3 m_GroundContactNormal;

		private bool m_Jump;

		private bool m_PreviouslyGrounded;

		private bool m_Jumping;

		private bool m_IsGrounded;

		public Vector3 Velocity => m_RigidBody.velocity;

		public bool Grounded => m_IsGrounded;

		public bool Jumping => m_Jumping;

		public bool Running => movementSettings.Running;

		private void Start()
		{
			m_RigidBody = GetComponent<Rigidbody>();
			m_Capsule = GetComponent<CapsuleCollider>();
			mouseLook.Init(base.transform, cam.transform);
		}

		private void Update()
		{
			RotateView();
			if (CrossPlatformInputManager.GetButtonDown("Jump") && !m_Jump)
			{
				m_Jump = true;
			}
		}

		private void FixedUpdate()
		{
			GroundCheck();
			Vector2 input = GetInput();
			if ((Mathf.Abs(input.x) > float.Epsilon || Mathf.Abs(input.y) > float.Epsilon) && (advancedSettings.airControl || m_IsGrounded))
			{
				Vector3 vector = cam.transform.forward * input.y + cam.transform.right * input.x;
				vector = Vector3.ProjectOnPlane(vector, m_GroundContactNormal).normalized;
				vector.x *= movementSettings.CurrentTargetSpeed;
				vector.z *= movementSettings.CurrentTargetSpeed;
				vector.y *= movementSettings.CurrentTargetSpeed;
				if (m_RigidBody.velocity.sqrMagnitude < movementSettings.CurrentTargetSpeed * movementSettings.CurrentTargetSpeed)
				{
					m_RigidBody.AddForce(vector * SlopeMultiplier(), ForceMode.Impulse);
				}
			}
			if (m_IsGrounded)
			{
				m_RigidBody.drag = 5f;
				if (m_Jump)
				{
					m_RigidBody.drag = 0f;
					m_RigidBody.velocity = new Vector3(m_RigidBody.velocity.x, 0f, m_RigidBody.velocity.z);
					m_RigidBody.AddForce(new Vector3(0f, movementSettings.JumpForce, 0f), ForceMode.Impulse);
					m_Jumping = true;
				}
				if (!m_Jumping && Mathf.Abs(input.x) < float.Epsilon && Mathf.Abs(input.y) < float.Epsilon && m_RigidBody.velocity.magnitude < 1f)
				{
					m_RigidBody.Sleep();
				}
			}
			else
			{
				m_RigidBody.drag = 0f;
				if (m_PreviouslyGrounded && !m_Jumping)
				{
					StickToGroundHelper();
				}
			}
			m_Jump = false;
		}

		private float SlopeMultiplier()
		{
			float time = Vector3.Angle(m_GroundContactNormal, Vector3.up);
			return movementSettings.SlopeCurveModifier.Evaluate(time);
		}

		private void StickToGroundHelper()
		{
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out var hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.stickToGroundHelperDistance, -1, QueryTriggerInteraction.Ignore) && Mathf.Abs(Vector3.Angle(hitInfo.normal, Vector3.up)) < 85f)
			{
				m_RigidBody.velocity = Vector3.ProjectOnPlane(m_RigidBody.velocity, hitInfo.normal);
			}
		}

		private Vector2 GetInput()
		{
			Vector2 vector = default(Vector2);
			vector.x = CrossPlatformInputManager.GetAxis("Horizontal");
			vector.y = CrossPlatformInputManager.GetAxis("Vertical");
			Vector2 vector2 = vector;
			movementSettings.UpdateDesiredTargetSpeed(vector2);
			return vector2;
		}

		private void RotateView()
		{
			if (!(Mathf.Abs(Time.timeScale) < float.Epsilon))
			{
				float y = base.transform.eulerAngles.y;
				mouseLook.LookRotation(base.transform, cam.transform);
				if (m_IsGrounded || advancedSettings.airControl)
				{
					Quaternion quaternion = Quaternion.AngleAxis(base.transform.eulerAngles.y - y, Vector3.up);
					m_RigidBody.velocity = quaternion * m_RigidBody.velocity;
				}
			}
		}

		private void GroundCheck()
		{
			m_PreviouslyGrounded = m_IsGrounded;
			if (Physics.SphereCast(base.transform.position, m_Capsule.radius * (1f - advancedSettings.shellOffset), Vector3.down, out var hitInfo, m_Capsule.height / 2f - m_Capsule.radius + advancedSettings.groundCheckDistance, -1, QueryTriggerInteraction.Ignore))
			{
				m_IsGrounded = true;
				m_GroundContactNormal = hitInfo.normal;
			}
			else
			{
				m_IsGrounded = false;
				m_GroundContactNormal = Vector3.up;
			}
			if (!m_PreviouslyGrounded && m_IsGrounded && m_Jumping)
			{
				m_Jumping = false;
			}
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		public enum UpdateType
		{
			FixedUpdate,
			LateUpdate,
			ManualUpdate
		}

		[SerializeField]
		protected Transform m_Target;

		[SerializeField]
		private bool m_AutoTargetPlayer = true;

		[SerializeField]
		private UpdateType m_UpdateType;

		protected Rigidbody targetRigidbody;

		public Transform Target => m_Target;

		protected virtual void Start()
		{
			if (m_AutoTargetPlayer)
			{
				FindAndTargetPlayer();
			}
			if (!(m_Target == null))
			{
				targetRigidbody = m_Target.GetComponent<Rigidbody>();
			}
		}

		private void FixedUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.FixedUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		private void LateUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.LateUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		public void ManualUpdate()
		{
			if (m_AutoTargetPlayer && (m_Target == null || !m_Target.gameObject.activeSelf))
			{
				FindAndTargetPlayer();
			}
			if (m_UpdateType == UpdateType.ManualUpdate)
			{
				FollowTarget(Time.deltaTime);
			}
		}

		protected abstract void FollowTarget(float deltaTime);

		public void FindAndTargetPlayer()
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			if ((bool)gameObject)
			{
				SetTarget(gameObject.transform);
			}
		}

		public virtual void SetTarget(Transform newTransform)
		{
			m_Target = newTransform;
		}
	}
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[SerializeField]
		private float m_MoveSpeed = 3f;

		[SerializeField]
		private float m_TurnSpeed = 1f;

		[SerializeField]
		private float m_RollSpeed = 0.2f;

		[SerializeField]
		private bool m_FollowVelocity;

		[SerializeField]
		private bool m_FollowTilt = true;

		[SerializeField]
		private float m_SpinTurnLimit = 90f;

		[SerializeField]
		private float m_TargetVelocityLowerLimit = 4f;

		[SerializeField]
		private float m_SmoothTurnTime = 0.2f;

		private float m_LastFlatAngle;

		private float m_CurrentTurnAmount;

		private float m_TurnSpeedVelocityChange;

		private Vector3 m_RollUp = Vector3.up;

		protected override void FollowTarget(float deltaTime)
		{
			if (!(deltaTime > 0f) || m_Target == null)
			{
				return;
			}
			Vector3 forward = m_Target.forward;
			Vector3 up = m_Target.up;
			if (m_FollowVelocity && Application.isPlaying)
			{
				if (targetRigidbody.velocity.magnitude > m_TargetVelocityLowerLimit)
				{
					forward = targetRigidbody.velocity.normalized;
					up = Vector3.up;
				}
				else
				{
					up = Vector3.up;
				}
				m_CurrentTurnAmount = Mathf.SmoothDamp(m_CurrentTurnAmount, 1f, ref m_TurnSpeedVelocityChange, m_SmoothTurnTime);
			}
			else
			{
				float num = Mathf.Atan2(forward.x, forward.z) * 57.29578f;
				if (m_SpinTurnLimit > 0f)
				{
					float value = Mathf.Abs(Mathf.DeltaAngle(m_LastFlatAngle, num)) / deltaTime;
					float num2 = Mathf.InverseLerp(m_SpinTurnLimit, m_SpinTurnLimit * 0.75f, value);
					float smoothTime = ((m_CurrentTurnAmount > num2) ? 0.1f : 1f);
					if (Application.isPlaying)
					{
						m_CurrentTurnAmount = Mathf.SmoothDamp(m_CurrentTurnAmount, num2, ref m_TurnSpeedVelocityChange, smoothTime);
					}
					else
					{
						m_CurrentTurnAmount = num2;
					}
				}
				else
				{
					m_CurrentTurnAmount = 1f;
				}
				m_LastFlatAngle = num;
			}
			base.transform.position = Vector3.Lerp(base.transform.position, m_Target.position, deltaTime * m_MoveSpeed);
			if (!m_FollowTilt)
			{
				forward.y = 0f;
				if (forward.sqrMagnitude < float.Epsilon)
				{
					forward = base.transform.forward;
				}
			}
			Quaternion b = Quaternion.LookRotation(forward, m_RollUp);
			m_RollUp = ((m_RollSpeed > 0f) ? Vector3.Slerp(m_RollUp, up, m_RollSpeed * deltaTime) : Vector3.up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, m_TurnSpeed * m_CurrentTurnAmount * deltaTime);
		}
	}
	public class FreeLookCam : PivotBasedCameraRig
	{
		[SerializeField]
		private float m_MoveSpeed = 1f;

		[Range(0f, 10f)]
		[SerializeField]
		private float m_TurnSpeed = 1.5f;

		[SerializeField]
		private float m_TurnSmoothing;

		[SerializeField]
		private float m_TiltMax = 75f;

		[SerializeField]
		private float m_TiltMin = 45f;

		[SerializeField]
		private bool m_LockCursor;

		[SerializeField]
		private bool m_VerticalAutoReturn;

		private float m_LookAngle;

		private float m_TiltAngle;

		private const float k_LookDistance = 100f;

		private Vector3 m_PivotEulers;

		private Quaternion m_PivotTargetRot;

		private Quaternion m_TransformTargetRot;

		protected override void Awake()
		{
			base.Awake();
			Cursor.lockState = (m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
			Cursor.visible = !m_LockCursor;
			m_PivotEulers = m_Pivot.rotation.eulerAngles;
			m_PivotTargetRot = m_Pivot.transform.localRotation;
			m_TransformTargetRot = base.transform.localRotation;
		}

		protected void Update()
		{
			HandleRotationMovement();
			if (m_LockCursor && Input.GetMouseButtonUp(0))
			{
				Cursor.lockState = (m_LockCursor ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !m_LockCursor;
			}
		}

		private void OnDisable()
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}

		protected override void FollowTarget(float deltaTime)
		{
			if (!(m_Target == null))
			{
				base.transform.position = Vector3.Lerp(base.transform.position, m_Target.position, deltaTime * m_MoveSpeed);
			}
		}

		private void HandleRotationMovement()
		{
			if (!(Time.timeScale < float.Epsilon))
			{
				float axis = CrossPlatformInputManager.GetAxis("Mouse X");
				float axis2 = CrossPlatformInputManager.GetAxis("Mouse Y");
				m_LookAngle += axis * m_TurnSpeed;
				m_TransformTargetRot = Quaternion.Euler(0f, m_LookAngle, 0f);
				if (m_VerticalAutoReturn)
				{
					m_TiltAngle = ((axis2 > 0f) ? Mathf.Lerp(0f, 0f - m_TiltMin, axis2) : Mathf.Lerp(0f, m_TiltMax, 0f - axis2));
				}
				else
				{
					m_TiltAngle -= axis2 * m_TurnSpeed;
					m_TiltAngle = Mathf.Clamp(m_TiltAngle, 0f - m_TiltMin, m_TiltMax);
				}
				m_PivotTargetRot = Quaternion.Euler(m_TiltAngle, m_PivotEulers.y, m_PivotEulers.z);
				if (m_TurnSmoothing > 0f)
				{
					m_Pivot.localRotation = Quaternion.Slerp(m_Pivot.localRotation, m_PivotTargetRot, m_TurnSmoothing * Time.deltaTime);
					base.transform.localRotation = Quaternion.Slerp(base.transform.localRotation, m_TransformTargetRot, m_TurnSmoothing * Time.deltaTime);
				}
				else
				{
					m_Pivot.localRotation = m_PivotTargetRot;
					base.transform.localRotation = m_TransformTargetRot;
				}
			}
		}
	}
	public class HandHeldCam : LookatTarget
	{
		[SerializeField]
		private float m_SwaySpeed = 0.5f;

		[SerializeField]
		private float m_BaseSwayAmount = 0.5f;

		[SerializeField]
		private float m_TrackingSwayAmount = 0.5f;

		[Range(-1f, 1f)]
		[SerializeField]
		private float m_TrackingBias;

		protected override void FollowTarget(float deltaTime)
		{
			base.FollowTarget(deltaTime);
			float num = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed) - 0.5f;
			float num2 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed + 100f) - 0.5f;
			num *= m_BaseSwayAmount;
			num2 *= m_BaseSwayAmount;
			float num3 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed) - 0.5f + m_TrackingBias;
			float num4 = Mathf.PerlinNoise(0f, Time.time * m_SwaySpeed + 100f) - 0.5f + m_TrackingBias;
			num3 *= (0f - m_TrackingSwayAmount) * m_FollowVelocity.x;
			num4 *= m_TrackingSwayAmount * m_FollowVelocity.y;
			base.transform.Rotate(num + num3, num2 + num4, 0f);
		}
	}
	public class LookatTarget : AbstractTargetFollower
	{
		[SerializeField]
		private Vector2 m_RotationRange;

		[SerializeField]
		private float m_FollowSpeed = 1f;

		private Vector3 m_FollowAngles;

		private Quaternion m_OriginalRotation;

		protected Vector3 m_FollowVelocity;

		protected override void Start()
		{
			base.Start();
			m_OriginalRotation = base.transform.localRotation;
		}

		protected override void FollowTarget(float deltaTime)
		{
			base.transform.localRotation = m_OriginalRotation;
			Vector3 vector = base.transform.InverseTransformPoint(m_Target.position);
			float value = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			value = Mathf.Clamp(value, (0f - m_RotationRange.y) * 0.5f, m_RotationRange.y * 0.5f);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f, value, 0f);
			vector = base.transform.InverseTransformPoint(m_Target.position);
			float value2 = Mathf.Atan2(vector.y, vector.z) * 57.29578f;
			value2 = Mathf.Clamp(value2, (0f - m_RotationRange.x) * 0.5f, m_RotationRange.x * 0.5f);
			m_FollowAngles = Vector3.SmoothDamp(target: new Vector3(m_FollowAngles.x + Mathf.DeltaAngle(m_FollowAngles.x, value2), m_FollowAngles.y + Mathf.DeltaAngle(m_FollowAngles.y, value)), current: m_FollowAngles, currentVelocity: ref m_FollowVelocity, smoothTime: m_FollowSpeed);
			base.transform.localRotation = m_OriginalRotation * Quaternion.Euler(0f - m_FollowAngles.x, m_FollowAngles.y, 0f);
		}
	}
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		protected Transform m_Cam;

		protected Transform m_Pivot;

		protected Vector3 m_LastTargetPosition;

		protected virtual void Awake()
		{
			m_Cam = GetComponentInChildren<Camera>().transform;
			m_Pivot = m_Cam.parent;
		}
	}
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		public class RayHitComparer : IComparer
		{
			public int Compare(object x, object y)
			{
				return ((RaycastHit)x).distance.CompareTo(((RaycastHit)y).distance);
			}
		}

		public float clipMoveTime = 0.05f;

		public float returnTime = 0.4f;

		public float sphereCastRadius = 0.1f;

		public bool visualiseInEditor;

		public float closestDistance = 0.5f;

		public string dontClipTag = "Player";

		private Transform m_Cam;

		private Transform m_Pivot;

		private float m_OriginalDist;

		private float m_MoveVelocity;

		private float m_CurrentDist;

		private Ray m_Ray;

		private RaycastHit[] m_Hits;

		private RayHitComparer m_RayHitComparer;

		public bool protecting { get; private set; }

		private void Start()
		{
			m_Cam = GetComponentInChildren<Camera>().transform;
			m_Pivot = m_Cam.parent;
			m_OriginalDist = m_Cam.localPosition.magnitude;
			m_CurrentDist = m_OriginalDist;
			m_RayHitComparer = new RayHitComparer();
		}

		private void LateUpdate()
		{
			float num = m_OriginalDist;
			m_Ray.origin = m_Pivot.position + m_Pivot.forward * sphereCastRadius;
			m_Ray.direction = -m_Pivot.forward;
			Collider[] array = Physics.OverlapSphere(m_Ray.origin, sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				m_Ray.origin += m_Pivot.forward * sphereCastRadius;
				m_Hits = Physics.RaycastAll(m_Ray, m_OriginalDist - sphereCastRadius);
			}
			else
			{
				m_Hits = Physics.SphereCastAll(m_Ray, sphereCastRadius, m_OriginalDist + sphereCastRadius);
			}
			Array.Sort(m_Hits, m_RayHitComparer);
			float num2 = float.PositiveInfinity;
			for (int j = 0; j < m_Hits.Length; j++)
			{
				if (m_Hits[j].distance < num2 && !m_Hits[j].collider.isTrigger && (!(m_Hits[j].collider.attachedRigidbody != null) || !m_Hits[j].collider.attachedRigidbody.CompareTag(dontClipTag)))
				{
					num2 = m_Hits[j].distance;
					num = 0f - m_Pivot.InverseTransformPoint(m_Hits[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				UnityEngine.Debug.DrawRay(m_Ray.origin, -m_Pivot.forward * (num + sphereCastRadius), Color.red);
			}
			protecting = flag2;
			m_CurrentDist = Mathf.SmoothDamp(m_CurrentDist, num, ref m_MoveVelocity, (m_CurrentDist > num) ? clipMoveTime : returnTime);
			m_CurrentDist = Mathf.Clamp(m_CurrentDist, closestDistance, m_OriginalDist);
			m_Cam.localPosition = -Vector3.forward * m_CurrentDist;
		}
	}
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[SerializeField]
		private float m_FovAdjustTime = 1f;

		[SerializeField]
		private float m_ZoomAmountMultiplier = 2f;

		[SerializeField]
		private bool m_IncludeEffectsInSize;

		private float m_BoundSize;

		private float m_FovAdjustVelocity;

		private Camera m_Cam;

		private Transform m_LastTarget;

		protected override void Start()
		{
			base.Start();
			m_BoundSize = MaxBoundsExtent(m_Target, m_IncludeEffectsInSize);
			m_Cam = GetComponentInChildren<Camera>();
		}

		protected override void FollowTarget(float deltaTime)
		{
			float magnitude = (m_Target.position - base.transform.position).magnitude;
			float target = Mathf.Atan2(m_BoundSize, magnitude) * 57.29578f * m_ZoomAmountMultiplier;
			m_Cam.fieldOfView = Mathf.SmoothDamp(m_Cam.fieldOfView, target, ref m_FovAdjustVelocity, m_FovAdjustTime);
		}

		public override void SetTarget(Transform newTransform)
		{
			base.SetTarget(newTransform);
			m_BoundSize = MaxBoundsExtent(newTransform, m_IncludeEffectsInSize);
		}

		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			Renderer[] componentsInChildren = obj.GetComponentsInChildren<Renderer>();
			Bounds bounds = default(Bounds);
			bool flag = false;
			Renderer[] array = componentsInChildren;
			foreach (Renderer renderer in array)
			{
				if (!(renderer is TrailRenderer) && !(renderer is ParticleSystemRenderer))
				{
					if (!flag)
					{
						flag = true;
						bounds = renderer.bounds;
					}
					else
					{
						bounds.Encapsulate(renderer.bounds);
					}
				}
			}
			return Mathf.Max(bounds.extents.x, bounds.extents.y, bounds.extents.z);
		}
	}
}
