using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using UnityEngine;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
[assembly: AssemblyVersion("0.0.0.0")]
[module: UnverifiableCode]
[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook : MonoBehaviour
{
	public enum RotationAxes
	{
		MouseXAndY,
		MouseX,
		MouseY
	}

	public RotationAxes axes;

	public float sensitivityX = 15f;

	public float sensitivityY = 15f;

	public float minimumX = -360f;

	public float maximumX = 360f;

	public float minimumY = -60f;

	public float maximumY = 60f;

	private float rotationY;

	private void Update()
	{
		if (axes == RotationAxes.MouseXAndY)
		{
			float y = base.transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, y, 0f);
		}
		else if (axes == RotationAxes.MouseX)
		{
			base.transform.Rotate(0f, Input.GetAxis("Mouse X") * sensitivityX, 0f);
		}
		else
		{
			rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
			rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);
			base.transform.localEulerAngles = new Vector3(0f - rotationY, base.transform.localEulerAngles.y, 0f);
		}
	}

	private void Start()
	{
		if ((bool)GetComponent<Rigidbody>())
		{
			GetComponent<Rigidbody>().freezeRotation = true;
		}
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
		RenderTexture renderTexture = RenderTexture.GetTemporary(source.width, source.height);
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
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Glow")]
public class GlowEffect : MonoBehaviour
{
	public float glowIntensity = 1.5f;

	public int blurIterations = 3;

	public float blurSpread = 0.7f;

	public Color glowTint = new Color(1f, 1f, 1f, 0f);

	public Shader compositeShader;

	private Material m_CompositeMaterial;

	public Shader blurShader;

	private Material m_BlurMaterial;

	public Shader downsampleShader;

	private Material m_DownsampleMaterial;

	protected Material compositeMaterial
	{
		get
		{
			if (m_CompositeMaterial == null)
			{
				m_CompositeMaterial = new Material(compositeShader);
				m_CompositeMaterial.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_CompositeMaterial;
		}
	}

	protected Material blurMaterial
	{
		get
		{
			if (m_BlurMaterial == null)
			{
				m_BlurMaterial = new Material(blurShader);
				m_BlurMaterial.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_BlurMaterial;
		}
	}

	protected Material downsampleMaterial
	{
		get
		{
			if (m_DownsampleMaterial == null)
			{
				m_DownsampleMaterial = new Material(downsampleShader);
				m_DownsampleMaterial.hideFlags = HideFlags.HideAndDontSave;
			}
			return m_DownsampleMaterial;
		}
	}

	protected void OnDisable()
	{
		if ((bool)m_CompositeMaterial)
		{
			UnityEngine.Object.DestroyImmediate(m_CompositeMaterial);
		}
		if ((bool)m_BlurMaterial)
		{
			UnityEngine.Object.DestroyImmediate(m_BlurMaterial);
		}
		if ((bool)m_DownsampleMaterial)
		{
			UnityEngine.Object.DestroyImmediate(m_DownsampleMaterial);
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
		if (downsampleShader == null)
		{
			Debug.Log("No downsample shader assigned! Disabling glow.");
			base.enabled = false;
			return;
		}
		if (!blurMaterial.shader.isSupported)
		{
			base.enabled = false;
		}
		if (!compositeMaterial.shader.isSupported)
		{
			base.enabled = false;
		}
		if (!downsampleMaterial.shader.isSupported)
		{
			base.enabled = false;
		}
	}

	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
		float num = 0.5f + (float)iteration * blurSpread;
		Graphics.BlitMultiTap(source, dest, blurMaterial, new Vector2(num, num), new Vector2(0f - num, num), new Vector2(num, 0f - num), new Vector2(0f - num, 0f - num));
	}

	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
		downsampleMaterial.color = new Color(glowTint.r, glowTint.g, glowTint.b, glowTint.a / 4f);
		Graphics.Blit(source, dest, downsampleMaterial);
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		glowIntensity = Mathf.Clamp(glowIntensity, 0f, 10f);
		blurIterations = Mathf.Clamp(blurIterations, 0, 30);
		blurSpread = Mathf.Clamp(blurSpread, 0.5f, 1f);
		RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
		DownSample4x(source, temporary);
		float num = Mathf.Clamp01((glowIntensity - 1f) / 4f);
		blurMaterial.color = new Color(1f, 1f, 1f, 0.25f + num);
		bool flag = true;
		for (int i = 0; i < blurIterations; i++)
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
		Graphics.Blit(source, destination);
		if (flag)
		{
			BlitGlow(temporary, destination);
		}
		else
		{
			BlitGlow(temporary2, destination);
		}
		RenderTexture.ReleaseTemporary(temporary);
		RenderTexture.ReleaseTemporary(temporary2);
	}

	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
		compositeMaterial.color = new Color(1f, 1f, 1f, Mathf.Clamp01(glowIntensity));
		Graphics.Blit(source, dest, compositeMaterial);
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
			return (rgbFallback || monochrome) ? m_MaterialRGB : m_MaterialYUV;
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
			Debug.Log("Noise shaders are not set up! Disabling noise effect.");
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
[AddComponentMenu("Image Effects/Sepia Tone")]
public class SepiaToneEffect : ImageEffectBase
{
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		Graphics.Blit(source, destination, base.material);
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
		Material material = new Material(shader);
		material.hideFlags = HideFlags.HideAndDontSave;
		return material;
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
		bool flag = m_Blur > 0;
		Graphics.Blit((!flag) ? source : null, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
		if (flag)
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
[AddComponentMenu("Mesh/Combine Children")]
public class CombineChildren : MonoBehaviour
{
	public bool generateTriangleStrips = true;

	private void Start()
	{
		Component[] componentsInChildren = GetComponentsInChildren(typeof(MeshFilter));
		Matrix4x4 worldToLocalMatrix = base.transform.worldToLocalMatrix;
		Hashtable hashtable = new Hashtable();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			MeshFilter meshFilter = (MeshFilter)componentsInChildren[i];
			Renderer component = componentsInChildren[i].GetComponent<Renderer>();
			MeshCombineUtility.MeshInstance meshInstance = default(MeshCombineUtility.MeshInstance);
			meshInstance.mesh = meshFilter.sharedMesh;
			if (!(component != null) || !component.enabled || !(meshInstance.mesh != null))
			{
				continue;
			}
			meshInstance.transform = worldToLocalMatrix * meshFilter.transform.localToWorldMatrix;
			Material[] sharedMaterials = component.sharedMaterials;
			for (int j = 0; j < sharedMaterials.Length; j++)
			{
				meshInstance.subMeshIndex = Math.Min(j, meshInstance.mesh.subMeshCount - 1);
				ArrayList arrayList = (ArrayList)hashtable[sharedMaterials[j]];
				if (arrayList != null)
				{
					arrayList.Add(meshInstance);
					continue;
				}
				arrayList = new ArrayList();
				arrayList.Add(meshInstance);
				hashtable.Add(sharedMaterials[j], arrayList);
			}
			component.enabled = false;
		}
		foreach (DictionaryEntry item in hashtable)
		{
			ArrayList arrayList2 = (ArrayList)item.Value;
			MeshCombineUtility.MeshInstance[] combines = (MeshCombineUtility.MeshInstance[])arrayList2.ToArray(typeof(MeshCombineUtility.MeshInstance));
			if (hashtable.Count == 1)
			{
				if (GetComponent(typeof(MeshFilter)) == null)
				{
					base.gameObject.AddComponent(typeof(MeshFilter));
				}
				if (!GetComponent("MeshRenderer"))
				{
					base.gameObject.AddComponent<MeshRenderer>();
				}
				MeshFilter meshFilter2 = (MeshFilter)GetComponent(typeof(MeshFilter));
				meshFilter2.mesh = MeshCombineUtility.Combine(combines, generateTriangleStrips);
				GetComponent<Renderer>().material = (Material)item.Key;
				GetComponent<Renderer>().enabled = true;
			}
			else
			{
				GameObject gameObject = new GameObject("Combined mesh");
				gameObject.transform.parent = base.transform;
				gameObject.transform.localScale = Vector3.one;
				gameObject.transform.localRotation = Quaternion.identity;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.AddComponent(typeof(MeshFilter));
				gameObject.AddComponent<MeshRenderer>();
				gameObject.GetComponent<Renderer>().material = (Material)item.Key;
				MeshFilter meshFilter3 = (MeshFilter)gameObject.GetComponent(typeof(MeshFilter));
				meshFilter3.mesh = MeshCombineUtility.Combine(combines, generateTriangleStrips);
			}
		}
	}
}
public class MeshCombineUtility
{
	public struct MeshInstance
	{
		public Mesh mesh;

		public int subMeshIndex;

		public Matrix4x4 transform;
	}

	public static Mesh Combine(MeshInstance[] combines, bool generateStrips)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < combines.Length; i++)
		{
			MeshInstance meshInstance = combines[i];
			if (!meshInstance.mesh)
			{
				continue;
			}
			num += meshInstance.mesh.vertexCount;
			if (!generateStrips)
			{
				continue;
			}
			int num4 = meshInstance.mesh.GetTriangles(meshInstance.subMeshIndex).Length;
			if (num4 != 0)
			{
				if (num3 != 0)
				{
					num3 = (((num3 & 1) != 1) ? (num3 + 2) : (num3 + 3));
				}
				num3 += num4;
			}
			else
			{
				generateStrips = false;
			}
		}
		if (!generateStrips)
		{
			for (int j = 0; j < combines.Length; j++)
			{
				MeshInstance meshInstance2 = combines[j];
				if ((bool)meshInstance2.mesh)
				{
					num2 += meshInstance2.mesh.GetTriangles(meshInstance2.subMeshIndex).Length;
				}
			}
		}
		Vector3[] array = new Vector3[num];
		Vector3[] array2 = new Vector3[num];
		Vector4[] array3 = new Vector4[num];
		Vector2[] array4 = new Vector2[num];
		Vector2[] array5 = new Vector2[num];
		Color[] array6 = new Color[num];
		int[] array7 = new int[num2];
		int[] array8 = new int[num3];
		int offset = 0;
		for (int k = 0; k < combines.Length; k++)
		{
			MeshInstance meshInstance3 = combines[k];
			if ((bool)meshInstance3.mesh)
			{
				Copy(meshInstance3.mesh.vertexCount, meshInstance3.mesh.vertices, array, ref offset, meshInstance3.transform);
			}
		}
		offset = 0;
		for (int l = 0; l < combines.Length; l++)
		{
			MeshInstance meshInstance4 = combines[l];
			if ((bool)meshInstance4.mesh)
			{
				Matrix4x4 transform = meshInstance4.transform;
				transform = transform.inverse.transpose;
				CopyNormal(meshInstance4.mesh.vertexCount, meshInstance4.mesh.normals, array2, ref offset, transform);
			}
		}
		offset = 0;
		for (int m = 0; m < combines.Length; m++)
		{
			MeshInstance meshInstance5 = combines[m];
			if ((bool)meshInstance5.mesh)
			{
				Matrix4x4 transform2 = meshInstance5.transform;
				transform2 = transform2.inverse.transpose;
				CopyTangents(meshInstance5.mesh.vertexCount, meshInstance5.mesh.tangents, array3, ref offset, transform2);
			}
		}
		offset = 0;
		for (int n = 0; n < combines.Length; n++)
		{
			MeshInstance meshInstance6 = combines[n];
			if ((bool)meshInstance6.mesh)
			{
				Copy(meshInstance6.mesh.vertexCount, meshInstance6.mesh.uv, array4, ref offset);
			}
		}
		offset = 0;
		for (int num5 = 0; num5 < combines.Length; num5++)
		{
			MeshInstance meshInstance7 = combines[num5];
			if ((bool)meshInstance7.mesh)
			{
				Copy(meshInstance7.mesh.vertexCount, meshInstance7.mesh.uv2, array5, ref offset);
			}
		}
		offset = 0;
		for (int num6 = 0; num6 < combines.Length; num6++)
		{
			MeshInstance meshInstance8 = combines[num6];
			if ((bool)meshInstance8.mesh)
			{
				CopyColors(meshInstance8.mesh.vertexCount, meshInstance8.mesh.colors, array6, ref offset);
			}
		}
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		for (int num10 = 0; num10 < combines.Length; num10++)
		{
			MeshInstance meshInstance9 = combines[num10];
			if (!meshInstance9.mesh)
			{
				continue;
			}
			if (generateStrips)
			{
				int[] triangles = meshInstance9.mesh.GetTriangles(meshInstance9.subMeshIndex);
				if (num8 != 0)
				{
					if ((num8 & 1) == 1)
					{
						array8[num8] = array8[num8 - 1];
						array8[num8 + 1] = triangles[0] + num9;
						array8[num8 + 2] = triangles[0] + num9;
						num8 += 3;
					}
					else
					{
						array8[num8] = array8[num8 - 1];
						array8[num8 + 1] = triangles[0] + num9;
						num8 += 2;
					}
				}
				for (int num11 = 0; num11 < triangles.Length; num11++)
				{
					array8[num11 + num8] = triangles[num11] + num9;
				}
				num8 += triangles.Length;
			}
			else
			{
				int[] triangles2 = meshInstance9.mesh.GetTriangles(meshInstance9.subMeshIndex);
				for (int num12 = 0; num12 < triangles2.Length; num12++)
				{
					array7[num12 + num7] = triangles2[num12] + num9;
				}
				num7 += triangles2.Length;
			}
			num9 += meshInstance9.mesh.vertexCount;
		}
		Mesh mesh = new Mesh();
		mesh.name = "Combined Mesh";
		mesh.vertices = array;
		mesh.normals = array2;
		mesh.colors = array6;
		mesh.uv = array4;
		mesh.uv2 = array5;
		mesh.tangents = array3;
		if (generateStrips)
		{
			mesh.SetTriangles(array8, 0);
		}
		else
		{
			mesh.triangles = array7;
		}
		return mesh;
	}

	private static void Copy(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
		for (int i = 0; i < src.Length; i++)
		{
			ref Vector3 reference = ref dst[i + offset];
			reference = transform.MultiplyPoint(src[i]);
		}
		offset += vertexcount;
	}

	private static void CopyNormal(int vertexcount, Vector3[] src, Vector3[] dst, ref int offset, Matrix4x4 transform)
	{
		for (int i = 0; i < src.Length; i++)
		{
			ref Vector3 reference = ref dst[i + offset];
			reference = transform.MultiplyVector(src[i]).normalized;
		}
		offset += vertexcount;
	}

	private static void Copy(int vertexcount, Vector2[] src, Vector2[] dst, ref int offset)
	{
		for (int i = 0; i < src.Length; i++)
		{
			ref Vector2 reference = ref dst[i + offset];
			reference = src[i];
		}
		offset += vertexcount;
	}

	private static void CopyColors(int vertexcount, Color[] src, Color[] dst, ref int offset)
	{
		for (int i = 0; i < src.Length; i++)
		{
			ref Color reference = ref dst[i + offset];
			reference = src[i];
		}
		offset += vertexcount;
	}

	private static void CopyTangents(int vertexcount, Vector4[] src, Vector4[] dst, ref int offset, Matrix4x4 transform)
	{
		for (int i = 0; i < src.Length; i++)
		{
			Vector4 vector = src[i];
			Vector3 vector2 = new Vector3(vector.x, vector.y, vector.z);
			vector2 = transform.MultiplyVector(vector2).normalized;
			ref Vector4 reference = ref dst[i + offset];
			reference = new Vector4(vector2.x, vector2.y, vector2.z, vector.w);
		}
		offset += vertexcount;
	}
}
